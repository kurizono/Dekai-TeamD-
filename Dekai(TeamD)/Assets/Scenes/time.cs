using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class time : MonoBehaviour
{
    public Text watch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        watch.text = Mathf.Floor(Time.time).ToString();
    }
}
