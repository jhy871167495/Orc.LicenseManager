﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NetworkLicenseUsage.cs" company="Orchestra development team">
//   Copyright (c) 2008 - 2014 Orchestra development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.LicenseManager.Models
{
    using System;

    public class NetworkLicenseUsage
    {
        #region Constructors
        public NetworkLicenseUsage(string computerId, string ip, DateTime startDateTime)
        {
            ComputerId = computerId;
            Ip = ip;
            StartDateTime = startDateTime;
        }
        #endregion

        public string ComputerId { get; private set; }

        public string Ip { get; private set; }

        public DateTime StartDateTime { get; private set; } 
    }
}