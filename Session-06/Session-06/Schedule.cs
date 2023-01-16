using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    class Schedule
    {
        //Properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }


        //Constructor
        public Schedule()
        {

        }
        public Schedule(Guid id)
        {
            ID = id;
        }
        public Schedule(Guid id, Guid courseid)
        {
            ID = id;
            CourseID = courseid;
        }
        public Schedule(Guid id, Guid studentid, Guid courseid, Guid professorid)
        {
            ID = id;
            CourseID = courseid;
            ProfessorID = professorid;
        }
        public Schedule(Guid id, Guid studentid, Guid courseid, Guid professorid, DateTime callendar)
        {
            ID = id;
            CourseID = courseid;
            ProfessorID = professorid;
            Callendar = callendar;
        }
    }
}
