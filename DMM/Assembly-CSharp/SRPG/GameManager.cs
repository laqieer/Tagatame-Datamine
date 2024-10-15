// Decompiled with JetBrains decompiler
// Type: SRPG.GameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018D1")]
  [AddComponentMenu("Scripts/SRPG/Manager/Game")]
  public class GameManager : MonoSingleton<GameManager>
  {
    [Token(Token = "0x400597E")]
    private const string MasterParamPath = "Data/MasterParam";
    [Token(Token = "0x400597F")]
    private const string MasterParamSerializedPath = "Data/MasterParamSerialized";
    [Token(Token = "0x4005980")]
    private const string QuestParamPath = "Data/QuestParam";
    [Token(Token = "0x4005981")]
    private const string QuestParamSerializedPath = "Data/QuestParamSerialized";
    [Token(Token = "0x4005982")]
    [FieldOffset(Offset = "0xC")]
    private bool mRelogin;
    [Token(Token = "0x4005983")]
    [FieldOffset(Offset = "0x10")]
    private PlayerData mPlayer;
    [Token(Token = "0x4005984")]
    [FieldOffset(Offset = "0x14")]
    private OptionData mOption;
    [Token(Token = "0x4005985")]
    [FieldOffset(Offset = "0x18")]
    private MasterParam mMasterParam;
    [Token(Token = "0x4005986")]
    [FieldOffset(Offset = "0x1C")]
    private List<SectionParam> mWorlds;
    [Token(Token = "0x4005987")]
    [FieldOffset(Offset = "0x20")]
    private List<ArchiveParam> mArchives;
    [Token(Token = "0x4005988")]
    [FieldOffset(Offset = "0x24")]
    private List<ChapterParam> mAreas;
    [Token(Token = "0x4005989")]
    [FieldOffset(Offset = "0x28")]
    private List<QuestParam> mQuests;
    [Token(Token = "0x400598A")]
    [FieldOffset(Offset = "0x2C")]
    private Dictionary<string, QuestParam> mQuestsDict;
    [Token(Token = "0x400598B")]
    [FieldOffset(Offset = "0x30")]
    private List<ObjectiveParam> mObjectives;
    [Token(Token = "0x400598C")]
    [FieldOffset(Offset = "0x34")]
    private List<ObjectiveParam> mTowerObjectives;
    [Token(Token = "0x400598D")]
    [FieldOffset(Offset = "0x38")]
    private List<MagnificationParam> mMagnifications;
    [Token(Token = "0x400598E")]
    [FieldOffset(Offset = "0x3C")]
    private List<QuestCondParam> mConditions;
    [Token(Token = "0x400598F")]
    [FieldOffset(Offset = "0x40")]
    private List<QuestPartyParam> mParties;
    [Token(Token = "0x4005990")]
    [FieldOffset(Offset = "0x44")]
    private List<QuestCampaignParentParam> mCampaignParents;
    [Token(Token = "0x4005991")]
    [FieldOffset(Offset = "0x48")]
    private List<QuestCampaignChildParam> mCampaignChildren;
    [Token(Token = "0x4005992")]
    [FieldOffset(Offset = "0x4C")]
    private List<QuestCampaignTrust> mCampaignTrust;
    [Token(Token = "0x4005993")]
    [FieldOffset(Offset = "0x50")]
    private List<QuestCampaignInspSkill> mCampaignInspSkill;
    [Token(Token = "0x4005994")]
    [FieldOffset(Offset = "0x54")]
    private List<QuestParam> mTowerBaseQuests;
    [Token(Token = "0x4005995")]
    [FieldOffset(Offset = "0x58")]
    private List<TowerFloorParam> mTowerFloors;
    [Token(Token = "0x4005996")]
    [FieldOffset(Offset = "0x5C")]
    private Dictionary<string, TowerFloorParam> mTowerFloorsDict;
    [Token(Token = "0x4005997")]
    [FieldOffset(Offset = "0x60")]
    private List<TowerRewardParam> mTowerRewards;
    [Token(Token = "0x4005998")]
    [FieldOffset(Offset = "0x64")]
    private List<TowerRoundRewardParam> mTowerRoundRewards;
    [Token(Token = "0x4005999")]
    [FieldOffset(Offset = "0x68")]
    private List<TowerParam> mTowers;
    [Token(Token = "0x400599A")]
    [FieldOffset(Offset = "0x6C")]
    private TowerResuponse mTowerResuponse;
    [Token(Token = "0x400599B")]
    [FieldOffset(Offset = "0x70")]
    private HotDealManageData mHotDealManageData;
    [Token(Token = "0x400599C")]
    [FieldOffset(Offset = "0x74")]
    private List<ArenaPlayer> mArenaPlayers;
    [Token(Token = "0x400599D")]
    [FieldOffset(Offset = "0x78")]
    private List<ArenaPlayer>[] mArenaRanking;
    [Token(Token = "0x400599E")]
    [FieldOffset(Offset = "0x7C")]
    private List<ArenaPlayerHistory> mArenaHistory;
    [Token(Token = "0x400599F")]
    [FieldOffset(Offset = "0x80")]
    private List<GachaParam> mGachas;
    [Token(Token = "0x40059A0")]
    [FieldOffset(Offset = "0x84")]
    private List<ChatChannelMasterParam> mChatChannelMasters;
    [Token(Token = "0x40059A1")]
    [FieldOffset(Offset = "0x88")]
    private List<UnitParam> mBadgeUnitUnlocks;
    [Token(Token = "0x40059A2")]
    [FieldOffset(Offset = "0x8C")]
    private List<AchievementParam> mAchievement;
    [Token(Token = "0x40059A3")]
    [FieldOffset(Offset = "0x90")]
    private GameObject mNotifyList;
    [Token(Token = "0x40059A4")]
    [FieldOffset(Offset = "0x94")]
    private List<MultiRanking> mMultiUnitRank;
    [Token(Token = "0x40059A5")]
    [FieldOffset(Offset = "0x98")]
    private Dictionary<string, RankingData> mUnitRanking;
    [Token(Token = "0x40059AC")]
    [FieldOffset(Offset = "0xB8")]
    private List<VersusTowerParam> mVersusTowerFloor;
    [Token(Token = "0x40059AD")]
    [FieldOffset(Offset = "0xBC")]
    private VsTowerMatchEndParam mVersusEndParam;
    [Token(Token = "0x40059B8")]
    [FieldOffset(Offset = "0xF4")]
    private List<VersusScheduleParam> mVersusScheduleParam;
    [Token(Token = "0x40059B9")]
    [FieldOffset(Offset = "0xF8")]
    private List<VersusCoinParam> mVersusCoinParam;
    [Token(Token = "0x40059BA")]
    [FieldOffset(Offset = "0xFC")]
    private List<VersusFriendScore> mVersusFriendScore;
    [Token(Token = "0x40059BB")]
    [FieldOffset(Offset = "0x100")]
    private List<SRPG.MapEffectParam> mMapEffectParam;
    [Token(Token = "0x40059BC")]
    [FieldOffset(Offset = "0x104")]
    private List<WeatherSetParam> mWeatherSetParam;
    [Token(Token = "0x40059BD")]
    [FieldOffset(Offset = "0x108")]
    private List<RankingQuestParam> mRankingQuestParam;
    [Token(Token = "0x40059BE")]
    [FieldOffset(Offset = "0x10C")]
    private List<RankingQuestRewardParam> mRankingQuestRewardParam;
    [Token(Token = "0x40059BF")]
    [FieldOffset(Offset = "0x110")]
    private List<RankingQuestScheduleParam> mRankingQuestScheduleParam;
    [Token(Token = "0x40059C0")]
    [FieldOffset(Offset = "0x114")]
    private List<RankingQuestParam> mAvailableRankingQuesstParams;
    [Token(Token = "0x40059C1")]
    [FieldOffset(Offset = "0x118")]
    private List<GenesisStarParam> mGenesisStarParam;
    [Token(Token = "0x40059C2")]
    [FieldOffset(Offset = "0x11C")]
    private List<GenesisChapterParam> mGenesisChapterParam;
    [Token(Token = "0x40059C3")]
    [FieldOffset(Offset = "0x120")]
    private List<GenesisRewardParam> mGenesisRewardParam;
    [Token(Token = "0x40059C4")]
    [FieldOffset(Offset = "0x124")]
    private List<GenesisLapBossParam> mGenesisLapBossParam;
    [Token(Token = "0x40059C5")]
    [FieldOffset(Offset = "0x128")]
    private List<AdvanceStarParam> mAdvanceStarParam;
    [Token(Token = "0x40059C6")]
    [FieldOffset(Offset = "0x12C")]
    private List<AdvanceEventParam> mAdvanceEventParam;
    [Token(Token = "0x40059C7")]
    [FieldOffset(Offset = "0x130")]
    private List<AdvanceRewardParam> mAdvanceRewardParam;
    [Token(Token = "0x40059C8")]
    [FieldOffset(Offset = "0x134")]
    private List<AdvanceLapBossParam> mAdvanceLapBossParam;
    [Token(Token = "0x40059C9")]
    [FieldOffset(Offset = "0x138")]
    private List<GuildRaidBossParam> mGuildRaidBossParam;
    [Token(Token = "0x40059CA")]
    [FieldOffset(Offset = "0x13C")]
    private List<GuildRaidCoolDaysParam> mGuildRaidCoolDaysParam;
    [Token(Token = "0x40059CB")]
    [FieldOffset(Offset = "0x140")]
    private List<GuildRaidPeriodParam> mGuildRaidPeriodParam;
    [Token(Token = "0x40059CC")]
    [FieldOffset(Offset = "0x144")]
    private List<GuildRaidScoreParam> mGuildRaidScoreParam;
    [Token(Token = "0x40059CD")]
    [FieldOffset(Offset = "0x148")]
    private List<GuildRaidRewardParam> mGuildRaidRewardParam;
    [Token(Token = "0x40059CE")]
    [FieldOffset(Offset = "0x14C")]
    private List<GuildRaidRewardDmgRankingParam> mGuildRaidRewardDmgRankingParam;
    [Token(Token = "0x40059CF")]
    [FieldOffset(Offset = "0x150")]
    private List<GuildRaidRewardDmgRatioParam> mGuildRaidRewardDmgRatioParam;
    [Token(Token = "0x40059D0")]
    [FieldOffset(Offset = "0x154")]
    private List<GuildRaidRewardRoundParam> mGuildRaidRewardRoundParam;
    [Token(Token = "0x40059D1")]
    [FieldOffset(Offset = "0x158")]
    private List<GuildRaidRewardRankingParam> mGuildRaidRewardRankingParam;
    [Token(Token = "0x40059D2")]
    [FieldOffset(Offset = "0x15C")]
    public List<GvGPeriodParam> mGvGPeriodParam;
    [Token(Token = "0x40059D3")]
    [FieldOffset(Offset = "0x160")]
    public List<GvGNodeParam> mGvGNodeParam;
    [Token(Token = "0x40059D4")]
    [FieldOffset(Offset = "0x164")]
    public List<GvGNPCPartyParam> mGvGNPCPartyParam;
    [Token(Token = "0x40059D5")]
    [FieldOffset(Offset = "0x168")]
    public List<GvGNPCUnitParam> mGvGNPCUnitParam;
    [Token(Token = "0x40059D6")]
    [FieldOffset(Offset = "0x16C")]
    public List<GvGRewardRankingParam> mGvGRewardRankingParam;
    [Token(Token = "0x40059D7")]
    [FieldOffset(Offset = "0x170")]
    public List<GvGRewardParam> mGvGRewardParam;
    [Token(Token = "0x40059D8")]
    [FieldOffset(Offset = "0x174")]
    public List<GvGRuleParam> mGvGRuleParam;
    [Token(Token = "0x40059D9")]
    [FieldOffset(Offset = "0x178")]
    public List<GvGNodeRewardParam> mGvGNodeRewardParam;
    [Token(Token = "0x40059DA")]
    [FieldOffset(Offset = "0x17C")]
    public List<GvGLeagueParam> mGvGLeagueParam;
    [Token(Token = "0x40059DB")]
    [FieldOffset(Offset = "0x180")]
    public List<GvGCalcRateSettingParam> mGvGCalcRateSettingParam;
    [Token(Token = "0x40059DC")]
    [FieldOffset(Offset = "0x184")]
    private List<WorldRaidParam> mWorldRaidParamList;
    [Token(Token = "0x40059DD")]
    [FieldOffset(Offset = "0x188")]
    private List<WorldRaidBossParam> mWorldRaidBossParamList;
    [Token(Token = "0x40059DE")]
    [FieldOffset(Offset = "0x18C")]
    private List<WorldRaidRewardParam> mWorldRaidRewardParamList;
    [Token(Token = "0x40059DF")]
    [FieldOffset(Offset = "0x190")]
    private List<WorldRaidDamageRewardParam> mWorldRaidDamageRewardParamList;
    [Token(Token = "0x40059E0")]
    [FieldOffset(Offset = "0x194")]
    private List<WorldRaidDamageLotteryParam> mWorldRaidDamageLotteryParamList;
    [Token(Token = "0x40059E1")]
    [FieldOffset(Offset = "0x198")]
    private List<WorldRaidRankingRewardParam> mWorldRaidRankingRewardParamList;
    [Token(Token = "0x40059E2")]
    [FieldOffset(Offset = "0x19C")]
    private List<WorldRaidLapRewardParam> mWorldRaidLapRewardParamList;
    [Token(Token = "0x40059E3")]
    [FieldOffset(Offset = "0x1A0")]
    private List<WorldRaidBpHealParam> mWorldRaidBpHealParamList;
    [Token(Token = "0x40059E4")]
    [FieldOffset(Offset = "0x1A4")]
    private DuelSeasonParam[] mDuelSeasonParam;
    [Token(Token = "0x40059E5")]
    [FieldOffset(Offset = "0x1A8")]
    private DuelRankingRewardParam[] mDuelRankingRewardParam;
    [Token(Token = "0x40059E6")]
    [FieldOffset(Offset = "0x1AC")]
    private DuelChainWinPointParam[] mDuelChainWinPointParam;
    [Token(Token = "0x40059E7")]
    [FieldOffset(Offset = "0x1B0")]
    private DuelChainWinRewardParam[] mDuelChainWinRewardParam;
    [Token(Token = "0x40059E8")]
    [FieldOffset(Offset = "0x1B4")]
    private DuelRewardParam[] mDuelRewardParam;
    [Token(Token = "0x40059E9")]
    [FieldOffset(Offset = "0x1B8")]
    private List<CombatPowerQuestParam> mCombatPowerQuestParamList;
    [Token(Token = "0x40059EA")]
    [FieldOffset(Offset = "0x1BC")]
    private List<ExtraQuestClearElementProgress> mExQuestClearElementProgress;
    [Token(Token = "0x40059EB")]
    [FieldOffset(Offset = "0x1C0")]
    private List<AdventureAreaParam> mAdventureAreaParamList;
    [Token(Token = "0x40059EC")]
    [FieldOffset(Offset = "0x1C4")]
    private List<AdventureCostParam> mAdventureCostParamList;
    [Token(Token = "0x40059ED")]
    [FieldOffset(Offset = "0x1C8")]
    private List<AdventureCondParam> mAdventureCondParamList;
    [Token(Token = "0x40059EE")]
    [FieldOffset(Offset = "0x1CC")]
    private AdventureNumParam mAdventureNum;
    [Token(Token = "0x40059EF")]
    [FieldOffset(Offset = "0x1D0")]
    private List<AdventureItemParam> mAdventureItemParamList;
    [Token(Token = "0x40059F0")]
    [FieldOffset(Offset = "0x1D4")]
    private List<AdventureCampaignParam> mAdventureCampaignParamList;
    [Token(Token = "0x40059F1")]
    [FieldOffset(Offset = "0x1D8")]
    public ParamDictionary<string, VersusUnitCondParam> mVersusUnitCondParam;
    [Token(Token = "0x40059F2")]
    [FieldOffset(Offset = "0x1DC")]
    public ParamDictionary<string, DragonGodParam> mDragonGodParam;
    [Token(Token = "0x40059F3")]
    [FieldOffset(Offset = "0x1E0")]
    public ParamDictionary<string, ScoreChallengeParam> mScoreChallengeParam;
    [Token(Token = "0x40059F4")]
    [FieldOffset(Offset = "0x1E4")]
    public ParamDictionary<string, PointQuestParam> mPointQuestParam;
    [Token(Token = "0x40059F5")]
    [FieldOffset(Offset = "0x1E8")]
    public ParamDictionary<string, PointQuestEventParam> mPointQuestEventParam;
    [Token(Token = "0x40059F6")]
    [FieldOffset(Offset = "0x1EC")]
    public ParamDictionary<string, PointQuestEventRewardParam> mPointQuestEventRewardParam;
    [Token(Token = "0x40059F7")]
    [FieldOffset(Offset = "0x1F0")]
    public ParamDictionary<string, PointQuestMissionParam> mPointQuestMissionParam;
    [Token(Token = "0x40059F8")]
    [FieldOffset(Offset = "0x1F4")]
    public ParamDictionary<string, PointQuestRankingRewardParam> mPointQuestRankingRewardParam;
    [Token(Token = "0x40059F9")]
    [FieldOffset(Offset = "0x1F8")]
    public ParamDictionary<string, PointQuestTotalRewardParam> mPointQuestTotalRewardParam;
    [Token(Token = "0x40059FA")]
    [FieldOffset(Offset = "0x1FC")]
    private List<LeagueMatchNPCPartyParam> mLeagueMatchNPCPartyParams;
    [Token(Token = "0x40059FB")]
    [FieldOffset(Offset = "0x200")]
    private List<LeagueMatchMissionParam> mLeagueMatchMissionParams;
    [Token(Token = "0x40059FF")]
    [FieldOffset(Offset = "0x208")]
    private VersusAudienceManager mAudienceManager;
    [Token(Token = "0x4005A02")]
    [FieldOffset(Offset = "0x214")]
    private List<MultiTowerFloorParam> mMultiTowerFloor;
    [Token(Token = "0x4005A03")]
    [FieldOffset(Offset = "0x218")]
    private List<MultiTowerRewardParam> mMultiTowerRewards;
    [Token(Token = "0x4005A04")]
    [FieldOffset(Offset = "0x21C")]
    private MultiTowerRoundParam mMultiTowerRound;
    [Token(Token = "0x4005A05")]
    [FieldOffset(Offset = "0x220")]
    public int MaxClearFloor;
    [Token(Token = "0x4005A06")]
    [FieldOffset(Offset = "0x224")]
    private List<VersusFirstWinBonusParam> mVersusFirstWinBonus;
    [Token(Token = "0x4005A07")]
    [FieldOffset(Offset = "0x228")]
    private List<VersusStreakWinScheduleParam> mVersusStreakSchedule;
    [Token(Token = "0x4005A08")]
    [FieldOffset(Offset = "0x22C")]
    private List<VersusStreakWinBonusParam> mVersusStreakWinBonus;
    [Token(Token = "0x4005A09")]
    [FieldOffset(Offset = "0x230")]
    private List<VersusRuleParam> mVersusRule;
    [Token(Token = "0x4005A0A")]
    [FieldOffset(Offset = "0x234")]
    private List<VersusCoinCampParam> mVersusCoinCamp;
    [Token(Token = "0x4005A0B")]
    [FieldOffset(Offset = "0x238")]
    private int mVersusNowStreakWinCnt;
    [Token(Token = "0x4005A0C")]
    [FieldOffset(Offset = "0x23C")]
    private List<VersusEnableTimeParam> mVersusEnableTime;
    [Token(Token = "0x4005A0D")]
    [FieldOffset(Offset = "0x240")]
    private List<VersusTagatameCupParam> mVersusTagatameCup;
    [Token(Token = "0x4005A0E")]
    [FieldOffset(Offset = "0x244")]
    private List<VersusRankParam> mVersusRank;
    [Token(Token = "0x4005A0F")]
    [FieldOffset(Offset = "0x248")]
    private List<VersusRankClassParam> mVersusRankClass;
    [Token(Token = "0x4005A10")]
    [FieldOffset(Offset = "0x24C")]
    private List<VersusRankRankingRewardParam> mVersusRankRankingReward;
    [Token(Token = "0x4005A11")]
    [FieldOffset(Offset = "0x250")]
    private List<VersusRankRewardParam> mVersusRankReward;
    [Token(Token = "0x4005A12")]
    [FieldOffset(Offset = "0x254")]
    private List<VersusRankMissionScheduleParam> mVersusRankMissionSchedule;
    [Token(Token = "0x4005A13")]
    [FieldOffset(Offset = "0x258")]
    private List<VersusRankMissionParam> mVersusRankMission;
    [Token(Token = "0x4005A14")]
    [FieldOffset(Offset = "0x25C")]
    private List<SRPG.VersusRankNPCPartyParam> mVersusRankNPCPartyParam;
    [Token(Token = "0x4005A15")]
    [FieldOffset(Offset = "0x260")]
    private List<SRPG.VersusRankNPCUnitParam> mVersusRankNPCUnitParam;
    [Token(Token = "0x4005A16")]
    [FieldOffset(Offset = "0x264")]
    private List<GuerrillaShopAdventQuestParam> mGuerrillaShopAdventQuest;
    [Token(Token = "0x4005A17")]
    [FieldOffset(Offset = "0x268")]
    private List<GuerrillaShopScheduleParam> mGuerrillaShopScheduleParam;
    [Token(Token = "0x4005A18")]
    [FieldOffset(Offset = "0x26C")]
    private List<VersusDraftDeckParam> mVersusDraftDecks;
    [Token(Token = "0x4005A19")]
    [FieldOffset(Offset = "0x270")]
    private List<VersusDraftUnitParam> mVersusDraftUnit;
    [Token(Token = "0x4005A1A")]
    [FieldOffset(Offset = "0x274")]
    private List<string> mTips;
    [Token(Token = "0x4005A1B")]
    [FieldOffset(Offset = "0x278")]
    public List<QuestLobbyNews> mQuestLobbyNews;
    [Token(Token = "0x4005A1C")]
    [FieldOffset(Offset = "0x27C")]
    private int mVersusBestStreakWinCnt;
    [Token(Token = "0x4005A1D")]
    [FieldOffset(Offset = "0x280")]
    private int mVersusAllPriodStreakWinCount;
    [Token(Token = "0x4005A1E")]
    [FieldOffset(Offset = "0x284")]
    private int mVersusBestAllPriodStreakWinCount;
    [Token(Token = "0x4005A1F")]
    [FieldOffset(Offset = "0x288")]
    private bool mVersusFirstWinRewardRecived;
    [Token(Token = "0x4005A20")]
    [FieldOffset(Offset = "0x290")]
    private long mVersusFreeExpiredTime;
    [Token(Token = "0x4005A21")]
    [FieldOffset(Offset = "0x298")]
    private long mVersusFreeNextTime;
    [Token(Token = "0x4005A23")]
    [FieldOffset(Offset = "0x2A8")]
    private VersusDraftType mVersusDraftType;
    [Token(Token = "0x4005A26")]
    [FieldOffset(Offset = "0x2BC")]
    private bool mSelectedVersusCpuBattle;
    [Token(Token = "0x4005A27")]
    [FieldOffset(Offset = "0x2C0")]
    private List<SRPG.VersusCpuData> mVersusCpuData;
    [Token(Token = "0x4005A28")]
    [FieldOffset(Offset = "0x2C4")]
    private ReqRaidBtlEnd.Response mRaidBtlEndParam;
    [Token(Token = "0x4005A2B")]
    [FieldOffset(Offset = "0x0")]
    private static string sBattleVersion;
    [Token(Token = "0x4005A2C")]
    [FieldOffset(Offset = "0x2D0")]
    private bool mExistsUDIDBeforeInitAuth;
    [Token(Token = "0x4005A2D")]
    [FieldOffset(Offset = "0x2D1")]
    private bool mExistsSecretKeyBeforeInitAuth;
    [Token(Token = "0x4005A2E")]
    [FieldOffset(Offset = "0x2D2")]
    private bool mExistsDeviceIdBeforeInitAuth;
    [Token(Token = "0x4005A30")]
    [FieldOffset(Offset = "0x2D4")]
    public ReqFgGAuth.eAuthStatus AuthStatus;
    [Token(Token = "0x4005A31")]
    [FieldOffset(Offset = "0x2D8")]
    public string FgGAuthHost;
    [Token(Token = "0x4005A32")]
    [FieldOffset(Offset = "0x2DC")]
    private string mReloadMasterDataError;
    [Token(Token = "0x4005A33")]
    [FieldOffset(Offset = "0x2E0")]
    public string MasterDataLoadErrorMessage;
    [Token(Token = "0x4005A34")]
    [FieldOffset(Offset = "0x2E4")]
    private MyGUID mMyGuid;
    [Token(Token = "0x4005A35")]
    [FieldOffset(Offset = "0x2E8")]
    public GameManager.BadgeTypes IsBusyUpdateBadges;
    [Token(Token = "0x4005A36")]
    [FieldOffset(Offset = "0x2EC")]
    public GameManager.BadgeTypes BadgeFlags;
    [Token(Token = "0x4005A37")]
    [FieldOffset(Offset = "0x2F0")]
    private DateTime mLastUpdateTime;
    [Token(Token = "0x4005A38")]
    [FieldOffset(Offset = "0x2F8")]
    private int mLastStamina;
    [Token(Token = "0x4005A39")]
    [FieldOffset(Offset = "0x300")]
    private long mLastGold;
    [Token(Token = "0x4005A3A")]
    [FieldOffset(Offset = "0x308")]
    private int mLastAbilityRankUpCount;
    [Token(Token = "0x4005A3B")]
    [FieldOffset(Offset = "0x30C")]
    public GameManager.DayChangeEvent OnDayChange;
    [Token(Token = "0x4005A3C")]
    [FieldOffset(Offset = "0x310")]
    public GameManager.StaminaChangeEvent OnStaminaChange;
    [Token(Token = "0x4005A3D")]
    [FieldOffset(Offset = "0x314")]
    public GameManager.RankUpCountChangeEvent OnAbilityRankUpCountChange;
    [Token(Token = "0x4005A3E")]
    [FieldOffset(Offset = "0x318")]
    public GameManager.RankUpCountChangeEvent OnAbilityRankUpCountPreReset;
    [Token(Token = "0x4005A3F")]
    [FieldOffset(Offset = "0x31C")]
    public GameManager.PlayerLvChangeEvent OnPlayerLvChange;
    [Token(Token = "0x4005A40")]
    [FieldOffset(Offset = "0x320")]
    public GameManager.PlayerCurrencyChangeEvent OnPlayerCurrencyChange;
    [Token(Token = "0x4005A41")]
    private const float DesiredFrameTime = 0.026f;
    [Token(Token = "0x4005A42")]
    private const float MaxFrameTime = 0.03f;
    [Token(Token = "0x4005A43")]
    private const float MinAnimationFrameTime = 0.001f;
    [Token(Token = "0x4005A44")]
    private const float MaxAnimationFrameTime = 0.006f;
    [Token(Token = "0x4005A45")]
    [FieldOffset(Offset = "0x324")]
    public bool EnableAnimationFrameSkipping;
    [Token(Token = "0x4005A46")]
    [FieldOffset(Offset = "0x325")]
    private bool mHasLoggedIn;
    [Token(Token = "0x4005A47")]
    [FieldOffset(Offset = "0x4")]
    private static bool mUpscaleMode;
    [Token(Token = "0x4005A48")]
    [FieldOffset(Offset = "0x328")]
    private GameObject mBuyCoinWindow;
    [Token(Token = "0x4005A49")]
    [FieldOffset(Offset = "0x32C")]
    private GameManager.BuyCoinEvent mOnBuyCoinEnd;
    [Token(Token = "0x4005A4A")]
    [FieldOffset(Offset = "0x330")]
    private GameManager.BuyCoinEvent mOnBuyCoinCancel;
    [Token(Token = "0x4005A4B")]
    [FieldOffset(Offset = "0x334")]
    private List<Coroutine> mImportantJobs;
    [Token(Token = "0x4005A4C")]
    [FieldOffset(Offset = "0x338")]
    private Coroutine mImportantJobCoroutine;
    [Token(Token = "0x4005A4D")]
    [FieldOffset(Offset = "0x33C")]
    public GameManager.SceneChangeEvent OnSceneChange;
    [Token(Token = "0x4005A4E")]
    [FieldOffset(Offset = "0x340")]
    private List<GameManager.TextureRequest> mTextureRequests;
    [Token(Token = "0x4005A4F")]
    [FieldOffset(Offset = "0x344")]
    private int mTutorialStep;
    [Token(Token = "0x4005A50")]
    [FieldOffset(Offset = "0x348")]
    private List<AssetList.Item> mTutorialDLAssets;
    [Token(Token = "0x4005A51")]
    [FieldOffset(Offset = "0x34C")]
    private bool mScannedTutorialAssets;
    [Token(Token = "0x4005A52")]
    [FieldOffset(Offset = "0x350")]
    private Coroutine mWaitDownloadThread;
    [Token(Token = "0x4005A53")]
    [FieldOffset(Offset = "0x8")]
    private static readonly int SAVE_UPDATE_TROPHY_LIST_ENCODE_KEY;
    [Token(Token = "0x4005A54")]
    [FieldOffset(Offset = "0x354")]
    private string mSavedUpdateTrophyListString;
    [Token(Token = "0x4005A55")]
    [FieldOffset(Offset = "0x358")]
    private List<TrophyState> mUpdateTrophyList;
    [Token(Token = "0x4005A56")]
    [FieldOffset(Offset = "0x35C")]
    private List<TrophyState> mUpdateChallengeList;
    [Token(Token = "0x4005A57")]
    [FieldOffset(Offset = "0x360")]
    private List<TrophyState> mUpdateTrophyAward;
    [Token(Token = "0x4005A58")]
    [FieldOffset(Offset = "0x364")]
    public UpdateTrophyLock update_trophy_lock;
    [Token(Token = "0x4005A59")]
    [FieldOffset(Offset = "0x368")]
    public UpdateTrophyInterval update_trophy_interval;
    [Token(Token = "0x4005A5A")]
    [FieldOffset(Offset = "0x36C")]
    private bool is_start_server_sync_trophy_exec;
    [Token(Token = "0x4005A5B")]
    [FieldOffset(Offset = "0x370")]
    private List<TrophyState> mServerSyncTrophyList;
    [Token(Token = "0x4005A5C")]
    [FieldOffset(Offset = "0x374")]
    private List<TrophyState> mServerSyncChallengeList;
    [Token(Token = "0x4005A5D")]
    [FieldOffset(Offset = "0x378")]
    private List<TrophyState> mServerSyncTrophyAward;
    [Token(Token = "0x4005A5E")]
    [FieldOffset(Offset = "0x37C")]
    private List<UnitData> mCharacterQuestUnits;
    [Token(Token = "0x4005A5F")]
    [FieldOffset(Offset = "0x380")]
    private long mLimitedShopEndAt;
    [Token(Token = "0x4005A60")]
    [FieldOffset(Offset = "0x388")]
    private JSON_ShopListArray.Shops[] mLimitedShopList;
    [Token(Token = "0x4005A61")]
    [FieldOffset(Offset = "0x38C")]
    private bool mIsLimitedShopOpen;
    [Token(Token = "0x4005A62")]
    [FieldOffset(Offset = "0x390")]
    private GameManager.VersusRange[] mFreeMatchRange;
    [Token(Token = "0x4005A63")]
    [FieldOffset(Offset = "0x394")]
    private GameManager.QuestTime mQuestPlayTime;

    [Token(Token = "0x170009CB")]
    public bool IsRelogin
    {
      [Token(Token = "0x6006389"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600638A"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] set
      {
      }
    }

    [Token(Token = "0x170009CC")]
    public HotDealManageData HotDealManageData
    {
      [Token(Token = "0x600638B"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return (HotDealManageData) null;
      }
    }

    [Token(Token = "0x170009CD")]
    private string AgreedVer
    {
      [Token(Token = "0x600638C"), Address(RVA = "0x138DFF0", Offset = "0x138CDF0", VA = "0x1138DFF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600638D"), Address(RVA = "0x138E780", Offset = "0x138D580", VA = "0x1138E780")] set
      {
      }
    }

    [Token(Token = "0x170009CE")]
    public bool VersusTowerMatchBegin
    {
      [Token(Token = "0x600638E"), Address(RVA = "0x7446B0", Offset = "0x7434B0", VA = "0x107446B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600638F"), Address(RVA = "0x138EB60", Offset = "0x138D960", VA = "0x1138EB60")] set
      {
      }
    }

    [Token(Token = "0x170009CF")]
    public bool VersusTowerMatchReceipt
    {
      [Token(Token = "0x6006390"), Address(RVA = "0x138E710", Offset = "0x138D510", VA = "0x1138E710")] get
      {
        return new bool();
      }
      [Token(Token = "0x6006391"), Address(RVA = "0x138EBA0", Offset = "0x138D9A0", VA = "0x1138EBA0")] set
      {
      }
    }

    [Token(Token = "0x170009D0")]
    public string VersusTowerMatchName
    {
      [Token(Token = "0x6006392"), Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006393"), Address(RVA = "0x685750", Offset = "0x684550", VA = "0x10685750")] set
      {
      }
    }

    [Token(Token = "0x170009D1")]
    public long VersusTowerMatchEndAt
    {
      [Token(Token = "0x6006394"), Address(RVA = "0x138E6F0", Offset = "0x138D4F0", VA = "0x1138E6F0")] get
      {
        return new long();
      }
      [Token(Token = "0x6006395"), Address(RVA = "0x138EB80", Offset = "0x138D980", VA = "0x1138EB80")] set
      {
      }
    }

    [Token(Token = "0x170009D2")]
    public int VersusCoinRemainCnt
    {
      [Token(Token = "0x6006396"), Address(RVA = "0x5FC000", Offset = "0x5FAE00", VA = "0x105FC000")] get
      {
        return new int();
      }
      [Token(Token = "0x6006397"), Address(RVA = "0x5FC0B0", Offset = "0x5FAEB0", VA = "0x105FC0B0")] set
      {
      }
    }

    [Token(Token = "0x170009D3")]
    public string VersusLastUid
    {
      [Token(Token = "0x6006398"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006399"), Address(RVA = "0x685600", Offset = "0x684400", VA = "0x10685600")] set
      {
      }
    }

    [Token(Token = "0x170009D4")]
    public bool RankMatchBegin
    {
      [Token(Token = "0x600639A"), Address(RVA = "0x8D1B30", Offset = "0x8D0930", VA = "0x108D1B30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600639B"), Address(RVA = "0x138E9A0", Offset = "0x138D7A0", VA = "0x1138E9A0")] set
      {
      }
    }

    [Token(Token = "0x170009D5")]
    public int RankMatchScheduleId
    {
      [Token(Token = "0x600639C"), Address(RVA = "0x5FBFF0", Offset = "0x5FADF0", VA = "0x105FBFF0")] get
      {
        return new int();
      }
      [Token(Token = "0x600639D"), Address(RVA = "0x138EA20", Offset = "0x138D820", VA = "0x1138EA20")] set
      {
      }
    }

    [Token(Token = "0x170009D6")]
    public ReqRankMatchStatus.RankingStatus RankMatchRankingStatus
    {
      [Token(Token = "0x600639E"), Address(RVA = "0x36A9E0", Offset = "0x3697E0", VA = "0x1036A9E0")] get
      {
        return new ReqRankMatchStatus.RankingStatus();
      }
      [Token(Token = "0x600639F"), Address(RVA = "0x36AA20", Offset = "0x369820", VA = "0x1036AA20")] set
      {
      }
    }

    [Token(Token = "0x170009D7")]
    public long RankMatchExpiredTime
    {
      [Token(Token = "0x60063A0"), Address(RVA = "0x138E4B0", Offset = "0x138D2B0", VA = "0x1138E4B0")] get
      {
        return new long();
      }
      [Token(Token = "0x60063A1"), Address(RVA = "0x138E9C0", Offset = "0x138D7C0", VA = "0x1138E9C0")] set
      {
      }
    }

    [Token(Token = "0x170009D8")]
    public long RankMatchNextTime
    {
      [Token(Token = "0x60063A2"), Address(RVA = "0x138E4D0", Offset = "0x138D2D0", VA = "0x1138E4D0")] get
      {
        return new long();
      }
      [Token(Token = "0x60063A3"), Address(RVA = "0x138EA00", Offset = "0x138D800", VA = "0x1138EA00")] set
      {
      }
    }

    [Token(Token = "0x170009D9")]
    public string[] RankMatchMatchedEnemies
    {
      [Token(Token = "0x60063A4"), Address(RVA = "0x38D820", Offset = "0x38C620", VA = "0x1038D820")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x60063A5"), Address(RVA = "0x138E9E0", Offset = "0x138D7E0", VA = "0x1138E9E0")] set
      {
      }
    }

    [Token(Token = "0x170009DA")]
    public string DigestHash
    {
      [Token(Token = "0x60063A6"), Address(RVA = "0x664D40", Offset = "0x663B40", VA = "0x10664D40")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60063A7"), Address(RVA = "0xB66530", Offset = "0xB65330", VA = "0x10B66530")] set
      {
      }
    }

    [Token(Token = "0x170009DB")]
    public string PrevCheckHash
    {
      [Token(Token = "0x60063A8"), Address(RVA = "0x45A220", Offset = "0x459020", VA = "0x1045A220")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60063A9"), Address(RVA = "0x45A2E0", Offset = "0x4590E0", VA = "0x1045A2E0")] set
      {
      }
    }

    [Token(Token = "0x170009DC")]
    public string AlterCheckHash
    {
      [Token(Token = "0x60063AA"), Address(RVA = "0x6718F0", Offset = "0x6706F0", VA = "0x106718F0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60063AB"), Address(RVA = "0x6857B0", Offset = "0x6845B0", VA = "0x106857B0")] set
      {
      }
    }

    [Token(Token = "0x170009DD")]
    public string QuestDigestHash
    {
      [Token(Token = "0x60063AC"), Address(RVA = "0x6718D0", Offset = "0x6706D0", VA = "0x106718D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60063AD"), Address(RVA = "0x138E960", Offset = "0x138D760", VA = "0x1138E960")] set
      {
      }
    }

    [Token(Token = "0x170009DE")]
    public List<SRPG.MapEffectParam> MapEffectParam
    {
      [Token(Token = "0x60063AE"), Address(RVA = "0xA45FB0", Offset = "0xA44DB0", VA = "0x10A45FB0")] get
      {
        return (List<SRPG.MapEffectParam>) null;
      }
    }

    [Token(Token = "0x170009DF")]
    public List<RankingQuestParam> RankingQuestParams
    {
      [Token(Token = "0x60063AF"), Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x106718E0")] get
      {
        return (List<RankingQuestParam>) null;
      }
    }

    [Token(Token = "0x170009E0")]
    public List<RankingQuestRewardParam> RankingQuestRewardParams
    {
      [Token(Token = "0x60063B0"), Address(RVA = "0x628750", Offset = "0x627550", VA = "0x10628750")] get
      {
        return (List<RankingQuestRewardParam>) null;
      }
    }

    [Token(Token = "0x170009E1")]
    public List<RankingQuestScheduleParam> RankingQuestScheduleParams
    {
      [Token(Token = "0x60063B1"), Address(RVA = "0x349390", Offset = "0x348190", VA = "0x10349390")] get
      {
        return (List<RankingQuestScheduleParam>) null;
      }
    }

    [Token(Token = "0x170009E2")]
    public List<RankingQuestParam> AvailableRankingQuesstParams
    {
      [Token(Token = "0x60063B2"), Address(RVA = "0x3495D0", Offset = "0x3483D0", VA = "0x103495D0")] get
      {
        return (List<RankingQuestParam>) null;
      }
    }

    [Token(Token = "0x170009E3")]
    public List<GenesisChapterParam> GenesisChapterParamList
    {
      [Token(Token = "0x60063B3"), Address(RVA = "0x685580", Offset = "0x684380", VA = "0x10685580")] get
      {
        return (List<GenesisChapterParam>) null;
      }
    }

    [Token(Token = "0x170009E4")]
    public List<AdvanceEventParam> AdvanceEventParamList
    {
      [Token(Token = "0x60063B4"), Address(RVA = "0x349280", Offset = "0x348080", VA = "0x10349280")] get
      {
        return (List<AdvanceEventParam>) null;
      }
    }

    [Token(Token = "0x170009E5")]
    public List<WorldRaidParam> WorldRaidParamList
    {
      [Token(Token = "0x60063B5"), Address(RVA = "0x138E740", Offset = "0x138D540", VA = "0x1138E740")] get
      {
        return (List<WorldRaidParam>) null;
      }
    }

    [Token(Token = "0x170009E6")]
    public List<WorldRaidBossParam> WorldRaidBossParamList
    {
      [Token(Token = "0x60063B6"), Address(RVA = "0xA30130", Offset = "0xA2EF30", VA = "0x10A30130")] get
      {
        return (List<WorldRaidBossParam>) null;
      }
    }

    [Token(Token = "0x170009E7")]
    public List<WorldRaidRewardParam> WorldRaidRewardParamList
    {
      [Token(Token = "0x60063B7"), Address(RVA = "0x138E750", Offset = "0x138D550", VA = "0x1138E750")] get
      {
        return (List<WorldRaidRewardParam>) null;
      }
    }

    [Token(Token = "0x170009E8")]
    public List<WorldRaidDamageRewardParam> WorldRaidDamageRewardParamList
    {
      [Token(Token = "0x60063B8"), Address(RVA = "0x66A5A0", Offset = "0x6693A0", VA = "0x1066A5A0")] get
      {
        return (List<WorldRaidDamageRewardParam>) null;
      }
    }

    [Token(Token = "0x170009E9")]
    public List<WorldRaidDamageLotteryParam> WorldRaidDamageLotteryParamList
    {
      [Token(Token = "0x60063B9"), Address(RVA = "0x9A04B0", Offset = "0x99F2B0", VA = "0x109A04B0")] get
      {
        return (List<WorldRaidDamageLotteryParam>) null;
      }
    }

    [Token(Token = "0x170009EA")]
    public List<WorldRaidRankingRewardParam> WorldRaidRankingRewardParamList
    {
      [Token(Token = "0x60063BA"), Address(RVA = "0xA46360", Offset = "0xA45160", VA = "0x10A46360")] get
      {
        return (List<WorldRaidRankingRewardParam>) null;
      }
    }

    [Token(Token = "0x170009EB")]
    public List<WorldRaidLapRewardParam> WorldRaidLapRewardParamList
    {
      [Token(Token = "0x60063BB"), Address(RVA = "0x138E730", Offset = "0x138D530", VA = "0x1138E730")] get
      {
        return (List<WorldRaidLapRewardParam>) null;
      }
    }

    [Token(Token = "0x170009EC")]
    public List<WorldRaidBpHealParam> WorldRaidBpHealParamList
    {
      [Token(Token = "0x60063BC"), Address(RVA = "0x6C1C40", Offset = "0x6C0A40", VA = "0x106C1C40")] get
      {
        return (List<WorldRaidBpHealParam>) null;
      }
    }

    [Token(Token = "0x170009ED")]
    public DuelSeasonParam[] DuelSeasonParams
    {
      [Token(Token = "0x60063BD"), Address(RVA = "0x349500", Offset = "0x348300", VA = "0x10349500")] get
      {
        return (DuelSeasonParam[]) null;
      }
    }

    [Token(Token = "0x170009EE")]
    public DuelRankingRewardParam[] DuelRankingRewardParams
    {
      [Token(Token = "0x60063BE"), Address(RVA = "0x349590", Offset = "0x348390", VA = "0x10349590")] get
      {
        return (DuelRankingRewardParam[]) null;
      }
    }

    [Token(Token = "0x170009EF")]
    public DuelChainWinPointParam[] DuelChainWinPointParams
    {
      [Token(Token = "0x60063BF"), Address(RVA = "0x138E200", Offset = "0x138D000", VA = "0x1138E200")] get
      {
        return (DuelChainWinPointParam[]) null;
      }
    }

    [Token(Token = "0x170009F0")]
    public DuelChainWinRewardParam[] DuelChainWinRewardParams
    {
      [Token(Token = "0x60063C0"), Address(RVA = "0xA21B70", Offset = "0xA20970", VA = "0x10A21B70")] get
      {
        return (DuelChainWinRewardParam[]) null;
      }
    }

    [Token(Token = "0x170009F1")]
    public DuelRewardParam[] DuelRewardParams
    {
      [Token(Token = "0x60063C1"), Address(RVA = "0x138E210", Offset = "0x138D010", VA = "0x1138E210")] get
      {
        return (DuelRewardParam[]) null;
      }
    }

    [Token(Token = "0x170009F2")]
    public List<CombatPowerQuestParam> CombatPowerQuestParamList
    {
      [Token(Token = "0x60063C2"), Address(RVA = "0xA22140", Offset = "0xA20F40", VA = "0x10A22140")] get
      {
        return (List<CombatPowerQuestParam>) null;
      }
    }

    [Token(Token = "0x170009F3")]
    public List<ExtraQuestClearElementProgress> ExQuestClearElementProgress
    {
      [Token(Token = "0x60063C3"), Address(RVA = "0x33F220", Offset = "0x33E020", VA = "0x1033F220")] get
      {
        return (List<ExtraQuestClearElementProgress>) null;
      }
    }

    [Token(Token = "0x170009F4")]
    public List<AdventureAreaParam> AdventureAreaParamList
    {
      [Token(Token = "0x60063C4"), Address(RVA = "0x349240", Offset = "0x348040", VA = "0x10349240")] get
      {
        return (List<AdventureAreaParam>) null;
      }
    }

    [Token(Token = "0x170009F5")]
    public List<AdventureCostParam> AdventureCostParamList
    {
      [Token(Token = "0x60063C5"), Address(RVA = "0x33F3B0", Offset = "0x33E1B0", VA = "0x1033F3B0")] get
      {
        return (List<AdventureCostParam>) null;
      }
    }

    [Token(Token = "0x170009F6")]
    public List<AdventureCondParam> AdventureCondParamList
    {
      [Token(Token = "0x60063C6"), Address(RVA = "0x349230", Offset = "0x348030", VA = "0x10349230")] get
      {
        return (List<AdventureCondParam>) null;
      }
    }

    [Token(Token = "0x170009F7")]
    public AdventureNumParam AdventureNum
    {
      [Token(Token = "0x60063C7"), Address(RVA = "0x349220", Offset = "0x348020", VA = "0x10349220")] get
      {
        return (AdventureNumParam) null;
      }
    }

    [Token(Token = "0x170009F8")]
    public List<AdventureItemParam> AdventureItemParamList
    {
      [Token(Token = "0x60063C8"), Address(RVA = "0xFC5560", Offset = "0xFC4360", VA = "0x10FC5560")] get
      {
        return (List<AdventureItemParam>) null;
      }
    }

    [Token(Token = "0x170009F9")]
    public List<AdventureCampaignParam> AdventureCampaignParamList
    {
      [Token(Token = "0x60063C9"), Address(RVA = "0x349130", Offset = "0x347F30", VA = "0x10349130")] get
      {
        return (List<AdventureCampaignParam>) null;
      }
    }

    [Token(Token = "0x170009FA")]
    public List<LeagueMatchNPCPartyParam> LeagueMatchNPCPartyParams
    {
      [Token(Token = "0x60063CA"), Address(RVA = "0xA222B0", Offset = "0xA210B0", VA = "0x10A222B0")] get
      {
        return (List<LeagueMatchNPCPartyParam>) null;
      }
    }

    [Token(Token = "0x170009FB")]
    public List<LeagueMatchMissionParam> LeagueMatchMissionParams
    {
      [Token(Token = "0x60063CB"), Address(RVA = "0x4782D0", Offset = "0x4770D0", VA = "0x104782D0")] get
      {
        return (List<LeagueMatchMissionParam>) null;
      }
    }

    [Token(Token = "0x170009FC")]
    public bool IsMultiPlay
    {
      [Token(Token = "0x60063CC"), Address(RVA = "0x138E3D0", Offset = "0x138D1D0", VA = "0x1138E3D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60063CD"), Address(RVA = "0x138E8A0", Offset = "0x138D6A0", VA = "0x1138E8A0")] set
      {
      }
    }

    [Token(Token = "0x170009FD")]
    public bool IsMultiVersus
    {
      [Token(Token = "0x60063CE"), Address(RVA = "0x9F01A0", Offset = "0x9EEFA0", VA = "0x109F01A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60063CF"), Address(RVA = "0x138E8C0", Offset = "0x138D6C0", VA = "0x1138E8C0")] set
      {
      }
    }

    [Token(Token = "0x170009FE")]
    public bool IsRankMatch
    {
      [Token(Token = "0x60063D0"), Address(RVA = "0xF70550", Offset = "0xF6F350", VA = "0x10F70550")] get
      {
        return new bool();
      }
      [Token(Token = "0x60063D1"), Address(RVA = "0x138E8E0", Offset = "0x138D6E0", VA = "0x1138E8E0")] set
      {
      }
    }

    [Token(Token = "0x170009FF")]
    public bool AudienceMode
    {
      [Token(Token = "0x60063D2"), Address(RVA = "0x730F10", Offset = "0x72FD10", VA = "0x10730F10")] get
      {
        return new bool();
      }
      [Token(Token = "0x60063D3"), Address(RVA = "0x138E7E0", Offset = "0x138D5E0", VA = "0x1138E7E0")] set
      {
      }
    }

    [Token(Token = "0x17000A00")]
    public PhotonRoomParameter AudienceRoomParam
    {
      [Token(Token = "0x60063D4"), Address(RVA = "0x7446A0", Offset = "0x7434A0", VA = "0x107446A0")] get
      {
        return (PhotonRoomParameter) null;
      }
      [Token(Token = "0x60063D5"), Address(RVA = "0x138E800", Offset = "0x138D600", VA = "0x1138E800")] set
      {
      }
    }

    [Token(Token = "0x17000A01")]
    public VersusAudienceManager AudienceManager
    {
      [Token(Token = "0x60063D6"), Address(RVA = "0x138E0F0", Offset = "0x138CEF0", VA = "0x1138E0F0")] get
      {
        return (VersusAudienceManager) null;
      }
    }

    [Token(Token = "0x17000A02")]
    public List<string> Tips
    {
      [Token(Token = "0x60063D7"), Address(RVA = "0xFEBDF0", Offset = "0xFEABF0", VA = "0x10FEBDF0")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60063D8"), Address(RVA = "0x101CB20", Offset = "0x101B920", VA = "0x1101CB20")] set
      {
      }
    }

    [Token(Token = "0x60063D9")]
    [Address(RVA = "0x1379C00", Offset = "0x1378A00", VA = "0x11379C00")]
    public TipsParam FindTips(string iname) => (TipsParam) null;

    [Token(Token = "0x17000A03")]
    public int VS_StreakWinCnt_Now
    {
      [Token(Token = "0x60063DA"), Address(RVA = "0x3495F0", Offset = "0x3483F0", VA = "0x103495F0")] get
      {
        return new int();
      }
      [Token(Token = "0x60063DB"), Address(RVA = "0x478310", Offset = "0x477110", VA = "0x10478310")] set
      {
      }
    }

    [Token(Token = "0x17000A04")]
    public int VS_StreakWinCnt_Best
    {
      [Token(Token = "0x60063DC"), Address(RVA = "0xA23070", Offset = "0xA21E70", VA = "0x10A23070")] get
      {
        return new int();
      }
      [Token(Token = "0x60063DD"), Address(RVA = "0x101CB00", Offset = "0x101B900", VA = "0x1101CB00")] set
      {
      }
    }

    [Token(Token = "0x17000A05")]
    public int VS_StreakWinCnt_NowAllPriod
    {
      [Token(Token = "0x60063DE"), Address(RVA = "0x319810", Offset = "0x318610", VA = "0x10319810")] get
      {
        return new int();
      }
      [Token(Token = "0x60063DF"), Address(RVA = "0x138EB40", Offset = "0x138D940", VA = "0x1138EB40")] set
      {
      }
    }

    [Token(Token = "0x17000A06")]
    public int VS_StreakWinCnt_BestAllPriod
    {
      [Token(Token = "0x60063E0"), Address(RVA = "0x349430", Offset = "0x348230", VA = "0x10349430")] get
      {
        return new int();
      }
      [Token(Token = "0x60063E1"), Address(RVA = "0x138EB20", Offset = "0x138D920", VA = "0x1138EB20")] set
      {
      }
    }

    [Token(Token = "0x17000A07")]
    public bool IsVSFirstWinRewardRecived
    {
      [Token(Token = "0x60063E2"), Address(RVA = "0x138E3E0", Offset = "0x138D1E0", VA = "0x1138E3E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60063E3"), Address(RVA = "0x138E920", Offset = "0x138D720", VA = "0x1138E920")] set
      {
      }
    }

    [Token(Token = "0x17000A08")]
    public long VSFreeExpiredTime
    {
      [Token(Token = "0x60063E4"), Address(RVA = "0x138E640", Offset = "0x138D440", VA = "0x1138E640")] get
      {
        return new long();
      }
      [Token(Token = "0x60063E5"), Address(RVA = "0x138EAE0", Offset = "0x138D8E0", VA = "0x1138EAE0")] set
      {
      }
    }

    [Token(Token = "0x17000A09")]
    public long VSFreeNextTime
    {
      [Token(Token = "0x60063E6"), Address(RVA = "0x138E660", Offset = "0x138D460", VA = "0x1138E660")] get
      {
        return new long();
      }
      [Token(Token = "0x60063E7"), Address(RVA = "0x138EB00", Offset = "0x138D900", VA = "0x1138EB00")] set
      {
      }
    }

    [Token(Token = "0x17000A0A")]
    public long mVersusEnableId
    {
      [Token(Token = "0x60063E8"), Address(RVA = "0x138E760", Offset = "0x138D560", VA = "0x1138E760")] get
      {
        return new long();
      }
      [Token(Token = "0x60063E9"), Address(RVA = "0x138EBE0", Offset = "0x138D9E0", VA = "0x1138EBE0")] set
      {
      }
    }

    [Token(Token = "0x17000A0B")]
    public VersusDraftType VSDraftType
    {
      [Token(Token = "0x60063EA"), Address(RVA = "0x3493D0", Offset = "0x3481D0", VA = "0x103493D0")] get
      {
        return new VersusDraftType();
      }
      [Token(Token = "0x60063EB"), Address(RVA = "0x138EAC0", Offset = "0x138D8C0", VA = "0x1138EAC0")] set
      {
      }
    }

    [Token(Token = "0x17000A0C")]
    public long VSDraftId
    {
      [Token(Token = "0x60063EC"), Address(RVA = "0x138E610", Offset = "0x138D410", VA = "0x1138E610")] get
      {
        return new long();
      }
      [Token(Token = "0x60063ED"), Address(RVA = "0x138EA80", Offset = "0x138D880", VA = "0x1138EA80")] set
      {
      }
    }

    [Token(Token = "0x17000A0D")]
    public string VSDraftQuestId
    {
      [Token(Token = "0x60063EE"), Address(RVA = "0x138E630", Offset = "0x138D430", VA = "0x1138E630")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60063EF"), Address(RVA = "0x138EAA0", Offset = "0x138D8A0", VA = "0x1138EAA0")] set
      {
      }
    }

    [Token(Token = "0x17000A0E")]
    public bool IsVSCpuBattle
    {
      [Token(Token = "0x60063F0"), Address(RVA = "0x5E0370", Offset = "0x5DF170", VA = "0x105E0370")] get
      {
        return new bool();
      }
      [Token(Token = "0x60063F1"), Address(RVA = "0x138E900", Offset = "0x138D700", VA = "0x1138E900")] set
      {
      }
    }

    [Token(Token = "0x17000A0F")]
    public List<SRPG.VersusCpuData> VersusCpuData
    {
      [Token(Token = "0x60063F2"), Address(RVA = "0x138E680", Offset = "0x138D480", VA = "0x1138E680")] get
      {
        return (List<SRPG.VersusCpuData>) null;
      }
    }

    [Token(Token = "0x60063F3")]
    [Address(RVA = "0x13826E0", Offset = "0x13814E0", VA = "0x113826E0")]
    public VersusEnableTimeParam GetVersusEnableTime(long schedule_id)
    {
      return (VersusEnableTimeParam) null;
    }

    [Token(Token = "0x60063F4")]
    [Address(RVA = "0x1383560", Offset = "0x1382360", VA = "0x11383560")]
    public VersusTagatameCupParam GetVersusTagatameCupParam(string _iname)
    {
      return (VersusTagatameCupParam) null;
    }

    [Token(Token = "0x60063F5")]
    [Address(RVA = "0x1383320", Offset = "0x1382120", VA = "0x11383320")]
    public VersusRankParam GetVersusRankParam(int schedule_id) => (VersusRankParam) null;

    [Token(Token = "0x60063F6")]
    [Address(RVA = "0x1382FD0", Offset = "0x1381DD0", VA = "0x11382FD0")]
    public List<VersusEnableTimeScheduleParam> GetVersusRankMapSchedule(int schedule_id)
    {
      return (List<VersusEnableTimeScheduleParam>) null;
    }

    [Token(Token = "0x60063F7")]
    [Address(RVA = "0x1380420", Offset = "0x137F220", VA = "0x11380420")]
    public int GetNextVersusRankClass(int schedule_id, RankMatchClass current_class, int point)
    {
      return new int();
    }

    [Token(Token = "0x60063F8")]
    [Address(RVA = "0x1382F00", Offset = "0x1381D00", VA = "0x11382F00")]
    public VersusRankClassParam GetVersusRankClass(int schedule_id, RankMatchClass current_class)
    {
      return (VersusRankClassParam) null;
    }

    [Token(Token = "0x60063F9")]
    [Address(RVA = "0x137F940", Offset = "0x137E740", VA = "0x1137F940")]
    public int GetMaxBattlePoint(int schedule_id) => new int();

    [Token(Token = "0x60063FA")]
    [Address(RVA = "0x1382C70", Offset = "0x1381A70", VA = "0x11382C70")]
    public List<VersusRankClassParam> GetVersusRankClassList(int schedule_id)
    {
      return (List<VersusRankClassParam>) null;
    }

    [Token(Token = "0x60063FB")]
    [Address(RVA = "0x13833E0", Offset = "0x13821E0", VA = "0x113833E0")]
    public List<VersusRankRankingRewardParam> GetVersusRankRankingRewardList(int schedule_id)
    {
      return (List<VersusRankRankingRewardParam>) null;
    }

    [Token(Token = "0x60063FC")]
    [Address(RVA = "0x1382DF0", Offset = "0x1381BF0", VA = "0x11382DF0")]
    public List<VersusRankReward> GetVersusRankClassRewardList(string reward_id)
    {
      return (List<VersusRankReward>) null;
    }

    [Token(Token = "0x60063FD")]
    [Address(RVA = "0x13830D0", Offset = "0x1381ED0", VA = "0x113830D0")]
    public List<VersusRankMissionParam> GetVersusRankMissionList(int schedule_id)
    {
      return (List<VersusRankMissionParam>) null;
    }

    [Token(Token = "0x17000A10")]
    public List<SRPG.VersusRankNPCPartyParam> VersusRankNPCPartyParam
    {
      [Token(Token = "0x60063FE"), Address(RVA = "0x349580", Offset = "0x348380", VA = "0x10349580")] get
      {
        return (List<SRPG.VersusRankNPCPartyParam>) null;
      }
    }

    [Token(Token = "0x17000A11")]
    public List<SRPG.VersusRankNPCUnitParam> VersusRankNPCUnitParam
    {
      [Token(Token = "0x60063FF"), Address(RVA = "0x138E6E0", Offset = "0x138D4E0", VA = "0x1138E6E0")] get
      {
        return (List<SRPG.VersusRankNPCUnitParam>) null;
      }
    }

    [Token(Token = "0x6006400")]
    [Address(RVA = "0xFEBE00", Offset = "0xFEAC00", VA = "0x10FEBE00")]
    public List<VersusDraftDeckParam> GetVersusDraftDecks() => (List<VersusDraftDeckParam>) null;

    [Token(Token = "0x6006401")]
    [Address(RVA = "0x1382440", Offset = "0x1381240", VA = "0x11382440")]
    public List<VersusDraftDeckParam> GetVersusDraftDecksNow(long schedule_id)
    {
      return (List<VersusDraftDeckParam>) null;
    }

    [Token(Token = "0x6006402")]
    [Address(RVA = "0x1382380", Offset = "0x1381180", VA = "0x11382380")]
    public VersusDraftDeckParam GetVersusDraftDeck(long draft_id) => (VersusDraftDeckParam) null;

    [Token(Token = "0x6006403")]
    [Address(RVA = "0x1382620", Offset = "0x1381420", VA = "0x11382620")]
    public List<VersusDraftUnitParam> GetVersusDraftUnits(long draft_id)
    {
      return (List<VersusDraftUnitParam>) null;
    }

    [Token(Token = "0x17000A12")]
    public ReqRaidBtlEnd.Response RaidBtlEndParam
    {
      [Token(Token = "0x6006404"), Address(RVA = "0x138E980", Offset = "0x138D780", VA = "0x1138E980")] set
      {
      }
      [Token(Token = "0x6006405"), Address(RVA = "0x138E4A0", Offset = "0x138D2A0", VA = "0x1138E4A0")] get
      {
        return (ReqRaidBtlEnd.Response) null;
      }
    }

    [Token(Token = "0x17000A13")]
    public ReqGuildRaidBtlEnd.Response RecentGuildRaidBtlEndParam
    {
      [Token(Token = "0x6006406"), Address(RVA = "0x349090", Offset = "0x347E90", VA = "0x10349090")] get
      {
        return (ReqGuildRaidBtlEnd.Response) null;
      }
      [Token(Token = "0x6006407"), Address(RVA = "0x138EA40", Offset = "0x138D840", VA = "0x1138EA40")] set
      {
      }
    }

    [Token(Token = "0x17000A14")]
    public ReqWorldRaidBtlEnd.Response RecentWorldRaidBtlEndParam
    {
      [Token(Token = "0x6006408"), Address(RVA = "0x349080", Offset = "0x347E80", VA = "0x10349080")] get
      {
        return (ReqWorldRaidBtlEnd.Response) null;
      }
      [Token(Token = "0x6006409"), Address(RVA = "0x138EA60", Offset = "0x138D860", VA = "0x1138EA60")] set
      {
      }
    }

    [Token(Token = "0x17000A15")]
    public string BattleVersion
    {
      [Token(Token = "0x600640A"), Address(RVA = "0x138E160", Offset = "0x138CF60", VA = "0x1138E160")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600640B"), Address(RVA = "0x138E820", Offset = "0x138D620", VA = "0x1138E820")] set
      {
      }
    }

    [Token(Token = "0x17000A16")]
    public bool ExistsUDID
    {
      [Token(Token = "0x600640C"), Address(RVA = "0x138E240", Offset = "0x138D040", VA = "0x1138E240")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A17")]
    public bool ExistsSecretKey
    {
      [Token(Token = "0x600640D"), Address(RVA = "0x138E230", Offset = "0x138D030", VA = "0x1138E230")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A18")]
    public bool ExistsDeviceId
    {
      [Token(Token = "0x600640E"), Address(RVA = "0x138E220", Offset = "0x138D020", VA = "0x1138E220")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A19")]
    public bool VisibleExpansionRepurchaseBadge
    {
      [Token(Token = "0x600640F"), Address(RVA = "0x138E720", Offset = "0x138D520", VA = "0x1138E720")] get
      {
        return new bool();
      }
      [Token(Token = "0x6006410"), Address(RVA = "0x138EBC0", Offset = "0x138D9C0", VA = "0x1138EBC0")] private set
      {
      }
    }

    [Token(Token = "0x6006411")]
    [Address(RVA = "0x1386DE0", Offset = "0x1385BE0", VA = "0x11386DE0", Slot = "5")]
    protected override void Release()
    {
    }

    [Token(Token = "0x6006412")]
    [Address(RVA = "0xF53AD0", Offset = "0xF528D0", VA = "0x10F53AD0")]
    public void ResetData()
    {
    }

    [Token(Token = "0x6006413")]
    [Address(RVA = "0x1383F60", Offset = "0x1382D60", VA = "0x11383F60")]
    public void InitNotifyList(GameObject notifyListTemplate)
    {
    }

    [Token(Token = "0x6006414")]
    [Address(RVA = "0x137A100", Offset = "0x1378F00", VA = "0x1137A100")]
    public SectionParam FindWorld(string iname) => (SectionParam) null;

    [Token(Token = "0x6006415")]
    [Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")]
    public List<SectionParam> GetWorldAll() => (List<SectionParam>) null;

    [Token(Token = "0x6006416")]
    [Address(RVA = "0x1378940", Offset = "0x1377740", VA = "0x11378940")]
    public ArchiveParam FindArchive(string iname) => (ArchiveParam) null;

    [Token(Token = "0x6006417")]
    [Address(RVA = "0x1378760", Offset = "0x1377560", VA = "0x11378760")]
    public ArchiveParam FindArchiveByArea(string area_iname) => (ArchiveParam) null;

    [Token(Token = "0x6006418")]
    [Address(RVA = "0x13789E0", Offset = "0x13777E0", VA = "0x113789E0")]
    public ChapterParam FindArea(string iname) => (ChapterParam) null;

    [Token(Token = "0x6006419")]
    [Address(RVA = "0x1378CB0", Offset = "0x1377AB0", VA = "0x11378CB0")]
    public List<ChapterParam> FindChaptersBySection(string section_iname)
    {
      return (List<ChapterParam>) null;
    }

    [Token(Token = "0x600641A")]
    [Address(RVA = "0x13808E0", Offset = "0x137F6E0", VA = "0x113808E0")]
    public List<QuestParam> GetQuestTypeList(
      QuestTypes quest_type,
      string chapter_id,
      QuestDifficulties difficulty = QuestDifficulties.MAX,
      bool is_no_check_unlock = false)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x600641B")]
    [Address(RVA = "0x137C7C0", Offset = "0x137B5C0", VA = "0x1137C7C0")]
    public List<QuestParam> GetDragonGodQuestList(string chapter_id) => (List<QuestParam>) null;

    [Token(Token = "0x600641C")]
    [Address(RVA = "0x1380FB0", Offset = "0x137FDB0", VA = "0x11380FB0")]
    public List<QuestParam> GetScoreChallengeQuestList(string chapter_id)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x600641D")]
    [Address(RVA = "0x1379A40", Offset = "0x1378840", VA = "0x11379A40")]
    public QuestParam FindQuest(string iname) => (QuestParam) null;

    [Token(Token = "0x600641E")]
    [Address(RVA = "0x13799B0", Offset = "0x13787B0", VA = "0x113799B0")]
    public QuestParam FindQuest(QuestTypes type) => (QuestParam) null;

    [Token(Token = "0x600641F")]
    [Address(RVA = "0x1380740", Offset = "0x137F540", VA = "0x11380740")]
    public QuestParam GetOpenUnitQuestParam(string unit_id) => (QuestParam) null;

    [Token(Token = "0x6006420")]
    [Address(RVA = "0x1379230", Offset = "0x1378030", VA = "0x11379230")]
    public ObjectiveParam FindObjective(string iname) => (ObjectiveParam) null;

    [Token(Token = "0x6006421")]
    [Address(RVA = "0x1379DB0", Offset = "0x1378BB0", VA = "0x11379DB0")]
    public ObjectiveParam FindTowerObjective(string iname) => (ObjectiveParam) null;

    [Token(Token = "0x6006422")]
    [Address(RVA = "0x1378F20", Offset = "0x1377D20", VA = "0x11378F20")]
    public MagnificationParam FindMagnification(string iname) => (MagnificationParam) null;

    [Token(Token = "0x6006423")]
    [Address(RVA = "0x1379870", Offset = "0x1378670", VA = "0x11379870")]
    public QuestCondParam FindQuestCond(string iname) => (QuestCondParam) null;

    [Token(Token = "0x6006424")]
    [Address(RVA = "0x1379910", Offset = "0x1378710", VA = "0x11379910")]
    public QuestPartyParam FindQuestParty(string iname) => (QuestPartyParam) null;

    [Token(Token = "0x6006425")]
    [Address(RVA = "0x13792D0", Offset = "0x13780D0", VA = "0x113792D0")]
    public QuestCampaignData[] FindQuestCampaigns(string[] inames) => (QuestCampaignData[]) null;

    [Token(Token = "0x6006426")]
    [Address(RVA = "0x13795F0", Offset = "0x13783F0", VA = "0x113795F0")]
    public QuestCampaignData[] FindQuestCampaigns(QuestParam questParam)
    {
      return (QuestCampaignData[]) null;
    }

    [Token(Token = "0x6006427")]
    [Address(RVA = "0x1378C00", Offset = "0x1377A00", VA = "0x11378C00")]
    public QuestParam FindBaseQuest(QuestTypes questType, string iname) => (QuestParam) null;

    [Token(Token = "0x6006428")]
    [Address(RVA = "0x1379C70", Offset = "0x1378A70", VA = "0x11379C70")]
    public TowerFloorParam FindTowerFloor(string iname) => (TowerFloorParam) null;

    [Token(Token = "0x6006429")]
    [Address(RVA = "0x1378DA0", Offset = "0x1377BA0", VA = "0x11378DA0")]
    public TowerFloorParam FindFirstTowerFloor(string towerID) => (TowerFloorParam) null;

    [Token(Token = "0x600642A")]
    [Address(RVA = "0x1378EB0", Offset = "0x1377CB0", VA = "0x11378EB0")]
    public TowerFloorParam FindLastTowerFloor(string towerID) => (TowerFloorParam) null;

    [Token(Token = "0x600642B")]
    [Address(RVA = "0x1379150", Offset = "0x1377F50", VA = "0x11379150")]
    public TowerFloorParam FindNextTowerFloor(string towerID, string currentFloorID)
    {
      return (TowerFloorParam) null;
    }

    [Token(Token = "0x600642C")]
    [Address(RVA = "0x1379CF0", Offset = "0x1378AF0", VA = "0x11379CF0")]
    public List<TowerFloorParam> FindTowerFloors(string towerID) => (List<TowerFloorParam>) null;

    [Token(Token = "0x600642D")]
    [Address(RVA = "0x1379E50", Offset = "0x1378C50", VA = "0x11379E50")]
    public TowerRewardParam FindTowerReward(string iname) => (TowerRewardParam) null;

    [Token(Token = "0x600642E")]
    [Address(RVA = "0x1379F90", Offset = "0x1378D90", VA = "0x11379F90")]
    public TowerParam FindTower(string iname) => (TowerParam) null;

    [Token(Token = "0x600642F")]
    [Address(RVA = "0x1380850", Offset = "0x137F650", VA = "0x11380850")]
    public int GetQuestTypeCount(QuestTypes type) => new int();

    [Token(Token = "0x6006430")]
    [Address(RVA = "0x1380A00", Offset = "0x137F800", VA = "0x11380A00")]
    public List<QuestParam> GetQuestTypeList(QuestTypes type) => (List<QuestParam>) null;

    [Token(Token = "0x6006431")]
    [Address(RVA = "0x136FC40", Offset = "0x136EA40", VA = "0x1136FC40")]
    public int CalcTowerScore(bool isNow = true) => new int();

    [Token(Token = "0x6006432")]
    [Address(RVA = "0x136FBC0", Offset = "0x136E9C0", VA = "0x1136FBC0")]
    public TOWER_RANK CalcTowerRank(bool isNow = true) => new TOWER_RANK();

    [Token(Token = "0x6006433")]
    [Address(RVA = "0x13709C0", Offset = "0x136F7C0", VA = "0x113709C0")]
    public string ConvertTowerScoreToRank(TowerParam towerParam, int score, TOWER_SCORE_TYPE type)
    {
      return (string) null;
    }

    [Token(Token = "0x6006434")]
    [Address(RVA = "0x1378A80", Offset = "0x1377880", VA = "0x11378A80")]
    public ArenaPlayer FindArenaPlayer(string fuid) => (ArenaPlayer) null;

    [Token(Token = "0x17000A1A")]
    public ArenaPlayer[] ArenaPlayers
    {
      [Token(Token = "0x6006435"), Address(RVA = "0x138E0B0", Offset = "0x138CEB0", VA = "0x1138E0B0")] get
      {
        return (ArenaPlayer[]) null;
      }
    }

    [Token(Token = "0x6006436")]
    [Address(RVA = "0x137BB10", Offset = "0x137A910", VA = "0x1137BB10")]
    public ArenaPlayer[] GetArenaRanking(ReqBtlColoRanking.RankingTypes type)
    {
      return (ArenaPlayer[]) null;
    }

    [Token(Token = "0x6006437")]
    [Address(RVA = "0x13786C0", Offset = "0x13774C0", VA = "0x113786C0")]
    public AchievementParam FindAchievement(int id) => (AchievementParam) null;

    [Token(Token = "0x6006438")]
    [Address(RVA = "0x137BAD0", Offset = "0x137A8D0", VA = "0x1137BAD0")]
    public ArenaPlayerHistory[] GetArenaHistory() => (ArenaPlayerHistory[]) null;

    [Token(Token = "0x6006439")]
    [Address(RVA = "0x1378FC0", Offset = "0x1377DC0", VA = "0x11378FC0")]
    public MailData FindMail(long mailID) => (MailData) null;

    [Token(Token = "0x17000A1B")]
    public PlayerData Player
    {
      [Token(Token = "0x600643A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (PlayerData) null;
      }
    }

    [Token(Token = "0x17000A1C")]
    public OptionData Option
    {
      [Token(Token = "0x600643B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (OptionData) null;
      }
    }

    [Token(Token = "0x17000A1D")]
    public MasterParam MasterParam
    {
      [Token(Token = "0x600643C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (MasterParam) null;
      }
      [Token(Token = "0x600643D"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x17000A1E")]
    public SectionParam[] Sections
    {
      [Token(Token = "0x600643E"), Address(RVA = "0x138E510", Offset = "0x138D310", VA = "0x1138E510")] get
      {
        return (SectionParam[]) null;
      }
    }

    [Token(Token = "0x17000A1F")]
    public ArchiveParam[] Archives
    {
      [Token(Token = "0x600643F"), Address(RVA = "0x138E070", Offset = "0x138CE70", VA = "0x1138E070")] get
      {
        return (ArchiveParam[]) null;
      }
    }

    [Token(Token = "0x17000A20")]
    public ChapterParam[] Chapters
    {
      [Token(Token = "0x6006440"), Address(RVA = "0x138E1A0", Offset = "0x138CFA0", VA = "0x1138E1A0")] get
      {
        return (ChapterParam[]) null;
      }
    }

    [Token(Token = "0x17000A21")]
    public QuestParam[] Quests
    {
      [Token(Token = "0x6006441"), Address(RVA = "0x138E460", Offset = "0x138D260", VA = "0x1138E460")] get
      {
        return (QuestParam[]) null;
      }
    }

    [Token(Token = "0x17000A22")]
    public ObjectiveParam[] Objectives
    {
      [Token(Token = "0x6006442"), Address(RVA = "0x138E420", Offset = "0x138D220", VA = "0x1138E420")] get
      {
        return (ObjectiveParam[]) null;
      }
    }

    [Token(Token = "0x17000A23")]
    public TrophyParam[] Trophies
    {
      [Token(Token = "0x6006443"), Address(RVA = "0x138E5D0", Offset = "0x138D3D0", VA = "0x1138E5D0")] get
      {
        return (TrophyParam[]) null;
      }
    }

    [Token(Token = "0x6006444")]
    [Address(RVA = "0x1381520", Offset = "0x1380320", VA = "0x11381520")]
    public TrophyObjective[] GetTrophiesOfType(TrophyConditionTypes type)
    {
      return (TrophyObjective[]) null;
    }

    [Token(Token = "0x6006445")]
    [Address(RVA = "0x137C440", Offset = "0x137B240", VA = "0x1137C440")]
    public ConceptCardParam GetConceptCardParam(string iname) => (ConceptCardParam) null;

    [Token(Token = "0x17000A24")]
    public AchievementParam[] Achievement
    {
      [Token(Token = "0x6006446"), Address(RVA = "0x138DF90", Offset = "0x138CD90", VA = "0x1138DF90")] get
      {
        return (AchievementParam[]) null;
      }
    }

    [Token(Token = "0x17000A25")]
    public GachaParam[] Gachas
    {
      [Token(Token = "0x6006447"), Address(RVA = "0x138E250", Offset = "0x138D050", VA = "0x1138E250")] get
      {
        return (GachaParam[]) null;
      }
    }

    [Token(Token = "0x6006448")]
    [Address(RVA = "0x1384890", Offset = "0x1383690", VA = "0x11384890")]
    public bool IsFgGAuthSync() => new bool();

    [Token(Token = "0x17000A26")]
    public TowerParam[] Towers
    {
      [Token(Token = "0x6006449"), Address(RVA = "0x138E590", Offset = "0x138D390", VA = "0x1138E590")] get
      {
        return (TowerParam[]) null;
      }
    }

    [Token(Token = "0x17000A27")]
    public TowerResuponse TowerResuponse
    {
      [Token(Token = "0x600644A"), Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")] get
      {
        return (TowerResuponse) null;
      }
    }

    [Token(Token = "0x17000A28")]
    public List<TowerResuponse.PlayerUnit> TowerResuponsePlayerUnit
    {
      [Token(Token = "0x600644B"), Address(RVA = "0x138E570", Offset = "0x138D370", VA = "0x1138E570")] get
      {
        return (List<TowerResuponse.PlayerUnit>) null;
      }
    }

    [Token(Token = "0x17000A29")]
    public List<TowerResuponse.EnemyUnit> TowerEnemyUnit
    {
      [Token(Token = "0x600644C"), Address(RVA = "0x138E550", Offset = "0x138D350", VA = "0x1138E550")] get
      {
        return (List<TowerResuponse.EnemyUnit>) null;
      }
    }

    [Token(Token = "0x17000A2A")]
    public VersusFriendScore[] VersusFriendInfo
    {
      [Token(Token = "0x600644D"), Address(RVA = "0x138E690", Offset = "0x138D490", VA = "0x1138E690")] get
      {
        return (VersusFriendScore[]) null;
      }
    }

    [Token(Token = "0x600644E")]
    [Address(RVA = "0x1384020", Offset = "0x1382E20", VA = "0x11384020", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x600644F")]
    [Address(RVA = "0x13839E0", Offset = "0x13827E0", VA = "0x113839E0")]
    public static void HandleAnyLoadMasterDataErrors(
      GameManager.LoadMasterDataResult result,
      bool flowNodeWillDisplayAnyErrorMessages = false)
    {
    }

    [Token(Token = "0x6006450")]
    [Address(RVA = "0x13870D0", Offset = "0x1385ED0", VA = "0x113870D0")]
    public GameManager.LoadMasterDataResult ReloadMasterData(
      GameManager.MasterDataInBinary masterDataSerialized)
    {
      return new GameManager.LoadMasterDataResult();
    }

    [Token(Token = "0x6006451")]
    [Address(RVA = "0x1387110", Offset = "0x1385F10", VA = "0x11387110")]
    public GameManager.LoadMasterDataResult ReloadMasterData(
      string masterParam = null,
      string questParam = null,
      GameManager.MasterDataInBinary masterDataSerialized = null)
    {
      return new GameManager.LoadMasterDataResult();
    }

    [Token(Token = "0x6006452")]
    [Address(RVA = "0x138A480", Offset = "0x1389280", VA = "0x1138A480")]
    private void Start()
    {
    }

    [Token(Token = "0x6006453")]
    [Address(RVA = "0x1371E10", Offset = "0x1370C10", VA = "0x11371E10")]
    public bool Deserialize(JSON_MasterParam json) => new bool();

    [Token(Token = "0x6006454")]
    [Address(RVA = "0x1371400", Offset = "0x1370200", VA = "0x11371400")]
    public bool Deserialize2(JSON_MasterParam json) => new bool();

    [Token(Token = "0x6006455")]
    [Address(RVA = "0x1376E60", Offset = "0x1375C60", VA = "0x11376E60")]
    public void Deserialize(Json_PlayerData json)
    {
    }

    [Token(Token = "0x6006456")]
    [Address(RVA = "0x13722A0", Offset = "0x13710A0", VA = "0x113722A0")]
    public void Deserialize(Json_HotDealInfo[] json, bool is_refresh = false)
    {
    }

    [Token(Token = "0x6006457")]
    [Address(RVA = "0x1376890", Offset = "0x1375690", VA = "0x11376890")]
    public void Deserialize(Json_TrophyPlayerData json)
    {
    }

    [Token(Token = "0x6006458")]
    [Address(RVA = "0x13770D0", Offset = "0x1375ED0", VA = "0x113770D0")]
    public void Deserialize(Json_Unit[] json)
    {
    }

    [Token(Token = "0x6006459")]
    [Address(RVA = "0x1376F00", Offset = "0x1375D00", VA = "0x11376F00")]
    public void Deserialize(Json_Item[] json)
    {
    }

    [Token(Token = "0x600645A")]
    [Address(RVA = "0x13771D0", Offset = "0x1375FD0", VA = "0x113771D0")]
    public void Deserialize(Json_Artifact[] json, bool differenceUpdate)
    {
    }

    [Token(Token = "0x600645B")]
    [Address(RVA = "0x1377F00", Offset = "0x1376D00", VA = "0x11377F00")]
    public void Deserialize(JSON_ConceptCard[] json, bool is_data_override = true)
    {
    }

    [Token(Token = "0x600645C")]
    [Address(RVA = "0x1377B20", Offset = "0x1376920", VA = "0x11377B20")]
    public void Deserialize(JSON_ConceptCardMaterial[] json, bool is_data_override = true)
    {
    }

    [Token(Token = "0x600645D")]
    [Address(RVA = "0x13778D0", Offset = "0x13766D0", VA = "0x113778D0")]
    public void Deserialize(string[] skin_card_inames)
    {
    }

    [Token(Token = "0x600645E")]
    [Address(RVA = "0x13770A0", Offset = "0x1375EA0", VA = "0x113770A0")]
    public void Deserialize(Json_Skin[] json)
    {
    }

    [Token(Token = "0x600645F")]
    [Address(RVA = "0x1371BC0", Offset = "0x13709C0", VA = "0x11371BC0")]
    public void Deserialize(Json_Party[] json)
    {
    }

    [Token(Token = "0x6006460")]
    [Address(RVA = "0x1376CD0", Offset = "0x1375AD0", VA = "0x11376CD0")]
    public bool Deserialize(Json_Mail[] json) => new bool();

    [Token(Token = "0x6006461")]
    [Address(RVA = "0x13771A0", Offset = "0x1375FA0", VA = "0x113771A0")]
    public void Deserialize(Json_Friend[] json)
    {
    }

    [Token(Token = "0x6006462")]
    [Address(RVA = "0x13775A0", Offset = "0x13763A0", VA = "0x113775A0")]
    public void Deserialize(Json_Friend[] json, FriendStates state)
    {
    }

    [Token(Token = "0x6006463")]
    [Address(RVA = "0x1376ED0", Offset = "0x1375CD0", VA = "0x11376ED0")]
    public void Deserialize(Json_Support[] json)
    {
    }

    [Token(Token = "0x6006464")]
    [Address(RVA = "0x1377C40", Offset = "0x1376A40", VA = "0x11377C40")]
    public void Deserialize(Json_MultiFuids[] json)
    {
    }

    [Token(Token = "0x6006465")]
    [Address(RVA = "0x1377170", Offset = "0x1375F70", VA = "0x11377170")]
    public void Deserialize(FriendPresentWishList.Json[] json)
    {
    }

    [Token(Token = "0x6006466")]
    [Address(RVA = "0x1371DB0", Offset = "0x1370BB0", VA = "0x11371DB0")]
    public void Deserialize(FriendPresentReceiveList.Json[] json)
    {
    }

    [Token(Token = "0x6006467")]
    [Address(RVA = "0x1377EA0", Offset = "0x1376CA0", VA = "0x11377EA0")]
    public void Deserialize(JSON_PlayerGuild json)
    {
    }

    [Token(Token = "0x6006468")]
    [Address(RVA = "0x1377ED0", Offset = "0x1376CD0", VA = "0x11377ED0")]
    public void Deserialize(JSON_Guild json)
    {
    }

    [Token(Token = "0x6006469")]
    [Address(RVA = "0x1371B90", Offset = "0x1370990", VA = "0x11371B90")]
    public void Deserialize(Json_Notify json)
    {
    }

    [Token(Token = "0x600646A")]
    [Address(RVA = "0x1371DE0", Offset = "0x1370BE0", VA = "0x11371DE0")]
    public void Deserialize(Json_Notify_Monthly json)
    {
    }

    [Token(Token = "0x600646B")]
    [Address(RVA = "0x1377FD0", Offset = "0x1376DD0", VA = "0x11377FD0")]
    public void Deserialize(Json_Versus json)
    {
    }

    [Token(Token = "0x600646C")]
    [Address(RVA = "0x1371760", Offset = "0x1370560", VA = "0x11371760")]
    public void Deserialize(ReqGetRune.Response json, bool is_data_override = true)
    {
    }

    [Token(Token = "0x600646D")]
    [Address(RVA = "0x1372270", Offset = "0x1371070", VA = "0x11372270")]
    public void Deserialize(Json_RuneEnforceGaugeData[] json)
    {
    }

    [Token(Token = "0x600646E")]
    [Address(RVA = "0x1372350", Offset = "0x1371150", VA = "0x11372350")]
    public void Deserialize(Json_RuneData[] json, bool is_data_override = true)
    {
    }

    [Token(Token = "0x600646F")]
    [Address(RVA = "0x1377C70", Offset = "0x1376A70", VA = "0x11377C70")]
    public void Deserialize(ReqRuneStorageAdd.Response json)
    {
    }

    [Token(Token = "0x6006470")]
    [Address(RVA = "0x1376D00", Offset = "0x1375B00", VA = "0x11376D00")]
    public void Deserialize(ReqRuneFavorite.Response json, bool is_data_override = true)
    {
    }

    [Token(Token = "0x6006471")]
    [Address(RVA = "0x13726C0", Offset = "0x13714C0", VA = "0x113726C0")]
    public void Deserialize(Json_QuestList json)
    {
    }

    [Token(Token = "0x6006472")]
    [Address(RVA = "0x13722D0", Offset = "0x13710D0", VA = "0x113722D0")]
    public bool Deserialize(Json_AchievementList json) => new bool();

    [Token(Token = "0x6006473")]
    [Address(RVA = "0x1388270", Offset = "0x1387070", VA = "0x11388270")]
    public void ResetJigenQuests(bool is_genesis = false, bool is_advance = false, bool is_pointquest = false)
    {
    }

    [Token(Token = "0x6006474")]
    [Address(RVA = "0x13881F0", Offset = "0x1386FF0", VA = "0x113881F0")]
    public void ResetGpsQuests()
    {
    }

    [Token(Token = "0x6006475")]
    [Address(RVA = "0x13716E0", Offset = "0x13704E0", VA = "0x113716E0")]
    public bool DeserializeGps(JSON_QuestProgress[] jsons) => new bool();

    [Token(Token = "0x6006476")]
    [Address(RVA = "0x1377F30", Offset = "0x1376D30", VA = "0x11377F30")]
    public bool Deserialize(JSON_QuestProgress[] json) => new bool();

    [Token(Token = "0x6006477")]
    [Address(RVA = "0x1376D30", Offset = "0x1375B30", VA = "0x11376D30")]
    public void Deserialize(JSON_ExtraQuestClearElementProgress[] json)
    {
    }

    [Token(Token = "0x6006478")]
    [Address(RVA = "0x13775D0", Offset = "0x13763D0", VA = "0x113775D0")]
    public bool Deserialize(JSON_QuestProgress json) => new bool();

    [Token(Token = "0x6006479")]
    [Address(RVA = "0x13719C0", Offset = "0x13707C0", VA = "0x113719C0")]
    public void Deserialize(JSON_ChapterCount[] json)
    {
    }

    [Token(Token = "0x600647A")]
    [Address(RVA = "0x1376E30", Offset = "0x1375C30", VA = "0x11376E30")]
    public void Deserialize(JSON_ChapterCount json)
    {
    }

    [Token(Token = "0x600647B")]
    [Address(RVA = "0x1371BF0", Offset = "0x13709F0", VA = "0x11371BF0")]
    public bool Deserialize(JSON_OpenedQuestArchivesListResponse listResponse) => new bool();

    [Token(Token = "0x600647C")]
    [Address(RVA = "0x13772E0", Offset = "0x13760E0", VA = "0x113772E0")]
    public bool Deserialize(JSON_QuestArchiveOpenResponse response) => new bool();

    [Token(Token = "0x600647D")]
    [Address(RVA = "0x1377CA0", Offset = "0x1376AA0", VA = "0x11377CA0")]
    public bool Deserialize(Json_GachaList json, bool diff = false) => new bool();

    [Token(Token = "0x600647E")]
    [Address(RVA = "0x1371A90", Offset = "0x1370890", VA = "0x11371A90")]
    public void Deserialize(Json_GachaResult json)
    {
    }

    [Token(Token = "0x600647F")]
    [Address(RVA = "0x1371790", Offset = "0x1370590", VA = "0x11371790")]
    public void Deserialize(Json_GoogleReview json)
    {
    }

    [Token(Token = "0x6006480")]
    [Address(RVA = "0x13724A0", Offset = "0x13712A0", VA = "0x113724A0")]
    public bool Deserialize(Json_ArenaPlayers json) => new bool();

    [Token(Token = "0x6006481")]
    [Address(RVA = "0x1376900", Offset = "0x1375700", VA = "0x11376900")]
    public bool Deserialize(Json_ArenaEnemies json) => new bool();

    [Token(Token = "0x6006482")]
    [Address(RVA = "0x1376AF0", Offset = "0x13758F0", VA = "0x11376AF0")]
    public bool Deserialize(JSON_ArenaRanking json, ReqBtlColoRanking.RankingTypes type)
    {
      return new bool();
    }

    [Token(Token = "0x6006483")]
    [Address(RVA = "0x1371800", Offset = "0x1370600", VA = "0x11371800")]
    public bool Deserialize(JSON_ArenaHistory json) => new bool();

    [Token(Token = "0x6006484")]
    [Address(RVA = "0x1372020", Offset = "0x1370E20", VA = "0x11372020")]
    public void Deserialize(JSON_ReqTowerResuponse json)
    {
    }

    [Token(Token = "0x6006485")]
    [Address(RVA = "0x1372380", Offset = "0x1371180", VA = "0x11372380")]
    public bool Deserialize(JSON_ChatChannelMaster json) => new bool();

    [Token(Token = "0x6006486")]
    [Address(RVA = "0x1377900", Offset = "0x1376700", VA = "0x11377900")]
    public bool Deserialize(Json_VersusFriendScore[] json) => new bool();

    [Token(Token = "0x6006487")]
    [Address(RVA = "0x1377200", Offset = "0x1376000", VA = "0x11377200")]
    public bool Deserialize(JSON_QuestCombatPowers json) => new bool();

    [Token(Token = "0x6006488")]
    [Address(RVA = "0x1377100", Offset = "0x1375F00", VA = "0x11377100")]
    public bool Deserialize(JSON_AreaCombatPower[] json) => new bool();

    [Token(Token = "0x6006489")]
    [Address(RVA = "0x1377AB0", Offset = "0x13768B0", VA = "0x11377AB0")]
    public bool Deserialize(JSON_QuestCombatPower[] json) => new bool();

    [Token(Token = "0x600648A")]
    [Address(RVA = "0x1389AE0", Offset = "0x13888E0", VA = "0x11389AE0")]
    public bool SetVersusWinCount(int wincnt) => new bool();

    [Token(Token = "0x600648B")]
    [Address(RVA = "0x1389A80", Offset = "0x1388880", VA = "0x11389A80")]
    public void SetVersuTowerEndParam(
      bool rankup,
      bool winbonus,
      int key,
      int floor,
      int arravied)
    {
    }

    [Token(Token = "0x600648C")]
    [Address(RVA = "0x36AA10", Offset = "0x369810", VA = "0x1036AA10")]
    public VsTowerMatchEndParam GetVsTowerMatchEndParam() => (VsTowerMatchEndParam) null;

    [Token(Token = "0x600648D")]
    [Address(RVA = "0x38B0F0", Offset = "0x389EF0", VA = "0x1038B0F0")]
    public void SetAvailableRankingQuestParams(List<RankingQuestParam> value)
    {
    }

    [Token(Token = "0x600648E")]
    [Address(RVA = "0x1381550", Offset = "0x1380350", VA = "0x11381550")]
    public UnitParam GetUnitParam(string key) => (UnitParam) null;

    [Token(Token = "0x600648F")]
    [Address(RVA = "0x1381190", Offset = "0x137FF90", VA = "0x11381190")]
    public SkillParam GetSkillParam(string key) => (SkillParam) null;

    [Token(Token = "0x6006490")]
    [Address(RVA = "0x137A330", Offset = "0x1379130", VA = "0x1137A330")]
    public AbilityParam GetAbilityParam(string key) => (AbilityParam) null;

    [Token(Token = "0x6006491")]
    [Address(RVA = "0x137F040", Offset = "0x137DE40", VA = "0x1137F040")]
    public ItemParam GetItemParam(string key) => (ItemParam) null;

    [Token(Token = "0x6006492")]
    [Address(RVA = "0x137C020", Offset = "0x137AE20", VA = "0x1137C020")]
    public AwardParam GetAwardParam(string key) => (AwardParam) null;

    [Token(Token = "0x6006493")]
    [Address(RVA = "0x137D130", Offset = "0x137BF30", VA = "0x1137D130")]
    public GeoParam GetGeoParam(string key) => (GeoParam) null;

    [Token(Token = "0x6006494")]
    [Address(RVA = "0x1383860", Offset = "0x1382660", VA = "0x11383860")]
    public WeaponParam GetWeaponParam(string key) => (WeaponParam) null;

    [Token(Token = "0x6006495")]
    [Address(RVA = "0x1380DF0", Offset = "0x137FBF0", VA = "0x11380DF0")]
    public RecipeParam GetRecipeParam(string key) => (RecipeParam) null;

    [Token(Token = "0x6006496")]
    [Address(RVA = "0x137F070", Offset = "0x137DE70", VA = "0x1137F070")]
    public JobParam GetJobParam(string key) => (JobParam) null;

    [Token(Token = "0x6006497")]
    [Address(RVA = "0x137AE10", Offset = "0x1379C10", VA = "0x1137AE10")]
    public JobParam[] GetAllJobs() => (JobParam[]) null;

    [Token(Token = "0x6006498")]
    [Address(RVA = "0x137F0A0", Offset = "0x137DEA0", VA = "0x1137F0A0")]
    public JobSetParam GetJobSetParam(string key) => (JobSetParam) null;

    [Token(Token = "0x6006499")]
    [Address(RVA = "0x137C410", Offset = "0x137B210", VA = "0x1137C410")]
    public JobSetParam[] GetClassChangeJobSetParam(string key) => (JobSetParam[]) null;

    [Token(Token = "0x600649A")]
    [Address(RVA = "0x137D160", Offset = "0x137BF60", VA = "0x1137D160")]
    public GrowParam GetGrowParam(string key) => (GrowParam) null;

    [Token(Token = "0x600649B")]
    [Address(RVA = "0x137A300", Offset = "0x1379100", VA = "0x1137A300")]
    public AIParam GetAIParam(string key) => (AIParam) null;

    [Token(Token = "0x600649C")]
    [Address(RVA = "0x1380DC0", Offset = "0x137FBC0", VA = "0x11380DC0")]
    public RarityParam GetRarityParam(int rarity) => (RarityParam) null;

    [Token(Token = "0x600649D")]
    [Address(RVA = "0x137C9A0", Offset = "0x137B7A0", VA = "0x1137C9A0")]
    public List<GachaParam> GetGachaList(string category) => (List<GachaParam>) null;

    [Token(Token = "0x600649E")]
    [Address(RVA = "0x137C3B0", Offset = "0x137B1B0", VA = "0x1137C3B0")]
    public ChatChannelMasterParam[] GetChatChannelMaster() => (ChatChannelMasterParam[]) null;

    [Token(Token = "0x17000A2B")]
    public string DeviceId
    {
      [Token(Token = "0x600649F"), Address(RVA = "0x138E1E0", Offset = "0x138CFE0", VA = "0x1138E1E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A2C")]
    public string SecretKey
    {
      [Token(Token = "0x60064A0"), Address(RVA = "0x138E4F0", Offset = "0x138D2F0", VA = "0x1138E4F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A2D")]
    public string UdId
    {
      [Token(Token = "0x60064A1"), Address(RVA = "0x138E5F0", Offset = "0x138D3F0", VA = "0x1138E5F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60064A2")]
    [Address(RVA = "0x13845F0", Offset = "0x13833F0", VA = "0x113845F0")]
    public bool IsDeviceId() => new bool();

    [Token(Token = "0x60064A3")]
    [Address(RVA = "0x1383EB0", Offset = "0x1382CB0", VA = "0x11383EB0")]
    public bool InitAuth() => new bool();

    [Token(Token = "0x60064A4")]
    [Address(RVA = "0x1388560", Offset = "0x1387360", VA = "0x11388560")]
    public void SaveAuth(string device_id)
    {
    }

    [Token(Token = "0x60064A5")]
    [Address(RVA = "0x13884A0", Offset = "0x13872A0", VA = "0x113884A0")]
    public void SaveAuthWithKey(string device_id, string secretKey)
    {
    }

    [Token(Token = "0x60064A6")]
    [Address(RVA = "0x1388600", Offset = "0x1387400", VA = "0x11388600")]
    public void SaveDeletionToken(string token)
    {
    }

    [Token(Token = "0x60064A7")]
    [Address(RVA = "0x1388130", Offset = "0x1386F30", VA = "0x11388130")]
    public void ResetAuth()
    {
    }

    [Token(Token = "0x60064A8")]
    [Address(RVA = "0x1389A60", Offset = "0x1388860", VA = "0x11389A60")]
    public void SetExistsUDID(bool value)
    {
    }

    [Token(Token = "0x60064A9")]
    [Address(RVA = "0x1389A50", Offset = "0x1388850", VA = "0x11389A50")]
    public void SetExistsSecretKey(bool value)
    {
    }

    [Token(Token = "0x60064AA")]
    [Address(RVA = "0x1389A30", Offset = "0x1388830", VA = "0x11389A30")]
    public void SetExistsDeviceId(bool value)
    {
    }

    [Token(Token = "0x60064AB")]
    [Address(RVA = "0x13881D0", Offset = "0x1386FD0", VA = "0x113881D0")]
    public void ResetExistsAccount()
    {
    }

    [Token(Token = "0x60064AC")]
    [Address(RVA = "0x137A260", Offset = "0x1379060", VA = "0x1137A260")]
    private string GenerateSalt() => (string) null;

    [Token(Token = "0x60064AD")]
    [Address(RVA = "0x137A1A0", Offset = "0x1378FA0", VA = "0x1137A1A0")]
    private string GenerateHash(string pass, string salt) => (string) null;

    [Token(Token = "0x60064AE")]
    [Address(RVA = "0x13782F0", Offset = "0x13770F0", VA = "0x113782F0")]
    public string Encrypt(string key, string iv, string src) => (string) null;

    [Token(Token = "0x60064AF")]
    [Address(RVA = "0x1371200", Offset = "0x1370000", VA = "0x11371200")]
    public string Decrypt(string key, string iv, string src) => (string) null;

    [Token(Token = "0x60064B0")]
    [Address(RVA = "0x1370090", Offset = "0x136EE90", VA = "0x11370090")]
    public bool CheckBadges(GameManager.BadgeTypes type) => new bool();

    [Token(Token = "0x60064B1")]
    [Address(RVA = "0x13700B0", Offset = "0x136EEB0", VA = "0x113700B0")]
    public bool CheckBusyBadges(GameManager.BadgeTypes type) => new bool();

    [Token(Token = "0x60064B2")]
    [Address(RVA = "0x1387E00", Offset = "0x1386C00", VA = "0x11387E00")]
    public void RequestUpdateBadges(GameManager.BadgeTypes type)
    {
    }

    [Token(Token = "0x60064B3")]
    [Address(RVA = "0x138C1E0", Offset = "0x138AFE0", VA = "0x1138C1E0")]
    private IEnumerator UpdateUnitsBadges() => (IEnumerator) null;

    [Token(Token = "0x60064B4")]
    [Address(RVA = "0x138C180", Offset = "0x138AF80", VA = "0x1138C180")]
    private IEnumerator UpdateUnitUnlockBadges() => (IEnumerator) null;

    [Token(Token = "0x60064B5")]
    [Address(RVA = "0x13700D0", Offset = "0x136EED0", VA = "0x113700D0")]
    public bool CheckEnableUnitUnlock(UnitParam unit) => new bool();

    [Token(Token = "0x60064B6")]
    [Address(RVA = "0x137F0D0", Offset = "0x137DED0", VA = "0x1137F0D0")]
    public void GetLearningAbilitySource(
      UnitData unit,
      string abilityID,
      out JobParam job,
      out int rank)
    {
    }

    [Token(Token = "0x60064B7")]
    [Address(RVA = "0x137C5A0", Offset = "0x137B3A0", VA = "0x1137C5A0")]
    public SectionParam GetCurrentSectionParam() => (SectionParam) null;

    [Token(Token = "0x17000A2E")]
    public bool IsLogin
    {
      [Token(Token = "0x60064B8"), Address(RVA = "0x138E3C0", Offset = "0x138D1C0", VA = "0x1138E3C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60064B9")]
    [Address(RVA = "0x13866E0", Offset = "0x13854E0", VA = "0x113866E0")]
    public void PostLogin()
    {
    }

    [Token(Token = "0x60064BA")]
    [Address(RVA = "0x13858E0", Offset = "0x13846E0", VA = "0x113858E0")]
    public void NotifyAbilityRankUpCountChanged()
    {
    }

    [Token(Token = "0x60064BB")]
    [Address(RVA = "0x138A900", Offset = "0x1389700", VA = "0x1138A900")]
    private void UpdateResolution()
    {
    }

    [Token(Token = "0x60064BC")]
    [Address(RVA = "0x138C250", Offset = "0x138B050", VA = "0x1138C250")]
    private void Update()
    {
    }

    [Token(Token = "0x60064BD")]
    [Address(RVA = "0x1371180", Offset = "0x136FF80", VA = "0x11371180")]
    private void DayChanged()
    {
    }

    [Token(Token = "0x60064BE")]
    [Address(RVA = "0x138A430", Offset = "0x1389230", VA = "0x1138A430")]
    public void StartBuyStaminaSequence(bool staminaLacking)
    {
    }

    [Token(Token = "0x60064BF")]
    [Address(RVA = "0x1389F10", Offset = "0x1388D10", VA = "0x11389F10")]
    public void StartBuyStaminaSequence(bool _staminaLacking, PartyWindow2 _pwindow)
    {
    }

    [Token(Token = "0x60064C0")]
    [Address(RVA = "0x1389EA0", Offset = "0x1388CA0", VA = "0x11389EA0")]
    private IEnumerator StartBuyStaminaSequence2(PartyWindow2 _pwindow) => (IEnumerator) null;

    [Token(Token = "0x60064C1")]
    [Address(RVA = "0x1370510", Offset = "0x136F310", VA = "0x11370510")]
    private void ContinueBuyStamina()
    {
    }

    [Token(Token = "0x60064C2")]
    [Address(RVA = "0x1385790", Offset = "0x1384590", VA = "0x11385790")]
    public bool NotRequiredHeal() => new bool();

    [Token(Token = "0x60064C3")]
    [Address(RVA = "0x1370280", Offset = "0x136F080", VA = "0x11370280")]
    public bool CoinShortage() => new bool();

    [Token(Token = "0x60064C4")]
    [Address(RVA = "0x1385FF0", Offset = "0x1384DF0", VA = "0x11385FF0")]
    private void OnBuyStamina(WWWResult www)
    {
    }

    [Token(Token = "0x60064C5")]
    [Address(RVA = "0x13703F0", Offset = "0x136F1F0", VA = "0x113703F0")]
    public void ConfirmBuyCoin(GameManager.BuyCoinEvent onEnd, GameManager.BuyCoinEvent onCancel)
    {
    }

    [Token(Token = "0x60064C6")]
    [Address(RVA = "0x1385FA0", Offset = "0x1384DA0", VA = "0x11385FA0")]
    private void OnBuyCoinEnd(GameObject go)
    {
    }

    [Token(Token = "0x60064C7")]
    [Address(RVA = "0x1385F60", Offset = "0x1384D60", VA = "0x11385F60")]
    private void OnBuyCoinConfirmCancel(GameObject go)
    {
    }

    [Token(Token = "0x60064C8")]
    [Address(RVA = "0x1389D10", Offset = "0x1388B10", VA = "0x11389D10")]
    public void StartBuyCoinSequence()
    {
    }

    [Token(Token = "0x17000A2F")]
    public bool IsBuyCoinWindowOpen
    {
      [Token(Token = "0x60064C9"), Address(RVA = "0x138E300", Offset = "0x138D100", VA = "0x1138E300")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60064CA")]
    [Address(RVA = "0x138C240", Offset = "0x138B040", VA = "0x1138C240")]
    public void UpdateVisibleExpansionRepurchaseBadge()
    {
    }

    [Token(Token = "0x60064CB")]
    [Address(RVA = "0x1386D20", Offset = "0x1385B20", VA = "0x11386D20")]
    public void RegisterImportantJob(Coroutine co)
    {
    }

    [Token(Token = "0x60064CC")]
    [Address(RVA = "0x136FB60", Offset = "0x136E960", VA = "0x1136FB60")]
    private IEnumerator AsyncWaitForImportantJobs() => (IEnumerator) null;

    [Token(Token = "0x17000A30")]
    public bool IsImportantJobRunning
    {
      [Token(Token = "0x60064CD"), Address(RVA = "0x138E370", Offset = "0x138D170", VA = "0x1138E370")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60064CE")]
    [Address(RVA = "0x13869C0", Offset = "0x13857C0", VA = "0x113869C0")]
    public bool PrepareSceneChange() => new bool();

    [Token(Token = "0x60064CF")]
    [Address(RVA = "0x136F870", Offset = "0x136E670", VA = "0x1136F870")]
    public void ApplyTextureAsync(RawImage target, string path)
    {
    }

    [Token(Token = "0x60064D0")]
    [Address(RVA = "0x1387D20", Offset = "0x1386B20", VA = "0x11387D20")]
    private bool RequestTexture(GameManager.TextureRequest texReq) => new bool();

    [Token(Token = "0x60064D1")]
    [Address(RVA = "0x136FFC0", Offset = "0x136EDC0", VA = "0x1136FFC0")]
    public void CancelTextureLoadRequest(RawImage target)
    {
    }

    [Token(Token = "0x60064D2")]
    [Address(RVA = "0x138AA80", Offset = "0x1389880", VA = "0x1138AA80")]
    private void UpdateTextureLoadRequests()
    {
    }

    [Token(Token = "0x60064D3")]
    [Address(RVA = "0x13703E0", Offset = "0x136F1E0", VA = "0x113703E0")]
    public void CompleteTutorialStep()
    {
    }

    [Token(Token = "0x60064D4")]
    [Address(RVA = "0x13803E0", Offset = "0x137F1E0", VA = "0x113803E0")]
    public string GetNextTutorialStep() => (string) null;

    [Token(Token = "0x60064D5")]
    [Address(RVA = "0x138BFA0", Offset = "0x138ADA0", VA = "0x1138BFA0")]
    public void UpdateTutorialFlags(long add)
    {
    }

    [Token(Token = "0x60064D6")]
    [Address(RVA = "0x138BE50", Offset = "0x138AC50", VA = "0x1138BE50")]
    public void UpdateTutorialFlags(string flagName)
    {
    }

    [Token(Token = "0x60064D7")]
    [Address(RVA = "0x1384E90", Offset = "0x1383C90", VA = "0x11384E90")]
    public bool IsTutorialFlagSet(string flagName) => new bool();

    [Token(Token = "0x17000A31")]
    public int TutorialStep
    {
      [Token(Token = "0x60064D8"), Address(RVA = "0x349040", Offset = "0x347E40", VA = "0x10349040")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60064D9")]
    [Address(RVA = "0x1386350", Offset = "0x1385150", VA = "0x11386350")]
    private void OnTutorialFlagUpdate(WWWResult www)
    {
    }

    [Token(Token = "0x60064DA")]
    [Address(RVA = "0x13841C0", Offset = "0x1382FC0", VA = "0x113841C0")]
    public bool IsClearedTutorialQuestAll() => new bool();

    [Token(Token = "0x60064DB")]
    [Address(RVA = "0x1378090", Offset = "0x1376E90", VA = "0x11378090")]
    public void DownloadAndTransitScene(string sceneName)
    {
    }

    [Token(Token = "0x60064DC")]
    [Address(RVA = "0x1378030", Offset = "0x1376E30", VA = "0x11378030")]
    private IEnumerator DownloadAndTransitSceneAsync(string sceneName) => (IEnumerator) null;

    [Token(Token = "0x60064DD")]
    [Address(RVA = "0x138C0D0", Offset = "0x138AED0", VA = "0x1138C0D0")]
    public void UpdateTutorialStep()
    {
    }

    [Token(Token = "0x60064DE")]
    [Address(RVA = "0x1385930", Offset = "0x1384730", VA = "0x11385930")]
    public void OnAgreeTermsOfUse(object caller)
    {
    }

    [Token(Token = "0x60064DF")]
    [Address(RVA = "0x1384180", Offset = "0x1382F80", VA = "0x11384180")]
    public bool IsAgreeTermsOfUse() => new bool();

    [Token(Token = "0x60064E0")]
    [Address(RVA = "0x1386A70", Offset = "0x1385870", VA = "0x11386A70")]
    public void RefreshTutorialDLAssets(bool forceRefresh = false)
    {
    }

    [Token(Token = "0x17000A32")]
    public bool HasTutorialDLAssets
    {
      [Token(Token = "0x60064E1"), Address(RVA = "0x138E2A0", Offset = "0x138D0A0", VA = "0x1138E2A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60064E2")]
    [Address(RVA = "0x1378190", Offset = "0x1376F90", VA = "0x11378190")]
    public void DownloadTutorialAssets()
    {
    }

    [Token(Token = "0x60064E3")]
    [Address(RVA = "0x13863C0", Offset = "0x13851C0", VA = "0x113863C0")]
    public bool PartialDownloadTutorialAssets() => new bool();

    [Token(Token = "0x60064E4")]
    [Address(RVA = "0x138C590", Offset = "0x138B390", VA = "0x1138C590")]
    private IEnumerator WaitDownloadAsync(
      List<AssetList.Item> queue,
      AssetDownloader.DownloadState state)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60064E5")]
    [Address(RVA = "0x13859A0", Offset = "0x13847A0", VA = "0x113859A0")]
    private void OnApplicationFocus(bool focus)
    {
    }

    [Token(Token = "0x60064E6")]
    [Address(RVA = "0x1385270", Offset = "0x1384070", VA = "0x11385270")]
    public void LoadUpdateTrophyList()
    {
    }

    [Token(Token = "0x60064E7")]
    [Address(RVA = "0x1388630", Offset = "0x1387430", VA = "0x11388630")]
    public void SaveUpdateTrophyList(List<TrophyState> updateList)
    {
    }

    [Token(Token = "0x60064E8")]
    [Address(RVA = "0x1384D00", Offset = "0x1383B00", VA = "0x11384D00")]
    private bool IsSavedUpdateTrophyStateNeedToSend(
      TrophyState server,
      int ymd,
      int[] count,
      bool isEnded)
    {
      return new bool();
    }

    [Token(Token = "0x60064E9")]
    [Address(RVA = "0x1370EF0", Offset = "0x136FCF0", VA = "0x11370EF0")]
    public void CreateUpdateTrophyList(
      out List<TrophyState> updateTrophyList,
      out List<TrophyState> updateChallengeList,
      out List<TrophyState> updateTrophyAward)
    {
    }

    [Token(Token = "0x60064EA")]
    [Address(RVA = "0x1384830", Offset = "0x1383630", VA = "0x11384830")]
    public bool IsExternalPermit() => new bool();

    [Token(Token = "0x60064EB")]
    [Address(RVA = "0x138BD00", Offset = "0x138AB00", VA = "0x1138BD00")]
    private void UpdateTrophy()
    {
    }

    [Token(Token = "0x60064EC")]
    [Address(RVA = "0x138ACE0", Offset = "0x1389AE0", VA = "0x1138ACE0")]
    public void UpdateTrophyAPI()
    {
    }

    [Token(Token = "0x60064ED")]
    [Address(RVA = "0x138B810", Offset = "0x138A610", VA = "0x1138B810")]
    private void UpdateTrophyResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60064EE")]
    [Address(RVA = "0x138A660", Offset = "0x1389460", VA = "0x1138A660")]
    private void UpdateChallengeResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60064EF")]
    [Address(RVA = "0x138B2D0", Offset = "0x138A0D0", VA = "0x1138B2D0")]
    private void UpdateTrophyAwardResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60064F0")]
    [Address(RVA = "0x1389320", Offset = "0x1388120", VA = "0x11389320")]
    public void ServerSyncTrophyExecStart(out string trophy_progs, out string bingo_progs)
    {
    }

    [Token(Token = "0x60064F1")]
    [Address(RVA = "0x1388C00", Offset = "0x1387A00", VA = "0x11388C00")]
    public void ServerSyncTrophyExecEnd(WWWResult www)
    {
    }

    [Token(Token = "0x60064F2")]
    [Address(RVA = "0x136F690", Offset = "0x136E490", VA = "0x1136F690")]
    public void AddCharacterQuestPopup(UnitData unit)
    {
    }

    [Token(Token = "0x60064F3")]
    [Address(RVA = "0x1389BD0", Offset = "0x13889D0", VA = "0x11389BD0")]
    public void ShowCharacterQuestPopup(string template)
    {
    }

    [Token(Token = "0x60064F4")]
    [Address(RVA = "0x1389B60", Offset = "0x1388960", VA = "0x11389B60")]
    public IEnumerator ShowCharacterQuestPopupAsync(string template) => (IEnumerator) null;

    [Token(Token = "0x60064F5")]
    [Address(RVA = "0x1389CB0", Offset = "0x1388AB0", VA = "0x11389CB0")]
    public IEnumerator SkinUnlockPopup(ArtifactParam unlockSkin) => (IEnumerator) null;

    [Token(Token = "0x60064F6")]
    [Address(RVA = "0x1389C50", Offset = "0x1388A50", VA = "0x11389C50")]
    public IEnumerator SkinUnlockPopup(ItemParam[] rewardItems) => (IEnumerator) null;

    [Token(Token = "0x17000A33")]
    public long LimitedShopEndAt
    {
      [Token(Token = "0x60064F7"), Address(RVA = "0x138E3F0", Offset = "0x138D1F0", VA = "0x1138E3F0")] get
      {
        return new long();
      }
      [Token(Token = "0x60064F8"), Address(RVA = "0x138E940", Offset = "0x138D740", VA = "0x1138E940")] set
      {
      }
    }

    [Token(Token = "0x17000A34")]
    public JSON_ShopListArray.Shops[] LimitedShopList
    {
      [Token(Token = "0x60064F9"), Address(RVA = "0x138E410", Offset = "0x138D210", VA = "0x1138E410")] get
      {
        return (JSON_ShopListArray.Shops[]) null;
      }
      [Token(Token = "0x60064FA"), Address(RVA = "0x92A340", Offset = "0x929140", VA = "0x1092A340")] set
      {
      }
    }

    [Token(Token = "0x17000A35")]
    public bool IsLimitedShopOpen
    {
      [Token(Token = "0x60064FB"), Address(RVA = "0x138E880", Offset = "0x138D680", VA = "0x1138E880")] set
      {
      }
      [Token(Token = "0x60064FC"), Address(RVA = "0x138E3B0", Offset = "0x138D1B0", VA = "0x1138E3B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60064FD")]
    [Address(RVA = "0x1376F30", Offset = "0x1375D30", VA = "0x11376F30")]
    public void Deserialize(ReqMultiRank.Json_MultiRank json)
    {
    }

    [Token(Token = "0x60064FE")]
    [Address(RVA = "0x1377B50", Offset = "0x1376950", VA = "0x11377B50")]
    public void Deserialize(RankingData[] datas)
    {
    }

    [Token(Token = "0x17000A36")]
    public List<MultiRanking> MultiUnitRank
    {
      [Token(Token = "0x60064FF"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (List<MultiRanking>) null;
      }
    }

    [Token(Token = "0x17000A37")]
    public Dictionary<string, RankingData> UnitRanking
    {
      [Token(Token = "0x6006500"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (Dictionary<string, RankingData>) null;
      }
    }

    [Token(Token = "0x6006501")]
    [Address(RVA = "0x1370C40", Offset = "0x136FA40", VA = "0x11370C40")]
    public void CreateMatchingRange()
    {
    }

    [Token(Token = "0x6006502")]
    [Address(RVA = "0x13829E0", Offset = "0x13817E0", VA = "0x113829E0")]
    public string GetVersusKey(VERSUS_TYPE type) => (string) null;

    [Token(Token = "0x6006503")]
    [Address(RVA = "0x13811C0", Offset = "0x137FFC0", VA = "0x113811C0")]
    public void GetTowerMatchItems(int floor, List<string> Items, List<int> Nums, bool bWin)
    {
    }

    [Token(Token = "0x6006504")]
    [Address(RVA = "0x1383620", Offset = "0x1382420", VA = "0x11383620")]
    public void GetVersusTopFloorItems(int floor, List<string> Items, List<int> Nums)
    {
    }

    [Token(Token = "0x6006505")]
    [Address(RVA = "0x1383810", Offset = "0x1382610", VA = "0x11383810")]
    public VersusTowerParam[] GetVersusTowerParam() => (VersusTowerParam[]) null;

    [Token(Token = "0x6006506")]
    [Address(RVA = "0x137C6B0", Offset = "0x137B4B0", VA = "0x1137C6B0")]
    public VersusTowerParam GetCurrentVersusTowerParam(int idx = -1) => (VersusTowerParam) null;

    [Token(Token = "0x6006507")]
    [Address(RVA = "0x1380D00", Offset = "0x137FB00", VA = "0x11380D00")]
    public void GetRankMatchCondition(out int lrange, out int frange)
    {
    }

    [Token(Token = "0x6006508")]
    [Address(RVA = "0x1383DC0", Offset = "0x1382BC0", VA = "0x11383DC0")]
    public void InitAlterHash(string digest = null, string quest_digest = null)
    {
    }

    [Token(Token = "0x6006509")]
    [Address(RVA = "0x137A030", Offset = "0x1378E30", VA = "0x1137A030")]
    public VersusScheduleParam FindVersusTowerScheduleParam(string towerID)
    {
      return (VersusScheduleParam) null;
    }

    [Token(Token = "0x600650A")]
    [Address(RVA = "0x1378500", Offset = "0x1377300", VA = "0x11378500")]
    public bool ExistsOpenVersusTower(string towerID = null) => new bool();

    [Token(Token = "0x600650B")]
    [Address(RVA = "0x13822C0", Offset = "0x13810C0", VA = "0x113822C0")]
    public VersusCoinParam GetVersusCoinParam(string iname) => (VersusCoinParam) null;

    [Token(Token = "0x600650C")]
    [Address(RVA = "0x13827A0", Offset = "0x13815A0", VA = "0x113827A0")]
    public VersusFriendScore[] GetVersusFriendScore(int floor) => (VersusFriendScore[]) null;

    [Token(Token = "0x600650D")]
    [Address(RVA = "0x13851B0", Offset = "0x1383FB0", VA = "0x113851B0")]
    public bool IsVersusMode() => new bool();

    [Token(Token = "0x600650E")]
    [Address(RVA = "0x137F1A0", Offset = "0x137DFA0", VA = "0x1137F1A0")]
    public List<MultiTowerFloorParam> GetMTAllFloorParam(string type)
    {
      return (List<MultiTowerFloorParam>) null;
    }

    [Token(Token = "0x600650F")]
    [Address(RVA = "0x137F390", Offset = "0x137E190", VA = "0x1137F390")]
    public MultiTowerFloorParam GetMTFloorParam(string type, int floor)
    {
      return (MultiTowerFloorParam) null;
    }

    [Token(Token = "0x6006510")]
    [Address(RVA = "0x137F450", Offset = "0x137E250", VA = "0x1137F450")]
    public MultiTowerFloorParam GetMTFloorParam(string iname) => (MultiTowerFloorParam) null;

    [Token(Token = "0x6006511")]
    [Address(RVA = "0x1379090", Offset = "0x1377E90", VA = "0x11379090")]
    public MultiTowerFloorParam FindMultiTowerFloorParam(string iname)
    {
      return (MultiTowerFloorParam) null;
    }

    [Token(Token = "0x6006512")]
    [Address(RVA = "0x137F580", Offset = "0x137E380", VA = "0x1137F580")]
    public List<MultiTowerRewardItem> GetMTFloorReward(string iname, int round)
    {
      return (List<MultiTowerRewardItem>) null;
    }

    [Token(Token = "0x6006513")]
    [Address(RVA = "0x137F650", Offset = "0x137E450", VA = "0x1137F650")]
    public int GetMTRound(int floor) => new int();

    [Token(Token = "0x6006514")]
    [Address(RVA = "0x137F370", Offset = "0x137E170", VA = "0x1137F370")]
    public int GetMTClearedMaxFloor() => new int();

    [Token(Token = "0x6006515")]
    [Address(RVA = "0x137F2A0", Offset = "0x137E0A0", VA = "0x1137F2A0")]
    public int GetMTChallengeFloor() => new int();

    [Token(Token = "0x6006516")]
    [Address(RVA = "0x136F7D0", Offset = "0x136E5D0", VA = "0x1136F7D0")]
    public void AddMTQuest(string iname, QuestParam param)
    {
    }

    [Token(Token = "0x6006517")]
    [Address(RVA = "0x137F6C0", Offset = "0x137E4C0", VA = "0x1137F6C0")]
    public List<int> GetMTSkipFloorList() => (List<int>) null;

    [Token(Token = "0x6006518")]
    [Address(RVA = "0x1384BB0", Offset = "0x13839B0", VA = "0x11384BB0")]
    public bool IsMTCanSkip() => new bool();

    [Token(Token = "0x6006519")]
    [Address(RVA = "0x1372090", Offset = "0x1370E90", VA = "0x11372090")]
    public void Deserialize(ReqMultiTwStatus.FloorParam[] param)
    {
    }

    [Token(Token = "0x600651A")]
    [Address(RVA = "0x1372690", Offset = "0x1371490", VA = "0x11372690")]
    public void Deserialize(ReqMultiTwStatus.Response param)
    {
    }

    [Token(Token = "0x600651B")]
    [Address(RVA = "0x137F7F0", Offset = "0x137E5F0", VA = "0x1137F7F0")]
    public SRPG.MapEffectParam GetMapEffectParam(string iname) => (SRPG.MapEffectParam) null;

    [Token(Token = "0x600651C")]
    [Address(RVA = "0x1383890", Offset = "0x1382690", VA = "0x11383890")]
    public WeatherSetParam GetWeatherSetParam(string iname) => (WeatherSetParam) null;

    [Token(Token = "0x600651D")]
    [Address(RVA = "0x137CBF0", Offset = "0x137B9F0", VA = "0x1137CBF0")]
    public GenesisChapterParam GetGenesisChapterParam(string iname) => (GenesisChapterParam) null;

    [Token(Token = "0x600651E")]
    [Address(RVA = "0x137CAA0", Offset = "0x137B8A0", VA = "0x1137CAA0")]
    public GenesisChapterParam GetGenesisChapterParamFromAreaId(string area_id)
    {
      return (GenesisChapterParam) null;
    }

    [Token(Token = "0x600651F")]
    [Address(RVA = "0x137CFE0", Offset = "0x137BDE0", VA = "0x1137CFE0")]
    public GenesisStarParam GetGenesisStarParam(string iname) => (GenesisStarParam) null;

    [Token(Token = "0x6006520")]
    [Address(RVA = "0x137CE90", Offset = "0x137BC90", VA = "0x1137CE90")]
    public GenesisRewardParam GetGenesisRewardParam(string iname) => (GenesisRewardParam) null;

    [Token(Token = "0x6006521")]
    [Address(RVA = "0x137CD40", Offset = "0x137BB40", VA = "0x1137CD40")]
    public GenesisLapBossParam GetGenesisLapBossParam(string iname) => (GenesisLapBossParam) null;

    [Token(Token = "0x6006522")]
    [Address(RVA = "0x137A8D0", Offset = "0x13796D0", VA = "0x1137A8D0")]
    public AdvanceEventParam GetAdvanceEventParam(string iname) => (AdvanceEventParam) null;

    [Token(Token = "0x6006523")]
    [Address(RVA = "0x137A780", Offset = "0x1379580", VA = "0x1137A780")]
    public AdvanceEventParam GetAdvanceEventParamFromAreaId(string area_id)
    {
      return (AdvanceEventParam) null;
    }

    [Token(Token = "0x6006524")]
    [Address(RVA = "0x137ACC0", Offset = "0x1379AC0", VA = "0x1137ACC0")]
    public AdvanceStarParam GetAdvanceStarParam(string iname) => (AdvanceStarParam) null;

    [Token(Token = "0x6006525")]
    [Address(RVA = "0x137AB70", Offset = "0x1379970", VA = "0x1137AB70")]
    public AdvanceRewardParam GetAdvanceRewardParam(string iname) => (AdvanceRewardParam) null;

    [Token(Token = "0x6006526")]
    [Address(RVA = "0x137AA20", Offset = "0x1379820", VA = "0x1137AA20")]
    public AdvanceLapBossParam GetAdvanceLapBossParam(string iname) => (AdvanceLapBossParam) null;

    [Token(Token = "0x6006527")]
    [Address(RVA = "0x13804F0", Offset = "0x137F2F0", VA = "0x113804F0")]
    public GuildRaidPeriodParam GetNowScheduleGuildRaidPeriodParam() => (GuildRaidPeriodParam) null;

    [Token(Token = "0x6006528")]
    [Address(RVA = "0x137A360", Offset = "0x1379160", VA = "0x1137A360")]
    public GuildRaidPeriodParam GetActiveGuildRaidRankingPeriod() => (GuildRaidPeriodParam) null;

    [Token(Token = "0x6006529")]
    [Address(RVA = "0x137A570", Offset = "0x1379370", VA = "0x1137A570")]
    public GuildRaidPeriodParam GetActiveGuildRaidRewardPeriod() => (GuildRaidPeriodParam) null;

    [Token(Token = "0x600652A")]
    [Address(RVA = "0x137D9F0", Offset = "0x137C7F0", VA = "0x1137D9F0")]
    public GuildRaidPeriodParam GetGuildRaidPeriodParam(int id) => (GuildRaidPeriodParam) null;

    [Token(Token = "0x600652B")]
    [Address(RVA = "0x137DD90", Offset = "0x137CB90", VA = "0x1137DD90")]
    public GuildRaidManager.GuildRaidScheduleType GetGuildRaidPeriodScheduleType()
    {
      return new GuildRaidManager.GuildRaidScheduleType();
    }

    [Token(Token = "0x600652C")]
    [Address(RVA = "0x137DB60", Offset = "0x137C960", VA = "0x1137DB60")]
    public GuildRaidManager.GuildRaidScheduleType GetGuildRaidPeriodScheduleType(int id)
    {
      return new GuildRaidManager.GuildRaidScheduleType();
    }

    [Token(Token = "0x600652D")]
    [Address(RVA = "0x137E7A0", Offset = "0x137D5A0", VA = "0x1137E7A0")]
    public GuildRaidRewardParam GetGuildRaidRewardParam(string id) => (GuildRaidRewardParam) null;

    [Token(Token = "0x600652E")]
    [Address(RVA = "0x137EEF0", Offset = "0x137DCF0", VA = "0x1137EEF0")]
    public List<GuildRaidReward> GetGuildRaidRewards(string id) => (List<GuildRaidReward>) null;

    [Token(Token = "0x600652F")]
    [Address(RVA = "0x137EC50", Offset = "0x137DA50", VA = "0x1137EC50")]
    public GuildRaidRewardParam GetGuildRaidRewardRound(string id, int round)
    {
      return (GuildRaidRewardParam) null;
    }

    [Token(Token = "0x6006530")]
    [Address(RVA = "0x137E250", Offset = "0x137D050", VA = "0x1137E250")]
    public GuildRaidRewardDmgRankingParam GetGuildRaidRewardDmgRanking(string id)
    {
      return (GuildRaidRewardDmgRankingParam) null;
    }

    [Token(Token = "0x6006531")]
    [Address(RVA = "0x137DDC0", Offset = "0x137CBC0", VA = "0x1137DDC0")]
    public GuildRaidRewardParam GetGuildRaidRewardDmgRankingReward(
      string id,
      int ranking,
      int round)
    {
      return (GuildRaidRewardParam) null;
    }

    [Token(Token = "0x6006532")]
    [Address(RVA = "0x137E3A0", Offset = "0x137D1A0", VA = "0x1137E3A0")]
    public GuildRaidRewardParam GetGuildRaidRewardDmgRatio(string id, int ratio, int round)
    {
      return (GuildRaidRewardParam) null;
    }

    [Token(Token = "0x6006533")]
    [Address(RVA = "0x137D4E0", Offset = "0x137C2E0", VA = "0x1137D4E0")]
    public GuildRaidBossParam GetGuildRaidBossParam(int boss_id) => (GuildRaidBossParam) null;

    [Token(Token = "0x6006534")]
    [Address(RVA = "0x137D190", Offset = "0x137BF90", VA = "0x1137D190")]
    public List<GuildRaidBossParam> GetGuildRaidBossByPeriod(int period_id)
    {
      return (List<GuildRaidBossParam>) null;
    }

    [Token(Token = "0x6006535")]
    [Address(RVA = "0x137D290", Offset = "0x137C090", VA = "0x1137D290")]
    public int GetGuildRaidBossCountByPeriod(int period_id) => new int();

    [Token(Token = "0x6006536")]
    [Address(RVA = "0x137D350", Offset = "0x137C150", VA = "0x1137D350")]
    public int GetGuildRaidBossIndex(int periodId, int bossId) => new int();

    [Token(Token = "0x6006537")]
    [Address(RVA = "0x1384AE0", Offset = "0x13838E0", VA = "0x11384AE0")]
    public bool IsGuildRaidBossHpWarning(int boss_id, int hp) => new bool();

    [Token(Token = "0x6006538")]
    [Address(RVA = "0x137D420", Offset = "0x137C220", VA = "0x1137D420")]
    public GuildRaidBossParam GetGuildRaidBossParam(int periodid, int area_no)
    {
      return (GuildRaidBossParam) null;
    }

    [Token(Token = "0x6006539")]
    [Address(RVA = "0x1380AF0", Offset = "0x137F8F0", VA = "0x11380AF0")]
    public List<GuildRaidBossParam> GetRaidBossParamAll(int period_id)
    {
      return (List<GuildRaidBossParam>) null;
    }

    [Token(Token = "0x600653A")]
    [Address(RVA = "0x1380BF0", Offset = "0x137F9F0", VA = "0x11380BF0")]
    public List<GuildRaidReward> GetRaidRewardParamList(string reward_id)
    {
      return (List<GuildRaidReward>) null;
    }

    [Token(Token = "0x600653B")]
    [Address(RVA = "0x137D5A0", Offset = "0x137C3A0", VA = "0x1137D5A0")]
    public int GetGuildRaidBossScore(int scoreId, int round, int damage) => new int();

    [Token(Token = "0x600653C")]
    [Address(RVA = "0x137E8E0", Offset = "0x137D6E0", VA = "0x1137E8E0")]
    public GuildRaidRewardRankingParam GetGuildRaidRewardRankingParamId(string id)
    {
      return (GuildRaidRewardRankingParam) null;
    }

    [Token(Token = "0x600653D")]
    [Address(RVA = "0x137EA20", Offset = "0x137D820", VA = "0x1137EA20")]
    public string GetGuildRaidRewardRankingParam(string id, int rank) => (string) null;

    [Token(Token = "0x600653E")]
    [Address(RVA = "0x13848B0", Offset = "0x13836B0", VA = "0x113848B0")]
    public bool IsGuildRaidBattleSchedule(int id) => new bool();

    [Token(Token = "0x600653F")]
    [Address(RVA = "0x137D740", Offset = "0x137C540", VA = "0x1137D740")]
    public int GetGuildRaidCurrentOrderId(int bossId) => new int();

    [Token(Token = "0x6006540")]
    [Address(RVA = "0x137D800", Offset = "0x137C600", VA = "0x1137D800")]
    public int GetGuildRaidLastBossOrderId(int periodId) => new int();

    [Token(Token = "0x6006541")]
    [Address(RVA = "0x1378B40", Offset = "0x1377940", VA = "0x11378B40")]
    public RankingQuestParam FindAvailableRankingQuest(string iname) => (RankingQuestParam) null;

    [Token(Token = "0x6006542")]
    [Address(RVA = "0x137FA00", Offset = "0x137E800", VA = "0x1137FA00")]
    public List<string> GetMultiAreaQuestList() => (List<string>) null;

    [Token(Token = "0x6006543")]
    [Address(RVA = "0x1384EF0", Offset = "0x1383CF0", VA = "0x11384EF0")]
    public bool IsValidAreaQuest() => new bool();

    [Token(Token = "0x6006544")]
    [Address(RVA = "0x1384F90", Offset = "0x1383D90", VA = "0x11384F90")]
    public bool IsValidMultiAreaQuest() => new bool();

    [Token(Token = "0x6006545")]
    [Address(RVA = "0x1381B20", Offset = "0x1380920", VA = "0x11381B20")]
    public VersusFirstWinBonusParam GetVSFirstWinBonus(long servertime = -1)
    {
      return (VersusFirstWinBonusParam) null;
    }

    [Token(Token = "0x6006546")]
    [Address(RVA = "0x1381FA0", Offset = "0x1380DA0", VA = "0x11381FA0")]
    public int GetVSStreakSchedule(STREAK_JUDGE judge, DateTime time) => new int();

    [Token(Token = "0x6006547")]
    [Address(RVA = "0x13820D0", Offset = "0x1380ED0", VA = "0x113820D0")]
    public VersusStreakWinBonusParam GetVSStreakWinBonus(
      int streakcnt,
      STREAK_JUDGE judge,
      long servertime = -1)
    {
      return (VersusStreakWinBonusParam) null;
    }

    [Token(Token = "0x6006548")]
    [Address(RVA = "0x1381E20", Offset = "0x1380C20", VA = "0x11381E20")]
    public VS_MODE GetVSMode(long servertime = -1) => new VS_MODE();

    [Token(Token = "0x6006549")]
    [Address(RVA = "0x1381CA0", Offset = "0x1380AA0", VA = "0x11381CA0")]
    public int GetVSGetCoinRate(long servertime = -1) => new int();

    [Token(Token = "0x600654A")]
    [Address(RVA = "0x1388A70", Offset = "0x1387870", VA = "0x11388A70")]
    public STREAK_JUDGE SearchVersusJudgeType(int id, long servertime = -1) => new STREAK_JUDGE();

    [Token(Token = "0x600654B")]
    [Address(RVA = "0x1371E60", Offset = "0x1370C60", VA = "0x11371E60")]
    public bool Deserialize(Json_VersusCpu json) => new bool();

    [Token(Token = "0x600654C")]
    [Address(RVA = "0x1380E20", Offset = "0x137FC20", VA = "0x11380E20")]
    public eStoryPart GetReleaseStoryPart(string quest_id) => new eStoryPart();

    [Token(Token = "0x600654D")]
    [Address(RVA = "0x13816A0", Offset = "0x13804A0", VA = "0x113816A0")]
    public Dictionary<eStoryPart, bool> GetUnlockStoryPartStates()
    {
      return (Dictionary<eStoryPart, bool>) null;
    }

    [Token(Token = "0x600654E")]
    [Address(RVA = "0x1370120", Offset = "0x136EF20", VA = "0x11370120")]
    public bool CheckReleaseStoryPart() => new bool();

    [Token(Token = "0x600654F")]
    [Address(RVA = "0x1380280", Offset = "0x137F080", VA = "0x11380280")]
    public eStoryPart GetNeedReleaseAnimationStoryPart() => new eStoryPart();

    [Token(Token = "0x6006550")]
    [Address(RVA = "0x1381580", Offset = "0x1380380", VA = "0x11381580")]
    public string GetUnlockConditionsStoryPartMessage(eStoryPart story_part) => (string) null;

    [Token(Token = "0x6006551")]
    [Address(RVA = "0x137B480", Offset = "0x137A280", VA = "0x1137B480")]
    public List<SectionParam> GetAllStorySelctionParams(bool isAvailableOnly = false)
    {
      return (List<SectionParam>) null;
    }

    [Token(Token = "0x6006552")]
    [Address(RVA = "0x137B2D0", Offset = "0x137A0D0", VA = "0x1137B2D0")]
    public List<QuestParam> GetAllQuestParamsInChallengeableStorySelctions()
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x6006553")]
    [Address(RVA = "0x137B820", Offset = "0x137A620", VA = "0x1137B820")]
    public List<QuestParam> GetAllTowerQuestParam() => (List<QuestParam>) null;

    [Token(Token = "0x6006554")]
    [Address(RVA = "0x137AE40", Offset = "0x1379C40", VA = "0x1137AE40")]
    public List<QuestParam> GetAllMultiTowerQuestParam() => (List<QuestParam>) null;

    [Token(Token = "0x6006555")]
    [Address(RVA = "0x137C470", Offset = "0x137B270", VA = "0x1137C470")]
    public DuelSeasonParam GetCurrentDuelSeason() => (DuelSeasonParam) null;

    [Token(Token = "0x6006556")]
    [Address(RVA = "0x1384610", Offset = "0x1383410", VA = "0x11384610")]
    public bool IsDuelWinBonusReward(string iname, int chain_win) => new bool();

    [Token(Token = "0x6006557")]
    [Address(RVA = "0x137C050", Offset = "0x137AE50", VA = "0x1137C050")]
    public List<UnitData> GetBattleEntryUnits(QuestParam questParam) => (List<UnitData>) null;

    [Token(Token = "0x6006558")]
    [Address(RVA = "0x137BB70", Offset = "0x137A970", VA = "0x1137BB70")]
    private List<UnitData> GetAudienceModeUnits(QuestParam questParam) => (List<UnitData>) null;

    [Token(Token = "0x6006559")]
    [Address(RVA = "0x137C100", Offset = "0x137AF00", VA = "0x1137C100")]
    private List<UnitData> GetCPUBattleUnits(QuestParam questParam) => (List<UnitData>) null;

    [Token(Token = "0x600655A")]
    [Address(RVA = "0x137FAF0", Offset = "0x137E8F0", VA = "0x1137FAF0")]
    private List<UnitData> GetMultiPlayUnits(QuestParam questParam) => (List<UnitData>) null;

    [Token(Token = "0x600655B")]
    [Address(RVA = "0x1378000", Offset = "0x1376E00", VA = "0x11378000")]
    public void DestroyAudienceManager()
    {
    }

    [Token(Token = "0x600655C")]
    [Address(RVA = "0x1388480", Offset = "0x1387280", VA = "0x11388480")]
    public void ResetQuestPlayTime()
    {
    }

    [Token(Token = "0x600655D")]
    [Address(RVA = "0x138A450", Offset = "0x1389250", VA = "0x1138A450")]
    public void StartQuestPlayTime()
    {
    }

    [Token(Token = "0x600655E")]
    [Address(RVA = "0x13784E0", Offset = "0x13772E0", VA = "0x113784E0")]
    public void EndQuestPlayTime()
    {
    }

    [Token(Token = "0x600655F")]
    [Address(RVA = "0x1380810", Offset = "0x137F610", VA = "0x11380810")]
    public float GetQuestPlayTime() => new float();

    [Token(Token = "0x6006560")]
    [Address(RVA = "0x13843A0", Offset = "0x13831A0", VA = "0x113843A0")]
    public bool IsCombatPowerQuestHold() => new bool();

    [Token(Token = "0x6006561")]
    [Address(RVA = "0x13715E0", Offset = "0x13703E0", VA = "0x113715E0")]
    public void DeserializeDifferenceUpdate(Json_DifferenceUpdate _data)
    {
    }

    [Token(Token = "0x6006562")]
    [Address(RVA = "0x1389860", Offset = "0x1388660", VA = "0x11389860")]
    public void SetConceptCardGetUnit(RewardData _data)
    {
    }

    [Token(Token = "0x6006563")]
    [Address(RVA = "0x1370BA0", Offset = "0x136F9A0", VA = "0x11370BA0")]
    public Json_DifferenceUpdate CreateJsonDifferenceUpdate(
      Json_Unit[] _units = null,
      Json_Item[] _items = null,
      Json_Artifact[] _artifacts = null,
      JSON_ConceptCard[] _cards = null,
      Json_RuneData[] _runes = null,
      int _rune_storage_used = 0)
    {
      return (Json_DifferenceUpdate) null;
    }

    [Token(Token = "0x6006564")]
    [Address(RVA = "0x1385030", Offset = "0x1383E30", VA = "0x11385030")]
    public static bool IsValid() => new bool();

    [Token(Token = "0x6006565")]
    [Address(RVA = "0x1371460", Offset = "0x1370260", VA = "0x11371460")]
    public void DeserializeDifferenceUpdatePlayer(Json_DifferenceUpdatePlayer _data)
    {
    }

    [Token(Token = "0x6006566")]
    [Address(RVA = "0x1370AF0", Offset = "0x136F8F0", VA = "0x11370AF0")]
    public Json_DifferenceUpdate CreateJsonDifferenceUpdatePlayer(
      Json_PlayerData _player,
      Json_Unit[] _units = null,
      Json_Item[] _items = null,
      Json_Artifact[] _artifacts = null,
      JSON_ConceptCard[] _cards = null,
      Json_RuneData[] _runes = null,
      int _rune_storage_used = 0)
    {
      return (Json_DifferenceUpdate) null;
    }

    [Token(Token = "0x6006567")]
    [Address(RVA = "0x138C640", Offset = "0x138B440", VA = "0x1138C640")]
    public GameManager()
    {
    }

    [Token(Token = "0x6006568")]
    [Address(RVA = "0x138C610", Offset = "0x138B410", VA = "0x1138C610")]
    static GameManager()
    {
    }

    [Token(Token = "0x20018D2")]
    public enum ELoadMasterDataResult
    {
      [Token(Token = "0x4005A65")] NOT_YET_MATE,
      [Token(Token = "0x4005A66")] SUCCESS,
      [Token(Token = "0x4005A67")] ERROR_MASTER_PARAM_DECRYPT,
      [Token(Token = "0x4005A68")] ERROR_QUEST_PARAM_DECRYPT,
      [Token(Token = "0x4005A69")] ERROR_QUEST_DROP_PARAM_DECRYPT,
      [Token(Token = "0x4005A6A")] ERROR_MASTER_PARAM_DESERIALIZE,
      [Token(Token = "0x4005A6B")] ERROR_QUEST_PARAM_DESERIALIZE,
      [Token(Token = "0x4005A6C")] ERROR_OTHER,
    }

    [Token(Token = "0x20018D3")]
    public struct LoadMasterDataResult
    {
      [Token(Token = "0x4005A6D")]
      [FieldOffset(Offset = "0x0")]
      public Exception Exception;
      [Token(Token = "0x4005A6E")]
      [FieldOffset(Offset = "0x4")]
      public GameManager.ELoadMasterDataResult Result;
      [Token(Token = "0x4005A6F")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_SendLogMessage.SendLogGenerator LogData;
    }

    [Token(Token = "0x20018D4")]
    public class MasterDataLoadException : Exception
    {
      [Token(Token = "0x4005A70")]
      [FieldOffset(Offset = "0x48")]
      public GameManager.ELoadMasterDataResult Type;
      [Token(Token = "0x4005A71")]
      [FieldOffset(Offset = "0x4C")]
      public Exception ActualException;

      [Token(Token = "0x17000A38")]
      public override string Message
      {
        [Token(Token = "0x600656B"), Address(RVA = "0x317190", Offset = "0x315F90", VA = "0x10317190", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000A39")]
      public override string StackTrace
      {
        [Token(Token = "0x600656C"), Address(RVA = "0x317450", Offset = "0x316250", VA = "0x10317450", Slot = "9")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600656D")]
      [Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0", Slot = "7")]
      public override Exception GetBaseException() => (Exception) null;

      [Token(Token = "0x600656E")]
      [Address(RVA = "0x316B60", Offset = "0x315960", VA = "0x10316B60")]
      public MasterDataLoadException()
      {
      }
    }

    [Token(Token = "0x20018D5")]
    public class MasterParamDecryptException : GameManager.MasterDataLoadException
    {
      [Token(Token = "0x600656F")]
      [Address(RVA = "0x316B60", Offset = "0x315960", VA = "0x10316B60")]
      public MasterParamDecryptException()
      {
      }
    }

    [Token(Token = "0x20018D6")]
    public class QuestParamDecryptException : GameManager.MasterDataLoadException
    {
      [Token(Token = "0x6006570")]
      [Address(RVA = "0x316B60", Offset = "0x315960", VA = "0x10316B60")]
      public QuestParamDecryptException()
      {
      }
    }

    [Token(Token = "0x20018D7")]
    public class QuestDropParamDecryptException : GameManager.MasterDataLoadException
    {
      [Token(Token = "0x6006571")]
      [Address(RVA = "0x316B60", Offset = "0x315960", VA = "0x10316B60")]
      public QuestDropParamDecryptException()
      {
      }
    }

    [Token(Token = "0x20018D8")]
    public class MasterParamDeserializeException : GameManager.MasterDataLoadException
    {
      [Token(Token = "0x6006572")]
      [Address(RVA = "0x316B60", Offset = "0x315960", VA = "0x10316B60")]
      public MasterParamDeserializeException()
      {
      }
    }

    [Token(Token = "0x20018D9")]
    public class QuestParamDeserializeException : GameManager.MasterDataLoadException
    {
      [Token(Token = "0x6006573")]
      [Address(RVA = "0x316B60", Offset = "0x315960", VA = "0x10316B60")]
      public QuestParamDeserializeException()
      {
      }
    }

    [Token(Token = "0x20018DA")]
    public class MasterDataGenericException : GameManager.MasterDataLoadException
    {
      [Token(Token = "0x6006574")]
      [Address(RVA = "0x316B60", Offset = "0x315960", VA = "0x10316B60")]
      public MasterDataGenericException()
      {
      }
    }

    [Token(Token = "0x20018DB")]
    public class MasterDataInBinary
    {
      [Token(Token = "0x4005A72")]
      [FieldOffset(Offset = "0x8")]
      public byte[] MasterBytes;
      [Token(Token = "0x4005A73")]
      [FieldOffset(Offset = "0xC")]
      public byte[] QuestBytes;
      [Token(Token = "0x4005A74")]
      [FieldOffset(Offset = "0x10")]
      public GameManager.LoadMasterDataResult LoadResult;

      [Token(Token = "0x6006575")]
      [Address(RVA = "0x316BB0", Offset = "0x3159B0", VA = "0x10316BB0")]
      public GameManager.MasterDataInBinary Load(bool serialized, bool encrypted)
      {
        return (GameManager.MasterDataInBinary) null;
      }

      [Token(Token = "0x6006576")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MasterDataInBinary()
      {
      }
    }

    [Token(Token = "0x20018DC")]
    [Flags]
    public enum BadgeTypes
    {
      [Token(Token = "0x4005A76")] Unit = 1,
      [Token(Token = "0x4005A77")] UnitUnlock = 2,
      [Token(Token = "0x4005A78")] GoldGacha = 4,
      [Token(Token = "0x4005A79")] RareGacha = 8,
      [Token(Token = "0x4005A7A")] DailyMission = 16, // 0x00000010
      [Token(Token = "0x4005A7B")] Arena = 32, // 0x00000020
      [Token(Token = "0x4005A7C")] Multiplay = 64, // 0x00000040
      [Token(Token = "0x4005A7D")] Friend = 128, // 0x00000080
      [Token(Token = "0x4005A7E")] GiftBox = 256, // 0x00000100
      [Token(Token = "0x4005A7F")] ItemEquipment = 512, // 0x00000200
      [Token(Token = "0x4005A80")] MasteryReward = 1024, // 0x00000400
      [Token(Token = "0x4005A81")] All = -1, // 0xFFFFFFFF
    }

    [Token(Token = "0x20018DD")]
    public delegate void DayChangeEvent();

    [Token(Token = "0x20018DE")]
    public delegate void StaminaChangeEvent();

    [Token(Token = "0x20018DF")]
    public delegate void RankUpCountChangeEvent(int count);

    [Token(Token = "0x20018E0")]
    public delegate void PlayerLvChangeEvent();

    [Token(Token = "0x20018E1")]
    public delegate void PlayerCurrencyChangeEvent();

    [Token(Token = "0x20018E2")]
    public delegate void BuyCoinEvent();

    [Token(Token = "0x20018E3")]
    public delegate bool SceneChangeEvent();

    [Token(Token = "0x20018E4")]
    private class TextureRequest
    {
      [Token(Token = "0x4005A82")]
      [FieldOffset(Offset = "0x8")]
      public RawImage Target;
      [Token(Token = "0x4005A83")]
      [FieldOffset(Offset = "0xC")]
      public string Path;
      [Token(Token = "0x4005A84")]
      [FieldOffset(Offset = "0x10")]
      public LoadRequest Request;

      [Token(Token = "0x6006593")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TextureRequest()
      {
      }
    }

    [Token(Token = "0x20018E5")]
    private class VersusRange
    {
      [Token(Token = "0x4005A85")]
      [FieldOffset(Offset = "0x8")]
      public int min;
      [Token(Token = "0x4005A86")]
      [FieldOffset(Offset = "0xC")]
      public int max;

      [Token(Token = "0x6006594")]
      [Address(RVA = "0x28D570", Offset = "0x28C370", VA = "0x1028D570")]
      public VersusRange(int _min, int _max)
      {
      }
    }

    [Token(Token = "0x20018E6")]
    private struct QuestTime
    {
      [Token(Token = "0x4005A87")]
      [FieldOffset(Offset = "0x0")]
      public float start;
      [Token(Token = "0x4005A88")]
      [FieldOffset(Offset = "0x4")]
      public float end;
    }
  }
}
