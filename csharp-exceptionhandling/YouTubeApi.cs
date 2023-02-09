namespace csharp_exceptionhandling
{
	internal class YouTubeApi
	{
		public List<Video> GetVideos(string user)
		{
			try
			{
				// Access YouTube web service
				// Read the data
				// Create a list of Video objects
				throw new Exception("Ooops some low lever YouTube error.");
			}
			catch (Exception ex)
			{
				// Log

				throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
			}

			return new List<Video>();
		}
	}
}