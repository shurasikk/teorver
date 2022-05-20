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
            addlist();
            Word word = new Word(name);
            int fst = list[random.Next(list.Count)];
            int presnd = list[random.Next(list.Count)];
            int snd = presnd == fst ? list[random.Next(list.Count)] : presnd;
            int trd = list.Find(x => x != fst && x != snd);
            string res = "1. Спортивный комментатор забыл счет баскетбольного матча, но помнит, что каждая команда набрала меньше 100 очков. Какова вероятность того, что, объявляя счет наугад, комментатор правильно назовет число очков, набранных первой командой, если ему подсказали, что это число: \nа) не содержит цифр " + fst.ToString() + " и " + snd.ToString() + "; \nб) содержит цифру " + trd.ToString() + "? ";
            double ans_a, ans_b; //ответы на пункты а и б
            if (fst == 0 || snd == 0) ans_a = 1 / 72;
            else ans_a = 1 / 64;
            if (trd == 0) ans_b = 1 / 10;
            else ans_b = 1 / 19;
            word.doc.InsertParagraph(res);
            word.doc.Save();
        }
        /*  {
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
          }*/
        //модуль 1 16.2
        void modul1_16_2()
        {
            Word word = new Word(name);
            word.doc.InsertParagraph();
            string fst = list[random.Next(list.Count)];
            string snd = list.Find(x => x != fst);
            string pretrd = list[random.Next(list.Count)];
            string trd = pretrd == snd ? list[random.Next(list.Count)] : pretrd;
            string res = "2. В третий тур конкурса красоты прошли 6 участниц из России, 5 — из Украины и 4 — из Болгарии. Для представления участниц на сцену наугад приглашают 5 девушек. Найти вероятность того, что среди приглашенных:\nа) все девушки из " + fst + "; \nб) две девушки из " + snd + " и две — из " + trd + ". ";
            int f = Parse(fst); int s = Parse(snd); int t = Parse(trd);
            double ans_a = sochet(5, Convert.ToUInt32(f)) / sochet(5, 15);
            double ans_b = (sochet(2, Convert.ToUInt32(s)) * sochet(2, Convert.ToUInt32(t)) * sochet(1, Convert.ToUInt32(f))) / (sochet(5, 15));
            word.doc.InsertParagraph(res);
            word.doc.Save();
            /*Random r = new Random();
            int all = r.Next(10, 20);
            int rus = r.Next(5, all - 2);
            int blgr = r.Next(2, all - rus);
            int ukr = all - rus - blgr;
            int g = r.Next(4, rus);//сколько девушек  приглашается на сцену
            string text = String.Format("В третий тур конкурса красоты прошли {0} участниц из России, {1} — из Украины и {2} — из Болгарии. Для представления участниц на сцену наугад приглашают {3} девушек. Найти вероятность того, что среди приглашенных:\nа) все девушки из России;\nб) две девушки из России и две — из Болгарии.", rus, ukr, blgr, g);
            double ans_a = sochet(Convert.ToUInt32(g), Convert.ToUInt32(rus)) / sochet(Convert.ToUInt32(g), Convert.ToUInt32(all));
            double ans_b = (sochet(2, Convert.ToUInt32(rus)) * sochet(2, Convert.ToUInt32(blgr)) * sochet(Convert.ToUInt32(g-4), Convert.ToUInt32(ukr))) / (sochet(Convert.ToUInt32(g), Convert.ToUInt32(all)));
            string text_ans = String.Format("а) Ответ: {0}\nб)Ответ: {1}", ans_a, ans_b);*/
        }
        void modul1_17_1()
        {
            addlist();
            Word word = new Word(name);
            int kurss = random.Next(nums.Count);
            int kurs2 = random.Next(nums.Count);
            string kurs2a = nums[kurs2]; int k2a = Parser(kurs2a);
            string kurs1_1 = nums[kurss]; int k1_1 = Parser(kurs1_1);
            string kurs1_2 = nums.Find(x => x != kurs1_1); int k1_2 = Parser(kurs1_2);
            string kurs1_3 = nums.Find(x => x != kurs1_1 && x != kurs1_2); int k1_3 = Parser(kurs1_3);
            word.doc.InsertParagraph("1. В финальном забеге на 100 м участвуют по два студента с четырех курсов.\nНайти вероятность того, что:\nа) первым пробежит дистанцию студент " + kurs1_1 + " курса, вторым — студент " + kurs1_2 + " курса и третьим — студент " + kurs1_3 + " курса;\nб) в тройке призеров не будет студентов " + kurs2a + " курса.").Alignment = Alignment.left;
            double ans_a = 1 / 42;
            double ans_b = 5 / 14;
            word.doc.InsertParagraph();
            word.doc.Save();
        }

        void modul1_17_2()
        {
            addlist();
            int a = random.Next(nums.Count);
            int b1 = random.Next(numsb.Count);
            int b2 = random.Next(numsb.Count);
            string aword = nums[a];
            string b1word = numsb[b1];
            string b2word = numsb[b2];
            string hat = "2. В студенческой столовой на обед предлагается по три вида салатов, первых и вторых блюд. Студент, как обычно, берет на обед пять блюд. Найти вероятность того, что он взял:";
            string input = "\nа) " + aword + " салата;\nб) " + b1word + " первых и " + b2word + " вторых блюда.";
            if (aword == "один") input = (Regex.Replace(input, "салата", "салат")).ToString();
            if (b1word == numsb[0]) input = (Regex.Replace(input, "первых", "первое")).ToString();
            if (b2word == numsb[0]) input = (Regex.Replace(input, "вторых блюда", "второе блюдо")).ToString();
            CreateTask1_9 c = new CreateTask1_9();
            int aw = c.Parse(aword); int b1w = c.Parse(b1word); int b2w = c.Parse(b2word);
            string res = hat + input;
            double ans_a= sochet(Convert.ToUInt32(a),3)* sochet(Convert.ToUInt32(5-a), 6)/sochet(5, 9);
            double ans_b = sochet(Convert.ToUInt32(b1), 3) * sochet(Convert.ToUInt32(b2), 3) / sochet(5,9);
            Word word = new Word(name);
            word.doc.InsertParagraph();
            word.doc.InsertParagraph(res);
            word.doc.Save();
        }

        void modul3_16_1()
        {
            addlist();
            Word word = new Word(name);
            word.doc.InsertParagraph();

            string head = "6. Из полного набора костей домино (28) наугад извлечена кость. Найти вероятность того, что вторую наугад взятую кость можно приставить к первой, если первая оказалась: ";
            string fst = list2[random.Next(list2.Count)];
            string snd = list2.Find(x => x != fst);
            string r = list[random.Next(list.Count)]; int rint = Parse(r);
            string tail = "\na) " + fst + "\nб) " + snd;
            string res = head + tail;
            double ans_a, ans_b;
            if (fst == "дубль") { ans_a = 1 / 4; ans_b = 4 / 9; }
            else { ans_a = 4 / 9; ans_b = 1 / 4; }
            word.doc.InsertParagraph(res);
            word.doc.Save();
        }

        void modul3_16_2()
        {
            addlist();
            Word word = new Word(name);
            word.doc.InsertParagraph();
            double fst = prob[random.Next(prob.Count)];
            double presnd = prob[random.Next(prob.Count)]; double snd = presnd == fst ? prob[random.Next(prob.Count)] : presnd;
            string res = "7. Три брата посеяли пшеницу, однако «...в долгом времени аль вскоре приключилось с ними горе: кто-то в поле стал ходить да пшеницу шевелить. Наконец они смекнули, чтоб стоять на карауле, хлеб ночами поберечь, злого вора подстеречь». В их деревне всем известно, что старший брат засыпает в дозоре с вероятностью  " + fst.ToString().Replace('.', ',') + ", средний — " + snd.ToString().Replace('.', ',') + ", а у младшего бессонница. Найти вероятность того, что в первую ночь удастся поймать вора, если очередность дежурства определяется жребием. ";
            double ans = (1 / 3) * ((1 - fst) + (1 - snd) + 1);
            word.doc.InsertParagraph(res);
            word.doc.Save();
        }

        void modul3_16_3()
        {
            addlist();
            Word word = new Word(name);
            word.doc.InsertParagraph();
            double fst = prob[random.Next(prob.Count)]; double presnd = prob[random.Next(prob.Count)]; double snd = presnd == fst ? prob[random.Next(prob.Count)] : presnd; double trd = prob.Find(x => x != fst && x != snd);
            double fst2 = prob[random.Next(prob.Count)]; double presnd2 = prob[random.Next(prob.Count)]; double snd2 = presnd2 == fst2 ? prob[random.Next(prob.Count)] : presnd; double trd2 = prob.Find(x => x != fst2 && x != snd2);
            string res = "8. Зритель с вероятностью " + fst.ToString().Replace('.', ',') + ", " + snd.ToString().Replace('.', ',') + " и " + trd.ToString().Replace('.', ',') + " соответственно может обратиться за билетом в одну из трех театральных касс Большого театра: в помещении театра, на Тверской и на станции метро «Пушкинская». Вероятность того, что к моменту прихода зрителя в кассе все билеты будут проданы, соответственно равна " + fst2.ToString().Replace('.', ',') + ", " + snd2.ToString().Replace('.', ',') + " и " + trd2.ToString().Replace('.', ',') + ". Поклонник Большого театра купил билет в одной из этих трех касс. Какова вероятность того, что эта касса на Тверской? ";
            double ans = snd * (1 - snd2) / (fst * fst2 + snd * snd2 + trd * trd2);
            word.doc.InsertParagraph(res);
            word.doc.Save();
        }

        void modul3_17_1()
        {
            addlist();
            Word word = new Word(name);
            word.doc.InsertParagraph();
            int num = nums[3];
            string res = "6. В колоде 36 карт. Наугад извлекают " + num.ToString() + " карты. Найти вероятность того, что вторым вынут туз, если первым тоже вынут туз. ";
            if (num == 5) res = Regex.Replace(res, "карты", "карт");
            double ans = 3 / 35;
            word.doc.InsertParagraph(res);
            word.doc.Save();
        }

        void modul3_17_2()
        {
            addlist();
            Word word = new Word(name);
            word.doc.InsertParagraph();
            double fst = nums[random.Next(nums.Count)];
            double presnd = nums[random.Next(nums.Count)];
            double snd = Equals(presnd, fst) ? nums[random.Next(nums.Count)] : presnd;
            double thrd = nums.Find(x => x != fst && x != snd);
            string res = "7. В фотоателье работают три оператора, каждый из которых печатает соответственно 35, 40 и 25% всей продукции. Вероятность того, что фотография будет некачественной, для первого оператора равна " + fst.ToString().Replace('.', ',') + ", для второго — " + snd.ToString().Replace('.', ',') + ", для третьего — " + thrd.ToString().Replace('.', ',') + ". Вы не знаете, к какому из операторов попала ваша фотопленка с портретом любимой бабушки. Какова вероятность того, что вы, получив снимок, узнаете на нем свою бабушку? ";
            double ans = 0.35 * (1 - fst) + 0.4 * (1 - snd) + 0.25 * (1 - thrd);
            word.doc.InsertParagraph(res);
            word.doc.Save();
        }

        void modul3_17_3()
        {
            addlist();
            Word word = new Word(name);
            word.doc.InsertParagraph();
            double fst = prob1[random.Next(prob1.Count)];
            double presnd = prob1[random.Next(prob1.Count)];
            double snd = Equals(presnd, fst) ? prob1[random.Next(prob1.Count)] : presnd;
            double thrd = prob1.Find(x => x != fst && x != snd);

            double fst2 = prob2[random.Next(prob2.Count)];
            double presnd2 = prob2[random.Next(prob2.Count)];
            double snd2 = Equals(presnd2, fst2) ? prob2[random.Next(prob2.Count)] : presnd2;
            double thrd2 = prob2.Find(x => x != fst2 && x != snd2);
            string res = "8. Студента Зевского на лекциях по математике посещают музы: Евтерпа (муза лирической поэзии) — с вероятностью " + fst.ToString().Replace('.', ',') + "; Эрато (муза любовной поэзии) — с вероятностью " + snd.ToString().Replace('.', ',') + " и Каллиопа (муза эпической поэзии) — с вероятностью " + thrd.ToString().Replace('.', ',') + ". Известно, что после посещения соответствующей музы Зевский лирические стихи сочиняет с вероятностью " + fst2.ToString().Replace('.', ',') + ", любовные — с вероятностью " + snd2.ToString().Replace('.', ',') + " и эпические — с вероятностью " + thrd2.ToString().Replace('.', ',') + ". Какова вероятность того, что написанное Зевским на очередной лекции стихотворение было эпическим? ";
            
            word.doc.InsertParagraph(res);
            word.doc.Save();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
