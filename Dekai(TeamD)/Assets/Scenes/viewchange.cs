using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class viewchange : MonoBehaviour
{
    public GameObject white, black, blue, red;
    // Start is called before the first frame update
    void Start()
    {
        white.SetActive(true);
        black.SetActive(false);
        blue.SetActive(false);
        red.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            white.SetActive(false);
            black.SetActive(true);
            blue.SetActive(false);
            red.SetActive(false);
            Debug.Log("black");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            white.SetActive(false);
            black.SetActive(false);
            blue.SetActive(true);
            red.SetActive(false);
            Debug.Log("blue");
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            white.SetActive(false);
            black.SetActive(false);
            blue.SetActive(false);
            red.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            white.SetActive(true);
            black.SetActive(false);
            blue.SetActive(false);
            red.SetActive(false);
        }
    }
}
