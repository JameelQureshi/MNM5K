 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShareScript : MonoBehaviour
{
	private string shareMsg;
    
    public void clickShare()
    {
		shareMsg = "helo im saba";
		StartCoroutine(TakeScreenshotAndShare());   
    }
	private IEnumerator TakeScreenshotAndShare()
	{
		yield return new WaitForEndOfFrame();

        //Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        //ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        //ss.Apply();

        //string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
        //File.WriteAllBytes(filePath, ss.EncodeToPNG());

        // To avoid memory leaks
        //Destroy(ss);

        //new NativeShare().AddFile(filePath)
        //	.SetSubject("Subject goes here").SetText(shareMsg).SetUrl("https://github.com/yasirkula/UnityNativeShare")
        //	.SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
        //	.Share();

        new NativeShare().AddFile(shareMsg)
			.SetSubject("meshFlix").SetText(shareMsg).SetUrl("https://github.com/yasirkula/UnityNativeShare")
			.SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
			.Share();
	}
}
