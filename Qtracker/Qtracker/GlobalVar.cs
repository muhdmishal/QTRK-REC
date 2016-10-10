using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qtracker
{
    public static class GlobalVar
    {
        public const string GlobalUrl = "http://localhost/qtracker/";

        static string _globalName;

        static int _globalID;

        public static string GlobalName
        {
            get
            {
                return _globalName;
            }
            set
            {
                _globalName = value;
            }
        }

        public static int GlobalID
        {
            get
            {
                return _globalID;
            }
            set
            {
                _globalID = value;
            }
        }

        public static bool GlobalBoolean;
    }
}
