using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Dovbyshchuk_Volodymyr
{
    internal class DairyProducts : Product
    {
        private int expirationdate;

        public int ExpirationDate
        {
            get { return expirationdate; }
            set { expirationdate = value; }
        }

        public DairyProducts() : base()
        {
            ExpirationDate = default;
        }

        public DairyProducts(string Name, double Price, double Weight, int expirationdate) : base(Name, Price, Weight)
        {
            this.expirationdate = expirationdate;
        }

        public override void ChangePrice(int percent)
        {
            base.ChangePrice(percent);

            if (this.expirationdate < 10 && this.ExpirationDate > 0)
            {
                base.ChangePrice(5);
            }
            else if (this.expirationdate >= 10 && this.expirationdate < 100)
            {
                base.ChangePrice(20);
            }
            else { base.ChangePrice(30); }
        }

        public override string ToString()
        {
            return base.ToString() + $"Expiration date: {this.expirationdate}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not DairyProducts)
                return false;
            else
            {
                DairyProducts other = (DairyProducts)obj;
                return base.Equals(other) && this.expirationdate == other.expirationdate;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.expirationdate.GetHashCode();
        }



    }
}
