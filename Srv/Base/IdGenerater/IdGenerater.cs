using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
    public class IdGenerater
    {
        public static long Aid { private get; set; }
        private static ushort value;
        public static long GenId()
        {
            long time = TimeHelper.ClientNowSeconds();
            return (Aid << 48) + (time << 16) + ++value;

        }
    }
}
