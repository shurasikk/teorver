using System;

namespace teorver_zadachi
{
    class Program
    {
        ulong factorial(uint a)
        {
            if (a == 0) return 1;
            else return a * factorial(a - 1);
        }
        ulong sochet(uint a, uint b)
        {
            return (factorial(b) / (factorial(a) * factorial(b - a)));
        }
        //модуль 1 16.1
        void modul1_16_1()
        {
            int k1;
            int a, b, c;
            string text1, text_ans;
            double ans_a, ans_b; //ответы на пункты а и б
            Random rnd1 = new Random();
            k1 = rnd1.Next(1, 4);
            Random rb = new Random();
            int cifr = rb.Next(0, 10);
            if (cifr == 0) ans_b = 1 / 10;
            else ans_b = 1 / 19;
            switch (k1)
            {
                case 1:
                    Random r1 = new Random();
                    a = r1.Next(0, 10);
                    if (a == 0) ans_a = 1 /90;
                    else ans_a = 1 / 81;
                    text1 = String.Format("Спортивный комментатор забыл счет баскетбольного матча, но помнит, что каждая команда набрала меньше 100 очков (счёт начинается с 0). Какова вероятность того, что, объявляя счет наугад, комментатор правильно назовет число очков, набранных первой командой, если ему подсказали, что это число:\nа)не содержит цифру {0};\nб)содержит цифру {1}? ", a, cifr);
                    text_ans = String.Format("а) Ответ: {0}\nб)Ответ: {1}", ans_a, ans_b);
                    break;
                case 2:
                    Random r2 = new Random();
                    a = r2.Next(0, 10);
                    do
                    {
                        b = r2.Next(0, 10);
                    } while (b == a);

                    if (a == 0 || b == 0) ans_a = 1 / 72;
                    else ans_a = 1 / 64;
                    text1 = String.Format("Спортивный комментатор забыл счет баскетбольного матча, но помнит, что каждая команда набрала меньше 100 очков (счёт начинается с 0). Какова вероятность того, что, объявляя счет наугад, комментатор правильно назовет число очков, набранных первой командой, если ему подсказали, что это число:\nа)не содержит цифры {0} и {1};\nб)содержит цифру {2}? ", a, b, cifr);
                    text_ans = String.Format("а) Ответ: {0}\nб)Ответ: {1}", ans_a, ans_b);
                    break;
                case 3:
                    Random r3 = new Random();
                    a = r3.Next(0, 10);
                    do
                    {
                        b = r3.Next(0, 10);
                    } while (b == a);
                    do
                    {
                        c = r3.Next(0, 10);
                    } while (c == a || c==b);

                    if (a == 0 || b == 0 || c==0) ans_a = 1 / 56;
                    else ans_a = 1 / 49;
                    text1 = String.Format("Спортивный комментатор забыл счет баскетбольного матча, но помнит, что каждая команда набрала меньше 100 очков (счёт начинается с 0). Какова вероятность того, что, объявляя счет наугад, комментатор правильно назовет число очков, набранных первой командой, если ему подсказали, что это число:\nа)не содержит цифры {0}, {1} и {2};\nб)содержит цифру {3}? ", a, b, c, cifr);
                    text_ans = String.Format("а) Ответ: {0}\nб)Ответ: {1}", ans_a, ans_b);
                    break;
            }
        }
        //модуль 1 16.2
        void modul1_16_2()
        {
            Random r = new Random();
            int all = r.Next(10, 20);
            int rus = r.Next(5, all - 2);
            int blgr = r.Next(2, all - rus);
            int ukr = all - rus - blgr;
            int g = r.Next(4, rus);//сколько девушек  приглашается на сцену
            string text = String.Format("В третий тур конкурса красоты прошли {0} участниц из России, {1} — из Украины и {2} — из Болгарии. Для представления участниц на сцену наугад приглашают {3} девушек. Найти вероятность того, что среди приглашенных:\nа) все девушки из России;\nб) две девушки из России и две — из Болгарии.", rus, ukr, blgr, g);
            double ans_a = sochet(Convert.ToUInt32(g), Convert.ToUInt32(rus)) / sochet(Convert.ToUInt32(g), Convert.ToUInt32(all));
            double ans_b = (sochet(2, Convert.ToUInt32(rus)) * sochet(2, Convert.ToUInt32(blgr)) * sochet(Convert.ToUInt32(g-4), Convert.ToUInt32(ukr))) / (sochet(Convert.ToUInt32(g), Convert.ToUInt32(all)));
            string text_ans = String.Format("а) Ответ: {0}\nб)Ответ: {1}", ans_a, ans_b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
