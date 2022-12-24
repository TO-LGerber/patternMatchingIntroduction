using APIExample.Models;

namespace APIExample.Services;

public class RequestValidationServiceImpl : IRequestValidationService
{
    public ValidationResult IsBodyValid(BodyObject body)
    {
        var isValid = body is { ID: > 1, Nested.MyProperty: not null };
        if (isValid)
        {
            return new ValidationResult(true);
        }

        return new ValidationResult(false, $"{nameof(body)} is invalid");
    }
}