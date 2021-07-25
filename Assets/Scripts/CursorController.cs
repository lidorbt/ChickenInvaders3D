using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public static CursorController instance;

    public Texture2D aimCursor, redAimCursor;

    private void Awake()
    {
        instance = this;
    }

    public void ActiateRedAimCursor()
    {
        Cursor.SetCursor(redAimCursor, new Vector2(redAimCursor.width / 2, redAimCursor.height / 2), CursorMode.Auto);
    }

    public void ActiateAimCursor()
    {
        Cursor.SetCursor(aimCursor, new Vector2(aimCursor.width / 2, aimCursor.height / 2), CursorMode.Auto);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
