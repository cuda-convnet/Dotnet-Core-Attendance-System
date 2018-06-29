using System;

namespace WebApi.Entities
{
    public class Configuration
    {
        public Guid Id { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string GracePeriod { get; set; }
    }
}