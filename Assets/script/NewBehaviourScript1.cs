using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Vector3 position;
    public Vector3 retation;
    public Vector3 sacle;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 jiggle = new Vector3(
            position.x,
            pisition.y + Random.value,
            position.z);
        this.transform.position = jiggle;
        this.transform.
    }
}
