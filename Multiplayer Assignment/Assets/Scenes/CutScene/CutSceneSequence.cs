using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneSequence : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;

    void Start()
    {
        StartCoroutine(TheSequence());
        
    }

    IEnumerator TheSequence(){
        yield return new WaitForSeconds(4);
        Camera2.SetActive(true);
        Camera1.SetActive(false);
        yield return new WaitForSeconds(6);
        Camera3.SetActive(true);
        Camera2.SetActive(false);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
        // SceneManager.LoadScene(5);
        // Camera3.SetActive(false);
    }
}
