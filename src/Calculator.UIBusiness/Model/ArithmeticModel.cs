namespace Calculator.UIBusiness.Model
{
    /// <summary>
    /// This is the model class for Calculator
    /// </summary>
    public class ArithmeticModel
    {
        public double Result { get; set; }
        public double TempNumber { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ArithmeticModel()
        {
            Result = 0;
            TempNumber = 1;
        }
        /// <summary>
        /// Returns the result
        /// </summary>
        public double Number
        {
            get { return Result;}
            set{Result = value;}

        }
       /// <summary>
       /// Add
       /// </summary>
       /// <param name="x">first number</param>
       /// <param name="y">Second number</param>
       /// <returns>result</returns>
        public double add(double x, double y)
        { return x + y; }

        /// <summary>
        /// Subtract
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <returns>result</returns>
        public double subtract(double x, double y)
        { return x - y; }

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <returns>result</returns>
        public double Multiply(double x, double y)
        { return x * y; }

        /// <summary>
        /// Divide
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <returns>result</returns>
        public double Divide(double x, double y)
        { return x / y; }

    }
}
