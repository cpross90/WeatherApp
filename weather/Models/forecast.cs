namespace weather.Models
{
    class forecast
    {
        public string? summary { get; set; }
        public string? percipProbability { get; set; }
        public string? percipType { get; set; }
        public string? temperature { get; set; }
        public string? humidity { get; set; }
        public string? uvIndex { get; set; }
        public string? visibility { get; set; }
    }
}