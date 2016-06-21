using System.Collections.Generic;

namespace GaussLMS.Data.Madrasah
{
    class MadrasahInfo
    {
        public Mosque Mosque { get; set; }
        public PersonalInformation Principal{ get; set; }

    }
    class Madrasah
    {
        MadrasahInfo info;
        List<Field> fields;
        List<Teacher> facultyMembers;
        List<Premise> premises;
    }
}
