namespace Exam.Web.ViewModels
{
    using System;

    using AutoMapper;

    using Exam.Common.Mappings;
    using Exam.Models;

    public class CommentsViewModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string User { get; set; }

        public string Content { get; set; }
        public DateTime DataTime { get; set; }

        public string UserId { get; set; }

        //public virtual User User { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentsViewModel>()
                .ForMember(x => x.User, cnf => cnf.MapFrom(m => m.User.Email));
        }
    }
}