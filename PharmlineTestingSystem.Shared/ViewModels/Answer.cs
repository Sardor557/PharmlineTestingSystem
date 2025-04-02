namespace PharmlineTestingSystem.Shared.ViewModels
{
    public sealed class Answer<T>
    {
        public Answer(bool isSuccess, string message, T data = default)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }


    public sealed class AnswerBasic
    {
        public AnswerBasic(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public bool IsSuccess { get; set; }
        public string Message { set; get; }
    }
}
