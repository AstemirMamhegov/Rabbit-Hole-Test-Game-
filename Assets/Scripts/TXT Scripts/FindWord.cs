using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine;

public class FindWord : MonoBehaviour
{
    [SerializeField]
    private string _allWords;

    [SerializeField]
    private TMP_Text _showWord;

    [SerializeField]
    private TMP_Text _showText;

    private int _countOfSymbols;

    private string _needWord;

    [SerializeField]
    private List<int> _wordSeparators = new List<int>();

    [SerializeField]
    private List<string> _words = new List<string>();

    private int index;

    [SerializeField]
    private List<string> _dropedWords = new List<string>();

    public void ClickSetLevel(int value)
    {
        _countOfSymbols = value;
    }

    public void StartGame()
    {
        GetChapter(_allWords);
        ShowReadyChapter();
        SetWordsFromText(_allWords);
    }

    private void SetWordsFromText(string Text) 
    {
        _words.Clear();
        _wordSeparators.Clear();
        string word = "";
        for (int i = 0; i < Text.Length; i++)
        {
            if (Text[i] == ' ')
            {
                _wordSeparators.Add(i);
            }
        }

        int nextindex = 0;

        for (int j = 0; j < _wordSeparators.Count; j++)
        {
            if (nextindex < _wordSeparators.Count -1)
            {
                nextindex++;
            }
            for (int i = _wordSeparators[j]; i < _wordSeparators[nextindex]; i++)
            {
                word += Text[i].ToString();
            }

            _words.Add(word);
            word = "";
        }

        StartCoroutine(findingNewWord());
        
    }

    private IEnumerator findingNewWord() 
    {
        while (_needWord != "")
        {
            string findingWord = _dropedWords.Find(x => x.Contains(_needWord));
            if (findingWord != null)
            {
                _needWord = _words.Find(x => x.Length == _countOfSymbols && x != findingWord);
                _dropedWords.Add(_needWord);
            }
            else
            {
                _needWord = _words.Find(x => x.Length == _countOfSymbols && x != findingWord);
                _dropedWords.Add(_needWord);
            }
            _showWord.text = _needWord;
            yield return null;
        }
        StopAllCoroutines();
    }

    private string GetChapter(string chaptere)
    {
        bool beginIsReady = false;
        string chapter = "";
        int beginIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < chaptere.Length; i++)
        {
            if (chaptere[i] == ' ' && !beginIsReady)
            {
                beginIndex = i;
                /*_words.Add(chaptere[i].ToString());*/
                beginIsReady = true;
            }
            else if (chaptere[i] == '.')
            {
                endIndex = i;
                break;
            }
            /*_words.Add(chaptere[i].ToString());*/
            chapter += chaptere[i].ToString();
        }
        return chapter;
    }

    private void ShowReadyChapter()
    {
        _showText.text = "";
        _showText.text += GetChapter(_allWords);
    }

    private string GetRandomWord()
    {
        string readyWord = "";
        int currentIndex = 0;
        int _indexOfBeginFindWord = _words.FindIndex(word => word == " ");
        for (int i = _indexOfBeginFindWord + 1; i < _words.Count; i++)
        {
            readyWord += _words[i].ToString();
            currentIndex++;
            if (_words[i] == " " && currentIndex == _countOfSymbols)
            {
                break;
            }
        }
        return readyWord;
    }

    //private IEnumerator FindRandomWord()
    //{
    //    string readyWord = "";
    //    int currentIndex = 0;
    //    bool findding = true;
    //    int _indexOfBeginFindWord = 0;
    //    for (int i = 0; i < _words.Count; i++)
    //    {
    //        int index = Random.Range(0, _words.Count);
    //        string oneOf = _words[index];
    //        if (oneOf == " ")
    //        {
    //            _indexOfBeginFindWord = index;
    //        }
    //    }
    //    while (_needWord == "")
    //    {
    //        for (int i = _indexOfBeginFindWord + 1; i < _words.Count; i++)
    //        {
    //            readyWord += _words[i].ToString();
    //            currentIndex++;
    //            if (_words[i] == " " && currentIndex == _countOfSymbols)
    //            {
    //                _needWord = readyWord;
    //                _showWord.text = _needWord;
    //                findding = false;
    //                StopAllCoroutines();
    //                break;
    //            }
    //            else
    //            {
    //                _needWord = "";
    //            }
    //        }
    //    }
    //    return null;
    //}
}
