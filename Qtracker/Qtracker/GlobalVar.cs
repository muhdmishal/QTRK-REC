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

        static int _projectID;

        static string _projectName;

        static int _taskID;

        static string _taskName;

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

        public static bool GlobalBoolean;
    }
}
