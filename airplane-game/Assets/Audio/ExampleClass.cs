using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public AudioSource audioSource;
	
	public bool Peo = false;
	
	public bool Pe = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Pe == false && Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
            Pe = true;
        }

        if (Peo == false && Input.GetKeyDown(KeyCode.Space)){
            audioSource.volume = 0.02f;
            Peo = true;


        }
        else if (Peo == true && Input.GetKeyDown(KeyCode.Space)){
            audioSource.volume = 0.0001f;
            Peo = false;

        }
    }
}