namespace StudentAttendanceManagement
{
    public class StudentAttendanceDetailsModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public double AttendencePercentage { get; set; }
    }
}
