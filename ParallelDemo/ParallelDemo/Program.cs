#region Namespaces
using System;
using System.Threading.Tasks;
#endregion

/// <summary>
/// Created By Utkarsh Bais 11/04/2019
/// </summary>
namespace ParallelDemo
{
    /// <summary>
    /// Program Class
    /// </summary>
    public class Program
    {
        #region Public : Print_Cat
        /// <summary>
        /// Function to Print Cat on console
        /// </summary>
        public void Print_Cat()
        {
            Console.WriteLine("Cat Start   :" + DateTime.Now);
            //Some work
            for (int i = 0; i < 1000000; i++)
            {
                i = i + 1;
            }
            Console.WriteLine("Cat End     :" + DateTime.Now);
        }
        #endregion

        #region Public : Print_Mouse
        /// <summary>
        /// Function to Print Mouse on console
        /// </summary>
        public void Print_Mouse()
        {
            Console.WriteLine("Mouse Start :" + DateTime.Now);
            //Some work
            for (int i = 0; i < 1000000; i++)
            {
                i = i + 1;
            }
            Console.WriteLine("Mouse End   :" + DateTime.Now);
        }
        #endregion

        #region Main Function
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">Arguments that can be passed to the function</param>
        static void Main(string[] args)
        {
            //Creating Object of Class Program
            Program obj = new Program();

            //Calling Print_Cat and Print_Mouse function in Parallel
            Parallel.Invoke(
                () => obj.Print_Cat(),
                () => obj.Print_Mouse()
                );

            //obj.Print_Cat();
            //obj.Print_Mouse();
            Console.ReadLine();
        }
        #endregion
    }
}