using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Exception
{
    public class ExceptionHandle
    {
        private static string _runMode = "DEV";
        private static void Init()
        {
            var reader = new System.Configuration.AppSettingsReader();
            _runMode = reader.GetValue("RUN_MODE", typeof(string)).ToString();
        }
        public static void Show(System.Exception inputException)
        {
            Init();
            switch (_runMode)
            {
                case "DEV":
                    MsgBoxException frm = new MsgBoxException(inputException);
                    frm.ShowDialog();
                    break;
                case "USER":
                    MsgBoxException userEx = new MsgBoxException(inputException);
                    userEx.ShowDialog();
                    break;
                default: break;
            }
        }
    }
}
