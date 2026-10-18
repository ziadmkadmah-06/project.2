using project._2;
using System;
using System.Security.Cryptography;

Full_Time_Employee ahmad = new Full_Time_Employee(1, "Ahmad", 1200m);
Part time omar = new Part time(2, "Omar", 40, 10m);

ahmad.Displayinfo();
Console.WriteLine();

omar.Displayinfo();
Console.WriteLine();
ahmad.workable();
omar.workable();
