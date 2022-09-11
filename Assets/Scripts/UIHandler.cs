using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject modelTarget;
    [SerializeField] private GameObject slider;
    [SerializeField] private GameObject sliderText;
    [SerializeField] private GameObject checkmark;
    private Slider sliderComponent;
    private Text sliderTextComponent;
    private bool hide;

    void Start()
    {
        sliderComponent = slider.GetComponent<Slider>();
        hide = false;
        sliderTextComponent = sliderText.GetComponent<Text>();
        sliderTextComponent.text = "1,0x";
        checkmark.SetActive(false);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UpdateModelScale()
    {
        modelTarget.transform.localScale = new Vector3(sliderComponent.value, sliderComponent.value, sliderComponent.value);
        sliderTextComponent.text = sliderComponent.value.ToString("F1") + "x";
    }    

    public void HideModel()
    {
        if(hide)
        {
            modelTarget.transform.localScale = new Vector3(sliderComponent.value, sliderComponent.value, sliderComponent.value);
            hide = false;
            checkmark.SetActive(false);
        }
        else
        {
            modelTarget.transform.localScale = Vector3.zero;
            hide = true;
            checkmark.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
