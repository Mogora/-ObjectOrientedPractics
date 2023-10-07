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

            //ItemsTab.Items = _store.Items;
            //CustomersTab.Customers = _store.Customers;
            //CartsTab.Items = Store.Items;
            //CartsTab.Customers = Store.Customers;
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
