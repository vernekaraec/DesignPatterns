
namespace Vernekar.FacadeDesignPattern.Facade
{
    using Vernekar.FacadeDesignPattern.Subsystem;

    public class HomeFacade
    {
        private Lights _lights = null;
        private AirConditioner _airConditioner = null;
        private MusicSystem _musicSystem = null;
        private HomeSecurity _homeSecurity = null;

        public HomeFacade()
        {
            _lights = new Lights();
            _airConditioner = new AirConditioner();
            _musicSystem = new MusicSystem();
            _homeSecurity = new HomeSecurity();
        }

        public void ArriveAtHome()
        {
            _lights.TurnOnLights();
            _musicSystem.TurnOnMusicSystem();
            _airConditioner.TurnOnAirConditioner();
            _homeSecurity.TurnOffHomeSecurity();
        }

        public void LeaveFromHome()
        {
            _lights.TurnOffLights();
            _musicSystem.TurnOffMusicSystem();
            _airConditioner.TurnOffAirConditioner();
            _homeSecurity.TurnOnHomeSecurity();
        }
    }
}
