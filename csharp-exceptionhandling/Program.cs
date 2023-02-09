using csharp_exceptionhandling;

var calculator = new Calculator();
// var result = calculator.Divide(5, 0); // System.DivideByZeroException: Attempted to divide by zero.

try
{
	var result = calculator.Divide(5, 0);
}
catch
{
	Console.WriteLine("Sorry, an unexpected error occurred.");
}

try
{
	var result = calculator.Divide(5, 0);
}
catch(DivideByZeroException ex)
{
	Console.WriteLine("You cannot divide by 0.");
}
catch(ArithmeticException ex)
{
	Console.WriteLine(ex.Message);
}
catch
{
	Console.WriteLine("Sorry, an unexpected error occurred.");
}

StreamReader? streamReader = null;
try
{
	streamReader = new StreamReader(@"c:\myFile.zip");
	var content = streamReader.ReadToEnd();
}
catch
{
	Console.WriteLine("Sorry, an unexpected error occurred.");
}
finally
{
	streamReader?.Dispose();
}

// always use 'using' instead 'finally'
try
{
	using (StreamReader sReader = new StreamReader(@"c:\myFile.zip"))
	{
		var content = sReader.ReadToEnd();
	}
}
catch
{
	Console.WriteLine("Sorry, an unexpected error occurred.");
}

try
{
	var api = new YouTubeApi();
	var videos = api.GetVideos("paulo");
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
