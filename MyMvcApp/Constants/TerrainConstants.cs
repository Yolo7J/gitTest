namespace MyMvcApp.Constants
{
    public static class TerrainConstants
    {
        // Terrain Types
        public const string TYPE_GRASSLAND = "Grassland";
        public const string TYPE_PLAINS = "Plains";
        public const string TYPE_DESERT = "Desert";
        public const string TYPE_TUNDRA = "Tundra";
        public const string TYPE_SNOW = "Snow";
        public const string TYPE_COAST = "Coast";
        public const string TYPE_OCEAN = "Ocean";

        // Terrain Features
        public const string FEATURE_FOREST = "Forest";
        public const string FEATURE_JUNGLE = "Jungle";
        public const string FEATURE_MARSH = "Marsh";
        public const string FEATURE_FLOODPLAINS = "Floodplains";
        public const string FEATURE_OASIS = "Oasis";
        public const string FEATURE_REEF = "Reef";
        public const string FEATURE_ICE = "Ice";
        public const string FEATURE_MOUNTAINS = "Mountains";
        public const string FEATURE_HILLS = "Hills";

        // Movement Costs
        public const int MOVEMENT_FLAT = 1;
        public const int MOVEMENT_HILLS = 2;
        public const int MOVEMENT_FOREST = 2;
        public const int MOVEMENT_JUNGLE = 2;
        public const int MOVEMENT_MARSH = 2;
        public const int MOVEMENT_MOUNTAINS = 99; // Impassable

        // Defense Bonuses
        public const int DEFENSE_HILLS = 3;
        public const int DEFENSE_FOREST = 3;
        public const int DEFENSE_JUNGLE = 3;
        public const int DEFENSE_MARSH = -2;

        // Appeal Modifiers
        public const int APPEAL_MOUNTAINS_ADJACENT = 1;
        public const int APPEAL_FOREST = 1;
        public const int APPEAL_MARSH = -1;
        public const int APPEAL_JUNGLE = -1;

        // Climate Zones
        public const string CLIMATE_TROPICAL = "Tropical";
        public const string CLIMATE_TEMPERATE = "Temperate";
        public const string CLIMATE_POLAR = "Polar";
    }
}
