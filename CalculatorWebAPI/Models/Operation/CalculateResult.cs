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
        public void Execute()
        {
            GlobalVariables.AllTerm.Add(GlobalVariables.CurrentValue);
            TreeNode root = Tree.ConstructTree();
            Tree.PreorderTraversal(root);
            Tree.PostorderTraversal(root);
            GlobalVariables.CurrentEquation += $"\r\n{GlobalVariables.PreorderEquation}\r\n{GlobalVariables.PostorderEquation}";
            GlobalVariables.Result = Tree.CalculateTree(root).ToString();

            GlobalVariables.Reset();
        }
    }
}
