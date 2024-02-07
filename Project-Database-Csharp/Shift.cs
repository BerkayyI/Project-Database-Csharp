using static Project_Database_Csharp.Worker;

namespace Project_Database_Csharp
{
    public class Shift {
        public Worker Worker { get; }
        public DateTime StartTime { get; private set; }
        public DateTime? EndTime { get; private set; }

        public Shift(Worker worker) {
            Worker = worker;
        }

        public void StartShift() {
            StartTime = DateTime.Now;
            Worker.StartShift();
        }

        public void EndShift() {
            EndTime = DateTime.Now;
            Worker.EndShift();
        }

        public DateTime GetStartTime() {
            return StartTime;
        }

        public DateTime? GetEndTime() {
            return EndTime;
        }
    }
}
