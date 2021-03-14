using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAQ : MonoBehaviour
{
	public string f = "https://vk.com/koviello";
	
	void Start()
	{
		Application.OpenURL(f);
	}
}
