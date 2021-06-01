namespace BMI_Weight_Calculator
{
    interface IBodyMassIndex
    {
        public double CalculateBMI(double weight, double height);
        public string ClassifyBMI(double bmi);
    }
}
