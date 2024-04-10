using UnityEngine;

public class Controls : MonoBehaviour
{
    public GameObject lightControl; // LightControl 오브젝트를 드래그 앤 드롭하여 연결합니다.
    private bool lightsOn = false; // 현재 라이트 상태를 추적하기 위한 변수

    private void Update()
    {
        // E 키를 입력하면
        if (Input.GetKeyDown(KeyCode.E))
        {
            // LightControl 오브젝트가 존재하고
            if (lightControl != null)
            {
                // 라이트 상태에 따라서
                if (lightsOn)
                {
                    // LightControl 자식으로 있는 모든 Point Light를 가져옵니다.
                    Light[] pointLights = lightControl.GetComponentsInChildren<Light>();

                    // 모든 Point Light를 끕니다.
                    foreach (Light pointLight in pointLights)
                    {
                        pointLight.enabled = false;
                    }

                    // 라이트 상태 업데이트
                    lightsOn = false;
                }
                else
                {
                    // LightControl 자식으로 있는 모든 Point Light를 가져옵니다.
                    Light[] pointLights = lightControl.GetComponentsInChildren<Light>();

                    // 모든 Point Light를 켭니다.
                    foreach (Light pointLight in pointLights)
                    {
                        pointLight.enabled = true;
                    }

                    // 라이트 상태 업데이트
                    lightsOn = true;
                }
            }
        }
    }
}
