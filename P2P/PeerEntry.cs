using System.Net.PeerToPeer;

namespace P2P
{
    public class PeerEntry
    {
        public PeerName PeerName { get; set; }
        public IP2PService ServiceProxy { get; set; }
        public string DisplayString { get; set; }
        public string Message { get; set; }
        public bool ButtonsEnabled { get; set; }
    }
}
