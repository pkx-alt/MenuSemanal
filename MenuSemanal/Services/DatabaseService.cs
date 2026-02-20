using SQLite;
using MenuSemanal.Models;

namespace MenuSemanal.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _connection;

        // Este método configura la conexión y crea las tablas
        private async Task Init()
        {
            if (_connection != null)
                return;

            // Definimos dónde se guardará el archivo en el dispositivo
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MenuSemanal.db3");

            _connection = new SQLiteAsyncConnection(databasePath);

            // Creamos las tablas basadas en nuestras Entidades
            await _connection.CreateTableAsync<Receta>();
            await _connection.CreateTableAsync<Ingrediente>();
            await _connection.CreateTableAsync<RecetaIngrediente>();
        }

        public async Task<int> SaveRecetaAsync(Receta receta)
        {
            // 1. Nos aseguramos de que las tablas existan
            await Init();

            // 2. Insertamos la receta en la tabla
            return await _connection.InsertAsync(receta);
        }
    }
}