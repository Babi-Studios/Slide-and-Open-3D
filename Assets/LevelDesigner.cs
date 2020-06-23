using UnityEngine;
using UnityEngine.UI;

public class LevelDesigner : MonoBehaviour
{
    public Text heartsText;
    public Text pointsText;

    public int hearts;
    public int points;
    // Start is called before the first frame update

    private void Start()
    {
        InıtialValuesOfCanvas();
    }

    private void InıtialValuesOfCanvas()
    {
        hearts = 3;
        heartsText.text = hearts.ToString("0");
        points = 0;
        pointsText.text = points.ToString("0");
    }

    public void PointsIncreaser()
    {
        points += 10;
        pointsText.text = points.ToString("0");
    }
    public void PointDecreaser()
    {
        points -= 10;
        pointsText.text = points.ToString("0");
    }
    public void HeartIncreaser()
    {
        hearts += 1;
        heartsText.text = hearts.ToString("0");
    }
    public void HeartDecreaser()
    {
        hearts -= 1;
        heartsText.text = hearts.ToString("0");
    }
}
