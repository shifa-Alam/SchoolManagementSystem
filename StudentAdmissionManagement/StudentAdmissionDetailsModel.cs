namespace StudentAdmissionManagement
{
    public class StudentAdmissionDetailsModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string StudentClass { get; set; } = string.Empty;
        public DateTime DateofJoining { get; set; }
    }
}
