using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace KPL_JURNAL_MOD8_1302213045
{
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        List<string> methods = new List<string>() { "RTO(real - time)", "SKN", "RTGS", "BI FAST" };
        public transfer transfer { get; set; }
        public confirmation confirmation { get; set; }

        public BankTransferConfig()
        {
            this.lang = "en";
            this.transfer = new transfer();
            this.transfer.threshold = 25000000;
            this.transfer.low_fee = 6500;
            this.transfer.high_fee = 15000;
            this.confirmation = new confirmation();
            this.confirmation.en = "yes";
            this.confirmation.id = "ya";
        }
        public BankTransferConfig readJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string jsonString = File.ReadAllText(path + "/bank_transfer_config.json");
            return JsonSerializer.Deserialize<BankTransferConfig>(jsonString);
        }
        
    }
    public class transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set;}
    }
    public class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }
    public class methods
    {

    }
}
