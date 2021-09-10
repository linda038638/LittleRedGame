using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 vec2 = new Vector2(1, 0);//int x=1 , int y=0
    Vector3 vec3 = new Vector3(1.0f, 0.0f, 0.5f);//float x=1.0 , float y=0.0 , float z=0.5

    
    public float speed;    //設公開的數度變數，可在unity中設值調整
    
    private void movement()//方法
    {   //採用直接改變物件座標的方式
        //向右走
        if (Input.GetKey("d"))//輸入.來自鍵盤(“d”)
        {
            this.gameObject.transform.Translate(new Vector2(5, 0) * Time.deltaTime);
        }  //此類別.這個物件.座標系統.位移(delta向量)

        //向左走
        if (Input.GetKey("a"))
        {
            this.gameObject.transform.Translate(new Vector2(-5, 0) * Time.deltaTime);
        }
        //向上走
        if (Input.GetKey("w"))
        {
            this.gameObject.transform.Translate(new Vector2(0, 5) * Time.deltaTime);
        }
        //向下走
        if (Input.GetKey("s"))
        {
            this.gameObject.transform.Translate(new Vector2(0, -5) * Time.deltaTime);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vec2.x); //1
        Debug.Log("vec3= "+vec3.z);
        Debug.Log(Vector2.up.y);
        Debug.Log(Vector2.up);
    }

    // Update is called once per frame
    void Update()
    {

        movement();
    }
}
