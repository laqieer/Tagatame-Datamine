// Decompiled with JetBrains decompiler
// Type: SRPG.GlobalVars
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F71")]
  public static class GlobalVars
  {
    [Token(Token = "0x400351F")]
    [FieldOffset(Offset = "0x0")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<eOverWritePartyType> OverWritePartyType;
    [Token(Token = "0x4003520")]
    [FieldOffset(Offset = "0x4")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<int> SelectedPartyIndex;
    [Token(Token = "0x4003521")]
    [FieldOffset(Offset = "0x8")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> SelectedChapter;
    [Token(Token = "0x4003522")]
    [FieldOffset(Offset = "0xC")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> SelectedSection;
    [Token(Token = "0x4003523")]
    [FieldOffset(Offset = "0x10")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<int> SelectedStoryPart;
    [Token(Token = "0x4003524")]
    [FieldOffset(Offset = "0x14")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> HomeBgSection;
    [Token(Token = "0x4003525")]
    [FieldOffset(Offset = "0x18")]
    public static int BanStatus;
    [Token(Token = "0x4003526")]
    [FieldOffset(Offset = "0x1C")]
    public static string CustomerID;
    [Token(Token = "0x4003527")]
    [FieldOffset(Offset = "0x20")]
    public static Vector2 Location;
    [Token(Token = "0x4003528")]
    [FieldOffset(Offset = "0x28")]
    public static GlobalVars.GlobalVar<long> BtlID;
    [Token(Token = "0x4003529")]
    [FieldOffset(Offset = "0x2C")]
    public static GlobalVars.GlobalVar<bool> BtlIDStatus;
    [Token(Token = "0x400352A")]
    [FieldOffset(Offset = "0x30")]
    public static QuestTypes QuestType;
    [Token(Token = "0x400352B")]
    [FieldOffset(Offset = "0x34")]
    public static GlobalVars.GlobalVar<long> ContinueBtlID;
    [Token(Token = "0x400352C")]
    [FieldOffset(Offset = "0x38")]
    public static BattleCore.Record ContinueBtlRecord;
    [Token(Token = "0x400352D")]
    [FieldOffset(Offset = "0x3C")]
    public static GlobalVars.GlobalVar<SupportData> SelectedSupport;
    [Token(Token = "0x400352E")]
    [FieldOffset(Offset = "0x40")]
    public static int SelectedTeamIndex;
    [Token(Token = "0x400352F")]
    [FieldOffset(Offset = "0x44")]
    public static string SelectedFriendID;
    [Token(Token = "0x4003530")]
    [FieldOffset(Offset = "0x48")]
    public static string SelectedQuestID;
    [Token(Token = "0x4003531")]
    [FieldOffset(Offset = "0x4C")]
    public static string SelectedItemID;
    [Token(Token = "0x4003532")]
    [FieldOffset(Offset = "0x50")]
    public static string SelectedCreateItemID;
    [Token(Token = "0x4003533")]
    [FieldOffset(Offset = "0x54")]
    public static string EditPlayerName;
    [Token(Token = "0x4003534")]
    [FieldOffset(Offset = "0x58")]
    public static string SelectedArtifactID;
    [Token(Token = "0x4003535")]
    [FieldOffset(Offset = "0x5C")]
    public static string SelectedArchiveID;
    [Token(Token = "0x4003536")]
    [FieldOffset(Offset = "0x60")]
    public static EncodingTypes.ESerializeCompressMethod SelectedSerializeCompressMethod;
    [Token(Token = "0x4003537")]
    [FieldOffset(Offset = "0x64")]
    public static bool SelectedSerializeCompressMethodWasNodeSet;
    [Token(Token = "0x4003538")]
    [FieldOffset(Offset = "0x68")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> LastPlayedQuest;
    [Token(Token = "0x4003539")]
    [FieldOffset(Offset = "0x6C")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<QuestStates> LastQuestState;
    [Token(Token = "0x400353A")]
    [FieldOffset(Offset = "0x70")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<BattleCore.QuestResult> LastQuestResult;
    [Token(Token = "0x400353B")]
    [FieldOffset(Offset = "0x74")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> SelectedAbilityID;
    [Token(Token = "0x400353C")]
    [FieldOffset(Offset = "0x78")]
    [GlobalVars.ResetOnLogin]
    public static List<QuestDifficulties> GenesisAvailableDifficulties;
    [Token(Token = "0x400353D")]
    [FieldOffset(Offset = "0x7C")]
    public static string UnlockUnitID;
    [Token(Token = "0x400353E")]
    [FieldOffset(Offset = "0x80")]
    public static GlobalVars.GlobalVar<ArenaPlayer> SelectedArenaPlayer;
    [Token(Token = "0x400353F")]
    [FieldOffset(Offset = "0x84")]
    public static ArenaBattleResponse ResultArenaBattleResponse;
    [Token(Token = "0x4003540")]
    [FieldOffset(Offset = "0x88")]
    public static GlobalVars.GlobalVar<DuelPlayerData> SelectedDuelPlayer;
    [Token(Token = "0x4003541")]
    [FieldOffset(Offset = "0x8C")]
    public static GlobalVars.GlobalVar<string> SelectedTrophy;
    [Token(Token = "0x4003542")]
    [FieldOffset(Offset = "0x90")]
    public static List<string> SelectedTrophies;
    [Token(Token = "0x4003543")]
    [FieldOffset(Offset = "0x94")]
    public static GlobalVars.GlobalVar<long> SelectedUnitUniqueID;
    [Token(Token = "0x4003544")]
    [FieldOffset(Offset = "0x98")]
    public static GlobalVars.GlobalVar<long> SelectedEquipUniqueID;
    [Token(Token = "0x4003545")]
    [FieldOffset(Offset = "0x9C")]
    public static GlobalVars.GlobalVar<long> SelectedJobUniqueID;
    [Token(Token = "0x4003546")]
    [FieldOffset(Offset = "0xA0")]
    public static GlobalVars.GlobalVar<long> PreBattleUnitUniqueID;
    [Token(Token = "0x4003547")]
    [FieldOffset(Offset = "0xA4")]
    public static GlobalVars.GlobalVar<TobiraParam.Category> PreBattleUnitTobiraCategory;
    [Token(Token = "0x4003548")]
    [FieldOffset(Offset = "0xA8")]
    public static GlobalVars.GlobalVar<int> SelectedUnitDoorLevelUpCount;
    [Token(Token = "0x4003549")]
    [FieldOffset(Offset = "0xAC")]
    public static GlobalVars.GlobalVar<long> SelectedLSChangeUnitUniqueID;
    [Token(Token = "0x400354A")]
    [FieldOffset(Offset = "0xB0")]
    public static GlobalVars.GlobalVar<long> SelectedArtifactUniqueID;
    [Token(Token = "0x400354B")]
    [FieldOffset(Offset = "0xB4")]
    public static List<long> SelectedArtifactUniqueIDList;
    [Token(Token = "0x400354C")]
    [FieldOffset(Offset = "0xB8")]
    public static GlobalVars.GlobalVar<string> SelectedArtifactIname;
    [Token(Token = "0x400354D")]
    [FieldOffset(Offset = "0xBC")]
    public static Dictionary<string, int> UsedArtifactExpItems;
    [Token(Token = "0x400354E")]
    [FieldOffset(Offset = "0xC0")]
    public static List<long> SellArtifactsList;
    [Token(Token = "0x400354F")]
    [FieldOffset(Offset = "0xC4")]
    public static List<long> ConvertArtifactsList;
    [Token(Token = "0x4003550")]
    [FieldOffset(Offset = "0xC8")]
    public static GlobalVars.GlobalVar<int> SelectedEquipmentSlot;
    [Token(Token = "0x4003551")]
    [FieldOffset(Offset = "0xCC")]
    public static GlobalVars.GlobalVar<int> SelectedUnitJobIndex;
    [Token(Token = "0x4003552")]
    [FieldOffset(Offset = "0xD0")]
    public static List<ItemParam> SelectedItemParamTree;
    [Token(Token = "0x4003553")]
    [FieldOffset(Offset = "0xD4")]
    public static GlobalVars.GlobalVar<int> SelectedAbilitySlot;
    [Token(Token = "0x4003554")]
    [FieldOffset(Offset = "0xD8")]
    public static GlobalVars.GlobalVar<long> SelectedAbilityUniqueID;
    [Token(Token = "0x4003555")]
    [FieldOffset(Offset = "0xDC")]
    public static GlobalVars.GlobalVar<long> SelectedMailUniqueID;
    [Token(Token = "0x4003556")]
    [FieldOffset(Offset = "0xE0")]
    public static GlobalVars.GlobalVar<int> SelectedMailPeriod;
    [Token(Token = "0x4003557")]
    [FieldOffset(Offset = "0xE4")]
    public static GlobalVars.GlobalVar<int> SelectedMailPage;
    [Token(Token = "0x4003558")]
    [FieldOffset(Offset = "0xE8")]
    public static GlobalVars.GlobalVar<RewardData> LastReward;
    [Token(Token = "0x4003559")]
    [FieldOffset(Offset = "0xEC")]
    public static Unit MainTarget;
    [Token(Token = "0x400355A")]
    [FieldOffset(Offset = "0xF0")]
    public static Unit SubTarget;
    [Token(Token = "0x400355B")]
    [FieldOffset(Offset = "0xF4")]
    public static FriendData SelectedFriend;
    [Token(Token = "0x400355C")]
    [FieldOffset(Offset = "0xF8")]
    public static FriendData FoundFriend;
    [Token(Token = "0x400355D")]
    [FieldOffset(Offset = "0xFC")]
    public static int RaidNum;
    [Token(Token = "0x400355E")]
    [FieldOffset(Offset = "0x100")]
    public static RaidResult RaidResult;
    [Token(Token = "0x400355F")]
    [FieldOffset(Offset = "0x104")]
    public static int FriendMasteryRank;
    [Token(Token = "0x4003560")]
    [FieldOffset(Offset = "0x108")]
    public static GlobalVars.GlobalVar<int> PlayerExpOld;
    [Token(Token = "0x4003561")]
    [FieldOffset(Offset = "0x10C")]
    public static GlobalVars.GlobalVar<int> PlayerExpNew;
    [Token(Token = "0x4003562")]
    [FieldOffset(Offset = "0x110")]
    public static GlobalVars.GlobalVar<bool> PlayerLevelChanged;
    [Token(Token = "0x4003563")]
    [FieldOffset(Offset = "0x114")]
    public static string SelectedGachaTableId;
    [Token(Token = "0x4003564")]
    [FieldOffset(Offset = "0x118")]
    public static EShopType ShopType;
    [Token(Token = "0x4003565")]
    [FieldOffset(Offset = "0x11C")]
    public static int ShopBuyIndex;
    [Token(Token = "0x4003566")]
    [FieldOffset(Offset = "0x120")]
    public static int ShopBuyAmount;
    [Token(Token = "0x4003567")]
    [FieldOffset(Offset = "0x124")]
    public static UnitPieceShopItem BuyUnitPieceShopItem;
    [Token(Token = "0x4003568")]
    [FieldOffset(Offset = "0x128")]
    public static List<ShopItem> TimeOutShopItems;
    [Token(Token = "0x4003569")]
    [FieldOffset(Offset = "0x12C")]
    public static LimitedShopListItemInfo LimitedShopInfo;
    [Token(Token = "0x400356A")]
    [FieldOffset(Offset = "0x130")]
    public static EventShopInfo EventShopItem;
    [Token(Token = "0x400356B")]
    [FieldOffset(Offset = "0x134")]
    public static List<EventShopInfo> EventShopInfos;
    [Token(Token = "0x400356C")]
    [FieldOffset(Offset = "0x138")]
    public static EventShopInfo SelectionEventShopInfo;
    [Token(Token = "0x400356D")]
    [FieldOffset(Offset = "0x13C")]
    public static GlobalVars.CoinListSelectionType SelectionCoinListType;
    [Token(Token = "0x400356E")]
    [FieldOffset(Offset = "0x140")]
    public static SellItem SelectSellItem;
    [Token(Token = "0x400356F")]
    [FieldOffset(Offset = "0x144")]
    public static List<SellItem> SellItemList;
    [Token(Token = "0x4003570")]
    [FieldOffset(Offset = "0x148")]
    public static List<SellItem> ConvertAwakePieceList;
    [Token(Token = "0x4003571")]
    [FieldOffset(Offset = "0x14C")]
    public static GlobalVars.GlobalVar<GlobalVars.JobRankUpTypes> JobRankUpType;
    [Token(Token = "0x4003572")]
    [FieldOffset(Offset = "0x150")]
    public static List<AbilityData> LearningAbilities;
    [Token(Token = "0x4003573")]
    [FieldOffset(Offset = "0x154")]
    public static List<ItemData> ReturnItems;
    [Token(Token = "0x4003574")]
    [FieldOffset(Offset = "0x158")]
    public static Dictionary<long, int> AbilitiesRankUp;
    [Token(Token = "0x4003575")]
    [FieldOffset(Offset = "0x15C")]
    public static EquipData SelectedEquipData;
    [Token(Token = "0x4003576")]
    [FieldOffset(Offset = "0x160")]
    public static List<EnhanceMaterial> SelectedEnhanceMaterials;
    [Token(Token = "0x4003577")]
    [FieldOffset(Offset = "0x164")]
    public static Dictionary<string, int> UsedUnitExpItems;
    [Token(Token = "0x4003578")]
    [FieldOffset(Offset = "0x168")]
    public static ArtifactData TargetInspSkillArtifact;
    [Token(Token = "0x4003579")]
    [FieldOffset(Offset = "0x16C")]
    public static InspirationSkillData TargetInspSkill;
    [Token(Token = "0x400357A")]
    [FieldOffset(Offset = "0x170")]
    public static List<ArtifactData> MixInspSkillArtifactList;
    [Token(Token = "0x400357B")]
    [FieldOffset(Offset = "0x174")]
    public static string EditMultiPlayRoomComment;
    [Token(Token = "0x400357C")]
    [FieldOffset(Offset = "0x178")]
    public static string EditMultiPlayRoomPassCode;
    [Token(Token = "0x400357D")]
    [FieldOffset(Offset = "0x17C")]
    public static bool SelectedMultiPlayQuestIsEvent;
    [Token(Token = "0x400357E")]
    [FieldOffset(Offset = "0x180")]
    public static PhotonRoomData.RoomType SelectedMPRoomType;
    [Token(Token = "0x400357F")]
    [FieldOffset(Offset = "0x184")]
    public static string SelectedMultiPlayArea;
    [Token(Token = "0x4003580")]
    [FieldOffset(Offset = "0x188")]
    public static string SelectedMultiPlayRoomName;
    [Token(Token = "0x4003581")]
    [FieldOffset(Offset = "0x18C")]
    public static string SelectedMultiPlayRoomComment;
    [Token(Token = "0x4003582")]
    [FieldOffset(Offset = "0x190")]
    public static string SelectedMultiPlayRoomPassCodeHash;
    [Token(Token = "0x4003583")]
    [FieldOffset(Offset = "0x194")]
    public static PhotonPlayerData SelectedMultiPlayerData;
    [Token(Token = "0x4003584")]
    [FieldOffset(Offset = "0x198")]
    public static List<int> SelectedMultiPlayerUnitIDs;
    [Token(Token = "0x4003585")]
    [FieldOffset(Offset = "0x19C")]
    public static VERSUS_TYPE SelectedMultiPlayVersusType;
    [Token(Token = "0x4003586")]
    [FieldOffset(Offset = "0x1A0")]
    public static string MultiPlayVersusKey;
    [Token(Token = "0x4003587")]
    [FieldOffset(Offset = "0x1A4")]
    public static bool VersusRoomReuse;
    [Token(Token = "0x4003588")]
    [FieldOffset(Offset = "0x1A5")]
    public static bool SelectedMultiPlayLimit;
    [Token(Token = "0x4003589")]
    [FieldOffset(Offset = "0x1A6")]
    public static bool MultiPlayClearOnly;
    [Token(Token = "0x400358A")]
    [FieldOffset(Offset = "0x1A8")]
    public static int MultiPlayJoinUnitLv;
    [Token(Token = "0x400358B")]
    [FieldOffset(Offset = "0x1AC")]
    public static string SelectedMultiTowerID;
    [Token(Token = "0x400358C")]
    [FieldOffset(Offset = "0x1B0")]
    public static int SelectedMultiTowerFloor;
    [Token(Token = "0x400358D")]
    [FieldOffset(Offset = "0x1B4")]
    public static bool CreateAutoMultiTower;
    [Token(Token = "0x400358E")]
    [FieldOffset(Offset = "0x1B5")]
    public static bool InvtationSameUser;
    [Token(Token = "0x400358F")]
    [FieldOffset(Offset = "0x1B8")]
    public static GlobalVars.GlobalVar<VersusCpuData> VersusCpu;
    [Token(Token = "0x4003590")]
    [FieldOffset(Offset = "0x1C0")]
    public static long VersusFreeMatchTime;
    [Token(Token = "0x4003591")]
    [FieldOffset(Offset = "0x1C8")]
    public static bool IsVersusDraftMode;
    [Token(Token = "0x4003592")]
    [FieldOffset(Offset = "0x1CC")]
    public static GlobalVars.EMultiPlayContinue SelectedMultiPlayContinue;
    [Token(Token = "0x4003593")]
    [FieldOffset(Offset = "0x1D0")]
    public static BattleCore.Json_BattleCont MultiPlayBattleCont;
    [Token(Token = "0x4003594")]
    [FieldOffset(Offset = "0x1D4")]
    public static int ResumeMultiplayPlayerID;
    [Token(Token = "0x4003595")]
    [FieldOffset(Offset = "0x1D8")]
    public static int ResumeMultiplaySeatID;
    [Token(Token = "0x4003596")]
    [FieldOffset(Offset = "0x1DC")]
    public static int MultiInvitation;
    [Token(Token = "0x4003597")]
    [FieldOffset(Offset = "0x1E0")]
    public static string MultiInvitationRoomOwner;
    [Token(Token = "0x4003598")]
    [FieldOffset(Offset = "0x1E4")]
    public static bool MultiInvitationRoomLocked;
    [Token(Token = "0x4003599")]
    [FieldOffset(Offset = "0x1E5")]
    public static bool MultiInvitaionFlag;
    [Token(Token = "0x400359A")]
    [FieldOffset(Offset = "0x1E8")]
    public static string MultiInvitaionComment;
    [Token(Token = "0x400359B")]
    [FieldOffset(Offset = "0x1EC")]
    public static int SelectedMultiPlayRoomID;
    [Token(Token = "0x400359C")]
    [FieldOffset(Offset = "0x1F0")]
    public static string SelectedMultiPlayPhotonAppID;
    [Token(Token = "0x400359D")]
    [FieldOffset(Offset = "0x1F4")]
    public static bool SelectedMultiPlayHiSpeed;
    [Token(Token = "0x400359E")]
    [FieldOffset(Offset = "0x1F8")]
    public static int SelectedMultiPlayBtlSpeed;
    [Token(Token = "0x400359F")]
    [FieldOffset(Offset = "0x1FC")]
    public static bool SelectedMultiPlayAutoAllowed;
    [Token(Token = "0x40035A0")]
    [FieldOffset(Offset = "0x200")]
    public static int SelectedRankMatchPlayBtlSpeed;
    [Token(Token = "0x40035A1")]
    [FieldOffset(Offset = "0x204")]
    public static int SelectedVersusPlayBtlSpeed;
    [Token(Token = "0x40035A2")]
    [FieldOffset(Offset = "0x208")]
    public static int SelectedFriendMatchPlayBtlSpeed;
    [Token(Token = "0x40035A3")]
    [FieldOffset(Offset = "0x20C")]
    public static int SelectedPvPPlayBtlSpeed;
    [Token(Token = "0x40035A4")]
    [FieldOffset(Offset = "0x210")]
    public static List<MultiPlayAPIRoom> MultiPlayRoomList;
    [Token(Token = "0x40035A5")]
    [FieldOffset(Offset = "0x214")]
    public static int SelectedTowerMultiPartyIndex;
    [Token(Token = "0x40035A6")]
    [FieldOffset(Offset = "0x218")]
    public static List<List<VersusRankReward>> RankMatchSeasonReward;
    [Token(Token = "0x40035A7")]
    [FieldOffset(Offset = "0x21C")]
    public static GlobalVars.GlobalVar<RaidManager.RaidOwnerType> RestoreOwnerType;
    [Token(Token = "0x40035A8")]
    [FieldOffset(Offset = "0x220")]
    public static GlobalVars.GlobalVar<int> CurrentRaidBossId;
    [Token(Token = "0x40035A9")]
    [FieldOffset(Offset = "0x224")]
    public static GlobalVars.GlobalVar<string> CurrentWorldRaidIname;
    [Token(Token = "0x40035AA")]
    [FieldOffset(Offset = "0x228")]
    public static GlobalVars.GlobalVar<string> CurrentRaidBossIname;
    [Token(Token = "0x40035AB")]
    [FieldOffset(Offset = "0x22C")]
    public static GlobalVars.GlobalVar<int> CurrentRaidRound;
    [Token(Token = "0x40035AC")]
    [FieldOffset(Offset = "0x230")]
    public static GlobalVars.GlobalVar<int> CurrentRaidBossHP;
    [Token(Token = "0x40035AD")]
    [FieldOffset(Offset = "0x234")]
    public static GlobalVars.GlobalVar<long> CurrentWorldRaidBossHP;
    [Token(Token = "0x40035AE")]
    [FieldOffset(Offset = "0x238")]
    public static GlobalVars.GlobalVar<GuildRaidBattleType> CurrentBattleType;
    [Token(Token = "0x40035AF")]
    [FieldOffset(Offset = "0x23C")]
    public static GlobalVars.GlobalVar<int> CurrentGuildRaidTurnRemain;
    [Token(Token = "0x40035B0")]
    [FieldOffset(Offset = "0x240")]
    public static GlobalVars.GlobalVar<int> CurrentWorldRaidLap;
    [Token(Token = "0x40035B1")]
    [FieldOffset(Offset = "0x244")]
    public static GlobalVars.GlobalVar<GvGParty> GvGOffenseParty;
    [Token(Token = "0x40035B2")]
    [FieldOffset(Offset = "0x248")]
    public static GlobalVars.GlobalVar<GvGParty> GvGDefenseParty;
    [Token(Token = "0x40035B3")]
    [FieldOffset(Offset = "0x24C")]
    public static GlobalVars.GlobalVar<int> GvGBattleSeed;
    [Token(Token = "0x40035B4")]
    [FieldOffset(Offset = "0x250")]
    public static GlobalVars.GlobalVar<bool> GvGBattleReplay;
    [Token(Token = "0x40035B5")]
    [FieldOffset(Offset = "0x254")]
    public static GlobalVars.GlobalVar<bool> GvGBattleMode;
    [Token(Token = "0x40035B6")]
    [FieldOffset(Offset = "0x258")]
    public static GlobalVars.GlobalVar<int> GvGNodeId;
    [Token(Token = "0x40035B7")]
    [FieldOffset(Offset = "0x25C")]
    public static GlobalVars.GlobalVar<int> GvGGroupId;
    [Token(Token = "0x40035B8")]
    [FieldOffset(Offset = "0x260")]
    public static GlobalVars.GlobalVar<bool> ResultGvGCapture;
    [Token(Token = "0x40035B9")]
    [FieldOffset(Offset = "0x264")]
    public static string SelectedProductID;
    [Token(Token = "0x40035BA")]
    [FieldOffset(Offset = "0x268")]
    public static string SelectedProductIname;
    [Token(Token = "0x40035BB")]
    [FieldOffset(Offset = "0x26C")]
    public static int SelectedSetUpIndex;
    [Token(Token = "0x40035BC")]
    [FieldOffset(Offset = "0x270")]
    public static int EditedYear;
    [Token(Token = "0x40035BD")]
    [FieldOffset(Offset = "0x274")]
    public static int EditedMonth;
    [Token(Token = "0x40035BE")]
    [FieldOffset(Offset = "0x278")]
    public static int EditedDay;
    [Token(Token = "0x40035BF")]
    [FieldOffset(Offset = "0x27C")]
    public static int BeforeCoin;
    [Token(Token = "0x40035C0")]
    [FieldOffset(Offset = "0x280")]
    public static int AfterCoin;
    [Token(Token = "0x40035C1")]
    [FieldOffset(Offset = "0x284")]
    public static bool IsTutorialEnd;
    [Token(Token = "0x40035C2")]
    [FieldOffset(Offset = "0x288")]
    public static string PubHash;
    [Token(Token = "0x40035C3")]
    [FieldOffset(Offset = "0x28C")]
    public static string UrgencyPubHash;
    [Token(Token = "0x40035C4")]
    [FieldOffset(Offset = "0x290")]
    public static string SelectedChallengeMissionTrophy;
    [Token(Token = "0x40035C5")]
    [FieldOffset(Offset = "0x294")]
    public static GlobalVars.GlobalVar<int> CurrentChatChannel;
    [Token(Token = "0x40035C6")]
    [FieldOffset(Offset = "0x298")]
    public static int ChatChannelViewNum;
    [Token(Token = "0x40035C7")]
    [FieldOffset(Offset = "0x29C")]
    public static int ChatChannelMax;
    [Token(Token = "0x40035C8")]
    [FieldOffset(Offset = "0x2A0")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> ReplaySelectedChapter;
    [Token(Token = "0x40035C9")]
    [FieldOffset(Offset = "0x2A4")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> ReplaySelectedSection;
    [Token(Token = "0x40035CA")]
    [FieldOffset(Offset = "0x2A8")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> ReplaySelectedQuestID;
    [Token(Token = "0x40035CB")]
    [FieldOffset(Offset = "0x2AC")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> ReplaySelectedNextQuestID;
    [Token(Token = "0x40035CC")]
    [FieldOffset(Offset = "0x2B0")]
    public static UnitGetParam UnitGetReward;
    [Token(Token = "0x40035CD")]
    [FieldOffset(Offset = "0x2B4")]
    public static string PreEventName;
    [Token(Token = "0x40035CE")]
    [FieldOffset(Offset = "0x2B8")]
    public static bool ForceSceneChange;
    [Token(Token = "0x40035CF")]
    [FieldOffset(Offset = "0x2BC")]
    public static GlobalVars.EventQuestListType ReqEventPageListType;
    [Token(Token = "0x40035D0")]
    [FieldOffset(Offset = "0x2C0")]
    public static bool KeyQuestTimeOver;
    [Token(Token = "0x40035D1")]
    [FieldOffset(Offset = "0x2C8")]
    public static long mDropTableGeneratedUnixTime;
    [Token(Token = "0x40035D2")]
    [FieldOffset(Offset = "0x2D0")]
    public static string SelectedTowerID;
    [Token(Token = "0x40035D3")]
    [FieldOffset(Offset = "0x2D4")]
    public static string SelectedFloorID;
    [Token(Token = "0x40035D4")]
    [FieldOffset(Offset = "0x2D8")]
    public static GlobalVars.GlobalVar<long> SelectedSupportUnitUniqueID;
    [Token(Token = "0x40035D5")]
    [FieldOffset(Offset = "0x2DC")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsEventShopOpen;
    [Token(Token = "0x40035D6")]
    [FieldOffset(Offset = "0x2E0")]
    public static ItemSelectListItemData ItemSelectListItemData;
    [Token(Token = "0x40035D7")]
    [FieldOffset(Offset = "0x2E4")]
    public static ArtifactSelectListItemData ArtifactListItem;
    [Token(Token = "0x40035D8")]
    [FieldOffset(Offset = "0x2E8")]
    public static string[] ConditionJobs;
    [Token(Token = "0x40035D9")]
    [FieldOffset(Offset = "0x2EC")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsDirtyArtifactData;
    [Token(Token = "0x40035DA")]
    [FieldOffset(Offset = "0x2F0")]
    public static CollaboSkillParam.Pair SelectedCollaboSkillPair;
    [Token(Token = "0x40035DB")]
    [FieldOffset(Offset = "0x2F4")]
    public static string TeamName;
    [Token(Token = "0x40035DC")]
    [FieldOffset(Offset = "0x2F8")]
    public static GlobalVars.UserSelectionPartyData UserSelectionPartyDataInfo;
    [Token(Token = "0x40035DD")]
    [FieldOffset(Offset = "0x2FC")]
    public static bool PartyUploadFinished;
    [Token(Token = "0x40035DE")]
    [FieldOffset(Offset = "0x2FD")]
    public static bool RankingQuestSelected;
    [Token(Token = "0x40035DF")]
    [FieldOffset(Offset = "0x300")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsTitleStart;
    [Token(Token = "0x40035E0")]
    [FieldOffset(Offset = "0x304")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsLoginInfoNotified;
    [Token(Token = "0x40035E1")]
    [FieldOffset(Offset = "0x308")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsRankMatchRewarded;
    [Token(Token = "0x40035E2")]
    [FieldOffset(Offset = "0x30C")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsRaidRewarded;
    [Token(Token = "0x40035E3")]
    [FieldOffset(Offset = "0x310")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsGuildRaidRewarded;
    [Token(Token = "0x40035E4")]
    [FieldOffset(Offset = "0x314")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsGuildTrophy;
    [Token(Token = "0x40035E5")]
    [FieldOffset(Offset = "0x318")]
    public static RankingQuestParam SelectedRankingQuestParam;
    [Token(Token = "0x40035E6")]
    [FieldOffset(Offset = "0x31C")]
    public static List<PartyEditData> OrdealParties;
    [Token(Token = "0x40035E7")]
    [FieldOffset(Offset = "0x320")]
    public static List<SupportData> OrdealSupports;
    [Token(Token = "0x40035E8")]
    [FieldOffset(Offset = "0x324")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsDirtyConceptCardData;
    [Token(Token = "0x40035E9")]
    [FieldOffset(Offset = "0x328")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsDirtySkinConceptCardData;
    [Token(Token = "0x40035EA")]
    [FieldOffset(Offset = "0x32C")]
    public static GlobalVars.GlobalVar<ConceptCardData> SelectedConceptCardData;
    [Token(Token = "0x40035EB")]
    [FieldOffset(Offset = "0x330")]
    public static bool RestoreBeginnerQuest;
    [Token(Token = "0x40035EC")]
    [FieldOffset(Offset = "0x334")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<int> ConceptCardNum;
    [Token(Token = "0x40035ED")]
    [FieldOffset(Offset = "0x338")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsDirtyRuneData;
    [Token(Token = "0x40035EE")]
    [FieldOffset(Offset = "0x33C")]
    public static bool IsSkipQuestDemo;
    [Token(Token = "0x40035EF")]
    [FieldOffset(Offset = "0x340")]
    public static Json_ArenaAward ArenaAward;
    [Token(Token = "0x40035F0")]
    [FieldOffset(Offset = "0x344")]
    public static UnitData UnitDataForUnitList;
    [Token(Token = "0x40035F1")]
    [FieldOffset(Offset = "0x348")]
    public static bool IsUnitRentalUnit;
    [Token(Token = "0x40035F2")]
    [FieldOffset(Offset = "0x34C")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsNeedRequestBtlCom;
    [Token(Token = "0x40035F3")]
    [FieldOffset(Offset = "0x350")]
    [GlobalVars.ResetOnLogin]
    public static bool IsInvalidSkillRequested;
    [Token(Token = "0x40035F4")]
    [FieldOffset(Offset = "0x354")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsGoToGuildTraining;
    [Token(Token = "0x40035F5")]
    [FieldOffset(Offset = "0x358")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> DuelResumeBattle;
    [Token(Token = "0x40035F6")]
    [FieldOffset(Offset = "0x35C")]
    [GlobalVars.ResetOnLogin]
    public static int LeagueMatchSeasonId;
    [Token(Token = "0x40035F7")]
    [FieldOffset(Offset = "0x360")]
    [GlobalVars.ResetOnLogin]
    public static BattleCore.Json_Battle LeagueMatchJsonBattle;
    [Token(Token = "0x40035F8")]
    [FieldOffset(Offset = "0x364")]
    [GlobalVars.ResetOnLogin]
    public static bool IsLeagueMatchShamBattle;
    [Token(Token = "0x40035F9")]
    [FieldOffset(Offset = "0x368")]
    [GlobalVars.ResetOnLogin]
    public static ShamBattleData LeagueMatchShamBattleData;
    [Token(Token = "0x40035FA")]
    [FieldOffset(Offset = "0x36C")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsGoToGuildBossPractice;
    [Token(Token = "0x40035FB")]
    [FieldOffset(Offset = "0x370")]
    [GlobalVars.ResetOnLogin]
    public static int GuildRaidPracticePeriodId;
    [Token(Token = "0x40035FC")]
    [FieldOffset(Offset = "0x374")]
    public static GlobalVars.GlobalVar<CrystalData> SelectedCrystalData;
    [Token(Token = "0x40035FD")]
    [FieldOffset(Offset = "0x378")]
    [GlobalVars.ResetOnLogin]
    public static bool IsOverWeriteSetBonusSetting;
    [Token(Token = "0x40035FE")]
    [FieldOffset(Offset = "0x37C")]
    public static GlobalVars.RecommendTeamSetting RecommendTeamSettingValue;
    [Token(Token = "0x40035FF")]
    [FieldOffset(Offset = "0x380")]
    public static bool IsAutoEquipConceptCard;
    [Token(Token = "0x4003600")]
    [FieldOffset(Offset = "0x384")]
    public static GlobalVars.SummonCoinInfo NewSummonCoinInfo;
    [Token(Token = "0x4003601")]
    [FieldOffset(Offset = "0x388")]
    public static GlobalVars.SummonCoinInfo OldSummonCoinInfo;
    [Token(Token = "0x4003602")]
    [FieldOffset(Offset = "0x38C")]
    public static List<string> SelectTipsList;
    [Token(Token = "0x4003603")]
    [FieldOffset(Offset = "0x390")]
    public static string RequestTips;
    [Token(Token = "0x4003604")]
    [FieldOffset(Offset = "0x394")]
    public static List<string> BlockList;
    [Token(Token = "0x4003605")]
    [FieldOffset(Offset = "0x398")]
    public static string MonthlyLoginBonus_SelectTableIname;
    [Token(Token = "0x4003606")]
    [FieldOffset(Offset = "0x39C")]
    public static int MonthlyLoginBonus_SelectRecoverDay;
    [Token(Token = "0x4003607")]
    [FieldOffset(Offset = "0x3A0")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsHomeAPIAddGuildRoleBonus;
    [Token(Token = "0x4003608")]
    [FieldOffset(Offset = "0x3A4")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsHomeAPI;
    [Token(Token = "0x4003609")]
    [FieldOffset(Offset = "0x3A8")]
    [GlobalVars.ResetOnLogin]
    public static DateTime LastPublicInfo;
    [Token(Token = "0x400360A")]
    [FieldOffset(Offset = "0x3B0")]
    public static GlobalVars.SelectUnitTicketData SelectUnitTicketDataValue;
    [Token(Token = "0x400360B")]
    [FieldOffset(Offset = "0x3B4")]
    public static string CommonMaterialQuestItemID;
    [Token(Token = "0x400360C")]
    [FieldOffset(Offset = "0x3B8")]
    public static string LastSelectBondGroupIname;
    [Token(Token = "0x400360D")]
    [FieldOffset(Offset = "0x3BC")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> SelectedPointQuestArea;
    [Token(Token = "0x400360E")]
    [FieldOffset(Offset = "0x3C0")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<int> CrystalNum;
    [Token(Token = "0x400360F")]
    [FieldOffset(Offset = "0x3C4")]
    public static string mRuneReplaceTargetUnit;
    [Token(Token = "0x4003610")]
    [FieldOffset(Offset = "0x3C8")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsDirtyCrystalData;
    [Token(Token = "0x4003611")]
    [FieldOffset(Offset = "0x3CC")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsRunPrideResetLoad;
    [Token(Token = "0x4003612")]
    [FieldOffset(Offset = "0x3D0")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<bool> IsTransitionByAutoRepeat;
    [Token(Token = "0x4003613")]
    [FieldOffset(Offset = "0x3D4")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> AutoScrollSelectedSection;
    [Token(Token = "0x4003614")]
    [FieldOffset(Offset = "0x3D8")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> AutoScrollSelectedChapter;
    [Token(Token = "0x4003615")]
    [FieldOffset(Offset = "0x3DC")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<string> AutoScrollSelectedChapterPar;
    [Token(Token = "0x4003616")]
    [FieldOffset(Offset = "0x3E0")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<int> AutoScrollSelectedNum;
    [Token(Token = "0x4003617")]
    [FieldOffset(Offset = "0x3E4")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<int> AutoScrollSelectedFloorNum;
    [Token(Token = "0x4003618")]
    [FieldOffset(Offset = "0x3E8")]
    [GlobalVars.ResetOnLogin]
    public static GlobalVars.GlobalVar<int> LastMaxClearFloor;
    [Token(Token = "0x4003619")]
    [FieldOffset(Offset = "0x3EC")]
    [GlobalVars.ResetOnLogin]
    public static int TowerEventListIndex;
    [Token(Token = "0x400361A")]
    [FieldOffset(Offset = "0x3F0")]
    [GlobalVars.ResetOnLogin]
    public static int SelectedRuneSlotIndexRestore;
    [Token(Token = "0x400361B")]
    [FieldOffset(Offset = "0x3F8")]
    [GlobalVars.ResetOnLogin]
    public static long CrystalReplaceBaseUnitId;

    [Token(Token = "0x1700055D")]
    public static bool DebugIsPlayTutorial
    {
      [Token(Token = "0x6004034"), Address(RVA = "0x11907A0", Offset = "0x118F5A0", VA = "0x111907A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004035"), Address(RVA = "0x1190830", Offset = "0x118F630", VA = "0x11190830")] set
      {
      }
    }

    [Token(Token = "0x6004036")]
    [Address(RVA = "0x118F1F0", Offset = "0x118DFF0", VA = "0x1118F1F0")]
    public static void SetDropTableGeneratedTime()
    {
    }

    [Token(Token = "0x6004037")]
    [Address(RVA = "0x118EF30", Offset = "0x118DD30", VA = "0x1118EF30")]
    public static long GetDropTableGeneratedUnixTime() => new long();

    [Token(Token = "0x6004038")]
    [Address(RVA = "0x118EEB0", Offset = "0x118DCB0", VA = "0x1118EEB0")]
    public static DateTime GetDropTableGeneratedDateTime() => new DateTime();

    [Token(Token = "0x6004039")]
    [Address(RVA = "0x118F270", Offset = "0x118E070", VA = "0x1118F270")]
    static GlobalVars()
    {
    }

    [Token(Token = "0x600403A")]
    [Address(RVA = "0x118EF80", Offset = "0x118DD80", VA = "0x1118EF80")]
    public static void ResetVarsWithAttribute(System.Type attrType)
    {
    }

    [Token(Token = "0x2000F72")]
    public enum CoinListSelectionType
    {
      [Token(Token = "0x400361D")] None,
      [Token(Token = "0x400361E")] EventShop,
      [Token(Token = "0x400361F")] ArenaShop,
      [Token(Token = "0x4003620")] MultiShop,
    }

    [Token(Token = "0x2000F73")]
    public enum JobRankUpTypes
    {
      [Token(Token = "0x4003622")] RankUp,
      [Token(Token = "0x4003623")] Unlock,
      [Token(Token = "0x4003624")] ClassChange,
    }

    [Token(Token = "0x2000F74")]
    public enum EMultiPlayContinue
    {
      [Token(Token = "0x4003626")] PENDING,
      [Token(Token = "0x4003627")] CONTINUE,
      [Token(Token = "0x4003628")] CANCEL,
    }

    [Token(Token = "0x2000F75")]
    public enum EventQuestListType
    {
      [Token(Token = "0x400362A")] EventQuest,
      [Token(Token = "0x400362B")] KeyQuest,
      [Token(Token = "0x400362C")] Tower,
      [Token(Token = "0x400362D")] RankingQuest,
      [Token(Token = "0x400362E")] BeginnerQuest,
      [Token(Token = "0x400362F")] Seiseki,
      [Token(Token = "0x4003630")] Babel,
      [Token(Token = "0x4003631")] EventQuestArchive,
      [Token(Token = "0x4003632")] DailyAndEnhance,
      [Token(Token = "0x4003633")] CombatPowerQuest,
    }

    [Token(Token = "0x2000F76")]
    public interface IGlobalVar
    {
      [Token(Token = "0x600403B")]
      void Reset();
    }

    [Token(Token = "0x2000F77")]
    public enum RecommendType
    {
      [Token(Token = "0x4003635")] Total,
      [Token(Token = "0x4003636")] Attack,
      [Token(Token = "0x4003637")] Defence,
      [Token(Token = "0x4003638")] Magic,
      [Token(Token = "0x4003639")] Mind,
      [Token(Token = "0x400363A")] Speed,
      [Token(Token = "0x400363B")] AttackTypeSlash,
      [Token(Token = "0x400363C")] AttackTypeStab,
      [Token(Token = "0x400363D")] AttackTypeBlow,
      [Token(Token = "0x400363E")] AttackTypeShot,
      [Token(Token = "0x400363F")] AttackTypeMagic,
      [Token(Token = "0x4003640")] AttackTypeNone,
      [Token(Token = "0x4003641")] Hp,
    }

    [Token(Token = "0x2000F78")]
    public class UserSelectionPartyData
    {
      [Token(Token = "0x4003642")]
      [FieldOffset(Offset = "0x8")]
      public UnitData[] unitData;
      [Token(Token = "0x4003643")]
      [FieldOffset(Offset = "0xC")]
      public SupportData supportData;
      [Token(Token = "0x4003644")]
      [FieldOffset(Offset = "0x10")]
      public int[] achievements;
      [Token(Token = "0x4003645")]
      [FieldOffset(Offset = "0x14")]
      public ItemData[] usedItems;

      [Token(Token = "0x600403C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UserSelectionPartyData()
      {
      }
    }

    [Token(Token = "0x2000F79")]
    [Serializable]
    public class RecommendTeamSetting
    {
      [Token(Token = "0x4003646")]
      [FieldOffset(Offset = "0x8")]
      public GlobalVars.RecommendType recommendedType;
      [Token(Token = "0x4003647")]
      [FieldOffset(Offset = "0xC")]
      public EElement recommendedElement;

      [Token(Token = "0x600403D")]
      [Address(RVA = "0x119C170", Offset = "0x119AF70", VA = "0x1119C170")]
      public RecommendTeamSetting(GlobalVars.RecommendType type, EElement elem)
      {
      }
    }

    [Token(Token = "0x2000F7A")]
    public class SummonCoinInfo
    {
      [Token(Token = "0x4003648")]
      [FieldOffset(Offset = "0x8")]
      public int ConvertedSummonCoin;
      [Token(Token = "0x4003649")]
      [FieldOffset(Offset = "0xC")]
      public int ReceivedStone;
      [Token(Token = "0x400364A")]
      [FieldOffset(Offset = "0x10")]
      public int SummonCoinStock;
      [Token(Token = "0x400364B")]
      [FieldOffset(Offset = "0x18")]
      public long Period;
      [Token(Token = "0x400364C")]
      [FieldOffset(Offset = "0x20")]
      public long ConvertedDate;

      [Token(Token = "0x600403E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SummonCoinInfo()
      {
      }
    }

    [Token(Token = "0x2000F7B")]
    public class SelectUnitTicketData
    {
      [Token(Token = "0x400364D")]
      [FieldOffset(Offset = "0x8")]
      public string SelectUnitId;
      [Token(Token = "0x400364E")]
      [FieldOffset(Offset = "0xC")]
      public int ConvertPieceNum;

      [Token(Token = "0x600403F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SelectUnitTicketData()
      {
      }
    }

    [Token(Token = "0x2000F7C")]
    public class GlobalVar<T> : GlobalVars.IGlobalVar
    {
      [Token(Token = "0x400364F")]
      [FieldOffset(Offset = "0x0")]
      private GlobalVars.GlobalVar<T>.VariableChangeEvent mListeners;
      [Token(Token = "0x4003650")]
      [FieldOffset(Offset = "0x0")]
      private T mValue;
      [Token(Token = "0x4003651")]
      [FieldOffset(Offset = "0x0")]
      private T mDefaultValue;

      [Token(Token = "0x6004040")]
      public GlobalVar()
      {
      }

      [Token(Token = "0x6004041")]
      public GlobalVar(T defaultValue)
      {
      }

      [Token(Token = "0x6004042")]
      public void Reset()
      {
      }

      [Token(Token = "0x6004043")]
      public T Get() => (T) null;

      [Token(Token = "0x6004044")]
      public void Set(T value)
      {
      }

      [Token(Token = "0x6004045")]
      public static implicit operator T(GlobalVars.GlobalVar<T> src) => (T) null;

      [Token(Token = "0x6004046")]
      public void AddChangeEventListener(
        GlobalVars.GlobalVar<T>.VariableChangeEvent callback)
      {
      }

      [Token(Token = "0x6004047")]
      public void RemoveChangeEventListener(
        GlobalVars.GlobalVar<T>.VariableChangeEvent callback)
      {
      }

      [Token(Token = "0x6004048")]
      public override string ToString() => (string) null;

      [Token(Token = "0x2000F7D")]
      public delegate void VariableChangeEvent();
    }

    [Token(Token = "0x2000F7E")]
    public class ResetOnLogin : Attribute
    {
      [Token(Token = "0x600404D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public ResetOnLogin()
      {
      }
    }
  }
}
