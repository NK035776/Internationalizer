using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.BuildEngine;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Internalization
{
    class BuildTraget
    {
        //BasicFileLogger b;
        //public SolutionBuilder() { }

        [STAThread]
        public static void Compile(string projFilePath)
        {
            Microsoft.Build.Evaluation.Project p = new Microsoft.Build.Evaluation.Project(projFilePath);
            
            p.Build("C:\\");
        }

    }
}
