using Session_10.Libraries;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Session_10
{
    public partial class Form1 : Form
    {
        private University _university;
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            SetControlProperties();
   
        }
        private void SetControlProperties() {
            PopulateStudents();
            PopulateGrades();
            PopulateCourses();
            PopulateScheduledCourses();
        }

        private void PopulateStudents() {
            _university = new University() {
                Name = "University Title"
            };
            List<Students> student = new List<Students>();

            Students student1 = new Students() {
                Name = "Student 1",
                Age = 20,
                RegistrationNumber = 1
            };

            Students student2 = new Students() {
                Name = "Student 2",
                Age = 25,
                RegistrationNumber = 2
            };

            student.Add(student1);
            student.Add(student2);
            GridViewStudents.DataSource = student;
            GridViewStudents.AutoGenerateColumns = false;

            _university.Student.Add(student1);
            _university.Student.Add(student2);
        }

        private void PopulateGrades() {
            _university = new University() {
                Name = "University Title"
            };
            List<Grades> grade = new List<Grades>();

            Grades grade1 = new Grades() {
                ID = new Guid(),
                GradeValue = 67
            };

            Grades grade2 = new Grades() {
                ID = new Guid(),
                GradeValue = 84
            };

            grade.Add(grade1);
            grade.Add(grade2);

            GridViewGrades.DataSource = grade;
            GridViewGrades.AutoGenerateColumns = false;

            _university.Grade.Add(grade1);
            _university.Grade.Add(grade2);
        }
        private void PopulateCourses() {
            _university = new University() {
                Name = "University Title"
            };
            List<Courses> course = new List<Courses>();

            Courses course1 = new Courses() {
                Code = "101",
                Subject = "Maths"
            };

            Courses course2 = new Courses() {
                Code = "150",
                Subject = "CS"
            };

            course.Add(course1);
            course.Add(course2);

            GridViewCourses.DataSource = course;
            GridViewCourses.AutoGenerateColumns = false;

            _university.Course.Add(course1);
            _university.Course.Add(course2);
        }
        private void PopulateScheduledCourses() {
            _university = new University() {
                Name = "University Title"
            };
            List<ScheduledCourses> scheduledCourse = new List<ScheduledCourses>();

            ScheduledCourses scheduledCourse1 = new ScheduledCourses() {
                ID = new Guid(),
                Callendar = DateTime.Today.AddDays(56)
            };

            ScheduledCourses scheduledCourse2 = new ScheduledCourses() {
                ID = new Guid(),
                Callendar = DateTime.Today.AddDays(40)
            };

            scheduledCourse.Add(scheduledCourse1);
            scheduledCourse.Add(scheduledCourse2);

            GridViewScheduledCourses.DataSource = scheduledCourse;
            GridViewScheduledCourses.AutoGenerateColumns = false;

            _university.ScheduledCourse.Add(scheduledCourse1);
            _university.ScheduledCourse.Add(scheduledCourse2);
        }
        private void button1_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_university, "university.json");

            MessageBox.Show("Save Done!");
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();

            _university = serializer.DeserializeFromFile<University>("university.json");

            MessageBox.Show(_university.Name + " Loaded!");
        }
    }
}