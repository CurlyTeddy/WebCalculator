using System.Collections.Generic;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The minus button class
    /// </summary>
    public class Substraction : BaseOperation, IButton, INode
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Substraction()
        {
            Content = "-";
        }

        /// <summary>
        /// The method prepares all prerequisites for substraction calculation
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
            storage.Push(-storage.Pop() + storage.Pop());
        }
    }
}
