﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame(){
       SceneManager.LoadScene(2);
    //    SceneManager.LoadScene(5);

   }

   public void QuitGame(){
       print("quit");
       Application.Quit();
   }

   public void Instructions(){
       
       SceneManager.LoadScene(1);
   }
}
