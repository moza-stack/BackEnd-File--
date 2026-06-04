using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Room
    {
        private int roomNumber;
        private string roomType;
        private bool isBooked;
        public int RoomNumber
        {
            get;
        }
        public string RoomType {
            get;
        }
        public bool IsBooked
        {
            get;
        }
        public int roomnumber;
        public string roomtype;

        public bool Book()
        {
            if (isBooked)
            {
                return false;
            }

            isBooked = true;
            return true;

        }

               public void CancelBooking()
        {
            isBooked = false;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Room Type: {RoomType}");
            Console.WriteLine($"Available: {!isBooked}");
        }
    }
        
    }


