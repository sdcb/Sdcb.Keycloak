namespace Sdcb.Keycloak
{
    public class ForwardedHttpHeaders
    {
        public string forwardedFor { get; set; }
        public string forwardedProto { get; set; }
        public string forwardedHost { get; set; }
    }
}
