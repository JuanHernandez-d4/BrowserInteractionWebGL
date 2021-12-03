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

        [SerializeField] private Button buttonCode;
        [SerializeField] private Button buttonPutUrl;


        private void Start()
        {
            text.text = "¡Hello!, Please:";
            if (buttonSend != null)
            {
                buttonSend.onClick.AddListener(EventSend);
                buttonCode.onClick.AddListener(Code);
                buttonPutUrl.onClick.AddListener(PutUrl);
            }

        }

        private void EventSend()
        {
            string message = inputField.text;
            if (message != null)
                JavaScript.SendMessage(message);
                
        }

        private void Code(){

            JavaScript.WebTokenEncode();
            //JavaScript.WebTokenDecode();
        }

        private void PutUrl(){

            JavaScript.PutToken1();

        }

    }
}