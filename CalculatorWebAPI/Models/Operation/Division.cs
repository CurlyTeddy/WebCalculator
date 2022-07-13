using System.Collections.Generic;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The divide button class
    /// </summary>
    public class Division : BaseOperation, IButton, INode
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Division()
        {
            Content = "÷";
        }

        /// <summary>
        /// The method prepares all prerequisites for division calculation
        /// </summary>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public void Execute(Answer answer)
        {
            SymbolWorks(this, Content, answer);
        }

        /// <summary>
        /// The caluculation interface for result computing
        /// </summary>
        /// <param name="storage">The auxiliary data structure to calculate result</param>
        public void Calculate(Stack<double> storage)
        {
            storage.Push(1 / storage.Pop() * storage.Pop());
        }
    }
}
