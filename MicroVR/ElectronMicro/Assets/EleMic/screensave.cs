using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class screensave : MonoBehaviour
{
    public GameObject UI;
    public Text Datetext;
    double wid, hei;
    void Start()
    {

    }
    void Update()
    {

    }
    private IEnumerator Screensave()
    {
        wid = Screen.width * (1.0 - 520.0 / 1920.0);
        hei = Screen.height * (1.0 - 32.0 / 1080.0);
        print(wid + " " + hei);

        Datetext.text = System.DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(System.Convert.ToInt32(wid), System.Convert.ToInt32(hei), TextureFormat.RGB24, false);
        texture.ReadPixels(new Rect(0, 0, System.Convert.ToInt32(wid), System.Convert.ToInt32(hei)), 0, 0);
        texture.Apply();
        Datetext.text = "";
        string name = "EleMic screenshot-" + System.DateTime.Now.ToString("yyyy.MM.dd HH-mm-ss") + ".png";

        byte[] bytes = texture.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/" + name, bytes);
        Destroy(texture);
        UI.SetActive(true);
    }
    public void TakeScreenshot()
    {
        UI.SetActive(false);
        StartCoroutine("Screensave");
    }
}
