using _2Domain.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AccessData.Validation
{
    public class CategoriaValidation:AbstractValidator<CategoriaDTO>
    {
        public CategoriaValidation() 
        {
            RuleFor(c=>c.tipo).MinimumLength(1).MaximumLength(15).NotEmpty().Matches("^[a-zA-Z]+$")
                .WithMessage("El minimo es de 1 caracter y el maximo 15 solo letras");
            
        }
    }
}
