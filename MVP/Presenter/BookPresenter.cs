using MVP.Model;
using MVP.View;

namespace MVP.Presenter
{
    public class BookPresenter
    {
        IBook ibook =null;
        BookModel bookModel = null;

        public BookPresenter(IBook ibook)
        {
            this.ibook = ibook;
            bookModel = new BookModel();
        }
        private void ConnectedBetweenInterfaceAndModel()
        {
            this.bookModel.Title = this.ibook.Title;
            this.bookModel.Author = this.ibook.Author;
            this.bookModel.Year = this.ibook.Year;
        }
        public bool Insert()
        {
            ConnectedBetweenInterfaceAndModel();
            return BookSetvices.Insert(this.bookModel);

        }
        public bool Update()
        {
            ConnectedBetweenInterfaceAndModel();
            return BookSetvices.Update(this.bookModel);
        }
        public bool Delete()
        {
            ConnectedBetweenInterfaceAndModel();
            return BookSetvices.Delete(this.bookModel);
        }
    }
}
