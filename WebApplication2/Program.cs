namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseStaticFiles();

            app.Run(async (context) => 
            {
                context.Response.ContentType = "text/html; charset=utf-8";

                if (context.Request.Path == "/page2")
                {
                    await context.Response.SendFileAsync("html/page2.html");
                }
                else if (context.Request.Path == "/page3")
                {
                    await context.Response.SendFileAsync("html/page3.html");
                }
                else
                {
                    await context.Response.SendFileAsync("html/page1.html");
                }
            });

            app.Run();
        }
    }
}