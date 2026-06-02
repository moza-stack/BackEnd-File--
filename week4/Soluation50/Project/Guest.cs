using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Guest
    {
        private static int totalGuestsCreated;
        private string nationalID;
        private string fullName;
        public string NationalID
        {
            get;
        }
        public string FullName
        {
            get; set;
        }
        public string GuestfullName;
        public string GuestnationalID;
        public static int GetTotalGuestsCreated()
        {  return totalGuestsCreated; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Guest Name: {fullName}");
            Console.WriteLine($"National ID: {nationalID}");
        }
                
        }




    }
        
    

