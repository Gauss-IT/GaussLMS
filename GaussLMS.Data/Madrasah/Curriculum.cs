using System.Collections.Generic;

namespace GaussLMS.Data.Madrasah
{
    public class Field
    {
        string fieldName;
        List<Subject> subjects;
    }
    public class Subject
    {
        string subjectName;
        Field field;
        List<Chapter> chapters;
        EvaluationWeighting value;

    }
    public class Chapter 
    {
        string chapterName;
        Subject subject;
        List<Lesson> lessons;
        EvaluationWeighting value;
    }

    public class Lesson
    {
        string lessonName;
        Chapter chapters;
        List<LessonUnit> lessonUnits;
        EvaluationWeighting value;
    }
    class LessonUnit
    {
        string lessonUnitName;
        Chapter chapters;
        List<string> lessonContent;
        EvaluationWeighting value;
    }
}
