namespace Controllers.Models
{
    /// <summary>
    /// The multiply button class
    /// </summary>
    public class Multiplication : BaseOperation, IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Multiplication()
        {
            Content = "×";
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
