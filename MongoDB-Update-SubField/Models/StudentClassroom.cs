namespace MongoDB_Update_SubField.Models
{
    public class StudentClassroom
    {
        public int id { get; set; }
        public int class_number { get; set; }
        public string class_name { get; set; }
        public string teacher_name { get; set; }
        public List<Student> Students { get; set; }


    }
}
