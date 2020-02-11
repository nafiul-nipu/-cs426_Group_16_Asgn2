using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deduction : MonoBehaviour
{
   public Score scoreManager;
   private void OnCollisionEnter(Collision collision)
   {
      scoreManager.DeductPoint();
      Destroy(gameObject); // Uncomment if want to destory trap!
   }
}
