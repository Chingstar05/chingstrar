using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasicVarlables : MonoBehaviour

{

    public int gold = 0;            //������
    public float Hp = 100.0f;       //�Ǽ��� (�Ҽ����� �ִ� ����, ���� 'f' �ʼ�)
    public string playName = "ȫ�浿"; //���ڿ� (������ ����)
    private bool jsAlive = true;       //���� (��/������ ��Ÿ��) true/false


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���ӽ���");              //����Ƽ ����׿� �޼��� ���


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("����������");              //����Ƽ ����׿� �޼��� ���

    }
}
