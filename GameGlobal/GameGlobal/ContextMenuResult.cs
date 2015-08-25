﻿namespace GameGlobal
{
    using System;

    public enum ContextMenuResult
    {
        None,
        KeepShowing,
        Architecture_Detail,
        Architecture_Persons,
        Architecture_Militaries,
        Architecture_NoFactionPersons,
        Architecture_Facilities,
        Architecture_Captive,
        Architecture_Treasure,
        Architecture_Informations,
        Architecture_Princesses,
        Architecture_LandLink,
        Architecture_WaterLink,
        Faction_Detail,
        Faction_Architectures,
        Faction_Troops,
        Faction_Persons,
        Faction_Militaries,
        Faction_AvailableMilitaryKinds,
        Faction_Captive,
        Faction_SelfCaptive,
        Faction_DiplomaticRelations,
        Faction_Techniques,
        Faction_Sections,
        Faction_Treasure,
        Faction_Informations,
        Internal_StopWork,
        Internal_zhenzai,
        Internal_Agriculture,
        Internal_Commerce,
        Internal_Technology,
        Internal_Domination,
        Internal_Morale,
        Internal_Endurance,
        Internal_Facility_Build,
        Internal_Facility_Demolish,
        Internal_Trade_BuyFood,
        Internal_Trade_SellFood,
        Internal_Expand,
        Military_Campaign,
        Military_Troopership,
        Military_Training,
        Military_Transfer, //运兵
        Military_New,
        Military_Recruitment,
        Military_Merge,
        Military_Disband,
        Military_LevelUp,
        Routeway_Design,
        Routeway_PointShortestNormal,
        Routeway_PointShortestNoWater,
        Routeway_ArchitectureShortestNormal,
        Routeway_ArchitectureShortestNoWater,
        Routeway_CloseAll,
        Routeway_DemolishAll,
        Transport_Fund,
        Transport_Food,
        Person_Transfer,
        Person_Convene,
        Person_Hire,
        Person_Convince,
        Person_AutoHire,
        Person_Reward,
        Person_RewardAll,
        Person_Redeem,
        Person_Study_Skill,
        Person_Study_Title,
        Person_Study_Stunt,
        RoutewayEdit,
        RoutewayShowArea,
        RoutewayBuild,
        RoutewayClose,
        RoutewayDemolish,
        Tactics_Information,
        Tactics_StopInformation,
        Tactics_Spy,
        Tactics_Destroy,
        Tactics_Instigate,
        Tactics_Gossip,
        Tactics_Search,
        Tactics_ClearField,
        Tactics_JailBreak,
        Tactics_Assassinate,
        Diplomacy,
        Monarch_Diplomatic_EnhanceDiplomaticRelation,
        Monarch_Diplomatic_AllyDiplomaticRelation,
        Monarch_Diplomatic_ResetDiplomaticRelation,
        Monarch_Diplomatic_DenounceDiplomaticRelation,
        Monarch_Diplomatic_TruceDiplomaticRelation,
        Monarch_officePosition_jingongzijin,
        Monarch_officePosition_jingongliangcao,
        Monarch_officePosition_SelfBecomeEmperor,
        Monarch_officePosition_BecomeEmperorLegally,
        Monarch_ChangeCapital,
        Monarch_SelectPrince,
        Monarch_Techniques,
        Monarch_MakeMarriage,
        Monarch_KillRelease_ReleaseSelfPerson,
        Monarch_KillRelease_ReleaseCaptive,
        Monarch_KillRelease_KillPerson,
        Monarch_KillRelease_KillCaptive,
        Monarch_hougongTop_nafei,
        Monarch_hougongTop_hougong,
        Monarch_hougongTop_moveFeizi,
        Monarch_Refuse,
        Monarch_Treasure_Confiscate,
        Monarch_Treasure_Award,
        Section_New,
        Section_Regroup,
        Section_Disband,
        Person_Hiring,
        Person_AutoReward,
        Internal_AutoWorking,
        Military_AutoRecruiting,
        Tactics_AutoSearching,
        AllEnter,
        DateGo_1Day,
        DateGo_2Days,
        DateGo_5Days,
        DateGo_10Days,
        DateGo_30Days,
        Jump_Architecture,
        Jump_Troop,
        Jump_Person,
        Switch_Smog,
        Switch_TroopTitle,
        Switch_Music,
        Switch_NormalSound,
        Switch_BattleSound,
        Switch_TroopAnimation,
        Switch_FullScreen,
        Switch_SkyEye,
        Switch_MultipleResource,
        Switch_StopOnAttack,
        Information_AllSkills,
        Information_AllTitles,
        Information_AllMilitaryKinds,
        Information_AllStunts,
        Information_AllFactions,
        Information_AllArchitectures,
        Information_AllTroops,
        Information_AllPersons,
        Information_AllMilitaries,
        Information_AllFacilities,
        Information_AllTerrainDetails,
        Information_AllSections,
        Information_AllRegions,
        Information_AllStates,
        Information_AllTreasures,
        Information_AllGuanjues,
        Information_AllDeadPersons,
        Load,
        Save,
        System,
        TroopMove,
        TroopTarget,
        TroopCombatMethod_Cancel,
        TroopCombatMethod,
        TroopStunt,
        TroopStratagem_Cancel,
        TroopStratagem_0,
        TroopStratagem_1,
        TroopStratagem_2,
        TroopStratagem_3,
        TroopStratagem_4,
        TroopStratagem_5,
        TroopStratagem_6,
        TroopStratagem_7,
        TroopStratagem_8,
        TroopStratagem_9,
        TroopStratagem_10,
        TroopStratagem_11,
        TroopStratagem_12,
        TroopStratagem_13,
        TroopStratagem_14,
        TroopStratagem_15,
        TroopStratagem_16,
        TroopStratagem_17,
        TroopStratagem_18,
        TroopStratagem_19,
        TroopEnter,
        TroopOccupy,
        TroopAction_LevyFood,
        TroopCutRouteway,
        TroopConfig_AttackDefaultKind,
        TroopConfig_AttackTargetKind,
        TroopConfig_CastDefaultKind,
        TroopConfig_CastTargetKind,
        TroopSetAuto,
        TroopIdle,
        TroopDetail,
        TroopPersons,
        TroopMilitary,
        TroopCaptive,
        TroopTreasure,
        TroopMorph,
        Plugins,
        CurrentArchitectureLeftClick,
        CurrentTroopLeftClick,
        CurrentArchitectureRightClick,
        CurrentTroopRightClick,
        CurrentRoutewayRightClick,
        YearTable_Year5,
        YearTable_OwnFaction,
        ChangeFaction
    }
}

