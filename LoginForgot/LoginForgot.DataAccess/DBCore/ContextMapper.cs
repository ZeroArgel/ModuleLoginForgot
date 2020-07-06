using AutoMapper;
using LoginForgot.Models;
using System.Collections.Generic;

namespace LoginForgot.DataAccess.DBCore
{
    public static class ContextMapper
    {
        public static IEnumerable<TR> MiddleT<T, TR>(this IEnumerable<T> model)
        {
            var mapper = MapperT();
            return mapper.Map<IEnumerable<TR>>(model);
        }
        private static Mapper MapperT() =>
            new Mapper(
                new MapperConfiguration(
                    cfg => {
                        cfg.CreateMap<User, Users>();
                        cfg.CreateMap<GetUserToLogin_Result, User>();
                        cfg.CreateMap<GetUserByEmail_Result, User>();
                        cfg.CreateMap<GetAllCountryPhonesToCombo_Result, GenericKeyValue>();
                        cfg.CreateMap<GetCodeToForgot_Result, Forgot>();
                    })
                );
    }
}