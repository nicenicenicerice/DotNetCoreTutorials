using LangConsoleApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program29
    {
        public static void Run()
        {
            Console.WriteLine("C# - Exception");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-exception");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-exception-handling");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/throw-csharp");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(1):");
            try
            {
                Console.WriteLine("(1-1)");
                int numA = 1;
                int numB = 1;
                int numC = numA / numB;
                Console.WriteLine("(1-2)numC = " + numC);
            }
            catch (Exception ex)
            {
                Console.WriteLine("(1-3)" + ex.Message);
            }
            finally
            {
                Console.WriteLine("(1-4)");
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(2):");
            try
            {
                Console.WriteLine("(2-1)");
                int numA = 1;
                int numB = 0;
                int numC = numA / numB;
                Console.WriteLine("(2-2)numC = " + numC);
            }
            catch (Exception ex)
            {
                Console.WriteLine("(2-3)" + ex.Message);
            }
            finally
            {
                Console.WriteLine("(2-4)");
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(3):");
            try
            {
                Console.WriteLine("(3-1)");
                int numA = 1;
                int numB = 0;
                int numC = numA / numB;
                Console.WriteLine("(3-2)numC = " + numC);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("(3-3)" + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("(3-4)" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("(3-5)" + ex.Message);
            }
            finally
            {
                Console.WriteLine("(3-6)");
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(4):");
            try
            {
                Console.WriteLine("(4-1)");
                try
                {
                    Console.WriteLine("(4-2)");
                    int numA = 1;
                    int numB = 0;
                    int numC = numA / numB;
                    Console.WriteLine("(4-3)numC = " + numC);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("(4-4)" + ex.Message);
                }
                Console.WriteLine("(4-5)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("(4-6)" + ex.Message);
            }
            Console.WriteLine("(4-7)");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(5):");
            try
            {
                Console.WriteLine("(5-1)");
                try
                {
                    Console.WriteLine("(5-2)");
                    int numA = 1;
                    int numB = 0;
                    int numC = numA / numB;
                    Console.WriteLine("(5-3)numC = " + numC);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("(5-5)" + ex.Message);
                }
                Console.WriteLine("(5-5)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("(5-6)" + ex.Message);
            }
            Console.WriteLine("(5-7)");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(6):");
            try
            {
                Console.WriteLine("(6-1)");
                TriggerUnexpectedEvent();
                Console.WriteLine("(6-2)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("(6-3)" + ex.Message);
            }
            Console.WriteLine("(6-4)");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(7):");
            try
            {
                Command1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
            }
            Console.WriteLine("(7):END");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(8):");
            try
            {
                Command2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
            }
            Console.WriteLine("(8):END");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("(9):");
            try
            {
                Console.WriteLine("(9-1)");
                throw new FoolProofException("Attention!");
                Console.WriteLine("(9-2)");
            }
            catch (FoolProofException ex)
            {
                Console.WriteLine("(9-3)" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("(9-4)" + ex.Message);
            }
            finally
            {
                Console.WriteLine("(9-5)");
            }
            Console.WriteLine("(9-6)");
        }

        private static void TriggerUnexpectedEvent()
        {
            Console.WriteLine("before TriggerUnexpectedEvent fun");
            throw new Exception("Unexpected event occurs.");
            Console.WriteLine("after  TriggerUnexpectedEvent fun");
        }

        private static void Command1()
        {
            try
            {
                Command3();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void Command2()
        {
            try
            {
                Command3();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void Command3()
        {
            throw new Exception("Command3 occurs unexpected event.");
        }
    }
}
