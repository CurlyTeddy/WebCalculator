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
        public void Execute(Answer answer)
        {
            answer.CurrentValue += Content;
            answer.CurrentEquation = answer.CurrentEquation.Substring(0, answer.NextNumberStart) + answer.CurrentValue;
        }

        public static void NumberOperation(string nodeSymbol)
        {
            double number = double.Parse(nodeSymbol);
        }
    }
}
