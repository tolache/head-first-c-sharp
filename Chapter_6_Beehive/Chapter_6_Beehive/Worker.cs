namespace Chapter_6_Beehive
{
    class Worker
    {
        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        private string[] jobsICanDo;
        public string CurrentJob { get; private set; }
        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
        }
        private int shiftsToWork;
        private int shiftsWorked;

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (string.IsNullOrEmpty(CurrentJob))
            {
                foreach (string jobICanDo in jobsICanDo)
                {
                    if (jobICanDo == job)
                    {
                        CurrentJob = job;
                        shiftsToWork = numberOfShifts;
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(CurrentJob))
            {
                return false;
            }

            shiftsWorked++;

            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                CurrentJob = "";
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
