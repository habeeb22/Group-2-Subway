using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Exite : MonoBehaviour
{
    //    public Text scoreName;
    //    public InputField enterName;

    public void exxite()
    {
        
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void restss()
    {
        PlayerPrefs.DeleteAll();
    }

    //public void Update()
    //{
    //    scoreName.text = enterName.text;
    //}
}

