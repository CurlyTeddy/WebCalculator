namespace Controllers.Models
{
    /// <summary>
    /// The base class of operators
    /// </summary>
    public class BaseOperation
    {
        /// <summary>
        /// The method prepares for calculating result
        /// </summary>
        /// <param name="content">The argument is the symbol of the operation</param>
        public static void SymbolWorks(string content, Answer answer)
        {
            if (answer.CurrentValue != "")
            {
                answer.AllTerm.Add(answer.CurrentValue);
            }
            answer.UpdateWindow(content);
            answer.CurrentValue = "";
        }
    }
}
