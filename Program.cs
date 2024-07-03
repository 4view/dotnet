using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;


class Program
{
    static void Main(string[] args)
    {       
        var value = new Branching("1234231", " ", "", null);

        value.BranchingIsNullOrWhiteSpace();

    }     
    
}

