using UnityEngine;
using UnityEngine.UI;
using System;

public class SaveScript : MonoBehaviour
{

    string inputFieldPlayerName1str;
    string inputFieldPlayerName2str;
    string inputFieldPlayerScore1str;
    string inputFieldPlayerScore2str;

    public InputField inputFieldPlayerName1;
    public InputField inputFieldPlayerName2;
    public InputField inputFieldPlayerScore1;
    public InputField inputFieldPlayerScore2;

    public Text inputFieldPlayerName1Text;
    public Text inputFieldPlayerName2Text;
    public Text inputFieldPlayerScore1Text;
    public Text inputFieldPlayerScore2Text;

    static int PlayerScore1;
    static int PlayerScore2;
    static String PlayerName1;
    static String PlayerName2;

    public void Start()
    {
        PlayerScore1 = 0;
        PlayerScore2 = 0;
    }

    public void SaveText()
    {
        inputFieldPlayerName1str = inputFieldPlayerName1.text;
        inputFieldPlayerName1Text.text = inputFieldPlayerName1str;
        SetInputFieldPlayerName1(inputFieldPlayerScore1Text.text);

        inputFieldPlayerName2str = inputFieldPlayerName2.text;
        inputFieldPlayerName2Text.text = inputFieldPlayerName2str;
        SetInputFieldPlayerName2(inputFieldPlayerScore1Text.text);

        inputFieldPlayerScore1str = inputFieldPlayerScore1.text;
        inputFieldPlayerScore1Text.text = inputFieldPlayerScore1str;
        SetInputFieldPlayerScore1(inputFieldPlayerScore1Text.text);

        inputFieldPlayerScore2str = inputFieldPlayerScore2.text;
        inputFieldPlayerScore2Text.text = inputFieldPlayerScore2str;
        SetInputFieldPlayerScore2(inputFieldPlayerScore2Text.text);
    }

    public int GetInputFieldPlayerScore1(){
        return PlayerScore1;
    }

    public int SetInputFieldPlayerScore1(String x)
    {
        PlayerScore1 = int.Parse(x);
        return PlayerScore1;
    }

    public int GetInputFieldPlayerScore2()
    {
        return PlayerScore2;
    }

    public int SetInputFieldPlayerScore2(String x)
    {
        PlayerScore2 = int.Parse(x);
        return PlayerScore2;
    }

    public String GetInputFieldPlayerName1()
    {
        return PlayerName1;
    }

    public String SetInputFieldPlayerName1(String x)
    {
        PlayerName1 = x;
        return PlayerName1;
    }

    public String GetInputFieldPlayerName2()
    {
        return PlayerName2;
    }

    public String SetInputFieldPlayerName2(String x)
    {
        PlayerName2 = x;
        return PlayerName2;
    }
}