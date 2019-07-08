using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepUpright : MonoBehaviour
{
    public Transform camera1;
    // Start is called before the first frame update

    void Update()
    {
        transform.position = camera1.position;
    }


}
