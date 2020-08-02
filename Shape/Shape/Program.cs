using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
     abstract class Quadrilateral
    {
        
        public int length;
        public abstract int Area();
    }

    class Square: Quadrilateral
    {
        public Square(int length)
        {
           this.length = length;
            Console.WriteLine(this.length);
        }

        public override int Area()
        {
            Console.WriteLine("Square area is:");
            return (length*length);
        }
    }

    class Rectangle: Quadrilateral
    {
         public int breadth;
         public Rectangle(int length , int breadth)
        {
            Console.WriteLine("{0} and {1}",length,breadth); 
            this.length = length;
           this.breadth=breadth;
        }
        public override int Area()
        {
          Console.WriteLine("{0} and {1}",length,breadth); 
            Console.WriteLine("Rectangle are is:");
             return (length*breadth);
        }

        public bool IsSquare( int area1 , int area2)
        {
           if(area1 == area2)
                {
                Console.WriteLine("given rectangle is equal:");
                return true;
            }
           else
                Console.WriteLine("given rectangle is not equal:");
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square sqr = new Square(4);
         int area1 = sqr.Area();
            Console.WriteLine(area1);
           Rectangle rect = new Rectangle(5 , 6);
         int  area2 =  rect.Area();
           Console.WriteLine(area2);
           
         if(area1>area2){
            Console.WriteLine("Square area is greater than Rectangle");
            }  
         else{
                    Console.WriteLine("Rectangle is greater");
            }
          Console.WriteLine("{0}", rect.IsSquare(area1,area2));  
        }
    }
}
