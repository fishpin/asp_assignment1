namespace Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.MapControllers();

            app.MapGet("/", () => "Welcome to the Library!");

            //Books routes
            app.MapGet("/books", () => { return "These are all the books!"; });
            app.MapGet("/books/{id}", (HttpContext context) =>
            {
                var bookId = context.Request.RouteValues["id"];
                return $"This book is ID# {bookId}.";
            });
            app.MapPost("/books", () => { return "This is a book post request!"; });
            app.MapPut("/books/{id}", (HttpContext context) => 
            {
                var bookId = context.Request.RouteValues["id"];
                return $"Book ID# {bookId} has been updated.";
            });
            app.MapDelete("/books/{id}", (HttpContext context) =>
            {
                var bookId = context.Request.RouteValues["id"];
                return $"Book ID# {bookId} has been deleted.";
            });

            //Readers routes
            app.MapGet("/readers", () => { return "These are all the readers!"; });
            app.MapGet("/readers/{id}", (HttpContext context) => 
            {
                var readerId = context.Request.RouteValues["id"];
                return $"This reader is ID# {readerId}"; 
            });
            app.MapPost("/readers", () => { return "This is a reader post request!"; });
            app.MapPut("/readers/{id}", (HttpContext context) =>
            {
                var readerId = context.Request.RouteValues["id"];
                return $"Reader ID# {readerId} has been updated.";
            });
            app.MapDelete("/readers/{id}", (HttpContext context) =>
            {
                var readerId = context.Request.RouteValues["id"];
                return $"Reader ID# {readerId} has been deleted.";
            });

            //Borrowings routes
            app.MapGet("/borrowings", () => { return "These are all the borrowings!"; });
            app.MapGet("/borrowings/{id}", (HttpContext context) =>
            {
                var borrowingId = context.Request.RouteValues["id"];
                return $"This borrowing is ID# {borrowingId}";
            });
            app.MapPost("/borrowings", () => { return "This is a borrowings post request!"; });
            app.MapPut("/borrowings/{id}", (HttpContext context) =>
            {
                var borrowingId = context.Request.RouteValues["id"];
                return $"Borrowing ID# {borrowingId} has been updated.";
            });
            app.MapDelete("/borrowings/{id}", (HttpContext context) =>
            {
                var borrowingId = context.Request.RouteValues["id"];
                return $"Borrowing ID# {borrowingId} has been deleted.";
            });

            app.Run();
        }
    }
}
