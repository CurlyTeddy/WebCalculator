namespace Controllers.Models
{
    /// <summary>
    /// The right parenthesis class
    /// </summary>
    public class RParenthesis : IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the number on the button
        /// </summary>
        static RParenthesis()
        {
            Content = ")";
        }

        /// <summary>
        /// 
        /// </summary>
        public void Execute()
        {
            GlobalVariables.AllTerm.Add(GlobalVariables.CurrentValue);
            GlobalVariables.UpdateWindow(Content);
            GlobalVariables.CurrentValue = "";
        }
    }
}
