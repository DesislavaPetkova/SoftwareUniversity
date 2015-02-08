using System;

class BankAccount
{
    static void Main()
    {
        string name = " Holder Name: Ivan Dragomirov Gradev";
        decimal balance = 32447.23m;
        string bankname = "Societe Generale Expressbank";
        string iban = "BG80BNBG96611020345678";
        long ccnumber1 = 4012888888881881;
        long ccnumber2 = 4012888888881834;
        long ccnumber3 = 4012888888881823;
        Console.WriteLine("{0},\n Balance Amount: {1};,\n Bank Name: {2};,\n IBAN Number: {3};,\n Credit Card Associated with the account: {4}, {5}, {6};", name, balance, bankname, iban, ccnumber1, ccnumber2, ccnumber3);

    }
}

