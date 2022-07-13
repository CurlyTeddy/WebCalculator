namespace CalculatorWebAPI.Models
{
    /// <summary>
    /// The interface regulates the method that all buttons should implement
    /// </summary>
    public interface IButton
    {
        /// <summary>
        /// The method template
        /// </summary>
        /// <param name="identifier">The argument is used to identify the working area</param>
        void Execute(Answer identifier);
    }
}
