namespace Controllers.Models
{
    /// <summary>
    /// The minus button class
    /// </summary>
    public class Substraction : BaseOperation, IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Substraction()
        {
            Content = "-";
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
