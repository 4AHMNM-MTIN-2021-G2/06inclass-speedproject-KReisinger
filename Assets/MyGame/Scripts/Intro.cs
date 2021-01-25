using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject InputField;
    public Data Data;
    public Color error;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene() {
        if(InputField.GetComponent<InputField>().text == "") {
             InputField.GetComponent<Image>().color = error;
        } else {
            Data.name = InputField.GetComponent<InputField>().text;
            SceneManager.LoadScene("Main");

        }
    }
}
