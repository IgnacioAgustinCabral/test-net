var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllers();  // Registra los controladores
builder.Services.AddEndpointsApiExplorer();  // Explora los endpoints
builder.Services.AddSwaggerGen();  // Configura Swagger para la documentación

var app = builder.Build();

// Configuración del pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  // Habilita Swagger en desarrollo
    app.UseSwaggerUI();  // Habilita la interfaz Swagger en desarrollo
}

app.UseHttpsRedirection();  // Redirige HTTP a HTTPS

app.UseRouting();  // Habilita el enrutamiento

app.MapControllers();  // Mapea los controladores a las rutas

app.Run();  // Ejecuta la aplicación