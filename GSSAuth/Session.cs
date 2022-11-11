using IdentityServer4.Models;
using System.Collections.Specialized;

namespace GSSAuth
{
    public class Session
    {
        public Dictionary<string, Message<NameValueCollection>> Messages { get; set; } = new Dictionary<string, Message<NameValueCollection>>();
    }
}