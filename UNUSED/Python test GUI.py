import sqlite3
import os
from pathlib import Path
import PySimpleGUI as sg

"""
This is meant to test the communication between the CV model and the GUI 
when going through the database.

"""
this_file = os.path.abspath(os.path.dirname(__file__))
database = this_file / Path(r'deployment.db')

layout = [
    [sg.Text("Press SEND to send the following text to the database")],
    [sg.Input("TEST SENTENCE", key='text')],
    [sg.Button('SEND')]
]

window = sg.Window("TEST PYTHON TO DATABASE", layout)


con = sqlite3.connect(database)
c = con.cursor()
while True:
    event, values = window.Read(timeout=0)
    if event in (None, ""):
        break
    elif event == 'SEND':
        c.execute('INSERT INTO Entry(entry_Id, common_Name, wiki_link, conservation_Status, eats, place_Seen, time_stamp) VALUES ("{}", "", "","","","","")'.format(values['text']))
        con.commit()
        sg.Popup('Entry added, please check DB')