using System;

namespace ifelseif
{
    class Program
    {
        static void Main(string[] args)
        {   int b = 1, Ay1=0 , d=0;
            do
            {
                try
                {
                    Console.WriteLine("Hangi aydayiz ?");
                     Ay1 = Convert.ToInt32(Console.ReadLine());
                     
                    b = 0;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Ayi sayi olarak gir");
                    b = 1;
                }
                finally
                {
                    string c = Ay1<=3 ? "Kisindeyiz" : 
                     Ay1<=6 && Ay1>3 ? "ilkbahardayiz" :
                      Ay1<=9 && Ay1>6 ? "Yazindeyiz" :
                      Ay1<=12 && Ay1>9 ? "sonbahardayiz" : "Girilen sayi yanlistir";
                        if (c=="Girilen sayi yanlistir")
                        d = 1;
                        else d = 0;
                        
                      Console.WriteLine(c);
                }
            } while (b == 1 || d == 1);
            
            
        }
    }
}