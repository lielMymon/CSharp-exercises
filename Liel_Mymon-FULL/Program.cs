using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Liel_Mymon_FULL
{
    internal class Program
    {
        // Exercise 1
        //public static bool IsPrime(int num)
        //{
        //    if (num <= 1)
        //        return false;

        //    for (int i = 2; i < num; i++)
        //    {
        //        if (i == num) continue;
        //        if (num % i == 0)
        //            return false;
        //    }
        //    return true;


        //}

        //Exercise 5

        //public abstract class Car
        //{

        //    public Car()
        //    {
        //        Speed = 0;
        //    }
        //    public int Speed { get; set; }
        //    public virtual string showDetails()
        //    {
        //       return "The car travels " +Speed+ " kilometers per hour";
        //    }

        //    public virtual void Acceleration(int speed) { Speed = speed ; }
        //    public  void Slow(int speed) { Speed -= speed; }
        //    public  void Stop() { Speed = 0; }

        //}

        //public class Lexus : Car
        //{

        //    public bool Music { get; set; }
        //    public Lexus()
        //    {
        //        Music = false;
        //    }

        //    public void musicOnOff()
        //    {
        //        Music=!Music;
        //    }

        //    public override string showDetails()
        //    {
        //      return "Lexus Car. " + base.showDetails() + " " + (Music ? "Music is ON!" : "Music is OFF!");
        //    }
        //}
        //public class Audi : Car
        //{
        //    public override void Acceleration(int speed)
        //    {
        //        Speed=speed*2;
        //    }
        //    public override string showDetails()
        //    {
        //        return "Audi Car. "+ base.showDetails();
        //    }


        //}


        static void Main(string[] args)
        {
            //Exercise 2
            //int num,max=0;
            //Console.WriteLine("enter numbers! press -1 to EXIT");
            //num = int.Parse(Console.ReadLine());
            //while (num != -1)
            //{
            //    while (num < 0)
            //    {
            //        Console.WriteLine("Positive numbers only!");
            //        num=int.Parse(Console.ReadLine());
            //    }

            //    if (num > max)
            //        max = num;
            //    num=int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("The highest number is:" + max);


            //Exercise 3
            //Console.WriteLine("Enter a number!");
            //int num=int.Parse(Console.ReadLine());
            //int sum = 0,x1=0,x2=1;
            //Console.Write("0,1,");
            //for (; ; )
            //{
            //    sum = x1 + x2;
            //    if (sum > num) break;
            //    Console.Write(sum+",");
            //    x1 = x2;
            //    x2 = sum;

            //}

            //Exercise 4
            //int num,max=0,sum=0,s1=0,s2=0,s3=0,n1 = 0,n2 = 0,n3 = 0;
            //Console.WriteLine("enter numbers! press -1 to EXIT");
            //num=int.Parse(Console.ReadLine());
            //s1 = num;
            //num = int.Parse(Console.ReadLine());
            //s2 = num;
            //num = int.Parse(Console.ReadLine());
            //s3 = num;

            //while (num!=-1)
            //{

            //    sum=s1+ s2+ s3;
            //    if (sum > max)
            //    {
            //        max = sum;
            //        n1 = s1;
            //        n2 = s2;
            //        n3 = s3;

            //    }

            //    num = int.Parse(Console.ReadLine());
            //    s1 = s2;
            //    s2=s3;
            //    s3 = num;

            //}

            //Console.WriteLine("biggest triplest are:{0}, {1}, {2}",n1,n2,n3);


            //Exercise 5- Main
            //int speed;
            //Audi Car1=new Audi();
            //Console.WriteLine(Car1.Speed);
            //Console.WriteLine("How much would you like to speed up?");
            //speed=int.Parse(Console.ReadLine());
            //Car1.Acceleration(speed);
            //Console.WriteLine(Car1.showDetails());
            //Car1.Slow(2);
            //Console.WriteLine(Car1.showDetails());
            //Car1.Stop();



            //Lexus Car2 = new Lexus();
            //Console.WriteLine(Car2.Speed);
            //Console.WriteLine("How much would you like to speed up?");
            //speed = int.Parse(Console.ReadLine());
            //Car2.Acceleration(speed);
            //Console.WriteLine(Car2.showDetails());
            //Car2.musicOnOff();
            //Car2.Slow(2);
            //Console.WriteLine(Car2.showDetails());
            //Car2.musicOnOff();
            //Car2.Stop();

           





        }
    }
}
