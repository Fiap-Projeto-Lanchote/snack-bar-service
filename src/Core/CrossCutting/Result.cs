using FluentValidation.Results;

namespace CrossCutting
{
    public class Result
    {
        private Result(bool succeeded, object? data, IEnumerable<ValidationFailure>? errors = null)
        {
            Succeeded = succeeded;
            Data = data;
            Errors = errors;
        }

        public bool Succeeded { get; }
        public object? Data { get; }
        public IEnumerable<ValidationFailure>? Errors { get; }

        public static Result Success()
            => new(true, default);

        public static Result Success(object data)
            => new(true, data);

        public static Result Failure(ValidationFailure error)
            => new(false, default, [error]);

        public static Result Failure(IEnumerable<ValidationFailure> errors)
            => new(false, default, errors);

        public static Result Failure(string propertyName, string errorMessage)
            => new(false, default, [new ValidationFailure(propertyName, errorMessage)]);

        public static Result Failure(ValidationResult notifications)
            => new(false, default, notifications.Errors);
    }

    public class Result<T>
    {
        private Result(bool succeeded, T? data, IEnumerable<ValidationFailure>? errors = null)
        {
            Succeeded = succeeded;
            Data = data;
            Errors = errors;
        }

        public bool Succeeded { get; }
        public T? Data { get; }
        public IEnumerable<ValidationFailure>? Errors { get; }

        public static Result<T> Success()
            => new(true, default);

        public static Result<T> Success(T data)
            => new(true, data);

        public static Result<T> Failure(ValidationFailure error)
            => new(false, default, [error]);

        public static Result<T> Failure(string propertyName, string errorMessage)
            => new(false, default, [new ValidationFailure(propertyName, errorMessage)]);

        public static Result<T> Failure(IEnumerable<ValidationFailure> errors)
            => new(false, default, errors);

        public static Result<T> Failure(ValidationResult notifications)
            => new(false, default, notifications.Errors);
    }
}
