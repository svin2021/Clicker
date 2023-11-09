using System.Collections;
using UnityEngine;

public class AutoClick : MonoBehaviour
{
    [SerializeField] float Time;
    [SerializeField] int cost;
    [SerializeField] int Income;
    public void OnClick()
    {
        if(MoneyManager.Money >= cost)
        {
            MoneyManager.Money -= cost;
            StartCoroutine("autoclick");
        }
    }
    private IEnumerator autoclick()
    {
        while(true)
        {
            MoneyManager.Money += Income;
            yield return new WaitForSeconds(Time);
        }
    }
}
