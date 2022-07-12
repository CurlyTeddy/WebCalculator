using System.Collections.Generic;
using Controllers.Models;

namespace CalculatorWebAPI
{
    public class GlobalVariables
    {
        public static readonly Dictionary<string, IButton> ButtonMap = new Dictionary<string, IButton>()
        {
            { Addition.Content, new Addition() }, { Substraction.Content, new Substraction() }, { Multiplication.Content, new Multiplication()},
            { Division.Content, new Division() }, { Sqrt.Content, new Sqrt() }, { LParenthesis.Content, new LParenthesis() },
            { RParenthesis.Content, new RParenthesis() }, { DoublePoint.Content, new DoublePoint()}, { CalculateResult.Content, new CalculateResult() },
            { AllWipe.Content, new AllWipe() }, { Backward.Content, new Backward() }, { EquationWipe.Content, new EquationWipe() }
        };

        public static Dictionary<int, Answer> IdentifierMap { get; set; } = new Dictionary<int, Answer>();
    }
}