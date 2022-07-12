using System.Collections.Generic;

namespace Controllers.Models
{
    public class Answer
    {
        /// <summary>
        /// The List of operands
        /// </summary>
        public List<string> AllTerm { get; set; }

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
        /// The answer of the equation
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// The constructor initialize each properties
        /// </summary>
        public Answer()
        {
            AllTerm = new List<string>();
            CurrentValue = "";
            CurrentEquation = "";
        }

        public void UpdateWindow(string content)
        {
            AllTerm.Add(content);
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