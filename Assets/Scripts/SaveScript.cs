using UnityEngine;
using UnityEngine.UI;
using System.Collections;
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

    private int PlayerScore1;
    private int PlayerScore2;

    public void Start()
    {
        PlayerScore1 = 0;
        PlayerScore2 = 0;
    }

    public void SaveText()
    {
        inputFieldPlayerName1str = inputFieldPlayerName1.text;
        inputFieldPlayerName1Text.text = inputFieldPlayerName1str;

        inputFieldPlayerName2str = inputFieldPlayerName2.text;
        inputFieldPlayerName2Text.text = inputFieldPlayerName2str;

        inputFieldPlayerScore1str = inputFieldPlayerScore1.text;
        inputFieldPlayerScore1Text.text = inputFieldPlayerScore1str;
        SetInputFieldPlayerScore1(inputFieldPlayerScore1Text.text);

        inputFieldPlayerScore2str = inputFieldPlayerScore2.text;
        inputFieldPlayerScore2Text.text = inputFieldPlayerScore2str;
        SetInputFieldPlayerScore2(inputFieldPlayerScore2Text.text);
    }

    public int GetInputFieldPlayerScore1(){
        return this.PlayerScore1;
    }

    public int SetInputFieldPlayerScore1(String x)
    {
        this.PlayerScore1 = int.Parse(inputFieldPlayerScore1str);
        return this.PlayerScore1;
    }

    public int GetInputFieldPlayerScore2()
    {
        return this.PlayerScore2;
    }

    public int SetInputFieldPlayerScore2(String x)
    {
        this.PlayerScore2 = int.Parse(inputFieldPlayerScore2str);
        return this.PlayerScore2;
    }
}