using System.Collections.Generic;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The class of number buttons
    /// </summary>
    public class Number : IButton, INode
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
        /// <param name="answer">The argument specifies the working area to work with</param>
        public void Execute(Answer answer)
        {
            answer.CurrentValue += Content;
            answer.CurrentEquation = answer.CurrentEquation.Substring(0, answer.NextNumberStart) + answer.CurrentValue;
        }

        /// <summary>
        /// The caluculation interface for result computing
        /// </summary>
        /// <param name="storage">The auxiliary data structure to calculate result</param>
        public void Calculate(Stack<double> storage)
        {
            storage.Push(double.Parse(Content));
        }
    }
}
