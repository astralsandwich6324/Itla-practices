using System.Text;

byte[] data = Encoding.UTF8.GetBytes("This is my text");

var text = Encoding.UTF8.GetString(data);

Console.WriteLine(text);