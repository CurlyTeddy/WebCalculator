namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The dot button class
    /// </summary>
    public class DoublePoint : IButton
    {
        /// <summary>
        /// The content of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static DoublePoint()
        {
            Content = ".";
        }

        /// <summary>
        /// The method adds a dot to current value and displayed equation
        /// </summary>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public void Execute(Answer answer)
        {
            answer.CurrentEquation += Content;
            answer.CurrentValue += Content;
        }
    }
}
