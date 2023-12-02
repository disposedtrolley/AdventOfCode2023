<Query Kind="Statements" />

using System.IO;

List<string> ReadInput(string filename)
{
	List<string> lines = new List<string>();
	
	string fullPath = Path.Join(Path.GetDirectoryName(Util.CurrentQueryPath), filename);
	StreamReader sr = new StreamReader(fullPath);
	
	string line = sr.ReadLine();
	while (line != null)
	{
		if (line != "\n") lines.Add(line);
		line = sr.ReadLine();
	}
	sr.Close();
	
	return lines;
}