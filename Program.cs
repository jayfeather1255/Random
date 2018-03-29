using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180322
{
    class Program
    {
        static void Main(string[] args)
        {
            // 設定文字顏色為黃色
            Console.ForegroundColor = ConsoleColor.Yellow;

            // 輸入產生幾組亂數
            Console.Write("輸入想要產生幾組亂數:");
            string number = Console.ReadLine();                       
            
            // 產生亂數物件
            Random rand = new Random();

            // 紀錄產生亂數的次數
            int count = 0;

            // 設定用戶輸入的次數為最大值
            int max = int.Parse(number);

            // 當次數達到最大值時，停止執行迴圈
            while (count < max)
            {
                // 用亂數物件產生六個亂數
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);

                
                // 設定文字顏色為綠色
                Console.ForegroundColor = ConsoleColor.Green;

                // 次數+1
                // 次數先+1再顯示，避免第一個顯示為[00]
                count++;

                // 顯示亂數
                // {0:00} 冒號後面的位數表示顯示的位數                
                Console.WriteLine("★"+"["+count+"]"+" {0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", r1, r2, r3, r4, r5, r6);
                                
            }
            
            // 防止視窗自動關閉
            Console.Read();
        }
    }
}
