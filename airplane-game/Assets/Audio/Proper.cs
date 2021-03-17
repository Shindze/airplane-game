using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proper : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
}
