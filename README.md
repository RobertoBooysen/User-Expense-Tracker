# prog6211-task-3-RobertoBooysen
prog6211-task-3-RobertoBooysen created by GitHub Classroom

Roberto Booysen-ST10085125
YouTube link: https://youtu.be/cKngs64wnSg
I have 2 classes which is the userExpenses class where I have a public delegate void to notify a user if their total expenses exceed 75% of their gross income and a 
dictionary generic collection that will store the users’ expenses and an Expense abstract class where I have 2 methods which is the calculation of the monthly home loan 
repayment and another to calculate the monthly amount a user needs to save to reach their goal. I then have a MainWindow.xaml which is the GUI where I have made use of a 
tab control tool which is for the user to add their expenses and will be then stored in the generic collection with a textbox to display the total expenses amount , the 
rent accommodation tab items follows after that where a user can enter their monthly rental amount and once they click the button “add monthly rental” the available money
will be displayed to the user in a listbox, the home loan tab item is after that where a user can enter the price of the property they would like to purchase , the 
deposit they would give , the interest rate and number of months, where there’s a “calculate home loan instalment” button once its clicked it will display the monthly 
instalment the user will need to pay and their available monthly money after their specified deductions that includes the instalment. The Buying Vehicle tab item follows
that if a user chooses to purchase a vehicle where they can enter the model and make of the car that they would like to purchase, the car purchase price, car deposit 
price, interest rate and the estimated insurance premium and two radio buttons where a user can choose what total expenses, they would like to calculate rent accommodation
or home loan. If they click the “Calculate Car Instalment” the total monthly cost of buying a car and the expenses of the user in descending order and the total expenses 
amount based on the user’s selection of the radio button will be displayed in the listbox. The last tab item is named Save Money where the user can enter an amount they 
would like to save up to, with the interest rate that will be earned on the savings and the period of years that they will save for. After the MainWindow.xaml follows 
the MainWindow.xaml.cs which is the code behind the GUI where there is a private void named “NumberValidationTextBox” which is an error checking method where a user can 
only enter numbers in the textboxes where the users only must enter numbers if they try to enter letters, they won’t be able to. There is then a private void for if the
button “btnAddExpenses” is clicked where there is error handling for all the textboxes that is in the tab item after the error handling the expenses amounts that the 
user entered is then stored in the dictionary generic collection which followed by a calculation to calculate the total of the expenses and will be displayed in the 
textbox txtAvailableMoneyAfterExpenses. Then there is a private void for if the button “btnAddMonthlyRental” is clicked where there is error handling for the monthly 
rental textbox so that it cannot be left emptied and error handling for if the user went straight to the rent accomodation tab item and entered the monthly rent there 
will be a message displayed that will state the user must first enter their expenses in Add Expenses tab item for the available monthly money after the monthly rental 
money deductions to be calculated after they’ve entered in all the necessary textboxes the available monthly money will be calculated and will be displayed in a textbox. 
The private void for if the button “btnHomeLoanRepayment” is clicked where there is error handling for all the textboxes in the home loan tab item emptied and error 
handling for if the user went straight to the home loan tab item and entered all the values in the textboxes there will be a message displayed that will state the user 
must first enter their expenses in Add Expenses tab item for the available monthly money after the home loan instalment amount deductions to be calculated after they’ve 
entered in all the necessary textboxes there will be a calculation for the monthly home loan instalment by making use of the monthlyHomeLoanRepayment_calculation method 
that’s in the Expenses abstract class by passing the necessary values through. There is then a calculation for the available monthly money after the monthly home loan 
instalment. It is then displayed in the list box if the monthly home loan instalment is greater than a third of the gross income the program will alert the user that 
their approval for the home loan is unlikely in a form of message box. The private void for if the button “btnCalculateTotalMonthlyCost” is clicked where there is 
error handling for the all the textboxes in the tab item so that it cannot be left emptied and error handling for if the user went straight to the buying vehicle tab 
item there will be a message displayed that will state the user must first enter their expenses in Add Expenses tab item. There is then a calculation for the total 
monthly cost of buying a car by making use of the calculation used to calculate the monthly home loan instalment by passing the necessary values through. After that 
there’s if statements for the two radio buttons for when a user wants to calculate their total expenses if the rent accommodation radio button is clicked there is 
error handling to see if they have entered an amount I rent accommodation tab item and if they haven’t there will be message that pops up that will say they need to 
enter the amount of the monthly rental if they selected the home loan radio button there’s error handling for all those fields the home loan tab item to see if they 
have entered it if they haven’t there will be message that pops up that will state that they will need to enter values into all those fields, with a calculation that 
follows that calculated the total expenses based on their selection. The total monthly cost of buying a car , the expenses that’s in the generic collection in
descending order, total expenses based on their selection will be displayed in the listbox and if the total expenses exceeds 75% of the gross income there will be
message that will pop up to state that it exceeded the 75% percentage by making used of a delegate void there’s also a target method for the delegate after it. The 
private void for if the button “btnCalculateMonthlySaving” is clicked where there is error handling for all the textboxes in the Save Money tab item to check if all 
is filled in if they not all entered the program will prompt the user to enter amounts in. After that theres a calculation that’s in the expense class, which is 
monthlyPayment to calculate the amount, the user needs to save every month to reach their goal it will then be displayed in the listbox.

Based on the feedback I got back from sir I implemented the following:
I basically cleaned up my code a bit more than I did in the previous task.
