using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 vec2 = new Vector2(1, 0);//int x=1 , int y=0
    Vector3 vec3 = new Vector3(1.0f, 0.0f, 0.5f);//float x=1.0 , float y=0.0 , float z=0.5

    
    public float speed;    //�]���}���ƫ��ܼơA�i�bunity���]�Ƚվ�
    
    private void movement()//��k
    {   //�ĥΪ������ܪ���y�Ъ��覡
        //�V�k��
        if (Input.GetKey("d"))//��J.�Ӧ���L(��d��)
        {
            this.gameObject.transform.Translate(new Vector2(5, 0) * Time.deltaTime);
        }  //�����O.�o�Ӫ���.�y�Шt��.�첾(delta�V�q)

        //�V����
        if (Input.GetKey("a"))
        {
            this.gameObject.transform.Translate(new Vector2(-5, 0) * Time.deltaTime);
        }
        //�V�W��
        if (Input.GetKey("w"))
        {
            this.gameObject.transform.Translate(new Vector2(0, 5) * Time.deltaTime);
        }
        //�V�U��
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
