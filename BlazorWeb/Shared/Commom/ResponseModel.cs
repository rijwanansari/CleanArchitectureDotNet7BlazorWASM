namespace BlazorWeb.Shared.Commom
{
    public class ResponseModel<T>
    {        
        public bool Success { get; set; }
        public string Message { get; set; }
        public T? Output { get; set; }
      
    }
}
