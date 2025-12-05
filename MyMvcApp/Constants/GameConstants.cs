namespace MyMvcApp.Constants
{
    public static class GameConstants
    {
        // City Limits
        public const int MAX_CITIES_PER_CIVILIZATION = 999;
        public const int STARTING_CITIES = 1;
        public const int MAX_CITY_POPULATION = 999;

        // Unit Limits
        public const int MAX_UNITS_PER_TILE = 1;
        public const int MAX_CIVILIAN_UNITS_PER_TILE = 1;
        public const int UNIT_SUPPLY_BASE = 5;

        // District Limits
        public const int MAX_DISTRICTS_PER_CITY = 13;
        public const int DISTRICT_COST_INCREASE_PERCENT = 15;

        // Turn Limits
        public const int TURNS_ANCIENT = 75;
        public const int TURNS_CLASSICAL = 50;
        public const int TURNS_MEDIEVAL = 60;
        public const int TURNS_RENAISSANCE = 50;
        public const int TURNS_INDUSTRIAL = 50;
        public const int TURNS_MODERN = 50;
        public const int TURNS_ATOMIC = 50;
        public const int TURNS_INFORMATION = 50;

        // Combat
        public const int MAX_COMBAT_STRENGTH = 200;
        public const int MIN_COMBAT_STRENGTH = 0;
        public const int COMBAT_DAMAGE_MAX = 100;

        // Age System
        public const int DARK_AGE_THRESHOLD = 0;
        public const int NORMAL_AGE_THRESHOLD = 12;
        public const int GOLDEN_AGE_THRESHOLD = 24;
        public const int HEROIC_AGE_THRESHOLD = 36;

        // Loyalty
        public const int LOYALTY_MAX = 100;
        public const int LOYALTY_MIN = 0;
        public const int LOYALTY_REBEL_THRESHOLD = 0;
        public const int LOYALTY_PRESSURE_RANGE = 9;

        // Great People
        public const int GREAT_PEOPLE_TYPES = 8;
        public const int GREAT_PERSON_POINTS_PER_TURN = 1;

        // Trade Routes
        public const int STARTING_TRADE_ROUTES = 1;
        public const int MAX_TRADE_ROUTES = 30;
        public const int TRADE_ROUTE_RANGE_DOMESTIC = 15;
        public const int TRADE_ROUTE_RANGE_INTERNATIONAL = 30;
    }
}
