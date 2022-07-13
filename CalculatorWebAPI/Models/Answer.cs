using System.Collections.Generic;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The class of working area
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// The List of all the terms in the equation
        /// </summary>
        public List<(string, INode)> AllTerm { get; set; }

        /// <summary>
        /// The value behinds the last operator
        /// </summary>
        public string CurrentValue { get; set; }

        /// <summary>
        /// The variable is set dynamically to record the position of the last operator
        /// </summary>
        public int NextNumberStart { get; set; }

        /// <summary>
        /// The current equation
        /// </summary>
        public string CurrentEquation { get; set; }

        /// <summary>
        /// The preorder equation
        /// </summary>
        public string PreorderEquation { get; set; }

        /// <summary>
        /// The postorder equation
        /// </summary>
        public string PostorderEquation { get; set; }

        /// <summary>
        /// The auxiliary stack for calculation process
        /// </summary>
        public Stack<double> CalculationStack { get; set; }

        /// <summary>
        /// The result of the calculation
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// The constructor initialize each properties
        /// </summary>
        public Answer()
        {
            AllTerm = new List<(string, INode)>();
            CurrentValue = "";
            CurrentEquation = "";
            CalculationStack = new Stack<double>();
        }

        /// <summary>
        /// The method that adds number to the list and updates the user interface
        /// </summary>
        /// <param name="operation">The interface containing calculation method</param>
        /// <param name="content">The content to show on the user interface</param>
        public void UpdateWindow(INode operation, string content)
        {
            AllTerm.Add((content, operation));
            CurrentEquation += content;
            NextNumberStart = CurrentEquation.Length;
        }

        /// <summary>
        /// The method resets background variables
        /// </summary>
        public void Reset()
        {
            AllTerm.Clear();
            NextNumberStart = 0;
            CurrentValue = "";
        }
    }
}