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
        protected readonly Shooting _shooting;
        protected AbstractPlayerState(WaypointSystem waypointSystem, IStationStateSwitcher stateSwitcher, Shooting shooting)
        {
            _waypointSystem = waypointSystem;
            _stateSwitcher = stateSwitcher;
            _shooting = shooting;
        }
        public abstract void MoveCharacter();
        public abstract void Shoot();
        public abstract void PauseCharacter();

    }
}
