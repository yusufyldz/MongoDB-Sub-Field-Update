using Microsoft.AspNetCore.Mvc;
using MongoDB_Update_SubField.Business;

namespace MongoDB_Update_SubField.Controller
{
    public class MongoController : ControllerBase
    {
        private readonly IMongoOperation _mongoOperation;
        public MongoController(IMongoOperation mongoOperation)
        {
            _mongoOperation = mongoOperation;
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTeacherName(int classroom_id,string teacher_name)
        {
           await  _mongoOperation.UpdateAccountMongo(classroom_id, teacher_name);
            return Ok();
        }
    }
}
