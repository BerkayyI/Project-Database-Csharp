namespace Project_Database_Csharp
{
    public class Role {
        public string Name { get; private set; }
        public float HourlyWage { get; private set; }

        public Role(string name, float hourlyWage) {
            Name = name;
            HourlyWage = hourlyWage;
        }

        public float GetHourlyWage() {
            return HourlyWage;
        }
    }
}
