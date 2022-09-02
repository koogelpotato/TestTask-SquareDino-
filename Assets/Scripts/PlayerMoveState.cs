using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class PlayerMoveState : AbstractPlayerState
    {
        public PlayerMoveState(WaypointSystem waypointSystem, IStationStateSwitcher stateSwitcher, Shooting shooting) : base(waypointSystem, stateSwitcher, shooting)
        {

        }
        public override void MoveCharacter()
        {
            _waypointSystem.UpdateCurrentPoint();
            _waypointSystem.MoveAgent();
        }
        public override void PauseCharacter()
        {
            return;
        }
        public override void Shoot()
        {
            return;
        }
    }
}
