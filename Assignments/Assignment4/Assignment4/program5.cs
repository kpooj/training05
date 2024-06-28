using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Doctor
    {
      
          // Private members
            private int regnNo;
            private string name;
            private double feesCharged;

            // Properties
            public int RegnNo
            {
                get { return regnNo; }
                set { regnNo = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double FeesCharged
            {
                get { return feesCharged; }
                set { feesCharged = value; }
            }

            // Constructor
            public  Doctor (int regnNo, string name, double feesCharged)
            {
                this.regnNo = regnNo;
                this.name = name;
                this.feesCharged = feesCharged;
            }

            // Display method
            public void Display()
            {
                Console.WriteLine($"RegnNo: {regnNo}, Name: {name}, Fees Charged: {feesCharged}");
                Console.ReadLine();
            }
     }

         public class doctor
        {
            static void Main(string[] args)
            {
                // Create a Doctor object
                Doctor doctor = new Doctor(1035494, "Dr. Vilas Kulkarni", 350.0);

                // Display the doctor details
                doctor.Display();
            }
        }

    
}
