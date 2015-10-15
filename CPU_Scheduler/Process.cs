using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPU_Scheduler
{
    public class Process
    {
        private int[] _cpuIoTime;
        private string _name;
        
        //set or get the cpu IO time array
        public int[] cpuIoTime 
        {
            get
            {
                return _cpuIoTime;
            }
            set 
            {
                _cpuIoTime = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        
        public int priority = 1;
        public int arriveTime = 0;
        public int timeOnReady = 0;
        public int timeOnIO = 0;
        public int responseTime = 0;
        public int finishTime = 0;
        public int index = 0;
        public int totalTime = 0;
        public bool finished = false;
        public bool firstExecution = true;

  
    }
}
