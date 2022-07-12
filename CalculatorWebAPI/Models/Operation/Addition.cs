namespace Controllers.Models
{
    /// <summary>
    /// The add button class
    /// </summary>
    public class Addition : BaseOperation, IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Addition()
        {
            Content = "+";
        }

        /// <summary>
        /// The method does the work that meets the prerequisite
        /// </summary>
        public void Execute(Answer answer)
        {
            SymbolWorks(Content, answer);
        }
    }
}
