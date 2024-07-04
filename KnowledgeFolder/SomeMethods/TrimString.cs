class TrimString
{
    string words = "";
    public TrimString(string words)
    {
        this.words = words;
    }

    public void MyTrim()
    {
        string NewString = words.Trim();
        Console.WriteLine(NewString);
    }
}