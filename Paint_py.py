'''
    @created:  Jan 23, 2023
    @title:    Paint (ePortfolio)
    @author:   George M Harrison Jr
    @description: This program was rewritten from Java to Python and given a gui. This program takes the users
                  name, email, wall width (wWidth) and wall height (wHeight). Calculates the Area of the wall.
                  Calculates the amount of paint needed to cover the Area. Then Calculates how many cans of paint
                  will be needed to have enough to cover wall by rounding up to the nearest whole number.
                  Once all calculations are performed, the user data will be stored for callback to user.
'''
from tkinter import *
from tkinter import ttk
from tkinter.messagebox import askyesno
import math
from _winapi import NULL

''' createWindow() function creates the main dialogue window for the user to enter
    string data into Entry() textboxes
'''
def createWindow():
    
    def Click():  
        
        if entry_n.get() == "":
            print("Error-- Please Enter Name")
            entry_n.destroy()
            
        if entry_n.get() != "":
            name = entry_n.get()
        
        email = entry_e.get()
        wWidth = entry_w.get()
        wHeight = entry_h.get()
        
        print(name)
        print(email)
        print("Width:" + wWidth)
        print("Height: " + wHeight)
        print(calculate(float(wWidth), float(wHeight)))
        
        
    root = Tk()
    root.title("Paint Calculator")
    frm = ttk.Frame(root, padding=20)    
    frm.grid()
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
    
    ttk.Button(frm, text="Calculate", command=lambda m="#ButtonPressed": Click()).grid(column=1, row=7, pady=10)

    root.geometry('300x400')
    root.grid_columnconfigure(3)
    root.mainloop()
    
'''
    button = Button(root, text="Click", fg='black')
    button.place(x=80, y=100)
    button.bind('<Button-1>', Click())
'''
''' Input variable declaration '''

name = []
email = []

''' calculation variables '''
wWidth = ''
wHeight = ''
Area = 0.0
gallonsPaintNeeded = 0.0
cansNeeded = 0.0


''' CONSTANTS declaration '''

sqFtPerGallon = 350.0
gallonsPerCan = 1.0



''' Area calculation function'''

def calculate(wWidth, wHeight):          
    Area = wWidth * wHeight
    gallonsPaintNeeded = Area/sqFtPerGallon
    cansNeeded = math.ceil(gallonsPaintNeeded/gallonsPerCan)
    return "Total area: " + str(Area) + "/nPaint in Gallons: " + str(gallonsPaintNeeded) + "/nCans Needs: " + str(cansNeeded)

'''create new form
def newForm(root):
    
    
    
    def get_input():
        Label.config(text= frm.Entry.get(), font=("Helvetica 12"))
        
    
    name LABEL and input box
    
    
    
'''
''' 
    
    
   
    root.mainloop()
'''
    

 
def buttonPush():   
    print("Hello")
    Click()
    print(name)


if __name__ == '__main__':
    createWindow()

 
    


