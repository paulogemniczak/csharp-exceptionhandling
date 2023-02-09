namespace csharp_exceptionhandling
{
	internal class YouTubeException : Exception
	{
		public YouTubeException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}