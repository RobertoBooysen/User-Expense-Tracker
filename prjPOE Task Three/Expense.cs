using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPOE_Task_Three
{
    public abstract class Expense
    {
        //method to calculate monthly home loan repayment and total monthly cost of buying a vehicle
        public static float monthlyHomeLoanRepayment_calculation(float p, float r, float t)
        {
            float monthlyHomeLoanRepayment;//variable to calculate monthly home loan repayment(Ray, 2021)

            //Math formula:A=(P*r(1+r)n) / ((1+r)n – 1)  (see Derivation of Loan/Mortgage Monthly Payment Formula,2021) 
            //p=principal amount; r=interest; t=time (see Derivation of Loan/Mortgage Monthly Payment Formula,2021) 
            //monthlyHomeLoanRepayment=(P*r(1+r)t) / ((1+r)t – 1)  (see Derivation of Loan/Mortgage Monthly Payment Formula,2021)
            r = r / (12 * 100); //interest(one month)//(Ray, 2021) 
            t = t * 12; // time period in months//(Ray, 2021)
            monthlyHomeLoanRepayment = p * r * (float)Math.Pow(1 + r, t)
            / (float)(Math.Pow(1 + r, t) - 1);//(Ray, 2021)

            return monthlyHomeLoanRepayment;//(Ray, 2021)
        }
        //method to calculate the monthly saving a user need to give to reach their goal
        public static float monthlyPayment(float f, float i, float n)
        {
            float monthlySaveAmount;
            //Math formula:x=F*i/[(1+i)n-1]
            //F=future value; i=interest rate;n=years
            i = i / (12 * 100); //interest(one month)//(Ray, 2021) 
            n = n * 12; // time period in months//(Ray, 2021)

            monthlySaveAmount = f * i / (float)(Math.Pow(1 + i, n) - 1); //(Siyavula, 2022)

            return monthlySaveAmount;
        }
    }
}
