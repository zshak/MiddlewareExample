using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class Logger
    {
        private enum MyEnum
        {
            Debug, Info, Warning, Error
        }
        
        private MyEnum m_Enum;
        public Logger(int level) 
        { 
            m_Enum = (MyEnum)(level);
        }


        public void AdditionalInfo(string timestamp, string logLevel, string logMessage)
        {
            Console.WriteLine(timestamp + " " + logLevel + " " + logMessage);
        }
        public void Debug(string debugMessage)
        {
            if(MyEnum.Debug > m_Enum)
            {
                Console.WriteLine(debugMessage);
            }

        }

        public void Info(string infoMessage) 
        {
            if (MyEnum.Info > m_Enum)
            {
                Console.WriteLine(infoMessage);
            }
        }
        public void Warning(string warningMessage) 
        {
            if (MyEnum.Warning > m_Enum)
            {
                Console.WriteLine(warningMessage);
            }
        }
        public void Error(string error) 
        {
            if (MyEnum.Error > m_Enum)
            {
                Console.WriteLine(error);
            }
        }
        public void LogToConsole(string logMessage)
        {
            Console.WriteLine(logMessage);
        }
    }
}
