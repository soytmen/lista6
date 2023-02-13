using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act5 : MonoBehaviour
{
    public int[] n;
    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (int sum in n)
        {
            num += sum;
            Debug.Log($" {sum} ");
        }
        Debug.Log($" {num} ");
    }
}




