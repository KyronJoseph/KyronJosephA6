using KyronJosephA6.Model;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace KyronJosephA6
{
    /// <summary>
    /// this is the form class for the bookdataform
    /// </summary>
    public partial class BookDataForm : Form
    {
        private List<Book> books = new List<Book>();
        /// <summary>
        /// contrcutor that intialized component
        /// </summary>
        public BookDataForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this button will allow user to select a specific file on computer to be read in 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async Task chooseFileButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this button will load the data from the file and export it as a CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportDataCSVButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this button will load the data from the file and export it as a Json file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportDataJsonButton_Click(object sender, EventArgs e)
        {

        }

    }
}
