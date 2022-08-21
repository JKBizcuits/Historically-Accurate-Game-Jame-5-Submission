using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform source;
    public GameObject target;
    Transform coordinate;
    Vector3 vector;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (source.position != target.transform.position)
        {
            vector = target.transform.position;
            source.position = target.transform.position;
            source.position = setZ(source.position, 0); 

        }


    }

    public Vector3 setZ(Vector3 vector, float z) 
    {
        vector.z = z;
        return vector;
    }
}
