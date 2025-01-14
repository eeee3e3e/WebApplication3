
namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // 使用 WebHost 配置监听所有 IP 地址
            builder.WebHost.UseUrls("http://0.0.0.0:8080");
            var app = builder.Build();

            // Configure the HTTP request pipeline. 
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
