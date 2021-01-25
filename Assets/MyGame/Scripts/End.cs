using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public Data Data;
    public Text Name;
    public Text RandValueTxt;
    public Text Time;
    public Text Message;
    void Start()
    {
        Name.text = Data.name;
        RandValueTxt.text = Data.randomVal.ToString("f2");
        Time.text = Data.time.ToString("f2");

        float TimeTmp = Data.time;
        if(TimeTmp < 3) {
            Message.text = "Du bist Super!";
        } else if(TimeTmp < 6) {
            Message.text = "Du bist fast zu langsam";
        } else {
            Message.text = "Du bist zu langsam";
        }
        
    }

    public void ResetScene() {
        Data.name = "";
        Data.randomVal = 0;
        Data.time = 0;
        Debug.Log("test");
        SceneManager.LoadScene("Intro");
    }

}
