using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler
{
    public partial class Form1 : Form
    {
        int tQ = 0;
        bool editedbool = false;
        public int clock = 0;
        public static Process P1 = new Process();
        public static Process P2 = new Process();
        public static Process P3 = new Process();
        public static Process P4 = new Process();
        public static Process P5 = new Process();
        public static Process P6 = new Process();
        public static Process P7 = new Process();
        public static Process P8 = new Process();
        public static Process P9 = new Process();
        public static Process P1R = new Process();
        public static Process P2R = new Process();
        public static Process P3R = new Process();
        public static Process P4R = new Process();
        public static Process P5R = new Process();
        public static Process P6R = new Process();
        public static Process P7R = new Process();
        public static Process P8R = new Process();
        public static Process P9R = new Process();
        ProcessEditor pEditorWindow = new ProcessEditor();
        DynamicExecutionConsole dynamicConsole = new DynamicExecutionConsole();
        ResultsWindow resultsWindow = new ResultsWindow();
        List<Process> Processes;
        List<Process> ROMProcesses;
        List<Process> CompletedProcesses = new List<Process>();
        Process nextProcess;
        int totalCPU;
        bool nextProcessCheck = false;
        bool algorithmFCFS = false;
        bool algorithmSJF = false;
        bool algorithmMLFQ = false;
        bool idle = false;




        public Form1()
        {
            InitializeComponent();

            P1.name = "P1";
            P2.name = "P2";
            P3.name = "P3";
            P4.name = "P4";
            P5.name = "P5";
            P6.name = "P6";
            P7.name = "P7";
            P8.name = "P8";
            P9.name = "P9";
            P1.cpuIoTime = new int[] { 17, 24, 18, 73, 17, 31, 16, 27, 14, 33, 16, 43, 14, 64, 15, 19, 15 };
            P2.cpuIoTime = new int[] { 10, 31, 9, 35, 8, 42, 7, 43, 9, 47, 12, 43, 15, 51, 19 };
            P3.cpuIoTime = new int[] { 18, 51, 23, 53, 24, 61, 22, 31, 21, 43, 20, 31, 12 };
            P4.cpuIoTime = new int[] { 17, 42, 19, 55, 20, 54, 17, 52, 15, 67, 12, 72, 15, 66, 14 };
            P5.cpuIoTime = new int[] { 5, 61, 6, 82, 5, 71, 3, 61, 5, 62, 4, 51, 3, 77, 4, 61, 3, 42, 5 };
            P6.cpuIoTime = new int[] { 10, 35, 12, 41, 14, 33, 11, 32, 15, 41, 13, 29, 11 };
            P7.cpuIoTime = new int[] { 6, 18, 7, 21, 5, 19, 4, 16, 5, 29, 7, 21, 8, 22, 6, 24, 5 };
            P8.cpuIoTime = new int[] { 9, 52, 12, 42, 14, 31, 14, 21, 16, 43, 14, 31, 13, 32, 15 };
            P9.cpuIoTime = new int[] { 6, 35, 4, 41, 6, 33, 6, 32, 7, 41, 4, 29, 5, 16, 5, 22, 4 };
            P1R.name = "P1";
            P2R.name = "P2";
            P3R.name = "P3";
            P4R.name = "P4";
            P5R.name = "P5";
            P6R.name = "P6";
            P7R.name = "P7";
            P8R.name = "P8";
            P9R.name = "P9";
            P1R.cpuIoTime = new int[] { 17, 24, 18, 73, 17, 31, 16, 27, 14, 33, 16, 43, 14, 64, 15, 19, 15 };
            P2R.cpuIoTime = new int[] { 10, 31, 9, 35, 8, 42, 7, 43, 9, 47, 12, 43, 15, 51, 19 };
            P3R.cpuIoTime = new int[] { 18, 51, 23, 53, 24, 61, 22, 31, 21, 43, 20, 31, 12 };
            P4R.cpuIoTime = new int[] { 17, 42, 19, 55, 20, 54, 17, 52, 15, 67, 12, 72, 15, 66, 14 };
            P5R.cpuIoTime = new int[] { 5, 61, 6, 82, 5, 71, 3, 61, 5, 62, 4, 51, 3, 77, 4, 61, 3, 42, 5 };
            P6R.cpuIoTime = new int[] { 10, 35, 12, 41, 14, 33, 11, 32, 15, 41, 13, 29, 11 };
            P7R.cpuIoTime = new int[] { 6, 18, 7, 21, 5, 19, 4, 16, 5, 29, 7, 21, 8, 22, 6, 24, 5 };
            P8R.cpuIoTime = new int[] { 9, 52, 12, 42, 14, 31, 14, 21, 16, 43, 14, 31, 13, 32, 15 };
            P9R.cpuIoTime = new int[] { 6, 35, 4, 41, 6, 33, 6, 32, 7, 41, 4, 29, 5, 16, 5, 22, 4 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FCFSbutton.Visible = false;
            SJFbutton.Visible = false;
            MLFQbutton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pickalgo.Visible = false;
            editpro.Visible = false;
            FCFSbutton.Visible = true;
            SJFbutton.Visible = true;
            MLFQbutton.Visible = true;

        }

        private void editpro_Click(object sender, EventArgs e)
        {
            editedbool = true;
            pEditorWindow.Show();
        }

        //-----------------------------------------------------------------
        //+++++++++++++++++++++++SJF Algorithm++++++++++++++++++++++++++++
        //----------------------------------------------------------------
        private void SJFbutton_Click(object sender, EventArgs e)
        {
            algorithmSJF = true;
            dynamicConsole.Show();

            //show resuts once algorithm is done
            //resultsWindow.Show();

            //while there is sitll a process to put in cpu
            if (editedbool)
            {
                P1 = pEditorWindow.P1;
                P2 = pEditorWindow.P2;
                P3 = pEditorWindow.P3;
                P4 = pEditorWindow.P4;
                P5 = pEditorWindow.P5;
                P6 = pEditorWindow.P6;
                P7 = pEditorWindow.P7;
                P8 = pEditorWindow.P8;
                P9 = pEditorWindow.P9;
                P1R = pEditorWindow.P1;
                P2R = pEditorWindow.P2;
                P3R = pEditorWindow.P3;
                P4R = pEditorWindow.P4;
                P5R = pEditorWindow.P5;
                P6R = pEditorWindow.P6;
                P7R = pEditorWindow.P7;
                P8R = pEditorWindow.P8;
                P9R = pEditorWindow.P9;
            }
            totalCPU = TotalCpu(P1, P2, P3, P4, P5, P6, P7, P8, P9);
            Processes = new List<Process>() { P1, P2, P3, P4, P5, P6, P7, P8, P9 };
            ROMProcesses = new List<Process>() { P1R, P2R, P3R, P4R, P5R, P6R, P7R, P8R, P9R };

            dynamicConsole.CPUclock.Start();
            dynamicConsole.CPUclock.Tick += CPUclock_Tick;
        }

        //--------------------------------------------------------------------------
        //++++++++++FCFS Algorithm++++++++++++++++++++++++++++++++++++++++++++++++
        //-----------------------------------------------------------------------
        private void FCFSbutton_Click(object sender, EventArgs e)
        {

            algorithmFCFS = true;
            dynamicConsole.Show();

            //show resuts once algorithm is done
            //resultsWindow.Show();

            //while there is sitll a process to put in cpu
            if (editedbool)
            {
                P1 = pEditorWindow.P1;
                P2 = pEditorWindow.P2;
                P3 = pEditorWindow.P3;
                P4 = pEditorWindow.P4;
                P5 = pEditorWindow.P5;
                P6 = pEditorWindow.P6;
                P7 = pEditorWindow.P7;
                P8 = pEditorWindow.P8;
                P9 = pEditorWindow.P9;
                P1R = pEditorWindow.P1;
                P2R = pEditorWindow.P2;
                P3R = pEditorWindow.P3;
                P4R = pEditorWindow.P4;
                P5R = pEditorWindow.P5;
                P6R = pEditorWindow.P6;
                P7R = pEditorWindow.P7;
                P8R = pEditorWindow.P8;
                P9R = pEditorWindow.P9;
            }
            totalCPU = TotalCpu(P1, P2, P3, P4, P5, P6, P7, P8, P9);
            Processes = new List<Process>() { P1, P2, P3, P4, P5, P6, P7, P8, P9 };
            ROMProcesses = new List<Process>() { P1R, P2R, P3R, P4R, P5R, P6R, P7R, P8R, P9R };

            dynamicConsole.CPUclock.Start();
            dynamicConsole.CPUclock.Tick += CPUclock_Tick;


        }

        //--------------------------------------------------------------------------
        //++++++++++MLFQ Algorithm++++++++++++++++++++++++++++++++++++++++++++++++
        //-----------------------------------------------------------------------
        private void MLFQbutton_Click(object sender, EventArgs e)
        {
            algorithmMLFQ = true;
            dynamicConsole.Show();
            ResultsWindow resultsWindow = new ResultsWindow();

            //show resuts once algorithm is done
            //resultsWindow.Show();

            //while there is sitll a process to put in cpu
            if (editedbool)
            {
                P1 = pEditorWindow.P1;
                P2 = pEditorWindow.P2;
                P3 = pEditorWindow.P3;
                P4 = pEditorWindow.P4;
                P5 = pEditorWindow.P5;
                P6 = pEditorWindow.P6;
                P7 = pEditorWindow.P7;
                P8 = pEditorWindow.P8;
                P9 = pEditorWindow.P9;
                P1R = pEditorWindow.P1;
                P2R = pEditorWindow.P2;
                P3R = pEditorWindow.P3;
                P4R = pEditorWindow.P4;
                P5R = pEditorWindow.P5;
                P6R = pEditorWindow.P6;
                P7R = pEditorWindow.P7;
                P8R = pEditorWindow.P8;
                P9R = pEditorWindow.P9;
            }
            totalCPU = TotalCpu(P1, P2, P3, P4, P5, P6, P7, P8, P9);
            Processes = new List<Process>() { P1, P2, P3, P4, P5, P6, P7, P8, P9 };
            ROMProcesses = new List<Process>() { P1R, P2R, P3R, P4R, P5R, P6R, P7R, P8R, P9R };

            dynamicConsole.CPUclock.Start();
            dynamicConsole.CPUclock.Tick += CPUclock_Tick;
        }

        //------------------------------------------------------------------
        //------------------------------------------------------------------
        //**********************MAIN LOOP**********************************
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        void CPUclock_Tick(object sender, EventArgs e)
        {
            //if there is no cpu to compute then cpu is idle meaning it is not executing any processes
            if (idle)
            {
                clock++;
                UpdateProcesses(Processes, nextProcess);
                UpdateInterface(Processes, nextProcess);
                if (Processes.Count == 0)
                {
                    Results();
                    resultsWindow.Show();
                    dynamicConsole.CPUclock.Stop();
                }

            }
            //if there is a completion of a process for whatever reason then a new next process is chosen
            else if (!nextProcessCheck)
            {
                nextProcessCheck = true;
                if (algorithmFCFS)
                {
                    nextProcess = NextProcess(P1, P2, P3, P4, P5, P6, P7, P8, P9);
                }
                else if (algorithmSJF)
                {
                    nextProcess = NextProcessSJF();
                }
                else
                {
                    tQ = 0;
                    nextProcess = NextProcessMLFQ();
                }

            }
            //if the cpu is executing and there is no need for a new next process then update everything(interface and other processes waiting or in IO)
            else
            {
                if (algorithmMLFQ)
                {
                    tQ++;
                    if (nextProcess.index % 2 == 0)
                    {
                        if (nextProcess.priority == 1)
                        {
                            if (tQ == 6)
                            {
                                nextProcess.priority = 2;
                                nextProcessCheck = false;

                            }
                            else if (nextProcess.cpuIoTime[nextProcess.index] == 0)
                            {
                                nextProcessCheck = false;

                            }
                            else
                            {
                                //keep going adding tq
                            }
                        }
                        else if (nextProcess.priority == 2)
                        {
                            if (tQ == 12)
                            {
                                nextProcess.priority = 3;
                                nextProcessCheck = false;
                            }
                            else if (nextProcess.cpuIoTime[nextProcess.index] == 0)
                            {
                                nextProcessCheck = false;
                            }
                            else
                            {
                                //keep going adding tq
                            }
                        }
                        else
                        {
                            nextProcess = NextProcess(P1, P2, P3, P4, P5, P6, P7, P8, P9);
                        }
                    }
                    if (nextProcess.cpuIoTime[nextProcess.index] == 0)
                    {
                        nextProcessCheck = false;
                        if (nextProcess.index < nextProcess.cpuIoTime.Length)
                        {
                            nextProcess.index++;
                        }
                        if (nextProcess.index == nextProcess.cpuIoTime.Length)
                        {
                            nextProcess.finished = true;
                        }

                        if (Processes.Count == 0)
                        {
                            dynamicConsole.CPUclock.Stop();
                        }
                    }

                }
                //else
                //{
                //    if (nextProcess.cpuIoTime[nextProcess.index] == 0)
                //    {
                //        nextProcessCheck = false;
                //        nextProcess.index++;
                //        if (nextProcess.index == nextProcess.cpuIoTime.Length)
                //        {
                //            nextProcess.finished = true;
                //        }

                //        if (Processes.Count == 0)
                //        {
                //            dynamicConsole.CPUclock.Stop();
                //        }
                //    }
                //}
                //__________FIRST EXECUTION ONLY_______________________________
                //check for the first time process is executed to record response time
                if (nextProcess.index == 0 && nextProcess.firstExecution)
                {
                    nextProcess.responseTime = clock;
                    //updating the romprocess for the results window
                    UpdateResponseTime(nextProcess);
                    //here we change the boolean so it doesnt go in here anymore than the first time the process is executed
                    nextProcess.firstExecution = false;
                    //if its the very first time thru here then save all the total times of all processes total cpu bursts
                    if (Processes[0] == nextProcess)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            ROMProcesses[i].totalTime = TotalTime(Processes[i].cpuIoTime, 0);
                        }
                    }
                }

                //Update all processes,clock and interface
                UpdateProcesses(Processes, nextProcess);
                UpdateInterface(Processes, nextProcess);
                clock++;
               
                //decrease cpu burst of the process being executed if not idle
                if(!idle) nextProcess.cpuIoTime[nextProcess.index]--;
                //check to see if process is done executing all its cpu burst
                if (nextProcess.cpuIoTime[nextProcess.index] == 0 && !idle)
                {
                    nextProcessCheck = false;
                    nextProcess.index++;
                    if (nextProcess.index == nextProcess.cpuIoTime.Length)
                    {
                        nextProcess.finished = true;
                    }

                }
           


            }

            
                



        }

        //fucntion that will determine what the results window will show
        private void Results()
        {
            List<Label> ResultsWaitingLabels = new List<Label>() { resultsWindow.P1WaitingTimeVar, resultsWindow.p2WaitingTimeVar, resultsWindow.p3WaitingTimeVar, resultsWindow.p4WaitingTimeVar, resultsWindow.p5WaitingTimeVar, resultsWindow.p6WaitingTimeVar, resultsWindow.p7WaitingTimeVar, resultsWindow.p8WaitingTimeVar, resultsWindow.p9WaitingTimeVar };
            List<Label> ResultsTurnaroundLabels = new List<Label>() { resultsWindow.p1TurnaroundTimeVar, resultsWindow.p2TurnaroundTimeVar, resultsWindow.p3TurnaroundTimeVar, resultsWindow.p4TurnaroundTimeVar, resultsWindow.p5TurnaroundTimeVar, resultsWindow.p6TurnaroundTimeVar, resultsWindow.p7TurnaroundTimeVar, resultsWindow.p8TurnaroundTimeVar, resultsWindow.p9TurnaroundTimeVar };
            List<Label> ResultsResponseLabels = new List<Label>() { resultsWindow.p1ResponseTimeVar, resultsWindow.p2ResponseTimeVar, resultsWindow.p3ResponseTimeVar, resultsWindow.p4ResponseTimeVar, resultsWindow.p5ResponseTimeVar, resultsWindow.p6ResponseTimeVar, resultsWindow.p7ResponseTimeVar, resultsWindow.p8ResponseTimeVar, resultsWindow.p9ResponseTimeVar };
            int avgWT = 0;
            int avgTT = 0;
            int avgRT = 0;

            resultsWindow.totalTimeLabelVar.Text = clock.ToString();
            resultsWindow.cpuUtilizationVarLabel.Text = (((double)totalCPU / (double)clock) * 100).ToString("#.##") + "%";
            for (int i = 0; i < 9; i++)
            {
                ResultsWaitingLabels[i].Text = ROMProcesses[i].timeOnReady.ToString();
                ResultsResponseLabels[i].Text = ROMProcesses[i].responseTime.ToString();
                ResultsTurnaroundLabels[i].Text = (ROMProcesses[i].timeOnReady + ROMProcesses[i].totalTime + ROMProcesses[i].timeOnIO).ToString();
                avgWT += ROMProcesses[i].timeOnReady;
                avgTT += (ROMProcesses[i].timeOnReady + ROMProcesses[i].totalTime + ROMProcesses[i].timeOnIO);
                avgRT += ROMProcesses[i].responseTime;
            }

            resultsWindow.averageWaitingTimeVar.Text = (((double)avgWT / 9)).ToString("#.##");
            resultsWindow.averageResponseTimeVar.Text = (((double)avgRT / 9)).ToString("#.##");
            resultsWindow.averageTurnaroundTimeVar.Text = (((double)avgTT / 9)).ToString("#.##");


        }

        //fucntion that is used to update the dyanmic console
        private void UpdateInterface(List<Process> Processes, Process nextProcess)
        {
            if (nextProcess == null)
            {
                nextProcess = new Process();
                nextProcess.name = "idle";

            }
            List<Process> CPUProcesses = new List<Process>();
            List<Process> IOProcesses = new List<Process>();

            dynamicConsole.execTimeLabelVar.Text = clock.ToString();
            dynamicConsole.runnigProcessLabelVar.Text = nextProcess.name;
            dynamicConsole.runnigProcessLabelVar.Visible = true;
            if (!idle && nextProcess.name != "idle")
            {
                dynamicConsole.executingTimeProcess.Text = nextProcess.cpuIoTime[nextProcess.index].ToString();
                dynamicConsole.executingTimeProcess.Visible = true;
            }
            for (int i = 0; i < Processes.Count; i++)
            {
                if (Processes[i].name != nextProcess.name)
                {
                    if ((Processes[i].index) % 2 == 0)
                    {
                        CPUProcesses.Add(Processes[i]);
                    }
                    else
                    {
                        IOProcesses.Add(Processes[i]);
                    }
                }
            }

            DisplayIOProcesses(IOProcesses);
            DisplayReadyProcesses(CPUProcesses);
            if (CompletedProcesses != null)
            {
                DisplayCompletedProcesses(CompletedProcesses);
            }


            dynamicConsole.Invalidate();
        }

        //dyanmic console function
        private void DisplayCompletedProcesses(List<Process> CompletedProcesses)
        {
            List<Label> CompletedLabels = new List<Label>() { dynamicConsole.processCompleted1LabelVar, dynamicConsole.processCompleted2LabelVar, dynamicConsole.processCompleted3LabelVar, dynamicConsole.processCompleted4LabelVar, dynamicConsole.processCompleted5LabelVar, dynamicConsole.processCompleted6LabelVar, dynamicConsole.processCompleted7LabelVar, dynamicConsole.processCompleted8LabelVar, dynamicConsole.processCompleted9LabelVar };

            for (int i = 0; i < CompletedProcesses.Count; i++)
            {
                CompletedLabels[i].Text = CompletedProcesses[i].name;
                CompletedLabels[i].Visible = true;
            }


        }

        //dynamic console function
        private void DisplayIOProcesses(List<Process> IOProcesses)
        {
            List<Label> IoLabels = new List<Label>() { dynamicConsole.processIO1Label, dynamicConsole.processIO2Label, dynamicConsole.processIO3Label, dynamicConsole.processIO4Label, dynamicConsole.processIO5Label, dynamicConsole.processIO6Label, dynamicConsole.processIO7Label, dynamicConsole.processIO8Label, dynamicConsole.processIO9Label };
            List<Label> IoTimeLabels = new List<Label>() { dynamicConsole.processIO1TimeLabel, dynamicConsole.processIO2TimeLabel, dynamicConsole.processIO3TimeLabel, dynamicConsole.processIO4TimeLabel, dynamicConsole.processIO5TimeLabel, dynamicConsole.processIO6TimeLabel, dynamicConsole.processIO7TimeLabel, dynamicConsole.processIO8TimeLabel, dynamicConsole.processIO9TimeLabel };
            int leftover = 0;

            for (int i = 0; i < IOProcesses.Count; i++)
            {
                leftover++;
                IoLabels[i].Visible = true;
                IoLabels[i].Text = IOProcesses[i].name;
                IoTimeLabels[i].Visible = true;
                IoTimeLabels[i].Text = TotalTime(IOProcesses[i].cpuIoTime, IOProcesses[i].index).ToString();
            }
            for (int j = leftover; j < IoLabels.Count; j++)
            {
                IoLabels[j].Visible = false;
                IoTimeLabels[j].Visible = false;
            }
        }

        //dynamic console function
        private void DisplayReadyProcesses(List<Process> CPUProcesses)
        {
            List<Label> readyLabels = new List<Label>() { dynamicConsole.processReady1Label, dynamicConsole.processReady2Label, dynamicConsole.processReady3Label, dynamicConsole.processReady4Label, dynamicConsole.processReady5Label, dynamicConsole.processReady6Label, dynamicConsole.processReady7Label, dynamicConsole.processReady8Label, dynamicConsole.processReady9Label };
            List<Label> readyTimeLabels = new List<Label>() { dynamicConsole.processReady1TimeLabel, dynamicConsole.processReady2TimeLabel, dynamicConsole.processReady3TimeLabel, dynamicConsole.processReady4TimeLabel, dynamicConsole.processReady5TimeLabel, dynamicConsole.processReady6TimeLabel, dynamicConsole.processReady7TimeLabel, dynamicConsole.processReady8TimeLabel, dynamicConsole.processReady9TimeLabel };
            int leftover = 0;

            for (int i = 0; i < CPUProcesses.Count; i++)
            {
                leftover++;
                readyLabels[i].Visible = true;
                readyLabels[i].Text = CPUProcesses[i].name;
                readyTimeLabels[i].Visible = true;
                readyTimeLabels[i].Text = TotalTime(CPUProcesses[i].cpuIoTime, CPUProcesses[i].index).ToString();
            }
            for (int j = leftover; j < readyLabels.Count; j++)
            {
                readyLabels[j].Visible = false;
                readyTimeLabels[j].Visible = false;
            }
        }

        //fucntion that calculates the total time of all the processes combined
        private int TotalTime(int[] cpuIoTime, int currentIndex)
        {
            int total = 0;

            for (int i = currentIndex; i < cpuIoTime.Length; i++)
            {
                if (i % 2 == 0)
                {
                    total += cpuIoTime[i];
                }
            }

            return total;
        }

        //function that updates the processes different properties every tick of the clock
        private void UpdateProcesses(List<Process> Processes, Process nextProcess)
        {

            List<Process> ProcessesInIO = new List<Process>();
            List<Process> ProcessesInCPU = new List<Process>();

            for (int i = 0; i < Processes.Count; i++)
            {
                if (Processes[i].index % 2 == 0)
                {
                    ProcessesInCPU.Add(Processes[i]);
                }
                else
                {
                    if (Processes[i].finished)
                    {
                        Processes[i].finishTime = clock;
                        CompletedProcesses.Add(Processes[i]);
                        Processes.RemoveAt(i);
                    }
                    else
                    {
                        ProcessesInIO.Add(Processes[i]);
                    }
                }
            }

            for (int b = 0; b < ProcessesInCPU.Count; b++)
            {
                if (ProcessesInCPU[b] != nextProcess)
                {
                    ProcessesInCPU[b].timeOnReady++;
                    UpdateTimeOnReady(ProcessesInCPU[b]);
                }
                else
                {

                }

            }

            for (int k = 0; k < ProcessesInIO.Count; k++)
            {


                ProcessesInIO[k].timeOnIO++;
                UpdateTimeOnIo(ProcessesInIO[k]);
                ProcessesInIO[k].cpuIoTime[ProcessesInIO[k].index]--;

                if (ProcessesInIO[k].cpuIoTime[ProcessesInIO[k].index] == 0)
                {

                    ProcessesInIO[k].index++;
                    ProcessesInIO[k].arriveTime = clock;
                    if (idle)
                    {
                        idle = false;
                        nextProcessCheck = false;
                    }

                }

            }


        }

        //function to keep track of individual times on Io
        private void UpdateTimeOnIo(Process process)
        {
            if (process.name == "P1")
            {
                ROMProcesses[0].timeOnIO++;
            }
            else if (process.name == "P2")
            {
                ROMProcesses[1].timeOnIO++;
            }
            else if (process.name == "P3")
            {
                ROMProcesses[2].timeOnIO++;
            }
            else if (process.name == "P4")
            {
                ROMProcesses[3].timeOnIO++;
            }
            else if (process.name == "P5")
            {
                ROMProcesses[4].timeOnIO++;
            }
            else if (process.name == "P6")
            {
                ROMProcesses[5].timeOnIO++;
            }
            else if (process.name == "P7")
            {
                ROMProcesses[6].timeOnIO++;
            }
            else if (process.name == "P8")
            {
                ROMProcesses[7].timeOnIO++;
            }
            else
            {
                ROMProcesses[8].timeOnIO++;
            }
        }

        //function to keep track of indivdual times on ready
        private void UpdateTimeOnReady(Process process)
        {

            if (process.name == "P1")
            {
                ROMProcesses[0].timeOnReady++;
            }
            else if (process.name == "P2")
            {
                ROMProcesses[1].timeOnReady++;
            }
            else if (process.name == "P3")
            {
                ROMProcesses[2].timeOnReady++;
            }
            else if (process.name == "P4")
            {
                ROMProcesses[3].timeOnReady++;
            }
            else if (process.name == "P5")
            {
                ROMProcesses[4].timeOnReady++;
            }
            else if (process.name == "P6")
            {
                ROMProcesses[5].timeOnReady++;
            }
            else if (process.name == "P7")
            {
                ROMProcesses[6].timeOnReady++;
            }
            else if (process.name == "P8")
            {
                ROMProcesses[7].timeOnReady++;
            }
            else
            {
                ROMProcesses[8].timeOnReady++;
            }
        }

        //function to keep track of individual response times
        private void UpdateResponseTime(Process process)
        {
            if (process.name == "P1")
            {
                ROMProcesses[0].responseTime = clock;
            }
            else if (process.name == "P2")
            {
                ROMProcesses[1].responseTime = clock;
            }
            else if (process.name == "P3")
            {
                ROMProcesses[2].responseTime = clock;
            }
            else if (process.name == "P4")
            {
                ROMProcesses[3].responseTime = clock;
            }
            else if (process.name == "P5")
            {
                ROMProcesses[4].responseTime = clock;
            }
            else if (process.name == "P6")
            {
                ROMProcesses[5].responseTime = clock;
            }
            else if (process.name == "P7")
            {
                ROMProcesses[6].responseTime = clock;
            }
            else if (process.name == "P8")
            {
                ROMProcesses[7].responseTime = clock;
            }
            else
            {
                ROMProcesses[8].responseTime = clock;
            }
        }

        //Method to find the total amunt of CPU bursts needed by the processes
        private int TotalCpu(Process P1, Process P2, Process P3, Process P4, Process P5, Process P6, Process P7, Process P8, Process P9)
        {
            List<Process> Processes = new List<Process>() { P1, P2, P3, P4, P5, P6, P7, P8, P9 };
            int processNumber = 0;
            Process NextProcess;
            int total = 0;

            while (processNumber < 8)
            {
                NextProcess = Processes[processNumber];

                for (int i = 0; i < NextProcess.cpuIoTime.Length; i += 2)
                {
                    total += NextProcess.cpuIoTime.ToArray()[i];
                }
                processNumber++;
            }

            return total;
        }

        //Method to find the next process FCFS
        public Process NextProcess(Process a, Process b, Process c, Process d, Process e, Process f, Process g, Process h, Process i)
        {
            int result = 0;

            Process p;
            List<Process> Processes = new List<Process>() { a, b, c, d, e, f, g, h, i };
            List<Process> ProcessesWithCpu = new List<Process>();

            for (int k = 0; k < Processes.Count; k++)
            {
                if ((Processes[k].index % 2) == 0)
                {
                    ProcessesWithCpu.Add(Processes[k]);
                }
            }

            if (ProcessesWithCpu.Count != 0)
            {
                p = ProcessesWithCpu[0];

                for (int j = 1; j < ProcessesWithCpu.Count; j++)
                {
                    result = Math.Min(p.arriveTime, ProcessesWithCpu[j].arriveTime);

                    if (result != p.arriveTime)
                    {
                        p = ProcessesWithCpu[j];
                    }

                }
            }
            else
            {
                idle = true;
                return null;

            }

            return p;

        }

        //Method to find the next process SJF
        private Process NextProcessSJF()
        {
            int result = 0;

            Process p;
            List<Process> Processes = new List<Process>() { P1, P2, P3, P4, P5, P6, P7, P8, P9 };
            List<Process> ProcessesWithCpu = new List<Process>();

            for (int i = 0; i < 9; i++)
            {
                if ((Processes[i].index % 2) == 0)
                {
                    ProcessesWithCpu.Add(Processes[i]);
                }
            }

            if (ProcessesWithCpu.Count != 0)
            {
                p = ProcessesWithCpu[0];

                for (int j = 1; j < ProcessesWithCpu.Count; j++)
                {
                    result = Math.Min(p.cpuIoTime[p.index], ProcessesWithCpu[j].cpuIoTime[ProcessesWithCpu[j].index]);

                    if (result != p.cpuIoTime[p.index])
                    {
                        p = ProcessesWithCpu[j];
                    }

                }
            }
            else
            {
                idle = true;
                return null;


            }

            return p;




        }

        //Method to find the next process MLFQ
        private Process NextProcessMLFQ()
        {
            int result;
            Process p;
            List<Process> Processes = new List<Process>() { P1, P2, P3, P4, P5, P6, P7, P8, P9 };
            List<Process> ProcessesWithCpu = new List<Process>();
            List<Process> Queue1 = new List<Process>();
            List<Process> Queue2 = new List<Process>();
            List<Process> Queue3 = new List<Process>();


            for (int i = 0; i < 9; i++)
            {
                if ((Processes[i].index % 2) == 0)
                {
                    if (Processes[i].priority == 1)
                    {
                        Queue1.Add(Processes[i]);
                    }
                    else if (Processes[i].priority == 2)
                    {
                        Queue2.Add(Processes[i]);
                    }
                    else
                    {
                        Queue3.Add(Processes[i]);
                    }
                }
            }

            if (Queue1.Count() != 0)
            {
                p = Queue1[0];

                for (int j = 0; j < Queue1.Count; j++)
                {
                    result = Math.Min(p.arriveTime, Queue1[j].arriveTime);
                    if (result != p.arriveTime)
                    {
                        p = Queue1[j];
                    }
                }
            }
            else if (Queue2.Count() != 0)
            {
                p = Queue2[0];

                for (int j = 0; j < Queue2.Count; j++)
                {
                    result = Math.Min(p.arriveTime, Queue2[j].arriveTime);
                    if (result != p.arriveTime)
                    {
                        p = Queue2[j];
                    }
                }
            }
            else if (Queue3.Count() != 0)
            {
                p = Queue3[0];

                for (int j = 0; j < Queue3.Count; j++)
                {
                    result = Math.Min(p.arriveTime, Queue3[j].arriveTime);
                    if (result != p.arriveTime)
                    {
                        p = Queue3[j];
                    }
                }
            }
            else
            {
                idle = true;
                return null;

            }
            return p;
        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}


 

       
      

     
               
                    
       

