﻿namespace Chapter_6_Beehive_2._0
{
    class Queen : Bee
    {
        public Queen(double weightMg, Worker[] workers) : base(weightMg)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber;

        public bool AssignWork(string job, int numberOfShifts)
        {
            foreach (Worker worker in workers)
            {
                if (worker.DoThisJob(job, numberOfShifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkNextShift()
        {
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            double totalHoneyConsumed = HoneyConsumptionRate();

            for (int i = 0; i < workers.Length; i++)
            {
                totalHoneyConsumed += workers[i].HoneyConsumptionRate();

                if (workers[i].DidYouFinish())
                {
                    report += "Worker #" + (i+1) + " has finished the job\r\n";
                }
                else if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                }
                else if (workers[i].ShiftsLeft > 0)
                {
                    report += "Worker #" + (i + 1) + " is doing " + workers[i].CurrentJob + " for " + workers[i].ShiftsLeft + " more shifts\r\n";
                }
                else
                {
                    report += "Worker #" + (i + 1) + " will be done with " + workers[i].CurrentJob + " after this shift\r\n";
                }
            }

            report += "Total honey consumed for the shift: " + totalHoneyConsumed + " units";
            return report;
        }
    }
}
