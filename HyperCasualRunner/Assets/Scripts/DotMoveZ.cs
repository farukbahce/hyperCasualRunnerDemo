using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DotMoveZ : MonoBehaviour
{
    
    public Transform Aim;
    public float time;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.DOMoveZ(Aim.position.z,time).SetLoops(-1);
    }
    
}
