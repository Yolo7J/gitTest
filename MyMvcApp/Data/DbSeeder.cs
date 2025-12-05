using Microsoft.EntityFrameworkCore;
using MyMvcApp.Constants;
using MyMvcApp.Models;

namespace MyMvcApp.Data
{
    public static class DbSeeder
    {
        public static void SeedDatabase(CivilizationDbContext context)
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Check if already seeded
            if (context.Civilizations.Any())
            {
                return; // Database already seeded
            }

            SeedCivilizations(context);
            SeedLeaders(context);
            SeedTechnologies(context);
            SeedCivicCards(context);
            SeedUnits(context);
            SeedBuildings(context);
            SeedWonders(context);
            SeedResources(context);
            SeedTerrains(context);

            context.SaveChanges();
        }

        private static void SeedCivilizations(CivilizationDbContext context)
        {
            var civilizations = new[]
            {
                new Civilization
                {
                    Name = "Rome",
                    UniqueAbility = "All Roads Lead to Rome",
                    PrimaryColor = "#8B0000",
                    SecondaryColor = "#FFD700",
                    StartingBias = CivilizationConstants.BIAS_COASTAL,
                    UniqueUnit = "Legion",
                    UniqueInfrastructure = "Bath",
                    IsExpansion = false
                },
                new Civilization
                {
                    Name = "Greece",
                    UniqueAbility = "Plato's Republic",
                    PrimaryColor = "#0000CD",
                    SecondaryColor = "#FFFFFF",
                    StartingBias = CivilizationConstants.BIAS_COASTAL,
                    UniqueUnit = "Hoplite",
                    UniqueInfrastructure = "Acropolis",
                    IsExpansion = false
                },
                new Civilization
                {
                    Name = "Egypt",
                    UniqueAbility = "Iteru",
                    PrimaryColor = "#FFD700",
                    SecondaryColor = "#0000FF",
                    StartingBias = CivilizationConstants.BIAS_RIVER,
                    UniqueUnit = "Maryannu Chariot Archer",
                    UniqueInfrastructure = "Sphinx",
                    IsExpansion = false
                },
                new Civilization
                {
                    Name = "China",
                    UniqueAbility = "Dynastic Cycles",
                    PrimaryColor = "#FF0000",
                    SecondaryColor = "#FFD700",
                    StartingBias = CivilizationConstants.BIAS_RIVER,
                    UniqueUnit = "Crouching Tiger",
                    UniqueInfrastructure = "Great Wall",
                    IsExpansion = false
                },
                new Civilization
                {
                    Name = "Japan",
                    UniqueAbility = "Meiji Restoration",
                    PrimaryColor = "#FFFFFF",
                    SecondaryColor = "#DC143C",
                    StartingBias = CivilizationConstants.BIAS_COASTAL,
                    UniqueUnit = "Samurai",
                    UniqueInfrastructure = "Electronics Factory",
                    IsExpansion = false
                }
            };

            context.Civilizations.AddRange(civilizations);
            context.SaveChanges();
        }

        private static void SeedLeaders(CivilizationDbContext context)
        {
            var rome = context.Civilizations.First(c => c.Name == "Rome");
            var greece = context.Civilizations.First(c => c.Name == "Greece");
            var egypt = context.Civilizations.First(c => c.Name == "Egypt");
            var china = context.Civilizations.First(c => c.Name == "China");
            var japan = context.Civilizations.First(c => c.Name == "Japan");

            var leaders = new[]
            {
                new Leader
                {
                    Name = "Trajan",
                    LeaderAbility = "Trajan's Column",
                    Agenda = "Optimus Princeps",
                    AgendaDescription = "Tries to have the most territory. Likes civilizations with large empires.",
                    UniqueUnit = "Legion",
                    UniqueBuilding = "Bath",
                    LeaderDifficulty = 5,
                    IsAlternate = false,
                    CivilizationId = rome.CivilizationId
                },
                new Leader
                {
                    Name = "Pericles",
                    LeaderAbility = "Surrounded by Glory",
                    Agenda = "Delian League",
                    AgendaDescription = "Tries to have the most City-States as allies. Likes those who do not compete for City-State allegiance.",
                    UniqueUnit = "Hoplite",
                    UniqueBuilding = "Acropolis",
                    LeaderDifficulty = 4,
                    IsAlternate = false,
                    CivilizationId = greece.CivilizationId
                },
                new Leader
                {
                    Name = "Cleopatra",
                    LeaderAbility = "Mediterranean's Bride",
                    Agenda = "Queen of the Nile",
                    AgendaDescription = "Tries to make Egypt rich and build many Wonders. Likes civilizations with strong militaries.",
                    UniqueUnit = "Maryannu Chariot Archer",
                    UniqueBuilding = "Sphinx",
                    LeaderDifficulty = 6,
                    IsAlternate = false,
                    CivilizationId = egypt.CivilizationId
                },
                new Leader
                {
                    Name = "Qin Shi Huang",
                    LeaderAbility = "The First Emperor",
                    Agenda = "Mandate of Heaven",
                    AgendaDescription = "Tries to earn as many Eurekas and Inspirations as possible. Likes civilizations that do the same.",
                    UniqueUnit = "Crouching Tiger",
                    UniqueBuilding = "Great Wall",
                    LeaderDifficulty = 7,
                    IsAlternate = false,
                    CivilizationId = china.CivilizationId
                },
                new Leader
                {
                    Name = "Hojo Tokimune",
                    LeaderAbility = "Divine Wind",
                    Agenda = "Bushido",
                    AgendaDescription = "Builds units with strong military and cultural abilities. Likes civilizations with both.",
                    UniqueUnit = "Samurai",
                    UniqueBuilding = "Electronics Factory",
                    LeaderDifficulty = 5,
                    IsAlternate = false,
                    CivilizationId = japan.CivilizationId
                }
            };

            context.Leaders.AddRange(leaders);
            context.SaveChanges();
        }

        private static void SeedTechnologies(CivilizationDbContext context)
        {
            var technologies = new[]
            {
                new Technology
                {
                    Name = "Pottery",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    ResearchCost = 25,
                    Description = "The art of shaping clay into useful vessels",
                    Prerequisites = "",
                    UnlocksUnits = "",
                    UnlocksBuildings = "Granary",
                    UnlocksImprovements = "",
                    IsBoostable = true,
                    BoostCondition = "Found a City",
                    BoostPercentage = 50,
                    IsLeafTech = false
                },
                new Technology
                {
                    Name = "Animal Husbandry",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    ResearchCost = 25,
                    Description = "The domestication of animals for food and labor",
                    Prerequisites = "",
                    UnlocksUnits = "Heavy Chariot",
                    UnlocksBuildings = "Pasture",
                    UnlocksImprovements = "Pasture",
                    IsBoostable = true,
                    BoostCondition = "Find a Camp or Pasture resource",
                    BoostPercentage = 50,
                    IsLeafTech = false
                },
                new Technology
                {
                    Name = "Mining",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    ResearchCost = 25,
                    Description = "The extraction of minerals from the earth",
                    Prerequisites = "",
                    UnlocksUnits = "",
                    UnlocksBuildings = "",
                    UnlocksImprovements = "Mine",
                    IsBoostable = true,
                    BoostCondition = "Find a Mine or Quarry resource",
                    BoostPercentage = 50,
                    IsLeafTech = false
                },
                new Technology
                {
                    Name = "Bronze Working",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    ResearchCost = 50,
                    Description = "The smelting of bronze for tools and weapons",
                    Prerequisites = "Mining",
                    UnlocksUnits = "Spearman",
                    UnlocksBuildings = "Barracks",
                    UnlocksImprovements = "",
                    IsBoostable = true,
                    BoostCondition = "Kill 3 Barbarians",
                    BoostPercentage = 50,
                    IsLeafTech = false
                },
                new Technology
                {
                    Name = "The Wheel",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    ResearchCost = 50,
                    Description = "The invention of the wheel for transportation",
                    Prerequisites = "Mining",
                    UnlocksUnits = "Heavy Chariot, Water Mill",
                    UnlocksBuildings = "",
                    UnlocksImprovements = "",
                    IsBoostable = true,
                    BoostCondition = "Mine a resource",
                    BoostPercentage = 50,
                    IsLeafTech = false
                }
            };

            context.Technologies.AddRange(technologies);
            context.SaveChanges();
        }

        private static void SeedCivicCards(CivilizationDbContext context)
        {
            var civics = new[]
            {
                new CivicCard
                {
                    Name = "Code of Laws",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    CultureCost = 1,
                    Description = "The first set of written laws",
                    Prerequisites = "",
                    CardType = CivicConstants.CARD_ECONOMIC,
                    Effect = "Unlocks first government",
                    IsBoostable = false,
                    BoostCondition = "",
                    BoostPercentage = 0,
                    UnlocksGovernments = "Chiefdom",
                    UnlocksPolicies = "Discipline, Urban Planning"
                },
                new CivicCard
                {
                    Name = "Craftsmanship",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    CultureCost = 40,
                    Description = "The development of skilled trades",
                    Prerequisites = "Code of Laws",
                    CardType = CivicConstants.CARD_ECONOMIC,
                    Effect = "+100% Industrial Zone adjacency bonuses",
                    IsBoostable = true,
                    BoostCondition = "Improve 3 tiles",
                    BoostPercentage = 50,
                    UnlocksGovernments = "",
                    UnlocksPolicies = "Agoge, Colonization"
                },
                new CivicCard
                {
                    Name = "Foreign Trade",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    CultureCost = 40,
                    Description = "Trade between different civilizations",
                    Prerequisites = "Code of Laws",
                    CardType = CivicConstants.CARD_ECONOMIC,
                    Effect = "Gain +1 Trade Route capacity",
                    IsBoostable = true,
                    BoostCondition = "Discover a second continent",
                    BoostPercentage = 50,
                    UnlocksGovernments = "",
                    UnlocksPolicies = "Caravansaries, Triangular Trade"
                }
            };

            context.CivicCards.AddRange(civics);
            context.SaveChanges();
        }

        private static void SeedUnits(CivilizationDbContext context)
        {
            var units = new[]
            {
                new Unit
                {
                    Name = "Warrior",
                    UnitType = UnitConstants.TYPE_MILITARY,
                    UnitClass = UnitConstants.CLASS_MELEE,
                    CombatStrength = 20,
                    RangedStrength = 0,
                    Range = 0,
                    Movement = 2,
                    ProductionCost = 40,
                    MaintenanceCost = 1,
                    Era = TechnologyConstants.ERA_ANCIENT,
                    RequiredTechnology = "",
                    RequiredCivic = "",
                    IsUnique = false,
                    CanEmbark = true,
                    SpecialAbilities = "Basic melee unit"
                },
                new Unit
                {
                    Name = "Spearman",
                    UnitType = UnitConstants.TYPE_MILITARY,
                    UnitClass = UnitConstants.CLASS_ANTI_CAVALRY,
                    CombatStrength = 25,
                    RangedStrength = 0,
                    Range = 0,
                    Movement = 2,
                    ProductionCost = 65,
                    MaintenanceCost = 1,
                    Era = TechnologyConstants.ERA_ANCIENT,
                    RequiredTechnology = "Bronze Working",
                    RequiredCivic = "",
                    IsUnique = false,
                    CanEmbark = true,
                    SpecialAbilities = "+10 Combat Strength vs. Cavalry"
                },
                new Unit
                {
                    Name = "Archer",
                    UnitType = UnitConstants.TYPE_MILITARY,
                    UnitClass = UnitConstants.CLASS_RANGED,
                    CombatStrength = 15,
                    RangedStrength = 25,
                    Range = 2,
                    Movement = 2,
                    ProductionCost = 60,
                    MaintenanceCost = 1,
                    Era = TechnologyConstants.ERA_ANCIENT,
                    RequiredTechnology = "Archery",
                    RequiredCivic = "",
                    IsUnique = false,
                    CanEmbark = true,
                    SpecialAbilities = "Ranged attack"
                },
                new Unit
                {
                    Name = "Settler",
                    UnitType = UnitConstants.TYPE_CIVILIAN,
                    UnitClass = "Settler",
                    CombatStrength = 0,
                    RangedStrength = 0,
                    Range = 0,
                    Movement = 2,
                    ProductionCost = 80,
                    MaintenanceCost = 0,
                    Era = TechnologyConstants.ERA_ANCIENT,
                    RequiredTechnology = "",
                    RequiredCivic = "",
                    IsUnique = false,
                    CanEmbark = true,
                    SpecialAbilities = "Builds new cities"
                },
                new Unit
                {
                    Name = "Builder",
                    UnitType = UnitConstants.TYPE_CIVILIAN,
                    UnitClass = "Builder",
                    CombatStrength = 0,
                    RangedStrength = 0,
                    Range = 0,
                    Movement = 2,
                    ProductionCost = 50,
                    MaintenanceCost = 0,
                    Era = TechnologyConstants.ERA_ANCIENT,
                    RequiredTechnology = "",
                    RequiredCivic = "",
                    IsUnique = false,
                    CanEmbark = true,
                    SpecialAbilities = "Builds improvements (3 charges)"
                }
            };

            context.Units.AddRange(units);
            context.SaveChanges();
        }

        private static void SeedBuildings(CivilizationDbContext context)
        {
            var buildings = new[]
            {
                new Building
                {
                    Name = "Campus",
                    BuildingType = BuildingConstants.TYPE_DISTRICT,
                    ProductionCost = 54,
                    MaintenanceCost = 1,
                    Description = "A district for scientific research",
                    FoodYield = 0,
                    ProductionYield = 0,
                    GoldYield = 0,
                    ScienceYield = 2,
                    CultureYield = 0,
                    FaithYield = 0,
                    RequiredTechnology = "Writing",
                    RequiredCivic = "",
                    RequiredDistrict = "",
                    SpecialAbilities = "+1 Science for every 2 adjacent Mountains",
                    IsUnique = false,
                    Era = TechnologyConstants.ERA_ANCIENT
                },
                new Building
                {
                    Name = "Holy Site",
                    BuildingType = BuildingConstants.TYPE_DISTRICT,
                    ProductionCost = 54,
                    MaintenanceCost = 1,
                    Description = "A district for religious worship",
                    FoodYield = 0,
                    ProductionYield = 0,
                    GoldYield = 0,
                    ScienceYield = 0,
                    CultureYield = 0,
                    FaithYield = 2,
                    RequiredTechnology = "",
                    RequiredCivic = "Mysticism",
                    RequiredDistrict = "",
                    SpecialAbilities = "+1 Faith for every 2 adjacent Mountains",
                    IsUnique = false,
                    Era = TechnologyConstants.ERA_ANCIENT
                },
                new Building
                {
                    Name = "Granary",
                    BuildingType = BuildingConstants.TYPE_BUILDING,
                    ProductionCost = 65,
                    MaintenanceCost = 1,
                    Description = "Storage for grain and food",
                    FoodYield = 2,
                    ProductionYield = 0,
                    GoldYield = 0,
                    ScienceYield = 0,
                    CultureYield = 0,
                    FaithYield = 0,
                    RequiredTechnology = "Pottery",
                    RequiredCivic = "",
                    RequiredDistrict = "",
                    SpecialAbilities = "+1 Food from each Wheat, Rice, and Maize",
                    IsUnique = false,
                    Era = TechnologyConstants.ERA_ANCIENT
                },
                new Building
                {
                    Name = "Monument",
                    BuildingType = BuildingConstants.TYPE_BUILDING,
                    ProductionCost = 60,
                    MaintenanceCost = 1,
                    Description = "A symbol of civic pride",
                    FoodYield = 0,
                    ProductionYield = 0,
                    GoldYield = 0,
                    ScienceYield = 0,
                    CultureYield = 2,
                    FaithYield = 0,
                    RequiredTechnology = "",
                    RequiredCivic = "",
                    RequiredDistrict = "",
                    SpecialAbilities = "Increases territorial growth",
                    IsUnique = false,
                    Era = TechnologyConstants.ERA_ANCIENT
                }
            };

            context.Buildings.AddRange(buildings);
            context.SaveChanges();
        }

        private static void SeedWonders(CivilizationDbContext context)
        {
            var wonders = new[]
            {
                new Wonder
                {
                    Name = "Pyramids",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    ProductionCost = 400,
                    Description = "One of the Seven Wonders of the Ancient World",
                    Effect = "Grants a free Builder. +2 Culture. Builders get +1 build charge.",
                    RequiredTechnology = "Masonry",
                    RequiredCivic = "",
                    RequiredTerrain = "Desert or Floodplains",
                    GreatPersonPoints = 0,
                    GreatPersonType = "",
                    IsNaturalWonder = false,
                    IsObsolete = false,
                    ObsoleteEra = "",
                    TourismYield = 4,
                    PlacementRequirements = "Must be built on Desert or Floodplains",
                    IsBuildable = true
                },
                new Wonder
                {
                    Name = "Stonehenge",
                    Era = TechnologyConstants.ERA_ANCIENT,
                    ProductionCost = 400,
                    Description = "Ancient megalithic monument",
                    Effect = "Grants a free Great Prophet. +2 Faith.",
                    RequiredTechnology = "",
                    RequiredCivic = "Astrology",
                    RequiredTerrain = "Flat land",
                    GreatPersonPoints = 0,
                    GreatPersonType = "Great Prophet",
                    IsNaturalWonder = false,
                    IsObsolete = false,
                    ObsoleteEra = "",
                    TourismYield = 4,
                    PlacementRequirements = "Must be built on flat land adjacent to Stone",
                    IsBuildable = true
                },
                new Wonder
                {
                    Name = "Great Library",
                    Era = TechnologyConstants.ERA_CLASSICAL,
                    ProductionCost = 400,
                    Description = "Repository of ancient knowledge",
                    Effect = "Grants 2 random Technologies. +2 Science. +1 Great Scientist point per turn.",
                    RequiredTechnology = "Writing",
                    RequiredCivic = "",
                    RequiredTerrain = "Must be adjacent to Campus",
                    GreatPersonPoints = 2,
                    GreatPersonType = "Great Scientist",
                    IsNaturalWonder = false,
                    IsObsolete = false,
                    ObsoleteEra = "",
                    TourismYield = 4,
                    PlacementRequirements = "Must be built adjacent to a Campus with a Library",
                    IsBuildable = true
                }
            };

            context.Wonders.AddRange(wonders);
            context.SaveChanges();
        }

        private static void SeedResources(CivilizationDbContext context)
        {
            var resources = new[]
            {
                new Resource
                {
                    Name = "Wheat",
                    ResourceType = ResourceConstants.TYPE_BONUS,
                    Description = "Staple grain crop",
                    FoodYield = 1,
                    ProductionYield = 0,
                    GoldYield = 0,
                    ScienceYield = 0,
                    CultureYield = 0,
                    FaithYield = 0,
                    ImprovedBy = "Farm",
                    RequiredTechnology = "",
                    ValidTerrain = "Plains, Floodplains",
                    ProvidesAmenity = false,
                    AmenityValue = 0,
                    AccumulationRate = 0,
                    UsedFor = "Food production",
                    IsHarvestable = true
                },
                new Resource
                {
                    Name = "Iron",
                    ResourceType = ResourceConstants.TYPE_STRATEGIC,
                    Description = "Essential metal for warfare",
                    FoodYield = 0,
                    ProductionYield = 1,
                    GoldYield = 0,
                    ScienceYield = 0,
                    CultureYield = 0,
                    FaithYield = 0,
                    ImprovedBy = "Mine",
                    RequiredTechnology = "Bronze Working",
                    ValidTerrain = "Hills, Plains",
                    ProvidesAmenity = false,
                    AmenityValue = 0,
                    AccumulationRate = ResourceConstants.ACCUMULATION_IRON,
                    UsedFor = "Required for Swordsman, Legion, etc.",
                    IsHarvestable = false
                },
                new Resource
                {
                    Name = "Spices",
                    ResourceType = ResourceConstants.TYPE_LUXURY,
                    Description = "Exotic flavoring and preservative",
                    FoodYield = 0,
                    ProductionYield = 0,
                    GoldYield = 2,
                    ScienceYield = 0,
                    CultureYield = 0,
                    FaithYield = 0,
                    ImprovedBy = "Plantation",
                    RequiredTechnology = "",
                    ValidTerrain = "Jungle, Rainforest",
                    ProvidesAmenity = true,
                    AmenityValue = ResourceConstants.AMENITY_LUXURY,
                    AccumulationRate = 0,
                    UsedFor = "Provides amenities to cities",
                    IsHarvestable = false
                },
                new Resource
                {
                    Name = "Horses",
                    ResourceType = ResourceConstants.TYPE_STRATEGIC,
                    Description = "Mounts for cavalry units",
                    FoodYield = 1,
                    ProductionYield = 1,
                    GoldYield = 0,
                    ScienceYield = 0,
                    CultureYield = 0,
                    FaithYield = 0,
                    ImprovedBy = "Pasture",
                    RequiredTechnology = "Animal Husbandry",
                    ValidTerrain = "Plains, Grassland",
                    ProvidesAmenity = false,
                    AmenityValue = 0,
                    AccumulationRate = ResourceConstants.ACCUMULATION_HORSES,
                    UsedFor = "Required for Horseman, Knight, etc.",
                    IsHarvestable = false
                }
            };

            context.Resources.AddRange(resources);
            context.SaveChanges();
        }

        private static void SeedTerrains(CivilizationDbContext context)
        {
            var terrains = new[]
            {
                new Terrain
                {
                    Name = "Grassland",
                    TerrainType = TerrainConstants.TYPE_GRASSLAND,
                    Description = "Fertile plains covered with grass",
                    FoodYield = 2,
                    ProductionYield = 0,
                    GoldYield = 0,
                    MovementCost = TerrainConstants.MOVEMENT_FLAT,
                    DefenseBonus = 0,
                    IsWater = false,
                    IsImpassable = false,
                    Features = "Can have Forest, Marsh, Floodplains",
                    AppealModifier = 0,
                    ValidResources = "Wheat, Cattle, Sheep, Horses",
                    ValidImprovements = "Farm, Pasture",
                    ProvidesWater = false,
                    ClimateZone = TerrainConstants.CLIMATE_TEMPERATE
                },
                new Terrain
                {
                    Name = "Plains",
                    TerrainType = TerrainConstants.TYPE_PLAINS,
                    Description = "Flat, open terrain",
                    FoodYield = 1,
                    ProductionYield = 1,
                    GoldYield = 0,
                    MovementCost = TerrainConstants.MOVEMENT_FLAT,
                    DefenseBonus = 0,
                    IsWater = false,
                    IsImpassable = false,
                    Features = "Can have Forest, Floodplains",
                    AppealModifier = 0,
                    ValidResources = "Wheat, Iron, Horses",
                    ValidImprovements = "Farm, Mine, Pasture",
                    ProvidesWater = false,
                    ClimateZone = TerrainConstants.CLIMATE_TEMPERATE
                },
                new Terrain
                {
                    Name = "Desert",
                    TerrainType = TerrainConstants.TYPE_DESERT,
                    Description = "Arid, sandy terrain",
                    FoodYield = 0,
                    ProductionYield = 0,
                    GoldYield = 0,
                    MovementCost = TerrainConstants.MOVEMENT_FLAT,
                    DefenseBonus = 0,
                    IsWater = false,
                    IsImpassable = false,
                    Features = "Can have Floodplains, Oasis",
                    AppealModifier = -1,
                    ValidResources = "Wheat (floodplains), Oil",
                    ValidImprovements = "Farm (floodplains)",
                    ProvidesWater = false,
                    ClimateZone = TerrainConstants.CLIMATE_TROPICAL
                },
                new Terrain
                {
                    Name = "Hills",
                    TerrainType = "Hills",
                    Description = "Elevated terrain",
                    FoodYield = 0,
                    ProductionYield = 1,
                    GoldYield = 0,
                    MovementCost = TerrainConstants.MOVEMENT_HILLS,
                    DefenseBonus = TerrainConstants.DEFENSE_HILLS,
                    IsWater = false,
                    IsImpassable = false,
                    Features = "Can have Forest",
                    AppealModifier = 0,
                    ValidResources = "Iron, Copper, Stone",
                    ValidImprovements = "Mine, Terrace Farm",
                    ProvidesWater = false,
                    ClimateZone = "Any"
                },
                new Terrain
                {
                    Name = "Coast",
                    TerrainType = TerrainConstants.TYPE_COAST,
                    Description = "Shallow water near land",
                    FoodYield = 1,
                    ProductionYield = 0,
                    GoldYield = 1,
                    MovementCost = TerrainConstants.MOVEMENT_FLAT,
                    DefenseBonus = 0,
                    IsWater = true,
                    IsImpassable = false,
                    Features = "Can have Reef",
                    AppealModifier = 0,
                    ValidResources = "Fish, Crabs, Pearls",
                    ValidImprovements = "Fishing Boats",
                    ProvidesWater = true,
                    ClimateZone = "Any"
                }
            };

            context.Terrains.AddRange(terrains);
            context.SaveChanges();
        }
    }
}
