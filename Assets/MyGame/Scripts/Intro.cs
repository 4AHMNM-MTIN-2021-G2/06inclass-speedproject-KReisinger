using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{

    public GameObject inputField;
    public Data data;
    public Color error;

    public void NextScene() 
    {
        if(inputField.GetComponent<InputField>().text == "") 
        {
             inputField.GetComponent<Image>().color = error;
        } 
        else 
        {
            data.name = inputField.GetComponent<InputField>().text;
            SceneManager.LoadScene("Main");

        }
    }
}
