using static Project_Database_Csharp.User;
using static Project_Database_Csharp.Role;
using static Project_Database_Csharp.Payroll;
using static Project_Database_Csharp.Shift;

namespace Project_Database_Csharp
{
    public class Worker {
        public User User { get; }
        public Role Role { get; }
        public float HoursWorked { get; private set; }
        public float MoneyEarned { get; private set; }

        public Worker(User user, Role role) {
            User = user;
            Role = role;
        }

        public User SignIn(string username, string password) {
            return User.SignIn(username, password);
        }

        public void SignOut() {
            User.SignOut();
        }

        public void StartShift() {
            HoursWorked = 0;
            MoneyEarned = 0;
        }

        public void EndShift() {
            // You can add any implementation needed when ending a shift
        }

        public float GetHoursWorked() {
            return HoursWorked;
        }

        public float GetMoneyEarned() {
            return MoneyEarned;
        }
    }

}
