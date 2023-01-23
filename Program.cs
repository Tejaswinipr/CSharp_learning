using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Logger.WriteLog("The End");
                
            }
            catch (Exception exception)
            {
                Logger.WriteLog(exception.Message);
            }
        }
    }
}
