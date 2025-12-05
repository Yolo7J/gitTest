namespace MyMvcApp.Constants
{
    public static class UnitConstants
    {
        // Unit Types
        public const string TYPE_MILITARY = "Military";
        public const string TYPE_CIVILIAN = "Civilian";
        public const string TYPE_SUPPORT = "Support";
        public const string TYPE_RELIGIOUS = "Religious";
        public const string TYPE_GREAT_PERSON = "GreatPerson";

        // Unit Classes
        public const string CLASS_MELEE = "Melee";
        public const string CLASS_RANGED = "Ranged";
        public const string CLASS_CAVALRY = "Cavalry";
        public const string CLASS_SIEGE = "Siege";
        public const string CLASS_NAVAL_MELEE = "NavalMelee";
        public const string CLASS_NAVAL_RANGED = "NavalRanged";
        public const string CLASS_NAVAL_RAIDER = "NavalRaider";
        public const string CLASS_NAVAL_CARRIER = "NavalCarrier";
        public const string CLASS_AIR_FIGHTER = "AirFighter";
        public const string CLASS_AIR_BOMBER = "AirBomber";
        public const string CLASS_RECON = "Recon";
        public const string CLASS_ANTI_CAVALRY = "AntiCavalry";

        // Movement Types
        public const string MOVEMENT_LAND = "Land";
        public const string MOVEMENT_WATER = "Water";
        public const string MOVEMENT_AIR = "Air";

        // Promotion Levels
        public const int MAX_PROMOTIONS = 7;
        public const int PROMOTION_XP_BASE = 15;
        public const int PROMOTION_XP_MULTIPLIER = 2;

        // Combat Modifiers
        public const int FLANKING_BONUS = 2;
        public const int SUPPORT_BONUS = 2;
        public const int FORTIFIED_BONUS = 3;
    }
}
