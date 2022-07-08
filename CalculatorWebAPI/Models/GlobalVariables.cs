using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Models
{
    /// <summary>
    /// The class of global variable
    /// </summary>
    public static class GlobalVariables
    {
        /// <summary>
        /// The List of operands
        /// </summary>
        public static List<string> AllTerm { get; set; }

        /// <summary>
        /// The value behinds the last operator
        /// </summary>
        public static string CurrentValue { get; set; }

        /// <summary>
        /// The variable is set dynamically to record the position of the last operator
        /// </summary>
        public static int NextNumberStart { get; set; }

        /// <summary>
        /// The current equation
        /// </summary>
        public static string CurrentEquation { get; set; }

        /// <summary>
        /// The preorder equation
        /// </summary>
        public static string PreorderEquation { get; set; }

        /// <summary>
        /// The postorder equation
        /// </summary>
        public static string PostorderEquation { get; set; }

        /// <summary>
        /// The answer of the equation
        /// </summary>
        public static string Result { get; set; }

        /// <summary>
        /// The constructor initialize each properties
        /// </summary>
        static GlobalVariables()
        {
            AllTerm = new List<string>();
            CurrentValue = "";
            CurrentEquation = "";
        }

        public static void UpdateWindow(string content)
        {
            AllTerm.Add(content);
            CurrentEquation += content;
            NextNumberStart = CurrentEquation.Length;
        }

        /// <summary>
        /// The method resets background variables
        /// </summary>
        public static void Reset()
        {
            AllTerm.Clear();
            NextNumberStart = 0;
            CurrentValue = "";
        }
    }
}
