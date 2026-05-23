using System;
using System.Collections.Generic;

public class Scripture
{
    // =====================================================
    // Private attributes
    // =====================================================

    private Reference _reference;

    private List<Word> _words;

    // =====================================================
    // Constructor
    // =====================================================

    public Scripture(
        Reference reference,
        string text)
    {
        _reference = reference;

        _words = new List<Word>();

        // ----------- Split text into words -----------

        string[] words = text.Split(" ");

        // ----------- Create Word objects -----------

        foreach (string word in words)
        {
            Word newWord = new Word(word);

            _words.Add(newWord);
        }
    }

    // =====================================================
    // Function: Hide random words
    // =====================================================

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index =
                random.Next(_words.Count);

            // ----------- Hide only visible words -----------

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
        }
    }

    // =====================================================
    // Function: Get scripture text
    // =====================================================

    public string GetDisplayText()
    {
        string result =
            _reference.GetDisplayText();

        result += " - ";

        foreach (Word word in _words)
        {
            result +=
                word.GetDisplayText() + " ";
        }

        return result;
    }

    // =====================================================
    // Function: Check if all hidden
    // =====================================================

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}