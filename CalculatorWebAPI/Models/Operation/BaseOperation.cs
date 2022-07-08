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
        public static void SymbolWorks(string content)
        {
            if (GlobalVariables.CurrentValue != "")
            {
                GlobalVariables.AllTerm.Add(GlobalVariables.CurrentValue);
            }
            GlobalVariables.UpdateWindow(content);
            GlobalVariables.CurrentValue = "";
        }
    }
}
