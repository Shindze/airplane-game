using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFx : MonoBehaviour
{
	public AudioSource myFx;
	public AudioClip hfx;
	public AudioClip cfx;
	
	public void Hsound()
	{
		myFx.PlayOneShot(hfx);
	}
	
	public void Csound()
	{
		myFx.PlayOneShot(cfx);
	}
}
