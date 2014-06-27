package com.project.helloworld;

import android.os.Bundle;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.view.KeyEvent;
import android.content.res.Configuration;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;


public class MainActivity extends Activity {
	
	private UnityPlayer mUnityPlayer;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		
		setTheme(android.R.style.Theme_NoTitleBar_Fullscreen);
	    requestWindowFeature(Window.FEATURE_NO_TITLE);
	     
	    mUnityPlayer = new UnityPlayer(this);
	     
	    if(mUnityPlayer.getSettings ().getBoolean ("hide_status_bar", true))
	       getWindow ().setFlags (WindowManager.LayoutParams.FLAG_FULLSCREEN,
	                                 WindowManager.LayoutParams.FLAG_FULLSCREEN);
	     
	    int glesMode = mUnityPlayer.getSettings().getInt("gles_mode", 1);
	    boolean trueColor8888 = false;
	    mUnityPlayer.init(glesMode, trueColor8888);
	     
	    View playerView = mUnityPlayer.getView();
	    setContentView(playerView);
	        
	    playerView.requestFocus();
	}
	
    protected void onDestroy ()
    {
    	super.onDestroy();
    	mUnityPlayer.quit();
    }

    // onPause()/onResume() must be sent to UnityPlayer to enable pause and resource recreation on resume.
    protected void onPause()
    {
    	super.onPause();
    	mUnityPlayer.pause();
    }
     
    protected void onResume()
    {
    	super.onResume();
    	mUnityPlayer.resume();
    }
    
    public void onConfigurationChanged(Configuration newConfig)
    {
    	super.onConfigurationChanged(newConfig);
    	mUnityPlayer.configurationChanged(newConfig);
    }
     
    public void onWindowFocusChanged(boolean hasFocus)
    {
    	super.onWindowFocusChanged(hasFocus);
    	mUnityPlayer.windowFocusChanged(hasFocus);
    }
   
    // Pass any keys not handled by (unfocused) views straight to UnityPlayer
    public boolean onKeyDown(int keyCode, KeyEvent event)
    {
      return mUnityPlayer.onKeyDown(keyCode, event);
    }
     
    public boolean onKeyUp(int keyCode, KeyEvent event)
    {
      return mUnityPlayer.onKeyUp(keyCode, event);
    }

	// 在Unity中调用的函数
	protected void HelloWorld(final String title, final String content)
	{
		 runOnUiThread(new Runnable() {     
			  public void run() {
				  MakeDialog(title, content);
			  }
		  });
	}
	
	// 显示对话框
	public void MakeDialog(String title, String content) 
	{
	        AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this);
	        
	        builder.setTitle(title)
	            .setMessage(content)
	            .setCancelable(false)
	            .setPositiveButton("OK", new DialogInterface.OnClickListener(){
	            	public void onClick(DialogInterface dialog, int which) {
	            		UnityPlayer.UnitySendMessage("AndroidManager", "AndroidCallBack", "");
	            	}
	            }
	            		);

	        builder.show();
	}

}
