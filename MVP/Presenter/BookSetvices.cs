using MVP.Model;
using System.Data;
using System.Data.SqlClient;

namespace MVP.Presenter
{
    public class BookSetvices
    {
        public static bool Insert(BookModel model)
        {
            return Helper.setData("P_Insert_Book",()=>Insert(model,Helper.command));
        }
        private static void Insert(BookModel model,SqlCommand command)
        {
            command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = model.Title;
            command.Parameters.Add("@Author", SqlDbType.NVarChar).Value = model.Author;
            command.Parameters.Add("@Year", SqlDbType.DateTime2).Value = model.Year;
        }
        public static bool Delete(BookModel model)
        {
            return Helper.setData("P_Delete_Book", () => Delete(model, Helper.command));
        }
        private static void Delete(BookModel model, SqlCommand command)
        {
            command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = model.Title;
            command.Parameters.Add("@Author", SqlDbType.NVarChar).Value = model.Author;
            command.Parameters.Add("@Year", SqlDbType.DateTime2).Value = model.Year;
        }
        public static bool Update(BookModel model)
        {
            return Helper.setData("P_Update_Book", () => Update(model, Helper.command));
        }
        private static void Update(BookModel model, SqlCommand command)
        {
            command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = model.Title;
            command.Parameters.Add("@Author", SqlDbType.NVarChar).Value = model.Author;
            command.Parameters.Add("@Year", SqlDbType.DateTime2).Value = model.Year;
        }
    }
}
