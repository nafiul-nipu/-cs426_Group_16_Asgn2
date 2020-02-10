using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSongs : MonoBehaviour
{

    public AudioSource gameMusic;
    public AudioClip [] tracks;
    int count; 
    // Start is called before the first frame update
    void Start()
    {
        count = 0;   
        print(tracks.Length);     
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)){
            if (count < tracks.Length){
                ChangeGameMusic(tracks[count]); 
                count++ ;
            }else if (count == tracks.Length){
                ChangeGameMusic(tracks[0]);
                count = 0 ;
            }
                       
        }
        
    }

    public void ChangeGameMusic(AudioClip music){
        gameMusic.Stop();
        gameMusic.clip = music;
        gameMusic.Play();

    }
}
