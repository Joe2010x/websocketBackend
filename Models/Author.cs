using System;

namespace WSserver.Models;

public class Author
{
    public Guid Id {get;set;}
    public string Name {get; set;}
    public string? Avatar {get; set;}

    public Author (string name, string? avatar) {
        Id = new Guid();
        Name = name;
        Avatar = avatar;
    }
    
}