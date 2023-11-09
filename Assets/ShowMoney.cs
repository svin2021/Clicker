using TMPro;
using UnityEngine;

public class ShowMoney : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void Update()
    {
        text.text = MoneyManager.Money.ToString();
    }
}
