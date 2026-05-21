namespace Patient.Models
{
    public class Prescription
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public string Medicine { get; set; }

        public string Dosage { get; set; }
    }
}
