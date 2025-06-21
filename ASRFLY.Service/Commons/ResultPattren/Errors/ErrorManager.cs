using ASRFLY.Application.Commons.ResultPattren.Errors;

namespace ASRFLY.Application.Commons.Result.Errors
{
    /// <summary>
    /// A facade for retrieving localized error messages.
    /// </summary>
    public static class ErrorManager
    {
        
        /// <summary>
        /// Gets the localized error message for the given error code and language.
        /// </summary>
        /// <param name="code">The error code (e.g. "Error.NullValue").</param>
        /// <param name="language">The language code (e.g. "en", "pt").</param>
        /// <returns>The localized error message.</returns>
        public static string GetMessage(string code, string language = "en")
        {
            return ErrorMessages.GetMessage(code, language);
        }

        /// <summary>
        /// Gets the error message using the default language.
        /// </summary>
        /// <param name="code">The error code (e.g. "Error.NullValue").</param>
        /// <returns>The localized error message in the default language.</returns>
        public static string GetMessage(string code)
        {
            // Hardcoding default language here (could be modified to pull from configuration or culture info)
            return ErrorMessages.GetMessage(code, "en");
        }
    }
}
