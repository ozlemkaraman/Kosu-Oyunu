using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kosuengel6 : MonoBehaviour
{
    public Animator animasyon;
    public Transform ilk;
    public GameObject bittipanel;

    void Start()
    {
        animasyon = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision temasEdilen)
    {
        if (temasEdilen.gameObject.tag == "engel")
        {
            //transform.position = ilk.position;
            transform.position = new Vector3(4, 0, -16);
            bittipanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
