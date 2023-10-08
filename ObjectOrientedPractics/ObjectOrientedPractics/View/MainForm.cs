using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        /// <summary>
        /// Предоставляет реализацию расположения элементов на форме.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            itemsTab1.Items = _store.Items;
            customersTabs1.Customers = _store.Customers;
            cartsTab1.Items = Store.Items;
            cartsTab1.Customers = Store.Customers;
        }

        /// <summary>
        /// Возвращает и задаёт информацию о магазине (товары и покупатели).
        /// </summary>
        public Store Store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }
    }
}
