using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SampleCalc.Models
{
    public class Logging {
        private static int _ALL = 100;
        private static int _INFO = 75;
        private static int _ERROR = 50;
        private static int _OFF = 0;

        private static String logFile = "c:\\samplecalc.log";
        private static int logLevel = _ALL;

        public static int ALL {
          get { return _ALL; }
        }
        public static int ERROR {
          get { return _ERROR; }
        }
        public static int INFO {
          get { return _INFO; }
        }
        public static int OFF {
          get { return _OFF; }
        }
        public static void append(String message, int level) {

          if (logLevel >= level) {
            DateTime dt = DateTime.Now;
            
            if (!File.Exists(logFile)) {
              FileStream fs = File.Create(logFile);
              fs.Close();
            }
            try {
              StreamWriter sw = File.AppendText(logFile);
              sw.WriteLine(dt.ToString("hh:mm:ss") + "|" + message);
              sw.Flush();
              sw.Close();
            } catch (Exception e) {
              Console.WriteLine(e.Message.ToString());
            }
          }
        }
    }
}
