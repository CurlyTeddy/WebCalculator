using System.Collections.Generic;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The add button class
    /// </summary>
    public class Addition : BaseOperation, IButton, INode
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Addition()
        {
            Content = "+";
        }

        /// <summary>
        /// The method prepares all prerequisites for plus calculation
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
            storage.Push(storage.Pop() + storage.Pop());
        }
    }
}
