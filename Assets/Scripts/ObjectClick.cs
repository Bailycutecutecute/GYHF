using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public GameObject popup;

    private void Update()
    {
        Debug.Log("Checking for touch/click...");

        if (Input.GetMouseButtonDown(0)) // 检测鼠标点击或触摸
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == gameObject) // 检查是否点击到该物体
                {
                    ChangeColor();
                    ShowPopup();
                }
            }
        }
    }

    private void ChangeColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material[] materials = renderer.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            renderer.materials[i].color = Random.ColorHSV(); // 随机改变颜色
        }
        Debug.Log("点击成功");
    }

    private void ShowPopup()
    {
        popup.SetActive(true);
    }

    public void OnClickHidePopup()
    {
        popup.SetActive(false);
    }
}
