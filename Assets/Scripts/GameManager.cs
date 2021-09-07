using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Scripts.Utilities.JavaScriptInteraction;

namespace Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private TMP_InputField inputField;
        [SerializeField] private Button buttonSend;

        private void Start()
        {
            text.text = "¡Hello!, Please:";
            if (buttonSend != null)
            {
                buttonSend.onClick.AddListener(EventSend);
            }
        }

        private void EventSend()
        {
            string message = inputField.text;
            if (message != null)
                JavaScript.SendMessage(message);
        }
    }
}