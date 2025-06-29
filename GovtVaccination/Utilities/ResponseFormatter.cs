namespace GovtVaccination.Utilities;

public class ResponseFormatter
{
    public ApiResponse SuccessResponse(object data = null, string message = "")
    {
        ApiResponse response = new ApiResponse();
        response.data = data;
        response.status = 200;
        response.status_title = "OK";
        response.message = "";
        response.errors = [];
        return response;
    }
}