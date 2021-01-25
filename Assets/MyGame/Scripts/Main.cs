using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    public Data Data;
    public Text Name;
    public Text Timer;

    public Text RandomVal;


    void Start()
    {
        Name.text = Data.name;
    }

    // Update is called once per frame
    void Update()
    {
        Timer.text = Time.timeSinceLevelLoad.ToString("f2");
    }

    public void GenerateRandom() {
        float rndVal = Random.Range(1.0f,10.0f);
        RandomVal.text = rndVal.ToString();
        Data.randomVal = rndVal;
    }

    public void NextScene() {
        if(Data.randomVal != 0) {
            Data.time = Time.timeSinceLevelLoad;
            SceneManager.LoadScene("End");
        }
    }
}
