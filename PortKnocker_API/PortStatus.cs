namespace PortKnocker_API
{
    public class PortStatus
    {
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public int PortNumber { get; set; }
        public bool IsOpen { get; set; }
    }
}