using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;

namespace App.Datos
{
    public class PackageRepositories
    {
        private static List<Package> data = new List<Package>();
        
        public IEnumerable<Package> getPackages()
        {
            Person sender = new Person();
            Person recipient = new Person();

            OrdinaryPackage pg1 = new OrdinaryPackage("T001", sender, recipient, 54.5, 2000.0, 3);
            TwoDayPackage pg2 = new TwoDayPackage("T002", sender, recipient, 30.1, 2500.0, 3000.0);
            OvernightPackage pg3 = new OvernightPackage("T003", sender, recipient, 28.3, 2300.0, 5000.0);

            data.Add(pg1);
            data.Add(pg2);

            return data;
        }
    }
}