using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
using static Core.Constants;

namespace Game.UI
{
    public class UpdatePanelView : MonoBehaviour
    {
        [Inject] private UIController _uiController;

        [SerializeField] private UIType _type;
        [SerializeField] private Button _buttonOk;
        [SerializeField] private TMP_Text _text;
        [SerializeField] private TMP_Text _textError;
        [SerializeField] private TMP_InputField _input;
        [SerializeField] private Animator _anim;
        [SerializeField] private Button _buttonCancel;
        [SerializeField] private TMP_Dropdown _dropdown;
        [SerializeField] private Toggle _toggleIsAnimated;

        [Inject]
        public void Construct()
        {
            _uiController.AddItemUI(DropdownColors, new ItemUI(_dropdown));
            _uiController.AddItemUI(Popup + _type, new ItemUI(_anim));
            _uiController.AddItemUI(TextCountCards + _type, new ItemUI(_text));
            _uiController.AddItemUI(ErrorText + _type, new ItemUI(_textError));
            _uiController.AddItemUI(PanelView + _type, new ItemUI(_buttonOk, _toggleIsAnimated, _dropdown, _input));
            _uiController.AddItemUI(BtnClosePopup + _type, new ItemUI(_buttonCancel));
        }
    }
}