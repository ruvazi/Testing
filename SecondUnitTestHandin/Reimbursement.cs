using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondUnitTestHandin
{
    public class Reimbursement
    {
        // reimbursement function
        public int reimbursementPercentage(bool deductableMet, string TypeOfVisit)
        {
            
            if (!deductableMet) return 0;

            else if (TypeOfVisit == "d" || TypeOfVisit == "doctor") return 50;

            else if (TypeOfVisit == "h" || TypeOfVisit == "hospital") return 80;

            else return 0;
        }

    }
}

