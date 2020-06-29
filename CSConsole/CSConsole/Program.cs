using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU_Consumption_SmallInstance();
            CPU_Consumption_MediumInstance();
            CPU_Consumption_LargeInstance();

            Memory_Consumption_SmallInstance();
            Memory_Consumption_MediumInstance();
            Memory_Consumption_LargeInstance();
            Console.ReadLine();
        }

        //CPU
        //==================================================================
        static void CPU_Consumption(string filePath)
        {
            List<Double> lst = new List<Double>();

            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                lst.Add(Convert.ToDouble(line.Split(':').Last().Trim()));
            }
            Console.WriteLine("{0} : {1}", filePath.Split('\\').Last(), Math.Round((lst.Sum() / lst.Count), 2));
        }

        //Small Instance
        static void CPU_Consumption_SmallInstance()
        {
            //CPU - Small Instance - DS Small
            string filePath1 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Small\Dataset_S_Instance_S_LinearModel_LR_1593283853.txt";
            string filePath2 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Small\Dataset_S_Instance_S_LinearModel_DT_1593283849.txt";
            string filePath3 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Small\Dataset_S_Instance_S_LinearModel_KNN_1593283858.txt";
            string filePath4 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Small\Dataset_S_Instance_S_Non-LinearModel_RF_1593284196.txt";
            string filePath5 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Small\Dataset_S_Instance_S_Non-LinearModel_XGB_1593284030.txt";

            //CPU - Small Instance - DS Medium
            string filePath6 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Med\Dataset_M_Instance_S_LinearModel_LR_1593287740.txt";
            string filePath7 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Med\Dataset_M_Instance_S_LinearModel_DT_1593287729.txt";
            string filePath8 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Med\Dataset_M_Instance_S_LinearModel_KNN_1593287758.txt";
            string filePath9 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Med\Dataset_M_Instance_S_Non-LinearModel_RF_1593339923.txt";
            string filePath10 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Small\DS_Med\Dataset_M_Instance_S_Non-LinearModel_XGB_1593339859.txt";
            

            Console.WriteLine("CPU - Small Instance - DS Small");
            CPU_Consumption(filePath1);
            CPU_Consumption(filePath2);
            CPU_Consumption(filePath3);
            CPU_Consumption(filePath4);
            CPU_Consumption(filePath5);

            Console.WriteLine("CPU - Small Instance - DS Medium");
            CPU_Consumption(filePath6);
            CPU_Consumption(filePath7);
            CPU_Consumption(filePath8);
            CPU_Consumption(filePath9);
            CPU_Consumption(filePath10);
            
        }
        //Medium Instance
        static void CPU_Consumption_MediumInstance()
        {
            //CPU - Medium Instance - DS Small
            string filePath1 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Small\Dataset_S_Instance_M_LinearModel_LR_1593288280.txt";
            string filePath2 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Small\Dataset_S_Instance_M_LinearModel_DT_1593288277.txt";
            string filePath3 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Small\Dataset_S_Instance_M_LinearModel_KNN_1593288290.txt";
            string filePath4 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Small\Dataset_S_Instance_M_Non-LinearModel_RF_1593288295.txt";
            string filePath5 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Small\Dataset_S_Instance_M_Non-LinearModel_XGB_1593288363.txt";

            //CPU - Medium Instance - DS Medium
            string filePath6 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Med\Dataset_M_Instance_M_LinearModel_LR_1593289809.txt";
            string filePath7 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Med\Dataset_M_Instance_M_LinearModel_DT_1593289804.txt";
            string filePath8 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Med\Dataset_M_Instance_M_LinearModel_KNN_1593341267.txt";
            string filePath9 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Med\Dataset_M_Instance_M_Non-LinearModel_RF_1593291932.txt";
            string filePath10 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Med\Dataset_M_Instance_M_Non-LinearModel_XGB_1593292030.txt";

            //CPU - Medium Instance - DS Large
            string filePath11 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Large\Dataset_L_Instance_M_LinearModel_LR_1593292797.txt";
            string filePath12 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Large\Dataset_L_Instance_M_LinearModel_DT_1593334073.txt";
            string filePath13 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Large\Dataset_L_Instance_M_LinearModel_KNN_1593296810.txt";
            string filePath14 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Large\Dataset_L_Instance_M_Non-LinearModel_RF_1593292923.txt";
            string filePath15 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Med\DS_Large\Dataset_L_Instance_M_Non-LinearModel_XGB_1593294596.txt";

            Console.WriteLine("CPU - Medium Instance - DS Small");
            CPU_Consumption(filePath1);
            CPU_Consumption(filePath2);
            CPU_Consumption(filePath3);
            CPU_Consumption(filePath4);
            CPU_Consumption(filePath5);

            Console.WriteLine("CPU - Medium Instance - DS Medium");
            CPU_Consumption(filePath6);
            CPU_Consumption(filePath7);
            CPU_Consumption(filePath8);
            CPU_Consumption(filePath9);
            CPU_Consumption(filePath10);

            Console.WriteLine("CPU - Medium Instance - DS Large");
            CPU_Consumption(filePath11);
            CPU_Consumption(filePath12);
            CPU_Consumption(filePath13);
            CPU_Consumption(filePath14);
            CPU_Consumption(filePath15);
        }
        //Large Instance
        static void CPU_Consumption_LargeInstance()
        {
            //CPU - Large Instance - DS Small
            string filePath1 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Small\Dataset_S_Instance_L_LinearModel_LR_1593353578.txt";
            string filePath2 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Small\Dataset_S_Instance_L_LinearModel_DT_1593353575.txt";
            string filePath3 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Small\Dataset_S_Instance_L_LinearModel_KNN_1593353586.txt";
            string filePath4 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Small\Dataset_S_Instance_L_Non-LinearModel_RF_1593353591.txt";
            string filePath5 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Small\Dataset_S_Instance_L_Non-LinearModel_XGB_1593353609.txt";

            //CPU - Large Instance - DS Medium
            string filePath6 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Med\Dataset_M_Instance_L_LinearModel_LR_1593346357.txt";
            string filePath7 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Med\Dataset_M_Instance_L_LinearModel_DT_1593346354.txt";
            string filePath8 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Med\Dataset_M_Instance_L_LinearModel_KNN_1593346449.txt";
            string filePath9 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Med\Dataset_M_Instance_L_Non-LinearModel_RF_1593346372.txt";
            string filePath10 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Med\Dataset_M_Instance_L_Non-LinearModel_XGB_1593346392.txt";

            //CPU - Large Instance - DS Large
            string filePath11 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Large\Dataset_L_Instance_L_LinearModel_LR_1593343944.txt";
            string filePath12 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Large\Dataset_L_Instance_L_LinearModel_DT_1593343849.txt";
            string filePath13 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Large\Dataset_L_Instance_L_LinearModel_KNN_1593345489.txt";
            string filePath14 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Large\Dataset_L_Instance_L_Non-LinearModel_RF_1593344017.txt";
            string filePath15 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\CPU\Instance_Large\DS_Large\Dataset_L_Instance_L_Non-LinearModel_XGB_1593344289.txt";

            Console.WriteLine("CPU - Large Instance - DS Small");
            CPU_Consumption(filePath1);
            CPU_Consumption(filePath2);
            CPU_Consumption(filePath3);
            CPU_Consumption(filePath4);
            CPU_Consumption(filePath5);

            Console.WriteLine("CPU - Large Instance - DS Medium");
            CPU_Consumption(filePath6);
            CPU_Consumption(filePath7);
            CPU_Consumption(filePath8);
            CPU_Consumption(filePath9);
            CPU_Consumption(filePath10);

            Console.WriteLine("CPU - Large Instance - DS Large");
            CPU_Consumption(filePath11);
            CPU_Consumption(filePath12);
            CPU_Consumption(filePath13);
            CPU_Consumption(filePath14);
            CPU_Consumption(filePath15);
        }

        //Memory
        //==================================================================
        static void Memory_Consumption(string filePath)
        {
            List<Double> lst = new List<Double>();

            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                lst.Add(Convert.ToDouble(line.Split(' ')[1].Trim()));
            }
            Console.WriteLine("{0} : {1}", filePath.Split('\\').Last(), (lst.Sum() / lst.Count));
        }

        //Small Instance
        static void Memory_Consumption_SmallInstance()
        {
            //Memory - Small Instance - DS Small
            string filePath1 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Small\Dataset_S_Instance_S_LinearModel_LR_1593283854.txt";
            string filePath2 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Small\Dataset_S_Instance_S_LinearModel_DT_1593283850.txt";
            string filePath3 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Small\Dataset_S_Instance_S_LinearModel_KNN_1593283859.txt";
            string filePath4 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Small\Dataset_S_Instance_S_Non-LinearModel_RF_1593284197.txt";
            string filePath5 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Small\Dataset_S_Instance_S_Non-LinearModel_XGB_1593284031.txt";

            //Memory - Small Instance - DS Medium
            string filePath6 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Med\Dataset_M_Instance_S_LinearModel_LR_1593287741.txt";
            string filePath7 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Med\Dataset_M_Instance_S_LinearModel_DT_1593287730.txt";
            string filePath8 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Med\Dataset_M_Instance_S_LinearModel_KNN_1593287759.txt";
            string filePath9 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Med\Dataset_M_Instance_S_Non-LinearModel_RF_1593339924.txt";
            string filePath10 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Small\DS_Med\Dataset_M_Instance_S_Non-LinearModel_XGB_1593339860.txt";

            Console.WriteLine("Memory - Small Instance - DS Small");
            Memory_Consumption(filePath1);
            Memory_Consumption(filePath2);
            Memory_Consumption(filePath3);
            Memory_Consumption(filePath4);
            Memory_Consumption(filePath5);

            Console.WriteLine("Memory - Small Instance - DS Medium");
            Memory_Consumption(filePath6);
            Memory_Consumption(filePath7);
            Memory_Consumption(filePath8);
            Memory_Consumption(filePath9);
            Memory_Consumption(filePath10);
            
        }
        //Medium Instance
        static void Memory_Consumption_MediumInstance()
        {
            //Memory - Medium Instance - DS Small
            string filePath1 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Small\Dataset_S_Instance_M_LinearModel_LR_1593288281.txt";
            string filePath2 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Small\Dataset_S_Instance_M_LinearModel_DT_1593288277.txt";
            string filePath3 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Small\Dataset_S_Instance_M_LinearModel_KNN_1593288290.txt";
            string filePath4 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Small\Dataset_S_Instance_M_Non-LinearModel_RF_1593288296.txt";
            string filePath5 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Small\Dataset_S_Instance_M_Non-LinearModel_XGB_1593288364.txt";

            //Memory - Medium Instance - DS Medium
            string filePath6 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Med\Dataset_M_Instance_M_LinearModel_LR_1593289810.txt";
            string filePath7 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Med\Dataset_M_Instance_M_LinearModel_DT_1593289805.txt";
            string filePath8 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Med\Dataset_M_Instance_M_LinearModel_KNN_1593341268.txt";
            string filePath9 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Med\Dataset_M_Instance_M_Non-LinearModel_RF_1593288875.txt";
            string filePath10 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Med\Dataset_M_Instance_M_Non-LinearModel_XGB_1593289048.txt";

            //Memory - Medium Instance - DS Large
            string filePath11 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Large\Dataset_L_Instance_M_LinearModel_LR_1593292797.txt";
            string filePath12 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Large\Dataset_L_Instance_M_LinearModel_DT_1593334073.txt";
            string filePath13 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Large\Dataset_L_Instance_M_LinearModel_KNN_1593296811.txt";
            string filePath14 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Large\Dataset_L_Instance_M_Non-LinearModel_RF_1593292923.txt";
            string filePath15 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Med\DS_Large\Dataset_L_Instance_M_Non-LinearModel_XGB_1593294596.txt";

            Console.WriteLine("Memory - Medium Instance - DS Small");
            Memory_Consumption(filePath1);
            Memory_Consumption(filePath2);
            Memory_Consumption(filePath3);
            Memory_Consumption(filePath4);
            Memory_Consumption(filePath5);

            Console.WriteLine("Memory - Medium Instance - DS Medium");
            Memory_Consumption(filePath6);
            Memory_Consumption(filePath7);
            Memory_Consumption(filePath8);
            Memory_Consumption(filePath9);
            Memory_Consumption(filePath10);

            Console.WriteLine("Memory - Medium Instance - DS Large");
            Memory_Consumption(filePath11);
            Memory_Consumption(filePath12);
            Memory_Consumption(filePath13);
            Memory_Consumption(filePath14);
            Memory_Consumption(filePath15);
        }
        //Large Instance
        static void Memory_Consumption_LargeInstance()
        {
            //Memory - Large Instance - DS Small
            string filePath1 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Small\Dataset_S_Instance_L_LinearModel_LR_1593353579.txt";
            string filePath2 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Small\Dataset_S_Instance_L_LinearModel_DT_1593353576.txt";
            string filePath3 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Small\Dataset_S_Instance_L_LinearModel_KNN_1593353586.txt";
            string filePath4 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Small\Dataset_S_Instance_L_Non-LinearModel_RF_1593353591.txt";
            string filePath5 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Small\Dataset_S_Instance_L_Non-LinearModel_XGB_1593353609.txt";

            //Memory - Large Instance - DS Medium
            string filePath6 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Med\Dataset_M_Instance_L_LinearModel_LR_1593346358.txt";
            string filePath7 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Med\Dataset_M_Instance_L_LinearModel_DT_1593346354.txt";
            string filePath8 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Med\Dataset_M_Instance_L_LinearModel_KNN_1593346450.txt";
            string filePath9 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Med\Dataset_M_Instance_L_Non-LinearModel_RF_1593346373.txt";
            string filePath10 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Med\Dataset_M_Instance_L_Non-LinearModel_XGB_1593346393.txt";

            //Memory - Large Instance - DS Large
            string filePath11 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Large\Dataset_L_Instance_L_LinearModel_LR_1593343944.txt";
            string filePath12 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Large\Dataset_L_Instance_L_LinearModel_DT_1593343849.txt";
            string filePath13 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Large\Dataset_L_Instance_L_LinearModel_KNN_1593345489.txt";
            string filePath14 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Large\Dataset_L_Instance_L_Non-LinearModel_RF_1593344018.txt";
            string filePath15 = @"C:\Users\Muhammad Zubair\source\repos\CSConsole\CSConsole\Data\Memory\Instance_Large\DS_Large\Dataset_L_Instance_L_Non-LinearModel_XGB_1593344289.txt";

            Console.WriteLine("Memory - Large Instance - DS Small");
            Memory_Consumption(filePath1);
            Memory_Consumption(filePath2);
            Memory_Consumption(filePath3);
            Memory_Consumption(filePath4);
            Memory_Consumption(filePath5);

            Console.WriteLine("Memory - Large Instance - DS Medium");
            Memory_Consumption(filePath6);
            Memory_Consumption(filePath7);
            Memory_Consumption(filePath8);
            Memory_Consumption(filePath9);
            Memory_Consumption(filePath10);

            Console.WriteLine("Memory - Large Instance - DS Large");
            Memory_Consumption(filePath11);
            Memory_Consumption(filePath12);
            Memory_Consumption(filePath13);
            Memory_Consumption(filePath14);
            Memory_Consumption(filePath15);
        }
    }
}
