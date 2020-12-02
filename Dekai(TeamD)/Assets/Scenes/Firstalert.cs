using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Firstalert : MonoBehaviour
{
    public Text alert;
    // Start is called before the first frame update
    void Start()
    {
        alert.color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < 1)
        {
            alert.color = new Color(1, 1, 1, 1 - Mathf.Sin(Time.time * Mathf.PI / 2 + Mathf.PI / 2));
            //Sin(90) = 1 → sin(0) = 0
        }
        //不透明
        else if (Time.time < 2)
        {

        }
        //不透明から透明
        else if (Time.time < 3)
        {
            alert.color = new Color(1, 1, 1, 1 - Mathf.Sin((Time.time - 2) * Mathf.PI / 2));
        }
        if (Time.time > 3)
        {
            //シーンを遷移するプログラム(事前にusing UnityEngine.SceneManagementを書いておく必要あり)
            SceneManager.LoadScene("title");
        }
    }
}
