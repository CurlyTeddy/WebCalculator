using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Controllers.Models
{
    public static class Tree
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ProduceSubtree(Stack<TreeNode> subtreeHead, Stack<string> operators)
        {
            TreeNode root = new TreeNode(operators.Pop());
            root.RightChild = subtreeHead.Pop();
            root.LeftChild = subtreeHead.Pop();
            subtreeHead.Push(root);
        }

        public static TreeNode ConstructTree()
        {
            Stack<TreeNode> subtreeHead = new Stack<TreeNode>();
            Stack<string> operators = new Stack<string>();

            // The priority of "(" must be the lowest, in order not to process "(" when meets the first operator in the parenthesis
            Dictionary<string, int> priority = new Dictionary<string, int>() { { "(", 1 }, { Addition.Content, 2 }, { Substraction.Content, 2 }, { Multiplication.Content, 3 }, { Division.Content, 3 } };

            foreach (string term in GlobalVariables.AllTerm)
            {
                if (term == "(" || term == Sqrt.Content)
                {
                    operators.Push(term);
                }
                else if (term == ")")
                {
                    // Only priority ascending order left, so processes from right to left
                    while (operators.Peek() != "(")
                    {
                        ProduceSubtree(subtreeHead, operators);
                    }
                    // Delete "("
                    operators.Pop();
                }
                else if (double.TryParse(term, out double dummy))
                {
                    // Check whether there's sqrt in front of the number
                    subtreeHead.Push(new TreeNode(term));
                    if (operators.Count != 0 && operators.Peek() == Sqrt.Content)
                    {
                        TreeNode root = new TreeNode(operators.Pop());
                        root.LeftChild = subtreeHead.Pop();
                        subtreeHead.Push(root);
                    }
                }
                else
                {
                    // The operator on the top of the stack might change
                    // so while loop is a must to ensure the operators with higher or same priority are processed
                    // This maintains the operations' priority in the stack is in ascending order
                    while (operators.Count != 0 && priority[operators.Peek()] >= priority[term])
                    {
                        ProduceSubtree(subtreeHead, operators);
                    }
                    operators.Push(term);
                }
            }

            // The operator and subtreeHead stack have following attributes after the for loop above executes
            // One is the operator stack is sort in non-strictly ascending priority order, two is the last operator won't be processed
            while(operators.Count != 0)
            {
                ProduceSubtree(subtreeHead, operators);
            }

            return subtreeHead.Pop();
        }

        public static void PreorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            GlobalVariables.PreorderEquation += root.Symbol;
            PreorderTraversal(root.LeftChild);
            PreorderTraversal(root.RightChild);
        }

        public static void PostorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PostorderTraversal(root.LeftChild);
            PostorderTraversal(root.RightChild);
            GlobalVariables.PostorderEquation += root.Symbol;
        }

        public static double CalculateTree(TreeNode root)
        {
            if(root.LeftChild == null && root.RightChild == null)
            {
                return double.Parse(root.Symbol);
            }
            else if (root.Symbol == Addition.Content)
            {
                return CalculateTree(root.LeftChild) + CalculateTree(root.RightChild);
            }
            else if (root.Symbol == Substraction.Content)
            {
                return CalculateTree(root.LeftChild) - CalculateTree(root.RightChild);
            }
            else if (root.Symbol == Multiplication.Content)
            {
                return CalculateTree(root.LeftChild) * CalculateTree(root.RightChild);
            }
            else if (root.Symbol == Division.Content)
            {
                return CalculateTree(root.LeftChild) / CalculateTree(root.RightChild);
            }
            else
            {
                return Math.Sqrt(CalculateTree(root.LeftChild));
            }
        }
    }
}
