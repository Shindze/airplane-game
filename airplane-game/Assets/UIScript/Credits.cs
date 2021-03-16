using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
	public string d = "https://vk.com/defoldsen";
	
	void Start()
	{
		Application.OpenURL(d);
	}
}
