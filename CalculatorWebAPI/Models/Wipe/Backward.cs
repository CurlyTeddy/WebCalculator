using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Controllers.Models
{
    /// <summary>
    /// The backspace class
    /// </summary>
    public class Backward : IButton
    {
        /// <summary>
        /// The content of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Backward()
        {
            Content = "←";
        }

        /// <summary>
        /// The method deletes one digit of current value
        /// </summary>
        public void Execute()
        {
            try
            {
                GlobalVariables.CurrentValue = GlobalVariables.CurrentValue.Remove(GlobalVariables.CurrentValue.Length - 1);
                GlobalVariables.CurrentEquation = GlobalVariables.CurrentEquation.Remove(GlobalVariables.CurrentEquation.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                
            }
        }
    }
}
