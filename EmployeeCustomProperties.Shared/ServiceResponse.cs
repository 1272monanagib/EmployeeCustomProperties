namespace EmployeeCustomProperties.Shared
{
    public class ServiceResponse<T>
    {
        public ServiceResponse(T data , string errorMessage= "")
        {
            Data = data;
            ErrorMessage = errorMessage;
        }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsSuccess => string.IsNullOrEmpty(ErrorMessage);

    }
}
