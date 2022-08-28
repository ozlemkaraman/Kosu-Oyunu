using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class oyuncu : MonoBehaviour
{

    public Animator animasyon;
    public Rigidbody rigi;
    public oyunkontrol oyunK;

    public GameObject bittipanel;
    public GameObject baslapanel;
    public GameObject sonpanel;
   
    

    bool sag = true;

    void Start()
    {
        Time.timeScale = 0;

    }


     void Update()
   {
    hareket();

    if (oyunK.oyunAktif)
      {

     if (Input.GetKey("l"))
     animasyon.SetBool("zipla", true);
      else
    animasyon.SetBool("zipla", false);

     if (Input.GetKey("w"))
      animasyon.SetBool("kosu", true);
       else
     animasyon.SetBool("kosu", false);
    }


    }

    void hareket()
    {
        if (oyunK.oyunAktif)
        {



            


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                sag = true;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                sag = false;
            }

            if (sag)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(1.1f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(-0.7f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);

             
            }

            void ziplama_iptal()
            {
                animasyon.SetBool("zipla", false);
            }
        }
    }
    void OnCollasionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals  ("engel"))
        {
            oyunK.oyunAktif = false;
        }

            
    }

    void OnCollisionEnter(Collision temasEdilen)

    {
        if (temasEdilen.gameObject.tag == "level")
        {
            Application.LoadLevel(1);
        }

        else if (temasEdilen.gameObject.tag == "engel")
        {
            
            bittipanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (temasEdilen.gameObject.tag == "son")
        {
            sonpanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void yeniden()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void basla()
    {
        baslapanel.SetActive(false);
        Time.timeScale = 1;
        animasyon = GetComponent<Animator>();
    }
}
