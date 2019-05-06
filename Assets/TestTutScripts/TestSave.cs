using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSave : MonoBehaviour
{
    public int completion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setCompletion(int c)
    {
        completion = c;
    }
    public int getCompletion()
    {
        return completion;
    }
}
