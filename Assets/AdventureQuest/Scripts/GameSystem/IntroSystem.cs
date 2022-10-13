using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.GameSystem
{
    public class IntroSystem : MonoBehaviour
    {
        public Texture2D cursor_texture;
        public CursorMode cursor_mode;
        Vector2 hot_spot = Vector2.zero;
        void Start()
        {
            Cursor.SetCursor(cursor_texture, hot_spot, cursor_mode);
        }

        void StartGame()
        {

        }
     
        void Update()
        {

        }
    }

}