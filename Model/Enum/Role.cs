namespace API.Model.Enum
{
    public enum Role
    {
        Administrator = 1,//Has access to delete,modify and create things such as members (even mods), blogs, comments, items etc.
        Moderator = 2,
        Member = 3,
        Visitor = 4
    }
}
