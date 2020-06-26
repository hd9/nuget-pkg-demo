﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HildenCo.Core.Infrastructure.Options
{
    public class SmtpOptions
    {
        public string Host { get; set; }
        public int  Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
    }
}
