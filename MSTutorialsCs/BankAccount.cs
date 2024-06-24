namespace MSTutorialsCs;


/* 
 - Es enthält eine 10-stellige Zahl, die das Bankkonto eindeutig identifiziert.
 - Es enthält eine Zeichenfolge, die den bzw. die Namen des Besitzers speichert.
 - Der Kontostand kann abgerufen werden.
 - Es akzeptiert Einzahlungen.
 - Es akzeptiert Abbuchungen.
 - Der anfängliche Kontostand muss positiv sein.
 - Abbuchungen dürfen nicht in einem negativen Kontostand resultieren.
 */
public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890;
    //Member Eigenschaften
    public string Number { get;  }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }
    
    //Konstruktor der Klasse BankAccount
    public BankAccount(string name, decimal initialBalance)
    {
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;

        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
    }



    private List<Transaction> _allTransactions = new List<Transaction>();

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }

        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }
    
    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }

        return report.ToString();
    }

}
    

