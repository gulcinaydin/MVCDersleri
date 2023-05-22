using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFiltreler.Models
{
    public class LogVeri
    {
        private static List<LogBilgi> loglistesi = new List<LogBilgi>();

        public static List<LogBilgi> Loglar
        {
            get { return loglistesi; }
        }

    }
}