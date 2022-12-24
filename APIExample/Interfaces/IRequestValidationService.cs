using APIExample.Models;

public interface IRequestValidationService
{
    ValidationResult IsBodyValid(BodyObject body);
}