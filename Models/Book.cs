using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lession1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        // danh sách cuốn sách
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id= 1,
                    Title ="Chí Phèo",
                    AuthorId =1 ,
                    GenreId=1,
                    Image="",
                    Price=50000,
                    Sumary="",
                    TotalPage=250 
                },
                new Book()
                {
                    Id= 2,
                    Title ="Động vật",
                    AuthorId =1 ,
                    GenreId=1,
                    Image="",
                    Price=50000,
                    Sumary="",
                    TotalPage=250
                },
                new Book()
                {
                    Id= 3,
                    Title ="Thực vật",
                    AuthorId =1 ,
                    GenreId=1,
                    Image="",
                    Price=50000,
                    Sumary="",
                    TotalPage=250
                },
                new Book()
                {
                    Id= 4,
                    Title ="Khoa học",
                    AuthorId =1 ,
                    GenreId=1,
                    Image="",
                    Price=50000,
                    Sumary="",
                    TotalPage=250
                },
            };
            return books;
        }
        // chi tiết 1 cuốn sách theo id (linq)
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        //
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Nam Cao"},
            new SelectListItem{Value="2", Text="Ngô Tất Tố"},
            new SelectListItem{Value="3", Text="AdamKhoom"},
            new SelectListItem{Value="4", Text="Thiên Sư"},
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Truyện Tranh"},
            new SelectListItem{Value="2", Text="Văn học"},
            new SelectListItem{Value="3", Text="AdamKhoom"},
            new SelectListItem{Value="4", Text="Thiên Sư"},
        };
    }
}
