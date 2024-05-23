using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, является ли объект главным героем
        {
            // Главный герой вошел в триггер
            // Здесь можно добавить дополнительные действия, если необходимо
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, является ли объект главным героем
        {
            // Главный герой вышел из триггера
            Destroy(other.gameObject); // Уничтожаем объект главного героя
          
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
