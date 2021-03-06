using System;

namespace teorver_zadachi
{
    class Program
    {
        static ulong mult_in(uint a, uint b)
        {
            ulong ans=1;
            for (uint i=a; i<=b; i++)
            {
                ans *= i;
            }
            return ans;
        }

        static double f(double x)
        {
            double ans=Math.Pow(Math.E, (-(Math.Abs(x * x)) / 2));
            return ans;
        }

        static double integral(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f(xi) + f(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double Laplas(double x)
        {
            double ans = (1 /(Math.Sqrt(2 * Math.PI))) * integral(100000, 0, Math.Abs(x));
            return ans;
        }

        static double fi(double x)
        {
            double ans;
            if (Math.Abs(x) <= 3.6) ans = 1 / (Math.Sqrt(2 * Math.PI)) * Math.Pow(Math.E, (-(Math.Abs(x * x)) / 2));
            else ans = 0;
            return ans;
        }

        static ulong factorial(uint a)
        {
            if (a == 0) return 1;
            else return a * factorial(a - 1);
        }
        static ulong sochet(uint a, uint b)
        {
            return (factorial(b) / (factorial(a) * factorial(b - a)));
        }
        //модуль 1 16.1
        double modul1_16_1_a(int fst, int snd, int trd)
        {
            double ans_a; //ответы на пункты а и б
            if (fst == 0 || snd == 0) ans_a = (double)1 / 72;
            else ans_a = 1 / 64;
            return ans_a;
        }
        static double modul1_16_1_b(int fst, int snd, int trd)
        {
            double ans_b;
            if (trd == 0) ans_b = (double)1 / 10;
            else ans_b = (double)1 / 19;
            return ans_b;
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
        static double modul1_16_2_a(int f, int s, int t)
        {
            double ans_a = (double)sochet(5, Convert.ToUInt32(f)) / sochet(5, 15);
            return ans_a;
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

        static double modul1_16_2_b(int f, int s, int t)
        {
            double ans_b = (double)(sochet(2, Convert.ToUInt32(s)) * sochet(2, Convert.ToUInt32(t)) * sochet(1, Convert.ToUInt32(f))) / (sochet(5, 15));
            return ans_b;
        }

        static double modul1_17_1_a()
        {
            double ans_a = (double)1 / 42;
            return ans_a;
        }

        static double modul1_17_1_b()
        {
            double ans_b = (double)5 / 14;
            return ans_b;
        }

        static double modul1_17_2_a(int a)
        {
            double ans_a= (double)sochet(Convert.ToUInt32(a),3)* sochet(Convert.ToUInt32(5-a), 6)/sochet(5, 9);
            return ans_a;
        }

        static double modul1_17_2_b(int b1, int b2)
        {
            double ans_b = (double)sochet(Convert.ToUInt32(b1), 3) * sochet(Convert.ToUInt32(b2), 3) / sochet(5, 9);
            return ans_b;
        }

        static double modul3_16_1_a(string fst)
        {

            double ans_a;
            if (fst == "дубль") ans_a = (double)1 / 4; 
            else ans_a = (double)4 / 9;
            return ans_a;
        }

        static double modul3_16_1_b(string fst)
        {

            double ans_b;
            if (fst == "дубль") ans_b = (double)4 / 9; 
            else ans_b = (double)1 / 4;
            return ans_b;
        }

        static double modul3_16_2(double fst, double snd)
        {
            double ans = ((double)1 /3) * ((1 - fst) + (1 - snd) + 1);
            return ans;

        }

        static double modul3_16_3(double fst, double snd, double trd, double fst2, double snd2, double trd2)
        {
            double ans = (double)snd * (1 - snd2) / (fst * fst2 + snd * snd2 + trd * trd2);
            return ans;
        }

        static double modul3_17_1()
        {
            double ans = (double)3 / 35;
            return ans;
        }

        static double modul3_17_2(double fst,double snd, double thrd)
        {
            double ans = (double)0.35 * (1 - fst) + 0.4 * (1 - snd) + 0.25 * (1 - thrd);
            return ans;
        }

        static double modul3_17_3(double fst, double snd, double thrd, double fst2, double snd2, double thrd2)
        {
           double ans = ((double)snd * snd2) / (fst * fst2 + snd * snd2 + thrd * thrd2);
           return ans;
        }

        static double modul4_16_1(int wdint)
        {
            double p = (double)5 / 55;
            double pp = 1 - p;
            double ans = sochet(Convert.ToUInt32(wdint), 10) * Math.Pow(p, wdint) * Math.Pow(pp, 10 - wdint);
            return ans;
        }

        static double modul4_16_2_a(int num)
        {
            double p = 0.25;
            double q = 0.75;
            double x = ((double)num - 243 * p) / (Math.Sqrt(243 * p * q));
            double ans = (1 / (Math.Sqrt(243 * p * q))) * fi(x);
            return ans;
        }

        static double modul4_16_2_b(int num)
        {
            double p = 0.25;
            double q = 0.75;
            double x1 = ((double)num - 243 * p) / (Math.Sqrt(243 * p * q));
            double x2 = 0;
            double ans = Laplas(x1) - Laplas(x2);
            return ans;
        }

        static double modul4_16_3(int wd)
        {
            //n=100; p=0.001; k=num;
            double ans=0;
            double lambda = 100 * 0.001;
            for (int i = 0; i < wd; i++)
            {
                ans += (Math.Pow(lambda, i)) / (factorial(Convert.ToUInt32(i))) * Math.Pow(Math.E, -1*lambda);
            }
            return ans;
        }

        static double modul4_17_1(int num)
        {
            double p = 0.25;
            double pp = 0.75;
            double ans = 0;
            for (int i = num; i <= 5; i++)
            {
                ans+= sochet(Convert.ToUInt32(i), 5) * Math.Pow(p, i) * Math.Pow(pp, 5 - i);
            }
            return ans;
        }

        static double modul4_17_2_a(int fst, int snd)
        {
            double p = 0.8;
            double q = 0.2;
            double x1 = ((double)snd - 100 * p) / (Math.Sqrt(100 * p * q));
            double x2 = ((double)fst - 100 * p) / (Math.Sqrt(100 * p * q)); ;
            double ans = Laplas(x1) - Laplas(x2);
            return ans;
        }

        static double modul4_17_2_b()
        {
            double p = 0.8;
            double q = 0.2;
            double x = ((double)50 - 100 * p) / (Math.Sqrt(100 * p * q));
            double ans = (1 / (Math.Sqrt(100 * p * q))) * fi(x);
            return ans;//тут ответ очень близок к 0, поэтому не знаю точно как считать.
        }

        static double modul4_17_3(int fst, int snd)
        {
            //n=fst; p=0.05; k=snd;
            double ans = 0;
            double lambda = fst * 0.05;
            ans = (Math.Pow(lambda, snd)) / (factorial(Convert.ToUInt32(snd))) * Math.Pow(Math.E, -1 * lambda);
            return ans;
        }

        static double modul5_16_1_mx(double fst, double snd, double trd)
        {
            double p1 = fst;
            double p2 = (1 - p1) * snd;
            double p3 = (1 - p1) * (1 - p2) * trd;
            double p4 = (1 - p1) * (1 - p2) * (1 - p3);
            double ans = 0;
            ans = 0 * p1 + 1 * p2 + 2 * p3 * 3 * p4;
            return ans;
        }

        static double modul5_16_1_dx(double fst, double snd, double trd)
        {
            double p1 = fst;
            double p2 = (1 - p1) * snd;
            double p3 = (1 - p1) * (1 - p2) * trd;
            double p4 = (1 - p1) * (1 - p2) * (1 - p3);
            double mx = modul5_16_1_mx(fst, snd, trd);
            double ans = 0 * p1 + 1 * p2 + 2*2 * p3 * 3*3 * p4-mx*mx;
            return ans;
        }

        static double modul5_16_1_sx(double fst, double snd, double trd)
        {
            double dx = modul5_16_1_dx(fst, snd, trd);
            double ans = Math.Sqrt(dx);
            return ans;
        }

        static double modul5_17_1_mx(double fst, double snd, double trd, double fth)
        {
            double ans = 1 * fst + 2 * snd + 3 * trd + 4 * fth;
            return ans;
        }

        static double modul5_17_1_dx(double fst, double snd, double trd, double fth)
        {
            double mx = modul5_17_1_mx(fst, snd, trd, fth);
            double ans = 1 * fst + 2 * 2 * snd + 3 * 3 * trd + 4 * 4 * fth - mx * mx;
            return ans;
        }

        static double modul5_17_1_sx(double fst, double snd, double trd, double fth)
        {
            double dx = modul5_17_1_dx(fst, snd, trd, fth);
            double ans = Math.Sqrt(dx);
            return ans;
        }

        static double modul6_16_1_mx(double probability)
        {
            double p1 = sochet(0,4)*Math.Pow(1 - probability, 4);
            double p2 = sochet(1,4)*probability * Math.Pow(1 - probability, 3);
            double p3 = sochet(2,4)*probability * probability * Math.Pow(1 - probability, 2);
            double p4 = sochet(3,4)*Math.Pow(probability, 3) * (1 - probability);
            double p5 = Math.Pow(probability, 4);
            double ans = 0*p1 + 1*p2 + 2*p3 + 3*p4 + 4*p5;
            return ans;
        }

        static double modul6_16_1_dx(double probability)
        {
            double mx = modul6_16_1_mx(probability);
            double p1 = sochet(0, 4) * Math.Pow(1 - probability, 4);
            double p2 = sochet(1, 4) * probability * Math.Pow(1 - probability, 3);
            double p3 = sochet(2, 4) * probability * probability * Math.Pow(1 - probability, 2);
            double p4 = sochet(3, 4) * Math.Pow(probability, 3) * (1 - probability);
            double p5 = Math.Pow(probability, 4);
            double ans = 0 * p1 + 1 * p2 + 2 * 2 * p3 + 3 * 3 * p4 + 4 * 4 * p5 - mx * mx;
            return ans;
        }
        
        static double modul6_17_1_mx(int f, int s)
        {
            double p = (double)f / 100;
            double q = 1 - p;
            double ans = 0;
            double[] pp = new double[s+1];
            for(int i=0;i<=s;i++)
            {
                pp[i] = sochet(Convert.ToUInt32(i), Convert.ToUInt32(s)) * Math.Pow(p, i) * Math.Pow(q, s - i);
            }
            for (int i = 0; i <= s; i++)
            {
                ans += i * pp[i];
            }
            return ans;
        }

        static double modul6_17_1_dx(int f, int s)
        {
            double mx = modul6_17_1_mx(f, s);
            double p = (double)f / 100;
            double q = 1 - p;
            double ans = 0;
            double[] pp = new double[s + 1];
            for (int i = 0; i <= s; i++)
            {
                pp[i] = sochet(Convert.ToUInt32(i), Convert.ToUInt32(s)) * Math.Pow(p, i) * Math.Pow(q, s - i);
            }
            for (int i = 0; i <= s; i++)
            {
                ans += i*i * pp[i];
            }
            ans = ans - mx * mx;
            return ans;
        }

        static double modul7_16_1_mx(double prob)
        {
            double mx = 1000 * prob;
            return mx;
        }

        static double modul7_17_1_mx(double prob)
        {
            double mx = prob * 400;
            return mx;
        }

        static double modul8_16_1_mx(double fst, double snd, double fst2, double snd2)
        {
            double trd = 1 - fst - snd;
            double mx = -1 * fst + 1 * snd + 2 * trd;
            return mx;
        }

        static double modul8_16_1_dx(double fst, double snd, double fst2, double snd2)
        {
            double trd = 1 - fst - snd;
            double mx = modul8_16_1_mx(fst, snd, fst2, snd2);
            double dx = 1 * fst + 1 * snd + 2 * 2 * trd-mx*mx;
            return dx;
        }

        static double modul8_16_1_my(double fst, double snd, double fst2, double snd2)
        {
            double my = 3 * fst2 + 5 * snd;
            return my;
        }

        static double modul8_16_1_dy(double fst, double snd, double fst2, double snd2)
        {
            double my = modul8_16_1_my(fst, snd, fst2, snd2);
            double dy = 3 * 3 * fst2 + 5 * 5 * snd2 - my * my;
            return dy;
        }

        static double modul8_17_1_mx(double fst, double snd, double fst2, double snd2)
        {
            double p = 1 - fst - snd;
            double mx = 1 * p + 2 * fst + 3 * snd;
            return mx;
        }

        static double modul8_17_1_dx(double fst, double snd, double fst2, double snd2)
        {
            double p = 1 - fst - snd;
            double mx = modul8_17_1_mx(fst,snd,fst2,snd2);
            double dx = 1 * p + 2 * 2 * fst + 3 * 3 * snd-mx*mx;
            return dx;
        }

        static double modul8_17_1_my(double fst, double snd, double fst2, double snd2)
        {
            double my = -1*fst2+4*snd2;
            return my;
        }

        static double modul8_17_1_dy(double fst, double snd, double fst2, double snd2)
        {
            double my = modul8_17_1_my(fst, snd, fst2, snd2);
            double dy = 1 * fst2 + 4 * 4 * snd2 - my * my;
            return dy;
        }

        static double modul9_16(double alpha, double b)
        {
            double fa;
            double fb;
            if (alpha <= -2) fa = 0;
            else fa = ((double)alpha / 4) + (double)1 / 2;
            if (b > 2) fb = 1;
            else fb= ((double)b / 4) + (double)1 / 2;
            double ans = fb - fa;
            return ans;
        }

        static double modul9_17(double alpha, double b)
        {
            double fa, fb;
            if (alpha <= 0) fa = 0;
            else fa = ((double)alpha * alpha + alpha) / 2;
            if (b > 1) fb = 1;
            else fb= ((double)b * b + b) / 2;
            double ans = fb - fa;
            return ans;
        }

        static double f10_16(double x)
        {
            double ans = (double)1 / (Math.Sqrt(4 - x * x));
            return ans;
        }

        static double integralf10_16(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f10_16(xi) + f10_16(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double modul10_16()
        {
            double a = (double)1 / integralf10_16(1000, -2, 2);
            return a;
        }

        static double f10_17(double x)
        {
            double ans = 4 * x - x * x * x;
            return ans;
        }

        static double integralf10_17(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f10_17(xi) + f10_17(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double modul10_17()
        {
            double a = (double)1 / integralf10_17(1000, 0, 2);
            return a;
        }


        static double modul11_16_p(int alpha, int bet)
        {
            double pb, pa;
            if (alpha <= 1) pa = 0;
            else if (alpha > 1 && alpha <= 4) pa = ((double)2 / 9) * alpha;
            else pa = ((double)14 * alpha - alpha * alpha - 22) / 27;
            if (bet > 4 && bet <= 7) pb = ((double)14 * bet - bet * bet - 22) / 27;
            else pb = 1;
            double ans = pb - pa;
            return ans;
        }

        static double f11_16_1(double x)
        {
            double ans = ((double)2 / 9) * x;
            return ans;
        }

        static double integralf11_16_1(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f11_16_1(xi) + f11_16_1(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double f11_16_2(double x)
        {
            double ans = (((double)2 / 27) * (7-x))*x;
            return ans;
        }

        static double integralf11_16_2(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f11_16_2(xi) + f11_16_2(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double modul11_16_mx(int alpha, int bet)
        {
            double mx = integralf11_16_1(1000, 1, 4) + integralf11_16_2(1000, 4, 7);
            return mx;
        }

        static double f11_16_dx1(double x)
        {
            double ans = ((double)2 / 9) * x*x;
            return ans;
        }

        static double integralf11_16_dx1(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f11_16_dx1(xi) + f11_16_dx1(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double f11_16_dx2(double x)
        {
            double ans = (((double)2 / 27) * (7 - x)) * x*x;
            return ans;
        }

        static double integralf11_16_dx2(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f11_16_dx2(xi) + f11_16_dx2(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double modul11_16_dx(int alpha, int bet)
        {
            double dx = integralf11_16_dx1(1000, 1, 4) + integralf11_16_dx2(1000, 4, 7);
            return dx;
        }

        static double modul11_16_sx(int alpha, int bet)
        {
            double dx = modul11_16_dx(alpha, bet);
            double sx = Math.Sqrt(dx);
            return sx;
        }

        static double modul11_17_p(double alpha, double bet)
        {
            double pb, pa;
            if (alpha <= 0) pa = 0;
            else if (alpha > 0 && alpha <= 2) pa = (alpha*alpha*alpha)/20;
            else pa = ((3*alpha)/5)-(double)4/5;
            if (bet > 2 && bet <= 3) pb = ((3 * bet) / 5) - (double)4 / 5;
            else pb = 1;
            double ans = pb - pa;
            return ans;
        }

        static double f11_17_mx1(double x)
        {
            double ans = ((double)3 / 20) * x*x*x;
            return ans;
        }

        static double integralf11_17_mx1(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f11_17_mx1(xi) + f11_17_mx1(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double f11_17_mx2(double x)
        {
            double ans = ((double)3/5) * x;
            return ans;
        }

        static double integralf11_17_mx2(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f11_17_mx2(xi) + f11_17_mx2(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double modul11_17_mx(int alpha, int bet)
        {
            double mx = integralf11_17_mx1(1000, 0, 2) + integralf11_16_2(1000, 2, 3);
            return mx;
        }

        static double f11_17_dx1(double x)
        {
            double ans = ((double)3 / 20) * x * x * x * x;
            return ans;
        }

        static double integralf11_17_dx1(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f11_17_dx1(xi) + f11_17_dx1(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double f11_17_dx2(double x)
        {
            double ans = ((double)3/5)*x*x;
            return ans;
        }

        static double integralf11_17_dx2(double n, double a, double b)
        {
            double h, res, sum, xi, xi1;
            sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += (f11_17_dx2(xi) + f11_17_dx2(xi1));
            }
            res = sum * h / 2;
            return res;
        }

        static double modul11_17_dx(int alpha, int bet)
        {
            double dx = integralf11_17_dx1(1000, 0, 2) + integralf11_17_dx2(1000, 2, 3);
            return dx;
        }

        static double modul11_17_sx(int alpha, int bet)
        {
            double dx = modul11_17_dx(alpha, bet);
            double sx = Math.Sqrt(dx);
            return sx;
        }

        static double modul12_16(int num)
        {
            //(a=0;b=num)
            double ans = 1-Math.Abs((Laplas(((double)num - 10) / 1.5) - Laplas(0)));
            return ans;
        }

        static double modul12_17(int num)
        {
            //(a=0;b=num)
            double ans = 1 - Math.Abs((Laplas(((double)num - 80) / 6) - Laplas(0)));
            return ans;
        }

        static void Main(string[] args)
        {
            double ans = modul10_17();
            Console.WriteLine(ans);
        }
    }
}
