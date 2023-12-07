using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDevTraumCursorManager : MonoBehaviour
{

    public Texture2D cursor_normal;
    public Vector2 normalCursorHotSpot;

    public Texture2D cursor_OnButton;
    public Vector2 onButtonCursorHotSpot;

    public Texture2D cursor_denied;
    public Vector2 deniedCursorHotSpot;

    void Start()
    {
        Cursor.SetCursor(cursor_normal, normalCursorHotSpot, CursorMode.Auto);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cursor.SetCursor(cursor_normal, normalCursorHotSpot, CursorMode.Auto);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cursor.SetCursor(cursor_OnButton, onButtonCursorHotSpot, CursorMode.Auto);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cursor.SetCursor(cursor_denied, deniedCursorHotSpot, CursorMode.Auto);
        }

    }

    public void OnButtonCursorEnter()
    {
        Cursor.SetCursor(cursor_OnButton, onButtonCursorHotSpot, CursorMode.Auto);

    }
    
    public void OnButtonCursorDenied()
    {
        Cursor.SetCursor(cursor_denied, deniedCursorHotSpot, CursorMode.Auto);

    }

    public void OnButtonCursorExit()
    {
        Cursor.SetCursor(cursor_normal, normalCursorHotSpot, CursorMode.Auto);

    }

}
