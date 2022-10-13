using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Scripts.Mouse
{
    public class Mouse : MonoBehaviour
    {
        public Texture2D cursor_texture_hand, cursor_texture_pointer;
        public CursorMode cursor_mode = CursorMode.Auto;
        public Vector2 hot_spot = Vector2.zero;
        public Button start_button;

        private void Start()
        {
            start_button.onClick.AddListener(StartGame);
        }
        public void OnMouseEnter()
        {
            Cursor.SetCursor(cursor_texture_hand, hot_spot, cursor_mode);
        }

        public void OnMouseExit()
        {
            Cursor.SetCursor(cursor_texture_pointer, Vector2.zero, cursor_mode);
        }

        public void StartGame()
        {
            StartCoroutine("StartBtn");
        }
        public IEnumerator StartBtn()
        {
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
