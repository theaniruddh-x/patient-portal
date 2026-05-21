namespace Patient.Models
{
    public class LabResult
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public string TestName { get; set; }

        public string Result { get; set; }
    }
}
