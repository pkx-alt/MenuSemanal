using SQLite;

namespace MenuSemanal.Models
{
    public class RecetaIngrediente
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Indexed] // Ayuda a que las búsquedas sean más rápidas
        public int RecetaId { get; set; }

        [Indexed]
        public int IngredienteId { get; set; }

        public double CantidadNecesaria { get; set; }
    }
}