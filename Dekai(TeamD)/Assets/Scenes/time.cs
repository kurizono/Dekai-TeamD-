using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class time : MonoBehaviour
{
    public Text watch;
    float firsttime;

    // Start is called before the first frame update
    void Start()
    {
        firsttime = Mathf.Floor(Time.time);
    }
    // Update is called once per frame
    void Update()
    {
        watch.text = (Mathf.Floor(Time.time) - firsttime).ToString();
    }
}
