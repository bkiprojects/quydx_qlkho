using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON
{
    public class ReadDataConfig
    {
        public ReadDataConfig()
        {

        }
        public static string ReadByKey(string key)
        {
            var reader = new System.Configuration.AppSettingsReader();
            var resultObject = reader.GetValue(key, typeof(string));
            if (resultObject == null)
            {
                throw new System.Exception("Không có key này trong DataConfig");
            }

            return resultObject.ToString();
        }
    }
}
