using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomengel : MonoBehaviour
{
    public Transform[] objeler;
    public Transform[] nokta;
         
    void Start()
    {
        for(int i = 0; i<20; i++)
        {
            int sayi = Random.Range(0, objeler.Length);
            Instantiate(objeler[Random.Range(0, objeler.Length)], nokta[Random.Range(0,nokta.Length)].position,Quaternion.identity);
                
        }
            
    }

   
    void Update()
    {
        
    }
}
