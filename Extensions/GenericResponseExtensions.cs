using LitePosBackend.Dto;

namespace LitePosBackend.Extensions
{
    public static  class GenericResponseExtensions
    {
        public static GenericResponseDTO<T> ToSuccess<T>(this T t)
        {
            return new GenericResponseDTO<T>()
            {
                Response = t,
                Status = "OK",
                StatusCode = 2000
            };
        }

        public static GenericResponseDTO<T> ToError<T>(this T t,int statusCode,Tuple<string,string> error)
        {
            return new GenericResponseDTO<T>()
            {
                Response = default(T),
                Status = "ERR",
                StatusCode = statusCode,
                ErrorMessage = error.Item2,
                ErrorCode = error.Item1,
            };
        }

    }
}
