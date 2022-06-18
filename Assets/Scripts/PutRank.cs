using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PutRank : MonoBehaviour
{
    public string url = "http://150.230.248.249:40000/api/rank/recode";
    public void ClickPutButton(string putLevel, string putName, int putScore)
    {
        StartCoroutine(PutRankBtn(putLevel, putName, putScore));
    }

    IEnumerator PutRankBtn(string _level, string _name, int _score)
    {
        if (string.Equals(_level, "Easy"))
        {
            _level = "EASY";
        }
        else if (string.Equals(_level, "Normal"))
        {
            _level = "NORMAL";
        }
        else if (string.Equals(_level, "Hard"))
        {
            _level = "HARD";
        }

        url += string.Format("?level={0}&name={1}&score={2}", _level, _name, _score);

        using (UnityWebRequest www = UnityWebRequest.Put(url, "dummy"))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError)
            {
                Debug.Log("error");
            }
            else
            {
                Debug.Log("Complete");
            }
        }
    }
}
