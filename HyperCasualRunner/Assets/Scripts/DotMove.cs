using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotMove : MonoBehaviour
{
    public Transform Aim;
    public float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOMove(Aim.position, time).SetLoops(-1);
    }

   
}
