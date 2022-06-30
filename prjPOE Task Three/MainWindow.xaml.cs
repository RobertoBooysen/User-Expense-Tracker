using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prjPOE_Task_Three
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    private void NumberValidationTextBox(object sender,TextCompositionEventArgs e)
    {
       //Error checking to ensure the user only types in numbers and not letters(Tutorialspoint, 2020)
       Regex regex = new Regex("[^0-9]+");
       e.Handled = regex.IsMatch(e.Text);
    }
        
        //Method for when the Add Expenses button is clicked
        private void btnAddExpenses_Click(object sender, RoutedEventArgs e)
        {
            //Error handling so that no textboxes are left empty(see Part-8 If textbox is empty give error message before saving,2016)
            if (txtGrossIncome.Text == "")
            {
                MessageBox.Show("Please enter an amount in the gross income textbox!");
                return;
            }
            else if (txtTaxDeducted.Text == "")
            {
                MessageBox.Show("Please enter an amount in the tax deducted textbox!");
                return;
            }
            else if (txtGroceries.Text == "")
            {
                MessageBox.Show("Please enter an amount in the groceries textbox!");
                return;
            }
            else if (txtWaterAndLights.Text == "")
            {
                MessageBox.Show("Please enter an amount in the water and lights textbox!");
                return; 
            }
            else if (txtTravelCost.Text == "")
            {
                MessageBox.Show("Please enter an amount in the travel cost textbox!");
                return;
            }
            else if (txtCellphoneAndTelephone.Text == "")
            {
                MessageBox.Show("Please enter an amount in the cellphone and telephone textbox!");
                return; 
            }
            else if (txtOtherExpeneses.Text == "")
            {
                MessageBox.Show("Please enter an amount in the other expenses textbox!");
                return;
            }
            //Adding into the dictionary generic collection(TutorialsTeacher, 2022)
            usersExpenses.expenses.Add("Tax deducted:R", Single.Parse(txtTaxDeducted.Text));
            usersExpenses.expenses.Add("Groceries:R", Single.Parse(txtGroceries.Text));
            usersExpenses.expenses.Add("Water and lights:R", Single.Parse(txtWaterAndLights.Text));
            usersExpenses.expenses.Add("Travel cost:R", Single.Parse(txtTravelCost.Text));
            usersExpenses.expenses.Add("Cellphone and telephone:R", Single.Parse(txtCellphoneAndTelephone.Text));
            usersExpenses.expenses.Add("Other expenses:R", Single.Parse(txtOtherExpeneses.Text));
            //Calculating the availanble money after the expenses have been deducted(W3Schools,2022)
            txtAvailableMoneyAfterExpenses.Text = (Single.Parse(txtGrossIncome.Text) - (Single.Parse(txtTaxDeducted.Text)
                            + Single.Parse(txtGroceries.Text) + Single.Parse(txtWaterAndLights.Text) 
                            + Single.Parse(txtTravelCost.Text) + Single.Parse(txtCellphoneAndTelephone.Text) 
                            + Single.Parse(txtOtherExpeneses.Text))).ToString();
        }
        //Method for when the Add Monthly Rental button is clicked
        private void btnAddMonthlyRental_Click(object sender, RoutedEventArgs e)
        {
            //Error handling so that no textboxes are left empty(see Part-8 If textbox is empty give error message before saving,2016)
            if (txtMonthlyRentalAmount.Text == "")
            {
                MessageBox.Show("Please enter an amount in the rent amount textbox!");
                return; 
            }
            //if the user went straight to the rent accomodation tab item and entered the monthly rent there will be a message
            //displayed that will state the user must first enter their expenses in Add Expenses tab item
            else if (txtAvailableMoneyAfterExpenses.Text == "")
            {
                MessageBox.Show("Please enter all the textboxes in the add expenses tab item!");
                return; 
            }
            //Available money after all deductions have been made gross income -the expenses and monthly rental amount(W3Schools,2022)
            string availableMoney1 = (Single.Parse(txtGrossIncome.Text) - (Single.Parse(txtTaxDeducted.Text)
                            + Single.Parse(txtGroceries.Text) + Single.Parse(txtWaterAndLights.Text) 
                            + Single.Parse(txtTravelCost.Text) + Single.Parse(txtCellphoneAndTelephone.Text) 
                            + Single.Parse(txtOtherExpeneses.Text)+ Single.Parse(txtMonthlyRentalAmount.Text))).ToString();
            //Displaying available money after rental in text box
            lstRental.Items.Add("Available monthly money after rental:R" + availableMoney1);
        }
        //Method for when the Calculate Monthly Home Loan button is clicked
        private void btnMonthlyHomeLoanRepayment_Click(object sender, RoutedEventArgs e)
        {
            //Error handling so that no textboxes are left empty(see Part-8 If textbox is empty give error message before saving,2016)
            if (txtPropertyPrice.Text == "")
            {
                MessageBox.Show("Please enter an amount in the property purchase price textbox!");
                return; 
            }
            else if (txtPropertyDeposit.Text == "")
            {
                MessageBox.Show("Please enter an amount in the total deposit textbox!");
                return; 
            }
            else if (txtPropertyInterestRate.Text == "")
            {
                MessageBox.Show("Please enter an amount in the interest rate for the property textbox!");
                return; 
            }
            else if (txtNumberOfMonths.Text == "")
            {
                MessageBox.Show("Please enter an amount in the number of months textbox!");
                return;
            }
            //if the user went straight to the rent accomodation tab item and entered the monthly rent there will be a message
            //displayed that will state the user must first enter their expenses in Add Expenses tab item
            else if (txtAvailableMoneyAfterExpenses.Text == "")
            {
                MessageBox.Show("Please enter all the textboxes in the add expenses tab item!");
                return;
            }
            //Using the method in abstract class to calculate the monthly home loan repayment
            float monthlyHomeLoanInstallment= Expense.monthlyHomeLoanRepayment_calculation(Single.Parse(txtPropertyPrice.Text)- 
                                        Single.Parse(txtPropertyDeposit.Text), Single.Parse(txtPropertyInterestRate.Text),
                                        Single.Parse(txtNumberOfMonths.Text)/12);

            //Available money after all deductions have been made gross income -the expenses and home loan installment(W3Schools,2022)
            float availableMoney2 = Single.Parse(txtGrossIncome.Text) - (Single.Parse(txtTaxDeducted.Text)
                            + Single.Parse(txtGroceries.Text) + Single.Parse(txtWaterAndLights.Text)
                            + Single.Parse(txtTravelCost.Text) + Single.Parse(txtCellphoneAndTelephone.Text)
                            + Single.Parse(txtOtherExpeneses.Text) + monthlyHomeLoanInstallment);

            //Displaying monthly home loan installment in listbox
            lstHomeLoan.Items.Add("Monthly home loan installment:R" + monthlyHomeLoanInstallment);
            lstHomeLoan.Items.Add("Available money after home loan installment:R" + availableMoney2);

            //Displaying if monthly home loan installment is greater then a third of the gross income approval for the home loan
            //will be unlikely message in listbox(W3Schools,2022)
            if (monthlyHomeLoanInstallment > Single.Parse(txtGrossIncome.Text) / 3)
            {
                MessageBox.Show("Approval of the home loan is unlikely.");
            }
        }
        //Method for when the Calculate Total Monthly Cost button is clicked
        private void btnCalculateTotalMonthlyCost_Click(object sender, RoutedEventArgs e)
        {
            //Error handling so that no textboxes are left empty(see Part-8 If textbox is empty give error message before saving,2016)
            if (txtModelAndMake.Text == "")
            {
                MessageBox.Show("Please enter an amount in the car model and make textbox!");
                return; 
            }
            else if (txtCarPrice.Text == "")
            {
                MessageBox.Show("Please enter an amount in the car purchase price textbox!");
                return; 
            }
            else if (txtCarDeposit.Text == "")
            {
                MessageBox.Show("Please enter an amount in the car deposit textbox!");
                return;
            }
            else if (txtCarInterestRate.Text == "")
            {
                MessageBox.Show("Please enter an amount in the car interest rate textbox!");
                return;
            }
            else if (txtEstimatedInsurancePremium.Text == "")
            {
                MessageBox.Show("Please enter an amount in the estimated insuarance premium textbox!");
                return;
            }
            //if the user went straight to the rent accomodation tab item and entered the monthly rent there will be a message
            //displayed that will state the user must first enter their expenses in Add Expenses tab item
            else if (txtAvailableMoneyAfterExpenses.Text == "")
            {
                MessageBox.Show("Please enter all the textboxes in the add expenses tab item!");
                return;
            }
            //Using the method in abstract class to calculate the total monthly cost
            float totalMonthlyCost = Expense.monthlyHomeLoanRepayment_calculation(Single.Parse(txtCarPrice.Text) -
                                        Single.Parse(txtCarDeposit.Text) + Single.Parse(txtEstimatedInsurancePremium.Text),
                                        Single.Parse(txtCarInterestRate.Text), 5);


            //Radio buttons for the option rent accomodation and home loan to calculate the users total expenses
            float calculateOption = 0;
            if (rbnRentAccomodation.IsChecked == true)//Rent accomodation option(W3Schools,2022)
            {
                if (txtMonthlyRentalAmount.Text == "")
                {
                    MessageBox.Show("Please enter an amount in the rent amount textbox in the rent accomodation tab item!");
                    return;
                }
                //Calculating total expenses with monthly rental amount included
                calculateOption = Single.Parse(txtTaxDeducted.Text)
                            + Single.Parse(txtGroceries.Text) + Single.Parse(txtWaterAndLights.Text)
                            + Single.Parse(txtTravelCost.Text) + Single.Parse(txtCellphoneAndTelephone.Text)
                            + Single.Parse(txtOtherExpeneses.Text)+Single.Parse(txtMonthlyRentalAmount.Text)+ totalMonthlyCost;
            }
            if (rbnHomeLoan.IsChecked == true)//Home loan installment option(W3Schools,2022)
            {
                //Error handling so that no textboxes are left empty(see Part-8 If textbox is empty give error message before saving,2016)
                if (txtPropertyPrice.Text == "")
                {
                    MessageBox.Show("Please enter an amount in the property purchase price textbox in the home loan tab item!");
                    return;
                }
                else if (txtPropertyDeposit.Text == "")
                {
                    MessageBox.Show("Please enter an amount in the total deposit textbox in the home loan tab item!");
                    return;
                }
                else if (txtPropertyInterestRate.Text == "")
                {
                    MessageBox.Show("Please enter an amount in the interest rate for the property textbox in the home loan tab item!");
                    return;
                }
                else if (txtNumberOfMonths.Text == "")
                {
                    MessageBox.Show("Please enter an amount in the number of months textbox in the home loan tab item!!");
                    return;
                }
                //Monthly installment for the home loan
                float monthlyHomeLoanInstallmentCalcOption = Expense.monthlyHomeLoanRepayment_calculation(Single.Parse(txtPropertyPrice.Text) -
                        Single.Parse(txtPropertyDeposit.Text), Single.Parse(txtPropertyInterestRate.Text),
                        Single.Parse(txtNumberOfMonths.Text) / 12);

                //Calculating total expenses with monthly home loan installment included
                calculateOption = Single.Parse(txtTaxDeducted.Text)
                           + Single.Parse(txtGroceries.Text) + Single.Parse(txtWaterAndLights.Text)
                           + Single.Parse(txtTravelCost.Text) + Single.Parse(txtCellphoneAndTelephone.Text)
                           + Single.Parse(txtOtherExpeneses.Text)+ monthlyHomeLoanInstallmentCalcOption+ totalMonthlyCost;
            }

            lstVehicle.Items.Clear();
            //Displaying total monthly cost of the car in listbox
            lstVehicle.Items.Add("Total monthly cost:" + totalMonthlyCost+"\n");
            //Sorting values in descending order
            usersExpenses.expenses = usersExpenses.expenses.OrderByDescending(x => x.Value).ToDictionary(y => y.Key, z => z.Value);

            //Displaying expenses in dicitonary generic collection in listbox
            lstVehicle.Items.Add("Expenses in descending order:");
            foreach (KeyValuePair<string, float> expenses in usersExpenses.expenses)
            {
                lstVehicle.Items.Add(expenses.Key + ":R" + expenses.Value);
            }
            //Displaying total expenses in listbox
            lstVehicle.Items.Add("\n"+"Total Expenses:R"+calculateOption);
            if (calculateOption > (Single.Parse(txtGrossIncome.Text) * 3 / 4))
            {
                //Displaying notify message when users total expenses amount exceed over 75%(TutorialsTeacher, 2022)
                MyDelegate del = new MyDelegate(notify);
                del.Invoke("The total expenses are greater then 75% of the gross income!");
            }

            //Target method for delegtate(TutorialsTeacher, 2022)
            static void notify(string notifying)
            {
                MessageBox.Show(notifying);
            }
        }
        //Method for when the Calculate Monthly Saving button is clicked
        private void btnCalculateMonthlySaving_Click_1(object sender, RoutedEventArgs e)
        {
            //Error handling so that no textboxes are left empty(see Part-8 If textbox is empty give error message before saving,2016)
            if (txtSavePrice.Text == "")
            {
                MessageBox.Show("Please enter an amount in the save price textbox!");
                return;
            }
            else if (txtSaveInterestRate.Text == "")
            {
                MessageBox.Show("Please enter an amount in the save interest rate textbox!");
                return;
            }
            else if (txtSavePeriodOfTime.Text == "")
            {
                MessageBox.Show("Please enter an amount in the save period of time textbox!");
                return;
            }
            //Using the method in abstract class to calculate the monthly installment the user needs to reach their goal
            float MonthlySavingAmount = Expense.monthlyPayment(Single.Parse(txtSavePrice.Text), Single.Parse(txtSaveInterestRate.Text), Single.Parse(txtSavePeriodOfTime.Text));
            //Displaying amount the user will need to pay every month to reach their goal(W3Schools,2022)
            lstSaveMoney.Items.Add("Amount that needs to be saved every month:\n"+"R" + MonthlySavingAmount);
        }
    }
}
