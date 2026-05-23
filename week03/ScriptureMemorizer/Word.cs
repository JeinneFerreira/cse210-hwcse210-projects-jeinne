public class Word
{
    // =====================================================
    // Private attributes
    // =====================================================

    private string _text;

    private bool _isHidden;

    // =====================================================
    // Constructor
    // =====================================================

    public Word(string text)
    {
        _text = text;

        _isHidden = false;
    }

    // =====================================================
    // Function: Hide word
    // =====================================================

    public void Hide()
    {
        _isHidden = true;
    }

    // =====================================================
    // Function: Check if hidden
    // =====================================================

    public bool IsHidden()
    {
        return _isHidden;
    }

    // =====================================================
    // Function: Display word
    // =====================================================

    public string GetDisplayText()
    {
        // ----------- Hidden word -----------

        if (_isHidden)
        {
            return
                new string('_', _text.Length);
        }

        // ----------- Visible word -----------

        else
        {
            return _text;
        }
    }
}