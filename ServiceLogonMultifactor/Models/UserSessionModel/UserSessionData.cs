﻿using System;
using ServiceLogonMultifactor.Configs.ApplicationConfig;

namespace ServiceLogonMultifactor.Models.UserSessionModel
{
    public class UserSessionData
    {
        public int SessionID { get; set; }
        public string IdRequest { get; set; }
        public DateTime SessionCreatedTimeStamp { get; set; }
        public UserConfig UserConfig { get; set; }
        public UserConfig UserConfigInTheFile { get; set; }
        public UserSessionDetails UserSessionDetails { get; set; }
        public int UserIndexInSettings { get; set; }
        public bool ShouldBeBlocked { get; set; } = true;
        public bool ShouldBeMessaged { get; set; } = true;
        public UInt32 InputBlockerProcessId { get; set; } = 0;
    }
}