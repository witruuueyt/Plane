using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banzi : MonoBehaviour
{
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open1()
    {
        this.ani.SetTrigger("Open");
    }

    public void Close1()
    {
        this.ani.SetTrigger("Close");
    }
}
