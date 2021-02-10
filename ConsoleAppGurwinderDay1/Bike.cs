//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppGurwinderDay1
//{
//    public class Bike
//    {
//        // Static Member - When we want to share a member betweenn all of the object of a class. Static member does not need an object to access .
//        //static memebr accessed by the class directly. when we any change in static property then it euquily effect all objects of the class
//        private int regno; // we want auto generate 
//        private string color;
//        private static int price=5000; // static 
//        private int mfg;
//        private static int series = 1000;
//        public Bike()
//        {
//            series = series + 1; // retain in mutiple function  
//            regno = series;
//            color = "Black";
//            mfg = DateTime.Now.Year;
//        }
//        public Bike(string color,int mfg)
//        {
//            series+=1;
//            regno = series;

//            this.color = color;
//            this.mfg = mfg;
//        }
//        public void display()
//        {
//            Console.WriteLine($"Regno {regno}, Bike Color {color} , Manufacturing Year {mfg} and Price {price}");
//        }
//        public static void Hike(int per) // to deal with static data member we need to create static member function
//        {
//            int hp;
//            hp = price * per / 100;
//            price = price + hp;
//        }
//        public static void Down(int per)
//        {
//            int dp;
//            dp = price * per / 100;
//            price = price - dp;
//        }
//    }
//    class BikeProgram
//    {
//        static void Main()
//        {
//            Bike bike1 = new Bike();
//            Bike bike2 = new Bike("Red",2020);
//            Bike bike3 = new Bike();
//            Bike bike4 = new Bike();
//            Bike[] bikes = new Bike[5]; // array of objects 

//            bike1.display();
//            bike2.display();
//            bike3.display();
//            bike4.display();
            
//            for (int i = 0; i < 5; i++) // initialization 
//                bikes[i] = new Bike();

//            for (int i = 0; i < 5; i++)
//                bikes[i].display();

//            Bike bike = new Bike();
//            bike = bike2; // we can assign an object to another object

//            bike.display();

//            //Bike.Hike(10); // 5000*10/100=>500

//            //Console.WriteLine("After Hike new prices ");
//            //bike1.display(); // 5500
//            //bike2.display(); // 5500

//            //Bike.Down(20); // 5500*20/100 => 1100

//            //Console.WriteLine("After Down new prices "); //on multiple function function call static variable (price) retain itself last value
//            //bike1.display(); // 4400
//            //bike2.display(); //4400

//        }
//    }
//}// Student - RollNo , Name, Hindi, Eng, Math , Sci, SST , (Total, Percentage, Grade - we do not input read only) , 10 Students , Topper() , TopN(3) 
