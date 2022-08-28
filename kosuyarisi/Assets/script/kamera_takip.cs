using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_takip : MonoBehaviour
{
    Transform Boy_pozisyon;
    Vector3 mesafe;

    private void Start()
    {
        Boy_pozisyon = GameObject.Find("Boy").transform; 
    }
    void LateUpdate()
    {
        mesafe = new Vector3(Boy_pozisyon.position.x, transform.position.y, Boy_pozisyon.position.z - 5f);

        transform.position = Vector3.Lerp(transform.position, mesafe, Time.deltaTime);
    }
        
    
    
}
