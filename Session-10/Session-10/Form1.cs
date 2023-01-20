namespace Session_10
{
    public partial class Form1 : Form
    {
        private University _university;
        private Grade _grade;
        private Course _course;
        private ScheduledCourse _scheduledCourse;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateData();
            PopulateGrades();
            PopulateCourses();
            PopulateScheduledCourses();
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
        private void PopulateGrades()
        {
            List<Grade> grades = new List<Grade>();

            _grade = new Grade()
            {
                CourseID = new Guid(),

                GradeValue = 0
            };

            Grade grade1 = new Grade()
            {
                CourseID = new Guid(),
                GradeValue = 67
            };

            Grade grade2 = new Grade()
            {
                CourseID = new Guid(),
                GradeValue = 84
            };

            _university.Grades.Add(grade1);
            _university.Grades.Add(grade2);

            grades.Add(grade1);
            grades.Add(grade2);

            grvGrades.AutoGenerateColumns = false;
            grvGrades.DataSource = grades;
        }
        private void PopulateCourses()
        {
            List<Course> courses = new List<Course>();

            _course = new Course()
            {
                Code = " ",
                Subject = " "
            };

            Course course1 = new Course()
            {
                Code = "101",
                Subject = "Math"
            };

            Course course2 = new Course()
            {
                Code = "150",
                Subject = "CS"
            };


            _university.Courses.Add(course1);
            _university.Courses.Add(course2);

            courses.Add(course1);
            courses.Add(course2);

            grvCourses.AutoGenerateColumns = false;
            grvCourses.DataSource = courses;
        }
        private void PopulateScheduledCourses()
        {
            List<ScheduledCourse> scheduledCourses = new List<ScheduledCourse>();

            _scheduledCourse = new ScheduledCourse()
            {
                Subject = "",
                Callendar = DateTime.Now
            };

            ScheduledCourse scheduledCourse1 = new ScheduledCourse()
            {
                Subject = "Math",
                Callendar = DateTime.Today.AddDays(4)
            };

            ScheduledCourse scheduledCourse2 = new ScheduledCourse()
            {
                Subject = "CS",
                Callendar = DateTime.Today.AddDays(3)
            };

            _university.ScheduledCourses.Add(scheduledCourse1);
            _university.ScheduledCourses.Add(scheduledCourse2);

            scheduledCourses.Add(scheduledCourse1);
            scheduledCourses.Add(scheduledCourse2);

            grvScheduledCourses.AutoGenerateColumns = false;
            grvScheduledCourses.DataSource = scheduledCourses;
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