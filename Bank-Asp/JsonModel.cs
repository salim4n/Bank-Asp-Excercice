namespace Bank_Asp
{
    public class JsonModel
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int CurrentBalance { get; set; }
    }
}

/*

"accountNumber": 1001,

    "accountHolderName": "Example Name",

    "currentBalance": 5000
*/