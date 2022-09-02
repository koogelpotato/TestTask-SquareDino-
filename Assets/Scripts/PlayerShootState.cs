using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class PlayerShootState : AbstractPlayerState
    {
        public PlayerShootState(WaypointSystem waypointSystem, IStationStateSwitcher stateSwitcher, Shooting shooting) : base(waypointSystem, stateSwitcher, shooting)
        {

        }
        public override void MoveCharacter()
        {
            return;
        }
        public override void PauseCharacter()
        {
            return;
        }
    }
}
