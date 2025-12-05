namespace MyMvcApp.Constants
{
    public static class CivicConstants
    {
        // Civic Card Types
        public const string CARD_ECONOMIC = "Economic";
        public const string CARD_MILITARY = "Military";
        public const string CARD_DIPLOMATIC = "Diplomatic";
        public const string CARD_WILDCARD = "Wildcard";
        public const string CARD_GREAT_PERSON = "GreatPerson";

        // Government Types
        public const string GOVERNMENT_CHIEFDOM = "Chiefdom";
        public const string GOVERNMENT_AUTOCRACY = "Autocracy";
        public const string GOVERNMENT_OLIGARCHY = "Oligarchy";
        public const string GOVERNMENT_CLASSICAL_REPUBLIC = "ClassicalRepublic";
        public const string GOVERNMENT_MONARCHY = "Monarchy";
        public const string GOVERNMENT_THEOCRACY = "Theocracy";
        public const string GOVERNMENT_MERCHANT_REPUBLIC = "MerchantRepublic";
        public const string GOVERNMENT_DEMOCRACY = "Democracy";
        public const string GOVERNMENT_COMMUNISM = "Communism";
        public const string GOVERNMENT_FASCISM = "Fascism";

        // Government Slot Types
        public const int SLOTS_CHIEFDOM_MILITARY = 1;
        public const int SLOTS_CHIEFDOM_ECONOMIC = 1;
        public const int SLOTS_AUTOCRACY_MILITARY = 2;
        public const int SLOTS_AUTOCRACY_ECONOMIC = 1;
        public const int SLOTS_OLIGARCHY_MILITARY = 3;
        public const int SLOTS_DEMOCRACY_ECONOMIC = 3;
        public const int SLOTS_DEMOCRACY_DIPLOMATIC = 2;

        // Boost Mechanics
        public const int CIVIC_BOOST_PERCENTAGE = 50;
        public const int BASE_CULTURE_COST = 25;
        public const double ERA_COST_MULTIPLIER = 1.5;

        // Legacy Bonuses
        public const int LEGACY_BONUS_SLOTS = 1;
        public const int ANCIENT_LEGACY_SLOT = 1;
        public const int CLASSICAL_LEGACY_SLOT = 2;
    }
}
