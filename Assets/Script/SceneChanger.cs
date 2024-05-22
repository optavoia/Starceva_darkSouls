using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ToFirstScene()
    {
        StartCoroutine(ChangeSceneWithDelay("SampleScene", 1f));
    }

    public void ToSecondScene()
    {
        StartCoroutine(ChangeSceneWithDelay(1, 1f));
    }

    public void ToThirdScene()
    {
        StartCoroutine(ChangeSceneWithDelay(2, 1f));
    }

    public void Quit()
    {
        Application.Quit();
    }

    private IEnumerator ChangeSceneWithDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    private IEnumerator ChangeSceneWithDelay(int sceneIndex, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }
}
