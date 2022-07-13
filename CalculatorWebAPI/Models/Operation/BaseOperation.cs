namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The base class of operators
    /// </summary>
    public class BaseOperation
    {
        /// <summary>
        /// The method prepares for calculating result
        /// </summary>
        /// <param name="operation">The operation binds with the symbol for later calculation</param>
        /// <param name="content">The argument is the symbol of the operation</param>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public static void SymbolWorks(INode operation, string content, Answer answer)
        {
            if (answer.CurrentValue != "")
            {
                answer.AllTerm.Add((answer.CurrentValue, new Number(answer.CurrentValue)));
            }
            answer.UpdateWindow(operation, content);
            answer.CurrentValue = "";
        }
    }
}
