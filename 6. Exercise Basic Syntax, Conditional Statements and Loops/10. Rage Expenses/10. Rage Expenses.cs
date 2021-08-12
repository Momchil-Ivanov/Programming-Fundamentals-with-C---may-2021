using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //As a MOBA challenger player, Pesho has the bad habit to trash his PC when he loses a game and rage quits.His gaming setup consists of headset, mouse, keyboard and display. You will receive Pesho's lost games count. 
            //Every second lost game, Pesho trashes his headset.
            //Every third lost game, Pesho trashes his mouse.
            //When Pesho trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.
            //You will receive the price of each item in his gaming setup.Calculate his rage expenses for renewing his gaming equipment.
            //Input / Constraints
            //•	On the first input line - lost games count – integer in the range[0, 1000].
            //•	On the second line – headset price - floating point number in range[0, 1000].
            //•	On the third line – mouse price - floating point number in range[0, 1000].
            //•	On the fourth line – keyboard price - floating point number in range[0, 1000].
            //•	On the fifth line – display price - floating point number in range[0, 1000].
            //Output
            //•	As output you must print Pesho's total expenses: "Rage expenses: {expenses} lv."
            //•	Allowed working time / memory: 100ms / 16MB.

            double lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetTrashCount = Math.Floor(lostGamesCount / 2);
            double mouseTrashCount = Math.Floor(lostGamesCount / 3);
            double keyboardTrashCount = Math.Floor(lostGamesCount / 6);
            double displayTrashCount = Math.Floor(keyboardTrashCount / 2);

            double expenses = headsetPrice * headsetTrashCount + mousePrice * mouseTrashCount + keyboardPrice * keyboardTrashCount + displayPrice * displayTrashCount;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");


        }
    }
}
