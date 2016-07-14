using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OAUTH.AuthenticationServer.Web.Constants;

namespace OAUTH.AuthenticationServer.Web.Data.Models
{
    public static class Clients
    {
        public readonly static Client Client1 = new Client
        {
            Id = "123",
            Secret = "asdf",
            RedirectUrl = Paths.AuthorizeCodeCallBackPath
        };

        public readonly static Client Client2 = new Client
        {
            Id = "ddd",
            Secret = "1qaz2wsx",
            RedirectUrl = Paths.ImplicitGrantCallBackPath
        };
    }

    public class Client
    {
        public string Id { get; set; }
        public string Secret { get; set; }
        public string RedirectUrl { get; set; }
    }
}