using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The Sqrt button class
    /// </summary>
    public class Sqrt : IButton, INode
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Sqrt()
        {
            Content = "√";
        }

        /// <summary>
        /// The method prepares all prerequisites for sqrt calculation
        /// </summary>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public void Execute(Answer answer)
        {
            answer.UpdateWindow(this, Content);
        }
        
        /// <summary>
        /// The caluculation interface for result computing
        /// </summary>
        /// <param name="storage">The auxiliary data structure to calculate result</param>
        public void Calculate(Stack<double> storage)
        {
            storage.Push(Math.Sqrt(storage.Pop()));
        }
    }
}
