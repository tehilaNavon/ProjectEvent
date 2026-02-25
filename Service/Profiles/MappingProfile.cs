using AutoMapper;
using Repository.Entities;
using Service.Dto.UserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Profiles
{
   

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // כאן אנחנו מגדירים את ה"גשר" בין ה-DTOs
            CreateMap<UserDtoo, UserUpdateDto>();
            CreateMap<UserRegisterDto, UserDtoo>();
            CreateMap<UserDtoo, UserRegisterDto>();
            // זו השורה שהייתה חסרה וגרמה לשגיאה:
            CreateMap<UserRegisterDto, User>();

            // אם תצטרכי בעתיד להפוך חזרה מ-Entity ל-Dto:
            CreateMap<User, UserRegisterDto>();
            // אם יש לך עוד המרות (למשל מ-User למודל), הוסיפי אותן כאן
            CreateMap<User, UserDtoo>();

            // אם את צריכה להפוך גם מה-DTO חזרה לישות (למשל בעדכון/הוספה):
            CreateMap<UserDtoo, User>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserUpdateDto>();


        }
    }

}
