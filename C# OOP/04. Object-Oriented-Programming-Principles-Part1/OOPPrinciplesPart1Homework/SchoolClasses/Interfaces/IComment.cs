
using System.Collections.Generic;
namespace SchoolClasses.Interfaces
{
    public interface IComment
    {
        List<string> Comment { get; }

        void AddComment(string addText);

        void DeleteComents();
    }
}
