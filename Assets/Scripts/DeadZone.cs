using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ���������, �������� �� ������ ������� ������
        {
            // ������� ����� ����� � �������
            // ����� ����� �������� �������������� ��������, ���� ����������
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ���������, �������� �� ������ ������� ������
        {
            // ������� ����� ����� �� ��������
            Destroy(other.gameObject); // ���������� ������ �������� �����
          
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
