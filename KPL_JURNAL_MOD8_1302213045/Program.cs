// See https://aka.ms/new-console-template for more information

using KPL_JURNAL_MOD8_1302213045;
class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig bank = new BankTransferConfig();
        bank.readJSON();
    }
}