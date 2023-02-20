'''
    @created:  Jan 23, 2023 ---> Feburary 19,2023
    @title:    Paint (ePortfolio)
    @author:   George M Harrison Jr
    @description: This program was rewritten from Java to Python and given a gui. This program takes the users
                  name, email, wall width (wWidth) and wall height (wHeight). Calculates the Area of the wall.
                  Calculates the amount of paint needed to cover the Area. Then Calculates how many cans of paint
                  will be needed to have enough to cover wall by rounding up to the nearest whole number.
                  Once all calculations are performed, the user data will be stored for callback to user.
'''

''' Import all necessary components.
'''
from tkinter import *
from tkinter import ttk
from tkinter.messagebox import askyesno
import math
from _winapi import NULL
import mysql_connector
import re
 
'''Make a regular expression for validating an Email'''

regex = r'\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,7}\b'

'''Setup of the window using tk().'''

root = Tk()
root.title("Paint Calculator")
frm = ttk.Frame(root, padding=20) 
    
''' User Input variable declaration '''

name = []
email = []

''' calculation variables declaration'''

wWidth = ''
wHeight = ''
Area = 0.0
gallonsPaintNeeded = 0.0
cansNeeded = 0.0


''' CONSTANTS variable declaration '''

sqFtPerGallon = 350.0
gallonsPerCan = 1.0


'''Define a function for validating an Email'''
 
def check(email):
 
    '''pass the regular expression and the string into the fullmatch() method'''
    
    if(re.fullmatch(regex, email)):
        print("Valid Email")
 
    else:
        print("Invalid Email")

''' createWindow() function creates the main dialogue window for the user to enter
    string data into Entry() textboxes
'''

def createWindow():
    
    '''Click() retrieves user entered data from Entry() and validated. If validated, calculcate() executes
    , data is written to appropriate frm Labels then, database connection is called to check the existance
    of database. Once database is confirmed, data is INSERTED into searchs database'''
    
    def Click():          
        if (entry_n.get() == ""):
            print("Invalid entry")
            entry_n.destroy()
        else: 
            name = entry_n.get()
        
        if (entry_e.get() != ""):
            check(entry_e.get())
            email = entry_e.get()
        else:
            print("Please enter email")       
                    
        ttk.Label(frm, text = name).grid(column=1, row=8, pady=8)    
        ttk.Label(frm, text = email).grid(column=1, row=9, pady=8)
        
    
        wWidth = float(entry_w.get())
        wHeight = float(entry_h.get()) 
        print(name, email, wWidth, wHeight)    
        calculate(wWidth, wHeight)
        
        mysql_connector.connect()
        mysql_connector.insert(name, email, wWidth, wHeight, gallonsPaintNeeded, cansNeeded)
        
      
    frm.grid()   
    
    '''Beginning of Label and Entry() data boxes for user input display'''
    
    ttk.Label(frm, text="Name:  ").grid(column=0, row=0, pady=8)
    entry_n = ttk.Entry(frm, width = 25)
    entry_n.grid(column=1,row=0)
    
    ttk.Label(frm, text="Email:  ").grid(column=0, row=1, pady=8)
    entry_e = ttk.Entry(frm, width = 25)
    entry_e.grid(column=1,row=1)
    
    
    ttk.Label(frm, text="Enter wall width and height: ").grid(column=1, row=4,pady=16)
    ttk.Label(frm, text="Width:  ").grid(column=0, row=5, pady=8)
    entry_w = ttk.Entry(frm, width = 25)
    entry_w.grid(column=1, row=5)
    
    
    ttk.Label(frm, text="Height:  ").grid(column=0, row=6, pady=8)
    entry_h = ttk.Entry(frm, width = 25)
    entry_h.grid(column=1, row=6)   
    
    '''button executes Click() onclick'''
    
    ttk.Button(frm, text="Calculate", command=lambda m="#ButtonPressed": Click()).grid(column=1, row=7, pady=10)

    ttk.Label(frm, text ="Name: ").grid(column=0, row=8, pady=8)
    
    ttk.Label(frm, text="Email: ").grid(column=0, row=9, pady=8)
    
    ttk.Label(frm, text="Wall width (ft): ").grid(column=0, row=10, pady=8)
    
    ttk.Label(frm, text="Wall height (ft): ").grid(column=0, row=11, pady=8)
    
    ttk.Label(frm, text="Total Area (sqft): ").grid(column=0, row=12, pady=8)
    
    ttk.Label(frm, text="Total Gallons: ").grid(column=0, row=13, pady=8)
    
    ttk.Label(frm, text="Total Cans: ").grid(column=0, row=14, pady=8)
    
    
    root.geometry('300x500')
    root.grid_columnconfigure(3)
    root.mainloop()
    
    
        
''' displayResults() recieves the passed data and assigns to appropriate Label'''
        
def displayResults(wWidth, wHeight, Area, gallonsPaintNeeded, cansNeeded):
 
    ttk.Label(frm, text = wWidth).grid(column=1, row=10, pady=8)
    
    ttk.Label(frm, text = wHeight).grid(column=1, row=11, pady=8)
    
    ttk.Label(frm, text= Area).grid(column=1, row=12, pady=8)
    
    ttk.Label(frm, text= gallonsPaintNeeded).grid(column=1, row=13, pady=8)
    
    ttk.Label(frm, text = cansNeeded).grid(column=1, row=14, pady=8)
    
            
''' Area calculation function'''
    
def calculate(wWidth,wHeight):
    Area = wWidth * wHeight
    gallonsPaintNeeded = Area/sqFtPerGallon
    cansNeeded = math.ceil(gallonsPaintNeeded/gallonsPerCan)
    displayResults(format(wWidth, '.0f'), format(wHeight, '.0f'), format(Area,'.0f'), format(gallonsPaintNeeded, '.1f'), cansNeeded)
    
if __name__ == '__main__':
    createWindow()

 
    


