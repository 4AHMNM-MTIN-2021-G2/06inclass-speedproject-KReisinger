using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Data data;
    public Text name;
    public Text timer;
    public Text randomVal;

    void Start()
    {
        name.text = data.name;
    }

    void Update()
    {
        timer.text = Time.timeSinceLevelLoad.ToString("f2");
    }

    public void GenerateRandom() 
    {
        float rndVal = Random.Range(1.0f,10.0f);
        randomVal.text = rndVal.ToString();
        data.randomVal = rndVal;
    }

    public void NextScene() 
    {
        if(data.randomVal != 0) 
        {
            data.time = Time.timeSinceLevelLoad;
            SceneManager.LoadScene("End");
        }
    }
}
