using AutoMapper;
using AutoMapperApp;

var configuration = new MapperConfiguration(cfg =>
{

    cfg.CreateMap<Grade, GradeDetailsModel>()
.ForMember(x => x.Name, x => x.MapFrom(x => new LocalizedItem(x.EnglishName, x.ArabicName)))
  .ReverseMap();


    cfg.CreateMap<GradeDetailsModel, Grade>()
.ForMember(x => x.EnglishName, x => x.MapFrom(x => x.Name.En))
.ForMember(x => x.ArabicName, x => x.MapFrom(x => x.Name.Ar))
.ForMember(x => x.GradeTracks, x => x.MapFrom(x => x.Tracks))
  .ReverseMap();


    cfg.CreateMap<GradeTracksModel, Track>()
.ForMember(x => x.EnglishName, x => x.MapFrom(x => x.Name.En))
.ForMember(x => x.ArabicName, x => x.MapFrom(x => x.Name.Ar))
.ForMember(x => x.TrackSubjects, x => x.MapFrom(x => x.Subjects))
.ReverseMap();



    cfg.CreateMap<GradeSubjectsModel, TrackSubject>()
.ForMember(x => x.Subject, x => x.MapFrom(x => new Subject()
{
    Id = x.Id,
    EnglishName = x.Name.En,
    ArabicName = x.Name.Ar,
    HaveGpa = x.HaveGpa,
    StudyHour = x.StudyHour,
    IsMandatory = x.IsMandatory,
    WeekClassRoomNumber = x.WeekClassRoomNumber,
    IsAddToFinalScore = x.IsAddToFinalScore,
}))
.ReverseMap();




    cfg.CreateMap<GradeTracksModel, TrackSubject>()
.ForMember(x => x.TrackId, x => x.MapFrom(x => x.Id))
.ForMember(x => x.TrackId, x => x.MapFrom(x => x.Id))
.ReverseMap();

    cfg.CreateMap<GradeSubjectsModel, TrackSubject>()
.ForMember(x => x.Subject, x => x.MapFrom(x => new Subject()
{
    Id = x.Id,
    EnglishName = x.Name.En,
    ArabicName = x.Name.Ar,
    HaveGpa = x.HaveGpa,
    StudyHour = x.StudyHour,
    IsMandatory = x.IsMandatory,
    WeekClassRoomNumber = x.WeekClassRoomNumber,
    IsAddToFinalScore = x.IsAddToFinalScore,
}))
.ReverseMap();

    cfg.CreateMap<Track, GradeTracksModel>()
.ForMember(x => x.Name, x => x.MapFrom(x => new LocalizedItem(x.EnglishName, x.ArabicName)))
.ForMember(x => x.SubjectCount, x => x.MapFrom(x => x.TrackSubjects.Count()))
.ForMember(x => x.Subjects, x => x.MapFrom(x => x.TrackSubjects))
.ReverseMap();

    cfg.CreateMap<GradeSubjectsModel, Subject>()
.ForMember(x => x.EnglishName, x => x.MapFrom(x => x.Name.En))
.ForMember(x => x.ArabicName, x => x.MapFrom(x => x.Name.Ar))
.ReverseMap();

    cfg.CreateMap<GradeSubjectsModel, Subject>()
.ForMember(x => x.EnglishName, x => x.MapFrom(x => x.Name.En))
.ForMember(x => x.ArabicName, x => x.MapFrom(x => x.Name.Ar));

    cfg.CreateMap<Subject, GradeSubjectsModel>()
.ForMember(x => x.Id, x => x.MapFrom(x => x.Id))
.ForMember(x => x.Name, x => x.MapFrom(x => new LocalizedItem(x.EnglishName, x.ArabicName)))
.ReverseMap();

});
var model = new GradeDetailsModel
{
    AddDegreesAndDescriptionPosiblity = true,
    HasDescription = true,
    HasTracks = true,
    Id = 1,
    Name = new LocalizedItem("gradeEn", "gradeAr"),
    Tracks = new List<GradeTracksModel>
    {
        new GradeTracksModel
        {Id = 1,
            Name= new LocalizedItem("trackEn", "trackAr"),
            Subjects = new List<GradeSubjectsModel>
            {
                new GradeSubjectsModel
                {
                    Id= 1,
                    ClassRoomNumber= "A2",
                    HaveGpa  =true,
                    IsAddToFinalScore = true,
                    IsMandatory= true,
                    StudyHour = new TimeSpan(1, 40,0),
                    Name= new LocalizedItem("subjectEn", "subjectAr"),
                    WeekClassRoomNumber = 8
                }
            }
        }
    }
};
var mapper = new Mapper(configuration);
var entity = mapper.Map<GradeDetailsModel, Grade>(model);

Console.WriteLine(entity);