using System;

namespace Program 
{
    class Program
    {
        public static int CompareTo(double length1, double length2)
        {
            double line1Length = length1;
            double line2Length = length2;

            //Checking for equality and other comparisions
            if (line1Length == line2Length)
                Console.WriteLine("Both lines have equal length");
            else if (line1Length > line2Length)
                Console.WriteLine("First line is longer than the second one");
            else
                Console.WriteLine("First line is shorter than the second one");
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Geometry assignment");

            ////Declaring the Variables:
            int[] line1Pt1 = new int[2];
            int[] line1Pt2 = new int[2];
            int[] line2Pt1 = new int[2];
            int[] line2Pt2 = new int[2];



            ////Function to find length
            static double FindLength(int[] l1, int[] l2)
            {
                double length;
                length = Math.Sqrt(Math.Pow((l2[0] - l1[0]), 2) + Math.Pow((l2[1] - l1[1]), 2));
                return length;
            }


            ////Taking input for 1st line          
            ////Provide Inputs for co-ordinates of first line:         

            static void InputLine(ref int[] point1, ref int[] point2)
            {
                Console.WriteLine("Enter X-Coordinate of 1st point");
                point1[0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y-Coordinate of 1st point");
                point1[1] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter X-Coordinate of 2nd point");
                point2[0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y-Coordinate of 2nd point");
                point2[1] = Int32.Parse(Console.ReadLine());

                return;
            }


            ////Taking points of line1 and printing length of line 1


            ////Calculate length of line 1 by using it's coordinates


            ////Calculate length of line 1 by using it's coordinates

            ////Taking co-ordinates of line1 and printing length of line 1



            InputLine(ref line1Pt1, ref line1Pt2);
            double line1Length;
            line1Length = FindLength(line1Pt1, line1Pt2);
            Console.WriteLine("Length of first line is " + line1Length);






            ////Taking points of line1 and printing length of line 2
            InputLine(ref line1Pt1, ref line1Pt2);
            double line2Length;
            line2Length = FindLength(line1Pt1, line1Pt2);
            Console.WriteLine("Length of first line is " + line2Length);


            CompareTo(line1Length, line2Length);

            //Checking for equality
            if (line1Length == line2Length)
                Console.WriteLine("Both lines have equal length");

            else Console.WriteLine("The line are not of equal length");


            //Comparison of lines
            if (line1Length == line2Length)
                Console.WriteLine("Both lines have equal length");

            else if (line1Length > line2Length)
                Console.WriteLine("First line is longer than the second one");

            else
                Console.WriteLine("First line is shorter than the second one");



        }
    }
}
