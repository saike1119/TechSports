using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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


    public void SaveText()
    {
        inputFieldPlayerName1str = inputFieldPlayerName1.text;
        inputFieldPlayerName1.text = inputFieldPlayerName1str;

        inputFieldPlayerName2str = inputFieldPlayerName2.text;
        inputFieldPlayerName2.text = inputFieldPlayerName2str;

        inputFieldPlayerScore1str = inputFieldPlayerScore1.text;
        inputFieldPlayerScore1.text = inputFieldPlayerScore1str;

        inputFieldPlayerScore2str = inputFieldPlayerScore2.text;
        inputFieldPlayerScore2.text = inputFieldPlayerScore2str;
        //inputField.text = "";
    }
}