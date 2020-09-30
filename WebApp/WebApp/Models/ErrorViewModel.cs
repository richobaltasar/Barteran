using System;

namespace WebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string MessageContent { get; set; }
        public string MessageTitle { get; set; }
    }
}
