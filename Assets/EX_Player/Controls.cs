using UnityEngine;

public class Controls : MonoBehaviour
{
    public GameObject lightControl; // LightControl ������Ʈ�� �巡�� �� ����Ͽ� �����մϴ�.
    private bool lightsOn = false; // ���� ����Ʈ ���¸� �����ϱ� ���� ����

    private void Update()
    {
        // E Ű�� �Է��ϸ�
        if (Input.GetKeyDown(KeyCode.E))
        {
            // LightControl ������Ʈ�� �����ϰ�
            if (lightControl != null)
            {
                // ����Ʈ ���¿� ����
                if (lightsOn)
                {
                    // LightControl �ڽ����� �ִ� ��� Point Light�� �����ɴϴ�.
                    Light[] pointLights = lightControl.GetComponentsInChildren<Light>();

                    // ��� Point Light�� ���ϴ�.
                    foreach (Light pointLight in pointLights)
                    {
                        pointLight.enabled = false;
                    }

                    // ����Ʈ ���� ������Ʈ
                    lightsOn = false;
                }
                else
                {
                    // LightControl �ڽ����� �ִ� ��� Point Light�� �����ɴϴ�.
                    Light[] pointLights = lightControl.GetComponentsInChildren<Light>();

                    // ��� Point Light�� �մϴ�.
                    foreach (Light pointLight in pointLights)
                    {
                        pointLight.enabled = true;
                    }

                    // ����Ʈ ���� ������Ʈ
                    lightsOn = true;
                }
            }
        }
    }
}
