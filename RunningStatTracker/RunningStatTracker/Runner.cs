﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningStatTracker
{
    class Runner
    {
        private List<Run> list_of_runs;
        private string name;
        private string gender;

        public Runner(string nameIn, string genderIn)
        {
            name = nameIn;
            gender = genderIn;
            list_of_runs = new List<Run>();
        }

        public string Name { get { return name; } }
        public string Gender { get { return gender; } }

        //add run
        public void AddRun(double min, double sec, double distance)
        {
            list_of_runs.Add(new Run(DateTime.Now, (min * 60) + sec, distance));
        }
        //get run by date
        public Run GetRunByDate(DateTime date)
        {
            Run run = null;
            foreach(Run x in list_of_runs)
            {
                if(date == x.Date)
                {
                    run = x;
                    break;
                }
            }
            return run;
        }
        //get total time ran
        public double TotalTimeRun()
        {
            double total = 0;
            foreach(Run run in list_of_runs)
            {
                total += run.Distance;
            }
            return total;
        }
        //get total distance
        public double TotalDistance()
        {
            double total = 0;
            foreach (Run run in list_of_runs)
            {
                total += run.Time_of_run;
            }
            return total;
        }
        //get mile average for a run
        //public 
        //get day of week average
        //get all run data
        //get all time stats
        //get average speed
    }
}