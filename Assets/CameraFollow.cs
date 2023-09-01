using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    // 目标对象，通常是玩家
    public float smoothing = 10;     // 平滑移动的速度

    Vector3 offset;             // 相机和目标的初始偏移量

    void Start()
    {
        // 计算初始偏移量
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // 目标摄像机的新位置
        Vector3 targetCamPos = target.position + offset;

        // 平滑转换到新位置
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}