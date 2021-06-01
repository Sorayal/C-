using System;

namespace BMI_Weight_Calculator.Implementations
{
    public sealed class BodyMassIndex : IBodyMassIndex
    {
        private static BodyMassIndex bmiObject = null;

        private BodyMassIndex(){}

        public static BodyMassIndex GetBMIObject
        {
            get
            {
                if (bmiObject == null)
                {
                    bmiObject = new BodyMassIndex();                 
                }
                return bmiObject;
            }
        }


        public double CalculateBMI(double weight, double height)
        {
            return weight / Math.Pow(height, 2);
        }

        public string ClassifyBMI(double bmi)
        {
            if (bmi < 16)
                return "Severe Thinness";
            else if (bmi >= 16 && bmi < 17)
                return "Moderate Thiness";
            else if (bmi >= 17 && bmi < 18.5)
                return "Mild Thiness";
            else if (bmi >= 18.5 && bmi < 25)
                return "Normal";
            else if (bmi >= 25 && bmi < 30)
                return "Overweight";
            else if (bmi >= 30 && bmi < 35)
                return "Obese Class 1";
            else if (bmi >= 35 && bmi < 40)
                return "Obese Class 2";
            else
                return "Obese Class 3";
        }
    }
}
