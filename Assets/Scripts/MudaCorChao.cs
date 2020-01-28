using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudaCorChao : MonoBehaviour
{
    private Material cor;
    // Start is called before the first frame update
    void Start()
    {
        cor = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cor.SetColor("_BaseColor", Color.red);
        }
        else
        {
            cor.SetColor("_BaseColor", Color.green);
        }
    }
}
