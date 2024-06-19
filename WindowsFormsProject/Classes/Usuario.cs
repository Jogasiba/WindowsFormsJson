using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WindowsFormsProject.Classes
{
    public class Usuario
    {
        public class Unit
        {
            [Required(ErrorMessage = "Nome é obrigatório!")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Email é obrigatório!")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Telefone é obrigatório!")]
            public string Telefone { get; set; }

            [Required(ErrorMessage = "Cpf é obrigatório!")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Cep é obrigatório!")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Login é obrigatório!")]
            public string Login { get; set; }

            [Required(ErrorMessage = "Senha é obrigatória!")]
            public string Senha { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }
        }
        
        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
