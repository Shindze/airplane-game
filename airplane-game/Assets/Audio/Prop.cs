using UnityEngine;
using System.Collections;

public class Sounds : MonoBehaviour 
{
   public AudioClip din;
   AudioSource audio;

   void Start()
   {
      audio = GetComponent<AudioSource>();
   }

   void Update()
   {
        if (Input.GetKeyDown(KeyCode.Space)) //здесь задаете  любую кнопку
            audio.PlayOneShot(din);
   }
}