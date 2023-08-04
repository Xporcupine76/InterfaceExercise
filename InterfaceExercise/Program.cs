using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;
namespace InterfaceExercise
{

    class Program
    {
        static void Main(string[] args)
        {

            MieEmployee mieEmployee = new MieEmployee();   
            MieStudent student = new MieStudent();

            ((MieRules)mieEmployee).GoHome();

        }
    }
    public class MieEmployee : MieRules
    {
        void MieRules.GoHome()
        {
            Console.WriteLine("17:00");
        }

        void MieRules.LunchBreak()
        {
            Console.WriteLine("12:00");
        }

        void MieRules.ReportToMie()
        {
            Console.WriteLine("08:00");
        }

        void MieRules.TeaBreak()
        {
            Console.WriteLine("10:00");
        }
    }
    public class MieStudent : MieRules
    {
        void MieRules.GoHome()
        {
            Console.WriteLine("15:30");
        }

        void MieRules.LunchBreak()
        {
            Console.WriteLine("12:00");
        }

        void MieRules.ReportToMie()
        {
            Console.WriteLine("09:00");
        }

        void MieRules.TeaBreak()
        {
            Console.WriteLine("10:00");
        }
    }
    interface MieRules
    {
        void ReportToMie();
        void LunchBreak();
        void TeaBreak();
        void GoHome();


    }


}