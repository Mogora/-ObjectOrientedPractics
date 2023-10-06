using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart(List<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Задает и возращает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public double Amount
        {
            get
            {
                double amount = 0;

                for (int i = 0; i < _items.Count(); i++)
                {
                    amount += _items[i].Cost;
                }

                return amount;
            }
        }
    }
}
