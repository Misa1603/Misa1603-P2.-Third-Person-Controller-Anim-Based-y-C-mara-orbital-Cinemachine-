using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinema2 : MonoBehaviour
{
    public GameObject GhostCamera;
    public GameObject personaje;
    public GameObject fantasma;
    public GameObject cubo;
    public GameObject cubo2;

   
    private void OnTriggerEnter(Collider other)
    {
        personaje.SetActive(false);
        GhostCamera.SetActive(true);
        fantasma.SetActive(true);
        StartCoroutine(tiempo());
    }

    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(12.5f);
        Destroy(cubo);
        Destroy(GhostCamera);
        Destroy(fantasma);
        cubo2.SetActive(true);
        personaje.SetActive(true);
       
    }
}
