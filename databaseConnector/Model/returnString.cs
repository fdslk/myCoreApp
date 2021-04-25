namespace databaseConnector.model{
    public class returnString
    {
        private bool success;
        private int code;
        private string data;

        public returnString(bool success = true, int code = 1, string data = "")
        {
            this.Success = success;
            this.Code = code;
            this.Data = data;
        }

        public bool Success { get => success; set => success = value; }
        public int Code { get => code; set => code = value; }
        public string Data { get => data; set => data = value; }
    }
}