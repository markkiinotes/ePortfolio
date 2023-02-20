'''
Created on Feb 19, 2023

@author: markk
'''
import mysql.connector
from Paint_py import name, email, wWidth, wHeight, gallonsPaintNeeded, cansNeeded

def connect():
    db = mysql.connector.connect(
      host="localhost",
      user="users",
      password="password",
      database = "mydatabase"
    )

    mycursor = db.cursor()

    if(mycursor == ""):
        mycursor.execute("CREATE DATABASE mydatabase")
        mycursor.execute("CREATE TABLE searches (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(255), email VARCHAR(255), width VARCHAR(255), height VARCHAR(255), area VAARCHAR(255), total_paint VARCHAR(255), cans_needed VARCHAR(255)")

def insert(name,email,wWidth,wHeight,gallonsPaintNeeded,cansNeeded):
    db = mysql.connector.connect(
      host="localhost",
      user="users",
      password="password",
      database = "mydatabase"
    )

    mycursor = db.cursor()
    
    sql = "INSERT INTO searches (name,email,width,height,area,total_paint,cans_needed VALUES(%s,%s,%d,%d,%d,%d)"
    val = (name,email,wWidth,wHeight,gallonsPaintNeeded,cansNeeded)
    mycursor.execute(sql,val)
    db.commit(
        )