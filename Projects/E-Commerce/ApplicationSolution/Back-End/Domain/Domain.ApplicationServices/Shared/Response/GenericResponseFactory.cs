using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ApplicationServices.Shared.Response
{
    public static class GenericResponseFactory
    {
        public static GenericResponse<T> BuildSuccessResponse<T>(T data)
        {
            GenericResponse<T> successResponse = new GenericResponse<T>();
            successResponse.ResponseStatus = ResponseStatusEnum.Ok;
            successResponse.Data = data;
            return successResponse;

        }

        public static GenericResponse<T> BuildNotFoundResponse<T>()
        {
            GenericResponse<T> successResponse = new GenericResponse<T>();
            successResponse.ResponseStatus = ResponseStatusEnum.NotFound;
            successResponse.Message = "the required resource is not found or deleted";
            return successResponse;

        }
    }


}
