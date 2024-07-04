class BranchingNOWS
{
    string[] values = {};
    public BranchingNOWS(params string[] values)
    {
        this.values = values;
    }

    public void BranchingIsNullOrWhiteSpace()
    {       
        foreach(string value in values)
        {
            Console.WriteLine(String.IsNullOrWhiteSpace(value));
        } 
    }
    
}



 