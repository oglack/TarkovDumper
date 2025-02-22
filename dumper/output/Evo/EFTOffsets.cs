namespace SDK
{
	public readonly partial struct ClassNames
	{
		public readonly partial struct GameVersion
		{
			public const string Value = @"0.2.6.2.34974";
		}

		public readonly partial struct StreamerMode
		{
			public const uint ClassName_ClassToken = 0x20021D8; // MDToken
			public const string ClassName = @"\uEAC0";
			public const string MethodName = @"IsLocalStreamer";
		}

		public readonly partial struct FixWildSpawnType
		{
			public const uint ClassName_ClassToken = 0x2002922; // MDToken
			public const string ClassName = @"\uED98";
			public const string MethodName = @"SetUpSpawnInfo";
		}

		public readonly partial struct NetworkContainer
		{
			public const uint ClassName_ClassToken = 0x2000669; // MDToken
			public const string ClassName = @"\uE324";
		}

		public readonly partial struct InertiaSettings
		{
			public const uint ClassName_ClassToken = 0x2001918; // MDToken
			public const string ClassName = @"\uE81F";
		}

		public readonly partial struct GameSettings
		{
			public const uint ClassName_ClassToken = 0x2002178; // MDToken
			public const string ClassName = @"\uEAB0";
		}

		public readonly partial struct GameAPIClient
		{
			public const uint ClassName_ClassToken = 0x2000656; // MDToken
			public const string ClassName = @"\uE31D";
		}

		public readonly partial struct DogtagComponent
		{
			public const uint MethodName_MethodToken = 0x60121DE; // MDToken
			public const string MethodName = @"\uE000";
		}

		public readonly partial struct GridItemView
		{
			public const uint MethodName_MethodToken = 0x601612E; // MDToken
			public const string MethodName = @"\uE012";
		}

		public readonly partial struct AFKMonitor
		{
			public const uint ClassName_ClassToken = 0x2001ED0; // MDToken
			public const uint MethodName_MethodToken = 0x600C0FD; // MDToken
			public const string ClassName = @"\uEA35";
			public const string MethodName = @"MoveNext";
		}

		public readonly partial struct VitalParts
		{
			public const uint ClassName_ClassToken = 0x20030F7; // MDToken
			public const uint MethodName_MethodToken = 0x6012666; // MDToken
			public const string ClassName = @"EFT.InventoryLogic.CompoundItem";
			public const string MethodName = @"\uE007";
		}

		public readonly partial struct EquipmentPenaltyComponent
		{
			public const uint ClassName_ClassToken = 0x2002FF7; // MDToken
			public const uint BaseCalculationMethod_MethodToken = 0x60121F1; // MDToken
			public const uint SpeedPenaltyPercent_MethodToken = 0x60121F2; // MDToken
			public const uint MousePenalty_MethodToken = 0x60121F4; // MDToken
			public const uint WeaponErgonomicPenalty_MethodToken = 0x60121F6; // MDToken
			public const string BaseCalculationMethod = @"\uE000";
			public const string ClassName = @"EFT.InventoryLogic.EquipmentPenaltyComponent+\uE000";
			public const string MousePenalty = @"\uE003";
			public const string SpeedPenaltyPercent = @"\uE001";
			public const string WeaponErgonomicPenalty = @"\uE005";
		}

		public readonly partial struct AmmoTemplate
		{
			public const uint ClassName_ClassToken = 0x2003142; // MDToken
			public const uint MethodName_MethodToken = 0x6012899; // MDToken
			public const string ClassName = @"\uF035";
			public const string MethodName = @"get_LoadUnloadModifier";
		}

		public readonly partial struct NoMalfunctions
		{
			public const uint ClassName_ClassToken = 0x2001B03; // MDToken
			public const uint GetMalfunctionState_MethodToken = 0x600A62E; // MDToken
			public const string ClassName = @"EFT.Player+FirearmController";
			public const string GetMalfunctionState = @"GetMalfunctionState";
		}

		public readonly partial struct InventoryController
		{
			public const uint ClassName_ClassToken = 0x2002FCD; // MDToken
			public const uint ShowOwnDogTagMethod_MethodToken = 0x60120E1; // MDToken
			public const uint KeybindFromAnywhereMethodB_MethodToken = 0x60120E4; // MDToken
			public const uint KeybindFromAnywhereMethodA_MethodToken = 0x60120E6; // MDToken
			public const string ClassName = @"EFT.InventoryLogic.InventoryController";
			public const string KeybindFromAnywhereMethodA = @"IsAtReachablePlace";
			public const string KeybindFromAnywhereMethodB = @"IsAtBindablePlace";
			public const string ShowOwnDogTagMethod = @"IsAllowedToSeeSlot";
		}

		public readonly partial struct OpticCameraManagerContainer
		{
			public const uint ClassName_ClassToken = 0x20033BE; // MDToken
			public const string ClassName = @"\uF1AA";
		}

		public readonly partial struct ScreenManager
		{
			public const uint ClassName_ClassToken = 0x2003A57; // MDToken
			public const string ClassName = @"\uF246";
		}

		public readonly partial struct FovChanger
		{
			public const uint ClassName_ClassToken = 0x20033BE; // MDToken
			public const uint MethodName_MethodToken = 0x6013481; // MDToken
			public const string ClassName = @"\uF1AA";
			public const string MethodName = @"SetFov";
		}

		public readonly partial struct LocaleManager
		{
			public const uint ClassName_ClassToken = 0x2002038; // MDToken
			public const string ClassName = @"\uEA70";
		}

		public readonly partial struct LayerManager
		{
			public const uint ClassName_ClassToken = 0x20008F0; // MDToken
			public const string ClassName = @"\uE3E2";
		}

		public readonly partial struct BallisticLayerManager
		{
			public const uint ClassName_ClassToken = 0x2002E0A; // MDToken
			public const string ClassName = @"\uEF06";
		}

		public readonly partial struct FirearmController
		{
			public const uint ClassName_ClassToken = 0x2001B03; // MDToken
			public const string ClassName = @"EFT.Player+FirearmController";
		}

		public readonly partial struct LookSensor
		{
			public const uint ClassName_ClassToken = 0x20005A3; // MDToken
			public const uint MethodName_MethodToken = 0x6002A09; // MDToken
			public const string ClassName = @"LookSensor";
			public const string MethodName = @"CheckAllEnemies";
		}

		public readonly partial struct ActiveHealthController
		{
			public const uint ClassName_ClassToken = 0x20029CD; // MDToken
			public const uint MethodName_MethodToken = 0x6010000; // MDToken
			public const string ClassName = @"EFT.HealthSystem.ActiveHealthController";
			public const string MethodName = @"HandleFall";
		}

		public readonly partial struct InventoryLogic_Mod
		{
			public const uint ClassName_ClassToken = 0x200315A; // MDToken
			public const uint MethodName_MethodToken = 0x601292F; // MDToken
			public const string ClassName = @"EFT.InventoryLogic.Mod";
			public const string MethodName = @"get_RaidModdable";
		}

		public readonly partial struct ProceduralWeaponAnimation
		{
			public const uint ClassName_ClassToken = 0x20027CD; // MDToken
			public const uint MethodName_MethodToken = 0x600F35E; // MDToken
			public const string ClassName = @"EFT.Animations.ProceduralWeaponAnimation";
			public const string MethodName = @"get_ShotNeedsFovAdjustments";
		}

		public readonly partial struct MovementContext
		{
			public const uint ClassName_ClassToken = 0x2001D17; // MDToken
			public const uint MethodName_MethodToken = 0x600B697; // MDToken
			public const string ClassName = @"EFT.MovementContext";
			public const string MethodName = @"SetPhysicalCondition";
		}

		public readonly partial struct GrenadeFlashScreenEffect
		{
			public const uint ClassName_ClassToken = 0x2000C52; // MDToken
			public const uint MethodName_MethodToken = 0x6005142; // MDToken
			public const string ClassName = @"GrenadeFlashScreenEffect";
			public const string MethodName = @"Update";
		}
	}

	public readonly partial struct Offsets
	{
		public readonly partial struct TarkovApplication
		{
			// [ERROR] Unable to find offset: "To_Profile"!
		}

		public readonly partial struct GameWorld
		{
			public const uint LootMaskObstruction = 0x1C; // Int32
		}

		public readonly partial struct ClientLocalGameWorld
		{
			public const uint TransitController = 0x18; // -.\uE891
			public const uint ExfilController = 0x20; // -.\uE6BF
			public const uint ClientShellingController = 0x70; // -.\uE6EB
			public const uint LocationId = 0x78; // String
			public const uint LootList = 0x100; // System.Collections.Generic.List<\uE306>
			public const uint RegisteredPlayers = 0x128; // System.Collections.Generic.List<IPlayer>
			public const uint BorderZones = 0x188; // EFT.Interactive.BorderZone[]
			public const uint MainPlayer = 0x198; // EFT.Player
			public const uint SynchronizableObjectLogicProcessor = 0x1C8; // -.\uEC1F
			public const uint Grenades = 0x1F8; // -.\uE3DA<Int32, Throwable>
			public const uint LoadBundlesAndCreatePools = 0x278; // Boolean
		}

		public readonly partial struct TransitController
		{
			public const uint TransitPoints = 0x18; // System.Collections.Generic.Dictionary<Int32, TransitPoint>
		}

		public readonly partial struct ClientShellingController
		{
			public const uint ActiveClientProjectiles = 0x68; // System.Collections.Generic.Dictionary<Int32, ArtilleryProjectileClient>
		}

		public readonly partial struct ArtilleryProjectileClient
		{
			public const uint Position = 0x2C; // UnityEngine.Vector3
			public const uint IsActive = 0x38; // Boolean
		}

		public readonly partial struct TransitPoint
		{
			public const uint parameters = 0x18; // -.\uE68D.Location.TransitParameters
		}

		public readonly partial struct TransitParameters
		{
			public const uint name = 0x10; // String
			public const uint description = 0x18; // String
		}

		public readonly partial struct SynchronizableObject
		{
			public const uint Type = 0x28; // System.Int32
		}

		public readonly partial struct SynchronizableObjectLogicProcessor
		{
			public const uint SynchronizableObjects = 0x18; // System.Collections.Generic.List<SynchronizableObject>
		}

		public readonly partial struct TripwireSynchronizableObject
		{
			public const uint GrenadeTemplateId = 0xC8; // EFT.MongoID
			public const uint _tripwireState = 0x124; // System.Int32
			public const uint FromPosition = 0x128; // UnityEngine.Vector3
			public const uint ToPosition = 0x134; // UnityEngine.Vector3
		}

		public readonly partial struct MineDirectional
		{
			public const uint Mines = 0x8; // System.Collections.Generic.List<MineDirectional>
			public const uint MineData = 0x18; // -.MineDirectional.MineSettings
		}

		public readonly partial struct MineSettings
		{
			public const uint _maxExplosionDistance = 0x28; // Single
			public const uint _directionalDamageAngle = 0x64; // Single
		}

		public readonly partial struct BorderZone
		{
			public const uint Description = 0x30; // String
			public const uint _extents = 0x40; // UnityEngine.Vector3
		}

		public readonly partial struct LevelSettings
		{
			public const uint AmbientMode = 0x68; // System.Int32
			public const uint EquatorColor = 0x7C; // UnityEngine.Color
			public const uint GroundColor = 0x8C; // UnityEngine.Color
		}

		public readonly partial struct EFTHardSettings
		{
			public const uint DecelerationSpeed = 0x180; // Single
			public const uint LOOT_RAYCAST_DISTANCE = 0x248; // Single
			public const uint DOOR_RAYCAST_DISTANCE = 0x250; // Single
			public const uint STOP_AIMING_AT = 0x2A4; // Single
			public const uint MOUSE_LOOK_HORIZONTAL_LIMIT = 0x39C; // UnityEngine.Vector2
		}

		public readonly partial struct GlobalConfigs
		{
			public const uint Inertia = 0xE8; // -.\uE81F.InertiaSettings
		}

		public readonly partial struct InertiaSettings
		{
			public const uint FallThreshold = 0x20; // Single
			public const uint BaseJumpPenaltyDuration = 0x4C; // Single
			public const uint BaseJumpPenalty = 0x54; // Single
			public const uint MoveTimeRange = 0xF4; // UnityEngine.Vector2
		}

		public readonly partial struct ExfilController
		{
			public const uint ExfiltrationPointArray = 0x20; // EFT.Interactive.ExfiltrationPoint[]
			public const uint ScavExfiltrationPointArray = 0x28; // EFT.Interactive.ScavExfiltrationPoint[]
		}

		public readonly partial struct Exfil
		{
			public const uint Settings = 0x70; // EFT.Interactive.ExitTriggerSettings
			public const uint EligibleEntryPoints = 0x98; // System.String[]
			public const uint _status = 0xC0; // System.Byte
		}

		public readonly partial struct ScavExfil
		{
			public const uint EligibleIds = 0xD8; // System.Collections.Generic.List<String>
		}

		public readonly partial struct ExfilSettings
		{
			public const uint Name = 0x18; // String
		}

		public readonly partial struct GenericCollectionContainer
		{
			public const uint List = 0x18; // System.Collections.Generic.List<Var>
		}

		public readonly partial struct Grenade
		{
			public const uint IsDestroyed = 0x55; // Boolean
			public const uint WeaponSource = 0x78; // -.\uF0B0
		}

		public readonly partial struct Player
		{
			public const uint _characterController = 0x38; // -.ICharacterController
			public const uint MovementContext = 0x50; // EFT.MovementContext
			public const uint _playerBody = 0xB8; // EFT.PlayerBody
			public const uint ProceduralWeaponAnimation = 0x1E0; // EFT.Animations.ProceduralWeaponAnimation
			public const uint _animators = 0x408; // -.IAnimator[]
			public const uint Corpse = 0x440; // EFT.Interactive.Corpse
			public const uint Location = 0x640; // String
			public const uint InteractableObject = 0x650; // EFT.Interactive.InteractableObject
			public const uint Profile = 0x678; // EFT.Profile
			public const uint Physical = 0x690; // -.\uE399
			public const uint AIData = 0x6A0; // -.IAIData
			public const uint _healthController = 0x6C0; // EFT.HealthSystem.IHealthController
			public const uint _inventoryController = 0x6D8; // -.Player.PlayerInventoryController
			public const uint _handsController = 0x6E0; // -.Player.AbstractHandsController
			public const uint EnabledAnimators = 0x9A8; // System.Int32
			public const uint InteractionRayOriginOnStartOperation = 0xA18; // UnityEngine.Vector3
			public const uint InteractionRayDirectionOnStartOperation = 0xA24; // UnityEngine.Vector3
			public const uint IsYourPlayer = 0xA3A; // Boolean
		}

		public readonly partial struct AIData
		{
			public const uint IsAI = 0xE0; // Boolean
		}

		public readonly partial struct ObservedPlayerView
		{
			public const uint GroupID = 0x18; // String
			public const uint NickName = 0x48; // String
			public const uint AccountId = 0x50; // String
			public const uint PlayerBody = 0x60; // EFT.PlayerBody
			public const uint ObservedPlayerController = 0x80; // -.\uED81
			public const uint Side = 0x100; // System.Int32
			public const uint IsAI = 0x111; // Boolean
			public const uint VisibleToCameraType = 0x114; // System.Int32
		}

		public readonly partial struct ObservedPlayerController
		{
			public static readonly uint[] MovementController = new uint[] { 0xF0, 0x10 }; // -.\uEDA4, -.\uEDA6
			public const uint HandsController = 0x100; // -.\uED8F
			public const uint InfoContainer = 0x110; // -.\uED98
			public const uint HealthController = 0x118; // -.\uE44C
			public const uint InventoryController = 0x140; // -.\uED7C
		}

		public readonly partial struct ObservedMovementController
		{
			public const uint Rotation = 0x88; // UnityEngine.Vector2
			public const uint Velocity = 0x120; // UnityEngine.Vector3
		}

		public readonly partial struct ObservedHandsController
		{
			public const uint ItemInHands = 0x58; // EFT.InventoryLogic.Item
		}

		public readonly partial struct ObservedHealthController
		{
			public const uint PlayerCorpse = 0x18; // EFT.Interactive.ObservedCorpse
			public const uint HealthStatus = 0xE0; // System.Int32
		}

		public readonly partial struct SimpleCharacterController
		{
			public const uint _collisionMask = 0x58; // UnityEngine.LayerMask
			public const uint _speedLimit = 0x74; // Single
			public const uint _sqrSpeedLimit = 0x78; // Single
			public const uint velocity = 0xE4; // UnityEngine.Vector3
		}

		public readonly partial struct InfoContainer
		{
			public const uint Side = 0x20; // System.Int32
		}

		public readonly partial struct PlayerSpawnInfo
		{
			public const uint Side = 0x28; // System.Int32
			public const uint WildSpawnType = 0x2C; // System.Int32
		}

		public readonly partial struct Physical
		{
			public const uint Stamina = 0x38; // -.\uE398
			public const uint HandsStamina = 0x40; // -.\uE398
			public const uint Oxygen = 0x48; // -.\uE398
			public const uint Overweight = 0x8C; // Single
			public const uint WalkOverweight = 0x90; // Single
			public const uint WalkSpeedLimit = 0x94; // Single
			public const uint Inertia = 0x98; // Single
			public const uint WalkOverweightLimits = 0xD8; // UnityEngine.Vector2
			public const uint BaseOverweightLimits = 0xE0; // UnityEngine.Vector2
			public const uint SprintOverweightLimits = 0xF4; // UnityEngine.Vector2
			public const uint SprintWeightFactor = 0x104; // Single
			public const uint SprintAcceleration = 0x114; // Single
			public const uint PreSprintAcceleration = 0x118; // Single
			public const uint IsOverweightA = 0x11C; // Boolean
			public const uint IsOverweightB = 0x11D; // Boolean
		}

		public readonly partial struct PhysicalValue
		{
			public const uint Current = 0x48; // Single
		}

		public readonly partial struct ProceduralWeaponAnimation
		{
			public const uint HandsContainer = 0x18; // EFT.Animations.PlayerSpring
			public const uint Breath = 0x28; // EFT.Animations.BreathEffector
			public const uint MotionReact = 0x38; // -.MotionEffector
			public const uint Shootingg = 0x48; // -.ShotEffector
			public const uint _optics = 0xC0; // System.Collections.Generic.List<SightNBone>
			public const uint Mask = 0x150; // System.Int32
			public const uint _isAiming = 0x1D5; // Boolean
			public const uint _aimingSpeed = 0x1F4; // Single
			public const uint _fovCompensatoryDistance = 0x208; // Single
			public const uint _compensatoryScale = 0x238; // Single
			public const uint CameraSmoothOut = 0x278; // Single
			public const uint PositionZeroSum = 0x354; // UnityEngine.Vector3
			public const uint ShotNeedsFovAdjustments = 0x41F; // Boolean
		}

		public readonly partial struct SightNBone
		{
			public const uint Mod = 0x10; // EFT.InventoryLogic.SightComponent
		}

		public readonly partial struct MotionEffector
		{
			public const uint _mouseProcessors = 0x18; // -.\uE441[]
			public const uint _movementProcessors = 0x20; // -.\uE440[]
		}

		public readonly partial struct PlayerSpring
		{
			public const uint CameraTransform = 0x68; // UnityEngine.Transform
		}

		public readonly partial struct BreathEffector
		{
			public const uint Intensity = 0xA4; // Single
		}

		public readonly partial struct ShotEffector
		{
			public const uint NewShotRecoil = 0x18; // EFT.Animations.NewRecoil.NewRecoilShotEffect
		}

		public readonly partial struct NewShotRecoil
		{
			public const uint IntensitySeparateFactors = 0x8C; // UnityEngine.Vector3
		}

		public readonly partial struct ThermalVision
		{
			public const uint Material = 0x90; // UnityEngine.Material
			public const uint On = 0xE0; // Boolean
		}

		public readonly partial struct NightVision
		{
			public const uint _on = 0xEC; // Boolean
		}

		public readonly partial struct VisorEffect
		{
			public const uint Intensity = 0xC0; // Single
		}

		public readonly partial struct Profile
		{
			public const uint Id = 0x10; // String
			public const uint AccountId = 0x18; // String
			public const uint Info = 0x28; // -.\uE884
			public const uint Skills = 0x58; // EFT.SkillManager
			public const uint TaskConditionCounters = 0x68; // System.Collections.Generic.Dictionary<MongoID, \uEF33>
			public const uint QuestsData = 0x70; // System.Collections.Generic.List<\uEF60>
			public const uint Stats = 0xD8; // -.\uE3AF
		}

		public readonly partial struct ProfileStatsContainer
		{
			public const uint Eft = 0x10; // -.ProfileStats
		}

		public readonly partial struct ProfileStats
		{
			public const uint OverallCounters = 0x28; // -.\uEC8F
			public const uint TotalInGameTime = 0x80; // Int64
		}

		public readonly partial struct OverallCounters
		{
			// [ERROR] Unable to find offset: "Counters"!
		}

		public readonly partial struct PlayerInfo
		{
			public const uint Nickname = 0x20; // String
			public const uint EntryPoint = 0x28; // String
			public const uint GroupId = 0x38; // String
			public const uint RegistrationDate = 0xA4; // Int32
			public const uint MemberCategory = 0xB0; // System.Int32
			public const uint Experience = 0xB4; // Int32
			// [ERROR] Unable to find offset: "Settings"!
			// [ERROR] Unable to find offset: "Side"!
		}

		public readonly partial struct PlayerInfoSettings
		{
			// [ERROR] Unable to find offset: "PlayerInfoSettings"!
		}

		public readonly partial struct SkillManager
		{
			public const uint StrengthBuffJumpHeightInc = 0x60; // -.SkillManager.FloatBuff
			public const uint StrengthBuffThrowDistanceInc = 0x70; // -.SkillManager.FloatBuff
			public const uint MagDrillsLoadSpeed = 0x180; // -.SkillManager.FloatBuff
			public const uint MagDrillsUnloadSpeed = 0x188; // -.SkillManager.FloatBuff
		}

		public readonly partial struct SkillValueContainer
		{
			public const uint Value = 0x30; // Single
		}

		public readonly partial struct QuestData
		{
			public const uint Id = 0x10; // String
			public const uint CompletedConditions = 0x20; // System.Collections.Generic.HashSet<MongoID>
			public const uint Template = 0x28; // -.\uEF61
			public const uint Status = 0x34; // System.Int32
		}

		public readonly partial struct ProfileTaskConditionCounter
		{
			public const uint Value = 0x50; // Int32
			// [ERROR] Unable to find offset: "Id"!
		}

		public readonly partial struct QuestTemplate
		{
			public const uint Conditions = 0x40; // -.\uEF3C
			public const uint Name = 0x50; // String
		}

		public readonly partial struct QuestConditionsContainer
		{
			public const uint ConditionsList = 0x50; // System.Collections.Generic.List<Var>
		}

		public readonly partial struct QuestCondition
		{
			public const uint id = 0x10; // EFT.MongoID
		}

		public readonly partial struct QuestConditionItem
		{
			public const uint value = 0x58; // Single
		}

		public readonly partial struct QuestConditionFindItem
		{
			public const uint target = 0x70; // System.String[]
		}

		public readonly partial struct QuestConditionCounterCreator
		{
			public const uint Conditions = 0x78; // -.\uEF2E
		}

		public readonly partial struct QuestConditionVisitPlace
		{
			public const uint target = 0x70; // String
		}

		public readonly partial struct QuestConditionPlaceBeacon
		{
			public const uint zoneId = 0x78; // String
			public const uint plantTime = 0x80; // Single
		}

		public readonly partial struct QuestConditionCounterTemplate
		{
			public const uint Conditions = 0x10; // -.\uEF2E
		}

		public readonly partial struct ItemHandsController
		{
			public const uint Item = 0x60; // EFT.InventoryLogic.Item
		}

		public readonly partial struct FirearmController
		{
			public const uint Fireport = 0xD8; // EFT.BifacialTransform
			public const uint TotalCenterOfImpact = 0x198; // Single
		}

		public readonly partial struct MovementContext
		{
			public const uint CurrentState = 0xE0; // EFT.BaseMovementState
			public const uint _states = 0x1E0; // System.Collections.Generic.Dictionary<Byte, BaseMovementState>
			public const uint _movementStates = 0x200; // -.IPlayerStateContainerBehaviour[]
			public const uint _tilt = 0x268; // Single
			public const uint _rotation = 0x27C; // UnityEngine.Vector2
			public const uint _physicalCondition = 0x300; // System.Int32
			public const uint _speedLimitIsDirty = 0x305; // Boolean
			public const uint StateSpeedLimit = 0x308; // Single
			public const uint StateSprintSpeedLimit = 0x30C; // Single
			public const uint _lookDirection = 0x420; // UnityEngine.Vector3
			public const uint WalkInertia = 0x4AC; // Single
			public const uint SprintBrakeInertia = 0x4B0; // Single
		}

		public readonly partial struct MovementState
		{
			public const uint Name = 0x21; // System.Byte
			public const uint AnimatorStateHash = 0x24; // Int32
			public const uint StickToGround = 0x5C; // Boolean
			public const uint PlantTime = 0x60; // Single
		}

		public readonly partial struct PlayerStateContainer
		{
			public const uint Name = 0x39; // System.Byte
			public const uint StateFullNameHash = 0x50; // Int32
		}

		public readonly partial struct StationaryWeapon
		{
			public const uint IsMounted = 0xF0; // Boolean
		}

		public readonly partial struct InventoryController
		{
			public const uint Inventory = 0x130; // EFT.InventoryLogic.Inventory
		}

		public readonly partial struct Inventory
		{
			public const uint Equipment = 0x10; // EFT.InventoryLogic.InventoryEquipment
			public const uint QuestRaidItems = 0x20; // -.\uF12B
			public const uint QuestStashItems = 0x28; // -.\uF12B
		}

		public readonly partial struct Equipment
		{
			public const uint Grids = 0x90; // -.\uEFA9[]
			public const uint Slots = 0x98; // EFT.InventoryLogic.Slot[]
		}

		public readonly partial struct Slot
		{
			public const uint ContainedItem = 0x48; // EFT.InventoryLogic.Item
			public const uint ID = 0x58; // String
			public const uint Required = 0x70; // Boolean
		}

		public readonly partial struct InteractiveLootItem
		{
			public const uint Item = 0xB0; // EFT.InventoryLogic.Item
		}

		public readonly partial struct InteractiveCorpse
		{
			public const uint PlayerBody = 0x130; // EFT.PlayerBody
		}

		public readonly partial struct LootableContainer
		{
			public const uint ItemOwner = 0x128; // -.\uEF86
			public const uint Template = 0x130; // String
		}

		public readonly partial struct LootableContainerItemOwner
		{
			public const uint RootItem = 0xD0; // EFT.InventoryLogic.Item
		}

		public readonly partial struct LootItem
		{
			public const uint Template = 0x58; // EFT.InventoryLogic.ItemTemplate
			public const uint StackObjectsCount = 0x7C; // Int32
			public const uint Version = 0x80; // Int32
			public const uint SpawnedInSession = 0x84; // Boolean
		}

		public readonly partial struct LootItemMod
		{
			public const uint Grids = 0x90; // -.\uEFA9[]
			public const uint Slots = 0x98; // EFT.InventoryLogic.Slot[]
		}

		public readonly partial struct LootItemModGrids
		{
			public const uint ItemCollection = 0x48; // -.\uEFAB
		}

		public readonly partial struct LootItemModGridsItemCollection
		{
			public const uint List = 0x18; // System.Collections.Generic.List<Item>
		}

		public readonly partial struct LootItemWeapon
		{
			public const uint FireMode = 0xB8; // EFT.InventoryLogic.FireModeComponent
			public const uint Chambers = 0xC8; // EFT.InventoryLogic.Slot[]
			public const uint _magSlotCache = 0xE8; // EFT.InventoryLogic.Slot
		}

		public readonly partial struct FireModeComponent
		{
			public const uint FireMode = 0x28; // System.Byte
		}

		public readonly partial struct LootItemMagazine
		{
			public const uint Cartridges = 0xB8; // EFT.InventoryLogic.StackSlot
			public const uint LoadUnloadModifier = 0x1B4; // Single
		}

		public readonly partial struct StackSlot
		{
			public const uint _items = 0x28; // System.Collections.Generic.List<Item>
			public const uint MaxCount = 0x50; // Int32
		}

		public readonly partial struct ItemTemplate
		{
			public const uint ShortName = 0x18; // String
			public const uint _id = 0x60; // EFT.MongoID
			public const uint Weight = 0xC0; // Single
			public const uint QuestItem = 0xCC; // Boolean
		}

		public readonly partial struct ModTemplate
		{
			public const uint Velocity = 0x180; // Single
		}

		public readonly partial struct AmmoTemplate
		{
			public const uint InitialSpeed = 0x1E0; // Single
			public const uint BallisticCoeficient = 0x1F4; // Single
			public const uint BulletMassGram = 0x27C; // Single
			public const uint BulletDiameterMilimeters = 0x280; // Single
		}

		public readonly partial struct WeaponTemplate
		{
			public const uint Velocity = 0x264; // Single
		}

		public readonly partial struct PlayerBody
		{
			public const uint SkeletonRootJoint = 0x28; // Diz.Skinning.Skeleton
			public const uint BodySkins = 0x40; // System.Collections.Generic.Dictionary<Int32, LoddedSkin>
			public const uint _bodyRenderers = 0x50; // -.\uE44B[]
			public const uint SlotViews = 0x68; // -.\uE3DA<Int32, \uE001>
			public const uint PointOfView = 0x90; // -.\uE752<Int32>
		}

		public readonly partial struct PlayerBodySubclass
		{
			public const uint Dresses = 0x40; // EFT.Visual.Dress[]
		}

		public readonly partial struct Dress
		{
			public const uint Renderers = 0x28; // UnityEngine.Renderer[]
		}

		public readonly partial struct Skeleton
		{
			public const uint _values = 0x28; // System.Collections.Generic.List<Transform>
		}

		public readonly partial struct LoddedSkin
		{
			public const uint _lods = 0x18; // Diz.Skinning.AbstractSkin[]
		}

		public readonly partial struct Skin
		{
			public const uint _skinnedMeshRenderer = 0x20; // UnityEngine.SkinnedMeshRenderer
		}

		public readonly partial struct TorsoSkin
		{
			public const uint _skin = 0x20; // Diz.Skinning.Skin
		}

		public readonly partial struct SlotViewsContainer
		{
			public const uint Dict = 0x10; // System.Collections.Generic.Dictionary<Var, Var>
		}

		public readonly partial struct PointOfView
		{
			public const uint POV = 0x10; // Var
		}

		public readonly partial struct InventoryBlur
		{
			public const uint _upsampleTexDimension = 0x2C; // System.Int32
			public const uint _blurCount = 0x34; // Int32
		}

		public readonly partial struct WeatherController
		{
			public const uint WeatherDebug = 0x60; // EFT.Weather.WeatherDebug
		}

		public readonly partial struct WeatherDebug
		{
			public const uint isEnabled = 0x18; // Boolean
			public const uint WindMagnitude = 0x1C; // Single
			public const uint CloudDensity = 0x2C; // Single
			public const uint Fog = 0x30; // Single
			public const uint Rain = 0x34; // Single
			public const uint LightningThunderProbability = 0x38; // Single
		}

		public readonly partial struct TOD_Scattering
		{
			public const uint sky = 0x18; // -.TOD_Sky
		}

		public readonly partial struct TOD_Sky
		{
			public const uint Cycle = 0x18; // -.TOD_CycleParameters
			public const uint TOD_Components = 0x78; // -.TOD_Components
		}

		public readonly partial struct TOD_CycleParameters
		{
			public const uint Hour = 0x10; // Single
		}

		public readonly partial struct TOD_Components
		{
			public const uint TOD_Time = 0x110; // -.TOD_Time
		}

		public readonly partial struct TOD_Time
		{
			public const uint LockCurrentTime = 0x68; // Boolean
		}

		public readonly partial struct PrismEffects
		{
			public const uint useVignette = 0x124; // Boolean
			public const uint useExposure = 0x1B8; // Boolean
		}

		public readonly partial struct CC_Vintage
		{
			public const uint amount = 0x38; // Single
		}

		public readonly partial struct GPUInstancerManager
		{
			public const uint runtimeDataList = 0x40; // System.Collections.Generic.List<\uE5D3>
		}

		public readonly partial struct RuntimeDataList
		{
			public const uint instanceBounds = 0x68; // UnityEngine.Bounds
		}

		public readonly partial struct GameSettingsContainer
		{
			public const uint Game = 0x10; // -.\uEAB0.\uE000<\uEAC1, \uEAC0>
			public const uint Graphics = 0x28; // -.\uEAB0.\uE000<\uEABD, \uEABB>
		}

		public readonly partial struct GameSettingsInnerContainer
		{
			public const uint Settings = 0x10; // Var
			public const uint Controller = 0x30; // Var
		}

		public readonly partial struct GameSettings
		{
			public const uint FieldOfView = 0x60; // Bsg.GameSettings.GameSetting<Int32>
			public const uint HeadBobbing = 0x68; // Bsg.GameSettings.GameSetting<Single>
			public const uint AutoEmptyWorkingSet = 0x70; // Bsg.GameSettings.GameSetting<Boolean>
		}

		public readonly partial struct GraphicsSettings
		{
			public const uint DisplaySettings = 0x20; // Bsg.GameSettings.GameSetting<\uEAB6>
		}

		public readonly partial struct NetworkContainer
		{
			public const uint NextRequestIndex = 0x8; // Int64
			public const uint PhpSessionId = 0x30; // String
		}

		public readonly partial struct ScreenManager
		{
			public const uint Instance = 0x0; // -.\uF246
			public const uint CurrentScreenController = 0x28; // -.\uF248<Var>
		}

		public readonly partial struct CurrentScreenController
		{
			public const uint Generic = 0x20; // Var
		}

		public readonly partial struct BSGGameSetting
		{
			public const uint ValueClass = 0x28; // [HUMAN] ulong
		}

		public readonly partial struct BSGGameSettingValueClass
		{
			public const uint Value = 0x30; // [HUMAN] T
		}

		public readonly partial struct SSAA
		{
			public const uint OpticMaskMaterial = 0x58; // [HUMAN] UnityEngine.Material
		}

		public readonly partial struct BloomAndFlares
		{
			public const uint BloomIntensity = 0xB8; // [HUMAN] Single
		}

		public readonly partial struct OpticCameraManagerContainer
		{
			public const uint Instance = 0x0; // -.\uF1AA
			public const uint OpticCameraManager = 0x10; // -.\uF1AE
			public const uint FPSCamera = 0x68; // UnityEngine.Camera
		}

		public readonly partial struct OpticCameraManager
		{
			public const uint Camera = 0x68; // UnityEngine.Camera
			public const uint CurrentOpticSight = 0x70; // EFT.CameraControl.OpticSight
		}

		public readonly partial struct OpticSight
		{
			public const uint LensRenderer = 0x18; // UnityEngine.Renderer
			// [ERROR] Unable to find offset: "OpticCullingMask"!
		}

		public readonly partial struct MongoID
		{
			public const uint _stringID = 0x10; // String
		}

		public readonly partial struct LocaleManager
		{
			public const uint Instance = 0x8; // -.\uEA70
			public const uint LocaleDictionary = 0x38; // System.Collections.Generic.Dictionary<String, \uEA6D>
			public const uint CurrentCulture = 0x70; // String
		}

		public readonly partial struct LayerMask
		{
			public const uint m_Mask = 0x0; // [HUMAN] Int32
		}

		public readonly partial struct LayerManager
		{
			public const uint HighPolyWithTerrainMask = 0x0; // UnityEngine.LayerMask
		}

		public readonly partial struct BallisticLayerManager
		{
			public const uint HitMask = 0x24; // UnityEngine.LayerMask
		}
	}

	public readonly partial struct Enums
	{
		public enum EPlayerState
		{
			None = 0,
			Idle = 1,
			ProneIdle = 2,
			ProneMove = 3,
			Run = 4,
			Sprint = 5,
			Jump = 6,
			FallDown = 7,
			Transition = 8,
			BreachDoor = 9,
			Loot = 10,
			Pickup = 11,
			Open = 12,
			Close = 13,
			Unlock = 14,
			Sidestep = 15,
			DoorInteraction = 16,
			Approach = 17,
			Prone2Stand = 18,
			Transit2Prone = 19,
			Plant = 20,
			Stationary = 21,
			Roll = 22,
			JumpLanding = 23,
			ClimbOver = 24,
			ClimbUp = 25,
			VaultingFallDown = 26,
			VaultingLanding = 27,
			BlindFire = 28,
			IdleWeaponMounting = 29,
			IdleZombieState = 30,
			MoveZombieState = 31,
			TurnZombieState = 32,
			StartMoveZombieState = 33,
			EndMoveZombieState = 34,
			DoorInteractionZombieState = 35,
		}

		public enum EPlayerSide
		{
			Usec = 1,
			Bear = 2,
			Savage = 4,
			Observer = 8,
		}

		[Flags]
		public enum ETagStatus
		{
			Unaware = 1,
			Aware = 2,
			Combat = 4,
			Solo = 8,
			Coop = 16,
			Bear = 32,
			Usec = 64,
			Scav = 128,
			TargetSolo = 256,
			TargetMultiple = 512,
			Healthy = 1024,
			Injured = 2048,
			BadlyInjured = 4096,
			Dying = 8192,
			Birdeye = 16384,
			Knight = 32768,
			BigPipe = 65536,
		}

		[Flags]
		public enum EMemberCategory
		{
			Default = 0,
			Developer = 1,
			UniqueId = 2,
			Trader = 4,
			Group = 8,
			System = 16,
			ChatModerator = 32,
			ChatModeratorWithPermanentBan = 64,
			UnitTest = 128,
			Sherpa = 256,
			Emissary = 512,
			Unheard = 1024,
		}

		public enum WildSpawnType
		{
			marksman = 0,
			assault = 1,
			bossTest = 2,
			bossBully = 3,
			followerTest = 4,
			followerBully = 5,
			bossKilla = 6,
			bossKojaniy = 7,
			followerKojaniy = 8,
			pmcBot = 9,
			cursedAssault = 10,
			bossGluhar = 11,
			followerGluharAssault = 12,
			followerGluharSecurity = 13,
			followerGluharScout = 14,
			followerGluharSnipe = 15,
			followerSanitar = 16,
			bossSanitar = 17,
			test = 18,
			assaultGroup = 19,
			sectantWarrior = 20,
			sectantPriest = 21,
			bossTagilla = 22,
			followerTagilla = 23,
			exUsec = 24,
			gifter = 25,
			bossKnight = 26,
			followerBigPipe = 27,
			followerBirdEye = 28,
			bossZryachiy = 29,
			followerZryachiy = 30,
			bossBoar = 32,
			followerBoar = 33,
			arenaFighter = 34,
			arenaFighterEvent = 35,
			bossBoarSniper = 36,
			crazyAssaultEvent = 37,
			peacefullZryachiyEvent = 38,
			sectactPriestEvent = 39,
			ravangeZryachiyEvent = 40,
			followerBoarClose1 = 41,
			followerBoarClose2 = 42,
			bossKolontay = 43,
			followerKolontayAssault = 44,
			followerKolontaySecurity = 45,
			shooterBTR = 46,
			bossPartisan = 47,
			spiritWinter = 48,
			spiritSpring = 49,
			peacemaker = 50,
			pmcBEAR = 51,
			pmcUSEC = 52,
			skier = 53,
			purifyGroupBot = 54,
			sectantPredvestnik = 57,
			sectantPrizrak = 58,
			sectantOni = 59,
			infectedAssault = 60,
			infectedPmc = 61,
			infectedCivil = 62,
			infectedLaborant = 63,
			infectedTagilla = 64,
		}

		public enum EExfiltrationStatus
		{
			NotPresent = 1,
			UncompleteRequirements = 2,
			Countdown = 3,
			RegularMode = 4,
			Pending = 5,
			AwaitsManualActivation = 6,
		}

		public enum EMalfunctionState
		{
			None = 0,
			Misfire = 1,
			Jam = 2,
			HardSlide = 3,
			SoftSlide = 4,
			Feed = 5,
		}

		[Flags]
		public enum EPhysicalCondition
		{
			None = 0,
			OnPainkillers = 1,
			LeftLegDamaged = 2,
			RightLegDamaged = 4,
			ProneDisabled = 8,
			LeftArmDamaged = 16,
			RightArmDamaged = 32,
			Tremor = 64,
			UsingMeds = 128,
			HealingLegs = 256,
			JumpDisabled = 512,
			SprintDisabled = 1024,
			ProneMovementDisabled = 2048,
			Panic = 4096,
		}

		[Flags]
		public enum EProceduralAnimationMask
		{
			Breathing = 1,
			Walking = 2,
			MotionReaction = 4,
			ForceReaction = 8,
			Shooting = 16,
			DrawDown = 32,
			Aiming = 64,
			HandShake = 128,
		}

		[Flags]
		public enum EAnimatorMask
		{
			Thirdperson = 1,
			Arms = 2,
			Procedural = 4,
			FBBIK = 8,
			IK = 16,
		}

		public enum InventoryBlurDimensions
		{
			_128 = 128,
			_256 = 256,
			_512 = 512,
			_1024 = 1024,
			_2048 = 2048,
		}

		public enum ECameraType
		{
			Default = 0,
			Spectator = 1,
			UIBackground = 2,
			KillCamera = 3,
		}

		public enum ColorType
		{
			red = 1,
			fuchsia = 2,
			yellow = 3,
			green = 4,
			azure = 5,
			white = 6,
			blue = 7,
			grey = 8,
		}

		public enum EWeaponModType
		{
			mod_mount = 1,
			mod_scope = 2,
			mod_tactical = 4,
			mod_stock = 8,
			mod_magazine = 16,
			mod_barrel = 32,
			mod_handguard = 64,
			mod_muzzle = 128,
			mod_sight_front = 256,
			mod_sight_rear = 512,
			mod_foregrip = 1024,
			mod_reciever = 2048,
			mod_charge = 4096,
			mod_pistol_grip = 8192,
			mod_launcher = 16384,
			mod_bipod = 32768,
			mod_mag_shaft = 65536,
			mod_silencer = 131072,
			mod_tactical_2 = 262144,
			chamber0 = 524288,
			chamber1 = 1048576,
			patron_in_weapon = 2097152,
			mod_gas_block = 4194304,
			mod_equipment = 8388608,
			mod_equipment_000 = 16777216,
			mod_equipment_001 = 33554432,
			mod_nvg = 67108864,
			mod_flashlight = 134217728,
			mod_muzzle_001 = 268435456,
		}

		public enum EquipmentSlot
		{
			FirstPrimaryWeapon = 0,
			SecondPrimaryWeapon = 1,
			Holster = 2,
			Scabbard = 3,
			Backpack = 4,
			SecuredContainer = 5,
			TacticalVest = 6,
			ArmorVest = 7,
			Pockets = 8,
			Eyewear = 9,
			FaceCover = 10,
			Headwear = 11,
			Earpiece = 12,
			Dogtag = 13,
			ArmBand = 14,
		}

		public enum EFireMode
		{
			fullauto = 0,
			single = 1,
			doublet = 2,
			burst = 3,
			doubleaction = 4,
			semiauto = 5,
			grenadeThrowing = 6,
			greanadePlanting = 7,
		}

		public enum SynchronizableObjectType
		{
			AirDrop = 0,
			AirPlane = 1,
			Tripwire = 2,
		}

		public enum ETripwireState
		{
			None = 0,
			Wait = 1,
			Active = 2,
			Exploding = 3,
			Exploded = 4,
			Inert = 5,
		}

		public enum EQuestStatus
		{
			Locked = 0,
			AvailableForStart = 1,
			Started = 2,
			AvailableForFinish = 3,
			Success = 4,
			Fail = 5,
			FailRestartable = 6,
			MarkedAsFailed = 7,
			Expired = 8,
			AvailableAfter = 9,
		}
	}
}
