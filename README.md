# Inventory-Management-System-C-
Inventory Management System - A C# .NET Windows Forms GUI application.


I. User Interface



A.  A main form, showing the following controls:

•  buttons for “Add,” “Modify,” “Delete,” “Search” for parts and products, and “Exit”

•  lists for parts and products

• text boxes for searching for parts and products

•  title labels for parts, products, and the application title



B.  An add part form, showing the following controls:

•  radio buttons for “In-House” and “Outsourced” parts

•  buttons for “Save” and “Cancel”

•  text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID

•  labels for ID, name, inventory level, price/cost, max and min values, the application title, and company name or machine ID



C.  A modify part form, with fields that populate with data from an existing Part, showing the following controls:

•  radio buttons for “In-House” and “Outsourced” parts

•  buttons for “Save” and “Cancel”

•  text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID

•  labels for ID, name, inventory level, price, max and min values, the application title, and company name or machine ID



D .  An add product form, showing the following controls:

•  buttons for “Save,” “Cancel,” “Add” part, and “Delete” part

•  text boxes for ID, name, inventory level, price, and max and min values

•  labels for ID, name, inventory level, price, max and min values, and the application

•  a grid view for all parts

•  a grid view for parts associated with the product

•  a “Search” button and a text field with an associated list for displaying the results of the search



E.  A modify product form, with fields that populate with data from an existing product, showing the following controls:

•  buttons for “Save,” “Cancel,” “Add” part, and “Delete” part

•  text boxes for ID, name, inventory level, price, and max and min values

•  labels for ID, name, inventory level, price, max and min values, and the application “all candidate parts”

•  a grid view for parts associated with the product

•  a “Search” button and a text box with associated list for displaying the results of the search



II. Application



F.  Structure

•  five classes with the all associated properties

•  variables are accessible/modifiable through properties



G.  Main form:

•  redirect the user to the “Add Part,” “Modify Part,” “Add Product,” or “Modify Product” forms

•  delete a selected part or product from the grid view

•  search for a part or product and display matching results

•  exit the main form



H.  Part forms:

1.   “Add Part” form

•  select “In-House” or “Outsourced”

•  enter name, inventory level, price, max and min values, and company name or machine ID

•  save the data and then redirect to the main form

•  cancel or exit out of this form and go back to the main form

2.   “Modify Part” form

•  select “In-House” or “Outsourced”

•  modify or change data values

•  save modifications to the data and then redirect to the main form

•  cancel or exit out of this form and go back to the main form



I.  Products Form:

1.   “Add Product” form

•  enter name, inventory level, price, and max and min values

•  save the data and then redirect to the main form

•  associate one or more parts with a product

•  remove or disassociate a part from a product

•  cancel or exit out of this form and go back to the main form

2.   “Modify Product” form

•  modify or change data values

•  save modifications to the data and then redirect to the main form

•  associate one or more parts with a product

•  remove or disassociate a part from a product

•  cancel or exit out of this form and go back to the main form



J.  Conditions with exception handling:

•  Detect non-numeric values in textboxes that expect numeric values

•  Min should be less than Max; and Inv should be between those two values

•  Prevent the user from deleting a product that has a Part associated with it

•  Confirm “Delete” actions
