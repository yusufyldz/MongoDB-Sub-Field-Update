using MongoDB.Driver;
using MongoDB_Update_SubField.Models;

namespace MongoDB_Update_SubField.Business
{
    public class MongoOperation : IMongoOperation
    {
        private readonly IConfiguration _configuration;
        public MongoOperation(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task UpdateAccountMongo(int class_number, string teacher_name)
        {
            
            MongoClient client = new MongoClient(_configuration.GetSection("ConnectionStrings:MongoDB").Value);

            var DataBase = client.GetDatabase("School");
            var _collection = DataBase.GetCollection<StudentClassroom>("StudentClassroms");

            var filter = Builders<StudentClassroom>.Filter.And(Builders<StudentClassroom>.Filter.Where(x => x.class_number == class_number ),
                Builders<StudentClassroom>.Filter.ElemMatch(p => p.Students, x => x.class_number == class_number));

            var update = Builders<StudentClassroom>.Update.Set(x => x.teacher_name, teacher_name).Set("Students.$[].teacher_name", teacher_name);
            await _collection.UpdateManyAsync(filter, update);
        }



    }
}
