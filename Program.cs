
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
            // ʹ�� WebHost ���ü������� IP ��ַ
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
