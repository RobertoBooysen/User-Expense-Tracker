using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPOE_Task_Three
{
    public delegate void MyDelegate(string notifyMessage); //declaring a delegate(TutorialsTeacher, 2022)
    class usersExpenses
    {
        //public static dictionary generic collection to store the users expenses(TutorialsTeacher, 2022)
        public static IDictionary<string, float> expenses = new Dictionary<string, float>();
    }
}
//References
//Derivation of Loan/Mortgage Monthly Payment Formula.2021.YouTube video, added by Physics Ninja.[Online].Available at: https://www.youtube.com/watch?v=iilFXMHKkZQ&t=557s [Accessed 14 April 2022].
//Part-8 If textbox is empty give error message before saving.2016. YouTube video, added by code factory 2016. [Online]. Available at: https://www.youtube.com/watch?v=fJ6Hdesu7Ig [Accessed 28 June 2022]
//Ray, K., 2021. GeeksforGeeks. [Online] Available at: https://www.geeksforgeeks.org/program-emi-calculator/ [Accessed 14 April 2022].
//Siyavula, 2022.Siyavula. [Online] Available at: https://www.siyavula.com/read/maths/grade-12/finance/03-finance-03 [Accessed 28 June 2022].
//Tutorialspoint, 2020.TutorialsPoint. [Online] Available at: https://www.tutorialspoint.com/how-to-write-regex-for-numbers-only-in-chash [Accessed 28 June 2022].

