using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Firstalert : MonoBehaviour
{
    public Text alert;
    //ここの数をいじると、表示の秒数等が変わるようにしました(1,3,4なら、1秒で透明から不透明、1秒から3秒まで不透明、3秒から4秒までで不透明から透明)
    private int[] alerttime = new int[3] {1,3,4};

    // Start is called before the first frame update
    void Start()
    {
        alert.color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //0からalerttime[0]秒まで
        if (Time.time < alerttime[0])
        {
            alert.color = new Color(1, 1, 1, alerttime[0] - (Mathf.Sin(Time.time * Mathf.PI / 2 + Mathf.PI / 2)) / alerttime[0]);
            //Sin(90) = 1 → sin(0) = 0
        }
        //不透明
        //alerttime[0]からalerttime[1]秒まで
        else if (Time.time < alerttime[1])
        {

        }
        //不透明から透明
        //alerttime[1]秒からalerttime[2]秒まで
        else if (Time.time < alerttime[2])
        {
            alert.color = new Color(1, 1, 1, (alerttime[2] - alerttime[1]) - (Mathf.Sin((Time.time - alerttime[1]) * Mathf.PI / 2))/(alerttime[2] - alerttime[1]));
        }
        if (Time.time > alerttime[2])
        {
            //シーンを遷移するプログラム(事前にusing UnityEngine.SceneManagementを書いておく必要あり)
            SceneManager.LoadScene("title");
        }
    }
}
