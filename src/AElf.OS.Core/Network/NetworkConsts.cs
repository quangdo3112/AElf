namespace AElf.OS.Network
{
    public static class NetworkConsts
    {
        public const int DefaultPeerDialTimeout = 3;
        public const int DefaultBlockRequestCount = 10;
        public const bool DefaultCompressBlocks = true;
        public const int DefaultMaxReceiveMessageLength = 30 * 1024 * 1024;
    }
}