#C-Project-Database
#A school project in C#, working with databases.

Steps:

1. User class

Attributes:

username: string (private set) birthday: DateTime (private set) name: string (private set, optional) password: string (private set) Methods:

SignIn(string username, string password): User SignOut(): void GetName(): string GetBirthday(): DateTime SetName(string name): void

2. Worker class

Attributes:

user: User (composition) role: Role (aggregation) hoursWorked: float (private set) moneyEarned: float (private set) Methods:

SignIn(string username, string password): User SignOut(): void StartShift(): void EndShift(): void GetHoursWorked(): float GetMoneyEarned(): float

3. Role class

Attributes:

name: string (private set) hourlyWage: float (private set) Methods:

GetName(): string GetHourlyWage(): float

4. Shift class

Attributes:

worker: Worker (aggregation) startTime: DateTime (private set) endTime: DateTime (private set, optional) Methods:

StartShift(): void EndShift(): void GetStartTime(): DateTime GetEndTime(): DateTime

5. Payroll class

Methods: GeneratePayrollReport(Worker worker): PayrollReport

6. PayrollReport class

Attributes:

worker: Worker totalHoursWorked: float totalMoneyEarned: float Methods:

DisplayReport(): void
