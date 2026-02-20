using SQLite;

namespace MenuSemanal.Models // Es buena práctica organizar esto en una carpeta "Models"
{
    public class Ingrediente
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, Unique]
        public string Nombre { get; set; }

        public string UnidadMedida { get; set; } // Ejemplo: "gramos", "unidades"
    }
}