using SerializerLib;
using System.Globalization;
using UniversityLib;
using static Session_10.University;

namespace Session_10 {
    public partial class Form1 : Form {

        private Serializer _serializer;
        private University _university;

        private void Form1_Load(object sender, EventArgs e) {

        }
        public Form1() {
            InitializeComponent();
            _serializer = new Serializer();
            _university = new University();
        }

        private void Populate() {

            // Populate Students
            var students = new List<Students>
            {
            new Students { Name = "John Doe", RegistrationNumber = 123, Age = 20 },
            new Students { Name = "Jane Doe", RegistrationNumber = 244, Age = 23 }
            };

            bsStudents.DataSource = students;
            studentGrid.DataSource = students;
            studentGrid.AutoGenerateColumns = false;

            // Populate Grades
            var grades = new List<Grades>();
            int gradesRow = 0;

            foreach (Students student in students) {
                grades.Add(new Grades { StudentName = student.Name, GradeValue = gradesRow == 0 ? 65 : 74 });                
                gradesRow++;
            }

            bsGrades.DataSource = grades;
            gradeGrid.DataSource = grades;
            gradeGrid.AutoGenerateColumns = false;

            // Populate Courses
            var courses = new List<Courses>
            {
            new Courses {Code = "205", Subject = "Mathematics" },
            new Courses {Code = "101", Subject = "English" }
            };

            bsCourses.DataSource = courses;
            courseGrid.DataSource = courses;
            courseGrid.AutoGenerateColumns = false;

            // Populate Scheduled Courses
            var scheduledCourses = new List<ScheduledCourses>();
            int scheduledCoursesRow = 0;

            foreach (Courses course in courses) {
                scheduledCourses.Add(new ScheduledCourses { CourseSubject = course.Subject, Callendar = scheduledCoursesRow == 0 ? new DateTime(2023, 5, 12) : new DateTime(2023, 6, 20) });
                scheduledCoursesRow++;
            }

            scheduledCourseGrid.DataSource = scheduledCourses;
            bsScheduledCourses.DataSource = bsCourses;
            scheduledCourseGrid.AutoGenerateColumns = false;

            // Add students list to the University object
            _university.Students = students;
            _university.Grades = grades;
            _university.Courses = courses;
            _university.ScheduledCourses = scheduledCourses;
        }
        private void btnPopulate_Click(object sender, EventArgs e) {
            Populate();
            _serializer.SerializeToFile(_university, "university.json");
            MessageBox.Show("Populate Successful!");
        }
        private void btnSave_Click(object sender, EventArgs e) {
            _serializer.SerializeToFile(_university, "university.json");
            MessageBox.Show("Saved!");
        }
        private void btnLoad_Click(object sender, EventArgs e) {

            if (File.Exists("university.json")) {
                _university = _serializer.DeserializeFromFile<University>("university.json");
                bsStudents.DataSource = _university.Students;
                studentGrid.DataSource = _university.Students;
                bsGrades.DataSource = _university.Grades;
                gradeGrid.DataSource = _university.Grades;
                bsCourses.DataSource = _university.Courses;
                courseGrid.DataSource = _university.Courses;
                bsScheduledCourses.DataSource = _university.ScheduledCourses;
                scheduledCourseGrid.DataSource = _university.ScheduledCourses;
                MessageBox.Show("Load Successful!");
            } else {
                MessageBox.Show("File Not Found!");
            }
        }
    }
}