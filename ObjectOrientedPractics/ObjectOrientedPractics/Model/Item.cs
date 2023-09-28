using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        private static int _allItemsCount;

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара. Должно быть не более 200 символов.</param>
        /// <param name="info">Описание товара. Должно быть не более 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Должна быть в пределах от 0 до 100000.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Cost = cost;
            Info = info;
            _allItemsCount++;
            _id = _allItemsCount;
           
        }

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Name), value, 200);
                _name = value;
            }
        }

        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Info), value, 1000);
                _info = value;
            }
        }

        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(nameof(Cost), value, 0, 100000);
                _cost = value;
            }
        }
    }
}
