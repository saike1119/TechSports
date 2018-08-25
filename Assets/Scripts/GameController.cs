using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour {

    SaveScript saveScript = new SaveScript();

    public Text inputFieldPlayerName1Text;
    public Text inputFieldPlayerName2Text;
    public Text inputFieldPlayerScore1Text;
    public Text inputFieldPlayerScore2Text;

    public string str1;
    public string str2;

    public int PlayerScore1;
    public int PlayerScore2;

    private void Awake()
    {
        inputFieldPlayerScore1Text.text = "0";
        inputFieldPlayerScore2Text.text = "0";
    }

    // Use this for initialization
    void Start () {
        str1 = inputFieldPlayerName1Text.text;
        PlayerScore1 = int.Parse(str1);
    }

    // Update is called once per frame
    void Update () {
        Debug.Log(PlayerScore1);
        PlayerScore1 = int.Parse(inputFieldPlayerScore1Text.text);
        if (PlayerScore1 > 2){
            Debug.Log("1 is 2points");
        }
        //Debug.Log(inputFieldPlayerScore1Text.text);
    }
}
