namespace Csharptraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            int accountNumber = 0;
            string holderName = "";
            double balance = 0.000;
            bool isActive = false;
            char accountType = 'A';
            bool isEmployed = false;
            double salary = 0.000;
            int creditScore = 0;
            int age = 0;
            double deposit = 0.000;
            double withdrawal = 0.000;
            double annualRate = 0.000;
            double avgBalance = 0.000;





            Console.WriteLine("""
            --- Account Profile ---
 1) Account Number (int) current: 0
 2) Holder Name (string) current: [not set]
 3) Balance (double) current: 0.000 OMR
 4) Account Active? (bool) current: false [enter 1=yes / 0=no]
 5) Account Type (char) current: - [enter S / C / F]

            --- Customer Profile ---
 6) Employed? (bool) current: false [enter 1=yes / 0=no]
 7) Monthly Salary (double) current: 0.000 OMR
 8) Credit Score (int) current: 0
 9) Age (int) current: 0

            --- Transaction Data ---
 10) Last Deposit Amount (double) current: 0.000 OMR
 11) Last Withdrawal (double) current: 0.000 OMR
 12) Annual Interest Rate (double) current: 0.000 OMR  [e.g. 0.035 = 3.5%]
 13) Avg Monthly Balance (double) current: 0.000 OMR

 0) Setup complete — launch Main Menu
 """);

            Console.WriteLine("enter your option");

            int SetUpMenue = Convert.ToInt32(Console.ReadLine());
            switch (SetUpMenue)
            {
                case 1:
                    Console.WriteLine("enter account number");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("enter your name");
                    holderName = Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("enter your balance");
                    balance = Convert.ToDouble(Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine("is it active yes/no");
                    isActive = Convert.ToBoolean(Console.ReadLine());
                    break;

                case 5:
                    Console.WriteLine("enter account type");
                    accountType = Convert.ToChar(Console.ReadLine());
                    break;

                case 6:
                    Console.WriteLine("are you employee? yes/no");
                    isEmployed = Convert.ToBoolean(Console.ReadLine());
                    break;

                case 7:
                    Console.WriteLine("enter your salary");
                    salary = Convert.ToDouble(Console.ReadLine());
                    break;

                case 8:
                    Console.WriteLine("enter your creditScore");
                    creditScore = Convert.ToInt32(Console.ReadLine());
                    break;

                case 9:
                    Console.WriteLine("enter your age");
                    age = Convert.ToInt32(Console.ReadLine());
                    break;

                case 10:
                    Console.WriteLine("enter your deposit");
                    deposit = Convert.ToDouble(Console.ReadLine());
                    break;

                case 11:
                    Console.WriteLine("enter your withdrawal");
                    withdrawal = Convert.ToDouble(Console.ReadLine());
                    break;

                case 12:
                    Console.WriteLine("enter your annualRate ");
                    annualRate = Convert.ToDouble(Console.ReadLine());
                    break;

                case 13:
                    Console.WriteLine("enter your avgBalance");
                    avgBalance = Convert.ToDouble(Console.ReadLine());
                    break;

                case 0:
                    Console.WriteLine("setup complete");
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;
                    ///////////////////////////////////////////////////////////////////////////////////





            }




            //task 2
            Console.WriteLine("=== ATM SERVICES ===");
            Console.WriteLine("1) Bank Info");
            Console.WriteLine("2) Branch Info");
            Console.WriteLine("3) Opening Hours");
            Console.WriteLine("0) Back to Main Menu");


            Console.WriteLine("select service: ");
            int ATMoption = Convert.ToInt32(Console.ReadLine());

            switch (ATMoption)
            {
                ////1) Bank Info
                case 1:
                    Console.WriteLine("bank name: (National Bank of Oman) ");
                    Console.WriteLine("tagline: No tax");
                    Console.WriteLine("founding year: 1231");
                    break;

                ///2) Branch Info
                case 2:
                    Console.WriteLine("branch name: (Bank Muscat) ");
                    Console.WriteLine("city: ALAMERAT Kingdom");
                    Console.WriteLine("address: Muscat");
                    break;

                ///3) Opening Hours

                case 3:
                    Console.WriteLine("(weekday: from sunday to friday) ");
                    Console.WriteLine("weekend: hours form 1:00 AM to 5:00 AM");
                    break;

                ///3) Returning to Main Menu

                case 0:
                    Console.WriteLine("'Returning to Main Menu... ");
                    break;

                    ///invalid otion
                    default :
                    Console.WriteLine("invalid option");
                    break;
            }

        }
    }
}