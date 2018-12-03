using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            try
            {
                try
                {
                    Console.Write("enter first number :");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter second number :");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int Result = FN / SN;
                    Console.Write("Result : {0}",Result);
                }
                catch(Exception ex)
                {
                    const string filePath = @"C:\my-log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        sw.Close();
                        Console.WriteLine("there is a problem please try again.");

                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present", ex);
                        //throw new FileNotFoundException(filePath + "is not present");
                        //throw ex;
                    }
                }
             
            }
            catch(Exception exc)
            {
                Console.WriteLine("Current ex = {0}", exc.GetType().Name);
                if(exc.InnerException!=null)
                {
                    Console.WriteLine("ınner exception={0}", exc.InnerException.GetType().Name);
                }
            }
            Console.ReadKey();

        }
    }
}
