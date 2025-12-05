# Civilization VI Backend Models

This project contains a comprehensive set of entity models and constants for a Civilization VI themed application.

## Entities (10 Total)

### Core Game Entities
1. **Civilization** - Represents playable civilizations with unique abilities, colors, and starting biases
2. **Leader** - Civilization leaders with traits, agendas, and unique bonuses
3. **City** - Cities with population, yields (food, production, gold, science, culture, faith), and districts

### Military & Units
4. **Unit** - Military and civilian units with combat strength, movement, and special abilities

### Progression Systems
5. **Technology** - Technology tree with eras, costs, prerequisites, and boost mechanics
6. **CivicCard** - Civic cards and government policies with effects and unlocks

### Infrastructure
7. **Building** - City buildings and districts with yields and requirements
8. **Wonder** - World and natural wonders with unique bonuses

### Map Elements
9. **Resource** - Strategic, luxury, and bonus resources with yields and amenities
10. **Terrain** - Terrain types with movement costs, yields, and features

## Constants Folder

The Constants folder contains 7 constant classes:

1. **CivilizationConstants** - Civilization types, starting biases, difficulties, victory types
2. **UnitConstants** - Unit types, classes, movement types, combat modifiers
3. **TechnologyConstants** - Eras, categories, boost percentages, research costs
4. **BuildingConstants** - Building types, districts, yields, maintenance
5. **ResourceConstants** - Resource types, specific resources, amenity values
6. **TerrainConstants** - Terrain types, features, movement costs, defense bonuses
7. **GameConstants** - General game mechanics, limits, age system, loyalty

## Features

- ✅ Proper C# naming conventions (PascalCase)
- ✅ Data annotations for validation
- ✅ Entity relationships (Foreign Keys & Navigation Properties)
- ✅ Comprehensive constants for game mechanics
- ✅ Well-organized folder structure
- ✅ Ready for Entity Framework Core integration

## Technology Stack

- ASP.NET Core MVC
- Entity Framework Core (ready for integration)
- C# 9.0+

## Next Steps

To use these entities:
1. Add Entity Framework Core NuGet packages
2. Create a DbContext class
3. Configure database connection in appsettings.json
4. Run migrations to create database schema
5. Create controllers and views for CRUD operations
