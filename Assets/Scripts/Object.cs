using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject MyPrefab;
    public GameObject InteractiveObject;

    private bool hasCollided = false; // �浹 ���θ� ��Ÿ���� ����

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasCollided && collision.gameObject.name == "GameObject")
        {
            hasCollided = true; // �浹 �߻�

            Debug.Log(gameObject.name);

            GameObject GO = Instantiate(MyPrefab, transform.position, transform.rotation); // �� ������Ʈ ����
            GO.transform.parent = InteractiveObject.transform;

            Destroy(GO, 3f); // �� ������Ʈ�� ���� �ð� �Ŀ� �ı�
            Destroy(gameObject); // �浹�� ������Ʈ�� �ٷ� �ı�
        }
    }
}
