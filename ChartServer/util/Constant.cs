using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChartServer.util
{
    public class Constant
    {
        public static string STUDENT_INFO_XML_PATH = System.Environment.CurrentDirectory + @"\Users.xml";

        public static Font info = new Font("宋体", 10, FontStyle.Regular);
        public static Font error = new Font("宋体", 10, FontStyle.Bold);
        public static Color errorColor = Color.Red;
        public static Color infoColor = Color.Black;
    }
}
