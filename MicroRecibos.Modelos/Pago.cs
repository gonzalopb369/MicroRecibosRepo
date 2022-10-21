

namespace MicroRecibos.Modelos
{
    public class Pago
    {
        public Guid Id { get; set; }
        public string NombPasajero { get; set; }
        public string ReservationNumber { get; set; }
        public int originalValue { get; set; }
        public int currentValue { get; set; }
        public int Amount { get; set; }
        public Guid Booking { get; set; }
        public DateTime Date { get; set; }
    }
}
