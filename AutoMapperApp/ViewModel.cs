namespace AutoMapperApp
{
    public class GradeDetailsModel
    {
        public int Id { get; set; }
        public LocalizedItem Name { get; set; }
        public bool HasTracks { get; set; }
        public bool HasDescription { get; set; }
        public bool AddDegreesAndDescriptionPosiblity { get; set; }
        public List<GradeTracksModel> Tracks { get; set; }
        public List<GradeSubjectsModel> Subjects { get; set; }
    }
    public class GradeTracksModel
    {
        public int Id { get; set; }
        public LocalizedItem Name { get; set; }
        public int SubjectCount { get; set; }
        public List<GradeSubjectsModel> Subjects { get; set; }
    }
    public class GradeSubjectsModel
    {
        public int Id { get; set; }
        public LocalizedItem Name { get; set; }
        public string ClassRoomNumber { get; set; }
        public TimeSpan StudyHour { get; set; }
        public bool IsMandatory { get; set; }
        public bool HaveGpa { get; set; }
        public bool IsAddToFinalScore { get; set; }
        public int WeekClassRoomNumber { get; set; }
    }

}
