namespace PlannerApp.Shared.Responses
{
    public class ApiErrorResponse
    {
        public string message { get; set; }
        public string[] errors { get; set; }
        public bool isSuccess { get; set; }
    }

}
