using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordSpinner : MonoBehaviour
{
    public GameObject record;
    float spinSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        record.transform.Rotate( 0f, spinSpeed * Time.deltaTime, 0f, Space.World );

    }
}
