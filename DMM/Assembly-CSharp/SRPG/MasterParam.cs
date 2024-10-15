// Decompiled with JetBrains decompiler
// Type: SRPG.MasterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019D1")]
  public class MasterParam
  {
    [Token(Token = "0x4005EE7")]
    [FieldOffset(Offset = "0x8")]
    private List<BuyCoinShopParam> mBuyCoinShopParam;
    [Token(Token = "0x4005EE8")]
    [FieldOffset(Offset = "0xC")]
    private ParamDictionary<string, BuyCoinProductParam> mBuyCoinProductDict;
    [Token(Token = "0x4005EE9")]
    [FieldOffset(Offset = "0x10")]
    private List<BuyCoinRewardParam> mBuyCoinRewardParam;
    [Token(Token = "0x4005EEA")]
    [FieldOffset(Offset = "0x14")]
    private ParamDictionary<string, BuyCoinProductConvertParam> mBuyCoinProductConvert_auID_to_commonID_Dict;
    [Token(Token = "0x4005EEB")]
    [FieldOffset(Offset = "0x18")]
    private ParamDictionary<string, BuyCoinProductConvertParam> mBuyCoinProductConvert_commonID_to_auID_Dict;
    [Token(Token = "0x4005EEC")]
    [FieldOffset(Offset = "0x1C")]
    private BuyCoinHotDealParamDatas mBuyCoinHotDealParam;
    [Token(Token = "0x4005EED")]
    [FieldOffset(Offset = "0x20")]
    private List<BuyCoinStepUpParam> mBuyCoinStepUpParam;
    [Token(Token = "0x4005EEE")]
    [FieldOffset(Offset = "0x24")]
    private PremiumParam[] mPremium;
    [Token(Token = "0x4005EEF")]
    [FieldOffset(Offset = "0x28")]
    private List<ConceptCardParam> mConceptCard;
    [Token(Token = "0x4005EF0")]
    [FieldOffset(Offset = "0x2C")]
    private Dictionary<string, ConceptCardParam> mConceptCardDict;
    [Token(Token = "0x4005EF1")]
    [FieldOffset(Offset = "0x30")]
    private OInt[,] mConceptCardLvTbl;
    [Token(Token = "0x4005EF2")]
    [FieldOffset(Offset = "0x34")]
    private OInt[] mConceptCardSellCoinRate;
    [Token(Token = "0x4005EF3")]
    [FieldOffset(Offset = "0x38")]
    private List<ConceptCardLsBuffCoefParam> mConceptCardLsBuffCoefParam;
    [Token(Token = "0x4005EF4")]
    [FieldOffset(Offset = "0x3C")]
    private Dictionary<string, List<ConceptCardParam>> mConceptCardGroup;
    [Token(Token = "0x4005EF5")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<string, ConceptCardConditionsParam> mConceptCardConditions;
    [Token(Token = "0x4005EF6")]
    [FieldOffset(Offset = "0x44")]
    private Dictionary<string, ConceptCardTrustRewardParam> mConceptCardTrustReward;
    [Token(Token = "0x4005EF7")]
    [FieldOffset(Offset = "0x48")]
    private FilterConceptCardParam[] mFilterConceptCardParams;
    [Token(Token = "0x4005EF8")]
    [FieldOffset(Offset = "0x4C")]
    private FixConceptCardParam mFixConceptCardParam;
    [Token(Token = "0x4005EF9")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<string, ConceptCardExtraRarityParam> mConceptCardExtraRarityDict;
    [Token(Token = "0x4005EFA")]
    [FieldOffset(Offset = "0x54")]
    private List<ElementPieceParam> mElementPieceParams;
    [Token(Token = "0x4005EFB")]
    [FieldOffset(Offset = "0x58")]
    private List<ElementBuffParam> mElementBuffParams;
    [Token(Token = "0x4005EFC")]
    [FieldOffset(Offset = "0x5C")]
    private List<ExpansionPurchaseParam> mExpansionPurchaseParams;
    [Token(Token = "0x4005EFD")]
    [FieldOffset(Offset = "0x60")]
    private List<ExpansionPurchaseQuestParam> mExpansionPurchaseQuestParams;
    [Token(Token = "0x4005EFE")]
    [FieldOffset(Offset = "0x64")]
    private List<LeagueMatchBuffParam> mLeagueMatchBuffParams;
    [Token(Token = "0x4005EFF")]
    [FieldOffset(Offset = "0x68")]
    private List<LeagueMatchBuffResetParam> mLeagueMatchBuffResetParams;
    [Token(Token = "0x4005F00")]
    [FieldOffset(Offset = "0x6C")]
    private List<LeagueMatchRankParam> mLeagueMatchRankParams;
    [Token(Token = "0x4005F01")]
    [FieldOffset(Offset = "0x70")]
    private List<LeagueMatchRewardParam> mLeagueMatchRewardParams;
    [Token(Token = "0x4005F02")]
    [FieldOffset(Offset = "0x74")]
    private List<LeagueMatchSeasonParam> mLeagueMatchSeasonParams;
    [Token(Token = "0x4005F03")]
    [FieldOffset(Offset = "0x78")]
    private List<LeagueMatchSettingParam> mLeagueMatchSettingParams;
    [Token(Token = "0x4005F04")]
    [FieldOffset(Offset = "0x7C")]
    private FixParam mFixParam;
    [Token(Token = "0x4005F05")]
    [FieldOffset(Offset = "0x80")]
    private FixArtifactParam mFixArtifactParam;
    [Token(Token = "0x4005F06")]
    [FieldOffset(Offset = "0x84")]
    private List<UnitParam> mUnitParam;
    [Token(Token = "0x4005F07")]
    [FieldOffset(Offset = "0x88")]
    private List<UnitJobOverwriteParam> mUnitJobOverwriteParam;
    [Token(Token = "0x4005F08")]
    [FieldOffset(Offset = "0x8C")]
    private List<AbilityParam> mAbilityParam;
    [Token(Token = "0x4005F09")]
    [FieldOffset(Offset = "0x90")]
    private List<ItemParam> mItemParam;
    [Token(Token = "0x4005F0A")]
    [FieldOffset(Offset = "0x94")]
    private List<ArtifactParam> mArtifactParam;
    [Token(Token = "0x4005F0B")]
    [FieldOffset(Offset = "0x98")]
    private List<WeaponParam> mWeaponParam;
    [Token(Token = "0x4005F0C")]
    [FieldOffset(Offset = "0x9C")]
    private List<RecipeParam> mRecipeParam;
    [Token(Token = "0x4005F0D")]
    [FieldOffset(Offset = "0xA0")]
    private List<JobParam> mJobParam;
    [Token(Token = "0x4005F0E")]
    [FieldOffset(Offset = "0xA4")]
    private Dictionary<string, JobParam> mJobParamDict;
    [Token(Token = "0x4005F0F")]
    [FieldOffset(Offset = "0xA8")]
    private List<QuestClearUnlockUnitDataParam> mUnlockUnitDataParam;
    [Token(Token = "0x4005F10")]
    [FieldOffset(Offset = "0xAC")]
    private List<CollaboSkillParam> mCollaboSkillParam;
    [Token(Token = "0x4005F11")]
    [FieldOffset(Offset = "0xB0")]
    private List<TrickParam> mTrickParam;
    [Token(Token = "0x4005F12")]
    [FieldOffset(Offset = "0xB4")]
    private List<BreakObjParam> mBreakObjParam;
    [Token(Token = "0x4005F13")]
    [FieldOffset(Offset = "0xB8")]
    private List<WeatherParam> mWeatherParam;
    [Token(Token = "0x4005F14")]
    [FieldOffset(Offset = "0xBC")]
    private List<WeatherReleaseParam> mWeatherReleaseParam;
    [Token(Token = "0x4005F15")]
    [FieldOffset(Offset = "0xC0")]
    private Dictionary<string, UnitUnlockTimeParam> mUnitUnlockTimeParam;
    [Token(Token = "0x4005F16")]
    [FieldOffset(Offset = "0xC4")]
    private List<TobiraParam> mTobiraParam;
    [Token(Token = "0x4005F17")]
    [FieldOffset(Offset = "0xC8")]
    private Dictionary<TobiraParam.Category, TobiraCategoriesParam> mTobiraCategoriesParam;
    [Token(Token = "0x4005F18")]
    [FieldOffset(Offset = "0xCC")]
    private List<TobiraCondsParam> mTobiraCondParam;
    [Token(Token = "0x4005F19")]
    [FieldOffset(Offset = "0xD0")]
    private Dictionary<string, TobiraCondsUnitParam> mTobiraCondUnitParam;
    [Token(Token = "0x4005F1A")]
    [FieldOffset(Offset = "0xD4")]
    private List<TobiraRecipeParam> mTobiraRecipeParam;
    [Token(Token = "0x4005F1B")]
    [FieldOffset(Offset = "0xD8")]
    private Dictionary<string, UnitGroupParam> mUnitGroup;
    [Token(Token = "0x4005F1C")]
    [FieldOffset(Offset = "0xDC")]
    private Dictionary<string, JobGroupParam> mJobGroup;
    [Token(Token = "0x4005F1D")]
    [FieldOffset(Offset = "0xE0")]
    private List<JobSetParam> mJobSetParam;
    [Token(Token = "0x4005F1E")]
    [FieldOffset(Offset = "0xE4")]
    private List<GrowParam> mGrowParam;
    [Token(Token = "0x4005F1F")]
    [FieldOffset(Offset = "0xE8")]
    private List<AIParam> mAIParam;
    [Token(Token = "0x4005F20")]
    [FieldOffset(Offset = "0xEC")]
    private List<GeoParam> mGeoParam;
    [Token(Token = "0x4005F21")]
    [FieldOffset(Offset = "0xF0")]
    private List<RarityParam> mRarityParam;
    [Token(Token = "0x4005F22")]
    [FieldOffset(Offset = "0xF4")]
    private List<ShopParam> mShopParam;
    [Token(Token = "0x4005F23")]
    [FieldOffset(Offset = "0xF8")]
    private PlayerParam[] mPlayerParamTbl;
    [Token(Token = "0x4005F24")]
    [FieldOffset(Offset = "0xFC")]
    private OInt[] mPlayerExpTbl;
    [Token(Token = "0x4005F25")]
    [FieldOffset(Offset = "0x100")]
    private OInt[] mUnitExpTbl;
    [Token(Token = "0x4005F26")]
    [FieldOffset(Offset = "0x104")]
    private OInt[] mArtifactExpTbl;
    [Token(Token = "0x4005F27")]
    [FieldOffset(Offset = "0x108")]
    private OInt[] mAbilityExpTbl;
    [Token(Token = "0x4005F28")]
    [FieldOffset(Offset = "0x10C")]
    private OInt[] mAwakePieceTbl;
    [Token(Token = "0x4005F29")]
    [FieldOffset(Offset = "0x110")]
    private LocalNotificationParam mLocalNotificationParam;
    [Token(Token = "0x4005F2A")]
    [FieldOffset(Offset = "0x114")]
    private TrophyCategoryParam[] mTrophyCategory;
    [Token(Token = "0x4005F2B")]
    [FieldOffset(Offset = "0x118")]
    private TrophyParam[] mTrophy;
    [Token(Token = "0x4005F2C")]
    [FieldOffset(Offset = "0x11C")]
    public Dictionary<string, TrophyParam> mTrophyInameDict;
    [Token(Token = "0x4005F2D")]
    [FieldOffset(Offset = "0x120")]
    private TrophyObjective[][] mTrophyDict;
    [Token(Token = "0x4005F2E")]
    [FieldOffset(Offset = "0x124")]
    private ChallengeCategoryParam[] mChallengeCategory;
    [Token(Token = "0x4005F2F")]
    [FieldOffset(Offset = "0x128")]
    private TrophyParam[] mChallenge;
    [Token(Token = "0x4005F30")]
    [FieldOffset(Offset = "0x12C")]
    private TrophyCategoryParam[] mGuildTrophyCategory;
    [Token(Token = "0x4005F31")]
    [FieldOffset(Offset = "0x130")]
    private GuildTrophyParam[] mGuildTrophy;
    [Token(Token = "0x4005F32")]
    [FieldOffset(Offset = "0x134")]
    public Dictionary<string, GuildTrophyParam> mGuildTrophyInameDict;
    [Token(Token = "0x4005F33")]
    [FieldOffset(Offset = "0x138")]
    private UnlockParam[] mUnlock;
    [Token(Token = "0x4005F34")]
    [FieldOffset(Offset = "0x13C")]
    private VipParam[] mVip;
    [Token(Token = "0x4005F35")]
    [FieldOffset(Offset = "0x140")]
    private JSON_StreamingMovie[] mStreamingMovies;
    [Token(Token = "0x4005F36")]
    [FieldOffset(Offset = "0x144")]
    private BannerParam[] mBanner;
    [Token(Token = "0x4005F37")]
    [FieldOffset(Offset = "0x148")]
    private List<VersusMatchingParam> mVersusMatching;
    [Token(Token = "0x4005F38")]
    [FieldOffset(Offset = "0x14C")]
    private List<VersusMatchCondParam> mVersusMatchCond;
    [Token(Token = "0x4005F39")]
    [FieldOffset(Offset = "0x150")]
    private Dictionary<string, TowerScoreParam[]> mTowerScores;
    [Token(Token = "0x4005F3A")]
    [FieldOffset(Offset = "0x154")]
    private OInt[] mTowerRankTbl;
    [Token(Token = "0x4005F3B")]
    [FieldOffset(Offset = "0x158")]
    public OInt[] mMultiLimitUnitLv;
    [Token(Token = "0x4005F3C")]
    [FieldOffset(Offset = "0x15C")]
    private Dictionary<string, UnitParam> mUnitDictionary;
    [Token(Token = "0x4005F3D")]
    [FieldOffset(Offset = "0x160")]
    private Dictionary<string, Dictionary<string, UnitJobOverwriteParam>> mUnitJobOverwriteDictionary;
    [Token(Token = "0x4005F3E")]
    [FieldOffset(Offset = "0x164")]
    private Dictionary<string, AbilityParam> mAbilityDictionary;
    [Token(Token = "0x4005F3F")]
    [FieldOffset(Offset = "0x168")]
    private Dictionary<string, ItemParam> mItemDictionary;
    [Token(Token = "0x4005F40")]
    [FieldOffset(Offset = "0x16C")]
    private Dictionary<string, ArtifactParam> mArtifactDictionary;
    [Token(Token = "0x4005F41")]
    [FieldOffset(Offset = "0x170")]
    private Dictionary<string, CrystalParam> mCrystalDictionary;
    [Token(Token = "0x4005F42")]
    [FieldOffset(Offset = "0x174")]
    private Dictionary<string, BuffEffectParam> mBuffEffectDictionary;
    [Token(Token = "0x4005F43")]
    [FieldOffset(Offset = "0x178")]
    private Dictionary<string, CondEffectParam> mCondEffectDictionary;
    [Token(Token = "0x4005F44")]
    [FieldOffset(Offset = "0x17C")]
    private Dictionary<string, RecipeParam> mRecipeDictionary;
    [Token(Token = "0x4005F45")]
    [FieldOffset(Offset = "0x180")]
    private Dictionary<string, JobSetParam> mJobsetDictionary;
    [Token(Token = "0x4005F46")]
    [FieldOffset(Offset = "0x184")]
    private Dictionary<string, List<JobSetParam>> mJobsetTargetDictionary;
    [Token(Token = "0x4005F47")]
    [FieldOffset(Offset = "0x188")]
    private List<AwardParam> mAwardParam;
    [Token(Token = "0x4005F48")]
    [FieldOffset(Offset = "0x18C")]
    private Dictionary<string, AwardParam> mAwardDictionary;
    [Token(Token = "0x4005F49")]
    [FieldOffset(Offset = "0x190")]
    private LoginInfoParam[] mLoginInfoParam;
    [Token(Token = "0x4005F4A")]
    [FieldOffset(Offset = "0x194")]
    private Dictionary<string, FriendPresentItemParam> mFriendPresentItemParam;
    [Token(Token = "0x4005F4B")]
    [FieldOffset(Offset = "0x198")]
    public StatusCoefficientParam mStatusCoefficient;
    [Token(Token = "0x4005F4C")]
    [FieldOffset(Offset = "0x19C")]
    private Dictionary<string, CustomTargetParam> mCustomTarget;
    [Token(Token = "0x4005F4D")]
    [FieldOffset(Offset = "0x1A0")]
    public SkillAbilityDeriveParam[] mSkillAbilityDeriveParam;
    [Token(Token = "0x4005F4E")]
    [FieldOffset(Offset = "0x1A4")]
    private List<SkillAbilityDeriveData> mSkillAbilityDerives;
    [Token(Token = "0x4005F4F")]
    [FieldOffset(Offset = "0x1A8")]
    private TipsParam[] mTipsParam;
    [Token(Token = "0x4005F50")]
    [FieldOffset(Offset = "0x1AC")]
    private List<GuildEmblemParam> mGuildEmblemParam;
    [Token(Token = "0x4005F51")]
    [FieldOffset(Offset = "0x1B0")]
    private Dictionary<string, GuildEmblemParam> mGuildEmblemDictionary;
    [Token(Token = "0x4005F52")]
    [FieldOffset(Offset = "0x1B4")]
    private List<GuildFacilityParam> mGuildFacilityParam;
    [Token(Token = "0x4005F53")]
    [FieldOffset(Offset = "0x1B8")]
    private Dictionary<string, GuildFacilityParam> mGuildFacilityDictionary;
    [Token(Token = "0x4005F54")]
    [FieldOffset(Offset = "0x1BC")]
    private GuildFacilityLvParam[] mGuildFacilityLvParam;
    [Token(Token = "0x4005F55")]
    [FieldOffset(Offset = "0x1C0")]
    private List<GuildTrainingUnit> mGuildTrainingUnit;
    [Token(Token = "0x4005F56")]
    [FieldOffset(Offset = "0x1C4")]
    private List<GuildTrainingEnergyLimit> mGuildTrainingEnergyLimit;
    [Token(Token = "0x4005F57")]
    [FieldOffset(Offset = "0x1C8")]
    private List<GuildTrainingEnergyItem> mGuildTrainingEnergyItems;
    [Token(Token = "0x4005F58")]
    [FieldOffset(Offset = "0x1CC")]
    private List<GuildTrainingCampaign> mGuildTrainingCampaign;
    [Token(Token = "0x4005F59")]
    [FieldOffset(Offset = "0x1D0")]
    private List<DynamicTransformUnitParam> mDynamicTransformUnitParam;
    [Token(Token = "0x4005F5A")]
    [FieldOffset(Offset = "0x1D4")]
    private ConvertUnitPieceExcludeParam[] mConvertUnitPieceExcludeParam;
    [Token(Token = "0x4005F5B")]
    [FieldOffset(Offset = "0x1D8")]
    private RecommendedArtifactList mRecommendedArtifactList;
    [Token(Token = "0x4005F5C")]
    [FieldOffset(Offset = "0x1DC")]
    private List<RaidPeriodParam> mRaidPeriodParam;
    [Token(Token = "0x4005F5D")]
    [FieldOffset(Offset = "0x1E0")]
    private List<RaidPeriodTimeParam> mRaidPeriodTimeParam;
    [Token(Token = "0x4005F5E")]
    [FieldOffset(Offset = "0x1E4")]
    private List<RaidAreaParam> mRaidAreaParam;
    [Token(Token = "0x4005F5F")]
    [FieldOffset(Offset = "0x1E8")]
    private List<RaidBossParam> mRaidBossParam;
    [Token(Token = "0x4005F60")]
    [FieldOffset(Offset = "0x1EC")]
    private List<RaidBattleRewardParam> mRaidBattleRewardParam;
    [Token(Token = "0x4005F61")]
    [FieldOffset(Offset = "0x1F0")]
    private List<RaidBeatRewardParam> mRaidBeatRewardParam;
    [Token(Token = "0x4005F62")]
    [FieldOffset(Offset = "0x1F4")]
    private List<RaidDamageRatioRewardParam> mRaidDamageRatioRewardParam;
    [Token(Token = "0x4005F63")]
    [FieldOffset(Offset = "0x1F8")]
    private List<RaidDamageAmountRewardParam> mRaidDamageAmountRewardParam;
    [Token(Token = "0x4005F64")]
    [FieldOffset(Offset = "0x1FC")]
    private List<RaidAreaClearRewardParam> mRaidAreaClearRewardParam;
    [Token(Token = "0x4005F65")]
    [FieldOffset(Offset = "0x200")]
    private List<RaidCompleteRewardParam> mRaidCompleteRewardParam;
    [Token(Token = "0x4005F66")]
    [FieldOffset(Offset = "0x204")]
    private List<RaidRewardParam> mRaidRewardParam;
    [Token(Token = "0x4005F67")]
    [FieldOffset(Offset = "0x208")]
    private List<ArenaRewardParam> mArenaRewardParams;
    [Token(Token = "0x4005F68")]
    [FieldOffset(Offset = "0x20C")]
    private List<SkillMotionParam> mSkillMotionParam;
    [Token(Token = "0x4005F69")]
    [FieldOffset(Offset = "0x210")]
    private List<DependStateSpcEffParam> mDependStateSpcEffParam;
    [Token(Token = "0x4005F6A")]
    [FieldOffset(Offset = "0x214")]
    private SRPG.HighlightParam[] mHighlightParam;
    [Token(Token = "0x4005F6B")]
    [FieldOffset(Offset = "0x218")]
    private List<GenesisParam> mGenesisParam;
    [Token(Token = "0x4005F6C")]
    [FieldOffset(Offset = "0x21C")]
    private CoinBuyUseBonusParam[] mCoinBuyUseBonusParam;
    [Token(Token = "0x4005F6D")]
    [FieldOffset(Offset = "0x220")]
    private CoinBuyUseBonusRewardSetParam[] mCoinBuyUseBonusRewardSetParam;
    [Token(Token = "0x4005F6E")]
    [FieldOffset(Offset = "0x224")]
    private CoinBuyUseBonusRewardParam[] mCoinBuyUseBonusRewardParam;
    [Token(Token = "0x4005F6F")]
    [FieldOffset(Offset = "0x228")]
    private Dictionary<string, UnitRentalNotificationParam> mUnitRentalNotificationParams;
    [Token(Token = "0x4005F70")]
    [FieldOffset(Offset = "0x22C")]
    private Dictionary<string, UnitRentalParam> mUnitRentalParams;
    [Token(Token = "0x4005F71")]
    [FieldOffset(Offset = "0x230")]
    private Dictionary<string, DrawCardRewardParam> mDrawCardRewardDict;
    [Token(Token = "0x4005F72")]
    [FieldOffset(Offset = "0x234")]
    private Dictionary<string, DrawCardParam> mDrawCardDict;
    [Token(Token = "0x4005F73")]
    [FieldOffset(Offset = "0x238")]
    private Dictionary<string, TrophyStarMissionRewardParam> mTrophyStarMissionRewardDict;
    [Token(Token = "0x4005F74")]
    [FieldOffset(Offset = "0x23C")]
    private Dictionary<string, TrophyStarMissionParam> mTrophyStarMissionDict;
    [Token(Token = "0x4005F75")]
    [FieldOffset(Offset = "0x240")]
    private List<UnitPieceShopParam> mUnitPieceShop;
    [Token(Token = "0x4005F76")]
    [FieldOffset(Offset = "0x244")]
    private List<UnitPieceShopGroupParam> mUnitPieceShopGroup;
    [Token(Token = "0x4005F77")]
    [FieldOffset(Offset = "0x248")]
    private TwitterMessageParam[] mTwitterMessageParams;
    [Token(Token = "0x4005F78")]
    [FieldOffset(Offset = "0x24C")]
    private FilterRuneParam[] mFilterRuneParams;
    [Token(Token = "0x4005F79")]
    [FieldOffset(Offset = "0x250")]
    private FilterUnitParam[] mFilterUnitParams;
    [Token(Token = "0x4005F7A")]
    [FieldOffset(Offset = "0x254")]
    private FilterArtifactParam[] mFilterArtifactParams;
    [Token(Token = "0x4005F7B")]
    [FieldOffset(Offset = "0x258")]
    private List<SortArtifactParam> mSortArtifactParams;
    [Token(Token = "0x4005F7C")]
    [FieldOffset(Offset = "0x25C")]
    private SortRuneParam[] mSortRuneParams;
    [Token(Token = "0x4005F7D")]
    [FieldOffset(Offset = "0x260")]
    private List<RuneParam> mRuneParam;
    [Token(Token = "0x4005F7E")]
    [FieldOffset(Offset = "0x264")]
    private Dictionary<string, RuneParam> mRuneParamDict;
    [Token(Token = "0x4005F7F")]
    [FieldOffset(Offset = "0x268")]
    private List<RuneLotteryBaseState> mRuneLotteryBaseState;
    [Token(Token = "0x4005F80")]
    [FieldOffset(Offset = "0x26C")]
    private List<RuneLotteryEvoState> mRuneLotteryEvoState;
    [Token(Token = "0x4005F81")]
    [FieldOffset(Offset = "0x270")]
    private List<SRPG.RuneMaterial> mRuneMaterial;
    [Token(Token = "0x4005F82")]
    [FieldOffset(Offset = "0x274")]
    private List<RuneCost> mRuneCost;
    [Token(Token = "0x4005F83")]
    [FieldOffset(Offset = "0x278")]
    private List<RuneSetEff> mRuneSetEff;
    [Token(Token = "0x4005F84")]
    [FieldOffset(Offset = "0x27C")]
    private List<RuneLotteryBaseStatePack> mRuneLotteryBaseStatePack;
    [Token(Token = "0x4005F85")]
    [FieldOffset(Offset = "0x280")]
    private List<RuneLotteryEvoStatePack> mRuneLotteryEvoStatePack;
    [Token(Token = "0x4005F86")]
    [FieldOffset(Offset = "0x284")]
    private List<RuneDedicatedCostParam> mRuneDedicatedCostParams;
    [Token(Token = "0x4005F87")]
    [FieldOffset(Offset = "0x288")]
    private List<JukeBoxParam> mJukeBoxParams;
    [Token(Token = "0x4005F88")]
    [FieldOffset(Offset = "0x28C")]
    private List<JukeBoxSectionParam> mJukeBoxSectionParams;
    [Token(Token = "0x4005F89")]
    [FieldOffset(Offset = "0x290")]
    private List<UnitSameGroupParam> mUnitSameGroup;
    [Token(Token = "0x4005F8A")]
    [FieldOffset(Offset = "0x294")]
    private AutoRepeatQuestBoxParam[] mAutoRepeatQuestBoxParams;
    [Token(Token = "0x4005F8B")]
    [FieldOffset(Offset = "0x298")]
    private GuildAttendParam[] mGuildAttendParams;
    [Token(Token = "0x4005F8C")]
    [FieldOffset(Offset = "0x29C")]
    private List<GuildAttendRewardParam> mGuildAttendRewardParams;
    [Token(Token = "0x4005F8D")]
    [FieldOffset(Offset = "0x2A0")]
    private GuildRoleBonusParam[] mGuildRoleBonusParams;
    [Token(Token = "0x4005F8E")]
    [FieldOffset(Offset = "0x2A4")]
    private List<GuildRoleBonusRewardParam> mGuildRoleBonusRewardParams;
    [Token(Token = "0x4005F8F")]
    [FieldOffset(Offset = "0x2A8")]
    private Dictionary<string, ResetCostParam> mResetCostParams;
    [Token(Token = "0x4005F90")]
    [FieldOffset(Offset = "0x2AC")]
    private GuildSearchFilterParam[] mGuildSeartchFilterParams;
    [Token(Token = "0x4005F91")]
    [FieldOffset(Offset = "0x2B0")]
    private List<ReplaceSprite> mRepraseSprite;
    [Token(Token = "0x4005F92")]
    [FieldOffset(Offset = "0x2B4")]
    private List<ExternalVideoLinkParam> mExternalVideoLinkParams;
    [Token(Token = "0x4005F93")]
    [FieldOffset(Offset = "0x2B8")]
    private ParamDictionary<string, TruthEquipmentParam> mTruthEquipmentDict;
    [Token(Token = "0x4005F94")]
    [FieldOffset(Offset = "0x2BC")]
    private ParamDictionary<string, TruthEquipmentRecipeParam> mTruthEquipmentRecipeDict;
    [Token(Token = "0x4005F95")]
    [FieldOffset(Offset = "0x2C0")]
    private ParamDictionary<string, TruthEquipmentStatusParam> mTruthEquipmentStatusDict;
    [Token(Token = "0x4005F96")]
    [FieldOffset(Offset = "0x2C4")]
    private ParamDictionary<string, TruthEquipmentAbilityParam> mTruthEquipmentAbilityDict;
    [Token(Token = "0x4005F97")]
    [FieldOffset(Offset = "0x2C8")]
    private List<BondGroupParam> mBondGroupParams;
    [Token(Token = "0x4005F98")]
    [FieldOffset(Offset = "0x2CC")]
    private List<BondGroupBuffParam> mBondGroupBuffParams;
    [Token(Token = "0x4005F99")]
    [FieldOffset(Offset = "0x2D0")]
    private List<BondPieceParam> mBondPieceParams;
    [Token(Token = "0x4005F9A")]
    [FieldOffset(Offset = "0x2D4")]
    private List<BondSubPieceParam> mBondSubPieceParams;
    [Token(Token = "0x4005F9B")]
    [FieldOffset(Offset = "0x2D8")]
    private List<BondRecipeParam> mBondRecipeParams;
    [Token(Token = "0x4005F9C")]
    [FieldOffset(Offset = "0x2DC")]
    private List<BondMissionParam> mBondMissionParams;
    [Token(Token = "0x4005F9D")]
    [FieldOffset(Offset = "0x2E0")]
    private List<TobiraEnhanceMaxItemParam> mTobiraEnhanceMaxItemParams;
    [Token(Token = "0x4005F9E")]
    [FieldOffset(Offset = "0x2E4")]
    private List<SkillBuffEffectParam> mSkillBuffEffectParams;
    [Token(Token = "0x4005F9F")]
    [FieldOffset(Offset = "0x2E8")]
    private List<MasteryRewardParam> mMasteryRewardParams;
    [Token(Token = "0x4005FA0")]
    [FieldOffset(Offset = "0x2EC")]
    private List<CrystalParam> mCrystalParam;
    [Token(Token = "0x4005FA1")]
    [FieldOffset(Offset = "0x2F0")]
    private List<CrystalSetBonusParam> mCrystalSetBonusParam;
    [Token(Token = "0x4005FA2")]
    [FieldOffset(Offset = "0x2F4")]
    private List<CrystalStatusLimitParam> mCrystalStatusLimitParam;
    [Token(Token = "0x4005FA3")]
    [FieldOffset(Offset = "0x2F8")]
    private List<CrystalSaleParam> mCrystalSaleParam;
    [Token(Token = "0x4005FA4")]
    [FieldOffset(Offset = "0x2FC")]
    private List<CrystalUpgradeParam> mCrystalUpgradeParam;
    [Token(Token = "0x4005FA5")]
    [FieldOffset(Offset = "0x300")]
    private List<CrystalSortParam> mCrystalSortParam;
    [Token(Token = "0x4005FA6")]
    [FieldOffset(Offset = "0x304")]
    private List<CrystalFilterParam> mCrystalFilterParam;
    [Token(Token = "0x4005FA7")]
    [FieldOffset(Offset = "0x308")]
    private List<CrystalSetBonusFilterParam> mCrystalSetBonusFilterParam;
    [Token(Token = "0x4005FA8")]
    [FieldOffset(Offset = "0x30C")]
    private List<CrystalRecommendParam> mCrystalRecommendParam;
    [Token(Token = "0x4005FA9")]
    [FieldOffset(Offset = "0x310")]
    private List<CrystalAddLimitParam> mCrystalAddLimitParam;
    [Token(Token = "0x4005FAA")]
    [FieldOffset(Offset = "0x314")]
    private List<ArtifactStoneEffectParam> mArtifactStoneEffectParam;
    [Token(Token = "0x4005FAB")]
    [FieldOffset(Offset = "0x318")]
    private List<CrystalReplaceFilterParam> mCrystalReplaceFilterParam;
    [Token(Token = "0x4005FAC")]
    [FieldOffset(Offset = "0x320")]
    private DateTime mDeserializeTime;
    [Token(Token = "0x4005FAE")]
    [FieldOffset(Offset = "0x32C")]
    private List<ResonanceParam> mResonanceParams;
    [Token(Token = "0x4005FAF")]
    [FieldOffset(Offset = "0x330")]
    private List<ResonanceRecipeParam> mResonanceRecipeParams;
    [Token(Token = "0x4005FB0")]
    [FieldOffset(Offset = "0x334")]
    private List<ResonanceCondParam> mResonanceCondParams;
    [Token(Token = "0x4005FB1")]
    [FieldOffset(Offset = "0x338")]
    private List<ResonanceLimitRateParam> mResonanceLimitRateParams;
    [Token(Token = "0x4005FB2")]
    [FieldOffset(Offset = "0x33C")]
    private List<ResonanceTobiraBuffRateParam> mResonanceTobiraBuffRateParams;
    [Token(Token = "0x4005FB3")]
    [FieldOffset(Offset = "0x340")]
    private List<HomeUnitVoiceParam> mHomeUnitVoiceParams;
    [Token(Token = "0x4005FB4")]
    [FieldOffset(Offset = "0x344")]
    private List<AutoRuneDisassemblyParam> mAutoRuneDisassemblyParams;
    [Token(Token = "0x4005FB5")]
    [FieldOffset(Offset = "0x348")]
    private List<AutoRuneDisassemblySetParam> mAutoRuneDisassemblySetParams;
    [Token(Token = "0x4005FB6")]
    [FieldOffset(Offset = "0x34C")]
    private List<AutoRuneDisassemblyStateParam> mAutoRuneDisassemblyStateParams;
    [Token(Token = "0x4005FB7")]
    [FieldOffset(Offset = "0x350")]
    private List<RunePridePanelParam> mRunePridePanelParams;
    [Token(Token = "0x4005FB8")]
    [FieldOffset(Offset = "0x354")]
    private List<RunePridePanelPatternParam> mRunePridePanelPatternParams;
    [Token(Token = "0x4005FB9")]
    [FieldOffset(Offset = "0x358")]
    private List<RunePridePanelContentsParam> mRunePridePanelContentsParams;
    [Token(Token = "0x4005FBA")]
    [FieldOffset(Offset = "0x35C")]
    private List<RunePrideBonusParam> mRunePrideBonusParams;
    [Token(Token = "0x4005FBB")]
    [FieldOffset(Offset = "0x360")]
    private List<RunePrideBonusStatusParam> mRunePrideBonusStatusParams;
    [Token(Token = "0x4005FBC")]
    [FieldOffset(Offset = "0x364")]
    private List<RunePridePotentialParam> mRunePridePotentialParams;
    [Token(Token = "0x4005FBD")]
    [FieldOffset(Offset = "0x368")]
    private List<RunePridePotentialStatusParam> mRunePridePotentialStatusParams;
    [Token(Token = "0x4005FBE")]
    [FieldOffset(Offset = "0x36C")]
    private List<RunePrideUnitItemParam> mRunePrideUnitItemParams;
    [Token(Token = "0x4005FBF")]
    [FieldOffset(Offset = "0x370")]
    private List<RunePrideItemListParam> mRunePrideItemListParams;
    [Token(Token = "0x4005FC0")]
    [FieldOffset(Offset = "0x374")]
    private List<RunePrideResetParam> mRunePrideResetParams;
    [Token(Token = "0x4005FC1")]
    [FieldOffset(Offset = "0x378")]
    private List<RunePrideUnitGroupParam> mRunePrideUnitGroupParams;
    [Token(Token = "0x4005FC2")]
    [FieldOffset(Offset = "0x37C")]
    private Dictionary<string, RunePridePanelParam> mRunePridePanelDictionary;
    [Token(Token = "0x4005FC3")]
    [FieldOffset(Offset = "0x380")]
    private Dictionary<string, RunePridePanelContentsParam> mRunePridePanelContentsDictionary;
    [Token(Token = "0x4005FC4")]
    [FieldOffset(Offset = "0x384")]
    private Dictionary<string, RunePridePanelPatternParam> mRunePridePanelPatternDictionary;
    [Token(Token = "0x4005FC5")]
    [FieldOffset(Offset = "0x388")]
    private Dictionary<string, List<RunePrideBonusParam>> mRunePrideBonusDictionary;
    [Token(Token = "0x4005FC6")]
    [FieldOffset(Offset = "0x38C")]
    private Dictionary<string, RunePrideUnitItemParam> mRunePrideUnitItemDictionary;
    [Token(Token = "0x4005FC7")]
    [FieldOffset(Offset = "0x390")]
    private Dictionary<string, RunePrideItemListParam> mRunePrideItemListDictionary;
    [Token(Token = "0x4005FC8")]
    [FieldOffset(Offset = "0x394")]
    private Dictionary<string, RunePrideUnitGroupParam> mRunePrideUnitGroupDictionary;
    [Token(Token = "0x4005FC9")]
    [FieldOffset(Offset = "0x398")]
    private List<InspSkillLvUpCostParam> mInspSkillLvUpCostParam;
    [Token(Token = "0x4005FCA")]
    [FieldOffset(Offset = "0x39C")]
    private Dictionary<string, InspSkillParam> mInspSkillDictionary;
    [Token(Token = "0x4005FCB")]
    [FieldOffset(Offset = "0x3A0")]
    private Dictionary<int, InspSkillCostParam> mInspSkillResetCostDictionary;
    [Token(Token = "0x4005FCC")]
    [FieldOffset(Offset = "0x3A4")]
    private Dictionary<int, InspSkillCostParam> mInspSkillOpenCostDictionary;
    [Token(Token = "0x4005FCD")]
    [FieldOffset(Offset = "0x3A8")]
    private List<SkillParam> mSkillParam;
    [Token(Token = "0x4005FCE")]
    [FieldOffset(Offset = "0x3AC")]
    private Dictionary<string, SkillParam> mSkillDictionary;
    [Token(Token = "0x4005FCF")]
    [FieldOffset(Offset = "0x3B0")]
    private List<ProtectSkillParam> mProtectSkillParams;
    [Token(Token = "0x4005FD0")]
    [FieldOffset(Offset = "0x3B4")]
    private List<SkillAdditionalParam> mSkillAdditionalList;
    [Token(Token = "0x4005FD1")]
    [FieldOffset(Offset = "0x3B8")]
    private List<SkillAntiShieldParam> mSkillAntiShieldList;
    [Token(Token = "0x4005FD2")]
    [FieldOffset(Offset = "0x3BC")]
    private List<SkillRevivalParam> mSkillRevivalList;
    [Token(Token = "0x4005FD3")]
    [FieldOffset(Offset = "0x3C0")]
    private List<SkillAutoHpJudgeParam> mSkillAutoHpJudgeList;
    [Token(Token = "0x4005FD4")]
    [FieldOffset(Offset = "0x3C4")]
    private List<SkillCriticalHealParam> mSkillCriticalHealList;
    [Token(Token = "0x4005FD5")]
    [FieldOffset(Offset = "0x3C8")]
    private List<SkillDuplicateResetParam> mSkillDuplicateResetList;
    [Token(Token = "0x4005FD6")]
    [FieldOffset(Offset = "0x3CC")]
    public ParamDictionary<string, SkillManipulateParam> mSkillManipulateParam;
    [Token(Token = "0x4005FD7")]
    [FieldOffset(Offset = "0x3D0")]
    public ParamDictionary<string, SkillManipulatePierceParam> mSkillManipulatePierceParam;
    [Token(Token = "0x4005FD8")]
    [FieldOffset(Offset = "0x3D4")]
    private List<SkillReactionCondParam> mSkillReactionCondParams;
    [Token(Token = "0x4005FD9")]
    [FieldOffset(Offset = "0x3D8")]
    private List<SkillDistanceParam> mSkillDistanceParam;
    [Token(Token = "0x4005FDA")]
    [FieldOffset(Offset = "0x3DC")]
    private List<SkillGroupParam> mSkillGroupParam;

    [Token(Token = "0x17000B30")]
    public PremiumParam[] Premium
    {
      [Token(Token = "0x600694D"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (PremiumParam[]) null;
      }
    }

    [Token(Token = "0x600694E")]
    [Address(RVA = "0x3369E0", Offset = "0x3357E0", VA = "0x103369E0")]
    private void Deserialize_BuyCoin(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x600694F")]
    [Address(RVA = "0x33BE90", Offset = "0x33AC90", VA = "0x1033BE90")]
    public eProductType GetBuyCoinProductType(string key) => new eProductType();

    [Token(Token = "0x6006950")]
    [Address(RVA = "0x33BCE0", Offset = "0x33AAE0", VA = "0x1033BCE0")]
    public BuyCoinProductParam GetBuyCoinProductParam(string key, int index = -1)
    {
      return (BuyCoinProductParam) null;
    }

    [Token(Token = "0x6006951")]
    [Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x1032ED30")]
    public void AddBuyCoinProductDictionary(string key, BuyCoinProductParam _param)
    {
    }

    [Token(Token = "0x6006952")]
    [Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")]
    public List<BuyCoinShopParam> GetBuyCoinShopParam() => (List<BuyCoinShopParam>) null;

    [Token(Token = "0x6006953")]
    [Address(RVA = "0x33C070", Offset = "0x33AE70", VA = "0x1033C070")]
    public BuyCoinShopParam GetBuyCoinShopParam(string shop_id) => (BuyCoinShopParam) null;

    [Token(Token = "0x6006954")]
    [Address(RVA = "0x330470", Offset = "0x32F270", VA = "0x10330470")]
    public void DeleteOutsidePeriodBuyCoinParam()
    {
    }

    [Token(Token = "0x6006955")]
    [Address(RVA = "0x347B00", Offset = "0x346900", VA = "0x10347B00")]
    public bool IsBuyCoinShopOpen(BuyCoinShopParam param) => new bool();

    [Token(Token = "0x6006956")]
    [Address(RVA = "0x33C130", Offset = "0x33AF30", VA = "0x1033C130")]
    public List<BuyCoinShopParam> GetBuyCoinShopParam(BuyCoinManager.BuyCoinShopType type)
    {
      return (List<BuyCoinShopParam>) null;
    }

    [Token(Token = "0x6006957")]
    [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
    public List<BuyCoinRewardParam> GetBuyCoinRewardParam() => (List<BuyCoinRewardParam>) null;

    [Token(Token = "0x6006958")]
    [Address(RVA = "0x33BF10", Offset = "0x33AD10", VA = "0x1033BF10")]
    public BuyCoinRewardParam GetBuyCoinRewardParam(string key) => (BuyCoinRewardParam) null;

    [Token(Token = "0x6006959")]
    [Address(RVA = "0x33BC60", Offset = "0x33AA60", VA = "0x1033BC60")]
    public string GetBuyCoinProductConvert_FromCommonProductID(string key) => (string) null;

    [Token(Token = "0x600695A")]
    [Address(RVA = "0x33BBE0", Offset = "0x33A9E0", VA = "0x1033BBE0")]
    public string GetBuyCoinProductConvert_FromAuProductID(string key) => (string) null;

    [Token(Token = "0x600695B")]
    [Address(RVA = "0x33BBC0", Offset = "0x33A9C0", VA = "0x1033BBC0")]
    public List<BuyCoinHotDealParam> GetBuyCoinHotDealParam() => (List<BuyCoinHotDealParam>) null;

    [Token(Token = "0x600695C")]
    [Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")]
    public List<BuyCoinStepUpParam> GetBuyCoinStepUpList() => (List<BuyCoinStepUpParam>) null;

    [Token(Token = "0x600695D")]
    [Address(RVA = "0x340A20", Offset = "0x33F820", VA = "0x10340A20")]
    public List<PremiumParam> GetPremiumParamList() => (List<PremiumParam>) null;

    [Token(Token = "0x600695E")]
    [Address(RVA = "0x3408E0", Offset = "0x33F6E0", VA = "0x103408E0")]
    public List<PremiumParam> GetPremiumParamListSpan() => (List<PremiumParam>) null;

    [Token(Token = "0x600695F")]
    [Address(RVA = "0x3480A0", Offset = "0x346EA0", VA = "0x103480A0")]
    public bool IsPremiumProductID(string _productid) => new bool();

    [Token(Token = "0x6006960")]
    [Address(RVA = "0x340D90", Offset = "0x33FB90", VA = "0x10340D90")]
    public PremiumParam GetPremiumParam(string _productid) => (PremiumParam) null;

    [Token(Token = "0x6006961")]
    [Address(RVA = "0x340B90", Offset = "0x33F990", VA = "0x10340B90")]
    public string GetPremiumParamProductID(string _tableid) => (string) null;

    [Token(Token = "0x6006962")]
    [Address(RVA = "0x340C80", Offset = "0x33FA80", VA = "0x10340C80")]
    public string GetPremiumParamTableID(string _productid) => (string) null;

    [Token(Token = "0x6006963")]
    [Address(RVA = "0x347F60", Offset = "0x346D60", VA = "0x10347F60")]
    public bool IsPremiumOpen(string _productid) => new bool();

    [Token(Token = "0x6006964")]
    [Address(RVA = "0x340AA0", Offset = "0x33F8A0", VA = "0x10340AA0")]
    public string GetPremiumParamProductID(int _type) => (string) null;

    [Token(Token = "0x17000B31")]
    public FilterConceptCardParam[] FilterConceptCardParams
    {
      [Token(Token = "0x6006965"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (FilterConceptCardParam[]) null;
      }
    }

    [Token(Token = "0x17000B32")]
    public Dictionary<string, ConceptCardExtraRarityParam> CocneptCardExtraRarityParams
    {
      [Token(Token = "0x6006966"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return (Dictionary<string, ConceptCardExtraRarityParam>) null;
      }
    }

    [Token(Token = "0x17000B33")]
    public FixConceptCardParam FixConcepctCard
    {
      [Token(Token = "0x6006967"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (FixConceptCardParam) null;
      }
    }

    [Token(Token = "0x6006968")]
    [Address(RVA = "0x336EC0", Offset = "0x335CC0", VA = "0x10336EC0")]
    private void Deserialize_ConceptCard(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x6006969")]
    [Address(RVA = "0x33C9E0", Offset = "0x33B7E0", VA = "0x1033C9E0")]
    public List<ConceptCardParam> GetConceptCardGroup(string iname)
    {
      return (List<ConceptCardParam>) null;
    }

    [Token(Token = "0x600696A")]
    [Address(RVA = "0x347B70", Offset = "0x346970", VA = "0x10347B70")]
    public bool IsContainsConceptCardLeaderSkill(
      string skill_iname,
      ConceptCardParam concept_card_param)
    {
      return new bool();
    }

    [Token(Token = "0x600696B")]
    [Address(RVA = "0x32F2F0", Offset = "0x32E0F0", VA = "0x1032F2F0")]
    public bool CheckConceptCardgroup(string group_iname, ConceptCardParam concept_card_param)
    {
      return new bool();
    }

    [Token(Token = "0x600696C")]
    [Address(RVA = "0x33CB50", Offset = "0x33B950", VA = "0x1033CB50")]
    public ConceptCardParam GetConceptCardParam(string iname) => (ConceptCardParam) null;

    [Token(Token = "0x600696D")]
    [Address(RVA = "0x33CAF0", Offset = "0x33B8F0", VA = "0x1033CAF0")]
    public int GetConceptCardNextExp(int rarity, int lv) => new int();

    [Token(Token = "0x600696E")]
    [Address(RVA = "0x33C960", Offset = "0x33B760", VA = "0x1033C960")]
    public int GetConceptCardLevelExp(int rarity, int lv) => new int();

    [Token(Token = "0x600696F")]
    [Address(RVA = "0x32F0D0", Offset = "0x32DED0", VA = "0x1032F0D0")]
    public int CalcConceptCardLevel(int rarity, int totalExp, int levelCap) => new int();

    [Token(Token = "0x6006970")]
    [Address(RVA = "0x33C960", Offset = "0x33B760", VA = "0x1033C960")]
    public int GetConceptCardExp(int rarity, int level) => new int();

    [Token(Token = "0x6006971")]
    [Address(RVA = "0x33C8D0", Offset = "0x33B6D0", VA = "0x1033C8D0")]
    public ConceptCardConditionsParam GetConceptCardConditions(string iname)
    {
      return (ConceptCardConditionsParam) null;
    }

    [Token(Token = "0x6006972")]
    [Address(RVA = "0x3397B0", Offset = "0x3385B0", VA = "0x103397B0")]
    public int FindUnitConceptCardConditions(UnitData unit, ConceptCardData card, bool allcheck = false)
    {
      return new int();
    }

    [Token(Token = "0x6006973")]
    [Address(RVA = "0x33CBD0", Offset = "0x33B9D0", VA = "0x1033CBD0")]
    public int GetConceptCardTrustMax(ConceptCardData data) => new int();

    [Token(Token = "0x6006974")]
    [Address(RVA = "0x346400", Offset = "0x345200", VA = "0x10346400")]
    public ConceptCardTrustRewardParam GetTrustReward(string iname)
    {
      return (ConceptCardTrustRewardParam) null;
    }

    [Token(Token = "0x6006975")]
    [Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")]
    public List<ConceptCardParam> GetConceptCardParams() => (List<ConceptCardParam>) null;

    [Token(Token = "0x6006976")]
    [Address(RVA = "0x33ACC0", Offset = "0x339AC0", VA = "0x1033ACC0")]
    public List<FilterConceptCardParam> GetAllFilterConceptCardParamList()
    {
      return (List<FilterConceptCardParam>) null;
    }

    [Token(Token = "0x6006977")]
    [Address(RVA = "0x33AC50", Offset = "0x339A50", VA = "0x1033AC50")]
    public Dictionary<string, List<ConceptCardParam>> GetAllConceptCardGroupDict()
    {
      return (Dictionary<string, List<ConceptCardParam>>) null;
    }

    [Token(Token = "0x6006978")]
    [Address(RVA = "0x33C840", Offset = "0x33B640", VA = "0x1033C840")]
    public float GetConceptCardCoinRate(int awake) => new float();

    [Token(Token = "0x6006979")]
    [Address(RVA = "0x33CA70", Offset = "0x33B870", VA = "0x1033CA70")]
    public int GetConceptCardLsBuffCoefInt(int rare, int bt_limit) => new int();

    [Token(Token = "0x600697A")]
    [Address(RVA = "0x33CA90", Offset = "0x33B890", VA = "0x1033CA90")]
    public int GetConceptCardLsBuffFriendCoefInt(int rare, int bt_limit) => new int();

    [Token(Token = "0x600697B")]
    [Address(RVA = "0x33CAB0", Offset = "0x33B8B0", VA = "0x1033CAB0")]
    public float GetConceptCardLsBuffFriendCoef(int rare, int bt_limit) => new float();

    [Token(Token = "0x600697C")]
    [Address(RVA = "0x339140", Offset = "0x337F40", VA = "0x10339140")]
    public ConceptCardExtraRarityParam FindExtraRarityParam(string iname)
    {
      return (ConceptCardExtraRarityParam) null;
    }

    [Token(Token = "0x17000B34")]
    public List<ElementPieceParam> ElementPieceParams
    {
      [Token(Token = "0x600697D"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return (List<ElementPieceParam>) null;
      }
    }

    [Token(Token = "0x17000B35")]
    public List<ElementBuffParam> ElementBuffParams
    {
      [Token(Token = "0x600697E"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return (List<ElementBuffParam>) null;
      }
    }

    [Token(Token = "0x600697F")]
    [Address(RVA = "0x337740", Offset = "0x336540", VA = "0x10337740")]
    private void Deserialize_Element(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x6006980")]
    [Address(RVA = "0x33DBD0", Offset = "0x33C9D0", VA = "0x1033DBD0")]
    public ItemParam GetElementPieceItemParam(EElement element, int plus) => (ItemParam) null;

    [Token(Token = "0x6006981")]
    [Address(RVA = "0x33C680", Offset = "0x33B480", VA = "0x1033C680")]
    public ItemParam GetCommonPieceItemParam(EElement element, int plus) => (ItemParam) null;

    [Token(Token = "0x6006982")]
    [Address(RVA = "0x347CF0", Offset = "0x346AF0", VA = "0x10347CF0")]
    public bool IsElementPiece(string iname) => new bool();

    [Token(Token = "0x6006983")]
    [Address(RVA = "0x33D9A0", Offset = "0x33C7A0", VA = "0x1033D9A0")]
    public List<BuffEffectParam> GetElementBuffEffectParamList(EElement element, int plus)
    {
      return (List<BuffEffectParam>) null;
    }

    [Token(Token = "0x6006984")]
    [Address(RVA = "0x33F4F0", Offset = "0x33E2F0", VA = "0x1033F4F0")]
    public int GetHighElementAddRate(EElement element, int plus) => new int();

    [Token(Token = "0x17000B36")]
    public List<ExpansionPurchaseParam> ExpansionPurchaseParams
    {
      [Token(Token = "0x6006985"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (List<ExpansionPurchaseParam>) null;
      }
    }

    [Token(Token = "0x17000B37")]
    public List<ExpansionPurchaseQuestParam> ExpansionPurchaseQuestParams
    {
      [Token(Token = "0x6006986"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return (List<ExpansionPurchaseQuestParam>) null;
      }
    }

    [Token(Token = "0x6006987")]
    [Address(RVA = "0x3377D0", Offset = "0x3365D0", VA = "0x103377D0")]
    private void Deserialize_ExpansionPurchase(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x6006988")]
    [Address(RVA = "0x33E7A0", Offset = "0x33D5A0", VA = "0x1033E7A0")]
    public ExpansionPurchaseParam[] GetExpansionPurchaseParams(ExpansionPurchaseParam.eType _type)
    {
      return (ExpansionPurchaseParam[]) null;
    }

    [Token(Token = "0x6006989")]
    [Address(RVA = "0x33E670", Offset = "0x33D470", VA = "0x1033E670")]
    public ExpansionPurchaseParam[] GetExpansionPurchaseParams(
      ExpansionPurchaseParam.eType _type,
      int _value)
    {
      return (ExpansionPurchaseParam[]) null;
    }

    [Token(Token = "0x600698A")]
    [Address(RVA = "0x33E5A0", Offset = "0x33D3A0", VA = "0x1033E5A0")]
    public ExpansionPurchaseParam GetExpansionPurchaseParamForProductId(string product_iname)
    {
      return (ExpansionPurchaseParam) null;
    }

    [Token(Token = "0x17000B38")]
    public List<LeagueMatchBuffParam> LeagueMatchBuffParams
    {
      [Token(Token = "0x600698B"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return (List<LeagueMatchBuffParam>) null;
      }
    }

    [Token(Token = "0x17000B39")]
    public List<LeagueMatchBuffResetParam> LeagueMatchBuffResetParams
    {
      [Token(Token = "0x600698C"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return (List<LeagueMatchBuffResetParam>) null;
      }
    }

    [Token(Token = "0x17000B3A")]
    public List<LeagueMatchRankParam> LeagueMatchRankParams
    {
      [Token(Token = "0x600698D"), Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")] get
      {
        return (List<LeagueMatchRankParam>) null;
      }
    }

    [Token(Token = "0x17000B3B")]
    public List<LeagueMatchRewardParam> LeagueMatchRewardParams
    {
      [Token(Token = "0x600698E"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return (List<LeagueMatchRewardParam>) null;
      }
    }

    [Token(Token = "0x17000B3C")]
    public List<LeagueMatchSeasonParam> LeagueMatchSeasonParams
    {
      [Token(Token = "0x600698F"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return (List<LeagueMatchSeasonParam>) null;
      }
    }

    [Token(Token = "0x17000B3D")]
    public List<LeagueMatchSettingParam> LeagueMatchSettingParams
    {
      [Token(Token = "0x6006990"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (List<LeagueMatchSettingParam>) null;
      }
    }

    [Token(Token = "0x6006991")]
    [Address(RVA = "0x337810", Offset = "0x336610", VA = "0x10337810")]
    private void Deserialize_LeagueMatch(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x6006992")]
    [Address(RVA = "0x340250", Offset = "0x33F050", VA = "0x10340250")]
    public LeagueMatchSeasonParam GetLeagueMatchSeasonParam(int mSeason)
    {
      return (LeagueMatchSeasonParam) null;
    }

    [Token(Token = "0x6006993")]
    [Address(RVA = "0x340090", Offset = "0x33EE90", VA = "0x10340090")]
    public LeagueMatchRankParam GetLeagueMatchRankParam(string mIname)
    {
      return (LeagueMatchRankParam) null;
    }

    [Token(Token = "0x6006994")]
    [Address(RVA = "0x340170", Offset = "0x33EF70", VA = "0x10340170")]
    public LeagueMatchRewardParam GetLeagueMatchRewardParam(string mIname)
    {
      return (LeagueMatchRewardParam) null;
    }

    [Token(Token = "0x6006995")]
    [Address(RVA = "0x33FFB0", Offset = "0x33EDB0", VA = "0x1033FFB0")]
    public LeagueMatchBuffParam GetLeagueMatchBuffParam(string mIname)
    {
      return (LeagueMatchBuffParam) null;
    }

    [Token(Token = "0x6006996")]
    [Address(RVA = "0x340320", Offset = "0x33F120", VA = "0x10340320")]
    public LeagueMatchSettingParam GetLeagueMatchSettingParam(string mIname)
    {
      return (LeagueMatchSettingParam) null;
    }

    [Token(Token = "0x17000B3E")]
    public TrophyCategoryParam[] GuildTrophyCategory
    {
      [Token(Token = "0x6006997"), Address(RVA = "0x349280", Offset = "0x348080", VA = "0x10349280")] get
      {
        return (TrophyCategoryParam[]) null;
      }
    }

    [Token(Token = "0x17000B3F")]
    public GuildTrophyParam[] GuildTrophy
    {
      [Token(Token = "0x6006998"), Address(RVA = "0x349290", Offset = "0x348090", VA = "0x10349290")] get
      {
        return (GuildTrophyParam[]) null;
      }
    }

    [Token(Token = "0x17000B40")]
    public List<SkillAbilityDeriveData> SkillAbilityDerives
    {
      [Token(Token = "0x6006999"), Address(RVA = "0x349500", Offset = "0x348300", VA = "0x10349500")] get
      {
        return (List<SkillAbilityDeriveData>) null;
      }
    }

    [Token(Token = "0x17000B41")]
    public TipsParam[] Tips
    {
      [Token(Token = "0x600699A"), Address(RVA = "0x349590", Offset = "0x348390", VA = "0x10349590")] get
      {
        return (TipsParam[]) null;
      }
    }

    [Token(Token = "0x17000B42")]
    public List<GuildTrainingUnit> GetGuildTrainingUnits
    {
      [Token(Token = "0x600699B"), Address(RVA = "0x349240", Offset = "0x348040", VA = "0x10349240")] get
      {
        return (List<GuildTrainingUnit>) null;
      }
    }

    [Token(Token = "0x17000B43")]
    public List<GuildTrainingEnergyItem> GetGuildTrainingEnergyItems
    {
      [Token(Token = "0x600699C"), Address(RVA = "0x349230", Offset = "0x348030", VA = "0x10349230")] get
      {
        return (List<GuildTrainingEnergyItem>) null;
      }
    }

    [Token(Token = "0x17000B44")]
    public List<GuildTrainingCampaign> GetGuildTrainingCampaign
    {
      [Token(Token = "0x600699D"), Address(RVA = "0x349220", Offset = "0x348020", VA = "0x10349220")] get
      {
        return (List<GuildTrainingCampaign>) null;
      }
    }

    [Token(Token = "0x17000B45")]
    public ConvertUnitPieceExcludeParam[] ConvertUnitPieceExclude
    {
      [Token(Token = "0x600699E"), Address(RVA = "0x349130", Offset = "0x347F30", VA = "0x10349130")] get
      {
        return (ConvertUnitPieceExcludeParam[]) null;
      }
    }

    [Token(Token = "0x17000B46")]
    public SRPG.HighlightParam[] HighlightParam
    {
      [Token(Token = "0x600699F"), Address(RVA = "0x3492A0", Offset = "0x3480A0", VA = "0x103492A0")] get
      {
        return (SRPG.HighlightParam[]) null;
      }
    }

    [Token(Token = "0x17000B47")]
    public CoinBuyUseBonusRewardSetParam[] CoinBuyUseBonusRewardSetParams
    {
      [Token(Token = "0x60069A0"), Address(RVA = "0x349110", Offset = "0x347F10", VA = "0x10349110")] get
      {
        return (CoinBuyUseBonusRewardSetParam[]) null;
      }
    }

    [Token(Token = "0x17000B48")]
    public CoinBuyUseBonusRewardParam[] CoinBuyUseBonusRewardParams
    {
      [Token(Token = "0x60069A1"), Address(RVA = "0x349100", Offset = "0x347F00", VA = "0x10349100")] get
      {
        return (CoinBuyUseBonusRewardParam[]) null;
      }
    }

    [Token(Token = "0x17000B49")]
    public Dictionary<string, UnitRentalNotificationParam> UnitRentalNotificationParams
    {
      [Token(Token = "0x60069A2"), Address(RVA = "0x349610", Offset = "0x348410", VA = "0x10349610")] get
      {
        return (Dictionary<string, UnitRentalNotificationParam>) null;
      }
    }

    [Token(Token = "0x17000B4A")]
    public Dictionary<string, UnitRentalParam> UnitRentalParams
    {
      [Token(Token = "0x60069A3"), Address(RVA = "0x349620", Offset = "0x348420", VA = "0x10349620")] get
      {
        return (Dictionary<string, UnitRentalParam>) null;
      }
    }

    [Token(Token = "0x17000B4B")]
    public Dictionary<string, DrawCardRewardParam> DrawCardRewardDict
    {
      [Token(Token = "0x60069A4"), Address(RVA = "0x349150", Offset = "0x347F50", VA = "0x10349150")] get
      {
        return (Dictionary<string, DrawCardRewardParam>) null;
      }
    }

    [Token(Token = "0x17000B4C")]
    public Dictionary<string, DrawCardParam> DrawCardDict
    {
      [Token(Token = "0x60069A5"), Address(RVA = "0x349140", Offset = "0x347F40", VA = "0x10349140")] get
      {
        return (Dictionary<string, DrawCardParam>) null;
      }
    }

    [Token(Token = "0x17000B4D")]
    public Dictionary<string, TrophyStarMissionRewardParam> TrophyStarMissionRewardDict
    {
      [Token(Token = "0x60069A6"), Address(RVA = "0x3495F0", Offset = "0x3483F0", VA = "0x103495F0")] get
      {
        return (Dictionary<string, TrophyStarMissionRewardParam>) null;
      }
    }

    [Token(Token = "0x17000B4E")]
    public Dictionary<string, TrophyStarMissionParam> TrophyStarMissionDict
    {
      [Token(Token = "0x60069A7"), Address(RVA = "0x3495E0", Offset = "0x3483E0", VA = "0x103495E0")] get
      {
        return (Dictionary<string, TrophyStarMissionParam>) null;
      }
    }

    [Token(Token = "0x17000B4F")]
    public List<UnitPieceShopParam> UnitPieceShop
    {
      [Token(Token = "0x60069A8"), Address(RVA = "0x349600", Offset = "0x348400", VA = "0x10349600")] get
      {
        return (List<UnitPieceShopParam>) null;
      }
    }

    [Token(Token = "0x17000B50")]
    public TwitterMessageParam[] TwitterMessageParams
    {
      [Token(Token = "0x60069A9"), Address(RVA = "0x305BA0", Offset = "0x3049A0", VA = "0x10305BA0")] get
      {
        return (TwitterMessageParam[]) null;
      }
    }

    [Token(Token = "0x17000B51")]
    public FilterRuneParam[] FilterRuneParams
    {
      [Token(Token = "0x60069AA"), Address(RVA = "0x349190", Offset = "0x347F90", VA = "0x10349190")] get
      {
        return (FilterRuneParam[]) null;
      }
    }

    [Token(Token = "0x17000B52")]
    public FilterUnitParam[] FilterUnitParams
    {
      [Token(Token = "0x60069AB"), Address(RVA = "0x2BA8C0", Offset = "0x2B96C0", VA = "0x102BA8C0")] get
      {
        return (FilterUnitParam[]) null;
      }
    }

    [Token(Token = "0x17000B53")]
    public FilterArtifactParam[] FilterArtifactParams
    {
      [Token(Token = "0x60069AC"), Address(RVA = "0x32ECE0", Offset = "0x32DAE0", VA = "0x1032ECE0")] get
      {
        return (FilterArtifactParam[]) null;
      }
    }

    [Token(Token = "0x17000B54")]
    public List<SortArtifactParam> SortArtifactParams
    {
      [Token(Token = "0x60069AD"), Address(RVA = "0x349570", Offset = "0x348370", VA = "0x10349570")] get
      {
        return (List<SortArtifactParam>) null;
      }
    }

    [Token(Token = "0x17000B55")]
    public SortRuneParam[] SortRuneParams
    {
      [Token(Token = "0x60069AE"), Address(RVA = "0x349580", Offset = "0x348380", VA = "0x10349580")] get
      {
        return (SortRuneParam[]) null;
      }
    }

    [Token(Token = "0x17000B56")]
    public List<SRPG.RuneMaterial> RuneMaterial
    {
      [Token(Token = "0x60069AF"), Address(RVA = "0x349440", Offset = "0x348240", VA = "0x10349440")] get
      {
        return (List<SRPG.RuneMaterial>) null;
      }
    }

    [Token(Token = "0x17000B57")]
    public List<RuneDedicatedCostParam> RuneDedicatedCostParams
    {
      [Token(Token = "0x60069B0"), Address(RVA = "0x349430", Offset = "0x348230", VA = "0x10349430")] get
      {
        return (List<RuneDedicatedCostParam>) null;
      }
    }

    [Token(Token = "0x17000B58")]
    public List<JukeBoxParam> JukeBoxParams
    {
      [Token(Token = "0x60069B1"), Address(RVA = "0x349330", Offset = "0x348130", VA = "0x10349330")] get
      {
        return (List<JukeBoxParam>) null;
      }
    }

    [Token(Token = "0x17000B59")]
    public List<JukeBoxSectionParam> JukeBoxSectionParams
    {
      [Token(Token = "0x60069B2"), Address(RVA = "0x349340", Offset = "0x348140", VA = "0x10349340")] get
      {
        return (List<JukeBoxSectionParam>) null;
      }
    }

    [Token(Token = "0x17000B5A")]
    public AutoRepeatQuestBoxParam[] AutoRepeatQuestBoxParams
    {
      [Token(Token = "0x60069B3"), Address(RVA = "0x349030", Offset = "0x347E30", VA = "0x10349030")] get
      {
        return (AutoRepeatQuestBoxParam[]) null;
      }
    }

    [Token(Token = "0x17000B5B")]
    public GuildAttendParam[] GuildAttendParams
    {
      [Token(Token = "0x60069B4"), Address(RVA = "0x349250", Offset = "0x348050", VA = "0x10349250")] get
      {
        return (GuildAttendParam[]) null;
      }
    }

    [Token(Token = "0x17000B5C")]
    public List<GuildAttendRewardParam> GuildAttendRewardParams
    {
      [Token(Token = "0x60069B5"), Address(RVA = "0x305B90", Offset = "0x304990", VA = "0x10305B90")] get
      {
        return (List<GuildAttendRewardParam>) null;
      }
    }

    [Token(Token = "0x17000B5D")]
    public GuildRoleBonusParam[] GuildRoleBonusParams
    {
      [Token(Token = "0x60069B6"), Address(RVA = "0x305B80", Offset = "0x304980", VA = "0x10305B80")] get
      {
        return (GuildRoleBonusParam[]) null;
      }
    }

    [Token(Token = "0x17000B5E")]
    public List<GuildRoleBonusRewardParam> GuildRoleBonusRewardParams
    {
      [Token(Token = "0x60069B7"), Address(RVA = "0x349260", Offset = "0x348060", VA = "0x10349260")] get
      {
        return (List<GuildRoleBonusRewardParam>) null;
      }
    }

    [Token(Token = "0x17000B5F")]
    public Dictionary<string, ResetCostParam> ResetCostParams
    {
      [Token(Token = "0x60069B8"), Address(RVA = "0x3493D0", Offset = "0x3481D0", VA = "0x103493D0")] get
      {
        return (Dictionary<string, ResetCostParam>) null;
      }
    }

    [Token(Token = "0x17000B60")]
    public GuildSearchFilterParam[] GuildSearchFilterParams
    {
      [Token(Token = "0x60069B9"), Address(RVA = "0x349270", Offset = "0x348070", VA = "0x10349270")] get
      {
        return (GuildSearchFilterParam[]) null;
      }
    }

    [Token(Token = "0x17000B61")]
    public List<ReplaceSprite> RepraseSprite
    {
      [Token(Token = "0x60069BA"), Address(RVA = "0x3493C0", Offset = "0x3481C0", VA = "0x103493C0")] get
      {
        return (List<ReplaceSprite>) null;
      }
    }

    [Token(Token = "0x17000B62")]
    public List<ExternalVideoLinkParam> ExternalVideoLinkParams
    {
      [Token(Token = "0x60069BB"), Address(RVA = "0x349180", Offset = "0x347F80", VA = "0x10349180")] get
      {
        return (List<ExternalVideoLinkParam>) null;
      }
    }

    [Token(Token = "0x17000B63")]
    public List<BondGroupParam> BondGroupParams
    {
      [Token(Token = "0x60069BC"), Address(RVA = "0x349090", Offset = "0x347E90", VA = "0x10349090")] get
      {
        return (List<BondGroupParam>) null;
      }
    }

    [Token(Token = "0x17000B64")]
    public List<BondGroupBuffParam> BondGroupBuffParams
    {
      [Token(Token = "0x60069BD"), Address(RVA = "0x349080", Offset = "0x347E80", VA = "0x10349080")] get
      {
        return (List<BondGroupBuffParam>) null;
      }
    }

    [Token(Token = "0x17000B65")]
    public List<BondPieceParam> BondPieceParams
    {
      [Token(Token = "0x60069BE"), Address(RVA = "0x3490B0", Offset = "0x347EB0", VA = "0x103490B0")] get
      {
        return (List<BondPieceParam>) null;
      }
    }

    [Token(Token = "0x17000B66")]
    public List<BondSubPieceParam> BondSubPieceParams
    {
      [Token(Token = "0x60069BF"), Address(RVA = "0x3490D0", Offset = "0x347ED0", VA = "0x103490D0")] get
      {
        return (List<BondSubPieceParam>) null;
      }
    }

    [Token(Token = "0x17000B67")]
    public List<BondRecipeParam> BondRecipeParams
    {
      [Token(Token = "0x60069C0"), Address(RVA = "0x3490C0", Offset = "0x347EC0", VA = "0x103490C0")] get
      {
        return (List<BondRecipeParam>) null;
      }
    }

    [Token(Token = "0x17000B68")]
    public List<BondMissionParam> BondMissionParams
    {
      [Token(Token = "0x60069C1"), Address(RVA = "0x3490A0", Offset = "0x347EA0", VA = "0x103490A0")] get
      {
        return (List<BondMissionParam>) null;
      }
    }

    [Token(Token = "0x17000B69")]
    public List<TobiraEnhanceMaxItemParam> TobiraEnhanceMaxItemParams
    {
      [Token(Token = "0x60069C2"), Address(RVA = "0x3495A0", Offset = "0x3483A0", VA = "0x103495A0")] get
      {
        return (List<TobiraEnhanceMaxItemParam>) null;
      }
    }

    [Token(Token = "0x17000B6A")]
    public List<SkillBuffEffectParam> SkillBuffEffectParams
    {
      [Token(Token = "0x60069C3"), Address(RVA = "0x349530", Offset = "0x348330", VA = "0x10349530")] get
      {
        return (List<SkillBuffEffectParam>) null;
      }
    }

    [Token(Token = "0x17000B6B")]
    public List<MasteryRewardParam> MasteryRewardParams
    {
      [Token(Token = "0x60069C4"), Address(RVA = "0x3493A0", Offset = "0x3481A0", VA = "0x103493A0")] get
      {
        return (List<MasteryRewardParam>) null;
      }
    }

    [Token(Token = "0x17000B6C")]
    public List<CrystalStatusLimitParam> GetCrystalStatusLimitParamList
    {
      [Token(Token = "0x60069C5"), Address(RVA = "0x349200", Offset = "0x348000", VA = "0x10349200")] get
      {
        return (List<CrystalStatusLimitParam>) null;
      }
    }

    [Token(Token = "0x17000B6D")]
    public List<CrystalSaleParam> GetCrystalSaleParamList
    {
      [Token(Token = "0x60069C6"), Address(RVA = "0x3491D0", Offset = "0x347FD0", VA = "0x103491D0")] get
      {
        return (List<CrystalSaleParam>) null;
      }
    }

    [Token(Token = "0x17000B6E")]
    public List<CrystalUpgradeParam> GetCrystalUpgradeParamList
    {
      [Token(Token = "0x60069C7"), Address(RVA = "0x349210", Offset = "0x348010", VA = "0x10349210")] get
      {
        return (List<CrystalUpgradeParam>) null;
      }
    }

    [Token(Token = "0x17000B6F")]
    public List<CrystalSortParam> GetCrystalSortParamList
    {
      [Token(Token = "0x60069C8"), Address(RVA = "0x3491F0", Offset = "0x347FF0", VA = "0x103491F0")] get
      {
        return (List<CrystalSortParam>) null;
      }
    }

    [Token(Token = "0x17000B70")]
    public List<CrystalFilterParam> GetCrystalFilterParamList
    {
      [Token(Token = "0x60069C9"), Address(RVA = "0x3491A0", Offset = "0x347FA0", VA = "0x103491A0")] get
      {
        return (List<CrystalFilterParam>) null;
      }
    }

    [Token(Token = "0x17000B71")]
    public List<CrystalSetBonusFilterParam> GetCrystalSetBonusFilterParamList
    {
      [Token(Token = "0x60069CA"), Address(RVA = "0x3491E0", Offset = "0x347FE0", VA = "0x103491E0")] get
      {
        return (List<CrystalSetBonusFilterParam>) null;
      }
    }

    [Token(Token = "0x17000B72")]
    public List<CrystalRecommendParam> GetCrystalRecommendParamList
    {
      [Token(Token = "0x60069CB"), Address(RVA = "0x3491B0", Offset = "0x347FB0", VA = "0x103491B0")] get
      {
        return (List<CrystalRecommendParam>) null;
      }
    }

    [Token(Token = "0x60069CC")]
    [Address(RVA = "0x33CE90", Offset = "0x33BC90", VA = "0x1033CE90")]
    public List<CrystalAddLimitParam> GetCrystalAddLimitParamList()
    {
      return (List<CrystalAddLimitParam>) null;
    }

    [Token(Token = "0x17000B73")]
    public List<ArtifactStoneEffectParam> ArtifactStoneEffectParamList
    {
      [Token(Token = "0x60069CD"), Address(RVA = "0x349010", Offset = "0x347E10", VA = "0x10349010")] get
      {
        return (List<ArtifactStoneEffectParam>) null;
      }
    }

    [Token(Token = "0x17000B74")]
    public List<CrystalReplaceFilterParam> GetCrystalReplaceFilterParamList
    {
      [Token(Token = "0x60069CE"), Address(RVA = "0x3491C0", Offset = "0x347FC0", VA = "0x103491C0")] get
      {
        return (List<CrystalReplaceFilterParam>) null;
      }
    }

    [Token(Token = "0x17000B75")]
    public bool Loaded
    {
      [Token(Token = "0x60069CF"), Address(RVA = "0x349380", Offset = "0x348180", VA = "0x10349380")] get
      {
        return new bool();
      }
      [Token(Token = "0x60069D0"), Address(RVA = "0x349640", Offset = "0x348440", VA = "0x10349640")] set
      {
      }
    }

    [Token(Token = "0x17000B76")]
    public FixParam FixParam
    {
      [Token(Token = "0x60069D1"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (FixParam) null;
      }
    }

    [Token(Token = "0x17000B77")]
    public FixArtifactParam FixArtifactParam
    {
      [Token(Token = "0x60069D2"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return (FixArtifactParam) null;
      }
    }

    [Token(Token = "0x17000B78")]
    public LocalNotificationParam LocalNotificationParam
    {
      [Token(Token = "0x60069D3"), Address(RVA = "0x349390", Offset = "0x348190", VA = "0x10349390")] get
      {
        return (LocalNotificationParam) null;
      }
    }

    [Token(Token = "0x17000B79")]
    public List<ItemParam> Items
    {
      [Token(Token = "0x60069D4"), Address(RVA = "0x3492D0", Offset = "0x3480D0", VA = "0x103492D0")] get
      {
        return (List<ItemParam>) null;
      }
    }

    [Token(Token = "0x17000B7A")]
    public JobSetParam[] JobSets
    {
      [Token(Token = "0x60069D5"), Address(RVA = "0x3492E0", Offset = "0x3480E0", VA = "0x103492E0")] get
      {
        return (JobSetParam[]) null;
      }
    }

    [Token(Token = "0x17000B7B")]
    public List<ArtifactParam> Artifacts
    {
      [Token(Token = "0x60069D6"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (List<ArtifactParam>) null;
      }
    }

    [Token(Token = "0x17000B7C")]
    public List<CollaboSkillParam> CollaboSkills
    {
      [Token(Token = "0x60069D7"), Address(RVA = "0x349120", Offset = "0x347F20", VA = "0x10349120")] get
      {
        return (List<CollaboSkillParam>) null;
      }
    }

    [Token(Token = "0x60069D8")]
    [Address(RVA = "0x3301C0", Offset = "0x32EFC0", VA = "0x103301C0")]
    private void CreateTrophyDict()
    {
    }

    [Token(Token = "0x60069D9")]
    [Address(RVA = "0x32ED80", Offset = "0x32DB80", VA = "0x1032ED80")]
    private void AddUnitToItem()
    {
    }

    [Token(Token = "0x60069DA")]
    [Address(RVA = "0x348A00", Offset = "0x347800", VA = "0x10348A00")]
    public void SetDeserializeTime(DateTime now)
    {
    }

    [Token(Token = "0x60069DB")]
    [Address(RVA = "0x338880", Offset = "0x337680", VA = "0x10338880")]
    public bool Deserialize(JSON_MasterParam json) => new bool();

    [Token(Token = "0x60069DC")]
    [Address(RVA = "0x32F020", Offset = "0x32DE20", VA = "0x1032F020")]
    public void CacheReferences()
    {
    }

    [Token(Token = "0x60069DD")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void DebugLogError(string bufs)
    {
    }

    [Token(Token = "0x60069DE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void DumpLoadedLog()
    {
    }

    [Token(Token = "0x60069DF")]
    [Address(RVA = "0x33AF00", Offset = "0x339D00", VA = "0x1033AF00")]
    public UnitParam[] GetAllUnits() => (UnitParam[]) null;

    [Token(Token = "0x60069E0")]
    [Address(RVA = "0x32F4D0", Offset = "0x32E2D0", VA = "0x1032F4D0")]
    public bool ContainsUnitID(string key) => new bool();

    [Token(Token = "0x60069E1")]
    [Address(RVA = "0x346DC0", Offset = "0x345BC0", VA = "0x10346DC0")]
    public UnitParam GetUnitParam(string key) => (UnitParam) null;

    [Token(Token = "0x60069E2")]
    [Address(RVA = "0x346790", Offset = "0x345590", VA = "0x10346790")]
    public Dictionary<string, UnitJobOverwriteParam> GetUnitJobOverwriteParamsForUnit(
      string unit_iname)
    {
      return (Dictionary<string, UnitJobOverwriteParam>) null;
    }

    [Token(Token = "0x60069E3")]
    [Address(RVA = "0x33BAA0", Offset = "0x33A8A0", VA = "0x1033BAA0")]
    public BuffEffectParam GetBuffEffectParam(string key) => (BuffEffectParam) null;

    [Token(Token = "0x60069E4")]
    [Address(RVA = "0x33CCB0", Offset = "0x33BAB0", VA = "0x1033CCB0")]
    public CondEffectParam GetCondEffectParam(string key) => (CondEffectParam) null;

    [Token(Token = "0x60069E5")]
    [Address(RVA = "0x32F430", Offset = "0x32E230", VA = "0x1032F430")]
    public bool ContainsAbilityID(string key) => new bool();

    [Token(Token = "0x60069E6")]
    [Address(RVA = "0x339BA0", Offset = "0x3389A0", VA = "0x10339BA0")]
    public AbilityParam GetAbilityParam(string key) => (AbilityParam) null;

    [Token(Token = "0x60069E7")]
    [Address(RVA = "0x33FB20", Offset = "0x33E920", VA = "0x1033FB20")]
    public ItemParam GetItemParam(string key) => (ItemParam) null;

    [Token(Token = "0x60069E8")]
    [Address(RVA = "0x33FC30", Offset = "0x33EA30", VA = "0x1033FC30")]
    public ItemParam GetItemParam(string key, bool showLogError) => (ItemParam) null;

    [Token(Token = "0x60069E9")]
    [Address(RVA = "0x33B1E0", Offset = "0x339FE0", VA = "0x1033B1E0")]
    public ArtifactParam GetArtifactParam(string key) => (ArtifactParam) null;

    [Token(Token = "0x60069EA")]
    [Address(RVA = "0x33B2F0", Offset = "0x33A0F0", VA = "0x1033B2F0")]
    public ArtifactParam GetArtifactParam(string key, bool showLogError) => (ArtifactParam) null;

    [Token(Token = "0x60069EB")]
    [Address(RVA = "0x33B130", Offset = "0x339F30", VA = "0x1033B130")]
    public bool GetArtifactMaxNum(ArtifactParam param) => new bool();

    [Token(Token = "0x60069EC")]
    [Address(RVA = "0x3477D0", Offset = "0x3465D0", VA = "0x103477D0")]
    public WeaponParam GetWeaponParam(string key) => (WeaponParam) null;

    [Token(Token = "0x60069ED")]
    [Address(RVA = "0x342120", Offset = "0x340F20", VA = "0x10342120")]
    public RecipeParam GetRecipeParam(string key) => (RecipeParam) null;

    [Token(Token = "0x60069EE")]
    [Address(RVA = "0x33FD50", Offset = "0x33EB50", VA = "0x1033FD50")]
    public JobParam GetJobParam(string key) => (JobParam) null;

    [Token(Token = "0x60069EF")]
    [Address(RVA = "0x33AD60", Offset = "0x339B60", VA = "0x1033AD60")]
    public JobParam[] GetAllJobs() => (JobParam[]) null;

    [Token(Token = "0x60069F0")]
    [Address(RVA = "0x33CFE0", Offset = "0x33BDE0", VA = "0x1033CFE0")]
    public List<CrystalParam> GetCrystalParamList() => (List<CrystalParam>) null;

    [Token(Token = "0x60069F1")]
    [Address(RVA = "0x33D0A0", Offset = "0x33BEA0", VA = "0x1033D0A0")]
    public CrystalParam GetCrystalParam(string key) => (CrystalParam) null;

    [Token(Token = "0x60069F2")]
    [Address(RVA = "0x33D000", Offset = "0x33BE00", VA = "0x1033D000")]
    public CrystalParam GetCrystalParam(string key, bool showLogError) => (CrystalParam) null;

    [Token(Token = "0x60069F3")]
    [Address(RVA = "0x33D4C0", Offset = "0x33C2C0", VA = "0x1033D4C0")]
    public List<CrystalSetBonusParam> GetCrystalSetBonusParamList()
    {
      return (List<CrystalSetBonusParam>) null;
    }

    [Token(Token = "0x60069F4")]
    [Address(RVA = "0x342060", Offset = "0x340E60", VA = "0x10342060")]
    public List<CrystalSetBonusParam> GetReccomendCrystalSetBonus(string main_crystal_iname)
    {
      return (List<CrystalSetBonusParam>) null;
    }

    [Token(Token = "0x60069F5")]
    [Address(RVA = "0x33DEC0", Offset = "0x33CCC0", VA = "0x1033DEC0")]
    public List<CrystalSetBonusParam> GetEnableCrystalSetBonus(List<CrystalData> set_crystal_datas)
    {
      return (List<CrystalSetBonusParam>) null;
    }

    [Token(Token = "0x60069F6")]
    [Address(RVA = "0x33D200", Offset = "0x33C000", VA = "0x1033D200")]
    public List<BuffEffectParam> GetCrystalSetBonusBuffParam(List<CrystalData> _datas)
    {
      return (List<BuffEffectParam>) null;
    }

    [Token(Token = "0x60069F7")]
    [Address(RVA = "0x33D4D0", Offset = "0x33C2D0", VA = "0x1033D4D0")]
    public int GetCrystalStatusLimit(ParamTypes type) => new int();

    [Token(Token = "0x60069F8")]
    [Address(RVA = "0x33D2F0", Offset = "0x33C0F0", VA = "0x1033D2F0")]
    public List<CrystalSetBonusParam> GetCrystalSetBonusByCrystalId(
      string crystal_iname,
      bool is_main = false,
      bool is_sub = false)
    {
      return (List<CrystalSetBonusParam>) null;
    }

    [Token(Token = "0x60069F9")]
    [Address(RVA = "0x348510", Offset = "0x347310", VA = "0x10348510")]
    public bool IsSetBonusExist(string crystal_iname, bool is_main = false, bool is_sub = false)
    {
      return new bool();
    }

    [Token(Token = "0x60069FA")]
    [Address(RVA = "0x3445A0", Offset = "0x3433A0", VA = "0x103445A0")]
    public List<CrystalSetBonusParam> GetSetBonusActivatePossible(List<string> crystal_inames)
    {
      return (List<CrystalSetBonusParam>) null;
    }

    [Token(Token = "0x60069FB")]
    [Address(RVA = "0x344690", Offset = "0x343490", VA = "0x10344690")]
    public List<CrystalSetBonusParam> GetSetBonusBySubCrystals(List<string> _sub_crystal_inames)
    {
      return (List<CrystalSetBonusParam>) null;
    }

    [Token(Token = "0x60069FC")]
    [Address(RVA = "0x33D140", Offset = "0x33BF40", VA = "0x1033D140")]
    public CrystalSaleParam GetCrystalSaleParam(string iname) => (CrystalSaleParam) null;

    [Token(Token = "0x60069FD")]
    [Address(RVA = "0x33D5B0", Offset = "0x33C3B0", VA = "0x1033D5B0")]
    public CrystalUpgradeParam GetCrystalUpgradeParamByRank(int rank) => (CrystalUpgradeParam) null;

    [Token(Token = "0x60069FE")]
    [Address(RVA = "0x33CDD0", Offset = "0x33BBD0", VA = "0x1033CDD0")]
    public CrystalAddLimitParam GetCrystalAddLimitParamList(string iname)
    {
      return (CrystalAddLimitParam) null;
    }

    [Token(Token = "0x60069FF")]
    [Address(RVA = "0x33CEA0", Offset = "0x33BCA0", VA = "0x1033CEA0")]
    public List<CrystalAddLimitStatus> GetCrystalAddLimitStatus(string iname)
    {
      return (List<CrystalAddLimitStatus>) null;
    }

    [Token(Token = "0x6006A00")]
    [Address(RVA = "0x348410", Offset = "0x347210", VA = "0x10348410")]
    public bool IsSaleSettingEnable() => new bool();

    [Token(Token = "0x6006A01")]
    [Address(RVA = "0x33AF60", Offset = "0x339D60", VA = "0x1033AF60")]
    public QuestClearUnlockUnitDataParam[] GetAllUnlockUnitDatas()
    {
      return (QuestClearUnlockUnitDataParam[]) null;
    }

    [Token(Token = "0x6006A02")]
    [Address(RVA = "0x347220", Offset = "0x346020", VA = "0x10347220")]
    public QuestClearUnlockUnitDataParam GetUnlockUnitData(string key)
    {
      return (QuestClearUnlockUnitDataParam) null;
    }

    [Token(Token = "0x6006A03")]
    [Address(RVA = "0x347150", Offset = "0x345F50", VA = "0x10347150")]
    public List<QuestClearUnlockUnitDataParam> GetUnlockUnitDataUid(string _unit)
    {
      return (List<QuestClearUnlockUnitDataParam>) null;
    }

    [Token(Token = "0x6006A04")]
    [Address(RVA = "0x33C400", Offset = "0x33B200", VA = "0x1033C400")]
    public CollaboSkillParam GetCollaboSkillData(string unit_iname) => (CollaboSkillParam) null;

    [Token(Token = "0x6006A05")]
    [Address(RVA = "0x3461E0", Offset = "0x344FE0", VA = "0x103461E0")]
    public TrickParam GetTrickParam(string iname) => (TrickParam) null;

    [Token(Token = "0x6006A06")]
    [Address(RVA = "0x33B950", Offset = "0x33A750", VA = "0x1033B950")]
    public BreakObjParam GetBreakObjParam(string iname) => (BreakObjParam) null;

    [Token(Token = "0x6006A07")]
    [Address(RVA = "0x3478E0", Offset = "0x3466E0", VA = "0x103478E0")]
    public WeatherParam GetWeatherParam(string iname) => (WeatherParam) null;

    [Token(Token = "0x6006A08")]
    [Address(RVA = "0x347A30", Offset = "0x346830", VA = "0x10347A30")]
    public List<WeatherReleaseParam> GetWeatherResetParam(string skill_iname)
    {
      return (List<WeatherReleaseParam>) null;
    }

    [Token(Token = "0x6006A09")]
    [Address(RVA = "0x33D850", Offset = "0x33C650", VA = "0x1033D850")]
    public DynamicTransformUnitParam GetDynamicTransformUnitParam(string iname)
    {
      return (DynamicTransformUnitParam) null;
    }

    [Token(Token = "0x6006A0A")]
    [Address(RVA = "0x345360", Offset = "0x344160", VA = "0x10345360")]
    public SkillMotionParam GetSkillMotionParam(string iname) => (SkillMotionParam) null;

    [Token(Token = "0x6006A0B")]
    [Address(RVA = "0x33D700", Offset = "0x33C500", VA = "0x1033D700")]
    public DependStateSpcEffParam GetDependStateSpcEffParam(string iname)
    {
      return (DependStateSpcEffParam) null;
    }

    [Token(Token = "0x6006A0C")]
    [Address(RVA = "0x33EB00", Offset = "0x33D900", VA = "0x1033EB00")]
    public GenesisParam GetGenesisParam() => (GenesisParam) null;

    [Token(Token = "0x6006A0D")]
    [Address(RVA = "0x345E30", Offset = "0x344C30", VA = "0x10345E30")]
    public TobiraParam GetTobiraParam(string unit_iname, TobiraParam.Category category)
    {
      return (TobiraParam) null;
    }

    [Token(Token = "0x6006A0E")]
    [Address(RVA = "0x345CC0", Offset = "0x344AC0", VA = "0x10345CC0")]
    public TobiraParam[] GetTobiraListForUnit(string unit_iname) => (TobiraParam[]) null;

    [Token(Token = "0x6006A0F")]
    [Address(RVA = "0x347E00", Offset = "0x346C00", VA = "0x10347E00")]
    public bool IsExistsTobiraUnlockParamInMaster(string unit_iname) => new bool();

    [Token(Token = "0x6006A10")]
    [Address(RVA = "0x345B00", Offset = "0x344900", VA = "0x10345B00")]
    public TobiraConditionParam[] GetTobiraConditionsForUnit(
      string unit_iname,
      TobiraParam.Category category)
    {
      return (TobiraConditionParam[]) null;
    }

    [Token(Token = "0x6006A11")]
    [Address(RVA = "0x345990", Offset = "0x344790", VA = "0x10345990")]
    public Dictionary<TobiraParam.Category, TobiraConditionParam[]> GetTobiraConditionsForUnit(
      string unit_iname)
    {
      return (Dictionary<TobiraParam.Category, TobiraConditionParam[]>) null;
    }

    [Token(Token = "0x6006A12")]
    [Address(RVA = "0x345F40", Offset = "0x344D40", VA = "0x10345F40")]
    public TobiraRecipeParam GetTobiraRecipe(
      string unit_iname,
      TobiraParam.Category category,
      int level)
    {
      return (TobiraRecipeParam) null;
    }

    [Token(Token = "0x6006A13")]
    [Address(RVA = "0x346120", Offset = "0x344F20", VA = "0x10346120")]
    public TobiraRecipeParam GetTobiraRecipe(string recipe_iname, int level)
    {
      return (TobiraRecipeParam) null;
    }

    [Token(Token = "0x6006A14")]
    [Address(RVA = "0x33FE60", Offset = "0x33EC60", VA = "0x1033FE60")]
    public JobSetParam GetJobSetParam(string key) => (JobSetParam) null;

    [Token(Token = "0x6006A15")]
    [Address(RVA = "0x33C300", Offset = "0x33B100", VA = "0x1033C300")]
    public JobSetParam[] GetClassChangeJobSetParam(string key) => (JobSetParam[]) null;

    [Token(Token = "0x6006A16")]
    [Address(RVA = "0x33EDD0", Offset = "0x33DBD0", VA = "0x1033EDD0")]
    public GrowParam GetGrowParam(string key) => (GrowParam) null;

    [Token(Token = "0x6006A17")]
    [Address(RVA = "0x3399D0", Offset = "0x3387D0", VA = "0x103399D0")]
    public AIParam GetAIParam(string key) => (AIParam) null;

    [Token(Token = "0x6006A18")]
    [Address(RVA = "0x33ECB0", Offset = "0x33DAB0", VA = "0x1033ECB0")]
    public GeoParam GetGeoParam(string key) => (GeoParam) null;

    [Token(Token = "0x6006A19")]
    [Address(RVA = "0x341FE0", Offset = "0x340DE0", VA = "0x10341FE0")]
    public RarityParam GetRarityParam(int rarity) => (RarityParam) null;

    [Token(Token = "0x6006A1A")]
    [Address(RVA = "0x344920", Offset = "0x343720", VA = "0x10344920")]
    public ShopParam GetShopParam(EShopType type) => (ShopParam) null;

    [Token(Token = "0x6006A1B")]
    [Address(RVA = "0x344D30", Offset = "0x343B30", VA = "0x10344D30")]
    public int GetShopType(string iname) => new int();

    [Token(Token = "0x6006A1C")]
    [Address(RVA = "0x346ED0", Offset = "0x345CD0", VA = "0x10346ED0")]
    public List<UnitPieceShopGroupParam> GetUnitPieceShopGroups()
    {
      return (List<UnitPieceShopGroupParam>) null;
    }

    [Token(Token = "0x6006A1D")]
    [Address(RVA = "0x3408A0", Offset = "0x33F6A0", VA = "0x103408A0")]
    public PlayerParam GetPlayerParam(int lv) => (PlayerParam) null;

    [Token(Token = "0x6006A1E")]
    [Address(RVA = "0x339AE0", Offset = "0x3388E0", VA = "0x10339AE0")]
    public int GetAbilityNextGold(int rank) => new int();

    [Token(Token = "0x6006A1F")]
    [Address(RVA = "0x33B780", Offset = "0x33A580", VA = "0x1033B780")]
    public int GetAwakeNeedPieces(int awakeLv) => new int();

    [Token(Token = "0x6006A20")]
    [Address(RVA = "0x346950", Offset = "0x345750", VA = "0x10346950")]
    public int GetUnitNextExp(int lv) => new int();

    [Token(Token = "0x6006A21")]
    [Address(RVA = "0x346840", Offset = "0x345640", VA = "0x10346840")]
    public int GetUnitLevelExp(int lv) => new int();

    [Token(Token = "0x6006A22")]
    [Address(RVA = "0x32F1A0", Offset = "0x32DFA0", VA = "0x1032F1A0")]
    public int CalcUnitLevel(int totalExp, int levelCap) => new int();

    [Token(Token = "0x6006A23")]
    [Address(RVA = "0x346930", Offset = "0x345730", VA = "0x10346930")]
    public int GetUnitMaxLevel() => new int();

    [Token(Token = "0x6006A24")]
    [Address(RVA = "0x3407E0", Offset = "0x33F5E0", VA = "0x103407E0")]
    public int GetPlayerNextExp(int lv) => new int();

    [Token(Token = "0x6006A25")]
    [Address(RVA = "0x3406F0", Offset = "0x33F4F0", VA = "0x103406F0")]
    public int GetPlayerLevelExp(int lv) => new int();

    [Token(Token = "0x6006A26")]
    [Address(RVA = "0x3406D0", Offset = "0x33F4D0", VA = "0x103406D0")]
    public int GetPlayerLevelCap() => new int();

    [Token(Token = "0x6006A27")]
    [Address(RVA = "0x3473F0", Offset = "0x3461F0", VA = "0x103473F0")]
    public int GetVipArenaResetCount(int rank) => new int();

    [Token(Token = "0x6006A28")]
    [Address(RVA = "0x347660", Offset = "0x346460", VA = "0x10347660")]
    public int GetVipRankNextPoint(int rank) => new int();

    [Token(Token = "0x6006A29")]
    [Address(RVA = "0x347710", Offset = "0x346510", VA = "0x10347710")]
    public int GetVipRankTotalNeedPoint(int rank) => new int();

    [Token(Token = "0x6006A2A")]
    [Address(RVA = "0x347550", Offset = "0x346350", VA = "0x10347550")]
    public int GetVipBuyStaminaLimit(int rank) => new int();

    [Token(Token = "0x6006A2B")]
    [Address(RVA = "0x3474A0", Offset = "0x3462A0", VA = "0x103474A0")]
    public int GetVipBuyGoldLimit(int rank) => new int();

    [Token(Token = "0x6006A2C")]
    [Address(RVA = "0x347600", Offset = "0x346400", VA = "0x10347600")]
    public int GetVipRankCap() => new int();

    [Token(Token = "0x17000B7D")]
    public TrophyCategoryParam[] TrophyCategories
    {
      [Token(Token = "0x6006A2D"), Address(RVA = "0x3495D0", Offset = "0x3483D0", VA = "0x103495D0")] get
      {
        return (TrophyCategoryParam[]) null;
      }
    }

    [Token(Token = "0x17000B7E")]
    public ChallengeCategoryParam[] ChallengeCategories
    {
      [Token(Token = "0x6006A2E"), Address(RVA = "0x3490E0", Offset = "0x347EE0", VA = "0x103490E0")] get
      {
        return (ChallengeCategoryParam[]) null;
      }
    }

    [Token(Token = "0x17000B7F")]
    public TrophyParam[] Trophies
    {
      [Token(Token = "0x6006A2F"), Address(RVA = "0x3495C0", Offset = "0x3483C0", VA = "0x103495C0")] get
      {
        return (TrophyParam[]) null;
      }
    }

    [Token(Token = "0x6006A30")]
    [Address(RVA = "0x346330", Offset = "0x345130", VA = "0x10346330")]
    public TrophyObjective[] GetTrophiesOfType(TrophyConditionTypes type)
    {
      return (TrophyObjective[]) null;
    }

    [Token(Token = "0x6006A31")]
    [Address(RVA = "0x346390", Offset = "0x345190", VA = "0x10346390")]
    public TrophyParam GetTrophy(string iname) => (TrophyParam) null;

    [Token(Token = "0x6006A32")]
    [Address(RVA = "0x33F480", Offset = "0x33E280", VA = "0x1033F480")]
    public TrophyParam GetGuildTrophy(string iname) => (TrophyParam) null;

    [Token(Token = "0x17000B80")]
    public UnlockParam[] Unlocks
    {
      [Token(Token = "0x6006A33"), Address(RVA = "0x349630", Offset = "0x348430", VA = "0x10349630")] get
      {
        return (UnlockParam[]) null;
      }
    }

    [Token(Token = "0x6006A34")]
    [Address(RVA = "0x3470D0", Offset = "0x345ED0", VA = "0x103470D0")]
    public UnlockParam GetUnlockParam(string iname) => (UnlockParam) null;

    [Token(Token = "0x6006A35")]
    [Address(RVA = "0x339960", Offset = "0x338760", VA = "0x10339960")]
    public UnlockParam FindUnlockParam(UnlockTargets value) => (UnlockParam) null;

    [Token(Token = "0x6006A36")]
    [Address(RVA = "0x346A10", Offset = "0x345810", VA = "0x10346A10")]
    public UnitParam GetUnitParamForPiece(string key, bool doCheck = true) => (UnitParam) null;

    [Token(Token = "0x6006A37")]
    [Address(RVA = "0x346C00", Offset = "0x345A00", VA = "0x10346C00")]
    public List<UnitParam> GetUnitParamListForPieceOrSubpiece(string key, bool doCheck = true)
    {
      return (List<UnitParam>) null;
    }

    [Token(Token = "0x6006A38")]
    [Address(RVA = "0x33B040", Offset = "0x339E40", VA = "0x1033B040")]
    public OInt[] GetArtifactExpTable() => (OInt[]) null;

    [Token(Token = "0x6006A39")]
    [Address(RVA = "0x33B050", Offset = "0x339E50", VA = "0x1033B050")]
    public int GetArtifactExp(int level) => new int();

    [Token(Token = "0x6006A3A")]
    [Address(RVA = "0x348A20", Offset = "0x347820", VA = "0x10348A20")]
    public string TranslateMoviePath(string path) => (string) null;

    [Token(Token = "0x6006A3B")]
    [Address(RVA = "0x3458B0", Offset = "0x3446B0", VA = "0x103458B0")]
    public ArtifactParam GetSkinParamFromItemId(string itemId) => (ArtifactParam) null;

    [Token(Token = "0x6006A3C")]
    [Address(RVA = "0x348660", Offset = "0x347460", VA = "0x10348660")]
    public bool IsSkinItem(string itemId) => new bool();

    [Token(Token = "0x17000B81")]
    public BannerParam[] Banners
    {
      [Token(Token = "0x6006A3D"), Address(RVA = "0x349070", Offset = "0x347E70", VA = "0x10349070")] get
      {
        return (BannerParam[]) null;
      }
    }

    [Token(Token = "0x6006A3E")]
    [Address(RVA = "0x32F480", Offset = "0x32E280", VA = "0x1032F480")]
    public bool ContainsAwardID(string key) => new bool();

    [Token(Token = "0x6006A3F")]
    [Address(RVA = "0x33B840", Offset = "0x33A640", VA = "0x1033B840")]
    public AwardParam GetAwardParam(string key, bool showLogError = true) => (AwardParam) null;

    [Token(Token = "0x6006A40")]
    [Address(RVA = "0x33ABF0", Offset = "0x3399F0", VA = "0x1033ABF0")]
    public AwardParam[] GetAllAwards() => (AwardParam[]) null;

    [Token(Token = "0x6006A41")]
    [Address(RVA = "0x33ADC0", Offset = "0x339BC0", VA = "0x1033ADC0")]
    public LoginInfoParam[] GetAllLoginInfos() => (LoginInfoParam[]) null;

    [Token(Token = "0x6006A42")]
    [Address(RVA = "0x339EA0", Offset = "0x338CA0", VA = "0x10339EA0")]
    public LoginInfoParam[] GetActiveLoginInfos() => (LoginInfoParam[]) null;

    [Token(Token = "0x6006A43")]
    [Address(RVA = "0x3473A0", Offset = "0x3461A0", VA = "0x103473A0")]
    public VersusMatchingParam[] GetVersusMatchingParam() => (VersusMatchingParam[]) null;

    [Token(Token = "0x6006A44")]
    [Address(RVA = "0x347350", Offset = "0x346150", VA = "0x10347350")]
    public VersusMatchCondParam[] GetVersusMatchingCondition() => (VersusMatchCondParam[]) null;

    [Token(Token = "0x17000B82")]
    public OInt[] TowerRank
    {
      [Token(Token = "0x6006A45"), Address(RVA = "0x3495B0", Offset = "0x3483B0", VA = "0x103495B0")] get
      {
        return (OInt[]) null;
      }
    }

    [Token(Token = "0x6006A46")]
    [Address(RVA = "0x3405B0", Offset = "0x33F3B0", VA = "0x103405B0")]
    public OInt[] GetMultiPlayLimitUnitLv() => (OInt[]) null;

    [Token(Token = "0x6006A47")]
    [Address(RVA = "0x3305B0", Offset = "0x32F3B0", VA = "0x103305B0")]
    public bool Deserialize2(JSON_MasterParam json) => new bool();

    [Token(Token = "0x6006A48")]
    [Address(RVA = "0x33C550", Offset = "0x33B350", VA = "0x1033C550")]
    public ItemParam GetCommonEquip(ItemParam item_param, bool is_soul) => (ItemParam) null;

    [Token(Token = "0x6006A49")]
    [Address(RVA = "0x347F10", Offset = "0x346D10", VA = "0x10347F10")]
    public bool IsFriendPresentItemParamValid() => new bool();

    [Token(Token = "0x6006A4A")]
    [Address(RVA = "0x33EA30", Offset = "0x33D830", VA = "0x1033EA30")]
    public FriendPresentItemParam[] GetFriendPresentItemParams() => (FriendPresentItemParam[]) null;

    [Token(Token = "0x6006A4B")]
    [Address(RVA = "0x33E980", Offset = "0x33D780", VA = "0x1033E980")]
    public FriendPresentItemParam GetFriendPresentItemParam(string key)
    {
      return (FriendPresentItemParam) null;
    }

    [Token(Token = "0x6006A4C")]
    [Address(RVA = "0x348840", Offset = "0x347640", VA = "0x10348840")]
    public void MakeMapEffectHaveJobLists()
    {
    }

    [Token(Token = "0x6006A4D")]
    [Address(RVA = "0x347010", Offset = "0x345E10", VA = "0x10347010")]
    public UnitUnlockTimeParam[] GetUnitUnlockTimeParams() => (UnitUnlockTimeParam[]) null;

    [Token(Token = "0x6006A4E")]
    [Address(RVA = "0x346FA0", Offset = "0x345DA0", VA = "0x10346FA0")]
    public UnitUnlockTimeParam GetUnitUnlockTimeParam(string _key) => (UnitUnlockTimeParam) null;

    [Token(Token = "0x6006A4F")]
    [Address(RVA = "0x348740", Offset = "0x347540", VA = "0x10348740")]
    public bool IsUnlockableUnit(string _key, DateTime _time) => new bool();

    [Token(Token = "0x6006A50")]
    [Address(RVA = "0x346700", Offset = "0x345500", VA = "0x10346700")]
    public UnitGroupParam GetUnitGroup(string iname) => (UnitGroupParam) null;

    [Token(Token = "0x6006A51")]
    [Address(RVA = "0x33FCC0", Offset = "0x33EAC0", VA = "0x1033FCC0")]
    public JobGroupParam GetJobGroup(string iname) => (JobGroupParam) null;

    [Token(Token = "0x6006A52")]
    [Address(RVA = "0x33D670", Offset = "0x33C470", VA = "0x1033D670")]
    public CustomTargetParam GetCustomTarget(string iname) => (CustomTargetParam) null;

    [Token(Token = "0x6006A53")]
    [Address(RVA = "0x339400", Offset = "0x338200", VA = "0x10339400")]
    public List<SkillAbilityDeriveParam> FindSkillAbilityDeriveParamWithArtifact(
      string artifactIname)
    {
      return (List<SkillAbilityDeriveParam>) null;
    }

    [Token(Token = "0x6006A54")]
    [Address(RVA = "0x3388E0", Offset = "0x3376E0", VA = "0x103388E0")]
    public List<SkillAbilityDeriveParam> FindAditionalSkillAbilityDeriveParam(
      SkillAbilityDeriveParam skillAbilityDeriveParam,
      ESkillAbilityDeriveConds triggerType,
      string triggerIname)
    {
      return (List<SkillAbilityDeriveParam>) null;
    }

    [Token(Token = "0x6006A55")]
    [Address(RVA = "0x338C70", Offset = "0x337A70", VA = "0x10338C70")]
    public List<SkillAbilityDeriveParam> FindAditionalSkillAbilityDeriveParam(
      SkillAbilityDeriveParam skillAbilityDeriveParam)
    {
      return (List<SkillAbilityDeriveParam>) null;
    }

    [Token(Token = "0x6006A56")]
    [Address(RVA = "0x32F710", Offset = "0x32E510", VA = "0x1032F710")]
    public Dictionary<string, SkillAbilityDeriveData> CreateSkillAbilityDeriveDataWithArtifacts(
      JobData[] jobData)
    {
      return (Dictionary<string, SkillAbilityDeriveData>) null;
    }

    [Token(Token = "0x6006A57")]
    [Address(RVA = "0x338EA0", Offset = "0x337CA0", VA = "0x10338EA0")]
    public List<SkillAbilityDeriveData> FindAllSkillAbilityDeriveDataWithArtifact(
      string artifactIname)
    {
      return (List<SkillAbilityDeriveData>) null;
    }

    [Token(Token = "0x6006A58")]
    [Address(RVA = "0x338890", Offset = "0x337690", VA = "0x10338890")]
    public bool ExistSkillAbilityDeriveDataWithArtifact(string artifactIname) => new bool();

    [Token(Token = "0x6006A59")]
    [Address(RVA = "0x32F9C0", Offset = "0x32E7C0", VA = "0x1032F9C0")]
    public SkillAbilityDeriveData CreateSkillAbilityDeriveDataWithArtifacts(string[] artifactInames)
    {
      return (SkillAbilityDeriveData) null;
    }

    [Token(Token = "0x6006A5A")]
    [Address(RVA = "0x3395D0", Offset = "0x3383D0", VA = "0x103395D0")]
    public TowerScoreParam[] FindTowerScoreParam(string score_iname) => (TowerScoreParam[]) null;

    [Token(Token = "0x6006A5B")]
    [Address(RVA = "0x33EFD0", Offset = "0x33DDD0", VA = "0x1033EFD0")]
    public GuildEmblemParam GetGuildEmbleme(string iname) => (GuildEmblemParam) null;

    [Token(Token = "0x6006A5C")]
    [Address(RVA = "0x33F050", Offset = "0x33DE50", VA = "0x1033F050")]
    public GuildEmblemParam[] GetGuildEmblemes() => (GuildEmblemParam[]) null;

    [Token(Token = "0x6006A5D")]
    [Address(RVA = "0x3405C0", Offset = "0x33F3C0", VA = "0x103405C0")]
    public GuildEmblemParam[] GetNoConditionsGuildEmblemes() => (GuildEmblemParam[]) null;

    [Token(Token = "0x6006A5E")]
    [Address(RVA = "0x33F230", Offset = "0x33E030", VA = "0x1033F230")]
    public GuildFacilityParam GetGuildFacility(string iname) => (GuildFacilityParam) null;

    [Token(Token = "0x6006A5F")]
    [Address(RVA = "0x33F0A0", Offset = "0x33DEA0", VA = "0x1033F0A0")]
    public GuildFacilityParam GetGuildFacilityFromFacilityType(GuildFacilityParam.eFacilityType type)
    {
      return (GuildFacilityParam) null;
    }

    [Token(Token = "0x6006A60")]
    [Address(RVA = "0x33F220", Offset = "0x33E020", VA = "0x1033F220")]
    public GuildFacilityLvParam[] GetGuildFacilityLevelTable() => (GuildFacilityLvParam[]) null;

    [Token(Token = "0x6006A61")]
    [Address(RVA = "0x33EEE0", Offset = "0x33DCE0", VA = "0x1033EEE0")]
    public GuildAttendRewardParam GetGuildAttendRewardParam(string reward_id)
    {
      return (GuildAttendRewardParam) null;
    }

    [Token(Token = "0x6006A62")]
    [Address(RVA = "0x33F2B0", Offset = "0x33E0B0", VA = "0x1033F2B0")]
    public GuildRoleBonusRewardParam GetGuildRoleBonusRewardParam(string reward_id)
    {
      return (GuildRoleBonusRewardParam) null;
    }

    [Token(Token = "0x6006A63")]
    [Address(RVA = "0x33E4A0", Offset = "0x33D2A0", VA = "0x1033E4A0")]
    public List<GuildTrainingCampaign> GetEnableGuildTraingCampaign()
    {
      return (List<GuildTrainingCampaign>) null;
    }

    [Token(Token = "0x6006A64")]
    [Address(RVA = "0x33F3C0", Offset = "0x33E1C0", VA = "0x1033F3C0")]
    public GuildTrainingUnit GetGuildTrainingUnit(string unit_iname) => (GuildTrainingUnit) null;

    [Token(Token = "0x6006A65")]
    [Address(RVA = "0x33F3B0", Offset = "0x33E1B0", VA = "0x1033F3B0")]
    public List<GuildTrainingEnergyLimit> GetGuildTrainingEnergyLimits()
    {
      return (List<GuildTrainingEnergyLimit>) null;
    }

    [Token(Token = "0x6006A66")]
    [Address(RVA = "0x342240", Offset = "0x341040", VA = "0x10342240")]
    public RecommendArtifactParams GetRecommendedArtifactParams(
      UnitData unitData,
      bool isMasterOnly,
      int jobIndex = -1)
    {
      return (RecommendArtifactParams) null;
    }

    [Token(Token = "0x6006A67")]
    [Address(RVA = "0x33B470", Offset = "0x33A270", VA = "0x1033B470")]
    public List<ArtifactParam> GetArtifactsWithUnitUsableAbility(UnitData unitData, int jobIndex)
    {
      return (List<ArtifactParam>) null;
    }

    [Token(Token = "0x6006A68")]
    [Address(RVA = "0x33A8B0", Offset = "0x3396B0", VA = "0x1033A8B0")]
    public RaidPeriodParam GetActiveRaidPeriod(int begin_offset_hour = 0, int end_offset_hour = 0)
    {
      return (RaidPeriodParam) null;
    }

    [Token(Token = "0x6006A69")]
    [Address(RVA = "0x33A1E0", Offset = "0x338FE0", VA = "0x1033A1E0")]
    public RaidPeriodTimeParam GetActiveRaidPeriodTimeDay() => (RaidPeriodTimeParam) null;

    [Token(Token = "0x6006A6A")]
    [Address(RVA = "0x341B10", Offset = "0x340910", VA = "0x10341B10")]
    public RaidPeriodTimeScheduleParam GetRaidScheduleTime(out bool nowCheck)
    {
      return (RaidPeriodTimeScheduleParam) null;
    }

    [Token(Token = "0x6006A6B")]
    [Address(RVA = "0x341A70", Offset = "0x340870", VA = "0x10341A70")]
    public RaidManager.RaidScheduleType GetRaidScheduleStatus()
    {
      return new RaidManager.RaidScheduleType();
    }

    [Token(Token = "0x6006A6C")]
    [Address(RVA = "0x33A410", Offset = "0x339210", VA = "0x1033A410")]
    public RaidPeriodTimeScheduleParam GetActiveRaidPeriodTime()
    {
      return (RaidPeriodTimeScheduleParam) null;
    }

    [Token(Token = "0x6006A6D")]
    [Address(RVA = "0x341380", Offset = "0x340180", VA = "0x10341380")]
    public RaidAreaParam GetRaidArea(int area_id) => (RaidAreaParam) null;

    [Token(Token = "0x6006A6E")]
    [Address(RVA = "0x3411F0", Offset = "0x33FFF0", VA = "0x103411F0")]
    public RaidAreaParam GetRaidAreaByOrder(int period_id, int order) => (RaidAreaParam) null;

    [Token(Token = "0x6006A6F")]
    [Address(RVA = "0x3412B0", Offset = "0x3400B0", VA = "0x103412B0")]
    public int GetRaidAreaCount(int period_id) => new int();

    [Token(Token = "0x6006A70")]
    [Address(RVA = "0x341710", Offset = "0x340510", VA = "0x10341710")]
    public RaidBossParam GetRaidBoss(int boss_id) => (RaidBossParam) null;

    [Token(Token = "0x6006A71")]
    [Address(RVA = "0x341650", Offset = "0x340450", VA = "0x10341650")]
    public List<RaidBossParam> GetRaidBossAll(int period_id) => (List<RaidBossParam>) null;

    [Token(Token = "0x6006A72")]
    [Address(RVA = "0x341440", Offset = "0x340240", VA = "0x10341440")]
    public string GetRaidBeatReward(int beat_reward_id, int round) => (string) null;

    [Token(Token = "0x6006A73")]
    [Address(RVA = "0x341960", Offset = "0x340760", VA = "0x10341960")]
    public List<RaidReward> GetRaidRewardList(string reward_id) => (List<RaidReward>) null;

    [Token(Token = "0x6006A74")]
    [Address(RVA = "0x3418A0", Offset = "0x3406A0", VA = "0x103418A0")]
    public RaidPeriodParam GetRaidPeriod(int period_id) => (RaidPeriodParam) null;

    [Token(Token = "0x6006A75")]
    [Address(RVA = "0x341890", Offset = "0x340690", VA = "0x10341890")]
    public List<RaidPeriodTimeParam> GetRaidPeriodTime() => (List<RaidPeriodTimeParam>) null;

    [Token(Token = "0x6006A76")]
    [Address(RVA = "0x3417D0", Offset = "0x3405D0", VA = "0x103417D0")]
    public RaidCompleteRewardParam GetRaidCompleteReward(int comp_reward_id)
    {
      return (RaidCompleteRewardParam) null;
    }

    [Token(Token = "0x6006A77")]
    [Address(RVA = "0x33AA70", Offset = "0x339870", VA = "0x1033AA70")]
    public RaidPeriodParam GetActiveRaidRewardPeriod() => (RaidPeriodParam) null;

    [Token(Token = "0x6006A78")]
    [Address(RVA = "0x33AFC0", Offset = "0x339DC0", VA = "0x1033AFC0")]
    public List<ArenaRewardParam> GetArenaRewardParams() => (List<ArenaRewardParam>) null;

    [Token(Token = "0x6006A79")]
    [Address(RVA = "0x346EE0", Offset = "0x345CE0", VA = "0x10346EE0")]
    public UnitSameGroupParam GetUnitSameGroup(string unit_iname) => (UnitSameGroupParam) null;

    [Token(Token = "0x6006A7A")]
    [Address(RVA = "0x340400", Offset = "0x33F200", VA = "0x10340400")]
    public string GetMasteryRewardEmblem(int Rank) => (string) null;

    [Token(Token = "0x6006A7B")]
    [Address(RVA = "0x339220", Offset = "0x338020", VA = "0x10339220")]
    public MasteryRewardParam FindMasteryRewardParam(string target) => (MasteryRewardParam) null;

    [Token(Token = "0x6006A7C")]
    [Address(RVA = "0x33AE00", Offset = "0x339C00", VA = "0x1033AE00")]
    public List<UnitParam> GetAllPlayableUnitParams() => (List<UnitParam>) null;

    [Token(Token = "0x6006A7D")]
    [Address(RVA = "0x33DD90", Offset = "0x33CB90", VA = "0x1033DD90")]
    public CoinBuyUseBonusParam[] GetEnableCoinBuyUseBonusParams() => (CoinBuyUseBonusParam[]) null;

    [Token(Token = "0x6006A7E")]
    [Address(RVA = "0x339CB0", Offset = "0x338AB0", VA = "0x10339CB0")]
    public CoinBuyUseBonusParam GetActiveCoinBuyUseBonusParam(
      eCoinBuyUseBonusTrigger trigger,
      eCoinBuyUseBonusType type)
    {
      return (CoinBuyUseBonusParam) null;
    }

    [Token(Token = "0x6006A7F")]
    [Address(RVA = "0x339060", Offset = "0x337E60", VA = "0x10339060")]
    public CoinBuyUseBonusParam FindCoinBuyUseBonusParam(string iname)
    {
      return (CoinBuyUseBonusParam) null;
    }

    [Token(Token = "0x6006A80")]
    [Address(RVA = "0x3394F0", Offset = "0x3382F0", VA = "0x103394F0")]
    public SortRuneConditionParam FindSortRuneConditionParam(SortUtility.SortPrefsData prefsData)
    {
      return (SortRuneConditionParam) null;
    }

    [Token(Token = "0x6006A81")]
    [Address(RVA = "0x343510", Offset = "0x342310", VA = "0x10343510")]
    public RuneParam GetRuneParam(string iname) => (RuneParam) null;

    [Token(Token = "0x6006A82")]
    [Address(RVA = "0x343390", Offset = "0x342190", VA = "0x10343390")]
    public RuneParam GetRuneParamByItemId(string item_iname) => (RuneParam) null;

    [Token(Token = "0x6006A83")]
    [Address(RVA = "0x342B20", Offset = "0x341920", VA = "0x10342B20")]
    public RuneLotteryBaseState GetRuneLotteryBaseState(string iname)
    {
      return (RuneLotteryBaseState) null;
    }

    [Token(Token = "0x6006A84")]
    [Address(RVA = "0x343210", Offset = "0x342010", VA = "0x10343210")]
    public RuneLotteryEvoState GetRuneLotteryEvoState(string iname) => (RuneLotteryEvoState) null;

    [Token(Token = "0x6006A85")]
    [Address(RVA = "0x3432D0", Offset = "0x3420D0", VA = "0x103432D0")]
    public SRPG.RuneMaterial GetRuneMaterial(int rarity) => (SRPG.RuneMaterial) null;

    [Token(Token = "0x6006A86")]
    [Address(RVA = "0x342840", Offset = "0x341640", VA = "0x10342840")]
    public RuneCost GetRuneCost(string iname) => (RuneCost) null;

    [Token(Token = "0x6006A87")]
    [Address(RVA = "0x3444E0", Offset = "0x3432E0", VA = "0x103444E0")]
    public RuneSetEff GetRuneSetEff(int seteff_type) => (RuneSetEff) null;

    [Token(Token = "0x6006A88")]
    [Address(RVA = "0x32F520", Offset = "0x32E320", VA = "0x1032F520")]
    public Dictionary<string, RuneParam> CreateRuneParamTable_KeyItemIname()
    {
      return (Dictionary<string, RuneParam>) null;
    }

    [Token(Token = "0x6006A89")]
    [Address(RVA = "0x343150", Offset = "0x341F50", VA = "0x10343150")]
    public RuneLotteryEvoStatePack GetRuneLotteryEvoStatePack(string evo_state)
    {
      return (RuneLotteryEvoStatePack) null;
    }

    [Token(Token = "0x6006A8A")]
    [Address(RVA = "0x3429C0", Offset = "0x3417C0", VA = "0x103429C0")]
    public List<RuneLotteryEvoState> GetRuneEvoStates(JSON_RuneLotteryStatePack[] lottery)
    {
      return (List<RuneLotteryEvoState>) null;
    }

    [Token(Token = "0x6006A8B")]
    [Address(RVA = "0x342900", Offset = "0x341700", VA = "0x10342900")]
    public RuneDedicatedCostParam GetRuneDedicatedCostParam(string iname)
    {
      return (RuneDedicatedCostParam) null;
    }

    [Token(Token = "0x6006A8C")]
    [Address(RVA = "0x33B750", Offset = "0x33A550", VA = "0x1033B750")]
    public AutoRepeatQuestBoxParam GetAutoRepeatQuestBoxParam(int box_add_count)
    {
      return (AutoRepeatQuestBoxParam) null;
    }

    [Token(Token = "0x6006A8D")]
    [Address(RVA = "0x33FF80", Offset = "0x33ED80", VA = "0x1033FF80")]
    public AutoRepeatQuestBoxParam GetLastAutoRepeatQuestBoxParam()
    {
      return (AutoRepeatQuestBoxParam) null;
    }

    [Token(Token = "0x6006A8E")]
    [Address(RVA = "0x339380", Offset = "0x338180", VA = "0x10339380")]
    public ResetCostParam FindResetCost(string iname) => (ResetCostParam) null;

    [Token(Token = "0x6006A8F")]
    [Address(RVA = "0x3391C0", Offset = "0x337FC0", VA = "0x103391C0")]
    public GuildSearchFilterParam FindGuildSearchFilter(eGuildSearchFilterTypes type)
    {
      return (GuildSearchFilterParam) null;
    }

    [Token(Token = "0x6006A90")]
    [Address(RVA = "0x33E8C0", Offset = "0x33D6C0", VA = "0x1033E8C0")]
    public ExternalVideoLinkParam GetExternalVideoLinkParam(ExternalVideoLinkParam.ePlaceType _type)
    {
      return (ExternalVideoLinkParam) null;
    }

    [Token(Token = "0x6006A91")]
    [Address(RVA = "0x340F50", Offset = "0x33FD50", VA = "0x10340F50")]
    public List<ExternalVideoLinkParam> GetQuestExternalVideoLinkParams(string _quest_iname)
    {
      return (List<ExternalVideoLinkParam>) null;
    }

    [Token(Token = "0x6006A92")]
    [Address(RVA = "0x347DB0", Offset = "0x346BB0", VA = "0x10347DB0")]
    public bool IsExistsQuestExternalVideoLinkParam(string _quest_iname) => new bool();

    [Token(Token = "0x6006A93")]
    [Address(RVA = "0x346490", Offset = "0x345290", VA = "0x10346490")]
    public List<ExternalVideoLinkParam> GetUnitExternalVideoLinkParams(string _unit_iname)
    {
      return (List<ExternalVideoLinkParam>) null;
    }

    [Token(Token = "0x6006A94")]
    [Address(RVA = "0x339690", Offset = "0x338490", VA = "0x10339690")]
    public TruthEquipmentParam FindTruthEquipmentParam(string iname) => (TruthEquipmentParam) null;

    [Token(Token = "0x6006A95")]
    [Address(RVA = "0x3396F0", Offset = "0x3384F0", VA = "0x103396F0")]
    public TruthEquipmentRecipeParam FindTruthEquipmentRecipeParam(string iname)
    {
      return (TruthEquipmentRecipeParam) null;
    }

    [Token(Token = "0x6006A96")]
    [Address(RVA = "0x339750", Offset = "0x338550", VA = "0x10339750")]
    public TruthEquipmentStatusParam FindTruthEquipmentStatusParam(string iname)
    {
      return (TruthEquipmentStatusParam) null;
    }

    [Token(Token = "0x6006A97")]
    [Address(RVA = "0x339630", Offset = "0x338430", VA = "0x10339630")]
    public TruthEquipmentAbilityParam FindTruthEquipmentAbilityParam(string iname)
    {
      return (TruthEquipmentAbilityParam) null;
    }

    [Token(Token = "0x6006A98")]
    [Address(RVA = "0x3450D0", Offset = "0x343ED0", VA = "0x103450D0")]
    public SkillBuffEffectParam GetSkillBuffEffect(string _iname) => (SkillBuffEffectParam) null;

    [Token(Token = "0x6006A99")]
    [Address(RVA = "0x33B380", Offset = "0x33A180", VA = "0x1033B380")]
    public ArtifactStoneEffectParam GetArtifactStoneEffectParam(string _iname)
    {
      return (ArtifactStoneEffectParam) null;
    }

    [Token(Token = "0x17000B83")]
    public List<ResonanceParam> ResonanceParams
    {
      [Token(Token = "0x6006A9A"), Address(RVA = "0x349400", Offset = "0x348200", VA = "0x10349400")] get
      {
        return (List<ResonanceParam>) null;
      }
    }

    [Token(Token = "0x17000B84")]
    public List<ResonanceRecipeParam> ResonanceRecipeParams
    {
      [Token(Token = "0x6006A9B"), Address(RVA = "0x349410", Offset = "0x348210", VA = "0x10349410")] get
      {
        return (List<ResonanceRecipeParam>) null;
      }
    }

    [Token(Token = "0x17000B85")]
    public List<ResonanceCondParam> ResonanceCondParams
    {
      [Token(Token = "0x6006A9C"), Address(RVA = "0x3493E0", Offset = "0x3481E0", VA = "0x103493E0")] get
      {
        return (List<ResonanceCondParam>) null;
      }
    }

    [Token(Token = "0x17000B86")]
    public List<HomeUnitVoiceParam> HomeUnitVoiceParams
    {
      [Token(Token = "0x6006A9D"), Address(RVA = "0x3492B0", Offset = "0x3480B0", VA = "0x103492B0")] get
      {
        return (List<HomeUnitVoiceParam>) null;
      }
    }

    [Token(Token = "0x17000B87")]
    public List<ResonanceLimitRateParam> ResonanceLimitRateParams
    {
      [Token(Token = "0x6006A9E"), Address(RVA = "0x3493F0", Offset = "0x3481F0", VA = "0x103493F0")] get
      {
        return (List<ResonanceLimitRateParam>) null;
      }
    }

    [Token(Token = "0x17000B88")]
    public List<ResonanceTobiraBuffRateParam> ResonanceTobiraBuffRateParams
    {
      [Token(Token = "0x6006A9F"), Address(RVA = "0x349420", Offset = "0x348220", VA = "0x10349420")] get
      {
        return (List<ResonanceTobiraBuffRateParam>) null;
      }
    }

    [Token(Token = "0x6006AA0")]
    [Address(RVA = "0x337970", Offset = "0x336770", VA = "0x10337970")]
    private void Deserialize_Resonance(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x6006AA1")]
    [Address(RVA = "0x3422E0", Offset = "0x3410E0", VA = "0x103422E0")]
    public ResonanceParam GetResonanceParam(string iname) => (ResonanceParam) null;

    [Token(Token = "0x6006AA2")]
    [Address(RVA = "0x3426D0", Offset = "0x3414D0", VA = "0x103426D0")]
    public ResonanceUseItemParam[] GetResonanceUseItemParamList(string iname)
    {
      return (ResonanceUseItemParam[]) null;
    }

    [Token(Token = "0x6006AA3")]
    [Address(RVA = "0x33F680", Offset = "0x33E480", VA = "0x1033F680")]
    public string GetHomeUnitVoice(string iname) => (string) null;

    [Token(Token = "0x6006AA4")]
    [Address(RVA = "0x342490", Offset = "0x341290", VA = "0x10342490")]
    public ResonanceTobiraBuffRateParam GetResonanceTobiraBuffRateParam(string iname, int awakeLv)
    {
      return (ResonanceTobiraBuffRateParam) null;
    }

    [Token(Token = "0x17000B89")]
    public List<AutoRuneDisassemblyParam> AutoRuneDisassemblyParams
    {
      [Token(Token = "0x6006AA5"), Address(RVA = "0x349040", Offset = "0x347E40", VA = "0x10349040")] get
      {
        return (List<AutoRuneDisassemblyParam>) null;
      }
    }

    [Token(Token = "0x17000B8A")]
    public List<AutoRuneDisassemblySetParam> AutoRuneDisassemblySetParams
    {
      [Token(Token = "0x6006AA6"), Address(RVA = "0x349050", Offset = "0x347E50", VA = "0x10349050")] get
      {
        return (List<AutoRuneDisassemblySetParam>) null;
      }
    }

    [Token(Token = "0x17000B8B")]
    public List<AutoRuneDisassemblyStateParam> AutoRuneDisassemblyStateParams
    {
      [Token(Token = "0x6006AA7"), Address(RVA = "0x349060", Offset = "0x347E60", VA = "0x10349060")] get
      {
        return (List<AutoRuneDisassemblyStateParam>) null;
      }
    }

    [Token(Token = "0x6006AA8")]
    [Address(RVA = "0x338420", Offset = "0x337220", VA = "0x10338420")]
    private void Deserialize_Rune(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x6006AA9")]
    [Address(RVA = "0x342BE0", Offset = "0x3419E0", VA = "0x10342BE0")]
    public List<RuneLotteryBaseState> GetRuneLotteryBaseState(int rare, int slot, int type)
    {
      return (List<RuneLotteryBaseState>) null;
    }

    [Token(Token = "0x17000B8C")]
    public List<RunePridePanelParam> RunePridePanelParams
    {
      [Token(Token = "0x6006AAA"), Address(RVA = "0x349490", Offset = "0x348290", VA = "0x10349490")] get
      {
        return (List<RunePridePanelParam>) null;
      }
    }

    [Token(Token = "0x17000B8D")]
    public List<RunePridePanelPatternParam> RunePridePanelPatternParams
    {
      [Token(Token = "0x6006AAB"), Address(RVA = "0x3494A0", Offset = "0x3482A0", VA = "0x103494A0")] get
      {
        return (List<RunePridePanelPatternParam>) null;
      }
    }

    [Token(Token = "0x17000B8E")]
    public List<RunePridePanelContentsParam> RunePridePanelContentsParams
    {
      [Token(Token = "0x6006AAC"), Address(RVA = "0x349480", Offset = "0x348280", VA = "0x10349480")] get
      {
        return (List<RunePridePanelContentsParam>) null;
      }
    }

    [Token(Token = "0x17000B8F")]
    public List<RunePrideBonusParam> RunePrideBonusParams
    {
      [Token(Token = "0x6006AAD"), Address(RVA = "0x349450", Offset = "0x348250", VA = "0x10349450")] get
      {
        return (List<RunePrideBonusParam>) null;
      }
    }

    [Token(Token = "0x17000B90")]
    public List<RunePrideBonusStatusParam> RunePrideBonusStatusParams
    {
      [Token(Token = "0x6006AAE"), Address(RVA = "0x349460", Offset = "0x348260", VA = "0x10349460")] get
      {
        return (List<RunePrideBonusStatusParam>) null;
      }
    }

    [Token(Token = "0x17000B91")]
    public List<RunePridePotentialParam> RunePridePotentialParams
    {
      [Token(Token = "0x6006AAF"), Address(RVA = "0x3494B0", Offset = "0x3482B0", VA = "0x103494B0")] get
      {
        return (List<RunePridePotentialParam>) null;
      }
    }

    [Token(Token = "0x17000B92")]
    public List<RunePridePotentialStatusParam> RunePridePotentialStatusParams
    {
      [Token(Token = "0x6006AB0"), Address(RVA = "0x3494C0", Offset = "0x3482C0", VA = "0x103494C0")] get
      {
        return (List<RunePridePotentialStatusParam>) null;
      }
    }

    [Token(Token = "0x17000B93")]
    public List<RunePrideUnitItemParam> RunePrideUnitItemParams
    {
      [Token(Token = "0x6006AB1"), Address(RVA = "0x3494F0", Offset = "0x3482F0", VA = "0x103494F0")] get
      {
        return (List<RunePrideUnitItemParam>) null;
      }
    }

    [Token(Token = "0x17000B94")]
    public List<RunePrideItemListParam> RunePrideItemListParams
    {
      [Token(Token = "0x6006AB2"), Address(RVA = "0x349470", Offset = "0x348270", VA = "0x10349470")] get
      {
        return (List<RunePrideItemListParam>) null;
      }
    }

    [Token(Token = "0x17000B95")]
    public List<RunePrideResetParam> RunePrideResetParams
    {
      [Token(Token = "0x6006AB3"), Address(RVA = "0x3494D0", Offset = "0x3482D0", VA = "0x103494D0")] get
      {
        return (List<RunePrideResetParam>) null;
      }
    }

    [Token(Token = "0x17000B96")]
    public List<RunePrideUnitGroupParam> RunePrideUnitGroupParams
    {
      [Token(Token = "0x6006AB4"), Address(RVA = "0x3494E0", Offset = "0x3482E0", VA = "0x103494E0")] get
      {
        return (List<RunePrideUnitGroupParam>) null;
      }
    }

    [Token(Token = "0x6006AB5")]
    [Address(RVA = "0x337AE0", Offset = "0x3368E0", VA = "0x10337AE0")]
    private void Deserialize_RunePride(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x6006AB6")]
    [Address(RVA = "0x343E60", Offset = "0x342C60", VA = "0x10343E60")]
    public RunePridePanelParam GetRunePridePanelByIname(string iname) => (RunePridePanelParam) null;

    [Token(Token = "0x6006AB7")]
    [Address(RVA = "0x343FA0", Offset = "0x342DA0", VA = "0x10343FA0")]
    public RunePridePanelPatternParam GetRunePridePanelPatternByIname(string iname)
    {
      return (RunePridePanelPatternParam) null;
    }

    [Token(Token = "0x6006AB8")]
    [Address(RVA = "0x343F00", Offset = "0x342D00", VA = "0x10343F00")]
    public RunePridePanelContentsParam GetRunePridePanelByPanelId(string panel_id)
    {
      return (RunePridePanelContentsParam) null;
    }

    [Token(Token = "0x6006AB9")]
    [Address(RVA = "0x343590", Offset = "0x342390", VA = "0x10343590")]
    public List<RunePrideBonusParam> GetRunePrideBonusListByUnitId(string unit_iname)
    {
      return (List<RunePrideBonusParam>) null;
    }

    [Token(Token = "0x6006ABA")]
    [Address(RVA = "0x344440", Offset = "0x343240", VA = "0x10344440")]
    public RunePrideUnitItemParam GetRunePrideUnitItemParamByUnitId(string unit_iname)
    {
      return (RunePrideUnitItemParam) null;
    }

    [Token(Token = "0x6006ABB")]
    [Address(RVA = "0x343720", Offset = "0x342520", VA = "0x10343720")]
    public RunePrideItemListParam GetRunePrideItemList(string iname)
    {
      return (RunePrideItemListParam) null;
    }

    [Token(Token = "0x6006ABC")]
    [Address(RVA = "0x3437C0", Offset = "0x3425C0", VA = "0x103437C0")]
    public List<RunePrideItemData> GetRunePrideItemList(string _unit_iname, string _iname)
    {
      return (List<RunePrideItemData>) null;
    }

    [Token(Token = "0x6006ABD")]
    [Address(RVA = "0x3441E0", Offset = "0x342FE0", VA = "0x103441E0")]
    public RunePrideResetParam GetRunePrideResetParam(DateTime _time) => (RunePrideResetParam) null;

    [Token(Token = "0x6006ABE")]
    [Address(RVA = "0x3481A0", Offset = "0x346FA0", VA = "0x103481A0")]
    public bool IsRunePrideResetLimit(DateTime _time, int _max) => new bool();

    [Token(Token = "0x6006ABF")]
    [Address(RVA = "0x344040", Offset = "0x342E40", VA = "0x10344040")]
    public RunePrideResetData GetRunePrideResetData(DateTime _time, int _count)
    {
      return (RunePrideResetData) null;
    }

    [Token(Token = "0x6006AC0")]
    [Address(RVA = "0x3443A0", Offset = "0x3431A0", VA = "0x103443A0")]
    public RunePrideUnitGroupParam GetRunePrideUnitGroupParam(string id)
    {
      return (RunePrideUnitGroupParam) null;
    }

    [Token(Token = "0x17000B97")]
    public Dictionary<string, InspSkillParam> InspirationSkillParams
    {
      [Token(Token = "0x6006AC1"), Address(RVA = "0x3492C0", Offset = "0x3480C0", VA = "0x103492C0")] get
      {
        return (Dictionary<string, InspSkillParam>) null;
      }
    }

    [Token(Token = "0x17000B98")]
    public List<ProtectSkillParam> ProtectSkillParams
    {
      [Token(Token = "0x6006AC2"), Address(RVA = "0x3493B0", Offset = "0x3481B0", VA = "0x103493B0")] get
      {
        return (List<ProtectSkillParam>) null;
      }
    }

    [Token(Token = "0x17000B99")]
    public List<SkillAdditionalParam> SkillAdditionalList
    {
      [Token(Token = "0x6006AC3"), Address(RVA = "0x349510", Offset = "0x348310", VA = "0x10349510")] get
      {
        return (List<SkillAdditionalParam>) null;
      }
    }

    [Token(Token = "0x17000B9A")]
    public List<SkillAntiShieldParam> SkillAntiShieldList
    {
      [Token(Token = "0x6006AC4"), Address(RVA = "0x319820", Offset = "0x318620", VA = "0x10319820")] get
      {
        return (List<SkillAntiShieldParam>) null;
      }
    }

    [Token(Token = "0x17000B9B")]
    public List<SkillRevivalParam> SkillRevivalList
    {
      [Token(Token = "0x6006AC5"), Address(RVA = "0x349560", Offset = "0x348360", VA = "0x10349560")] get
      {
        return (List<SkillRevivalParam>) null;
      }
    }

    [Token(Token = "0x17000B9C")]
    public List<SkillAutoHpJudgeParam> SkillAutoHpJudgeList
    {
      [Token(Token = "0x6006AC6"), Address(RVA = "0x349520", Offset = "0x348320", VA = "0x10349520")] get
      {
        return (List<SkillAutoHpJudgeParam>) null;
      }
    }

    [Token(Token = "0x17000B9D")]
    public List<SkillCriticalHealParam> SkillCriticalHealList
    {
      [Token(Token = "0x6006AC7"), Address(RVA = "0x349540", Offset = "0x348340", VA = "0x10349540")] get
      {
        return (List<SkillCriticalHealParam>) null;
      }
    }

    [Token(Token = "0x17000B9E")]
    public List<SkillDuplicateResetParam> SkillDuplicateResetList
    {
      [Token(Token = "0x6006AC8"), Address(RVA = "0x349550", Offset = "0x348350", VA = "0x10349550")] get
      {
        return (List<SkillDuplicateResetParam>) null;
      }
    }

    [Token(Token = "0x6006AC9")]
    [Address(RVA = "0x3384F0", Offset = "0x3372F0", VA = "0x103384F0")]
    private void Deserialize_Skill(JSON_MasterParam json)
    {
    }

    [Token(Token = "0x6006ACA")]
    [Address(RVA = "0x33FA80", Offset = "0x33E880", VA = "0x1033FA80")]
    public InspSkillParam GetInspirationSkillParam(string iname) => (InspSkillParam) null;

    [Token(Token = "0x6006ACB")]
    [Address(RVA = "0x33FA00", Offset = "0x33E800", VA = "0x1033FA00")]
    public InspSkillCostParam GetInspSkillResetCost(int gen) => (InspSkillCostParam) null;

    [Token(Token = "0x6006ACC")]
    [Address(RVA = "0x33F980", Offset = "0x33E780", VA = "0x1033F980")]
    public InspSkillCostParam GetInspSkillOpenCost(int count) => (InspSkillCostParam) null;

    [Token(Token = "0x6006ACD")]
    [Address(RVA = "0x33F930", Offset = "0x33E730", VA = "0x1033F930")]
    public int GetInspSkillMaxOpenCount() => new int();

    [Token(Token = "0x6006ACE")]
    [Address(RVA = "0x33F7E0", Offset = "0x33E5E0", VA = "0x1033F7E0")]
    public int GetInspLvUpCostTotal(int id, int current_lv, int up) => new int();

    [Token(Token = "0x6006ACF")]
    [Address(RVA = "0x3454B0", Offset = "0x3442B0", VA = "0x103454B0")]
    public SkillParam GetSkillParam(string key) => (SkillParam) null;

    [Token(Token = "0x6006AD0")]
    [Address(RVA = "0x340E80", Offset = "0x33FC80", VA = "0x10340E80")]
    public ProtectSkillParam GetProtectSkillParam(string iname) => (ProtectSkillParam) null;

    [Token(Token = "0x6006AD1")]
    [Address(RVA = "0x344E50", Offset = "0x343C50", VA = "0x10344E50")]
    public SkillAdditionalParam GetSkillAdditionalParam(string iname)
    {
      return (SkillAdditionalParam) null;
    }

    [Token(Token = "0x6006AD2")]
    [Address(RVA = "0x344F20", Offset = "0x343D20", VA = "0x10344F20")]
    public SkillAntiShieldParam GetSkillAntiShieldParam(string iname)
    {
      return (SkillAntiShieldParam) null;
    }

    [Token(Token = "0x6006AD3")]
    [Address(RVA = "0x3457E0", Offset = "0x3445E0", VA = "0x103457E0")]
    public SkillRevivalParam GetSkillRevivalParam(string iname) => (SkillRevivalParam) null;

    [Token(Token = "0x6006AD4")]
    [Address(RVA = "0x345000", Offset = "0x343E00", VA = "0x10345000")]
    public SkillAutoHpJudgeParam GetSkillAutoHpParam(string iname) => (SkillAutoHpJudgeParam) null;

    [Token(Token = "0x6006AD5")]
    [Address(RVA = "0x3455C0", Offset = "0x3443C0", VA = "0x103455C0")]
    public SkillReactionCondParam GetSkillReactionCondParam(string _skill_id)
    {
      return (SkillReactionCondParam) null;
    }

    [Token(Token = "0x6006AD6")]
    [Address(RVA = "0x345190", Offset = "0x343F90", VA = "0x10345190")]
    public List<SkillDistanceParam> GetSkillDistanceParamList() => (List<SkillDistanceParam>) null;

    [Token(Token = "0x6006AD7")]
    [Address(RVA = "0x3451A0", Offset = "0x343FA0", VA = "0x103451A0")]
    public SkillDistanceParam GetSkillDistanceParam(string iname) => (SkillDistanceParam) null;

    [Token(Token = "0x6006AD8")]
    [Address(RVA = "0x345280", Offset = "0x344080", VA = "0x10345280")]
    public SkillGroupParam GetSkillGroup(string skillDistanceIname) => (SkillGroupParam) null;

    [Token(Token = "0x6006AD9")]
    [Address(RVA = "0x348AB0", Offset = "0x3478B0", VA = "0x10348AB0")]
    public MasterParam()
    {
    }
  }
}
