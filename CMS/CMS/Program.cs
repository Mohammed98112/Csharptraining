namespace CMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 System Storage (Region 1)

            // ── REGION 1: System Storage ─────────────────────────────────────
            // Capacity constants
            const int MAX_PATIENTS = 3;
                const int MAX_DOCTORS = 2;
                const int MAX_APPOINTMENTS = 3;
                // Patient slots
                string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
                string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
                string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;
                int patientCount = 0;
                // Doctor slots
                string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
                string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;
                int doctorCount = 0;
                // Appointment slots
                string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status =
                ""; bool a1Active = false;
                string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status =
                ""; bool a2Active = false;
                string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status =
                ""; bool a3Active = false;
                int appointmentCount = 0;


            //////////////////////////////////////////////////////////
            ///

            //3 Main Menu (Region 2)

            int option;
                bool exit = false;

                do
                {




                    Console.WriteLine("CLINIC MANAGEMENT SYSTEM");
                    Console.WriteLine("1. Patient Management");
                    Console.WriteLine("2. Doctor Management");
                    Console.WriteLine("3. Appointment Management");
                    Console.WriteLine("0. Exit");

                    Console.WriteLine("enter your choice: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {

                        //1. Patient Management
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Patient Management");
                            break;

                        //2. Doctor Management
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Doctor Management");
                            break;

                        //3. Appointment Management
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Appointment Management");
                            break;

                        //0. Exit
                        case 0:
                            Console.WriteLine("Exit");
                        exit = true;
                            break;

                        //Invalid option
                        default:
                            Console.WriteLine("Patient Management");
                            break;










                    }








                } while (exit == false);






            }
        }
    }
