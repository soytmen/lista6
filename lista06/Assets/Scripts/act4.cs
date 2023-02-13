using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act4 : MonoBehaviour
{

    public int start = 3;
    public int end = 27;
    // Start is called before the first frame update
    void Start()
    {
        int num = start;
        while ( num <= end)
        {
            if( num % 5 == 0)
            {
                Debug.Log(num);
            }
            num++;
        }
    }

    
}
