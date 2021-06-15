using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class element_legend : MonoBehaviour
{
    List<string> arr = new List<string>();
    private void Start()
    {
        arr.Add("si");
        arr.Add("o");
        arr.Add("na");
        arr.Add("ca");
        arr.Add("fe");
        arr.Add("al");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            arr.RemoveAt(1);
            foreach (var item in arr)
            {
                print(item);
            }
        }
    }
}
