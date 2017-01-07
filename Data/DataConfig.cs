namespace Data
{
    public class DataConfig
    {
        public string ConnectionProvider { get; set; }
        public string Dialect { get; set; }
        public string ConnectionDriver { get; set; }
        public bool FormatSql { get; set; }
        public bool ShowSql { get; set; }
        public string ConnectionStringName { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public string MappingDirectory { get; internal set; }
    }
}