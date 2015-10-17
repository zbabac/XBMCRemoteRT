﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBMCRemoteRT.Models.Network
{
    public class ConnectionItem : NotifyBase
    {
        private int connectionId;
        public int ConnectionId
        {
            get { return connectionId; }
            set { 
                if( connectionId != value)
                {
                    connectionId = value;
                    NotifyPropertyChanged("ConnectionId");
                }
            }
        }

        private string connectionName;
        public string ConnectionName
        {
            get { return connectionName; }
            set
            {
                if (connectionName != value)
                {
                    connectionName = value;
                    NotifyPropertyChanged("ConnectionName");
                }
            }
        }
        

        
        private string ipAddress;
        public string IpAddress
        {
            get { return ipAddress; }
            set {
                if (ipAddress != value)
                {
                    ipAddress = value;
                    NotifyPropertyChanged("IpAddress");
                }
            }
        }

        private int port;
        public int Port
        {
            get { return port; }
            set
            {
                if (port != value)
                {
                    port = value;
                    NotifyPropertyChanged("Port");

                }
            }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    NotifyPropertyChanged("Username");
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    NotifyPropertyChanged("Password");
                }
            }
        }

        private MacAddress macAddress;
        public MacAddress MACAddress
        {
            get { return macAddress; }
            set
            {
                if (macAddress != value)
                {
                    macAddress = value;
                    NotifyPropertyChanged("MACAddress");
                }
            }
        }

        private IPAddress subnetMask;
        public IPAddress SubnetMask
        {
            get { return subnetMask; }
            set
            {
                if (subnetMask != value)
                {
                    subnetMask = value;
                    NotifyPropertyChanged("SubnetMask");
                }
            }
        }

        private bool autoWake;

        public bool AutoWake
        {
            get { return autoWake; }
            set
            {
                if (autoWake != value)
                {
                    autoWake = value;
                    NotifyPropertyChanged("AutoWake");
                }
            }
        }

        private bool isWakable;

        public bool IsWakable
        {
            get { return isWakable; }
            set
            {
                if (isWakable != value)
                {
                    isWakable = value;
                    NotifyPropertyChanged("IsWakable");
                }
            }
        }
        

        public int WakeUpTime { get; set; }

        public bool HasCredentials()
        {
            return password != null
                && password != string.Empty;
        }
    }
}

