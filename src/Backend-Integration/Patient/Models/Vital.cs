namespace Patient.Models
{
    public class Vital
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public string BloodPressure { get; set; }

        public int HeartRate { get; set; }
    }
}
