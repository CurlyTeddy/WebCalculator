namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The class of equal button
    /// </summary>
    public class CalculateResult : IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constructor sets the button's symbol
        /// </summary>
        static CalculateResult()
        {
            Content = "=";
        }

        /// <summary>
        /// The function of the equal button
        /// </summary>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public void Execute(Answer answer)
        {
            // Pushes the last number to the list
            answer.AllTerm.Add((answer.CurrentValue, new Number(answer.CurrentValue)));
            // Compute process
            TreeNode root = Tree.ConstructTree(answer);
            Tree.PreorderTraversal(root, answer);
            Tree.PostorderTraversal(root, answer);
            Tree.CalculateTree(root, answer);
            // Updates the user interface
            answer.CurrentEquation += $"\r\n{answer.PreorderEquation}\r\n{answer.PostorderEquation}";
            answer.Result = answer.CalculationStack.Pop().ToString();
            // Clears data structure
            answer.Reset();
        }
    }
}
