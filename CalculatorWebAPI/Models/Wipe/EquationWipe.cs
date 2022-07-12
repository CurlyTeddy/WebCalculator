namespace Controllers.Models
{
    /// <summary>
    /// The class of clear entry button
    /// </summary>
    public class EquationWipe : IButton
    {
        /// <summary>
        /// The content of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static EquationWipe()
        {
            Content = "CE";
        }
        /// <summary>
        /// The method represents clear entry button's function
        /// </summary>
        public void Execute(Answer answer)
        {
            answer.CurrentEquation = "";
            answer.PreorderEquation = "";
            answer.PostorderEquation = "";
            answer.Reset();
        }
    }
}
