namespace Assignment4._1._1
{
    public partial class Form1 : Form
    {
        Dictionary<string, Person> contactBook = new Dictionary<string, Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddNewContactButton_Click(object sender, EventArgs e)
        {
            Person newPerson= new Person();

            if (FirstNameTextBox.Text != null)
            {
                newperson.FirstName = FirstNameTextBox.Text;
            }

            if (LastNameTextBox.Text != null)
            {
                newPerson.LastName = LastNameTextBox.Text;
            }

            if (MobilePhone.TextBox.Text != null)
            {
                newPerson.MobilePhone = Convert.ToInt32(MobilePhoneTextBox.Text);
            }

            if (WorkPhone.TextBox.Text != null)
            {
                newPerson.WorkPhone = Convert.ToInt32(WorkPhoneTextBox.Text);
            }


           newPerson.FirstName =  FNametextBox.Text;
           newPerson.LastName = LNametextBox.Text;
            newPerson.MobilePhoneNumber = MPhone.textBox.Text;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
