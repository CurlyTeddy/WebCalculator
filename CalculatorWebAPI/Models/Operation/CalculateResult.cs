namespace Controllers.Models
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
        /// The function of the button
        /// </summary>
        public void Execute(Answer answer)
        {
            answer.AllTerm.Add(answer.CurrentValue);
            TreeNode root = Tree.ConstructTree(answer);
            Tree.PreorderTraversal(root, answer);
            Tree.PostorderTraversal(root, answer);
            answer.CurrentEquation += $"\r\n{answer.PreorderEquation}\r\n{answer.PostorderEquation}";
            answer.Result = Tree.CalculateTree(root).ToString();

            answer.Reset();
        }
    }
}
