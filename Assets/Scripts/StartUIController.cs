using UnityEngine;
using UnityEngine.UI;

public class StartUIController : MonoBehaviour
{
    //上一次
    public Text lastText;
    //最佳
    public Text bestText;
    public Toggle blue;
    public Toggle yellow;
    //边界模式
    public Toggle border;
    //无尽模式
    public Toggle noBorder;

    void Awake()
    {
        lastText.text = "上次：长度" + PlayerPrefs.GetInt("lastl", 0) + "，分数" + PlayerPrefs.GetInt("lasts", 0);
        bestText.text = "最好：长度" + PlayerPrefs.GetInt("bestl", 0) + "，分数" + PlayerPrefs.GetInt("bests", 0);
    }

    void Start()
    {
        if (PlayerPrefs.GetString("sh", "sh01") == "sh01")
        {
            blue.isOn = true;
            PlayerPrefs.SetString("sh", "sh01");//存储蛇头
            PlayerPrefs.SetString("sb01", "sb0101");//奇数蛇身
            PlayerPrefs.SetString("sb02", "sb0102");//偶数蛇身
        }
        else
        {
            yellow.isOn = true;
            PlayerPrefs.SetString("sh", "sh02");
            PlayerPrefs.SetString("sb01", "sb0201");
            PlayerPrefs.SetString("sb02", "sb0202");
        }
        if (PlayerPrefs.GetInt("border", 1) == 1)
        {
            border.isOn = true;
            PlayerPrefs.SetInt("border", 1);
        }
        else
        {
            noBorder.isOn = true;
            PlayerPrefs.SetInt("border", 0);
        }
    }
    //选择科技小蛇
    public void BlueSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetString("sh", "sh01");
            PlayerPrefs.SetString("sb01", "sb0101");
            PlayerPrefs.SetString("sb02", "sb0102");
        }
    }
    //选择黄色小蛇
    public void YellowSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetString("sh", "sh02");
            PlayerPrefs.SetString("sb01", "sb0201");
            PlayerPrefs.SetString("sb02", "sb0202");
        }
    }
    //模式选择
    public void BorderSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetInt("border", 1);
        }
    }

    public void NoBorderSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetInt("border", 0);
        }
    }
    //加载游戏场景
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
