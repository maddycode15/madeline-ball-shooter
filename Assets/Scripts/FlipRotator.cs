using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipRotator : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(-30, 00, 00) * Time.deltaTime * 2);
    }
}
