using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Models
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
        /// The constructor set the value of the node
        /// </summary>
        /// <param name="content">The term in the equation</param>
        public TreeNode(string content)
        {
            Symbol = content;
        }
    }
}
