using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qtracker
{
    class GlobalVar
    {
        public const string GlobalUrl = "http://www.tecque.com/qtracker/";

        static string _globalName;

        static int _globalID;

        static int _projectID;

        static string _projectName;

        static int _taskID;

        static string _taskName;

        static int _timeSpend;

        static int _browserSpend;

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

        public static int ProjectID
        {
            get
            {
                return _projectID;
            }
            set
            {
                _projectID = value;
            }
        }

        public static string ProjectName
        {
            get
            {
                return _projectName;
            }
            set
            {
                _projectName = value;
            }
        }

        public static int TaskID
        {
            get
            {
                return _taskID;
            }
            set
            {
                _taskID = value;
            }
        }

        public static string TaskName
        {
            get
            {
                return _taskName;
            }
            set
            {
                _taskName = value;
            }
        }

        public static int TimeSpend
        {
            get
            {
                return _timeSpend;
            }
            set
            {
                _timeSpend = value;
            }
        }
        public static int BrowserSpend
        {
            get
            {
                return _browserSpend;
            }
            set
            {
                _browserSpend = value;
            }
        }

        public static bool GlobalBoolean;
    }
}
