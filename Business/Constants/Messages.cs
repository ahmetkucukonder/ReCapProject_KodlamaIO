using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Car successfully added!";
        public static string InvalidCarName = "The car name is must be higher than 2 characters!";
        public static string MaintenanceTime = "The system is under maintenance!";
        public static string CarsListed = "Cars successfully listed!";
        public static string InvalidPrice = "The daily price of the vehicle should be a minimum of 1$";
        public static string ListedCarDetails = "Listed car details!";
        public static string CarIsUpdated = "Car is successfully updated!";

        public static string CarIsDeleted { get; internal set; }
    }
}
