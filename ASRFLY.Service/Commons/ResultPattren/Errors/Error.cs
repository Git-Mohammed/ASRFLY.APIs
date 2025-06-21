using ASRFLY.Application.Commons.Result.Errors;

namespace ASRFLY.Application.Commons.ResultPattren.Errors
{
    public record Error(string Code)
    {
        public string Message => ErrorManager.GetMessage(Code, CurrentLanguage);

        public static string CurrentLanguage { get; set; } = "en";

        public static readonly Error None = new(string.Empty);
        public static readonly Error NullValue = new(nameof(NullValue));
        public static readonly Error NotFound = new(nameof(NotFound));
        public static readonly Error Invalid = new(nameof(Invalid));
        public static readonly Error Unauthorized = new(nameof(Unauthorized));
        public static readonly Error Conflict = new(nameof(Conflict));
        public static readonly Error Failure = new(nameof(Failure));
    }
}
