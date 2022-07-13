using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The calculation tree class
    /// </summary>
    public static class Tree
    {
        /// <summary>
        /// The method produces subtree that is rooted by operator
        /// </summary>
        /// <param name="subtreeHead">The stack stores the root of all subtrees</param>
        /// <param name="operators">The stack stores all the operators</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ProduceSubtree(Stack<TreeNode> subtreeHead, Stack<(string, INode)> operators)
        {
            (string content, INode operation) = operators.Pop();
            TreeNode root = new TreeNode(content, operation)
            {
                RightChild = subtreeHead.Pop(),
                LeftChild = subtreeHead.Pop()
            };
            subtreeHead.Push(root);
        }

        /// <summary>
        /// The method constructs the calculation tree
        /// </summary>
        /// <param name="answer">The argument specifies the working area to work with</param>
        /// <returns>The root of the calculation tree</returns>
        public static TreeNode ConstructTree(Answer answer)
        {
            Stack<TreeNode> subtreeHead = new Stack<TreeNode>();
            Stack<(string content, INode operation)> operators = new Stack<(string, INode)>();

            // The priority of "(" must be the lowest, in order not to process "(" when meets the first operator in the parenthesis
            Dictionary<string, int> priority = new Dictionary<string, int>() { { "(", 1 }, { Addition.Content, 2 }, { Substraction.Content, 2 }, { Multiplication.Content, 3 }, { Division.Content, 3 } };

            foreach ((string content, INode method) in answer.AllTerm)
            {
                if (content == "(" || content == Sqrt.Content)
                {
                    operators.Push((content, method));
                }
                else if (content == ")")
                {
                    // Only priority ascending order left, so processes from right to left
                    while (operators.Peek().content != "(")
                    {
                        ProduceSubtree(subtreeHead, operators);
                    }
                    // Delete "("
                    operators.Pop();
                }
                else if (double.TryParse(content, out double dummy))
                {
                    // Check whether there's sqrt in front of the number
                    subtreeHead.Push(new TreeNode(content, method));
                    if (operators.Count != 0 && operators.Peek().content == Sqrt.Content)
                    {
                        (string sqrt, INode sqrtOperation) = operators.Pop();
                        TreeNode root = new TreeNode(sqrt, sqrtOperation)
                        {
                            LeftChild = subtreeHead.Pop()
                        };
                        subtreeHead.Push(root);
                    }
                }
                else
                {
                    // The operator on the top of the stack might change
                    // so while loop is a must to ensure the operators with higher or same priority are processed
                    // This maintains the operations' priority in the stack is in ascending order
                    while (operators.Count != 0 && priority[operators.Peek().content] >= priority[content])
                    {
                        ProduceSubtree(subtreeHead, operators);
                    }
                    operators.Push((content, method));
                }
            }

            // The operator and subtreeHead stack have following attributes after the for loop above executes
            // One is the operator stack is sort in non-strictly ascending priority order, two is the last operator won't be processed
            while (operators.Count != 0)
            {
                ProduceSubtree(subtreeHead, operators);
            }

            return subtreeHead.Pop();
        }

        /// <summary>
        /// The method traversals the tree in preorder
        /// </summary>
        /// <param name="root">The root of the tree to traversal</param>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public static void PreorderTraversal(TreeNode root, Answer answer)
        {
            if (root == null)
            {
                return;
            }

            answer.PreorderEquation += root.Symbol;
            PreorderTraversal(root.LeftChild, answer);
            PreorderTraversal(root.RightChild, answer);
        }

        /// <summary>
        /// The method traversals the tree in postorder
        /// </summary>
        /// <param name="root">The root of the tree to traversal</param>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public static void PostorderTraversal(TreeNode root, Answer answer)
        {
            if (root == null)
            {
                return;
            }

            PostorderTraversal(root.LeftChild, answer);
            PostorderTraversal(root.RightChild, answer);
            answer.PostorderEquation += root.Symbol;
        }

        /// <summary>
        /// The method calculates the result based on the tree
        /// </summary>
        /// <param name="root">The root of the tree to traversal</param>
        /// <param name="answer">The argument specifies the working area to work with</param>
        public static void CalculateTree(TreeNode root, Answer answer)
        {
            if (root == null)
            {
                return;
            }

            CalculateTree(root.LeftChild, answer);
            CalculateTree(root.RightChild, answer);
            root.Operation.Calculate(answer.CalculationStack);
        }
    }
}
