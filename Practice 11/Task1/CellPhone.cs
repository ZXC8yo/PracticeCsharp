using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class CellPhone : Phone
    {
        private string model;

        public CellPhone(string name, int k, string model) : base(name, k)
        {
            this.model = model;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double CalculateCash()
        {
            return K * 3;
        }

        public void DisplayFields()
        {
            base.DisplayFields();
            Console.WriteLine($"Вторая сторона: {model}");
        }
    }
}
