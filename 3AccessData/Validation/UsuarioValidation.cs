using _2Domain.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AccessData.Validation
{
    public class UsuarioValidation:AbstractValidator<UsuarioDTO>
    {
        public UsuarioValidation() 
        {
            RuleFor(dto=>dto.nombre).MinimumLength(2).MaximumLength(40).NotEmpty().Matches("^[a-zA-Z ]+$").
                WithMessage("El minimo son 2 caracteres y el maximo 40, solo letras");
            RuleFor(dto=>dto.apellido).MinimumLength(2).MaximumLength(40).NotEmpty().Matches("^[a-zA-Z]+$").
                WithMessage("El minimo son 2 caracteres y el maximo 40, solo letras");
            RuleFor(dto => dto.dni).Matches("^[0-9]+$").NotEmpty().
                WithMessage("solo se aceptan numeros");
            RuleFor(dto => dto.email).Matches("^.+@.+\\..+$").NotEmpty().
                WithMessage("Ingrese un email valido");
            
        }  
    }
}
