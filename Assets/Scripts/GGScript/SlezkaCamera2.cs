using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlezkaCamera2 : MonoBehaviour
{
    public Transform target; // ������ �� ���������, �� ������� ������ ����� �������
    public float smoothTime = 0.3f; // �����, �� ������� ������ ������� ���������
    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        if (target != null)
        {
            // �������� ������� ��������� � �������, � ������� ������ ���������� ������
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            Vector3 newPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

            // ������������� ����� ������� ������
            transform.position = newPosition;
        }
    }
}
