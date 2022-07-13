namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The tree node class
    /// </summary>
    public class TreeNode
    {
        /// <summary>
        /// The content of the tree node
        /// </summary>
        public string Symbol { get; }

        /// <summary>
        /// The Left child of the tree node
        /// </summary>
        public TreeNode LeftChild { get; set; }

        /// <summary>
        /// The right child of the tree node
        /// </summary>
        public TreeNode RightChild { get; set; }

        /// <summary>
        /// The interface containing the calculate method
        /// </summary>
        public INode Operation { get; }

        /// <summary>
        /// The constructor set the value of the node
        /// </summary>
        /// <param name="content">The term in the equation</param>
        /// <param name="operation">The interface containing the calculate method</param>
        public TreeNode(string content, INode operation)
        {
            Symbol = content;
            Operation = operation;
        }
    }
}
