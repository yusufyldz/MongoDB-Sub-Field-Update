namespace MongoDB_Update_SubField.Business
{
    public interface IMongoOperation
    {
        Task UpdateAccountMongo(int class_number, string teacher_name);
    }
}
