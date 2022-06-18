using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;


public class GetRank : MonoBehaviour
{
    public Text easyText;
    public Text normalText;
    public Text hardText;

    [Serializable]
    public class LevelResponse
    {
        public string name;
        public int score;
    }

    [Serializable]
    public class RankResponse
    {
        public bool signal;
        public List<LevelResponse> easy = new List<LevelResponse>();
        public List<LevelResponse> normal = new List<LevelResponse>();
        public List<LevelResponse> hard = new List<LevelResponse>();
    }

    public void ClickRankButton()
    {
        StartCoroutine(GetRankBtn());
    }

    IEnumerator GetRankBtn()
    {
        string easy;
        string normal;
        string hard;
        
        UnityWebRequest www = UnityWebRequest.Get("http://150.230.248.249:40000/api/rank/top");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
            Debug.Log(www.error);
        else
            Debug.Log(www.downloadHandler.text);

        RankResponse data = JsonUtility.FromJson<RankResponse>(www.downloadHandler.text);

        for (int i = 0; i < 5; i++)
        {
            //Debug.Log("EASY : " + data.easy[i].name + " " + data.easy[i].score);
            easy = string.Format("{0} {1:D3}\n", data.easy[i].name, data.easy[i].score);
            Debug.Log(easy);
            easyText.text += easy;
        }

        for (int i = 0; i < 5; i++)
        {
            //Debug.Log("NORMAL : " + data.normal[i].name + " " + data.normal[i].score);
            normal = string.Format("{0} {1:D3}\n", data.normal[i].name, data.normal[i].score);
            Debug.Log(normal);
            normalText.text += normal;
        }

        for (int i = 0; i < 5; i++)
        {
            //Debug.Log("HARD : " + data.hard[i].name + " " + data.hard[i].score);
            hard = string.Format("{0} {1:D3}\n", data.hard[i].name, data.hard[i].score);
            Debug.Log(hard);
            hardText.text += hard;
        }
    }
}
