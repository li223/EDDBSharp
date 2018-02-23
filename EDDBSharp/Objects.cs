using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EDDBSharp;
using System.Net.Http;

namespace EDDBSharp.Objects
{
    /// <summary>
    /// System info for all populated systems
    /// </summary>
    public class PopulatedSystem
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("edsm_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EdsmId { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("x")]
        internal double X { get; set; }

        [JsonProperty("y")]
        internal double Y { get; set; }

        [JsonProperty("z")]
        internal double Z { get; set; }

        [JsonIgnore]
        public (double, double, double) Location { get { return this.Location; } set { this.Location = (this.X, this.Y, this.Z); } }

        [JsonProperty("population", NullValueHandling = NullValueHandling.Ignore)]
        public long? Population { get; internal set; }

        [JsonProperty("is_populated")]
        public bool IsPopulated { get; internal set; }

        [JsonProperty("government_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? GovernmentId { get; internal set; }

        [JsonProperty("government")]
        public string Government { get; internal set; }

        [JsonProperty("allegiance_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllegianceId { get; internal set; }

        [JsonProperty("allegiance")]
        public string Allegiance { get; internal set; }

        [JsonProperty("state_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StateId { get; internal set; }

        [JsonProperty("state")]
        public string State { get; internal set; }

        [JsonProperty("security_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityId { get; internal set; }

        [JsonProperty("security")]
        public string Security { get; internal set; }

        [JsonProperty("primary_economy_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrimaryEconomyId { get; internal set; }

        [JsonProperty("primary_economy")]
        public string PrimaryEconomy { get; internal set; }

        [JsonProperty("power")]
        public string Power { get; internal set; }

        [JsonProperty("power_state")]
        public string PowerState { get; internal set; }

        [JsonProperty("power_state_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PowerStateId { get; internal set; }

        [JsonProperty("needs_permit")]
        public bool NeedsPermit { get; internal set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; internal set; }

        [JsonProperty("simbad_ref")]
        public string SimbadRef { get; internal set; }

        [JsonProperty("controlling_minor_faction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ControllingMinorFactionId { get; internal set; }

        [JsonProperty("controlling_minor_faction")]
        public string ControllingMinorFaction { get; internal set; }

        [JsonProperty("reserve_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReserveTypeId { get; internal set; }

        [JsonProperty("reserve_type")]
        public string ReserveType { get; internal set; }

        [JsonProperty("minor_faction_presences")]
        public IEnumerable<MinorFaction> MinorFactions { get; internal set; }
    }

    /// <summary>
    /// Information on each minor faction in a populated system
    /// </summary>
    public class MinorFaction
    {
        [JsonProperty("minor_faction_id")]
        public int Id { get; internal set; }

        [JsonProperty("state_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StateId { get; internal set; }

        [JsonProperty("influence", NullValueHandling = NullValueHandling.Ignore)]
        public double? Influence { get; internal set; }

        [JsonProperty("state")]
        public string State { get; internal set; }
    }

    /// <summary>
    /// Info on all stations in the game
    /// </summary>
    public class Station
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("system_id")]
        public int SystemId { get; set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; internal set; }

        [JsonProperty("max_landing_pad_size")]
        public string MaxLandingPadSize { get; internal set; }

        [JsonProperty("distance_to_star", NullValueHandling = NullValueHandling.Ignore)]
        public double? DistanceToStar { get; internal set; }

        [JsonProperty("government_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? GovernmentId { get; internal set; }

        [JsonProperty("government")]
        public string Government { get; internal set; }

        [JsonProperty("allegiance_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllegianceId { get; internal set; }

        [JsonProperty("allegiance")]
        public string Allegiance { get; internal set; }

        [JsonProperty("state_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StateId { get; internal set; }

        [JsonProperty("state")]
        public string State { get; internal set; }

        [JsonProperty("type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TypeId { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("has_blackmarket")]
        public bool HasBlackmarket { get; internal set; }

        [JsonProperty("has_market")]
        public bool HasMarket { get; internal set; }

        [JsonProperty("has_refuel")]
        public bool HasRefuel { get; internal set; }

        [JsonProperty("has_repair")]
        public bool HasRepair { get; internal set; }

        [JsonProperty("has_rearm")]
        public bool HasRearm { get; internal set; }

        [JsonProperty("has_outfitting")]
        public bool HasOutfitting { get; internal set; }

        [JsonProperty("has_shipyard")]
        public bool HasShipyard { get; internal set; }

        [JsonProperty("has_docking")]
        public bool HasDocking { get; internal set; }

        [JsonProperty("has_commodities")]
        public bool HasCommodities { get; internal set; }

        [JsonProperty("import_commodities")]
        public string[] ImportCommodities { get; internal set; }

        [JsonProperty("export_commodities")]
        public string[] ExportCommodities { get; internal set; }

        [JsonProperty("prohibited_commodities")]
        public string[] ProhibitedCommodities { get; internal set; }

        [JsonProperty("economies")]
        public string[] Economies { get; internal set; }

        [JsonProperty("shipyard_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShipyardUpdateAt { get; internal set; }

        [JsonProperty("outfitting_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? OutfittingUpdateAt { get; internal set; }

        [JsonProperty("market_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? MarketUpdatedAt { get; internal set; }

        [JsonProperty("is_planetary")]
        public bool IsPlanetary { get; internal set; }

        [JsonProperty("selling_ships")]
        public string[] SellingShips { get; internal set; }

        [JsonProperty("selling_modules")]
        public int[] SellingModulesIds { get; internal set; }

        [JsonProperty("settlement_size_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SettlementSizeId { get; internal set; }

        [JsonProperty("settlement_size")]
        public string SettlementSize { get; internal set; }

        [JsonProperty("settlement_security_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SettlementSecurityId { get; internal set; }

        [JsonProperty("settlement_security")]
        public string SettlementSecurity { get; internal set; }

        [JsonProperty("body_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? BodyId { get; internal set; }

        [JsonProperty("controlling_minor_faction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ControllingMinorFactionId { get; internal set; }
    }

    /// <summary>
    /// Info on various Commodities in the game
    /// </summary>
    public class Commodity
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("category_id")]
        public int CategoryId { get; internal set; }

        [JsonProperty("average_price")]
        public int AveragePrice { get; internal set; }

        [JsonProperty("is_rare")]
        public bool IsRare {  get; internal set; }

        [JsonProperty("max_buy_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBuyPrice { get; internal set; }

        [JsonProperty("max_sell_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSellPrice { get; internal set; }

        [JsonProperty("min_buy_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinBuyPrice { get; internal set; }

        [JsonProperty("min_sell_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinSellPrice { get; internal set; }

        [JsonProperty("buy_price_lower_average", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuyPriceLowerAverage { get; internal set; }

        [JsonProperty("sell_price_upper_average", NullValueHandling = NullValueHandling.Ignore)]
        public int? SellPriceUpperAverage { get; internal set; }

        [JsonProperty("is_non_marketable")]
        public bool IsNonMarketable { get; internal set; }

        [JsonProperty("ed_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EdId { get; internal set; }

        [JsonProperty("category")]
        public Category Category { get; internal set; }
    }

    /// <summary>
    /// Info on a ship module sold at a station
    /// </summary>
    public class Module
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("group_id")]
        public int GroupId { get; internal set; }

        [JsonProperty("class")]
        public int Class { get; internal set; }

        [JsonProperty("rating")]
        public char Rating { get; internal set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public int? Price { get; internal set; }

        [JsonProperty("weapon_mode")]
        public string WeaponMode { get; internal set; }

        [JsonProperty("missile_type")]
        public string MissileType { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("belongs_to")]
        public string BelongsTo { get; internal set; }

        [JsonProperty("ed_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EdId { get; internal set; }

        [JsonProperty("ed_symbol")]
        public string EdSymbol { get; internal set; }

        [JsonProperty("ship")]
        public string Ship { get; internal set; }

        [JsonProperty("group")]
        public Group Group { get; internal set; }
    }

    /// <summary>
    /// Planetary info
    /// </summary>
    public class PlanetBody
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; internal set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("system_id")]
        public int SystemId { get; internal set; }

        [JsonProperty("group_id")]
        public int GroupId { get; internal set; }

        [JsonProperty("group_name")]
        public string GroupName { get; internal set; }

        [JsonProperty("type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TypeId { get; internal set; }

        [JsonProperty("type_name")]
        public string TypeName { get; internal set; }

        [JsonProperty("distance_to_arrival", NullValueHandling = NullValueHandling.Ignore)]
        public double? DistanceToArrival { get; internal set; }

        [JsonProperty("full_spectral_class")]
        public string FullSpectralClass { get; internal set; }

        [JsonProperty("spectral_class")]
        public string SpectralClass { get; internal set; }

        [JsonProperty("spectral_sub_class")]
        public string SpectralSubClass { get; internal set; }

        [JsonProperty("luminosity_class")]
        public string LuminosityClass { get; internal set; }

        [JsonProperty("luminosity_sub_class")]
        public string LuminositySubClass { get; internal set; }

        [JsonProperty("surface_temperature", NullValueHandling = NullValueHandling.Ignore)]
        public double? SurfaceTemperature { get; internal set; }

        [JsonProperty("is_main_star", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMainStar { get; internal set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; internal set; }

        [JsonProperty("solar_masses", NullValueHandling = NullValueHandling.Ignore)]
        public double? SolarMasses { get; internal set; }

        [JsonProperty("solar_radius", NullValueHandling = NullValueHandling.Ignore)]
        public double? SolarRadius { get; internal set; }

        [JsonProperty("catalogue_gliese_id")]
        public string CatalogueGlieseId { get; internal set; }

        [JsonProperty("catalogue_hipp_id")]
        public string CatalogueHippId { get; internal set; }

        [JsonProperty("catalogue_hd_id")]
        public string CatalogueHdId { get; internal set; }

        [JsonProperty("volcanism_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolcanismTypeId { get; internal set; }

        [JsonProperty("volcanism_type_name")]
        public string VolcanismTypeName { get; internal set; }

        [JsonProperty("atmosphere_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AtmosphereTypeId { get; internal set; }

        [JsonProperty("atmosphere_type_name")]
        public string AtmpsphereTypeName { get; internal set; }

        [JsonProperty("terraforming_state_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TerraformingStateId { get; internal set; }

        [JsonProperty("terraforming_state_name")]
        public string TerraformingStateName { get; internal set; }

        [JsonProperty("earth_masses", NullValueHandling = NullValueHandling.Ignore)]
        public double? EarthMasses { get; internal set; }
        
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public double? Radius { get; internal set; }

        [JsonProperty("gravity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Gravity { get; internal set; }
        
        [JsonProperty("surface_pressure", NullValueHandling = NullValueHandling.Ignore)]
        public double? SurfacePressure { get; internal set; }

        [JsonProperty("orbital_period", NullValueHandling = NullValueHandling.Ignore)]
        public double? OrbitalPeriod { get; internal set; }

        [JsonProperty("semi_major_axis", NullValueHandling = NullValueHandling.Ignore)]
        public double? SemiMajorAxis { get; internal set; }

        [JsonProperty("orbital_eccentricity", NullValueHandling = NullValueHandling.Ignore)]
        public double? OrbitalEccentricity { get; internal set; }

        [JsonProperty("orbital_inclination", NullValueHandling = NullValueHandling.Ignore)]
        public double? OrbitalInclination { get; internal set; }

        [JsonProperty("arg_of_periapsis", NullValueHandling = NullValueHandling.Ignore)]
        public double? ArgOfPeriapsis { get; internal set; }

        [JsonProperty("rotational_period", NullValueHandling = NullValueHandling.Ignore)]
        public double? RotationalPeriod { get; internal set; }

        [JsonProperty("is_rotational_period_tidally_locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRotationalPeriodTidallyLocked { get; internal set; }

        [JsonProperty("axis_tilt", NullValueHandling = NullValueHandling.Ignore)]
        public double? AxisTilt { get; internal set; }

        [JsonProperty("eg_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EgId { get; internal set; }

        [JsonProperty("belt_moon_masses", NullValueHandling = NullValueHandling.Ignore)]
        public double? BeltMoonMasses { get; internal set; }

        [JsonProperty("ring_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RingTypeId { get; internal set; }

        [JsonProperty("ring_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RingTypeName { get; internal set; }

        [JsonProperty("ring_mass", NullValueHandling = NullValueHandling.Ignore)]
        public double? RingMass { get; internal set; }

        [JsonProperty("ring_inner_radius", NullValueHandling = NullValueHandling.Ignore)]
        public double? RingInnerRadius { get; internal set; } 

        [JsonProperty("ring_outer_radius", NullValueHandling = NullValueHandling.Ignore)]
        public double? RingOuterRadius { get; internal set; }

        [JsonProperty("rings", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Rings { get; internal set; }

        [JsonProperty("atmosphere_composition", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AtmosphereComponent> AtmosphereComposition { get; internal set; }

        [JsonProperty("solid_composition", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SolidComponent> SolidComposition { get; internal set; } = null;

        [JsonProperty("materials", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Material> Materials { get; internal set; }
    }

    public sealed class Ring
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; internal set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("semi_major_axis")]
        public int SemiMajorAxis { get; internal set; }

        [JsonProperty("ring_type_id")]
        public int RingTypeId { get; internal set; }

        [JsonProperty("ring_mass")]
        public double RingMass { get; internal set; }

        [JsonProperty("ring_inner_radius")]
        public double RingInnerRadius { get; internal set; }

        [JsonProperty("ring_outer_radius")]
        public double RingOuterRadius { get; internal set; }

        [JsonProperty("ring_type_name")]
        public string RingTypeName { get; internal set; }
    }

    public sealed class AtmosphereComponent
    {
        [JsonProperty("atmosphere_component_id")]
        public int Id { get; internal set; }

        [JsonProperty("atmosphere_component_name")]
        public string Name { get; internal set; }

        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public double? Share { get; internal set; }
    }

    public sealed class SolidComponent
    {
        [JsonProperty("solid_component_id")]
        public int Id { get; internal set; }

        [JsonProperty("solid_component_name")]
        public string Name { get; internal set; }

        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public double? Share { get; internal set; }
    }

    public sealed class Material
    {
        [JsonProperty("material_id")]
        public int Id { get; internal set; }

        [JsonProperty("material_name")]
        public string Name { get; internal set; }

        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public double? Share { get; internal set; }
    }

    public sealed class Group
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("category_id")]
        public int CategoryId { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("category")]
        public string Category { get; internal set; }
    }

    public sealed class Category
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}