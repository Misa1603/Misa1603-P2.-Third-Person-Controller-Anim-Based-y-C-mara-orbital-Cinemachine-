using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinema_3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject peleaCamera;
    public GameObject personaje;
    public GameObject fantasma;
    public GameObject cubo2;
    public GameObject personajeAnim;

    private void OnTriggerEnter(Collider other)
    {
        personaje.SetActive(false);
        peleaCamera.SetActive(true);
        fantasma.SetActive(true);
        personajeAnim.SetActive(true);
        StartCoroutine(tiempo2());
    }

    IEnumerator tiempo2()
    {
        yield return new WaitForSeconds(8.7f);
        Destroy(cubo2);
        Destroy(peleaCamera);
        Destroy(fantasma);
        Destroy(personajeAnim);
        personaje.SetActive(true);
    }
}
