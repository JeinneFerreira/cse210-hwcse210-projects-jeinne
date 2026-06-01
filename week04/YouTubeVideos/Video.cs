using System.Collections.Generic;

public class Video
{
// =====================================================
// ------------- Private attributes --------------------
// =====================================================

    private string _title;

    private string _author;

    private int _length;

    private List<Comment> _comments;

// =====================================================
// ------------------- Constructor ---------------------
// =====================================================

    public Video(string title, string author, int length)
    {
        _title = title;

        _author = author;

        _length = length;

        _comments = new List<Comment>();
    }


// =====================================================
// -------------- Function: Add comment ----------------
// =====================================================

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

// =====================================================
// ------- Function: Return number of comments ---------
// =====================================================

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

// =====================================================
// --------------------- Getters -----------------------
// =====================================================

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}