using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace blog_app_test.Models
{
    public class BlogEntry
    {
        [BindNever]
        public int BlogEntryId { get; set; }

        [Required(ErrorMessage = "Defina un titulo para el articulo")]
        [DisplayName("Titulo")]
        public string Title { get; set; } = string.Empty;

        // todo: Segregar información de autores en nueva entidad
        [Required(ErrorMessage = "Se requiere el nombre del autor")]
        [DisplayName("Autor")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe establecer un contenido para el articulo")]
        [DisplayName("Contenido")]
        public string Content { get; set; } = string.Empty;

        [BindNever]
        public DateTime Created { get; set; } = DateTime.Now;

        public string GetTruncatedContent(int characters)
        {
            if (Content.Length < characters)
            {
                return Content;
            }

            return string.Concat(Content.AsSpan(0, characters), "...");
        }
    }
}
