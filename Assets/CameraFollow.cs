using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    // Ŀ�����ͨ�������
    public float smoothing = 10;     // ƽ���ƶ����ٶ�

    Vector3 offset;             // �����Ŀ��ĳ�ʼƫ����

    void Start()
    {
        // �����ʼƫ����
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // Ŀ�����������λ��
        Vector3 targetCamPos = target.position + offset;

        // ƽ��ת������λ��
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}