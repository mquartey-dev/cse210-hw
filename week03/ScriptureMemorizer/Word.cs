using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string blanks = "";
            for (int i = 0; i < _text.Length; i++)
            {
                blanks += "_";
            }
            return blanks;
        }
        else
        {
            return _text;
        }
    }
}
