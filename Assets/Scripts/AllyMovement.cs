using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyMovement : MonoBehaviour
{
    public float speed = 0.03f;

    Vector3 translationVec;
    float x = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        translationVec = new Vector3(x, 0, 0);

        transform.localPosition += translationVec * speed;
    }
}
