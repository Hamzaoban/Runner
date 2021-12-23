using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElmasEkleme : MonoBehaviour
{
    public Vector3 [] diamondskonum;
    public GameObject[] diamonds ;
    public float uzaklik;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ElmasOlusturucu(int sayac)
    {

        int rastgelesayi = Random.Range(0,diamonds.Length);
        Debug.Log(rastgelesayi);
    
        Instantiate(diamonds[rastgelesayi], new Vector3(diamondskonum[0].x, diamondskonum[0].y, diamondskonum[0].z + uzaklik+sayac), Quaternion.identity);

 
    } 
}
