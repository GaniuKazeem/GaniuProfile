using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaniuProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthProfile healthProfile = new HealthProfile(null, null, null, null, 0, 0, 0, 0, 0);

            Console.WriteLine("Please Enter First Name:");
            healthProfile.FirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter Last Name:");
            healthProfile.LastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter Gender:");
            healthProfile.Gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter Month of Birth:");
            healthProfile.MonthOfBirth = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter day of birth:");
            healthProfile.DayOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter year of birth:");
            healthProfile.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Height in inches:");
            healthProfile.HeightInInches = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter weight in pounds:");
            healthProfile.WeightInPounds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Current Year:");
            healthProfile.CurrentYear = Convert.ToInt32(Console.ReadLine());


            healthProfile.DisplayFirstName();
            healthProfile.DisplayLastName();
            healthProfile.DisplayGender();
            healthProfile.DisplayMonthOfBirth();
            healthProfile.DisplayDayOfBirth();
            healthProfile.DisplayYearOfBirth();
            healthProfile.DisplayHeightInInches();
            healthProfile.DisplayWeightInPounds();
            healthProfile.DisplayCurrentYear();
            healthProfile.DisplayAge();
            healthProfile.DisplayMaxHeartRate();
            healthProfile.DisplayTargetHeartRate();
            healthProfile.DisplayBodyMassIndex();
            healthProfile.DisplayBMIOutput();
            healthProfile.DisplayBMIChart();

            Console.ReadLine();
            // To delay the program before it terminates

        }
    }
}
