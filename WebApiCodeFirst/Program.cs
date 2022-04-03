using CodeFirstDb;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CourseContext>();

var app = builder.Build();

var scope = app.Services.CreateScope();
var studentCourseDb = scope.ServiceProvider.GetRequiredService<CourseContext>();
studentCourseDb.Database.EnsureDeleted();
studentCourseDb.Database.EnsureCreated();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();