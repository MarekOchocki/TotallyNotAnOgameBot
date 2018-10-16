namespace TotallyNotAnOgameBot.Data.Defenses
{
    public class DefenseState
    {
        public Defense RocletLauncher;
        public Defense LightLaser;
        public Defense HeavyLaser;
        public Defense GaussCannon;
        public Defense IonCannon;
        public Defense PlasmaTurret;
        public Defense SmallShieldDome;
        public Defense LargeShieldDome;
        public Defense AntiBalisticMissiles;
        public Defense InterplanetaryMissiles;

        public DefenseState()
        {
            RocletLauncher = new Defense(Defense.Type.RocletLauncher, 0);
            LightLaser = new Defense(Defense.Type.LightLaser, 0);
            HeavyLaser = new Defense(Defense.Type.HeavyLaser, 0);
            GaussCannon = new Defense(Defense.Type.GaussCannon, 0);
            IonCannon = new Defense(Defense.Type.IonCannon, 0);
            PlasmaTurret = new Defense(Defense.Type.PlasmaTurret, 0);
            SmallShieldDome = new Defense(Defense.Type.SmallShieldDome, 0);
            LargeShieldDome = new Defense(Defense.Type.LargeShieldDome, 0);
            AntiBalisticMissiles = new Defense(Defense.Type.AntiBalisticMissiles, 0);
            InterplanetaryMissiles = new Defense(Defense.Type.InterplanetaryMissiles, 0);
        }
    }
}
