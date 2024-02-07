namespace Project_Database_Csharp
{
    public class Payroll {
        public PayrollReport GeneratePayrollReport(Worker worker) {
            // Implement payroll report generation logic here
            return new PayrollReport(worker);
        }
    }
}
