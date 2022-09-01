using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public abstract class AbstractPlayerState
    {
        protected readonly WaypointSystem _waypointSystem;
        protected readonly IStationStateSwitcher _stateSwitcher;

        protected AbstractPlayerState(WaypointSystem waypointSystem, IStationStateSwitcher stateSwitcher)
        {
            _waypointSystem = waypointSystem;
            _stateSwitcher = stateSwitcher;
        }
        public abstract void MoveCharacter();
        public abstract void Shoot();
        public abstract void PauseCharacter();

    }
}
