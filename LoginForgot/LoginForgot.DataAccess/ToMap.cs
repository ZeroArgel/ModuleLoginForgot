namespace LoginForgot.DataAccess.Core
{
    using AutoMapper;
    public static class ToMap
    {
        public static TR To<T, TR>(this T model) => MapperT().Map<TR>(model);
        private static Mapper MapperT() =>
            new Mapper(
                new MapperConfiguration(
                    cfg => {
                    })
                );
    }
}