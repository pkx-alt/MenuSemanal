using SQLite; // ⬅️ Cambiamos esto para que reconozca PrimaryKey y AutoIncrement

namespace MenuSemanal.Models
{
    public class Receta
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Nombre { get; set; }

        public double TiempoPreparacion { get; set; }

        // Nota: Como vamos a usar una tabla intermedia para los ingredientes,
        // no necesitamos el IdIngrediente aquí. 
    }
}