using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    interface ICountVectorizer
    {
        public string[] Featurenames { get; }
        void Fit(string[] courpus);
        int[,] Transform(string[] courpus);
        int[,] FitTransform(string[] courpus);



    }
}
