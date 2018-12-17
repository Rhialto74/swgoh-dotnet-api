using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwgohHelpApi
{
    public class UriPathBuilder
    {
        private UriBuilder uriBuilder;

        public UriPathBuilder(string protocol, string host, int port)
        {
            uriBuilder = new UriBuilder(protocol, host, port);
        }

        public string SignIn
        {
            get
            {
                uriBuilder.Path = "/auth/signin/";
                return uriBuilder.ToString();
            }
        }

        public string Data
        {
            get
            {
                uriBuilder.Path = "/swgoh/data/";
                return uriBuilder.ToString();
            }
        }

        public string Player
        {
            get
            {
                uriBuilder.Path = "/swgoh/player/";
                return uriBuilder.ToString();
            }
        }

        public string Units
        {
            get
            {
                uriBuilder.Path = "/swgoh/units/";
                return uriBuilder.ToString();
            }
        }

        public string Zetas
        {
            get
            {
                uriBuilder.Path = "/swgoh/zetas/";
                return uriBuilder.ToString();
            }
        }

        public string Squads
        {
            get
            {
                uriBuilder.Path = "/swgoh/squads/";
                return uriBuilder.ToString();
            }
        }

        public string Events
        {
            get
            {
                uriBuilder.Path = "/swgoh/events/";
                return uriBuilder.ToString();
            }
        }

        public string Battles
        {
            get
            {
                uriBuilder.Path = "/swgoh/battles/";
                return uriBuilder.ToString();
            }
        }

        public string Guild
        {
            get
            {
                uriBuilder.Path = "/swgoh/guild/";
                return uriBuilder.ToString();
            }
        }

        public string Roster
        {
            get
            {
                uriBuilder.Path = "/swgoh/roster/";
                return uriBuilder.ToString();
            }
        }
    }
}
