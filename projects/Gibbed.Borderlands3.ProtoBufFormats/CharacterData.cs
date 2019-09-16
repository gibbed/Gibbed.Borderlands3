/* Copyright (c) 2019 Rick (rick 'at' gibbed 'dot' us)
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Gibbed.Borderlands3.ProtoBufFormats
{
    [ProtoContract]
    public class CharacterData : INotifyPropertyChanged
    {
        #region Fields
        private uint _SaveGameID;
        private long _LastSaveTimestamp;
        private uint _TimePlayedSeconds;
        private CharacterClassData _Class;
        private List<ResourcePoolData> _ResourcePools;
        private List<RegionData> _Regions;
        private int _ExperiencePoints;
        private List<StatData> _Stats;
        private List<InventoryCategoryData> _InventoryCategories;
        private List<InventoryItemData> _InventoryItems;
        private List<EquippedInventoryData> _EquippedInventories;
        private List<int> _ActiveWeapons;
        private CharacterAbilityData _Ability;
        private int _LastPlaythroughIndex;
        private int _PlaythroughsCompleted;
        private bool _ShowNewPlaythroughNotification;
        private List<MissionPlaythroughData> _MissionPlaythroughs;
        private List<string> _ActiveTravelStations;
        private DiscoveryData _Discovery;
        private string _LastActiveTravelStation;
        private List<VehicleUnlockedData> _VehiclesUnlocked;
        private List<string> _VehiclePartsUnlocked;
        private List<CARMenuVehicleConfigurationData> _VehicleLoadouts;
        private int _VehicleLastLoadoutIndex;
        private List<ChallengeData> _Challenges;
        private List<SDUData> _SDUs;
        private List<string> _SelectedCustomizations;
        private List<int> _EquippedEmoteCustomizations;
        private List<CharacterCustomColorData> _SelectedColorCustomizations;
        private GuardianRankData _GuardianRank;
        private CrewQuartersRoomData _CrewQuartersRoom;
        private CrewQuartersGunRackData _CrewQuartersGunRack;
        private List<EchoLogData> _UnlockedEchoLogs;
        private bool _HasPlayedSpecialEchoLogInsertAlready;
        private List<CharacterNicknameMapping> _NicknameMappings;
        private MapIDData _LastTraveledMapID;
        private ChallengeCategoryProgressData _ChallengeCategoryProgress;
        private CharacterSlotData _CharacterSlot;
        private UITrackingData _UITracking;
        private string _PreferredCharacterName;
        private int _NameCharacterLimit;
        private uint _PreferredGroupMode;
        private TimeOfDayData _TimeOfDay;
        private List<LevelPersistenceLevelData> _LevelPersistenceData;
        private uint _AccumulatedLevelPersistenceResetTimerSeconds;
        private uint _MayhemLevel;
        private ZoneMapFODData _ZoneMapFOD;
        private List<ActiveFastTravelData> _ActiveOrBlacklistedTravelStations;
        private List<string> _LastActiveTravelStationForPlaythrough;
        private List<StateData> _StateForPlaythroughs;
        private List<RegisteredDownloadableEntitlementGroupData> _RegisteredDownloadableEntitlementGroups;
        private List<PlaythroughActiveFastTravelData> _ActiveTravelStationsForPlaythroughs;
        private string _SaveGameGuid;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public uint SaveGameID
        {
            get { return this._SaveGameID; }
            set
            {
                if (value != this._SaveGameID)
                {
                    this._SaveGameID = value;
                    this.NotifyOfPropertyChange(nameof(SaveGameID));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public long LastSaveTimestamp
        {
            get { return this._LastSaveTimestamp; }
            set
            {
                if (value != this._LastSaveTimestamp)
                {
                    this._LastSaveTimestamp = value;
                    this.NotifyOfPropertyChange(nameof(LastSaveTimestamp));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public uint TimePlayedSeconds
        {
            get { return this._TimePlayedSeconds; }
            set
            {
                if (value != this._TimePlayedSeconds)
                {
                    this._TimePlayedSeconds = value;
                    this.NotifyOfPropertyChange(nameof(TimePlayedSeconds));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public CharacterClassData Class
        {
            get { return this._Class; }
            set
            {
                if (value != this._Class)
                {
                    this._Class = value;
                    this.NotifyOfPropertyChange(nameof(Class));
                }
            }
        }

        [ProtoMember(5, IsRequired = true)]
        public List<ResourcePoolData> ResourcePools
        {
            get { return this._ResourcePools; }
            set
            {
                if (value != this._ResourcePools)
                {
                    this._ResourcePools = value;
                    this.NotifyOfPropertyChange(nameof(ResourcePools));
                }
            }
        }

        [ProtoMember(6, IsRequired = true)]
        public List<RegionData> Regions
        {
            get { return this._Regions; }
            set
            {
                if (value != this._Regions)
                {
                    this._Regions = value;
                    this.NotifyOfPropertyChange(nameof(Regions));
                }
            }
        }

        [ProtoMember(7, IsRequired = false)]
        public int ExperiencePoints
        {
            get { return this._ExperiencePoints; }
            set
            {
                if (value != this._ExperiencePoints)
                {
                    this._ExperiencePoints = value;
                    this.NotifyOfPropertyChange(nameof(ExperiencePoints));
                }
            }
        }

        [ProtoMember(8, IsRequired = true)]
        public List<StatData> Stats
        {
            get { return this._Stats; }
            set
            {
                if (value != this._Stats)
                {
                    this._Stats = value;
                    this.NotifyOfPropertyChange(nameof(Stats));
                }
            }
        }

        [ProtoMember(9, IsRequired = true)]
        public List<InventoryCategoryData> InventoryCategories
        {
            get { return this._InventoryCategories; }
            set
            {
                if (value != this._InventoryCategories)
                {
                    this._InventoryCategories = value;
                    this.NotifyOfPropertyChange(nameof(InventoryCategories));
                }
            }
        }

        [ProtoMember(10, IsRequired = true)]
        public List<InventoryItemData> InventoryItems
        {
            get { return this._InventoryItems; }
            set
            {
                if (value != this._InventoryItems)
                {
                    this._InventoryItems = value;
                    this.NotifyOfPropertyChange(nameof(InventoryItems));
                }
            }
        }

        [ProtoMember(11, IsRequired = true)]
        public List<EquippedInventoryData> EquippedInventories
        {
            get { return this._EquippedInventories; }
            set
            {
                if (value != this._EquippedInventories)
                {
                    this._EquippedInventories = value;
                    this.NotifyOfPropertyChange(nameof(EquippedInventories));
                }
            }
        }

        [ProtoMember(12, IsRequired = true, IsPacked = true)]
        public List<int> ActiveWeapons
        {
            get { return this._ActiveWeapons; }
            set
            {
                if (value != this._ActiveWeapons)
                {
                    this._ActiveWeapons = value;
                    this.NotifyOfPropertyChange(nameof(ActiveWeapons));
                }
            }
        }

        [ProtoMember(13, IsRequired = false)]
        public CharacterAbilityData Ability
        {
            get { return this._Ability; }
            set
            {
                if (value != this._Ability)
                {
                    this._Ability = value;
                    this.NotifyOfPropertyChange(nameof(Ability));
                }
            }
        }

        [ProtoMember(14, IsRequired = false)]
        public int LastPlaythroughIndex
        {
            get { return this._LastPlaythroughIndex; }
            set
            {
                if (value != this._LastPlaythroughIndex)
                {
                    this._LastPlaythroughIndex = value;
                    this.NotifyOfPropertyChange(nameof(LastPlaythroughIndex));
                }
            }
        }

        [ProtoMember(15, IsRequired = false)]
        public int PlaythroughsCompleted
        {
            get { return this._PlaythroughsCompleted; }
            set
            {
                if (value != this._PlaythroughsCompleted)
                {
                    this._PlaythroughsCompleted = value;
                    this.NotifyOfPropertyChange(nameof(PlaythroughsCompleted));
                }
            }
        }

        [ProtoMember(16, IsRequired = false)]
        public bool ShowNewPlaythroughNotification
        {
            get { return this._ShowNewPlaythroughNotification; }
            set
            {
                if (value != this._ShowNewPlaythroughNotification)
                {
                    this._ShowNewPlaythroughNotification = value;
                    this.NotifyOfPropertyChange(nameof(ShowNewPlaythroughNotification));
                }
            }
        }

        [ProtoMember(17, IsRequired = true)]
        public List<MissionPlaythroughData> MissionPlaythroughs
        {
            get { return this._MissionPlaythroughs; }
            set
            {
                if (value != this._MissionPlaythroughs)
                {
                    this._MissionPlaythroughs = value;
                    this.NotifyOfPropertyChange(nameof(MissionPlaythroughs));
                }
            }
        }

        [ProtoMember(21, IsRequired = true)]
        public List<string> ActiveTravelStations
        {
            get { return this._ActiveTravelStations; }
            set
            {
                if (value != this._ActiveTravelStations)
                {
                    this._ActiveTravelStations = value;
                    this.NotifyOfPropertyChange(nameof(ActiveTravelStations));
                }
            }
        }

        [ProtoMember(22, IsRequired = false)]
        public DiscoveryData Discovery
        {
            get { return this._Discovery; }
            set
            {
                if (value != this._Discovery)
                {
                    this._Discovery = value;
                    this.NotifyOfPropertyChange(nameof(Discovery));
                }
            }
        }

        [ProtoMember(23, IsRequired = false)]
        public string LastActiveTravelStation
        {
            get { return this._LastActiveTravelStation; }
            set
            {
                if (value != this._LastActiveTravelStation)
                {
                    this._LastActiveTravelStation = value;
                    this.NotifyOfPropertyChange(nameof(LastActiveTravelStation));
                }
            }
        }

        [ProtoMember(24, IsRequired = true)]
        public List<VehicleUnlockedData> VehiclesUnlocked
        {
            get { return this._VehiclesUnlocked; }
            set
            {
                if (value != this._VehiclesUnlocked)
                {
                    this._VehiclesUnlocked = value;
                    this.NotifyOfPropertyChange(nameof(VehiclesUnlocked));
                }
            }
        }

        [ProtoMember(25, IsRequired = true)]
        public List<string> VehiclePartsUnlocked
        {
            get { return this._VehiclePartsUnlocked; }
            set
            {
                if (value != this._VehiclePartsUnlocked)
                {
                    this._VehiclePartsUnlocked = value;
                    this.NotifyOfPropertyChange(nameof(VehiclePartsUnlocked));
                }
            }
        }

        [ProtoMember(26, IsRequired = true)]
        public List<CARMenuVehicleConfigurationData> VehicleLoadouts
        {
            get { return this._VehicleLoadouts; }
            set
            {
                if (value != this._VehicleLoadouts)
                {
                    this._VehicleLoadouts = value;
                    this.NotifyOfPropertyChange(nameof(VehicleLoadouts));
                }
            }
        }

        [ProtoMember(27, IsRequired = false)]
        public int VehicleLastLoadoutIndex
        {
            get { return this._VehicleLastLoadoutIndex; }
            set
            {
                if (value != this._VehicleLastLoadoutIndex)
                {
                    this._VehicleLastLoadoutIndex = value;
                    this.NotifyOfPropertyChange(nameof(VehicleLastLoadoutIndex));
                }
            }
        }

        [ProtoMember(28, IsRequired = true)]
        public List<ChallengeData> Challenges
        {
            get { return this._Challenges; }
            set
            {
                if (value != this._Challenges)
                {
                    this._Challenges = value;
                    this.NotifyOfPropertyChange(nameof(Challenges));
                }
            }
        }

        [ProtoMember(29, IsRequired = true)]
        public List<SDUData> SDUs
        {
            get { return this._SDUs; }
            set
            {
                if (value != this._SDUs)
                {
                    this._SDUs = value;
                    this.NotifyOfPropertyChange(nameof(SDUs));
                }
            }
        }

        [ProtoMember(30, IsRequired = true)]
        public List<string> SelectedCustomizations
        {
            get { return this._SelectedCustomizations; }
            set
            {
                if (value != this._SelectedCustomizations)
                {
                    this._SelectedCustomizations = value;
                    this.NotifyOfPropertyChange(nameof(SelectedCustomizations));
                }
            }
        }

        [ProtoMember(31, IsRequired = true, IsPacked = true)]
        public List<int> EquippedEmoteCustomizations
        {
            get { return this._EquippedEmoteCustomizations; }
            set
            {
                if (value != this._EquippedEmoteCustomizations)
                {
                    this._EquippedEmoteCustomizations = value;
                    this.NotifyOfPropertyChange(nameof(EquippedEmoteCustomizations));
                }
            }
        }

        [ProtoMember(32, IsRequired = true)]
        public List<CharacterCustomColorData> SelectedColorCustomizations
        {
            get { return this._SelectedColorCustomizations; }
            set
            {
                if (value != this._SelectedColorCustomizations)
                {
                    this._SelectedColorCustomizations = value;
                    this.NotifyOfPropertyChange(nameof(SelectedColorCustomizations));
                }
            }
        }

        [ProtoMember(33, IsRequired = false)]
        public GuardianRankData GuardianRank
        {
            get { return this._GuardianRank; }
            set
            {
                if (value != this._GuardianRank)
                {
                    this._GuardianRank = value;
                    this.NotifyOfPropertyChange(nameof(GuardianRank));
                }
            }
        }

        [ProtoMember(34, IsRequired = false)]
        public CrewQuartersRoomData CrewQuartersRoom
        {
            get { return this._CrewQuartersRoom; }
            set
            {
                if (value != this._CrewQuartersRoom)
                {
                    this._CrewQuartersRoom = value;
                    this.NotifyOfPropertyChange(nameof(CrewQuartersRoom));
                }
            }
        }

        [ProtoMember(35, IsRequired = false)]
        public CrewQuartersGunRackData CrewQuartersGunRack
        {
            get { return this._CrewQuartersGunRack; }
            set
            {
                if (value != this._CrewQuartersGunRack)
                {
                    this._CrewQuartersGunRack = value;
                    this.NotifyOfPropertyChange(nameof(CrewQuartersGunRack));
                }
            }
        }

        [ProtoMember(36, IsRequired = true)]
        public List<EchoLogData> UnlockedEchoLogs
        {
            get { return this._UnlockedEchoLogs; }
            set
            {
                if (value != this._UnlockedEchoLogs)
                {
                    this._UnlockedEchoLogs = value;
                    this.NotifyOfPropertyChange(nameof(UnlockedEchoLogs));
                }
            }
        }

        [ProtoMember(37, IsRequired = false)]
        public bool HasPlayedSpecialEchoLogInsertAlready
        {
            get { return this._HasPlayedSpecialEchoLogInsertAlready; }
            set
            {
                if (value != this._HasPlayedSpecialEchoLogInsertAlready)
                {
                    this._HasPlayedSpecialEchoLogInsertAlready = value;
                    this.NotifyOfPropertyChange(nameof(HasPlayedSpecialEchoLogInsertAlready));
                }
            }
        }

        [ProtoMember(38, IsRequired = true)]
        public List<CharacterNicknameMapping> NicknameMappings
        {
            get { return this._NicknameMappings; }
            set
            {
                if (value != this._NicknameMappings)
                {
                    this._NicknameMappings = value;
                    this.NotifyOfPropertyChange(nameof(NicknameMappings));
                }
            }
        }

        [ProtoMember(39, IsRequired = false)]
        public MapIDData LastTraveledMapID
        {
            get { return this._LastTraveledMapID; }
            set
            {
                if (value != this._LastTraveledMapID)
                {
                    this._LastTraveledMapID = value;
                    this.NotifyOfPropertyChange(nameof(LastTraveledMapID));
                }
            }
        }

        [ProtoMember(40, IsRequired = false)]
        public ChallengeCategoryProgressData ChallengeCategoryProgress
        {
            get { return this._ChallengeCategoryProgress; }
            set
            {
                if (value != this._ChallengeCategoryProgress)
                {
                    this._ChallengeCategoryProgress = value;
                    this.NotifyOfPropertyChange(nameof(ChallengeCategoryProgress));
                }
            }
        }

        [ProtoMember(41, IsRequired = false)]
        public CharacterSlotData Slot
        {
            get { return this._CharacterSlot; }
            set
            {
                if (value != this._CharacterSlot)
                {
                    this._CharacterSlot = value;
                    this.NotifyOfPropertyChange(nameof(Slot));
                }
            }
        }

        [ProtoMember(42, IsRequired = false)]
        public UITrackingData UITracking
        {
            get { return this._UITracking; }
            set
            {
                if (value != this._UITracking)
                {
                    this._UITracking = value;
                    this.NotifyOfPropertyChange(nameof(UITracking));
                }
            }
        }

        [ProtoMember(43, IsRequired = false)]
        public string PreferredCharacterName
        {
            get { return this._PreferredCharacterName; }
            set
            {
                if (value != this._PreferredCharacterName)
                {
                    this._PreferredCharacterName = value;
                    this.NotifyOfPropertyChange(nameof(PreferredCharacterName));
                }
            }
        }

        [ProtoMember(44, IsRequired = false)]
        public int NameCharacterLimit
        {
            get { return this._NameCharacterLimit; }
            set
            {
                if (value != this._NameCharacterLimit)
                {
                    this._NameCharacterLimit = value;
                    this.NotifyOfPropertyChange(nameof(NameCharacterLimit));
                }
            }
        }

        [ProtoMember(45, IsRequired = false)]
        public uint PreferredGroupMode
        {
            get { return this._PreferredGroupMode; }
            set
            {
                if (value != this._PreferredGroupMode)
                {
                    this._PreferredGroupMode = value;
                    this.NotifyOfPropertyChange(nameof(PreferredGroupMode));
                }
            }
        }

        [ProtoMember(46, IsRequired = false)]
        public TimeOfDayData TimeOfDay
        {
            get { return this._TimeOfDay; }
            set
            {
                if (value != this._TimeOfDay)
                {
                    this._TimeOfDay = value;
                    this.NotifyOfPropertyChange(nameof(TimeOfDay));
                }
            }
        }

        [ProtoMember(47, IsRequired = true)]
        public List<LevelPersistenceLevelData> LevelPersistenceData
        {
            get { return this._LevelPersistenceData; }
            set
            {
                if (value != this._LevelPersistenceData)
                {
                    this._LevelPersistenceData = value;
                    this.NotifyOfPropertyChange(nameof(LevelPersistenceData));
                }
            }
        }

        [ProtoMember(48, IsRequired = false)]
        public uint AccumulatedLevelPersistenceResetTimerSeconds
        {
            get { return this._AccumulatedLevelPersistenceResetTimerSeconds; }
            set
            {
                if (value != this._AccumulatedLevelPersistenceResetTimerSeconds)
                {
                    this._AccumulatedLevelPersistenceResetTimerSeconds = value;
                    this.NotifyOfPropertyChange(nameof(AccumulatedLevelPersistenceResetTimerSeconds));
                }
            }
        }

        [ProtoMember(49, IsRequired = false)]
        public uint MayhemLevel
        {
            get { return this._MayhemLevel; }
            set
            {
                if (value != this._MayhemLevel)
                {
                    this._MayhemLevel = value;
                    this.NotifyOfPropertyChange(nameof(MayhemLevel));
                }
            }
        }

        [ProtoMember(50, IsRequired = false)]
        public ZoneMapFODData ZoneMapFOD
        {
            get { return this._ZoneMapFOD; }
            set
            {
                if (value != this._ZoneMapFOD)
                {
                    this._ZoneMapFOD = value;
                    this.NotifyOfPropertyChange(nameof(ZoneMapFOD));
                }
            }
        }

        [ProtoMember(51, IsRequired = true)]
        public List<ActiveFastTravelData> ActiveOrBlacklistedTravelStations
        {
            get { return this._ActiveOrBlacklistedTravelStations; }
            set
            {
                if (value != this._ActiveOrBlacklistedTravelStations)
                {
                    this._ActiveOrBlacklistedTravelStations = value;
                    this.NotifyOfPropertyChange(nameof(ActiveOrBlacklistedTravelStations));
                }
            }
        }
        [ProtoMember(52, IsRequired = true)]
        public List<string> LastActiveTravelStationForPlaythrough
        {
            get { return this._LastActiveTravelStationForPlaythrough; }
            set
            {
                if (value != this._LastActiveTravelStationForPlaythrough)
                {
                    this._LastActiveTravelStationForPlaythrough = value;
                    this.NotifyOfPropertyChange(nameof(LastActiveTravelStationForPlaythrough));
                }
            }
        }

        [ProtoMember(53, IsRequired = true)]
        public List<StateData> StateForPlaythroughs
        {
            get { return this._StateForPlaythroughs; }
            set
            {
                if (value != this._StateForPlaythroughs)
                {
                    this._StateForPlaythroughs = value;
                    this.NotifyOfPropertyChange(nameof(StateForPlaythroughs));
                }
            }
        }

        [ProtoMember(54, IsRequired = true)]
        public List<RegisteredDownloadableEntitlementGroupData> RegisteredDownloadableEntitlementGroups
        {
            get { return this._RegisteredDownloadableEntitlementGroups; }
            set
            {
                if (value != this._RegisteredDownloadableEntitlementGroups)
                {
                    this._RegisteredDownloadableEntitlementGroups = value;
                    this.NotifyOfPropertyChange(nameof(RegisteredDownloadableEntitlementGroups));
                }
            }
        }

        [ProtoMember(55, IsRequired = true)]
        public List<PlaythroughActiveFastTravelData> ActiveTravelStationsForPlaythroughs
        {
            get { return this._ActiveTravelStationsForPlaythroughs; }
            set
            {
                if (value != this._ActiveTravelStationsForPlaythroughs)
                {
                    this._ActiveTravelStationsForPlaythroughs = value;
                    this.NotifyOfPropertyChange(nameof(ActiveTravelStationsForPlaythroughs));
                }
            }
        }

        [ProtoMember(56, IsRequired = false)]
        public string SaveGameGuid
        {
            get { return this._SaveGameGuid; }
            set
            {
                if (value != this._SaveGameGuid)
                {
                    this._SaveGameGuid = value;
                    this.NotifyOfPropertyChange(nameof(SaveGameGuid));
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
