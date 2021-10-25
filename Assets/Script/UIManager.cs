using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager instance { get; private set; } = null;
    public Text _timerText = null;
    private Text timerText { get { return _timerText; } set { timerText = value; } }
    private void Awake()
    {
        instance = this;
    }


    private void Update() { }
    
      public void SetTimer(float time)
        {
        timerText.text = "Timer: " + time.ToString("F1");
        }
}
