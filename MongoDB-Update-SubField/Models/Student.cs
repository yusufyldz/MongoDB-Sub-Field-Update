using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Update_SubField.Models
{
    public class Student
    {
        [BsonId]
        public int id { get; set; }
        public int class_number { get; set; }
        public string student_name { get; set; }
        public string student_number { get; set; }
        public string phone_number { get; set; }
        public string parent_phone_number { get; set; }
        public string teacher_name { get; set; }
    }
}
