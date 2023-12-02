
namespace P05Shop.API.Exceptions
{
    public class MovieAlreadyExistsException : Exception {
        public MovieAlreadyExistsException() {
        }

        public MovieAlreadyExistsException(string message) : base(message) {
        }

        public MovieAlreadyExistsException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}
