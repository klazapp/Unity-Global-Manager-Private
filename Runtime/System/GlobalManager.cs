using Unity.Mathematics;
using UnityEngine;

namespace com.Klazapp.Utility
{
    [ScriptHeader("Global manager provides a central basic data retrieval end point. It contains basic data such as Time.deltaTime and WaitForSeconds")]
    public class GlobalManager : MonoBehaviour
    {
        #region Variables
        //Delta times
        public static float deltaTime;
        public static float smoothDeltaTime;
        public static float fixedDeltaTime;

        //Default transform values
        public static readonly float3 zeroF3 = new(0);
        public static readonly quaternion zeroRot = quaternion.identity;

        //Wait for seconds
        public static readonly WaitForSeconds pointSixWfs = new(0.6f);
        public static readonly WaitForSeconds oneWfs = new(1f);
        public static readonly WaitForSeconds twoWfs = new(2f);
        public static readonly WaitForSeconds threeWfs = new(3f);
        public static readonly WaitForSeconds fourWfs = new(4f);
        public static readonly WaitForSeconds fiveWfs = new(5f);
        #endregion
        
        #region Lifecycle Flow
        private void FixedUpdate()
        {
            fixedDeltaTime = Time.fixedDeltaTime;
        }

        private void Update()
        {
            deltaTime = Time.deltaTime;
            smoothDeltaTime = Time.smoothDeltaTime;
        }
        #endregion
    }
}
