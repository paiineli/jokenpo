using JokenpoApp.Enums;

namespace JokenpoApp.Models
{
    public class Match
    {
        public string Player { get; set; } = string.Empty;

        public string Computer { get; set; } = string.Empty;

        public string Result { get; set; } = string.Empty;

        public Move PlayerMove { get; set; }

        public Move ComputerMove { get; set; }
    }
}
