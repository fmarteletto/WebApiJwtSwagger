using System.ComponentModel.DataAnnotations;

namespace WebAPIJWT.Controllers
{

    /// <summary>
    /// Classe que representa o Usuario
    /// </summary>
    /// <example>Usuario para acesssar determinada funcionalidade</example>
    public class Usuario
    {

        /// <summary>
        /// Id do Usuario, Idenfificação unica
        /// </summary>
        /// <example>1</example>
        [Required]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do Usuario
        /// </summary>
        /// <example>Flavio Marteletto</example>
        [Required]
        [StringLength(maximumLength:150, MinimumLength =3,ErrorMessage = "O Nome deve conter no minimo 3 e maximo 150 carateres")]

        public string Nome { get; set; }

        /// <summary>
        /// Email do Usuario
        /// </summary>
        /// <example>flavio_marteletto@hotmail.com</example>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Nivel de Permissão
        /// </summary>
        /// <example>Administrador/Usuario</example>
        [Required]
        public string Role { get; set; }
    }





}


