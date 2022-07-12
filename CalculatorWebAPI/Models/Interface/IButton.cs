namespace Controllers.Models
{
    /// <summary>
    /// The interface regulates the method that all buttons should implement
    /// </summary>
    public interface IButton
    {
        /// <summary>
        /// The method template
        /// </summary>
        void Execute(Answer identifier);
    }
}
