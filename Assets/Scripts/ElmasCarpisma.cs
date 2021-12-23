using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElmasCarpisma : MonoBehaviour
{
    static int sayac;
    ElmasEkleme ElmasEkleme;
    void Start()
    {
        ElmasEkleme = GameObject.Find("ElmasKontrol").GetComponent<ElmasEkleme>();
        
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sayac = sayac + 2;
            ElmasEkleme.ElmasOlusturucu(sayac);

            Debug.Log("girdi");
        }
    }
}
