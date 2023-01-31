using UnityEngine;

namespace Player
{
    public class PlayerMovementInput
    {
         public bool Click()
         {
            return Input.GetMouseButtonDown(0);
         }
    }
}
