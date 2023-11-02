
namespace P05Shop.API.Exceptions
{
    public class MovieDoesNotExistException : Exception {
        public MovieDoesNotExistException() {
        }

        public MovieDoesNotExistException(string message) : base(message) {
        }

        public MovieDoesNotExistException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}
