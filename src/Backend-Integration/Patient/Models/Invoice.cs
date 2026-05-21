namespace Patient.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public decimal Amount { get; set; }
    }
}
