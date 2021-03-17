using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAQ: MonoBehaviour
{
	public string f = "https://vk.com/koviello";
	public string f2 = "https://vk.com/defoldsen";
	
	void Start()
	{
		Application.OpenURL(f);
		Application.OpenURL(f2);
	}
}
