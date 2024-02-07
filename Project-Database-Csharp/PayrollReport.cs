namespace Project_Database_Csharp
{
  public class PayrollReport {
    public Worker Worker { get; }
    public float TotalHoursWorked { get; private set; }
    public float TotalMoneyEarned { get; private set; }

    public PayrollReport(Worker worker) {
      Worker = worker;
      TotalHoursWorked = worker.GetHoursWorked();
      TotalMoneyEarned = worker.GetMoneyEarned();
    }

    public void DisplayReport() {
      // Implement report display logic here
    }
  }
}
