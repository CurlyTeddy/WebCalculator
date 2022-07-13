using System.Collections.Generic;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The interface to give convenience for calculation
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// The caluculation interface for result computing
        /// </summary>
        /// <param name="storage">The auxiliary data structure to calculate result</param>
        void Calculate(Stack<double> storage);
    }
}
