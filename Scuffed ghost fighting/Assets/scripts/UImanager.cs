using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    private float hp, sc;
    [SerializeField]
    private Text HealthText, ScoreText;
    

    // Update is called once per frame
    void LateUpdate()
    {
        //get values
        hp = gameObject.GetComponent<PlayerHealthManagement>().playerHealth;
        sc = gameObject.GetComponent<PlayerScoreManagement>().score;
        //set values in ui
        HealthText.text = hp.ToString();
        ScoreText.text = sc.ToString();
    }
}
