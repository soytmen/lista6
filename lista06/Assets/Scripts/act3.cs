using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act3 : MonoBehaviour
{
    // Start is called before the first frame update
    public int num = 10;
    void Start()
    {
        for (int i = num; i >= 0; i -= 1)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
