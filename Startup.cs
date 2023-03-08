using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using studentsAPI.Context;
using studentsAPI.Repository;
using studentsAPI.Repository.Interfaces;

namespace studentsAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

          services.AddControllers().AddNewtonsoftJson(options => {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IBaseRepository, BaseRepository>();
            services.AddScoped<IClassroomRepository, ClassroomRepository>();
            services.AddScoped<ISchoolSubjectRepository, SchoolSubjectRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            
            services.AddDbContext<StudentContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("StudentDatabase"),
                    assembly => assembly.MigrationsAssembly(typeof(StudentContext).Assembly.FullName));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1.0.0",
                    Title = "Students Service.",
                    Description = "Registration flow of classes and students.",
                    Contact = new OpenApiContact
                    {
                        Name = "Victor99Dev",
                        Url = new Uri("https://victor99dev.site/")
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
