

using System;
using System.Threading;
using NLog;
using SG;

namespace Srv
{
    class Program
    {

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

          
                
       //      XmlConfigurator.Configure(new log4net.Repository.Hierarchy.Hierarchy(),new System.IO.FileInfo(args[0]));
            AxOneTSC one = new AxOneTSC();
            SynchronizationContext.SetSynchronizationContext(one);
            logger.Info("fyindex");
           // Log.Info("server start........................");
            try
            {
         //       log.Info("Entry number: ");

            }
            catch
            {

            }
            Console.ReadKey();
        }
    }
}
