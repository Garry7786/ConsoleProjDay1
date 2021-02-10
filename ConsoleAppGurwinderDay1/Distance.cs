//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    class Distance
//    {
//        private int feet;
//        private int inch;

//        public int Inch
//        {
//            get { return inch; }
//            set { inch = value; }
//        }

//        public int Feet
//        {
//            get { return feet; }
//            set { feet = value; }
//        }
//        // Add 2 distnace  d1=> 5 Feet 3 Inch , d2=> 4 Feet 2 Inch, d3=> 9 feet 5 Inch
//        public Distance Add(Distance distance)
//        {
//            Distance distance1 = new Distance();
//            distance1.feet = this.feet + distance.feet;
//            distance1.inch = this.inch + distance.inch;
//            return distance1;
//        }

//    }
//    class DistanceProgram
//    {
//        static void Main()
//        {
//            Distance d1 = new Distance();
//            Distance d2 = new Distance();
//            Distance d3 = new Distance();
//            d1.Feet = 5;
//            d1.Inch = 3;

//            d2.Feet = 4;
//            d2.Inch = 2;

//            d3 = d2.Add(d1);

//            Console.WriteLine($"Distance is {d3.Feet} feet {d3.Inch} inch.");

//        }
//    }
//}
