namespace Controllers.Models
{
    /// <summary>
    /// The clear button class
    /// </summary>
    public class AllWipe : IButton
    {
        /// <summary>
        /// The content of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static AllWipe()
        {
            Content = "C";
        }

        /// <summary>
        /// The method clears the screen and background variables
        /// </summary>
        public void Execute(Answer answer)
        {
            answer.CurrentEquation = "";
            answer.PreorderEquation = "";
            answer.PostorderEquation = "";
            answer.Result = "";
            answer.Reset();
        }
    }
}
