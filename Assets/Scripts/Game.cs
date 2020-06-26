using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public NumericalTextHandler lives;
    public NumericalTextHandler points;

    private void Start()
    {
        InıtializeCanvasText();
    }

    private void InıtializeCanvasText()
    {
        lives.Set(3);
        points.Set(0);
    }

    public void IncreasePoints()
    {
        points.IncrementBy(10);
    }

    public void DecreasePoints()
    {
        points.DecrementBy(10);
    }

    public void IncreaseLives()
    {
        lives.IncrementBy(1);
    }

    public void DecreaseLives()
    {
        lives.DecrementBy(1);
        if (lives.Get() <= 0)
        {
            SceneManager.LoadScene("Game Over");
            return;
        }
    }
}
