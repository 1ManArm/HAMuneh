using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMuneh
{
    internal class Money
    {

        private int rubles;
        private int kopeks;

        public Money(int rubles, int kopeks)
        {
            if (rubles < 0 || kopeks < 0)
            {
                throw new ArgumentException("Счет не может быть отрицательным");
            }

            this.rubles = rubles;
            this.kopeks = kopeks;
        }

        public int Rubles
        {
            get { return rubles; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Счет не может быть отрицательным");
                }

                rubles = value;
            }
        }

        public int Kopeks
        {
            get { return kopeks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Счет не может быть отрицательным");
                }

                kopeks = value;
            }
        }

        public static Money operator +(Money m1, Money m2)
        {
            int totalKopeks = (m1.rubles * 100 + m1.kopeks) + (m2.rubles * 100 + m2.kopeks);
            return new Money(totalKopeks / 100, totalKopeks % 100);
        }

        public static Money operator -(Money m1, Money m2)
        {
            int totalKopeks = (m1.rubles * 100 + m1.kopeks) - (m2.rubles * 100 + m2.kopeks);

            if (totalKopeks < 0)
            {
                throw new Exception("Банкрот");
            }

            return new Money(totalKopeks / 100, totalKopeks % 100);
        }

        public static Money operator /(Money m, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            int totalKopeks = (m.rubles * 100 + m.kopeks) / divisor;
            return new Money(totalKopeks / 100, totalKopeks % 100);
        }

        public static Money operator *(Money m, int multiplier)
        {
            if (multiplier < 0)
            {
                throw new ArgumentException("Множитель не может быть отрицательным");
            }

            int totalKopeks = (m.rubles * 100 + m.kopeks) * multiplier;
            return new Money(totalKopeks / 100, totalKopeks % 100);
        }

        public static Money operator ++(Money m)
        {
            return new Money(m.rubles, m.kopeks + 1);
        }

        public static Money operator --(Money m)
        {
            if (m.kopeks == 0)
            {
                throw new Exception("Банкрот");
            }

            return new Money(m.rubles, m.kopeks - 1);
        }

        public static bool operator <(Money m1, Money m2)
        {
            int totalKopeks1 = m1.rubles * 100 + m1.kopeks;
            int totalKopeks2 = m2.rubles * 100 + m2.kopeks;
            return totalKopeks1 < totalKopeks2;
        }

        public static bool operator >(Money m1, Money m2)
        {
            int totalKopeks1 = m1.rubles * 100 + m1.kopeks;
            int totalKopeks2 = m2.rubles * 100 + m2.kopeks;
            return totalKopeks1 > totalKopeks2;
        }

        public static bool operator ==(Money m1, Money m2)
        {
            int totalKopeks1 = m1.rubles * 100 + m1.kopeks;
            int totalKopeks2 = m2.rubles * 100 + m2.kopeks;
            return totalKopeks1 == totalKopeks2;
        }

        public static bool operator !=(Money m1, Money m2)
        {
            int totalKopeks1 = m1.rubles * 100 + m1.kopeks;
            int totalKopeks2 = m2.rubles * 100 + m2.kopeks;
            return totalKopeks1 != totalKopeks2;
        }

        public override string ToString()
        {
            return $"{rubles} rubles {kopeks} kopeks";
        }
    }
}
