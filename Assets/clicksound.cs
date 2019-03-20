using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class clicksound : MonoBehaviour
{

    public AudioClip sound;
    private Button button { get { return GetComponent<Button>(); } }
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        button.onClick.AddListener(() => playsound());
    }
  
    void playsound()
    {
        source.PlayOneShot(sound);


    }



    // Update is called once per frame
    void Update()
    {
        
    }


}
