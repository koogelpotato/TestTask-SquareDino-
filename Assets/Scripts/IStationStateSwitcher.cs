namespace Assets.Scripts
{
    public interface IStationStateSwitcher
    {
        void SwitchState<T>() where T : AbstractPlayerState;
    }
}