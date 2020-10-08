using UnityEngine;

namespace Assets.UnityTest.KCPTest
{
    public class KCPTest:MonoBehaviour
    {
        private KCPPlayer p1, p2;

        void Awake()
        {
            Debuger.EnableLog = true;

            p1 = new KCPPlayer();
            p1.Init("Server", 12345, 12346);

            p2 = new KCPPlayer();
            p2.Init("Player2", 12346, 12345);
            
        }

        void Update()
        {
            p1.OnUpdate();
            p2.OnUpdate();

            p1.SendMessage();
            p2.SendMessage();
        }
    }
}
