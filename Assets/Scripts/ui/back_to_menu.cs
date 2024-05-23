using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_to_menu : MonoBehaviour
{
    public void backtomenu()
    {
        SceneManager.LoadScene(0);
        CounterSoul.soul = 0f;
    }

}
