using BankAccountApp;

var bankAccountService = new BankAccount();

Console.WriteLine($"Initial Balance: {bankAccountService.Balance}");

bankAccountService.Deposit(500);
bankAccountService.Withdraw(2500);
bankAccountService.Withdraw(100);
bankAccountService.Deposit(3000);
bankAccountService.Withdraw(200);