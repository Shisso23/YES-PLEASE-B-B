Public Class Help

    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Select Case e.Node.Name
            Case "Node0"
                RichTextBox1.Text = ""
            Case "Node1"
                RichTextBox1.Text = "To Login to the system you need to have a valid username and password which is given by the manager." &
                    "Start the yes please ordering and reservation system and go to the top left corner of the home interface and click login then sign in." &
                    "the login screen will appear and you will be asked to write your username in the first field and password in the second field." &
                    "Click on the login button and you will be redirected to the interface corresponding to your login details and the type of user you are."



            Case "Node2"
                RichTextBox1.Text = "Expand for more information." &
                 "" &
                    "" &
                    "" &
                    "" &
                    "" &
                    ""
            Case "Node3"
                RichTextBox1.Text = "To make Normal orders; login as a Waiter  " &
                     "Click on the orders image and the ordering interface will appear" &
                    "If the customer wants to be part of our loyalty program you can check first if they already exist in the " &
                    "database by  entering their name or id number in the search bar on the top right corner. If they do not " &
                    "exist yet, then you can register them by clicking the add customer button. Enter their name, surname " &
                    "and id number then save. The customer will be added to the database." &
                    "Select the table number and order type, add the menu item using the + button and enter the quantity " &
                    "on the right. You can press the full menu button to view the full menu. After adding all selected items " &
                    "press the create button to create the order then press submit."

            Case "Node4"
                RichTextBox1.Text = "To create a reservation order, login as a receptionist, click on the reservation image" &
                     "If the customer is not registered, they can be registered by the waiter when they make their orders." &
                    "If the customer is registered, enter their details and the reservation details and the name of the waiter " &
                    "who will be responsible for that reservation, press the invoice button to view the receipt and print it. " &
                    "notice the press button will be enabled, press it to save this information." &
                    "A new interface will appear, search for the selected items, enter the quantity and click on the + button " &
                    "for each selected item to add the order."
            Case "Node5"
                RichTextBox1.Text = "help about reports details here" &
                     "" &
                    "" &
                    "" &
                    "" &
                    "" &
                    ""

            Case "Node6"
                RichTextBox1.Text = "" &
                     "To view the reservation reports; Login as a manager, select reports in the menu and click on reservation"
                    
            Case "Node7"
                RichTextBox1.Text = "" &
                     "To view the reservation reports; Login as a manager, select reports in the menu and click on SALES"
                   
            Case "Node8"
                RichTextBox1.Text = "help about employee management here.. " &
                    "To Manage the Employees ; login as a manager. In the top menu select manager" &
                     " then clik Employee management from here you can add new employees, delete old Employees , view all Employees." &
                     "to add a new Employees; view the user registration steps."
                    
            Case "Node9"
                RichTextBox1.Text = "help about reward employees  here" &
                     "To reward the best employee ; login as a manager. In the top menu select manager then clik reward employee and reward the first employee on the list" &
                    "" &
                    "" &
                    "" &
                    "" &
                    ""
            Case "Node12"
                RichTextBox1.Text = "help about user registration details here" &
                     "To Register a new user ; login as a manager. In the top menu select manager then clik Register user and provide the name , surename , phone number , username, password and the usertype"
                   
            Case "Node14"
                RichTextBox1.Text = "help about customer management here" &
                     " Login as a manager and go to the manager's interface , enter the customer's name in  the search bar to check if they already exist or not. if they don't exist add them by clicking the" &
" add Customer button and provide the name , surname and ID then click save."
                   
            Case "Node15"
                RichTextBox1.Text = "help about product details and management here" &
                     "To Manage the products ; login as a manager. In the top menu select manager" &
                     " then clik Product management from here you can add new products, delete old products , view all products." &
                     "to add a new product; click the + button on this same interface and provide the item code name" &
                    " price and a brief description then click the save button."
                  
            Case "Node16"
                RichTextBox1.Text = "help about Menu details here" &
                     "to view all menu itemsLogin as a waiter, click the create order image," &
                     " select any table number and the reservation type then click on full menu at the bottom of the screen." &
                    "here you can view menu items by categories."
            
        End Select
    End Sub

    Private Sub Help_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RichTextBox2.Text = "This  Help system  user  guide  is  a  step  by  step " &
"instruction  manual  on  how  to  use  the " &
" Yes please Ordering and Reservation System. " &
"Shows you how you can login to our System and use it. How you can Create Orders as a Waiter ,register customers and print the bill for the customer to make the payement.How to create reservations as a receptionist, and help the customer to book the lunchbox ." &
 "Show you  What the manager should do to View the orders reports and reservation reports, how he can manage and reward employees, and manage  products.  " & ""

    End Sub
End Class