using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PicturesChanger : MonoBehaviour
{
    public Sprite[] pictures;
    private int i;
    public int cost;
    [SerializeField] Image mainImage;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] string[] costs;

    public void OnClick()
    {
        if(MoneyManager.Money >= cost)
        {
            text.text = "Следущая девушка стоит:" + costs[i];
            MoneyManager.Money -= cost;
            cost = int.Parse(costs[i]);
            ChangeImage();
        }
    }
    private void ChangeImage()
    {
        mainImage.sprite = pictures[i];
        i++;
    }
}
