using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderForButtons : MonoBehaviour
{
    // Start is called before the first frame update
public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
