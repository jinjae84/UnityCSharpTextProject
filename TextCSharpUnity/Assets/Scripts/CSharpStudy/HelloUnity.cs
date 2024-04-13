
using UnityEngine;
using TMPro;

public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    int damage = 100;
    float time = 30.5f;
    string _name = "이순신";
    private void Start()
    {
        Debug.Log("데미지의 값" + damage);
        Debug.Log("시간의 값" + time);
        Debug.Log("이름" + name);

        text.text = string.Format($"Only{damage} English{time} is visible : 정말이니 ? ");
    }
}
