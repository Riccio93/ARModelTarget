using UnityEngine;
using UnityEngine.EventSystems;

public class UIToggle : MonoBehaviour
{
    [SerializeField] private GameObject ui;

    private void Start()
    {
        ui.gameObject.SetActive(false);
    }

    private void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            int id = touch.fingerId;
            if (!EventSystem.current.IsPointerOverGameObject(id) && touch.phase == TouchPhase.Began)
            {
                if(ui.gameObject.activeSelf)
                {
                    ui.gameObject.SetActive(false);
                }
                else
                {
                    ui.gameObject.SetActive(true);
                }
            }
        }
    }
}
