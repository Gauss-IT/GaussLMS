using System;
using System.Collections.Generic;

namespace GaussLMS.Data.Madrasah
{
    class Student
    {
        Guid StudentID;
        PersonalInformation StudentInfo;
        List<Parent> Parents;
        List<Lesson> Lessons;
       // Dictionary<LessonClass, bool> Attendance;
        Dictionary<Lesson, Grade> Grades;
        Timetable timetable;
    }
}
