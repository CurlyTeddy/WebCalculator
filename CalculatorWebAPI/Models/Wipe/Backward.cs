using System;
using System.Net;
using System.Web.Http;

namespace CalculatorWebAPI.Models
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
        public void Execute(Answer answer)
        {
            try
            {
                answer.CurrentValue = answer.CurrentValue.Remove(answer.CurrentValue.Length - 1);
                answer.CurrentEquation = answer.CurrentEquation.Remove(answer.CurrentEquation.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}
