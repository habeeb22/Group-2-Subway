using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manegarsound : MonoBehaviour
{
 
    public Sprite audioOffSprite;
    public Sprite audioOnfSprite;
    public Image Soundimage;
  
    public AudioSource musicAudioSource;
    public AudioSource soundEffectsAudioSource;
    public static Manegarsound Instance;
    // Start is called before the first frame update
    void Start()
    {
        //if (musicAudioSource != null )
        //{
            
        //   // musicAudioSource.Stop();
        //}
        if (Instance == null)
            Instance = this;
        else
        {
            musicAudioSource.Stop();
            //PlayerPrefs.SetInt("Music", 0);
            Destroy(this);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()

    {
       
        
    }




    public void ToggleMuteMusic()
    {
        if (PlayerPrefs.GetInt("Music", 0) == 0)
        {
            musicAudioSource.volume = 1;
            Soundimage.sprite = audioOnfSprite;
            PlayerPrefs.SetInt("Music", 1);
        }
        else 
        {
            PlayerPrefs.SetInt("Music", 0);
            musicAudioSource.volume = 0;
            Soundimage.sprite = audioOffSprite;
           
        }
    }

    public void PlaySoundEffect()
    {
        soundEffectsAudioSource.Play();
    }

    public void SoundCont()
    {

        if  (PlayerPrefs.GetInt("Music", 0) == 0)
        {

            soundEffectsAudioSource.volume = 0;

        }
        else 
        {
            soundEffectsAudioSource.volume = 1;

        }
    }
   
}
