using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
    public interface ILog
    {
        void Trace(string message);
        void Warning(string message);
        void Info(string message);
        void Debug(string message);
        void Error(string message);
    }
}
