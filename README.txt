Crear migraciones (Referenciar el proyecto en los comandos si son varios)
	https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=vs
	Add-Migration NewMigration -Project Model //Crea una migracion del Model a sentencias SQL
	Update-Database -Project Model //Para actualizar la base de datos


Para lograr la migracion de la base de datos creamos el constructor en Program.cs de la API builder.Services.AddDbContext<DbModelContext>();
Tambien, en el dbcontextmodel tuvimos que referenciar directamente la base de datos, ya que no reconocía el appsettings. En la siguinte linea de codigo.
var str = "Server=localhost\\SQLEXPRESS;Database=DemoDataBase;MultipleActiveResultSets=true; TrustServerCertificate=True";
