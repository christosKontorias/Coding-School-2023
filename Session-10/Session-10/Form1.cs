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
            List<Student> students = new List<Student>();

            _university = new University()
            {
                Name = "University 1"
            };

            Student student1 = new Student()
            {
                Name = "Student 1",
                Surname = "Surname 1",
                Age = 20,
                Gender = Student.GenderEnum.Male
            };

            Student student2 = new Student()
            {
                Name = "Student 2",
                Surname = "Surname 2",
                Age = 22,
                Gender = Student.GenderEnum.Female
            };

            _university.Students.Add(student1);
            _university.Students.Add(student2);
            
            students.Add(student1);
            students.Add(student2);

            grvStudents.AutoGenerateColumns = false;
            grvStudents.DataSource = students;
            
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeTofile(_university, "university.json");

            MessageBox.Show("Save Done");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            _university = serializer.DeserializeFromFile<University>("university.json");

            MessageBox.Show(_university.Name + " Loaded!");

        }

        private void grvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}