using UnityEngine;
using System.Collections;

public class AndroidAPP : MonoBehaviour {

    public GUISkin m_skin;

    // 显示android 对话框
    public Rect m_showAndroidDialog;

    // Android Activity
    private AndroidJavaObject activity;

	// Use this for initialization
	void Start () {

        this.name = "AndroidManager";

        // 获得Android Activity
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        activity = jc.GetStatic<AndroidJavaObject>("currentActivity");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.skin=m_skin;

        if (GUI.Button(m_showAndroidDialog, "显示android 对话框"))
        {
            string[] args=new string[2];
            args[0]="Hello";
            args[1]="World";
            activity.Call("HelloWorld", args);
        }

    }

    void AndroidCallBack()
    {
        // 将背景改为红色
        Camera.main.backgroundColor = new Color(1.0f, 0, 0);
    }
}
