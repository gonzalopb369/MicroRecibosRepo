
using FluentValidation;

namespace MicroRecibos.Modelos
{
    public class Recibo
    {
        public Guid Id { get; set; }

        public int NroRecibo { get; set; }

        public DateTime FechaPago { get; set; }

        public string NombrePasajero { get; set; }

        public Guid CodigoReserva { get; set; }

        public string Concepto { get; set; }

        public decimal MontoTotal { get; set; }

        public decimal ACuenta { get; set; }
        public decimal Saldo { get; set; }

        public int Estado { get; set; }


        public Recibo()
        {
            FechaPago = DateTime.Now;
            Estado = 3;
        }
    }


    public class ReciboValidator : AbstractValidator<Recibo>
    {
        public ReciboValidator()
        {
            RuleFor(p => p.NombrePasajero).NotEmpty().WithMessage("Debe ingresar el nombre del pasajero!");
            RuleFor(p => p.NombrePasajero).MaximumLength(50).WithMessage("El nombre del pasajero debe tener 50 caracteres como máximo!");
            RuleFor(p => p.CodigoReserva).NotEmpty().WithMessage("Debe ingresar el Código de Reserva!");            
            RuleFor(p => p.Concepto).NotEmpty().WithMessage("Debe ingresar el Concepto del Recibo!");
            RuleFor(p => p.Concepto).MaximumLength(100).WithMessage("El Concepto debe tener 100 caracteres como máximo!");
            RuleFor(p => p.MontoTotal).NotEmpty().WithMessage("Debe ingresar el Monto Total!");
            RuleFor(p => p.MontoTotal).GreaterThan(0).WithMessage("El Monto total debe ser mayor a 0!");
            RuleFor(p => p.ACuenta).NotEmpty().WithMessage("Debe ingresar el Monto pagado!");
            RuleFor(p => p.ACuenta).GreaterThan(0).WithMessage("El Monto Pagado debe ser mayor a 0!");
            RuleFor(p => p.Saldo).NotEmpty().WithMessage("Debe ingresar el Saldo restante!");
            RuleFor(p => p.Saldo).GreaterThan(0).WithMessage("El Saldo restante debe ser mayor a 0!");

        }

    }

}
