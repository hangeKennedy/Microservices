using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Servicios.api.Libreria.Core.Entities
{
    public class Autor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // tipo object id
        public string? Id { get; set; }

        [BsonElement("nombre")]
        public string? Nombre { get; set; }

        [BsonElement("apellido")]
        public string? Apellido { get; set; }

        [BsonElement("gradoAcademico")]
        public string? GradoAcademico { get; set; }
    }
}
