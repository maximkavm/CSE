using UnityEngine;
namespace Runtime{

// class Runner хранит ссылки на все контроллеры и для 
// них вызывать метод Tick()
public class Runner : MonoBehaviour {
    
    private List<IController> m_Controllers;

    private void Update() {
        TickControllers();
    }



    private void OnStartControllers(){

        foreach (IController controller in m_Controllers)
        {
            try
            {
                 controller.OnStart();
                 //controller.OnStop();
                 //controller.Tick();
                 
            }
            catch (Exception e)
            {

                    Debug.LogError(e);
            }

        }
    }

    
    private void OnStopControllers(){

        foreach (IController controller in m_Controllers)
        {
            try
            {
                 
                 controller.OnStop();
                                 
            }
            catch (Exception e)
            {

                    Debug.LogError(e);
            }

        }
    }

        private void TickControllers(){

        foreach (IController controller in m_Controllers)
        {
            try
            {
                 
                
                controller.Tick();
                 
            }
            catch (Exception e)
            {

                    Debug.LogError(e);
            }

        }
    }
}

}