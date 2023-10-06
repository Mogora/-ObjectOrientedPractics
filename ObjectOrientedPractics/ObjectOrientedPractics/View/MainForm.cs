using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

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
        }
    }
}
