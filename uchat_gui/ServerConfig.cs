namespace uchat_gui
{
    public static class ServerConfig
    {
        public static string DefaultServerIp { get; set; } = "127.0.0.1";

        public static int DefaultServerPort { get; set; } = 5000;

        public static string GetServerIp()
        {
            var envIp = System.Environment.GetEnvironmentVariable("UCHAT_SERVER_IP");
            return !string.IsNullOrWhiteSpace(envIp) ? envIp : DefaultServerIp;
        }

        public static int GetServerPort()
        {
            var envPort = System.Environment.GetEnvironmentVariable("UCHAT_SERVER_PORT");
            if (!string.IsNullOrWhiteSpace(envPort) && int.TryParse(envPort, out int port))
            {
                return port;
            }
            return DefaultServerPort;
        }
    }
}

