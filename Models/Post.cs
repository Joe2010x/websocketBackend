using System;

namespace WSserver.Models;

public class Post {
    public Guid Id {get; set;}
    public Author Author {get; set;}

    public DateTime Created {get; set;}
    public DateTime? Updated {get; set;}

    public string? Title {get; set;}
    public string Content {get;set;}

    public Post (string name, string? avatar,string? title, string content) {
        Id = new Guid();
        Author = new Author(name, avatar);
        Created = DateTime.Now;
        Updated = null;
        Title = title;
        Content = content;
    }
}