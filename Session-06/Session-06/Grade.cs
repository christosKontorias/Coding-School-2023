using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_06
{
    class Grade
    {
        //Properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeValue { get; set; }


        //Constructor
        public Grade()
        {

        }
        public Grade(Guid id)
        {
            ID = id;
        }
        public Grade(Guid id, Guid studentid)
        {
            ID = id;
            StudentID = studentid;
        }
        public Grade(Guid id, Guid studentid, Guid courseid)
        {
            ID = id;
            StudentID = studentid;
            CourseID = courseid;
        }
        public Grade(Guid id, Guid studentid, Guid courseid, int gradevalue)
        {
            ID = id;
            StudentID = studentid;
            CourseID = courseid;
            GradeValue = gradevalue;
        }
    }
}