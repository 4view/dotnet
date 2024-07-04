class RemWhiteSpace
{
    public string word { get; set; }
    public RemWhiteSpace(string word)
    {
        this.word = word;
    }

    public void RemoveWhiteSpace()
    {
        string NewString = String.Concat(word.Where( c => !Char.IsWhiteSpace(c)));
        Console.WriteLine(NewString);
    }

    public void Replace()
    {
        Console.WriteLine(word);

        string result = word.Replace(" ", "");
        Console.WriteLine(result);
    }
}