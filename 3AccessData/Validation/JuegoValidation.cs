using _2Domain.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AccessData.Validation
{
    public class JuegoValidation:AbstractValidator<JuegoDTO>
    {
        public JuegoValidation() 
        {   
            RuleFor(dto=>dto.nombre).MinimumLength(2).MaximumLength(40).NotEmpty().Matches("^[a-zA-Z0-9 ]+$").
                WithMessage("El minimo son 2 caracteres y el maximo 40, solo letras");
            RuleFor( dto=>dto.precio).LessThan(999999999999).NotEmpty().GreaterThan(0).
                WithMessage("El valor no puede superar los 18 digitos y el valor debe ser un numero");
            RuleFor(dto=>dto.imagen).MinimumLength(1).MaximumLength(500).NotEmpty().Matches("^.+$").
                WithMessage("El link son 1 caracter y el maximo 500");
            RuleFor(dto=>dto.descripcion).MinimumLength(3).MaximumLength(2000).NotEmpty().Matches("^[a-zA-Z]+$").
                WithMessage("El minimo son 3 caracteres y el maximo 2000, solo letras");
        }
    }
}
