namespace Session_10
{
    public partial class Form1 : Form
    {
        private University _university;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {
            _university = new University()
            {
                Name = "University 1"
            };

            Student student1 = new Student()
            {
                Name = "Student 1",
                Age = 20
            };

            Student student2 = new Student()
            {
                Name = "Student 2",
                Age = 25
            };

            _university.Students.Add(student1);
            _university.Students.Add(student2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeTofile(_university, "university.json");

            MessageBox.Show("Save Done");
        }
    }
}