namespace BirdUp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.saveSucc = new System.Windows.Forms.Label();
            this.ImageBrowserHead = new System.Windows.Forms.Label();
            this.SaveFileButt = new System.Windows.Forms.Button();
            this.OpenFileButt = new System.Windows.Forms.Button();
            this.browseBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priceCBox = new System.Windows.Forms.ComboBox();
            this.brandCBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.brandLbl = new System.Windows.Forms.Label();
            this.addDataButt = new System.Windows.Forms.Button();
            this.typeCBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.FeedDataHead = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.WelcomeHead = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BirdDataHead = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WeatherHead = new System.Windows.Forms.Label();
            this.LastUpdated = new System.Windows.Forms.Label();
            this.Conditions = new System.Windows.Forms.Label();
            this.SunSet = new System.Windows.Forms.Label();
            this.SunRise = new System.Windows.Forms.Label();
            this.WindDirSpd = new System.Windows.Forms.Label();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.weatherValLbl = new System.Windows.Forms.Label();
            this.lastUpdateLbl = new System.Windows.Forms.Label();
            this.windDirLbl = new System.Windows.Forms.Label();
            this.windSpdLbl = new System.Windows.Forms.Label();
            this.sunSetLbl = new System.Windows.Forms.Label();
            this.sunRiseLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.WeatherButt = new System.Windows.Forms.Button();
            this.tempLbl = new System.Windows.Forms.Label();
            this.Recognized = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Recognizable = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridRecognizable = new System.Windows.Forms.DataGridView();
            this.Help = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Recognized.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Recognizable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecognizable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Recognized);
            this.tabControl1.Controls.Add(this.Recognizable);
            this.tabControl1.Controls.Add(this.Help);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.panel6);
            this.Home.Controls.Add(this.panel2);
            this.Home.Controls.Add(this.panel5);
            this.Home.Controls.Add(this.panel4);
            this.Home.Controls.Add(this.panel3);
            this.Home.Controls.Add(this.panel1);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1031, 656);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.saveSucc);
            this.panel6.Controls.Add(this.ImageBrowserHead);
            this.panel6.Controls.Add(this.SaveFileButt);
            this.panel6.Controls.Add(this.OpenFileButt);
            this.panel6.Controls.Add(this.browseBox);
            this.panel6.Location = new System.Drawing.Point(478, 420);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(550, 91);
            this.panel6.TabIndex = 4;
            // 
            // saveSucc
            // 
            this.saveSucc.AutoSize = true;
            this.saveSucc.Location = new System.Drawing.Point(430, 18);
            this.saveSucc.Name = "saveSucc";
            this.saveSucc.Size = new System.Drawing.Size(112, 17);
            this.saveSucc.TabIndex = 24;
            this.saveSucc.Text = "Save Successful";
            // 
            // ImageBrowserHead
            // 
            this.ImageBrowserHead.AutoSize = true;
            this.ImageBrowserHead.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageBrowserHead.Location = new System.Drawing.Point(197, 9);
            this.ImageBrowserHead.Name = "ImageBrowserHead";
            this.ImageBrowserHead.Size = new System.Drawing.Size(155, 28);
            this.ImageBrowserHead.TabIndex = 23;
            this.ImageBrowserHead.Text = "Image Browser";
            // 
            // SaveFileButt
            // 
            this.SaveFileButt.Location = new System.Drawing.Point(467, 42);
            this.SaveFileButt.Name = "SaveFileButt";
            this.SaveFileButt.Size = new System.Drawing.Size(75, 32);
            this.SaveFileButt.TabIndex = 2;
            this.SaveFileButt.Text = "Save";
            this.SaveFileButt.UseVisualStyleBackColor = true;
            this.SaveFileButt.Click += new System.EventHandler(this.button5_Click);
            // 
            // OpenFileButt
            // 
            this.OpenFileButt.Location = new System.Drawing.Point(8, 43);
            this.OpenFileButt.Name = "OpenFileButt";
            this.OpenFileButt.Size = new System.Drawing.Size(75, 31);
            this.OpenFileButt.TabIndex = 1;
            this.OpenFileButt.Text = "Open";
            this.OpenFileButt.UseVisualStyleBackColor = true;
            this.OpenFileButt.Click += new System.EventHandler(this.button4_Click);
            // 
            // browseBox
            // 
            this.browseBox.Location = new System.Drawing.Point(89, 47);
            this.browseBox.Name = "browseBox";
            this.browseBox.Size = new System.Drawing.Size(372, 22);
            this.browseBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.priceCBox);
            this.panel2.Controls.Add(this.brandCBox);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.priceLbl);
            this.panel2.Controls.Add(this.brandLbl);
            this.panel2.Controls.Add(this.addDataButt);
            this.panel2.Controls.Add(this.typeCBox);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.typeLbl);
            this.panel2.Controls.Add(this.FeedDataHead);
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 271);
            this.panel2.TabIndex = 5;
            // 
            // priceCBox
            // 
            this.priceCBox.FormattingEnabled = true;
            this.priceCBox.Location = new System.Drawing.Point(237, 155);
            this.priceCBox.Name = "priceCBox";
            this.priceCBox.Size = new System.Drawing.Size(188, 24);
            this.priceCBox.TabIndex = 33;
            // 
            // brandCBox
            // 
            this.brandCBox.FormattingEnabled = true;
            this.brandCBox.Location = new System.Drawing.Point(237, 105);
            this.brandCBox.Name = "brandCBox";
            this.brandCBox.Size = new System.Drawing.Size(188, 24);
            this.brandCBox.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 22);
            this.textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 22);
            this.textBox2.TabIndex = 30;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(15, 158);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(44, 17);
            this.priceLbl.TabIndex = 29;
            this.priceLbl.Text = "Price:";
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Location = new System.Drawing.Point(15, 108);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(50, 17);
            this.brandLbl.TabIndex = 28;
            this.brandLbl.Text = "Brand:";
            // 
            // addDataButt
            // 
            this.addDataButt.Location = new System.Drawing.Point(91, 198);
            this.addDataButt.Name = "addDataButt";
            this.addDataButt.Size = new System.Drawing.Size(75, 25);
            this.addDataButt.TabIndex = 27;
            this.addDataButt.Text = "Add Data";
            this.addDataButt.UseVisualStyleBackColor = true;
            this.addDataButt.Click += new System.EventHandler(this.button3_Click);
            // 
            // typeCBox
            // 
            this.typeCBox.FormattingEnabled = true;
            this.typeCBox.Location = new System.Drawing.Point(237, 56);
            this.typeCBox.Name = "typeCBox";
            this.typeCBox.Size = new System.Drawing.Size(188, 24);
            this.typeCBox.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 25;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(15, 61);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(44, 17);
            this.typeLbl.TabIndex = 24;
            this.typeLbl.Text = "Type:";
            // 
            // FeedDataHead
            // 
            this.FeedDataHead.AutoSize = true;
            this.FeedDataHead.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedDataHead.Location = new System.Drawing.Point(180, 13);
            this.FeedDataHead.Name = "FeedDataHead";
            this.FeedDataHead.Size = new System.Drawing.Size(106, 28);
            this.FeedDataHead.TabIndex = 22;
            this.FeedDataHead.Text = "Feed Data";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.WelcomeHead);
            this.panel5.Controls.Add(this.timeLbl);
            this.panel5.Location = new System.Drawing.Point(0, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(472, 91);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // WelcomeHead
            // 
            this.WelcomeHead.AutoSize = true;
            this.WelcomeHead.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeHead.Location = new System.Drawing.Point(114, 9);
            this.WelcomeHead.Name = "WelcomeHead";
            this.WelcomeHead.Size = new System.Drawing.Size(237, 33);
            this.WelcomeHead.TabIndex = 1;
            this.WelcomeHead.Text = "Welcome to BirdUp!";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Black;
            this.timeLbl.Location = new System.Drawing.Point(134, 42);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(49, 24);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "Time";
            this.timeLbl.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BirdDataHead);
            this.panel4.Location = new System.Drawing.Point(478, 517);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 134);
            this.panel4.TabIndex = 1;
            // 
            // BirdDataHead
            // 
            this.BirdDataHead.AutoSize = true;
            this.BirdDataHead.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirdDataHead.Location = new System.Drawing.Point(224, 10);
            this.BirdDataHead.Name = "BirdDataHead";
            this.BirdDataHead.Size = new System.Drawing.Size(101, 28);
            this.BirdDataHead.TabIndex = 22;
            this.BirdDataHead.Text = "Bird Data";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(478, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 408);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.WeatherHead);
            this.panel1.Controls.Add(this.LastUpdated);
            this.panel1.Controls.Add(this.Conditions);
            this.panel1.Controls.Add(this.SunSet);
            this.panel1.Controls.Add(this.SunRise);
            this.panel1.Controls.Add(this.WindDirSpd);
            this.panel1.Controls.Add(this.zipBox);
            this.panel1.Controls.Add(this.weatherValLbl);
            this.panel1.Controls.Add(this.lastUpdateLbl);
            this.panel1.Controls.Add(this.windDirLbl);
            this.panel1.Controls.Add(this.windSpdLbl);
            this.panel1.Controls.Add(this.sunSetLbl);
            this.panel1.Controls.Add(this.sunRiseLbl);
            this.panel1.Controls.Add(this.cityLbl);
            this.panel1.Controls.Add(this.WeatherButt);
            this.panel1.Controls.Add(this.tempLbl);
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 271);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // WeatherHead
            // 
            this.WeatherHead.AutoSize = true;
            this.WeatherHead.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherHead.Location = new System.Drawing.Point(180, 17);
            this.WeatherHead.Name = "WeatherHead";
            this.WeatherHead.Size = new System.Drawing.Size(94, 28);
            this.WeatherHead.TabIndex = 21;
            this.WeatherHead.Text = "Weather";
            // 
            // LastUpdated
            // 
            this.LastUpdated.AutoSize = true;
            this.LastUpdated.Location = new System.Drawing.Point(237, 212);
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.Size = new System.Drawing.Size(97, 17);
            this.LastUpdated.TabIndex = 26;
            this.LastUpdated.Text = "Last Updated:";
            // 
            // Conditions
            // 
            this.Conditions.AutoSize = true;
            this.Conditions.Location = new System.Drawing.Point(237, 133);
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(78, 17);
            this.Conditions.TabIndex = 25;
            this.Conditions.Text = "Conditions:";
            // 
            // SunSet
            // 
            this.SunSet.AutoSize = true;
            this.SunSet.Location = new System.Drawing.Point(237, 88);
            this.SunSet.Name = "SunSet";
            this.SunSet.Size = new System.Drawing.Size(62, 17);
            this.SunSet.TabIndex = 24;
            this.SunSet.Text = "Sun Set:";
            // 
            // SunRise
            // 
            this.SunRise.AutoSize = true;
            this.SunRise.Location = new System.Drawing.Point(237, 65);
            this.SunRise.Name = "SunRise";
            this.SunRise.Size = new System.Drawing.Size(69, 17);
            this.SunRise.TabIndex = 23;
            this.SunRise.Text = "Sun Rise:";
            // 
            // WindDirSpd
            // 
            this.WindDirSpd.AutoSize = true;
            this.WindDirSpd.Location = new System.Drawing.Point(18, 110);
            this.WindDirSpd.Name = "WindDirSpd";
            this.WindDirSpd.Size = new System.Drawing.Size(145, 17);
            this.WindDirSpd.TabIndex = 22;
            this.WindDirSpd.Text = "Wind Direction/Speed";
            // 
            // zipBox
            // 
            this.zipBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.zipBox.Location = new System.Drawing.Point(14, 209);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(100, 22);
            this.zipBox.TabIndex = 20;
            this.zipBox.Text = "Enter Zip Code";
            this.zipBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.zipBox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // weatherValLbl
            // 
            this.weatherValLbl.AutoSize = true;
            this.weatherValLbl.ForeColor = System.Drawing.Color.Red;
            this.weatherValLbl.Location = new System.Drawing.Point(345, 133);
            this.weatherValLbl.Name = "weatherValLbl";
            this.weatherValLbl.Size = new System.Drawing.Size(78, 17);
            this.weatherValLbl.TabIndex = 19;
            this.weatherValLbl.Text = "weatherVal";
            this.weatherValLbl.Click += new System.EventHandler(this.label8_Click);
            // 
            // lastUpdateLbl
            // 
            this.lastUpdateLbl.AutoSize = true;
            this.lastUpdateLbl.ForeColor = System.Drawing.Color.Red;
            this.lastUpdateLbl.Location = new System.Drawing.Point(347, 212);
            this.lastUpdateLbl.Name = "lastUpdateLbl";
            this.lastUpdateLbl.Size = new System.Drawing.Size(76, 17);
            this.lastUpdateLbl.TabIndex = 18;
            this.lastUpdateLbl.Text = "lastUpdate";
            // 
            // windDirLbl
            // 
            this.windDirLbl.AutoSize = true;
            this.windDirLbl.ForeColor = System.Drawing.Color.Red;
            this.windDirLbl.Location = new System.Drawing.Point(28, 133);
            this.windDirLbl.Name = "windDirLbl";
            this.windDirLbl.Size = new System.Drawing.Size(54, 17);
            this.windDirLbl.TabIndex = 17;
            this.windDirLbl.Text = "windDir";
            // 
            // windSpdLbl
            // 
            this.windSpdLbl.AutoSize = true;
            this.windSpdLbl.ForeColor = System.Drawing.Color.Red;
            this.windSpdLbl.Location = new System.Drawing.Point(88, 133);
            this.windSpdLbl.Name = "windSpdLbl";
            this.windSpdLbl.Size = new System.Drawing.Size(61, 17);
            this.windSpdLbl.TabIndex = 16;
            this.windSpdLbl.Text = "windSpd";
            // 
            // sunSetLbl
            // 
            this.sunSetLbl.AutoSize = true;
            this.sunSetLbl.ForeColor = System.Drawing.Color.Red;
            this.sunSetLbl.Location = new System.Drawing.Point(345, 88);
            this.sunSetLbl.Name = "sunSetLbl";
            this.sunSetLbl.Size = new System.Drawing.Size(52, 17);
            this.sunSetLbl.TabIndex = 14;
            this.sunSetLbl.Text = "sunSet";
            this.sunSetLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // sunRiseLbl
            // 
            this.sunRiseLbl.AutoSize = true;
            this.sunRiseLbl.ForeColor = System.Drawing.Color.Red;
            this.sunRiseLbl.Location = new System.Drawing.Point(345, 65);
            this.sunRiseLbl.Name = "sunRiseLbl";
            this.sunRiseLbl.Size = new System.Drawing.Size(59, 17);
            this.sunRiseLbl.TabIndex = 13;
            this.sunRiseLbl.Text = "sunRise";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.ForeColor = System.Drawing.Color.Red;
            this.cityLbl.Location = new System.Drawing.Point(85, 65);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(29, 17);
            this.cityLbl.TabIndex = 12;
            this.cityLbl.Text = "city";
            // 
            // WeatherButt
            // 
            this.WeatherButt.Location = new System.Drawing.Point(120, 206);
            this.WeatherButt.Name = "WeatherButt";
            this.WeatherButt.Size = new System.Drawing.Size(74, 29);
            this.WeatherButt.TabIndex = 9;
            this.WeatherButt.Text = "Update";
            this.WeatherButt.UseVisualStyleBackColor = true;
            this.WeatherButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.ForeColor = System.Drawing.Color.Red;
            this.tempLbl.Location = new System.Drawing.Point(28, 65);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(39, 17);
            this.tempLbl.TabIndex = 10;
            this.tempLbl.Text = "temp";
            // 
            // Recognized
            // 
            this.Recognized.Controls.Add(this.dataGridView1);
            this.Recognized.Controls.Add(this.panel9);
            this.Recognized.Controls.Add(this.panel7);
            this.Recognized.Location = new System.Drawing.Point(4, 25);
            this.Recognized.Name = "Recognized";
            this.Recognized.Padding = new System.Windows.Forms.Padding(3);
            this.Recognized.Size = new System.Drawing.Size(1031, 656);
            this.Recognized.TabIndex = 1;
            this.Recognized.Text = "Recognized";
            this.Recognized.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 645);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label21);
            this.panel9.Location = new System.Drawing.Point(479, 422);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(546, 229);
            this.panel9.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(224, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 28);
            this.label21.TabIndex = 22;
            this.label21.Text = "Bird Data";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Location = new System.Drawing.Point(479, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(546, 410);
            this.panel7.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(539, 402);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Recognizable
            // 
            this.Recognizable.Controls.Add(this.button2);
            this.Recognizable.Controls.Add(this.dataGridRecognizable);
            this.Recognizable.Location = new System.Drawing.Point(4, 25);
            this.Recognizable.Name = "Recognizable";
            this.Recognizable.Padding = new System.Windows.Forms.Padding(3);
            this.Recognizable.Size = new System.Drawing.Size(1031, 656);
            this.Recognizable.TabIndex = 2;
            this.Recognizable.Text = "Recognizable";
            this.Recognizable.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridRecognizable
            // 
            this.dataGridRecognizable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecognizable.Location = new System.Drawing.Point(6, 6);
            this.dataGridRecognizable.Name = "dataGridRecognizable";
            this.dataGridRecognizable.RowHeadersWidth = 51;
            this.dataGridRecognizable.RowTemplate.Height = 24;
            this.dataGridRecognizable.Size = new System.Drawing.Size(1019, 644);
            this.dataGridRecognizable.TabIndex = 0;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(4, 25);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3);
            this.Help.Size = new System.Drawing.Size(1031, 656);
            this.Help.TabIndex = 3;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 683);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BirdUp!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Recognized.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Recognizable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecognizable)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Recognized;
		private System.Windows.Forms.TabPage Recognizable;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button WeatherButt;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label sunRiseLbl;
        private System.Windows.Forms.Label sunSetLbl;
        private System.Windows.Forms.Label windDirLbl;
        private System.Windows.Forms.Label windSpdLbl;
        private System.Windows.Forms.Label lastUpdateLbl;
        private System.Windows.Forms.Label weatherValLbl;
        private System.Windows.Forms.Label WeatherHead;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label WelcomeHead;
        private System.Windows.Forms.Label WindDirSpd;
        private System.Windows.Forms.Label FeedDataHead;
        private System.Windows.Forms.Label BirdDataHead;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label SunSet;
        private System.Windows.Forms.Label SunRise;
        private System.Windows.Forms.Label LastUpdated;
        private System.Windows.Forms.Label Conditions;
        private System.Windows.Forms.DataGridView dataGridRecognizable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox typeCBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addDataButt;
        private System.Windows.Forms.Label ImageBrowserHead;
        private System.Windows.Forms.Button SaveFileButt;
        private System.Windows.Forms.Button OpenFileButt;
        private System.Windows.Forms.TextBox browseBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label saveSucc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.ComboBox priceCBox;
        private System.Windows.Forms.ComboBox brandCBox;
    }
}

