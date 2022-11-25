using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMapperApp
{
    public class Grade
    {
        public int Id { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public IEnumerable<Track> GradeTracks { get; set; }
        public bool AddDegreesAndDescriptionPosiblity { get; set; }
        public bool HasTracks { get; set; }
    }
    public class Track
    {
        public int Id { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public IEnumerable<TrackSubject> TrackSubjects { get; set; }
    }
    public class TrackSubject
    {
        public int Id { get; set; }

        [ForeignKey("Track")]
        public int TrackId { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Track Track { get; set; }
        public Subject Subject { get; set; }
    }
    public class Subject
    {
        public int Id { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public double? GPA { get; set; }
        public int? SubjectHours { get; set; }
        public bool? IsMandatory { get; set; }
        public int WeekClassRoomNumber { get; set; }
        public bool HaveGpa { get; set; }
        public bool IsAddToFinalScore { get; set; }
        public TimeSpan StudyHour { get; set; }
    }
}
