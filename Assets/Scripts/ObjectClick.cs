using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public GameObject popup;

    private void Update()
    {
        Debug.Log("Checking for touch/click...");

        if (Input.GetMouseButtonDown(0)) // ������������
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == gameObject) // ����Ƿ�����������
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
            renderer.materials[i].color = Random.ColorHSV(); // ����ı���ɫ
        }
        Debug.Log("����ɹ�");
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
