namespace BlazorWeb.Shared.Master
{
    public class AppSettingVm
    {
        public int Id { get; set; }
        public string ReferenceKey { get; set; } = String.Empty;
        public string Value { get; set; } = String.Empty;
        public string? Description { get; set; }
        public string Type { get; set; } = String.Empty;
    }
}
