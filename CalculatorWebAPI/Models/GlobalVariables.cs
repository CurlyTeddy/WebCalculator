using System;
using System.Collections.Generic;

namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The global variables class
    /// </summary>
    public static class GlobalVariables
    {
        /// <summary>
        /// The dictionary maps the symbols sending from the user to corresponding class instance
        /// </summary>
        public static readonly Dictionary<string, IButton> ButtonMap = new Dictionary<string, IButton>()
        {
            { Addition.Content, new Addition() }, { Substraction.Content, new Substraction() }, { Multiplication.Content, new Multiplication()},
            { Division.Content, new Division() }, { Sqrt.Content, new Sqrt() }, { LParenthesis.Content, new LParenthesis() },
            { RParenthesis.Content, new RParenthesis() }, { DoublePoint.Content, new DoublePoint()}, { CalculateResult.Content, new CalculateResult() },
            { AllWipe.Content, new AllWipe() }, { Backward.Content, new Backward() }, { EquationWipe.Content, new EquationWipe() }
        };

        /// <summary>
        /// The dictionary record the identifier of a client
        /// </summary>
        public static Dictionary<int?, Answer> IdentifierMap { get; set; } = new Dictionary<int?, Answer>();

        /// <summary>
        /// The max online user number
        /// </summary>
        private const int UserLimit = 10000;

        /// <summary>
        /// The current number of online user
        /// </summary>
        public static int UserNumber { get; set; }

        /// <summary>
        /// The unique tokens that are used to identify each user
        /// </summary>
        public static int[] Token { get; set; } = new int[UserLimit];

        /// <summary>
        /// The constructor initializes token array by Fisher–Yates algorithm
        /// </summary>
        static GlobalVariables()
        {
            Random random = new Random();
            for (int i = 0; i < UserLimit; ++i)
            {
                Token[i] = i;
            }
            for (int i = 0; i < UserLimit - 1; ++i)
            {
                (Token[i], Token[random.Next(i, UserLimit)]) = (Token[random.Next(i, UserLimit)], Token[i]);
            }
        }
    }
}