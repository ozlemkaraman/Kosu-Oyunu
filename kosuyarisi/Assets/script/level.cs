using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider temasEdilen)

    {
        if (temasEdilen.tag == "level")
        {
           SceneManager.LoadScene(1);
        }
   }

   
}
