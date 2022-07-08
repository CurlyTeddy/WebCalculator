namespace Controllers.Models
{
    /// <summary>
    /// The class of number buttons
    /// </summary>
    public class Number : IButton
    {
        /// <summary>
        /// The content of the button
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// The constuctor sets the number on the button
        /// </summary>
        /// <param name="buttonText">The argument passes the number on the button</param>
        public Number(string buttonText)
        {
            Content = buttonText;
        }

        /// <summary>
        /// The methods set the current number and the equation
        /// </summary>
        public void Execute()
        {
            GlobalVariables.CurrentValue += Content;
            GlobalVariables.CurrentEquation = GlobalVariables.CurrentEquation.Substring(0, GlobalVariables.NextNumberStart) + GlobalVariables.CurrentValue;
        }

        public static void NumberOperation(string nodeSymbol)
        {
            double number = double.Parse(nodeSymbol);
        }
    }
}
