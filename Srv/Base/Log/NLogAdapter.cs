﻿using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
    public class NLogAdapter:SGLogDr,ILog
    {
        private readonly Logger logger = LogManager.GetLogger("Logger");

        public NLogAdapter(SGLogDr decorater = null) : base(decorater)
        {
        }
        public void Debug(string message)
        {
            this.logger.Debug(this.Decorate(message));
        }

        public void Error(string message)
        {
            this.logger.Error(this.Decorate(message));
        }

        public void Info(string message)
        {
            this.logger.Info(this.Decorate(message));
        }

        public void Trace(string message)
        {
            this.logger.Trace(this.Decorate(message));
        }

        public void Warning(string message)
        {
            this.logger.Warn(this.Decorate(message));
        }
    }
}
