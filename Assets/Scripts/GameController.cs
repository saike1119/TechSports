using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Text inputFieldPlayerScore1Text;
    public Text inputFieldPlayerScore2Text;
    public Text inputFieldPlayerName1Text;
    public Text inputFieldPlayername2Text;

    private int PlayerScore1;
    private int PlayerScore2;

    public GameObject player1WinText;
    public GameObject player2WinText;

    public AudioClip sound;
    AudioSource audioSource;

    SaveScript saveScript = new SaveScript();

    private void Start()
    {
        inputFieldPlayerScore1Text.text = "0";
        inputFieldPlayerScore2Text.text = "0";
        inputFieldPlayerName1Text.text = "Player1";
        inputFieldPlayername2Text.text = "Player2";

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
        if (saveScript.GetInputFieldPlayerScore1() >= 5){
            player1WinText.SetActive(true);
            Debug.Log("Player1 is 5points Win"+saveScript.GetInputFieldPlayerName1());
        }

        if (saveScript.GetInputFieldPlayerScore2() >= 5)
        {
            player2WinText.SetActive(true);
            Debug.Log("Player2 is 5points Win" + saveScript.GetInputFieldPlayerName2());
        }

        //クリックしたら音を鳴らす処理
        if (Input.GetMouseButtonUp(0))
        {
            audioSource.PlayOneShot(sound);
        }
    }
}
