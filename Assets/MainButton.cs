using UnityEngine;

public class MainButton : MonoBehaviour
{
    int moneyModifire = 1;

    public void OnMouseDown()
    {
        MoneyManager.Money += moneyModifire;
    }
}
