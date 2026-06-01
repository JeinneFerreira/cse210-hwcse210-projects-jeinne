public class Comment
{
// =====================================================
// ------------ Private attributes----------------------
// =====================================================


    private string _personName;

    private string _commentText;

// =====================================================
// ---------------- Constructor ------------------------
// =====================================================

    public Comment(string personName, string commentText)
    {
        _personName = personName;

        _commentText = commentText;
    }

// =====================================================
// ------------ Function: Get person name --------------
// =====================================================

    public string GetPersonName()
    {
        return _personName;
    }

// =====================================================
// ---------- Function: Get comment text ---------------
// =====================================================

    public string GetCommentText()
    {
        return _commentText;
    }
}