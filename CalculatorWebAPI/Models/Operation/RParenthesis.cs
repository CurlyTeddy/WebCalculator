using System.Collections.Generic;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The right parenthesis class
    /// </summary>
    public class RParenthesis : IButton, INode
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the number on the button
        /// </summary>
        static RParenthesis()
        {
            Content = ")";
        }

        /// <summary>
        /// The method prepares all prerequisites for right parenthesis
        /// </summary>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public void Execute(Answer answer)
        {
            answer.AllTerm.Add((answer.CurrentValue, new Number(answer.CurrentValue)));
            answer.UpdateWindow(this, Content);
            answer.CurrentValue = "";
        }

        /// <summary>
        /// The caluculation interface for result computing
        /// </summary>
        /// <param name="storage">The auxiliary data structure to calculate result</param>
        public void Calculate(Stack<double> storage)
        {
            // Parenthesis don't need to perform calculation
        }
    }
}
