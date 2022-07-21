using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoColor : MonoBehaviour
{
    private Material mevcutRenk;
    public Material yeniRenk;
    public float gecisSuresi;
    void Start()
    {
        mevcutRenk = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            mevcutRenk.DOColor(yeniRenk.color,gecisSuresi);
        }
    }
}
