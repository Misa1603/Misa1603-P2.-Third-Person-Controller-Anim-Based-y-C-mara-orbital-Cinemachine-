using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionYjUEGO : MonoBehaviour
{

    public GameObject personaje;
    public GameObject CameraAnimacion;
    public GameObject AnimPersonaje;
    public GameObject cubo;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(tiempo());
    }

    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(15f);
        Destroy(CameraAnimacion);
        Destroy(AnimPersonaje);
        personaje.SetActive(true);
        cubo.SetActive(true);
    }
}
