
// Create car objects
using MohammedNajmOOP;

//Car car1 = new Car("Toyota", "Camry", 2020);
//Car car2 = new Car("Honda", "Civic", 2022);
//Car car3 = new Car("Ford", "Mustang", 2021);

//Call methods
//car1.Start();
//car1.Stop();
//car2.Start();
//car2.Stop();
//car3.Start();
//car3.Stop();

//Student student1 = new Student("Ali", 16, "10th");
//student1.Introduce();

//Rectangle rect = new Rectangle(5.0, 3.0);
//Console.WriteLine("Area: " + rect.Area());
//Console.WriteLine("Perimeter: " + rect.Perimeter());

BankAccount account = new BankAccount("123456789", 500);
account.CheckBalance();
account.Deposit(200);
account.Withdraw(100);
// سحب أكبر من الرصيد
account.Withdraw(700); 
account.CheckBalance();