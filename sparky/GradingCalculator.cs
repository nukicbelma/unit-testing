using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sparky
{
    public class GradingCalculator
    {
        public int Score { get; set; }
        public int AttendeancePercentage { get; set; }
        public string GetGrade()
        {
            if(Score>90 && AttendeancePercentage>70)
                return "A";
            else
                if (Score > 80 && AttendeancePercentage > 60)
                return "B";
            else
                if (Score > 60 && AttendeancePercentage > 60)
                return "C";
            else
                return "F";
        }
    }
}
