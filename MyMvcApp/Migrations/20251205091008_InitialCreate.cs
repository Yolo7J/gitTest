using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMvcApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CivicCards",
                columns: table => new
                {
                    CivicCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Era = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CultureCost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Prerequisites = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsBoostable = table.Column<bool>(type: "bit", nullable: false),
                    BoostCondition = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BoostPercentage = table.Column<int>(type: "int", nullable: false),
                    UnlocksGovernments = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnlocksPolicies = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivicCards", x => x.CivicCardId);
                });

            migrationBuilder.CreateTable(
                name: "Civilizations",
                columns: table => new
                {
                    CivilizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UniqueAbility = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PrimaryColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondaryColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartingBias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UniqueUnit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UniqueInfrastructure = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsExpansion = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Civilizations", x => x.CivilizationId);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResourceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FoodYield = table.Column<int>(type: "int", nullable: false),
                    ProductionYield = table.Column<int>(type: "int", nullable: false),
                    GoldYield = table.Column<int>(type: "int", nullable: false),
                    ScienceYield = table.Column<int>(type: "int", nullable: false),
                    CultureYield = table.Column<int>(type: "int", nullable: false),
                    FaithYield = table.Column<int>(type: "int", nullable: false),
                    ImprovedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequiredTechnology = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ValidTerrain = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ProvidesAmenity = table.Column<bool>(type: "bit", nullable: false),
                    AmenityValue = table.Column<int>(type: "int", nullable: false),
                    AccumulationRate = table.Column<int>(type: "int", nullable: false),
                    UsedFor = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsHarvestable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.ResourceId);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    TechnologyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Era = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResearchCost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Prerequisites = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnlocksUnits = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    UnlocksBuildings = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    UnlocksImprovements = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsBoostable = table.Column<bool>(type: "bit", nullable: false),
                    BoostCondition = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BoostPercentage = table.Column<int>(type: "int", nullable: false),
                    IsLeafTech = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.TechnologyId);
                });

            migrationBuilder.CreateTable(
                name: "Terrains",
                columns: table => new
                {
                    TerrainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TerrainType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FoodYield = table.Column<int>(type: "int", nullable: false),
                    ProductionYield = table.Column<int>(type: "int", nullable: false),
                    GoldYield = table.Column<int>(type: "int", nullable: false),
                    MovementCost = table.Column<int>(type: "int", nullable: false),
                    DefenseBonus = table.Column<int>(type: "int", nullable: false),
                    IsWater = table.Column<bool>(type: "bit", nullable: false),
                    IsImpassable = table.Column<bool>(type: "bit", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppealModifier = table.Column<int>(type: "int", nullable: false),
                    ValidResources = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ValidImprovements = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ProvidesWater = table.Column<bool>(type: "bit", nullable: false),
                    ClimateZone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terrains", x => x.TerrainId);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UnitType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CombatStrength = table.Column<int>(type: "int", nullable: false),
                    RangedStrength = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    Movement = table.Column<int>(type: "int", nullable: false),
                    ProductionCost = table.Column<int>(type: "int", nullable: false),
                    MaintenanceCost = table.Column<int>(type: "int", nullable: false),
                    Era = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequiredTechnology = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequiredCivic = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    CanEmbark = table.Column<bool>(type: "bit", nullable: false),
                    SpecialAbilities = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "Wonders",
                columns: table => new
                {
                    WonderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Era = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductionCost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RequiredTechnology = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequiredCivic = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequiredTerrain = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GreatPersonPoints = table.Column<int>(type: "int", nullable: false),
                    GreatPersonType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsNaturalWonder = table.Column<bool>(type: "bit", nullable: false),
                    IsObsolete = table.Column<bool>(type: "bit", nullable: false),
                    ObsoleteEra = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TourismYield = table.Column<int>(type: "int", nullable: false),
                    PlacementRequirements = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsBuildable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wonders", x => x.WonderId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    ProductionPerTurn = table.Column<int>(type: "int", nullable: false),
                    SciencePerTurn = table.Column<int>(type: "int", nullable: false),
                    CulturePerTurn = table.Column<int>(type: "int", nullable: false),
                    GoldPerTurn = table.Column<int>(type: "int", nullable: false),
                    FaithPerTurn = table.Column<int>(type: "int", nullable: false),
                    DistrictCount = table.Column<int>(type: "int", nullable: false),
                    IsCapital = table.Column<bool>(type: "bit", nullable: false),
                    HasWalls = table.Column<bool>(type: "bit", nullable: false),
                    DefenseStrength = table.Column<int>(type: "int", nullable: false),
                    FoundedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Era = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CivilizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Civilizations_CivilizationId",
                        column: x => x.CivilizationId,
                        principalTable: "Civilizations",
                        principalColumn: "CivilizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leaders",
                columns: table => new
                {
                    LeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LeaderAbility = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Agenda = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AgendaDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UniqueUnit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UniqueBuilding = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LeaderDifficulty = table.Column<int>(type: "int", nullable: false),
                    IsAlternate = table.Column<bool>(type: "bit", nullable: false),
                    CivilizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaders", x => x.LeaderId);
                    table.ForeignKey(
                        name: "FK_Leaders_Civilizations_CivilizationId",
                        column: x => x.CivilizationId,
                        principalTable: "Civilizations",
                        principalColumn: "CivilizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BuildingType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductionCost = table.Column<int>(type: "int", nullable: false),
                    MaintenanceCost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FoodYield = table.Column<int>(type: "int", nullable: false),
                    ProductionYield = table.Column<int>(type: "int", nullable: false),
                    GoldYield = table.Column<int>(type: "int", nullable: false),
                    ScienceYield = table.Column<int>(type: "int", nullable: false),
                    CultureYield = table.Column<int>(type: "int", nullable: false),
                    FaithYield = table.Column<int>(type: "int", nullable: false),
                    RequiredTechnology = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequiredCivic = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequiredDistrict = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SpecialAbilities = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    Era = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_Buildings_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_CityId",
                table: "Buildings",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CivilizationId",
                table: "Cities",
                column: "CivilizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name",
                table: "Cities",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_CivicCards_Era_Name",
                table: "CivicCards",
                columns: new[] { "Era", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Civilizations_Name",
                table: "Civilizations",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leaders_CivilizationId",
                table: "Leaders",
                column: "CivilizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaders_Name",
                table: "Leaders",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_Era_Name",
                table: "Technologies",
                columns: new[] { "Era", "Name" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "CivicCards");

            migrationBuilder.DropTable(
                name: "Leaders");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "Terrains");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Wonders");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Civilizations");
        }
    }
}
