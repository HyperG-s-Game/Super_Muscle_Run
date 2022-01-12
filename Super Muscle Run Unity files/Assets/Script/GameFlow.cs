using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{
    public float waitingTimeToReload = 1f;
    public void Restart()
    {

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitingTimeToReload);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
