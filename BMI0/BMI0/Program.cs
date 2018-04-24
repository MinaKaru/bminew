using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("BMI計算機");

            while (true)
            {
                // 宣告兩個變數 , 屬入身高體重
                Console.Write("請輸入身高:");
                float tall = float.Parse(Console.ReadLine()) / 100;

                Console.Write("請輸入體重:");
                float weight = float.Parse(Console.ReadLine());

                // 宣告變數 , 判斷要檢測甚麼
                Console.Write("輸入1為身體情形2為兵役狀況:");
                int people = int.Parse(Console.ReadLine());

                // 宣告變數 , 以便儲存計算後數值
                double BMI;

                // 計算BMI值
                BMI = weight / (tall * tall);
                // 當people = 1 , 進行以下程式碼
                if (people == 1)
                {
                    if (BMI < 18.5)
                    {
                        Console.WriteLine("過輕！你需要再吃營養些，讓自己重一些！");
                    }
                    else if (18.5 <= BMI && BMI < 24)
                    {
                        Console.WriteLine("標準！請您繼續保持！");
                    }
                    else if (24 <= BMI && BMI < 27)
                    {
                        Console.WriteLine("過重！肥胖容易引起疾病，您得要多多注意自己的健康囉！");
                        Console.Beep(1000, 1000);
                    }
                    else if (27 <= BMI && BMI < 30)
                    {
                        Console.WriteLine("輕度肥胖！肥胖容易引起疾病，您得要多多注意自己的健康囉！");
                        Console.Beep(1000, 1000);
                    }
                    else if (30 <= BMI && BMI < 35)
                    {
                        Console.WriteLine("中度肥胖！肥胖容易引起疾病，您得要多多注意自己的健康囉！");
                        Console.Beep(1000, 1000);
                    }
                    else
                    {
                        Console.WriteLine("重度肥胖！肥胖容易引起疾病，您得要多多注意自己的健康囉！");
                        Console.Beep(1000, 1000);
                    }
                }
                // 若 people = 1 以外的值 , 進行以下程式碼
                else
                {
                    if (BMI < 16.5 || BMI > 31.5)
                    {
                        Console.WriteLine("恭喜你不用當兵");
                    }
                    else if (16.5 <= BMI && BMI < 17)
                    {
                        Console.WriteLine("你還是得當替代役");
                    }
                    else if (31 <= BMI && BMI < 31.5)
                    {
                        Console.WriteLine("你還是得當替代役");
                    }
                    else
                    {
                        Console.WriteLine("乖乖當兵吧");
                    }
                }

                // 顯示結果
                Console.WriteLine("您的BMI指數為" + BMI + "kg/m*m");
                Console.ReadLine();
            }
        }
    }
}
