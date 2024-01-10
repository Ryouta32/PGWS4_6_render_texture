using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] GameObject Plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Plane.transform.position = target.position+new Vector3(0,1,0);
        //transform.position = target.position+new Vector3(0,10,0);
        transform.position = new Vector3(0.5f * Mathf.Sin(0.2f * Time.time), 0.0f, 0.8f);
    }
}
