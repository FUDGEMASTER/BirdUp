using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.IO;
using System.Net;
using System.Data.SQLite;

namespace BirdUp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//Initiate clock
			timer1.Start();
			//Hide weather labels until button click
			tempLbl.Visible = false;
			cityLbl.Visible = false;
			sunRiseLbl.Visible = false;
			sunSetLbl.Visible = false;
			windDirLbl.Visible = false;
			windSpdLbl.Visible = false;
			lastUpdateLbl.Visible = false;
			weatherValLbl.Visible = false;
			saveSucc.Visible = false;
			//Open DB on startup
			UpdateTable();
			//Load Feed Data
			UpdateFeedComboBox();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			if (zipBox.Text == "Enter Zip Code")
			{
				zipBox.Text = "";

				zipBox.ForeColor = Color.Black;
			}
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (zipBox.Text == "")
			{
				zipBox.Text = "Enter Zip Code";

				zipBox.ForeColor = Color.Silver;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.Now;
			this.timeLbl.Text = dateTime.ToString();
		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		//WEATHER APP
		private async void button1_Click(object sender, EventArgs e)
		{
			//ZIP CODE TRY/CATCH
			try
			{
				string weburlTC = "http://api.openweathermap.org/data/2.5/weather?zip=" + zipBox.Text + "&appid=e700e5bdb963292f9c06c472d6dd9017" + "&mode=xml";
				var xmlTC = await new WebClient().DownloadStringTaskAsync(new Uri(weburlTC));
			}
			catch (WebException ex)
			{
				if (ex.Status == WebExceptionStatus.ProtocolError &&
					ex.Response != null)
				{
					var resp = (HttpWebResponse)ex.Response;
					if (resp.StatusCode == HttpStatusCode.NotFound)
					{
						MessageBox.Show("Zip Code Not Found", "Weather App Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
						zipBox.Text = "";
						if (zipBox.Text == "")
						{
							zipBox.Text = "Enter Zip Code";

							zipBox.ForeColor = Color.Silver;
						}
						return;
					}
					else
					{
						MessageBox.Show("Fatal Error: Program Will Now Exit", "Weather App Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();
					}
				}
				else
				{
					MessageBox.Show("Fatal Error: Program Will Now Exit", "Weather App Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
				}
			}
			//ZIP CODE TRY/CATCH^^

			string weburl = "http://api.openweathermap.org/data/2.5/weather?zip=" + zipBox.Text + "&appid=e700e5bdb963292f9c06c472d6dd9017" + "&mode=xml";
			var xml = await new WebClient().DownloadStringTaskAsync(new Uri(weburl));
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xml);
			//Temp
			string szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
			double temp = double.Parse(szTemp) - 273.16;
			temp = temp * 1.8 + 32;
			tempLbl.Text = temp.ToString("N0") + "° F";
			//City Name
			string cityName = doc.DocumentElement.SelectSingleNode("city").Attributes["name"].Value;
			cityLbl.Text = cityName;
			//Sunrise
			string sunRise = doc.DocumentElement.SelectSingleNode("city").SelectSingleNode("sun").Attributes["rise"].Value;
			DateTime conSunRise = DateTime.Parse(sunRise);
			conSunRise = conSunRise.AddHours(-4);
			sunRise = conSunRise.ToString();
			sunRise = sunRise.Remove(0, 9);
			sunRiseLbl.Text = sunRise;
			//Sunset
			string sunSet = doc.DocumentElement.SelectSingleNode("city").SelectSingleNode("sun").Attributes["set"].Value;
			DateTime conSunSet = DateTime.Parse(sunSet);
			conSunSet = conSunSet.AddHours(-4);
			sunSet = conSunSet.ToString();
			sunSet = sunSet.Remove(0, 9);
			sunSetLbl.Text = sunSet;
			//Wind Speed
			string szSpd = doc.DocumentElement.SelectSingleNode("wind").SelectSingleNode("speed").Attributes["value"].Value;
			double windSpd = double.Parse(szSpd) * 2.2;
			windSpdLbl.Text = windSpd.ToString("N1") + " mph";

			//WIND DIR TRY CATCH
			try
			{
				//Wind Direction
				string windDir = doc.DocumentElement.SelectSingleNode("wind").SelectSingleNode("direction").Attributes["code"].Value;
				windDirLbl.Text = windDir;
			}

			catch
			{
				windDirLbl.Text = "No Wind";
				windSpdLbl.Text = "";
			}
			//WIND DIR TRY CATCH^^

			//Last Update
			string LastUp = doc.DocumentElement.SelectSingleNode("lastupdate").Attributes["value"].Value;
			DateTime conLastUp = DateTime.Parse(LastUp);
			conLastUp = conLastUp.AddHours(-4);
			LastUp = conLastUp.ToString();
			LastUp = LastUp.Remove(0, 9);
			lastUpdateLbl.Text = LastUp;
			//Weather Value
			string weatherValue = doc.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;
			weatherValue = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(weatherValue.ToLower());
			weatherValue = " " + weatherValue;
			weatherValLbl.Text = weatherValue;

			//Display weather labels after button click
			tempLbl.Visible = true;
			cityLbl.Visible = true;
			sunRiseLbl.Visible = true;
			sunSetLbl.Visible = true;
			windDirLbl.Visible = true;
			windSpdLbl.Visible = true;
			lastUpdateLbl.Visible = true;
			weatherValLbl.Visible = true;
	
		}
		//WEATHER APP^^

		//Update and run DB
		private void UpdateTable()
		{
			//connection object
			SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\Owner\Desktop\updatedBird.db");
			con.Open();
			//command object
			string query = "SELECT* from Recognizable";
			SQLiteCommand cmd = new SQLiteCommand(query, con);
			//adapter
			//datatable
			DataTable dt = new DataTable();
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
			adapter.Fill(dt);
			dataGridRecognizable.DataSource = dt;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UpdateTable();
		}
		//Update and run DB^^^

		//Update Feed Data Boxes
		private void UpdateFeedComboBox()
		{
			SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\Owner\Desktop\updatedBird.db");
			con.Open();
			SQLiteCommand cmd = new SQLiteCommand("SELECT feed_Type from Feed_Mix order by Feed_Type", con);
			SQLiteDataReader reader;
			reader = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("feed_Type", typeof(string));
			dt.Load(reader);
			typeCBox.ValueMember = "feed_Type";
			typeCBox.DataSource = dt;
			con.Close();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			string result = "";
			SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\Owner\Desktop\updateBird.db");
			con.Open();
			SQLiteCommand cmd = con.CreateCommand();
			cmd.CommandText = "SELECT COUNT(feed_Id) FROM Feed_Mix";
			result = cmd.ExecuteScalar().ToString();
			int feedId = int.Parse(result);

			feedId++;
			SQLiteCommand insertSQL = con.CreateCommand();
			insertSQL.CommandText = "INSERT INTO Feed_Mix (feed_Id, feed_Type) VALUES (" + feedId + ", '" + textBox1.Text + "')";
			insertSQL.ExecuteNonQuery();
			con.Close();

			UpdateFeedComboBox();
		}
		//Update Feed Data Boxes^^

		//File Browsing
		private void button4_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png *.jfif;)| *.jpg; *.jpeg; *.gif; *.bmp; *.png; *.jfif;";
			if(open.ShowDialog() == DialogResult.OK)
			{
				browseBox.Text = open.FileName;
				pictureBox1.Image = new Bitmap(open.FileName);
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox2.Image = new Bitmap(open.FileName);
				pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}
		private void button5_Click(object sender, EventArgs e)
		{
			File.Copy(browseBox.Text, Path.Combine(@"C:\Users\Owner\source\repos\BirdUp1\BirdUp1\Images\", Path.GetFileName(browseBox.Text)), true);
			saveSucc.Visible = true;
			var t = new Timer();
			t.Interval = 5000;
			t.Tick += (s, c) =>
			{
				saveSucc.Visible = false;
				t.Stop();
			};
			t.Start();
		}
		//File Browsing^^
	}
}