using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem_project.Models
{
    public class Suite
    {

        public Suite(string suiteType, int capacity, decimal diaryValue)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            DiaryValue = diaryValue;
        }
        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal DiaryValue { get; set; }
    }
}