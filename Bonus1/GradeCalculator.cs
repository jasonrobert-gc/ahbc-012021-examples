using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus1
{
    public class GradeCalculator
    {
        public LetterGrade Calculate(int numberGrade)
        {
            if (numberGrade >= 88 && numberGrade <= 100)
            {
                return LetterGrade.A;
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                return LetterGrade.B;
            }
            else if (numberGrade >= 67 && numberGrade <= 79)
            {
                return LetterGrade.C;
            }
            else if (numberGrade >= 60 && numberGrade <= 66)
            {
                return LetterGrade.D;
            }
            else if (numberGrade >= 0 && numberGrade <= 59)
            {
                return LetterGrade.F;
            }
            else
            {
                // nameof(numberGrade) == "numberGrade"
                throw new ArgumentOutOfRangeException(nameof(numberGrade));
            }
        }
    }
}
