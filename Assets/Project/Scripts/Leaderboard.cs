using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo
{
    public string name;
    public float score;
    public PlayerInfo(string name, float score)
    {
        this.name = name;
        this.score = score;
    }
}

public class Leaderboard : MonoBehaviour
{
    public InputField display;
    public List<PlayerInfo> collectedStats = new List<PlayerInfo>();
    public string names;
    public float scores;
    private bool newSub;

    // Start is called before the first frame update
    void Start()
    {
        names = PlayerPrefs.GetString("Name", "");
        scores = PlayerPrefs.GetFloat("Score");
        Debug.Log(names);
        Debug.Log(scores);
        LoadLeaderBoard();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < collectedStats.Count; i++)
        {
            if (names == collectedStats[i].name)
            {
                newSub = true;
                break;

            }
            else
            {
                newSub = false;
            }
        }

        if (!newSub)
        {
            PlayerInfo stats = new PlayerInfo(names, scores);
            collectedStats.Add(stats);
            SortStats();
        }

    }

    void SortStats()
    {
        for (int i = collectedStats.Count - 1; i > 0; i--)
        {
            if (collectedStats[i].score > collectedStats[i - 1].score)
            {
                PlayerInfo tempInfo = collectedStats[i - 1];

                collectedStats[i - 1] = collectedStats[i];
                collectedStats[i] = tempInfo;
            }
        }
        UpdatePlayerPrefsString();
    }

    void UpdatePlayerPrefsString()
    {
        string stats = "";
        Debug.Log(collectedStats.Count);

        for (int i = 0; i < collectedStats.Count; i++)
        {
            Debug.Log(collectedStats[i]);
            stats += collectedStats[i].name + ",";
            stats += collectedStats[i].score + ",";

        }

        PlayerPrefs.SetString("LeaderBoards", stats);

        UpdateLeaderBoardVisual();
    }

    void UpdateLeaderBoardVisual()
    {
        display.text = "";
        Debug.Log("yup");

        for (int i = 0; i <= collectedStats.Count - 1; i++)
        {
            display.text += collectedStats[i].name + "                            " + collectedStats[i].score.ToString() + "\n";
        }

    }

    void LoadLeaderBoard()
    {
        Debug.Log("load");
        string stats = PlayerPrefs.GetString("LeaderBoards", "");

        string[] stats2 = stats.Split(',');

        for (int i = 0; i < stats2.Length - 2; i += 2)
        {
            PlayerInfo loadedInfo = new PlayerInfo(stats2[i], float.Parse(stats2[i + 1]));
            collectedStats.Add(loadedInfo);
            UpdateLeaderBoardVisual();
        }
    }
}
