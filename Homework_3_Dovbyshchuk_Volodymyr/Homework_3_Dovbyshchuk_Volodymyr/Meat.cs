using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Dovbyshchuk_Volodymyr
{
    internal class Meat : Product
    {
        private Category category;
        private TypeOfMeat typeofmeat;

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public TypeOfMeat TypeOfMeat
        {
            get { return typeofmeat; }
            set { typeofmeat = value; }
        }

        public Meat() : base()
        {
            Category = new Category();
            TypeOfMeat = new TypeOfMeat();
        }

        public Meat(string Name, double Price, double Weight, Category category, TypeOfMeat typeofmeat) : base(Name, Price, Weight)
        {
            this.category = category;
            this.typeofmeat = typeofmeat;
        }

        public override void ChangePrice(int percent)
        {
            base.ChangePrice(percent);
            int meatPercent = (int)this.typeofmeat;
            base.ChangePrice(meatPercent);
        }

        public override string ToString()
        {
            return base.ToString() + $"Meat category: {category}\nType: {typeofmeat}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Meat)
                return false;
            else
            {
                Meat other = (Meat)obj;
                return base.Equals(other) && this.typeofmeat == other.typeofmeat && this.category == other.category;
            }
            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.category.GetHashCode() ^ this.typeofmeat.GetHashCode();
        }


    }
}
