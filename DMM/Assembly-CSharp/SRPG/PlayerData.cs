// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Purchase;
using Il2CppDummyDll;
using MessagePack;
using SRPG.Models;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200105A")]
  public class PlayerData
  {
    [Token(Token = "0x4003A86")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int INI_UNIT_CAPACITY;
    [Token(Token = "0x4003A87")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int MAX_UNIT_CAPACITY;
    [Token(Token = "0x4003A88")]
    public const string SAIGONI_HOME_HIRAITA_LV = "lastplv";
    [Token(Token = "0x4003A89")]
    public const string SAIGONI_HOME_HIRAITA_VIPLV = "lastviplv";
    [Token(Token = "0x4003A8A")]
    public const int ITEM_CAP = 99999999;
    [Token(Token = "0x4003A8B")]
    public const int INVENTORY_SIZE = 5;
    [Token(Token = "0x4003A8C")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string PLAYRE_DATA_VERSION;
    [Token(Token = "0x4003A8D")]
    [FieldOffset(Offset = "0xC")]
    public static readonly string TEAM_ID_KEY;
    [Token(Token = "0x4003A8E")]
    [FieldOffset(Offset = "0x10")]
    public static readonly string MULTI_PLAY_TEAM_ID_KEY;
    [Token(Token = "0x4003A8F")]
    [FieldOffset(Offset = "0x14")]
    public static readonly string ARENA_TEAM_ID_KEY;
    [Token(Token = "0x4003A90")]
    [FieldOffset(Offset = "0x18")]
    public static readonly string ROOM_COMMENT_KEY;
    [Token(Token = "0x4003A91")]
    [FieldOffset(Offset = "0x1C")]
    public static readonly string VERSUS_ID_KEY;
    [Token(Token = "0x4003A92")]
    [FieldOffset(Offset = "0x8")]
    private string mName;
    [Token(Token = "0x4003A93")]
    [FieldOffset(Offset = "0xC")]
    private string mCuid;
    [Token(Token = "0x4003A94")]
    [FieldOffset(Offset = "0x10")]
    private string mFuid;
    [Token(Token = "0x4003A95")]
    [FieldOffset(Offset = "0x14")]
    private string mTuid;
    [Token(Token = "0x4003A96")]
    [FieldOffset(Offset = "0x18")]
    private long mTuidExpiredAt;
    [Token(Token = "0x4003A97")]
    [FieldOffset(Offset = "0x20")]
    private int mLoginCount;
    [Token(Token = "0x4003A98")]
    [FieldOffset(Offset = "0x24")]
    private OInt mNewGameAt;
    [Token(Token = "0x4003A99")]
    [FieldOffset(Offset = "0x38")]
    private OInt mLv;
    [Token(Token = "0x4003A9A")]
    [FieldOffset(Offset = "0x4C")]
    private OInt mExp;
    [Token(Token = "0x4003A9B")]
    [FieldOffset(Offset = "0x60")]
    private OInt mGold;
    [Token(Token = "0x4003A9C")]
    [FieldOffset(Offset = "0x74")]
    private OInt mFreeCoin;
    [Token(Token = "0x4003A9D")]
    [FieldOffset(Offset = "0x88")]
    private OInt mPaidCoin;
    [Token(Token = "0x4003A9E")]
    [FieldOffset(Offset = "0x9C")]
    private OInt mComCoin;
    [Token(Token = "0x4003A9F")]
    [FieldOffset(Offset = "0xB0")]
    private OInt mTourCoin;
    [Token(Token = "0x4003AA0")]
    [FieldOffset(Offset = "0xC4")]
    private OInt mArenaCoin;
    [Token(Token = "0x4003AA1")]
    [FieldOffset(Offset = "0xD8")]
    private OInt mMultiCoin;
    [Token(Token = "0x4003AA2")]
    [FieldOffset(Offset = "0xEC")]
    private OInt mAbilityPoint;
    [Token(Token = "0x4003AA3")]
    [FieldOffset(Offset = "0x100")]
    private OInt mPiecePoint;
    [Token(Token = "0x4003AA4")]
    [FieldOffset(Offset = "0x114")]
    private OInt mVipRank;
    [Token(Token = "0x4003AA5")]
    [FieldOffset(Offset = "0x128")]
    private OInt mVipPoint;
    [Token(Token = "0x4003AA6")]
    [FieldOffset(Offset = "0x140")]
    private OLong mVipExpiredAt;
    [Token(Token = "0x4003AA7")]
    [FieldOffset(Offset = "0x168")]
    private List<EventCoinData> mEventCoinList;
    [Token(Token = "0x4003AA8")]
    [FieldOffset(Offset = "0x16C")]
    private TimeRecoveryValue mStamina;
    [Token(Token = "0x4003AA9")]
    [FieldOffset(Offset = "0x170")]
    private TimeRecoveryValue mCaveStamina;
    [Token(Token = "0x4003AAA")]
    [FieldOffset(Offset = "0x174")]
    private TimeRecoveryValue mAbilityRankUpCount;
    [Token(Token = "0x4003AAB")]
    [FieldOffset(Offset = "0x178")]
    public int mArenaResetCount;
    [Token(Token = "0x4003AAC")]
    [FieldOffset(Offset = "0x17C")]
    public int mRunePrideResetCount;
    [Token(Token = "0x4003AAD")]
    [FieldOffset(Offset = "0x180")]
    public DateTime LoginDate;
    [Token(Token = "0x4003AAE")]
    [FieldOffset(Offset = "0x188")]
    public long TutorialFlags;
    [Token(Token = "0x4003AAF")]
    [FieldOffset(Offset = "0x190")]
    private Json_LoginBonus[] mLoginBonus;
    [Token(Token = "0x4003AB0")]
    [FieldOffset(Offset = "0x194")]
    private int mLoginBonusCount;
    [Token(Token = "0x4003AB1")]
    [FieldOffset(Offset = "0x198")]
    private bool mFirstLogin;
    [Token(Token = "0x4003AB2")]
    [FieldOffset(Offset = "0x19C")]
    private Dictionary<string, Json_LoginBonusTable> mLoginBonusTables;
    [Token(Token = "0x4003AB3")]
    [FieldOffset(Offset = "0x1A0")]
    private Json_Notify mServerNotify;
    [Token(Token = "0x4003AB4")]
    [FieldOffset(Offset = "0x1A4")]
    private Json_LoginBonusTable mLoginBonus30days;
    [Token(Token = "0x4003AB5")]
    [FieldOffset(Offset = "0x1A8")]
    private Json_LoginBonusTable mLoginBonus28days;
    [Token(Token = "0x4003AB6")]
    [FieldOffset(Offset = "0x1AC")]
    private OInt mChallengeMultiNum;
    [Token(Token = "0x4003AB7")]
    [FieldOffset(Offset = "0x1C0")]
    private OInt mStaminaBuyNum;
    [Token(Token = "0x4003AB8")]
    [FieldOffset(Offset = "0x1D4")]
    private OInt mGoldBuyNum;
    [Token(Token = "0x4003AB9")]
    [FieldOffset(Offset = "0x1E8")]
    private OInt mChallengeArenaNum;
    [Token(Token = "0x4003ABA")]
    [FieldOffset(Offset = "0x1FC")]
    private TimeRecoveryValue mChallengeArenaTimer;
    [Token(Token = "0x4003ABB")]
    [FieldOffset(Offset = "0x200")]
    private OInt mTourNum;
    [Token(Token = "0x4003ABC")]
    [FieldOffset(Offset = "0x214")]
    private OInt mUnitCap;
    [Token(Token = "0x4003ABD")]
    [FieldOffset(Offset = "0x228")]
    private int mArenaRank;
    [Token(Token = "0x4003ABE")]
    [FieldOffset(Offset = "0x22C")]
    private int mBestArenaRank;
    [Token(Token = "0x4003ABF")]
    [FieldOffset(Offset = "0x230")]
    private DateTime mArenaLastAt;
    [Token(Token = "0x4003AC0")]
    [FieldOffset(Offset = "0x238")]
    private int mArenaSeed;
    [Token(Token = "0x4003AC1")]
    [FieldOffset(Offset = "0x23C")]
    private int mArenaMaxActionNum;
    [Token(Token = "0x4003AC2")]
    [FieldOffset(Offset = "0x240")]
    private DateTime mArenaEndAt;
    [Token(Token = "0x4003AC3")]
    [FieldOffset(Offset = "0x248")]
    private List<UnitData> mUnits;
    [Token(Token = "0x4003AC4")]
    [FieldOffset(Offset = "0x24C")]
    private List<ItemData> mItems;
    [Token(Token = "0x4003AC5")]
    [FieldOffset(Offset = "0x250")]
    private List<PartyData> mPartys;
    [Token(Token = "0x4003AC6")]
    [FieldOffset(Offset = "0x254")]
    private List<ArtifactData> mArtifacts;
    [Token(Token = "0x4003AC7")]
    [FieldOffset(Offset = "0x258")]
    private Dictionary<string, Dictionary<int, int>> mArtifactsNumByRarity;
    [Token(Token = "0x4003AC8")]
    [FieldOffset(Offset = "0x25C")]
    private List<ConceptCardData> mConceptCards;
    [Token(Token = "0x4003AC9")]
    [FieldOffset(Offset = "0x260")]
    private Dictionary<string, int> mConceptCardNum;
    [Token(Token = "0x4003ACA")]
    [FieldOffset(Offset = "0x264")]
    private List<SkinConceptCardData> mSkinConceptCards;
    [Token(Token = "0x4003ACB")]
    [FieldOffset(Offset = "0x268")]
    private List<ConceptCardMaterialData> mConceptCardExpMaterials;
    [Token(Token = "0x4003ACC")]
    [FieldOffset(Offset = "0x26C")]
    private List<ConceptCardMaterialData> mConceptCardTrustMaterials;
    [Token(Token = "0x4003ACD")]
    [FieldOffset(Offset = "0x270")]
    private Dictionary<long, RuneData> mRunes;
    [Token(Token = "0x4003ACE")]
    [FieldOffset(Offset = "0x274")]
    private short mRuneStorage;
    [Token(Token = "0x4003ACF")]
    [FieldOffset(Offset = "0x276")]
    private short mRuneStorageUsed;
    [Token(Token = "0x4003AD0")]
    [FieldOffset(Offset = "0x278")]
    private List<RuneEnforceGaugeData> mRuneEnforceGauge;
    [Token(Token = "0x4003AD1")]
    [FieldOffset(Offset = "0x27C")]
    private List<CrystalData> mCrystals;
    [Token(Token = "0x4003AD2")]
    [FieldOffset(Offset = "0x280")]
    private PlayerGuildData mPlayerGuild;
    [Token(Token = "0x4003AD3")]
    [FieldOffset(Offset = "0x284")]
    private GuildData mGuild;
    [Token(Token = "0x4003AD4")]
    [FieldOffset(Offset = "0x288")]
    private StoryExChallengeCountData mStoryExChallengeCountData;
    [Token(Token = "0x4003AD5")]
    [FieldOffset(Offset = "0x28C")]
    private int mGvGMaxActionNum;
    [Token(Token = "0x4003AD6")]
    [FieldOffset(Offset = "0x290")]
    private List<string> mSkins;
    [Token(Token = "0x4003AD7")]
    [FieldOffset(Offset = "0x294")]
    private Dictionary<long, UnitData> mUniqueID2UnitData;
    [Token(Token = "0x4003AD8")]
    [FieldOffset(Offset = "0x298")]
    private Dictionary<string, ItemData> mID2ItemData;
    [Token(Token = "0x4003AD9")]
    [FieldOffset(Offset = "0x29C")]
    private TrophyData mTrophyData;
    [Token(Token = "0x4003ADA")]
    [FieldOffset(Offset = "0x2A0")]
    private GuildTrophyData mGuildTrophyData;
    [Token(Token = "0x4003ADB")]
    [FieldOffset(Offset = "0x2A4")]
    private ShopData[] mShops;
    [Token(Token = "0x4003ADC")]
    [FieldOffset(Offset = "0x2A8")]
    private LimitedShopData mLimitedShops;
    [Token(Token = "0x4003ADD")]
    [FieldOffset(Offset = "0x2AC")]
    private EventShopData mEventShops;
    [Token(Token = "0x4003ADE")]
    [FieldOffset(Offset = "0x2B0")]
    private UnitPieceShopData mUnitPieceShopData;
    [Token(Token = "0x4003ADF")]
    [FieldOffset(Offset = "0x2B4")]
    private List<SRPG.RankMatchMissionState> mRankMatchMissionState;
    [Token(Token = "0x4003AE0")]
    [FieldOffset(Offset = "0x2B8")]
    private List<Json_ShopBuyCrystal> mShopBuyCrystal;
    [Token(Token = "0x4003AE1")]
    [FieldOffset(Offset = "0x2BC")]
    public RankMatchSeasonResult mRankMatchSeasonResult;
    [Token(Token = "0x4003AE2")]
    [FieldOffset(Offset = "0x2C0")]
    public RaidRankRewardResult mRaidRankRewardResult;
    [Token(Token = "0x4003AE3")]
    [FieldOffset(Offset = "0x2C4")]
    public GuildRaidSeasonResult mGuildRaidSeasonResult;
    [Token(Token = "0x4003AE4")]
    [FieldOffset(Offset = "0x2C8")]
    private List<PlayerCoinBuyUseBonusState> mCoinBuyUseBonusStateList;
    [Token(Token = "0x4003AE5")]
    [FieldOffset(Offset = "0x2CC")]
    private List<PlayerCoinBuyUseBonusRewardState> mCoinBuyUseBonusRewardStateList;
    [Token(Token = "0x4003AE6")]
    [FieldOffset(Offset = "0x2D0")]
    private AutoRepeatQuestData mAutoRepeatQuestProgress;
    [Token(Token = "0x4003AE7")]
    [FieldOffset(Offset = "0x2D4")]
    private AutoRepeatQuestBoxData mAutoRepeatQuestBox;
    [Token(Token = "0x4003AE8")]
    [FieldOffset(Offset = "0x2D8")]
    private List<string> mAutoRepeatQuestApItemPriority;
    [Token(Token = "0x4003AE9")]
    [FieldOffset(Offset = "0x2DC")]
    private AutoRepeatQuestToggleCheckData mAutoRepeatQuestToggleCheck;
    [Token(Token = "0x4003AEA")]
    [FieldOffset(Offset = "0x2E0")]
    private Dictionary<eOverWritePartyType, List<PartyOverWrite>> mPartyOverWriteDatas;
    [Token(Token = "0x4003AEB")]
    [FieldOffset(Offset = "0x2E4")]
    private List<TrophyParam> mTrophyDailyClearList;
    [Token(Token = "0x4003AEC")]
    [FieldOffset(Offset = "0x2E8")]
    private BadgeViewUnitOverWriteData mBadgeViewUnitOverWriteDatas;
    [Token(Token = "0x4003AED")]
    [FieldOffset(Offset = "0x2EC")]
    private EnumBitArray<eOverWritePartyType> mIsDirtyPartyOverWriteData;
    [Token(Token = "0x4003AEE")]
    [FieldOffset(Offset = "0x2F0")]
    private List<BondData> mBondDatas;
    [Token(Token = "0x4003AEF")]
    [FieldOffset(Offset = "0x2F4")]
    private QuestParam[] mAvailableQuests;
    [Token(Token = "0x4003AF0")]
    [FieldOffset(Offset = "0x2F8")]
    private Dictionary<string, QuestParam> mAvailableQuestDict;
    [Token(Token = "0x4003AF1")]
    [FieldOffset(Offset = "0x2FC")]
    private bool mQuestListDirty;
    [Token(Token = "0x4003AF2")]
    [FieldOffset(Offset = "0x300")]
    private List<OpenedQuestArchive> mQuestArchives;
    [Token(Token = "0x4003AF3")]
    [FieldOffset(Offset = "0x308")]
    public long QuestArchivesFreeEndTime;
    [Token(Token = "0x4003AF4")]
    [FieldOffset(Offset = "0x310")]
    public List<FriendData> Friends;
    [Token(Token = "0x4003AF5")]
    [FieldOffset(Offset = "0x314")]
    public List<FriendData> FriendsFollower;
    [Token(Token = "0x4003AF6")]
    [FieldOffset(Offset = "0x318")]
    public List<FriendData> FriendsFollow;
    [Token(Token = "0x4003AF7")]
    [FieldOffset(Offset = "0x31C")]
    public int mFriendNum;
    [Token(Token = "0x4003AF8")]
    [FieldOffset(Offset = "0x320")]
    public int mFollowerNum;
    [Token(Token = "0x4003AF9")]
    [FieldOffset(Offset = "0x324")]
    public List<string> mFollowerUID;
    [Token(Token = "0x4003AFA")]
    [FieldOffset(Offset = "0x328")]
    public List<MultiFuid> MultiFuids;
    [Token(Token = "0x4003AFB")]
    [FieldOffset(Offset = "0x32C")]
    public List<SupportData> Supports;
    [Token(Token = "0x4003AFC")]
    [FieldOffset(Offset = "0x330")]
    public FriendPresentWishList FriendPresentWishList;
    [Token(Token = "0x4003AFD")]
    [FieldOffset(Offset = "0x334")]
    public FriendPresentReceiveList FriendPresentReceiveList;
    [Token(Token = "0x4003AFE")]
    [FieldOffset(Offset = "0x338")]
    public List<MailData> Mails;
    [Token(Token = "0x4003AFF")]
    [FieldOffset(Offset = "0x33C")]
    public List<MailData> CurrentMails;
    [Token(Token = "0x4003B00")]
    [FieldOffset(Offset = "0x340")]
    public MailPageData MailPage;
    [Token(Token = "0x4003B01")]
    [FieldOffset(Offset = "0x348")]
    public OLong mUnlocks;
    [Token(Token = "0x4003B02")]
    [FieldOffset(Offset = "0x370")]
    public FreeGacha FreeGachaGold;
    [Token(Token = "0x4003B03")]
    [FieldOffset(Offset = "0x374")]
    public FreeGacha FreeGachaCoin;
    [Token(Token = "0x4003B04")]
    [FieldOffset(Offset = "0x378")]
    public PaidGacha PaidGacha;
    [Token(Token = "0x4003B05")]
    [FieldOffset(Offset = "0x37C")]
    public Dictionary<string, PaymentInfo> PaymentInfos;
    [Token(Token = "0x4003B06")]
    [FieldOffset(Offset = "0x380")]
    private bool mUnreadMailPeriod;
    [Token(Token = "0x4003B07")]
    [FieldOffset(Offset = "0x381")]
    private bool mUnreadMail;
    [Token(Token = "0x4003B08")]
    [FieldOffset(Offset = "0x382")]
    private bool mValidGpsGift;
    [Token(Token = "0x4003B09")]
    [FieldOffset(Offset = "0x383")]
    private bool mValidFriendPresent;
    [Token(Token = "0x4003B0A")]
    [FieldOffset(Offset = "0x384")]
    private string mSelectedAward;
    [Token(Token = "0x4003B0B")]
    [FieldOffset(Offset = "0x388")]
    private List<string> mHaveAward;
    [Token(Token = "0x4003B0C")]
    [FieldOffset(Offset = "0x38C")]
    private int mVersusPoint;
    [Token(Token = "0x4003B0D")]
    [FieldOffset(Offset = "0x390")]
    private int[] mVersusWinCount;
    [Token(Token = "0x4003B0E")]
    [FieldOffset(Offset = "0x394")]
    private int[] mVersusTotalCount;
    [Token(Token = "0x4003B0F")]
    [FieldOffset(Offset = "0x398")]
    private int mVersusFreeWin;
    [Token(Token = "0x4003B10")]
    [FieldOffset(Offset = "0x39C")]
    private int mVersusRankWin;
    [Token(Token = "0x4003B11")]
    [FieldOffset(Offset = "0x3A0")]
    private int mVersusFriendWin;
    [Token(Token = "0x4003B12")]
    [FieldOffset(Offset = "0x3A4")]
    private int mVersusTwFloor;
    [Token(Token = "0x4003B13")]
    [FieldOffset(Offset = "0x3A8")]
    private int mVersusTwKey;
    [Token(Token = "0x4003B14")]
    [FieldOffset(Offset = "0x3AC")]
    private int mVersusTwWinCnt;
    [Token(Token = "0x4003B15")]
    [FieldOffset(Offset = "0x3B0")]
    private bool mVersusSeasonGift;
    [Token(Token = "0x4003B16")]
    [FieldOffset(Offset = "0x3B4")]
    private int mRankMatchRank;
    [Token(Token = "0x4003B17")]
    [FieldOffset(Offset = "0x3B8")]
    private int mRankMatchScore;
    [Token(Token = "0x4003B18")]
    [FieldOffset(Offset = "0x3BC")]
    private RankMatchClass mRankMatchClass;
    [Token(Token = "0x4003B19")]
    [FieldOffset(Offset = "0x3C0")]
    private int mRankMatchBattlePoint;
    [Token(Token = "0x4003B1A")]
    [FieldOffset(Offset = "0x3C4")]
    private int mRankMatchStreakWin;
    [Token(Token = "0x4003B1B")]
    [FieldOffset(Offset = "0x3C8")]
    private int mRankMatchOldRank;
    [Token(Token = "0x4003B1C")]
    [FieldOffset(Offset = "0x3CC")]
    private int mRankMatchOldScore;
    [Token(Token = "0x4003B1D")]
    [FieldOffset(Offset = "0x3D0")]
    private RankMatchClass mRankMatchOldClass;
    [Token(Token = "0x4003B21")]
    [FieldOffset(Offset = "0x3E0")]
    private bool mMultiInvitaionFlag;
    [Token(Token = "0x4003B22")]
    [FieldOffset(Offset = "0x3E4")]
    private string mMultiInvitaionComment;
    [Token(Token = "0x4003B23")]
    [FieldOffset(Offset = "0x3E8")]
    private int mFirstFriendCount;
    [Token(Token = "0x4003B24")]
    [FieldOffset(Offset = "0x3EC")]
    private int mFirstChargeStatus;
    [Token(Token = "0x4003B25")]
    [FieldOffset(Offset = "0x3F0")]
    private long mGuerrillaShopStart;
    [Token(Token = "0x4003B26")]
    [FieldOffset(Offset = "0x3F8")]
    private long mGuerrillaShopEnd;
    [Token(Token = "0x4003B27")]
    [FieldOffset(Offset = "0x400")]
    private bool mIsGuerrillaShopStarted;
    [Token(Token = "0x4003B28")]
    private const string CHANGE_SCRIPT_COMPLETE_QUEST_KEY = "COMPLETE_QUEST_MISSION";
    [Token(Token = "0x4003B29")]
    [FieldOffset(Offset = "0x404")]
    public CombatPowerData combatPowerData;
    [Token(Token = "0x4003B2A")]
    [FieldOffset(Offset = "0x408")]
    public int SupportCount;
    [Token(Token = "0x4003B2B")]
    [FieldOffset(Offset = "0x40C")]
    public int SupportGold;
    [Token(Token = "0x4003B2C")]
    [FieldOffset(Offset = "0x410")]
    private ItemData[] mInventory;
    [Token(Token = "0x4003B3D")]
    [FieldOffset(Offset = "0x438")]
    private Dictionary<string, int> mConsumeMaterials;
    [Token(Token = "0x4003B3E")]
    [FieldOffset(Offset = "0x43C")]
    private Dictionary<string, int> mTempConsumeMaterials;
    [Token(Token = "0x4003B3F")]
    [FieldOffset(Offset = "0x440")]
    private int mCreateItemCost;
    [Token(Token = "0x4003B40")]
    [FieldOffset(Offset = "0x444")]
    private int mTempCreateItemCost;
    [Token(Token = "0x4003B41")]
    private const int MAX_JOB = 6;
    [Token(Token = "0x4003B42")]
    [FieldOffset(Offset = "0x448")]
    private int mPrevCheckHour;
    [Token(Token = "0x4003B43")]
    [FieldOffset(Offset = "0x44C")]
    private UpdateTrophyInterval mUpdateInterval;
    [Token(Token = "0x4003B44")]
    [FieldOffset(Offset = "0x450")]
    private Queue<string> mLoginBonusQueue;
    [Token(Token = "0x4003B45")]
    [FieldOffset(Offset = "0x454")]
    private PlayerData.TrophyStarMission mTrophyStarMissionInfo;
    [Token(Token = "0x4003B46")]
    [FieldOffset(Offset = "0x458")]
    private bool mIsEndTutorialGacha;
    [Token(Token = "0x4003B47")]
    [FieldOffset(Offset = "0x459")]
    private bool mIsEndNameSet;
    [Token(Token = "0x4003B48")]
    [FieldOffset(Offset = "0x460")]
    private OLong mPremiumExpiredAt;
    [Token(Token = "0x4003B49")]
    [FieldOffset(Offset = "0x488")]
    private Dictionary<string, PlayerData.PremiumLoginStatus> mPremiumLoginData;
    [Token(Token = "0x4003B4A")]
    [FieldOffset(Offset = "0x48C")]
    private Json_LoginBonusTable mDrawPremiumBonus;
    [Token(Token = "0x4003B4B")]
    [FieldOffset(Offset = "0x490")]
    private List<ExpansionPurchaseData> mExpansions;
    [Token(Token = "0x4003B4C")]
    [FieldOffset(Offset = "0x494")]
    private PlayerData_GvG mGvGData;
    [Token(Token = "0x4003B4D")]
    [FieldOffset(Offset = "0x498")]
    private PlayerData.PlayerData_LeagueMatch mLeagueMatchData;
    [Token(Token = "0x4003B4E")]
    [FieldOffset(Offset = "0x49C")]
    private PlayerData.PlayerData_Rune mRuneData;
    [Token(Token = "0x4003B4F")]
    [FieldOffset(Offset = "0x4A0")]
    private PlayerData.PlayerData_UnitUseItem mUnitUseItemData;

    [Token(Token = "0x17000649")]
    public TrophyData TrophyData
    {
      [Token(Token = "0x600432B"), Address(RVA = "0x305B90", Offset = "0x304990", VA = "0x10305B90")] get
      {
        return (TrophyData) null;
      }
    }

    [Token(Token = "0x600432C")]
    [Address(RVA = "0x305B80", Offset = "0x304980", VA = "0x10305B80")]
    public GuildTrophyData GetGuildTrophyData() => (GuildTrophyData) null;

    [Token(Token = "0x1700064A")]
    public GuildTrophyData GuildTrophyData
    {
      [Token(Token = "0x600432D"), Address(RVA = "0x305B80", Offset = "0x304980", VA = "0x10305B80")] get
      {
        return (GuildTrophyData) null;
      }
    }

    [Token(Token = "0x1700064B")]
    public UnitPieceShopData UnitPieceShopData
    {
      [Token(Token = "0x600432E"), Address(RVA = "0x3493C0", Offset = "0x3481C0", VA = "0x103493C0")] get
      {
        return (UnitPieceShopData) null;
      }
    }

    [Token(Token = "0x1700064C")]
    public List<SRPG.RankMatchMissionState> RankMatchMissionState
    {
      [Token(Token = "0x600432F"), Address(RVA = "0x349180", Offset = "0x347F80", VA = "0x10349180")] get
      {
        return (List<SRPG.RankMatchMissionState>) null;
      }
      [Token(Token = "0x6004330"), Address(RVA = "0x11C9460", Offset = "0x11C8260", VA = "0x111C9460")] set
      {
      }
    }

    [Token(Token = "0x1700064D")]
    public List<PlayerCoinBuyUseBonusState> CoinBuyUseBonusStateList
    {
      [Token(Token = "0x6004331"), Address(RVA = "0x349090", Offset = "0x347E90", VA = "0x10349090")] get
      {
        return (List<PlayerCoinBuyUseBonusState>) null;
      }
    }

    [Token(Token = "0x1700064E")]
    public List<PlayerCoinBuyUseBonusRewardState> CoinBuyUseBonusRewardStateList
    {
      [Token(Token = "0x6004332"), Address(RVA = "0x349080", Offset = "0x347E80", VA = "0x10349080")] get
      {
        return (List<PlayerCoinBuyUseBonusRewardState>) null;
      }
    }

    [Token(Token = "0x1700064F")]
    public AutoRepeatQuestData AutoRepeatQuestProgress
    {
      [Token(Token = "0x6004333"), Address(RVA = "0x3490B0", Offset = "0x347EB0", VA = "0x103490B0")] get
      {
        return (AutoRepeatQuestData) null;
      }
    }

    [Token(Token = "0x17000650")]
    public bool IsAutoRepeatQuestMeasuring
    {
      [Token(Token = "0x6004334"), Address(RVA = "0x11C8830", Offset = "0x11C7630", VA = "0x111C8830")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000651")]
    public AutoRepeatQuestBoxData AutoRepeatQuestBox
    {
      [Token(Token = "0x6004335"), Address(RVA = "0x3490D0", Offset = "0x347ED0", VA = "0x103490D0")] get
      {
        return (AutoRepeatQuestBoxData) null;
      }
    }

    [Token(Token = "0x17000652")]
    public List<string> AutoRepeatQuestApItemPriority
    {
      [Token(Token = "0x6004336"), Address(RVA = "0x3490C0", Offset = "0x347EC0", VA = "0x103490C0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17000653")]
    public AutoRepeatQuestToggleCheckData AutoRepeatQuestToggleCheck
    {
      [Token(Token = "0x6004337"), Address(RVA = "0x3490A0", Offset = "0x347EA0", VA = "0x103490A0")] get
      {
        return (AutoRepeatQuestToggleCheckData) null;
      }
    }

    [Token(Token = "0x17000654")]
    public Dictionary<eOverWritePartyType, List<PartyOverWrite>> PartyOverWriteDatas
    {
      [Token(Token = "0x6004338"), Address(RVA = "0x3495A0", Offset = "0x3483A0", VA = "0x103495A0")] get
      {
        return (Dictionary<eOverWritePartyType, List<PartyOverWrite>>) null;
      }
    }

    [Token(Token = "0x17000655")]
    public List<TrophyParam> TrophyDailyClearList
    {
      [Token(Token = "0x6004339"), Address(RVA = "0x349530", Offset = "0x348330", VA = "0x10349530")] get
      {
        return (List<TrophyParam>) null;
      }
    }

    [Token(Token = "0x17000656")]
    public BadgeViewUnitOverWriteData BadgeViewUnitData
    {
      [Token(Token = "0x600433A"), Address(RVA = "0x3493A0", Offset = "0x3481A0", VA = "0x103493A0")] get
      {
        return (BadgeViewUnitOverWriteData) null;
      }
    }

    [Token(Token = "0x600433B")]
    [Address(RVA = "0x11C19C0", Offset = "0x11C07C0", VA = "0x111C19C0")]
    public void UpdateBadgeViewUnitData()
    {
    }

    [Token(Token = "0x600433C")]
    [Address(RVA = "0x11BE430", Offset = "0x11BD230", VA = "0x111BE430")]
    public void SetDirtyParty(eOverWritePartyType type)
    {
    }

    [Token(Token = "0x17000657")]
    public List<BondData> BondDatas
    {
      [Token(Token = "0x600433D"), Address(RVA = "0x33D4C0", Offset = "0x33C2C0", VA = "0x1033D4C0")] get
      {
        return (List<BondData>) null;
      }
    }

    [Token(Token = "0x600433E")]
    [Address(RVA = "0x11B11A0", Offset = "0x11AFFA0", VA = "0x111B11A0")]
    public void IncrementRankMatchMission(RankMatchMissionType type)
    {
    }

    [Token(Token = "0x600433F")]
    [Address(RVA = "0x11BE9C0", Offset = "0x11BD7C0", VA = "0x111BE9C0")]
    public void SetMaxProgRankMatchMission(RankMatchMissionType type, int prog)
    {
    }

    [Token(Token = "0x6004340")]
    [Address(RVA = "0x11BD160", Offset = "0x11BBF60", VA = "0x111BD160")]
    public void RewardedRankMatchMission(string iname)
    {
    }

    [Token(Token = "0x6004341")]
    [Address(RVA = "0x11AEC80", Offset = "0x11ADA80", VA = "0x111AEC80")]
    public string GetMissionProgressString() => (string) null;

    [Token(Token = "0x6004342")]
    [Address(RVA = "0x11B3C30", Offset = "0x11B2A30", VA = "0x111B3C30")]
    public bool IsQuestAvailable(string questID) => new bool();

    [Token(Token = "0x6004343")]
    [Address(RVA = "0x11B3D40", Offset = "0x11B2B40", VA = "0x111B3D40")]
    public bool IsQuestAvailable(QuestParam questparam) => new bool();

    [Token(Token = "0x6004344")]
    [Address(RVA = "0x11B3DB0", Offset = "0x11B2BB0", VA = "0x111B3DB0")]
    public bool IsQuestCleared(string questID) => new bool();

    [Token(Token = "0x17000658")]
    public QuestParam[] AvailableQuests
    {
      [Token(Token = "0x6004345"), Address(RVA = "0x11C7D00", Offset = "0x11C6B00", VA = "0x111C7D00")] get
      {
        return (QuestParam[]) null;
      }
    }

    [Token(Token = "0x6004346")]
    [Address(RVA = "0x11A1860", Offset = "0x11A0660", VA = "0x111A1860")]
    public bool ContainAvailableQuestsKey(string iname) => new bool();

    [Token(Token = "0x6004347")]
    [Address(RVA = "0x11AC860", Offset = "0x11AB660", VA = "0x111AC860")]
    public QuestParam[] GetClearedQuests() => (QuestParam[]) null;

    [Token(Token = "0x6004348")]
    [Address(RVA = "0x11B1CC0", Offset = "0x11B0AC0", VA = "0x111B1CC0")]
    public bool IsAnyStateQuests(QuestStates state) => new bool();

    [Token(Token = "0x6004349")]
    [Address(RVA = "0x11B1A00", Offset = "0x11B0800", VA = "0x111B1A00")]
    public bool IsAnyClearedQuests() => new bool();

    [Token(Token = "0x600434A")]
    [Address(RVA = "0x11B19E0", Offset = "0x11B07E0", VA = "0x111B19E0")]
    public bool IsAnyChallangedQuests() => new bool();

    [Token(Token = "0x17000659")]
    public List<OpenedQuestArchive> OpenedQuestArchives
    {
      [Token(Token = "0x600434B"), Address(RVA = "0x3491F0", Offset = "0x347FF0", VA = "0x103491F0")] get
      {
        return (List<OpenedQuestArchive>) null;
      }
    }

    [Token(Token = "0x1700065A")]
    public bool CanOpenArchiveForFree
    {
      [Token(Token = "0x600434C"), Address(RVA = "0x11C7EF0", Offset = "0x11C6CF0", VA = "0x111C7EF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700065B")]
    public string OkyakusamaCode
    {
      [Token(Token = "0x600434D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700065C")]
    public BtlResultTypes RankMatchResult
    {
      [Token(Token = "0x600434E"), Address(RVA = "0x11C8C50", Offset = "0x11C7A50", VA = "0x111C8C50")] get
      {
        return new BtlResultTypes();
      }
      [Token(Token = "0x600434F"), Address(RVA = "0x11C9480", Offset = "0x11C8280", VA = "0x111C9480")] set
      {
      }
    }

    [Token(Token = "0x1700065D")]
    public int RankMatchTotalCount
    {
      [Token(Token = "0x6004350"), Address(RVA = "0x11C8C60", Offset = "0x11C7A60", VA = "0x111C8C60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700065E")]
    public int RankMatchWinCount
    {
      [Token(Token = "0x6004351"), Address(RVA = "0x345190", Offset = "0x343F90", VA = "0x10345190")] get
      {
        return new int();
      }
      [Token(Token = "0x6004352"), Address(RVA = "0x11C94A0", Offset = "0x11C82A0", VA = "0x111C94A0")] set
      {
      }
    }

    [Token(Token = "0x1700065F")]
    public int RankMatchLoseCount
    {
      [Token(Token = "0x6004353"), Address(RVA = "0x1105E30", Offset = "0x1104C30", VA = "0x11105E30")] get
      {
        return new int();
      }
      [Token(Token = "0x6004354"), Address(RVA = "0x11C9440", Offset = "0x11C8240", VA = "0x111C9440")] set
      {
      }
    }

    [Token(Token = "0x17000660")]
    public string Name
    {
      [Token(Token = "0x6004355"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004356"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x17000661")]
    public string CUID
    {
      [Token(Token = "0x6004357"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000662")]
    public string FUID
    {
      [Token(Token = "0x6004358"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000663")]
    public string TUID
    {
      [Token(Token = "0x6004359"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000664")]
    public long TuidExpiredAt
    {
      [Token(Token = "0x600435A"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000665")]
    public int LoginCount
    {
      [Token(Token = "0x600435B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000666")]
    public int Lv
    {
      [Token(Token = "0x600435C"), Address(RVA = "0x11C8AB0", Offset = "0x11C78B0", VA = "0x111C8AB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000667")]
    public int Exp
    {
      [Token(Token = "0x600435D"), Address(RVA = "0x11C8590", Offset = "0x11C7390", VA = "0x111C8590")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000668")]
    public long NewGameAt
    {
      [Token(Token = "0x600435E"), Address(RVA = "0x11C8B70", Offset = "0x11C7970", VA = "0x111C8B70")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000669")]
    public DateTime NewGameAtDateTime
    {
      [Token(Token = "0x600435F"), Address(RVA = "0x11C8B00", Offset = "0x11C7900", VA = "0x111C8B00")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x1700066A")]
    public int Gold
    {
      [Token(Token = "0x6004360"), Address(RVA = "0xA23600", Offset = "0xA22400", VA = "0x10A23600")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700066B")]
    public int Coin
    {
      [Token(Token = "0x6004361"), Address(RVA = "0x11C8380", Offset = "0x11C7180", VA = "0x111C8380")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700066C")]
    public int FreeCoin
    {
      [Token(Token = "0x6004362"), Address(RVA = "0xA23630", Offset = "0xA22430", VA = "0x10A23630")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700066D")]
    public int PaidCoin
    {
      [Token(Token = "0x6004363"), Address(RVA = "0xA235A0", Offset = "0xA223A0", VA = "0x10A235A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700066E")]
    public int ComCoin
    {
      [Token(Token = "0x6004364"), Address(RVA = "0xA235D0", Offset = "0xA223D0", VA = "0x10A235D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700066F")]
    public int TourCoin
    {
      [Token(Token = "0x6004365"), Address(RVA = "0xA23510", Offset = "0xA22310", VA = "0x10A23510")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000670")]
    public int ArenaCoin
    {
      [Token(Token = "0x6004366"), Address(RVA = "0xA23540", Offset = "0xA22340", VA = "0x10A23540")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000671")]
    public int MultiCoin
    {
      [Token(Token = "0x6004367"), Address(RVA = "0xA23570", Offset = "0xA22370", VA = "0x10A23570")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000672")]
    public int AbilityPoint
    {
      [Token(Token = "0x6004368"), Address(RVA = "0x11C7AC0", Offset = "0x11C68C0", VA = "0x111C7AC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000673")]
    public int PiecePoint
    {
      [Token(Token = "0x6004369"), Address(RVA = "0x11C8BA0", Offset = "0x11C79A0", VA = "0x111C8BA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000674")]
    public int VipRank
    {
      [Token(Token = "0x600436A"), Address(RVA = "0x11C9190", Offset = "0x11C7F90", VA = "0x111C9190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000675")]
    public int VipPoint
    {
      [Token(Token = "0x600436B"), Address(RVA = "0x11C9160", Offset = "0x11C7F60", VA = "0x111C9160")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000676")]
    public List<EventCoinData> EventCoinList
    {
      [Token(Token = "0x600436C"), Address(RVA = "0xFC53A0", Offset = "0xFC41A0", VA = "0x10FC53A0")] get
      {
        return (List<EventCoinData>) null;
      }
    }

    [Token(Token = "0x17000677")]
    public int Stamina
    {
      [Token(Token = "0x600436D"), Address(RVA = "0x11C8EB0", Offset = "0x11C7CB0", VA = "0x111C8EB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000678")]
    public int StaminaMax
    {
      [Token(Token = "0x600436E"), Address(RVA = "0x11C8DC0", Offset = "0x11C7BC0", VA = "0x111C8DC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000679")]
    public long StaminaRecverySec
    {
      [Token(Token = "0x600436F"), Address(RVA = "0x11C8E00", Offset = "0x11C7C00", VA = "0x111C8E00")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700067A")]
    public long StaminaAt
    {
      [Token(Token = "0x6004370"), Address(RVA = "0x11C8D40", Offset = "0x11C7B40", VA = "0x111C8D40")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700067B")]
    public int StaminaStockCap
    {
      [Token(Token = "0x6004371"), Address(RVA = "0x11C8E40", Offset = "0x11C7C40", VA = "0x111C8E40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700067C")]
    public int CaveStamina
    {
      [Token(Token = "0x6004372"), Address(RVA = "0x11C8090", Offset = "0x11C6E90", VA = "0x111C8090")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700067D")]
    public int CaveStaminaMax
    {
      [Token(Token = "0x6004373"), Address(RVA = "0x11C7FA0", Offset = "0x11C6DA0", VA = "0x111C7FA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700067E")]
    public long CaveStaminaRecverySec
    {
      [Token(Token = "0x6004374"), Address(RVA = "0x11C7FE0", Offset = "0x11C6DE0", VA = "0x111C7FE0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700067F")]
    public long CaveStaminaAt
    {
      [Token(Token = "0x6004375"), Address(RVA = "0x11C7F50", Offset = "0x11C6D50", VA = "0x111C7F50")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000680")]
    public int CaveStaminaStockCap
    {
      [Token(Token = "0x6004376"), Address(RVA = "0x11C8020", Offset = "0x11C6E20", VA = "0x111C8020")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000681")]
    public int AbilityRankUpCountNum
    {
      [Token(Token = "0x6004377"), Address(RVA = "0x11C7B80", Offset = "0x11C6980", VA = "0x111C7B80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000682")]
    public int AbilityRankUpCountMax
    {
      [Token(Token = "0x6004378"), Address(RVA = "0x11C7B40", Offset = "0x11C6940", VA = "0x111C7B40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000683")]
    public long AbilityRankUpCountRecverySec
    {
      [Token(Token = "0x6004379"), Address(RVA = "0x11C7BC0", Offset = "0x11C69C0", VA = "0x111C7BC0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000684")]
    public long AbilityRankUpCountAt
    {
      [Token(Token = "0x600437A"), Address(RVA = "0x11C7AF0", Offset = "0x11C68F0", VA = "0x111C7AF0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000685")]
    public int ChallengeArenaNum
    {
      [Token(Token = "0x600437B"), Address(RVA = "0x11C8210", Offset = "0x11C7010", VA = "0x111C8210")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000686")]
    public int ChallengeArenaMax
    {
      [Token(Token = "0x600437C"), Address(RVA = "0x11C81A0", Offset = "0x11C6FA0", VA = "0x111C81A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000687")]
    public long ChallengeArenaCoolDownSec
    {
      [Token(Token = "0x600437D"), Address(RVA = "0x11C8120", Offset = "0x11C6F20", VA = "0x111C8120")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000688")]
    public long ChallengeArenaAt
    {
      [Token(Token = "0x600437E"), Address(RVA = "0x11C80D0", Offset = "0x11C6ED0", VA = "0x111C80D0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000689")]
    public int ChallengeTourNum
    {
      [Token(Token = "0x600437F"), Address(RVA = "0x11C8350", Offset = "0x11C7150", VA = "0x111C8350")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700068A")]
    public int ChallengeTourMax
    {
      [Token(Token = "0x6004380"), Address(RVA = "0x11C82E0", Offset = "0x11C70E0", VA = "0x111C82E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700068B")]
    public int ArenaRank
    {
      [Token(Token = "0x6004381"), Address(RVA = "0x349610", Offset = "0x348410", VA = "0x10349610")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700068C")]
    public int ArenaRankBest
    {
      [Token(Token = "0x6004382"), Address(RVA = "0x349620", Offset = "0x348420", VA = "0x10349620")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700068D")]
    public DateTime ArenaLastAt
    {
      [Token(Token = "0x6004383"), Address(RVA = "0x11C7C20", Offset = "0x11C6A20", VA = "0x111C7C20")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x1700068E")]
    public int ArenaSeed
    {
      [Token(Token = "0x6004384"), Address(RVA = "0x3495F0", Offset = "0x3483F0", VA = "0x103495F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700068F")]
    public int ArenaMaxActionNum
    {
      [Token(Token = "0x6004385"), Address(RVA = "0x3495E0", Offset = "0x3483E0", VA = "0x103495E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000690")]
    public DateTime ArenaEndAt
    {
      [Token(Token = "0x6004386"), Address(RVA = "0x11C7C00", Offset = "0x11C6A00", VA = "0x111C7C00")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000691")]
    public int ChallengeMultiNum
    {
      [Token(Token = "0x6004387"), Address(RVA = "0x11C82B0", Offset = "0x11C70B0", VA = "0x111C82B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6004388")]
    [Address(RVA = "0x11B1080", Offset = "0x11AFE80", VA = "0x111B1080")]
    public void IncrementChallengeMultiNum()
    {
    }

    [Token(Token = "0x17000692")]
    public int ChallengeMultiMax
    {
      [Token(Token = "0x6004389"), Address(RVA = "0x11C8240", Offset = "0x11C7040", VA = "0x111C8240")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000693")]
    public int StaminaBuyNum
    {
      [Token(Token = "0x600438A"), Address(RVA = "0x11C8D90", Offset = "0x11C7B90", VA = "0x111C8D90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000694")]
    public int GoldBuyNum
    {
      [Token(Token = "0x600438B"), Address(RVA = "0x11C8690", Offset = "0x11C7490", VA = "0x111C8690")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000695")]
    public int UnitCap
    {
      [Token(Token = "0x600438C"), Address(RVA = "0x11C8F10", Offset = "0x11C7D10", VA = "0x111C8F10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000696")]
    public List<UnitData> Units
    {
      [Token(Token = "0x600438D"), Address(RVA = "0x305BA0", Offset = "0x3049A0", VA = "0x10305BA0")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x17000697")]
    public int UnitNum
    {
      [Token(Token = "0x600438E"), Address(RVA = "0x11C8F40", Offset = "0x11C7D40", VA = "0x111C8F40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600438F")]
    [Address(RVA = "0x11AFD70", Offset = "0x11AEB70", VA = "0x111AFD70")]
    public UnitData GetRentalUnit() => (UnitData) null;

    [Token(Token = "0x6004390")]
    [Address(RVA = "0x11BC9B0", Offset = "0x11BB7B0", VA = "0x111BC9B0")]
    public bool RemoveRentalUnit(string iname) => new bool();

    [Token(Token = "0x17000698")]
    public List<ItemData> Items
    {
      [Token(Token = "0x6004391"), Address(RVA = "0x11C8950", Offset = "0x11C7750", VA = "0x111C8950")] get
      {
        return (List<ItemData>) null;
      }
    }

    [Token(Token = "0x17000699")]
    public List<ArtifactData> Artifacts
    {
      [Token(Token = "0x6004392"), Address(RVA = "0x32ECE0", Offset = "0x32DAE0", VA = "0x1032ECE0")] get
      {
        return (List<ArtifactData>) null;
      }
    }

    [Token(Token = "0x1700069A")]
    public int ArtifactNum
    {
      [Token(Token = "0x6004393"), Address(RVA = "0x11C7CB0", Offset = "0x11C6AB0", VA = "0x111C7CB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700069B")]
    public int ArtifactCap
    {
      [Token(Token = "0x6004394"), Address(RVA = "0x11C7C40", Offset = "0x11C6A40", VA = "0x111C7C40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6004395")]
    [Address(RVA = "0x11AC1B0", Offset = "0x11AAFB0", VA = "0x111AC1B0")]
    public int GetArtifactNumByRarity(string iname, int rarity) => new int();

    [Token(Token = "0x6004396")]
    [Address(RVA = "0x11BCC00", Offset = "0x11BBA00", VA = "0x111BCC00")]
    private void ResetArtifacts()
    {
    }

    [Token(Token = "0x6004397")]
    [Address(RVA = "0x119D380", Offset = "0x119C180", VA = "0x1119D380")]
    private void AddArtifact(ArtifactData item)
    {
    }

    [Token(Token = "0x6004398")]
    [Address(RVA = "0x11BC5F0", Offset = "0x11BB3F0", VA = "0x111BC5F0")]
    private void RemoveArtifact(ArtifactData item)
    {
    }

    [Token(Token = "0x6004399")]
    [Address(RVA = "0x119D1A0", Offset = "0x119BFA0", VA = "0x1119D1A0")]
    private void AddArtifaceNumByRarity(ArtifactData item)
    {
    }

    [Token(Token = "0x600439A")]
    [Address(RVA = "0x11BC4A0", Offset = "0x11BB2A0", VA = "0x111BC4A0")]
    private void RemoveArtifactNumByRarity(ArtifactData item)
    {
    }

    [Token(Token = "0x1700069C")]
    public List<string> Skins
    {
      [Token(Token = "0x600439B"), Address(RVA = "0xA223C0", Offset = "0xA211C0", VA = "0x10A223C0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x1700069D")]
    public int FriendCap
    {
      [Token(Token = "0x600439C"), Address(RVA = "0x11C85F0", Offset = "0x11C73F0", VA = "0x111C85F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700069E")]
    public int FriendNum
    {
      [Token(Token = "0x600439D"), Address(RVA = "0x11C8680", Offset = "0x11C7480", VA = "0x111C8680")] get
      {
        return new int();
      }
      [Token(Token = "0x600439E"), Address(RVA = "0x11C9240", Offset = "0x11C8040", VA = "0x111C9240")] set
      {
      }
    }

    [Token(Token = "0x1700069F")]
    public int FollowerNum
    {
      [Token(Token = "0x600439F"), Address(RVA = "0x6DA850", Offset = "0x6D9650", VA = "0x106DA850")] get
      {
        return new int();
      }
      [Token(Token = "0x60043A0"), Address(RVA = "0x11C9220", Offset = "0x11C8020", VA = "0x111C9220")] set
      {
      }
    }

    [Token(Token = "0x170006A0")]
    public List<string> FollowerUID
    {
      [Token(Token = "0x60043A1"), Address(RVA = "0x11C85E0", Offset = "0x11C73E0", VA = "0x111C85E0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x60043A2")]
    [Address(RVA = "0x11B4050", Offset = "0x11B2E50", VA = "0x111B4050")]
    public bool IsRequestFriend() => new bool();

    [Token(Token = "0x170006A1")]
    public List<PartyData> Partys
    {
      [Token(Token = "0x60043A3"), Address(RVA = "0x2BA8C0", Offset = "0x2B96C0", VA = "0x102BA8C0")] get
      {
        return (List<PartyData>) null;
      }
    }

    [Token(Token = "0x170006A2")]
    public ItemData[] Inventory
    {
      [Token(Token = "0x60043A4"), Address(RVA = "0x11C87E0", Offset = "0x11C75E0", VA = "0x111C87E0")] get
      {
        return (ItemData[]) null;
      }
    }

    [Token(Token = "0x170006A3")]
    public int ConceptCardNum
    {
      [Token(Token = "0x60043A5"), Address(RVA = "0x11C8470", Offset = "0x11C7270", VA = "0x111C8470")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006A4")]
    public int ConceptCardCap
    {
      [Token(Token = "0x60043A6"), Address(RVA = "0x11C8400", Offset = "0x11C7200", VA = "0x111C8400")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006A5")]
    public bool UnreadMailPeriod
    {
      [Token(Token = "0x60043A7"), Address(RVA = "0x11C8F80", Offset = "0x11C7D80", VA = "0x111C8F80")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043A8"), Address(RVA = "0x11C9520", Offset = "0x11C8320", VA = "0x111C9520")] set
      {
      }
    }

    [Token(Token = "0x170006A6")]
    public bool UnreadMail
    {
      [Token(Token = "0x60043A9"), Address(RVA = "0x11C8F90", Offset = "0x11C7D90", VA = "0x111C8F90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006A7")]
    public bool ValidGpsGift
    {
      [Token(Token = "0x60043AA"), Address(RVA = "0x11C9560", Offset = "0x11C8360", VA = "0x111C9560")] set
      {
      }
      [Token(Token = "0x60043AB"), Address(RVA = "0x11C8FB0", Offset = "0x11C7DB0", VA = "0x111C8FB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006A8")]
    public bool ValidFriendPresent
    {
      [Token(Token = "0x60043AC"), Address(RVA = "0x11C9540", Offset = "0x11C8340", VA = "0x111C9540")] set
      {
      }
      [Token(Token = "0x60043AD"), Address(RVA = "0x11C8FA0", Offset = "0x11C7DA0", VA = "0x111C8FA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006A9")]
    public string SelectedAward
    {
      [Token(Token = "0x60043AE"), Address(RVA = "0xA21C20", Offset = "0xA20A20", VA = "0x10A21C20")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60043AF"), Address(RVA = "0x11C94C0", Offset = "0x11C82C0", VA = "0x111C94C0")] set
      {
      }
    }

    [Token(Token = "0x170006AA")]
    public int VERSUS_POINT
    {
      [Token(Token = "0x60043B0"), Address(RVA = "0x93F560", Offset = "0x93E360", VA = "0x1093F560")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006AB")]
    public int VersusFreeWinCnt
    {
      [Token(Token = "0x60043B1"), Address(RVA = "0x11C8FF0", Offset = "0x11C7DF0", VA = "0x111C8FF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006AC")]
    public int VersusTowerWinCnt
    {
      [Token(Token = "0x60043B2"), Address(RVA = "0x11C90B0", Offset = "0x11C7EB0", VA = "0x111C90B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006AD")]
    public int VersusFriendWinCnt
    {
      [Token(Token = "0x60043B3"), Address(RVA = "0x11C9050", Offset = "0x11C7E50", VA = "0x111C9050")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006AE")]
    public int VersusFreeCnt
    {
      [Token(Token = "0x60043B4"), Address(RVA = "0x11C8FC0", Offset = "0x11C7DC0", VA = "0x111C8FC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006AF")]
    public int VersusTowerCnt
    {
      [Token(Token = "0x60043B5"), Address(RVA = "0x11C9080", Offset = "0x11C7E80", VA = "0x111C9080")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006B0")]
    public int VersusFriendCnt
    {
      [Token(Token = "0x60043B6"), Address(RVA = "0x11C9020", Offset = "0x11C7E20", VA = "0x111C9020")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006B1")]
    public int VersusTowerFloor
    {
      [Token(Token = "0x60043B7"), Address(RVA = "0x7446C0", Offset = "0x7434C0", VA = "0x107446C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006B2")]
    public int VersusTowerKey
    {
      [Token(Token = "0x60043B8"), Address(RVA = "0xA21C70", Offset = "0xA20A70", VA = "0x10A21C70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006B3")]
    public int VersusTowerWinBonus
    {
      [Token(Token = "0x60043B9"), Address(RVA = "0x7446D0", Offset = "0x7434D0", VA = "0x107446D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006B4")]
    public bool VersusSeazonGiftReceipt
    {
      [Token(Token = "0x60043BA"), Address(RVA = "0x1105E40", Offset = "0x1104C40", VA = "0x11105E40")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043BB"), Address(RVA = "0x11C9580", Offset = "0x11C8380", VA = "0x111C9580")] set
      {
      }
    }

    [Token(Token = "0x170006B5")]
    public int RankMatchRank
    {
      [Token(Token = "0x60043BC"), Address(RVA = "0x349510", Offset = "0x348310", VA = "0x10349510")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006B6")]
    public int RankMatchScore
    {
      [Token(Token = "0x60043BD"), Address(RVA = "0x319820", Offset = "0x318620", VA = "0x10319820")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006B7")]
    public RankMatchClass RankMatchClass
    {
      [Token(Token = "0x60043BE"), Address(RVA = "0x349560", Offset = "0x348360", VA = "0x10349560")] get
      {
        return new RankMatchClass();
      }
    }

    [Token(Token = "0x170006B8")]
    public int RankMatchBattlePoint
    {
      [Token(Token = "0x60043BF"), Address(RVA = "0x349520", Offset = "0x348320", VA = "0x10349520")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006B9")]
    public int RankMatchStreakWin
    {
      [Token(Token = "0x60043C0"), Address(RVA = "0x349540", Offset = "0x348340", VA = "0x10349540")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006BA")]
    public int RankMatchOldRank
    {
      [Token(Token = "0x60043C1"), Address(RVA = "0x349550", Offset = "0x348350", VA = "0x10349550")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006BB")]
    public int RankMatchOldScore
    {
      [Token(Token = "0x60043C2"), Address(RVA = "0x11C8C40", Offset = "0x11C7A40", VA = "0x111C8C40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006BC")]
    public RankMatchClass RankMatchOldClass
    {
      [Token(Token = "0x60043C3"), Address(RVA = "0x816E50", Offset = "0x815C50", VA = "0x10816E50")] get
      {
        return new RankMatchClass();
      }
    }

    [Token(Token = "0x170006BD")]
    public bool MultiInvitaionFlag
    {
      [Token(Token = "0x60043C4"), Address(RVA = "0x11C8AF0", Offset = "0x11C78F0", VA = "0x111C8AF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006BE")]
    public string MultiInvitaionComment
    {
      [Token(Token = "0x60043C5"), Address(RVA = "0x922CB0", Offset = "0x921AB0", VA = "0x10922CB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170006BF")]
    public int FirstFriendCount
    {
      [Token(Token = "0x60043C6"), Address(RVA = "0x1105E10", Offset = "0x1104C10", VA = "0x11105E10")] get
      {
        return new int();
      }
      [Token(Token = "0x60043C7"), Address(RVA = "0x11C9200", Offset = "0x11C8000", VA = "0x111C9200")] set
      {
      }
    }

    [Token(Token = "0x170006C0")]
    public int FirstChargeStatus
    {
      [Token(Token = "0x60043C8"), Address(RVA = "0x11C85D0", Offset = "0x11C73D0", VA = "0x111C85D0")] get
      {
        return new int();
      }
      [Token(Token = "0x60043C9"), Address(RVA = "0x11C91E0", Offset = "0x11C7FE0", VA = "0x111C91E0")] set
      {
      }
    }

    [Token(Token = "0x170006C1")]
    public long GuerrillaShopStart
    {
      [Token(Token = "0x60043CA"), Address(RVA = "0x11C86E0", Offset = "0x11C74E0", VA = "0x111C86E0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170006C2")]
    public long GuerrillaShopEnd
    {
      [Token(Token = "0x60043CB"), Address(RVA = "0x11C86C0", Offset = "0x11C74C0", VA = "0x111C86C0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170006C3")]
    public bool IsGuerrillaShopStarted
    {
      [Token(Token = "0x60043CC"), Address(RVA = "0x11C8870", Offset = "0x11C7670", VA = "0x111C8870")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043CD"), Address(RVA = "0x11C9320", Offset = "0x11C8120", VA = "0x111C9320")] set
      {
      }
    }

    [Token(Token = "0x170006C4")]
    public PlayerGuildData PlayerGuild
    {
      [Token(Token = "0x60043CE"), Address(RVA = "0x319810", Offset = "0x318610", VA = "0x10319810")] get
      {
        return (PlayerGuildData) null;
      }
    }

    [Token(Token = "0x170006C5")]
    public GuildData Guild
    {
      [Token(Token = "0x60043CF"), Address(RVA = "0x349430", Offset = "0x348230", VA = "0x10349430")] get
      {
        return (GuildData) null;
      }
    }

    [Token(Token = "0x170006C6")]
    public bool IsGuildAssign
    {
      [Token(Token = "0x60043D0"), Address(RVA = "0x11C8880", Offset = "0x11C7680", VA = "0x111C8880")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006C7")]
    public bool HasArenaReward
    {
      [Token(Token = "0x60043D1"), Address(RVA = "0x11C8770", Offset = "0x11C7570", VA = "0x111C8770")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043D2"), Address(RVA = "0x11C9280", Offset = "0x11C8080", VA = "0x111C9280")] set
      {
      }
    }

    [Token(Token = "0x170006C8")]
    public bool HasDuelReward
    {
      [Token(Token = "0x60043D3"), Address(RVA = "0x11C8780", Offset = "0x11C7580", VA = "0x111C8780")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043D4"), Address(RVA = "0x11C92A0", Offset = "0x11C80A0", VA = "0x111C92A0")] set
      {
      }
    }

    [Token(Token = "0x170006C9")]
    public bool HasGvGReward
    {
      [Token(Token = "0x60043D5"), Address(RVA = "0x1105E20", Offset = "0x1104C20", VA = "0x11105E20")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043D6"), Address(RVA = "0x11C92E0", Offset = "0x11C80E0", VA = "0x111C92E0")] set
      {
      }
    }

    [Token(Token = "0x170006CA")]
    public int GvGMaxActionNum
    {
      [Token(Token = "0x60043D7"), Address(RVA = "0x349340", Offset = "0x348140", VA = "0x10349340")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006CB")]
    public bool HasGuildReward
    {
      [Token(Token = "0x60043D8"), Address(RVA = "0x66B000", Offset = "0x669E00", VA = "0x1066B000")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043D9"), Address(RVA = "0x11C92C0", Offset = "0x11C80C0", VA = "0x111C92C0")] set
      {
      }
    }

    [Token(Token = "0x170006CC")]
    public int GuildLeagueRate
    {
      [Token(Token = "0x60043DA"), Address(RVA = "0x66AFF0", Offset = "0x669DF0", VA = "0x1066AFF0")] get
      {
        return new int();
      }
      [Token(Token = "0x60043DB"), Address(RVA = "0x11C9260", Offset = "0x11C8060", VA = "0x111C9260")] set
      {
      }
    }

    [Token(Token = "0x170006CD")]
    public bool IsGuildGvGJoin
    {
      [Token(Token = "0x60043DC"), Address(RVA = "0x66B010", Offset = "0x669E10", VA = "0x1066B010")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043DD"), Address(RVA = "0x11C9340", Offset = "0x11C8140", VA = "0x111C9340")] set
      {
      }
    }

    [Token(Token = "0x170006CE")]
    public StoryExChallengeCountData StoryExChallengeCount
    {
      [Token(Token = "0x60043DE"), Address(RVA = "0x349330", Offset = "0x348130", VA = "0x10349330")] get
      {
        return (StoryExChallengeCountData) null;
      }
    }

    [Token(Token = "0x170006CF")]
    public int CurrentRuneStorageSize
    {
      [Token(Token = "0x60043DF"), Address(RVA = "0x11C8560", Offset = "0x11C7360", VA = "0x111C8560")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006D0")]
    public int CurrentRuneStorageUsed
    {
      [Token(Token = "0x60043E0"), Address(RVA = "0x11C8570", Offset = "0x11C7370", VA = "0x111C8570")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170006D1")]
    public bool IsRuneStorageFull
    {
      [Token(Token = "0x60043E1"), Address(RVA = "0x11C8930", Offset = "0x11C7730", VA = "0x111C8930")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006D2")]
    public bool IsNeedToCombatPowerRequest
    {
      [Token(Token = "0x60043E2"), Address(RVA = "0x11C88F0", Offset = "0x11C76F0", VA = "0x111C88F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006D3")]
    public bool HomeGuildBadge
    {
      [Token(Token = "0x60043E3"), Address(RVA = "0x11C87D0", Offset = "0x11C75D0", VA = "0x111C87D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043E4"), Address(RVA = "0x11C9300", Offset = "0x11C8100", VA = "0x111C9300")] set
      {
      }
    }

    [Token(Token = "0x170006D4")]
    public bool IsPublicInfoBadge
    {
      [Token(Token = "0x60043E5"), Address(RVA = "0x11C8910", Offset = "0x11C7710", VA = "0x111C8910")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043E6"), Address(RVA = "0x11C93E0", Offset = "0x11C81E0", VA = "0x111C93E0")] set
      {
      }
    }

    [Token(Token = "0x170006D5")]
    public int MasteryRank
    {
      [Token(Token = "0x60043E7"), Address(RVA = "0x11C8AE0", Offset = "0x11C78E0", VA = "0x111C8AE0")] get
      {
        return new int();
      }
      [Token(Token = "0x60043E8"), Address(RVA = "0x11C9420", Offset = "0x11C8220", VA = "0x111C9420")] set
      {
      }
    }

    [Token(Token = "0x170006D6")]
    public bool IsMasteryNotRewarded
    {
      [Token(Token = "0x60043E9"), Address(RVA = "0x11C88E0", Offset = "0x11C76E0", VA = "0x111C88E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043EA"), Address(RVA = "0x11C93C0", Offset = "0x11C81C0", VA = "0x111C93C0")] set
      {
      }
    }

    [Token(Token = "0x170006D7")]
    public int TobiraMasterUnitNum
    {
      [Token(Token = "0x60043EB"), Address(RVA = "0x11C8EF0", Offset = "0x11C7CF0", VA = "0x111C8EF0")] get
      {
        return new int();
      }
      [Token(Token = "0x60043EC"), Address(RVA = "0x11C94E0", Offset = "0x11C82E0", VA = "0x111C94E0")] set
      {
      }
    }

    [Token(Token = "0x170006D8")]
    public List<CrystalData> Crystals
    {
      [Token(Token = "0x60043ED"), Address(RVA = "0xA23070", Offset = "0xA21E70", VA = "0x10A23070")] get
      {
        return (List<CrystalData>) null;
      }
    }

    [Token(Token = "0x170006D9")]
    public bool IsLeaguematchNotComplete
    {
      [Token(Token = "0x60043EE"), Address(RVA = "0x11C88C0", Offset = "0x11C76C0", VA = "0x111C88C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043EF"), Address(RVA = "0x11C9380", Offset = "0x11C8180", VA = "0x111C9380")] set
      {
      }
    }

    [Token(Token = "0x170006DA")]
    public bool IsLeaguematchNoticeOption
    {
      [Token(Token = "0x60043F0"), Address(RVA = "0x11C88D0", Offset = "0x11C76D0", VA = "0x111C88D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043F1"), Address(RVA = "0x11C93A0", Offset = "0x11C81A0", VA = "0x111C93A0")] set
      {
      }
    }

    [Token(Token = "0x170006DB")]
    public bool IsLeaguematchMatchingPeriod
    {
      [Token(Token = "0x60043F2"), Address(RVA = "0x11C88B0", Offset = "0x11C76B0", VA = "0x111C88B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043F3"), Address(RVA = "0x11C9360", Offset = "0x11C8160", VA = "0x111C9360")] set
      {
      }
    }

    [Token(Token = "0x170006DC")]
    public JSON_ArtifactStoneEffectHomeParam ArtifactStoneOnHold
    {
      [Token(Token = "0x60043F4"), Address(RVA = "0x11C7CF0", Offset = "0x11C6AF0", VA = "0x111C7CF0")] get
      {
        return (JSON_ArtifactStoneEffectHomeParam) null;
      }
      [Token(Token = "0x60043F5"), Address(RVA = "0x11C91C0", Offset = "0x11C7FC0", VA = "0x111C91C0")] set
      {
      }
    }

    [Token(Token = "0x170006DD")]
    public bool IsRaidbossInvalidRewarded
    {
      [Token(Token = "0x60043F6"), Address(RVA = "0x11C8920", Offset = "0x11C7720", VA = "0x111C8920")] get
      {
        return new bool();
      }
      [Token(Token = "0x60043F7"), Address(RVA = "0x11C9400", Offset = "0x11C8200", VA = "0x111C9400")] set
      {
      }
    }

    [Token(Token = "0x60043F8")]
    [Address(RVA = "0x11A16F0", Offset = "0x11A04F0", VA = "0x111A16F0")]
    public bool ConsumeStamina(int stamina) => new bool();

    [Token(Token = "0x60043F9")]
    [Address(RVA = "0x11A38B0", Offset = "0x11A26B0", VA = "0x111A38B0")]
    public bool DEBUG_CONSUME_COIN(int coin) => new bool();

    [Token(Token = "0x60043FA")]
    [Address(RVA = "0x11A3A60", Offset = "0x11A2860", VA = "0x111A3A60")]
    public bool DEBUG_CONSUME_PAID_COIN(int coin) => new bool();

    [Token(Token = "0x60043FB")]
    [Address(RVA = "0x11A2C10", Offset = "0x11A1A10", VA = "0x111A2C10")]
    public void DEBUG_ADD_COIN(int free, int paid, int com)
    {
    }

    [Token(Token = "0x60043FC")]
    [Address(RVA = "0x11BE280", Offset = "0x11BD080", VA = "0x111BE280")]
    public void SetCoinPurchaseResult(FulfillmentResult result)
    {
    }

    [Token(Token = "0x60043FD")]
    [Address(RVA = "0x11B30A0", Offset = "0x11B1EA0", VA = "0x111B30A0")]
    public bool IsGuerrillaShopOpen() => new bool();

    [Token(Token = "0x60043FE")]
    [Address(RVA = "0x11A3D70", Offset = "0x11A2B70", VA = "0x111A3D70")]
    public void DEBUG_REPAIR_STAMINA()
    {
    }

    [Token(Token = "0x60043FF")]
    [Address(RVA = "0x11A2CF0", Offset = "0x11A1AF0", VA = "0x111A2CF0")]
    public void DEBUG_ADD_GOLD(int gold)
    {
    }

    [Token(Token = "0x6004400")]
    [Address(RVA = "0x11C65B0", Offset = "0x11C53B0", VA = "0x111C65B0")]
    public PlayerData()
    {
    }

    [Token(Token = "0x6004401")]
    [Address(RVA = "0x11BD690", Offset = "0x11BC490", VA = "0x111BD690")]
    public Json_PlayerData Serialize() => (Json_PlayerData) null;

    [Token(Token = "0x6004402")]
    [Address(RVA = "0x11A6E40", Offset = "0x11A5C40", VA = "0x111A6E40")]
    public bool Deserialize(Json_PlayerData json, PlayerData.EDeserializeFlags flag) => new bool();

    [Token(Token = "0x6004403")]
    [Address(RVA = "0x11A7A70", Offset = "0x11A6870", VA = "0x111A7A70")]
    public bool Deserialize(Json_ArenaPlayers json) => new bool();

    [Token(Token = "0x6004404")]
    [Address(RVA = "0x11BE840", Offset = "0x11BD640", VA = "0x111BE840")]
    public void SetGvGMaxActionNum(int maxActionNum)
    {
    }

    [Token(Token = "0x6004405")]
    [Address(RVA = "0x11A5430", Offset = "0x11A4230", VA = "0x111A5430")]
    public bool Deserialize(Json_ArenaEnemies json) => new bool();

    [Token(Token = "0x6004406")]
    [Address(RVA = "0x11A5CE0", Offset = "0x11A4AE0", VA = "0x111A5CE0")]
    public void Deserialize(Json_PlayerData json)
    {
    }

    [Token(Token = "0x6004407")]
    [Address(RVA = "0x11A9AF0", Offset = "0x11A88F0", VA = "0x111A9AF0")]
    public void Deserialize(Json_TrophyPlayerData json)
    {
    }

    [Token(Token = "0x6004408")]
    [Address(RVA = "0x11A5B90", Offset = "0x11A4990", VA = "0x111A5B90")]
    public void Deserialize(Json_Currencies json)
    {
    }

    [Token(Token = "0x6004409")]
    [Address(RVA = "0x11A49A0", Offset = "0x11A37A0", VA = "0x111A49A0")]
    public void Deserialize(Json_MailInfo json)
    {
    }

    [Token(Token = "0x600440A")]
    [Address(RVA = "0x11A95B0", Offset = "0x11A83B0", VA = "0x111A95B0")]
    public void Deserialize(Json_Unit[] units, JSON_PlayerBuff _buff = null)
    {
    }

    [Token(Token = "0x600440B")]
    [Address(RVA = "0x11A56C0", Offset = "0x11A44C0", VA = "0x111A56C0")]
    public void Deserialize(Json_Item[] items)
    {
    }

    [Token(Token = "0x600440C")]
    [Address(RVA = "0x11A4130", Offset = "0x11A2F30", VA = "0x111A4130")]
    public void DeserializeOverWrite(Json_Artifact[] artifacts)
    {
    }

    [Token(Token = "0x600440D")]
    [Address(RVA = "0x11A42B0", Offset = "0x11A30B0", VA = "0x111A42B0")]
    public bool DeserializeUpdate(Json_Artifact[] artifacts) => new bool();

    [Token(Token = "0x600440E")]
    [Address(RVA = "0x11A5130", Offset = "0x11A3F30", VA = "0x111A5130")]
    public void Deserialize(Json_Artifact[] artifacts, bool differenceUpdate)
    {
    }

    [Token(Token = "0x600440F")]
    [Address(RVA = "0x11A91B0", Offset = "0x11A7FB0", VA = "0x111A91B0")]
    public void Deserialize(JSON_ConceptCard concept_cards)
    {
    }

    [Token(Token = "0x6004410")]
    [Address(RVA = "0x11A7C50", Offset = "0x11A6A50", VA = "0x111A7C50")]
    public void Deserialize(JSON_ConceptCard[] concept_cards, bool is_data_override = true)
    {
    }

    [Token(Token = "0x6004411")]
    [Address(RVA = "0x11A7470", Offset = "0x11A6270", VA = "0x111A7470")]
    public void Deserialize(
      JSON_ConceptCardMaterial[] concept_card_materials,
      bool is_data_override = true)
    {
    }

    [Token(Token = "0x6004412")]
    [Address(RVA = "0x11A8180", Offset = "0x11A6F80", VA = "0x111A8180")]
    public void Deserialize(string[] inames)
    {
    }

    [Token(Token = "0x6004413")]
    [Address(RVA = "0x11A99C0", Offset = "0x11A87C0", VA = "0x111A99C0")]
    public void Deserialize(Json_Skin[] skins)
    {
    }

    [Token(Token = "0x6004414")]
    [Address(RVA = "0x11A7730", Offset = "0x11A6530", VA = "0x111A7730")]
    public void Deserialize(JSON_CrystalData crystal)
    {
    }

    [Token(Token = "0x6004415")]
    [Address(RVA = "0x11A49D0", Offset = "0x11A37D0", VA = "0x111A49D0")]
    public void Deserialize(JSON_CrystalData[] crystals)
    {
    }

    [Token(Token = "0x6004416")]
    [Address(RVA = "0x11A87B0", Offset = "0x11A75B0", VA = "0x111A87B0")]
    public void Deserialize(Json_Party[] parties)
    {
    }

    [Token(Token = "0x6004417")]
    [Address(RVA = "0x11A52D0", Offset = "0x11A40D0", VA = "0x111A52D0")]
    public bool Deserialize(Json_Mail[] mails) => new bool();

    [Token(Token = "0x6004418")]
    [Address(RVA = "0x11A8D10", Offset = "0x11A7B10", VA = "0x111A8D10")]
    public bool Deserialize(Json_Mails mails) => new bool();

    [Token(Token = "0x6004419")]
    [Address(RVA = "0x11A8CD0", Offset = "0x11A7AD0", VA = "0x111A8CD0")]
    public void Deserialize(Json_Friend[] friends)
    {
    }

    [Token(Token = "0x600441A")]
    [Address(RVA = "0x11A8F60", Offset = "0x11A7D60", VA = "0x111A8F60")]
    public void Deserialize(Json_Friend[] friends, FriendStates state)
    {
    }

    [Token(Token = "0x600441B")]
    [Address(RVA = "0x11A4F80", Offset = "0x11A3D80", VA = "0x111A4F80")]
    public void Deserialize(Json_Support[] supports)
    {
    }

    [Token(Token = "0x600441C")]
    [Address(RVA = "0x11A59E0", Offset = "0x11A47E0", VA = "0x111A59E0")]
    public void Deserialize(Json_MultiFuids[] fuids)
    {
    }

    [Token(Token = "0x600441D")]
    [Address(RVA = "0x11A8AA0", Offset = "0x11A78A0", VA = "0x111A8AA0")]
    public void Deserialize(FriendPresentWishList.Json[] jsons)
    {
    }

    [Token(Token = "0x600441E")]
    [Address(RVA = "0x11A86D0", Offset = "0x11A74D0", VA = "0x111A86D0")]
    public void Deserialize(FriendPresentReceiveList.Json[] jsons)
    {
    }

    [Token(Token = "0x600441F")]
    [Address(RVA = "0x11A6AE0", Offset = "0x11A58E0", VA = "0x111A6AE0")]
    public bool Deserialize(Json_Notify notify) => new bool();

    [Token(Token = "0x6004420")]
    [Address(RVA = "0x11A4830", Offset = "0x11A3630", VA = "0x111A4830")]
    public bool Deserialize(Json_Notify_Monthly notify) => new bool();

    [Token(Token = "0x6004421")]
    [Address(RVA = "0x11B1290", Offset = "0x11B0090", VA = "0x111B1290")]
    public void InitLoginBonusTable()
    {
    }

    [Token(Token = "0x6004422")]
    [Address(RVA = "0x11C3DB0", Offset = "0x11C2BB0", VA = "0x111C3DB0")]
    public void UpdateLoginBonusTable(Json_Notify_Monthly notify)
    {
    }

    [Token(Token = "0x6004423")]
    [Address(RVA = "0x11A1D90", Offset = "0x11A0B90", VA = "0x111A1D90")]
    public Json_LoginBonusTable[] CreateLoginBonusData(Json_LoginBonusTable[] originals)
    {
      return (Json_LoginBonusTable[]) null;
    }

    [Token(Token = "0x6004424")]
    [Address(RVA = "0x11A2340", Offset = "0x11A1140", VA = "0x111A2340")]
    private Json_LoginBonusTable CreateLoginBonusTable(
      List<Dictionary<string, object>> tables,
      Json_LoginBonusTable orig)
    {
      return (Json_LoginBonusTable) null;
    }

    [Token(Token = "0x6004425")]
    [Address(RVA = "0x11A7900", Offset = "0x11A6700", VA = "0x111A7900")]
    public bool Deserialize(JSON_PlayerCoinBuyUseBonusState[] bonus_stats) => new bool();

    [Token(Token = "0x6004426")]
    [Address(RVA = "0x11A55C0", Offset = "0x11A43C0", VA = "0x111A55C0")]
    public bool Deserialize(
      JSON_PlayerCoinBuyUseBonusRewardState[] reward_stats)
    {
      return new bool();
    }

    [Token(Token = "0x6004427")]
    [Address(RVA = "0x11A5400", Offset = "0x11A4200", VA = "0x111A5400")]
    public bool Deserialize(Json_AutoRepeatQuestData progress, bool override_drop = true)
    {
      return new bool();
    }

    [Token(Token = "0x6004428")]
    [Address(RVA = "0x11A8280", Offset = "0x11A7080", VA = "0x111A8280")]
    public bool Deserialize(JSON_PartyOverWrite[] ow_party) => new bool();

    [Token(Token = "0x6004429")]
    [Address(RVA = "0x11A1250", Offset = "0x11A0050", VA = "0x111A1250")]
    public void ClearPartyOverWriteDatas()
    {
    }

    [Token(Token = "0x600442A")]
    [Address(RVA = "0x11A1280", Offset = "0x11A0080", VA = "0x111A1280")]
    public void ClearPartyOverWriteDatas(eOverWritePartyType partyType)
    {
    }

    [Token(Token = "0x600442B")]
    [Address(RVA = "0x11A85D0", Offset = "0x11A73D0", VA = "0x111A85D0")]
    public bool Deserialize(Json_InvalidSkill[] json, EInvalidSkillApplyType apply_type = EInvalidSkillApplyType.COMMON)
    {
      return new bool();
    }

    [Token(Token = "0x600442C")]
    [Address(RVA = "0x11BD4D0", Offset = "0x11BC2D0", VA = "0x111BD4D0")]
    public Json_BondData[] SerializeBonds() => (Json_BondData[]) null;

    [Token(Token = "0x600442D")]
    [Address(RVA = "0x11A6BA0", Offset = "0x11A59A0", VA = "0x111A6BA0")]
    public bool Deserialize(Json_BondData[] json, bool is_refresh = true) => new bool();

    [Token(Token = "0x600442E")]
    private T[] SortToIntegerOrderedJsonObject<T>(Dictionary<string, object> json) where T : class
    {
      return (T[]) null;
    }

    [Token(Token = "0x600442F")]
    [Address(RVA = "0x11A2140", Offset = "0x11A0F40", VA = "0x111A2140")]
    private List<Dictionary<string, object>> CreateLoginBonusTableFromJson()
    {
      return (List<Dictionary<string, object>>) null;
    }

    [Token(Token = "0x6004430")]
    [Address(RVA = "0x11A1EA0", Offset = "0x11A0CA0", VA = "0x111A1EA0")]
    private Json_LoginBonus[] CreateLoginBonusItemTable(Dictionary<string, object> json)
    {
      return (Json_LoginBonus[]) null;
    }

    [Token(Token = "0x6004431")]
    [Address(RVA = "0x11A27F0", Offset = "0x11A15F0", VA = "0x111A27F0")]
    private Json_PremiumLoginBonus[] CreatePremiumLoginBonusItemTable(
      Dictionary<string, object> json)
    {
      return (Json_PremiumLoginBonus[]) null;
    }

    [Token(Token = "0x6004432")]
    [Address(RVA = "0x11A9380", Offset = "0x11A8180", VA = "0x111A9380")]
    public void Deserialize(Json_Versus json)
    {
    }

    [Token(Token = "0x6004433")]
    [Address(RVA = "0x11C02A0", Offset = "0x11BF0A0", VA = "0x111C02A0")]
    public void SetVersusWinCount(VERSUS_TYPE type, int wincnt)
    {
    }

    [Token(Token = "0x6004434")]
    [Address(RVA = "0x119DCC0", Offset = "0x119CAC0", VA = "0x1119DCC0")]
    public void AddVersusTotalCount(VERSUS_TYPE type, int addcnt)
    {
    }

    [Token(Token = "0x6004435")]
    [Address(RVA = "0x11C0270", Offset = "0x11BF070", VA = "0x111C0270")]
    public void SetVersusTotalCount(VERSUS_TYPE type, int cnt)
    {
    }

    [Token(Token = "0x6004436")]
    [Address(RVA = "0x11C0250", Offset = "0x11BF050", VA = "0x111C0250")]
    public void SetVersusRankpoint(int point)
    {
    }

    [Token(Token = "0x6004437")]
    [Address(RVA = "0x11BE860", Offset = "0x11BD660", VA = "0x111BE860")]
    public void SetHaveAward(string[] awards)
    {
    }

    [Token(Token = "0x6004438")]
    [Address(RVA = "0x11A4E50", Offset = "0x11A3C50", VA = "0x111A4E50")]
    public void Deserialize(JSON_PlayerGuild player_guild)
    {
    }

    [Token(Token = "0x6004439")]
    [Address(RVA = "0x11A8B80", Offset = "0x11A7980", VA = "0x111A8B80")]
    public void Deserialize(JSON_Guild guild)
    {
    }

    [Token(Token = "0x600443A")]
    [Address(RVA = "0x11A6B60", Offset = "0x11A5960", VA = "0x111A6B60")]
    public void Deserialize(
      JSON_StoryExChallengeCount story_ex_challenge_count)
    {
    }

    [Token(Token = "0x600443B")]
    [Address(RVA = "0x11A4A90", Offset = "0x11A3890", VA = "0x111A4A90")]
    public void Deserialize(string[] trophy_daily_clear, bool is_available)
    {
    }

    [Token(Token = "0x170006DE")]
    public bool IsFirstLogin
    {
      [Token(Token = "0x600443C"), Address(RVA = "0x5EF100", Offset = "0x5EDF00", VA = "0x105EF100")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600443D")]
    [Address(RVA = "0x11AB470", Offset = "0x11AA270", VA = "0x111AB470")]
    public void ForceFirstLogin()
    {
    }

    [Token(Token = "0x600443E")]
    [Address(RVA = "0x11B6170", Offset = "0x11B4F70", VA = "0x111B6170")]
    public int LoginCountWithType(string type) => new int();

    [Token(Token = "0x170006DF")]
    public Json_LoginBonus RecentLoginBonus
    {
      [Token(Token = "0x600443F"), Address(RVA = "0x11C8C80", Offset = "0x11C7A80", VA = "0x111C8C80")] get
      {
        return (Json_LoginBonus) null;
      }
    }

    [Token(Token = "0x6004440")]
    [Address(RVA = "0x11AAA40", Offset = "0x11A9840", VA = "0x111AAA40")]
    public Json_LoginBonus FindRecentLoginBonus(string type) => (Json_LoginBonus) null;

    [Token(Token = "0x170006E0")]
    public Json_LoginBonusTable LoginBonus28days
    {
      [Token(Token = "0x6004441"), Address(RVA = "0x349590", Offset = "0x348390", VA = "0x10349590")] get
      {
        return (Json_LoginBonusTable) null;
      }
    }

    [Token(Token = "0x170006E1")]
    public Json_LoginBonus[] LoginBonus
    {
      [Token(Token = "0x6004442"), Address(RVA = "0x66A5A0", Offset = "0x6693A0", VA = "0x1066A5A0")] get
      {
        return (Json_LoginBonus[]) null;
      }
    }

    [Token(Token = "0x170006E2")]
    public Json_LoginBonusTable LoginBonus30days
    {
      [Token(Token = "0x6004443"), Address(RVA = "0x349500", Offset = "0x348300", VA = "0x10349500")] get
      {
        return (Json_LoginBonusTable) null;
      }
    }

    [Token(Token = "0x6004444")]
    [Address(RVA = "0x11AA6F0", Offset = "0x11A94F0", VA = "0x111AA6F0")]
    public Json_LoginBonus[] FindLoginBonuses(string type) => (Json_LoginBonus[]) null;

    [Token(Token = "0x170006E3")]
    public int LoginBonusCount
    {
      [Token(Token = "0x6004445"), Address(RVA = "0x9A04B0", Offset = "0x99F2B0", VA = "0x109A04B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6004446")]
    [Address(RVA = "0x11AEB60", Offset = "0x11AD960", VA = "0x111AEB60")]
    public string GetLoginBonusePrefabName(string type) => (string) null;

    [Token(Token = "0x6004447")]
    [Address(RVA = "0x11AEBF0", Offset = "0x11AD9F0", VA = "0x111AEBF0")]
    public string[] GetLoginBonuseUnitIDs(string type) => (string[]) null;

    [Token(Token = "0x6004448")]
    [Address(RVA = "0x11B3890", Offset = "0x11B2690", VA = "0x111B3890")]
    public bool IsLoginBonusPremium(string type) => new bool();

    [Token(Token = "0x6004449")]
    [Address(RVA = "0x11AEAC0", Offset = "0x11AD8C0", VA = "0x111AEAC0")]
    public Json_LoginBonusTable GetLoginBonus(string type) => (Json_LoginBonusTable) null;

    [Token(Token = "0x600444A")]
    [Address(RVA = "0x11B37F0", Offset = "0x11B25F0", VA = "0x111B37F0")]
    public bool IsLastLoginBonus(string type) => new bool();

    [Token(Token = "0x600444B")]
    [Address(RVA = "0x11AE8F0", Offset = "0x11AD6F0", VA = "0x111AE8F0")]
    public int[] GetLoginBonusLoginDays(string type) => (int[]) null;

    [Token(Token = "0x600444C")]
    [Address(RVA = "0x11AEA20", Offset = "0x11AD820", VA = "0x111AEA20")]
    public int GetLoginBonusRemainRecover(string type) => new int();

    [Token(Token = "0x600444D")]
    [Address(RVA = "0x11AE980", Offset = "0x11AD780", VA = "0x111AE980")]
    public int GetLoginBonusMaxRecover(string type) => new int();

    [Token(Token = "0x600444E")]
    [Address(RVA = "0x11AE850", Offset = "0x11AD650", VA = "0x111AE850")]
    public int GetLoginBonusCurrentMonth(string type) => new int();

    [Token(Token = "0x600444F")]
    [Address(RVA = "0x11B3930", Offset = "0x11B2730", VA = "0x111B3930")]
    public bool IsLoginBonusTable(string type) => new bool();

    [Token(Token = "0x6004450")]
    [Address(RVA = "0x11BFC30", Offset = "0x11BEA30", VA = "0x111BFC30")]
    public void SetRuneStorageNum(int value)
    {
    }

    [Token(Token = "0x6004451")]
    [Address(RVA = "0x11BFC80", Offset = "0x11BEA80", VA = "0x111BFC80")]
    public void SetRuneStorageUsedNum(int value)
    {
    }

    [Token(Token = "0x6004452")]
    [Address(RVA = "0x11A4BA0", Offset = "0x11A39A0", VA = "0x111A4BA0")]
    public void Deserialize(ReqGetRune.Response json, bool is_data_override)
    {
    }

    [Token(Token = "0x6004453")]
    [Address(RVA = "0x11A4C80", Offset = "0x11A3A80", VA = "0x111A4C80")]
    public void Deserialize(Json_RuneEnforceGaugeData[] rune_enforce_gauge)
    {
    }

    [Token(Token = "0x6004454")]
    [Address(RVA = "0x11A8EB0", Offset = "0x11A7CB0", VA = "0x111A8EB0")]
    public void Deserialize(Json_RuneData[] runes, bool is_data_override)
    {
    }

    [Token(Token = "0x6004455")]
    [Address(RVA = "0x11A4500", Offset = "0x11A3300", VA = "0x111A4500")]
    public void Deserialize(Json_RuneData rune)
    {
    }

    [Token(Token = "0x6004456")]
    [Address(RVA = "0x11A7A00", Offset = "0x11A6800", VA = "0x111A7A00")]
    public void Deserialize(ReqRuneStorageAdd.Response json)
    {
    }

    [Token(Token = "0x6004457")]
    [Address(RVA = "0x11A7A20", Offset = "0x11A6820", VA = "0x111A7A20")]
    public void Deserialize(ReqRuneFavorite.Response json)
    {
    }

    [Token(Token = "0x6004458")]
    [Address(RVA = "0x11A0ED0", Offset = "0x119FCD0", VA = "0x111A0ED0")]
    public bool CheckUnlock(UnlockTargets target) => new bool();

    [Token(Token = "0x6004459")]
    [Address(RVA = "0x11BEFA0", Offset = "0x11BDDA0", VA = "0x111BEFA0")]
    public void SetParty(int index, PartyData party)
    {
    }

    [Token(Token = "0x600445A")]
    [Address(RVA = "0x11AAFC0", Offset = "0x11A9DC0", VA = "0x111AAFC0")]
    public UnitData FindUnitDataByUnitID(string iname) => (UnitData) null;

    [Token(Token = "0x600445B")]
    [Address(RVA = "0x11AAE50", Offset = "0x11A9C50", VA = "0x111AAE50")]
    public UnitData FindUnitDataByUniqueID(long iid) => (UnitData) null;

    [Token(Token = "0x600445C")]
    [Address(RVA = "0x11AAF20", Offset = "0x11A9D20", VA = "0x111AAF20")]
    public UnitData FindUnitDataByUniqueParam(UnitParam unit) => (UnitData) null;

    [Token(Token = "0x600445D")]
    [Address(RVA = "0x11AB080", Offset = "0x11A9E80", VA = "0x111AB080")]
    public UnitData FindUnitDataCheckUnitOverWrite(
      PlayerPartyTypes party_type,
      string iname = null,
      long iid = 0,
      UnitParam unit = null)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600445E")]
    [Address(RVA = "0x11AA960", Offset = "0x11A9760", VA = "0x111AA960")]
    public PartyData FindPartyOfType(PlayerPartyTypes type) => (PartyData) null;

    [Token(Token = "0x600445F")]
    [Address(RVA = "0x11BFB60", Offset = "0x11BE960", VA = "0x111BFB60")]
    public void SetQuestState(string name, QuestStates st)
    {
    }

    [Token(Token = "0x6004460")]
    [Address(RVA = "0x11BD000", Offset = "0x11BBE00", VA = "0x111BD000")]
    public void ResetQuestStates()
    {
    }

    [Token(Token = "0x6004461")]
    [Address(RVA = "0x11BCD20", Offset = "0x11BBB20", VA = "0x111BCD20")]
    public void ResetQuestChallengeResets()
    {
    }

    [Token(Token = "0x6004462")]
    [Address(RVA = "0x11BCE90", Offset = "0x11BBC90", VA = "0x111BCE90")]
    public void ResetQuestChallenges()
    {
    }

    [Token(Token = "0x6004463")]
    [Address(RVA = "0x11B6230", Offset = "0x11B5030", VA = "0x111B6230")]
    public void MarkQuestChallenged(string name)
    {
    }

    [Token(Token = "0x6004464")]
    [Address(RVA = "0x11B62A0", Offset = "0x11B50A0", VA = "0x111B62A0")]
    public void MarkQuestCleared(string name)
    {
    }

    [Token(Token = "0x6004465")]
    [Address(RVA = "0x11AA4B0", Offset = "0x11A92B0", VA = "0x111AA4B0")]
    public QuestParam FindLastStoryQuest() => (QuestParam) null;

    [Token(Token = "0x6004466")]
    [Address(RVA = "0x11BFAD0", Offset = "0x11BE8D0", VA = "0x111BFAD0")]
    public void SetQuestMissionFlags(string name, bool[] missions)
    {
    }

    [Token(Token = "0x6004467")]
    [Address(RVA = "0x11BFA70", Offset = "0x11BE870", VA = "0x111BFA70")]
    public void SetQuestMissionFlags(string name, int missions)
    {
    }

    [Token(Token = "0x6004468")]
    [Address(RVA = "0x11B3A10", Offset = "0x11B2810", VA = "0x111B3A10")]
    public bool IsQuestArchiveOpenByArea(string chapterIname) => new bool();

    [Token(Token = "0x6004469")]
    [Address(RVA = "0x11B3A70", Offset = "0x11B2870", VA = "0x111B3A70")]
    public bool IsQuestArchiveOpen(string iname) => new bool();

    [Token(Token = "0x600446A")]
    [Address(RVA = "0x11AF310", Offset = "0x11AE110", VA = "0x111AF310")]
    public OpenedQuestArchive GetOpenedQuestArchive(string iname) => (OpenedQuestArchive) null;

    [Token(Token = "0x600446B")]
    [Address(RVA = "0x11BFA00", Offset = "0x11BE800", VA = "0x111BFA00")]
    public void SetQuestChallengeNumDaily(string name, int num)
    {
    }

    [Token(Token = "0x600446C")]
    [Address(RVA = "0x11B10D0", Offset = "0x11AFED0", VA = "0x111B10D0")]
    public void IncrementQuestChallangeNumDaily(string name)
    {
    }

    [Token(Token = "0x600446D")]
    [Address(RVA = "0x11B1050", Offset = "0x11AFE50", VA = "0x111B1050")]
    public bool HasItem(string iname) => new bool();

    [Token(Token = "0x600446E")]
    [Address(RVA = "0x11AE6E0", Offset = "0x11AD4E0", VA = "0x111AE6E0")]
    public int GetItemAmount(string iname, bool is_none_cap = false) => new int();

    [Token(Token = "0x600446F")]
    [Address(RVA = "0x11AA2F0", Offset = "0x11A90F0", VA = "0x111AA2F0")]
    public ItemData FindItemDataByItemID(string iname, bool is_all = false) => (ItemData) null;

    [Token(Token = "0x6004470")]
    [Address(RVA = "0x11AA3F0", Offset = "0x11A91F0", VA = "0x111AA3F0")]
    public ItemData FindItemDataByItemParam(ItemParam param) => (ItemData) null;

    [Token(Token = "0x6004471")]
    [Address(RVA = "0x11AA250", Offset = "0x11A9050", VA = "0x111AA250")]
    public ItemData FindInventoryByItemID(string iname) => (ItemData) null;

    [Token(Token = "0x6004472")]
    [Address(RVA = "0x11B2DA0", Offset = "0x11B1BA0", VA = "0x111B2DA0")]
    public bool IsExistExpireItem_Inventory() => new bool();

    [Token(Token = "0x6004473")]
    [Address(RVA = "0x11A9E80", Offset = "0x11A8C80", VA = "0x111A9E80")]
    public ArtifactData FindArtifactByUniqueID(long iid) => (ArtifactData) null;

    [Token(Token = "0x6004474")]
    [Address(RVA = "0x11AA000", Offset = "0x11A8E00", VA = "0x111AA000")]
    public List<ArtifactData> FindArtifactsByIDs(HashSet<string> ids) => (List<ArtifactData>) null;

    [Token(Token = "0x6004475")]
    [Address(RVA = "0x11A9F40", Offset = "0x11A8D40", VA = "0x111A9F40")]
    public List<ArtifactData> FindArtifactsByArtifactID(string iname) => (List<ArtifactData>) null;

    [Token(Token = "0x6004476")]
    [Address(RVA = "0x11AE540", Offset = "0x11AD340", VA = "0x111AE540")]
    public List<ArtifactData> GetInspirationSkillLvUpArtifacts(
      ArtifactData source_artifact,
      InspirationSkillData source_insp_skill)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x6004477")]
    [Address(RVA = "0x11BC3B0", Offset = "0x11BB1B0", VA = "0x111BC3B0")]
    public void RemoveArtifactByUniqueID(long iid)
    {
    }

    [Token(Token = "0x6004478")]
    [Address(RVA = "0x11AA790", Offset = "0x11A9590", VA = "0x111AA790")]
    public bool FindOwner(
      ArtifactData arti,
      out UnitData unit,
      out JobData job,
      bool is_include_over_write = false)
    {
      return new bool();
    }

    [Token(Token = "0x6004479")]
    [Address(RVA = "0x11BEF10", Offset = "0x11BDD10", VA = "0x111BEF10")]
    public void SetPartyCurrentIndex(int index)
    {
    }

    [Token(Token = "0x600447A")]
    [Address(RVA = "0x11AD180", Offset = "0x11ABF80", VA = "0x111AD180")]
    public int GetDefensePartyIndex() => new int();

    [Token(Token = "0x600447B")]
    [Address(RVA = "0x11BE3A0", Offset = "0x11BD1A0", VA = "0x111BE3A0")]
    public void SetDefenseParty(int index)
    {
    }

    [Token(Token = "0x600447C")]
    [Address(RVA = "0x11AF460", Offset = "0x11AE260", VA = "0x111AF460")]
    public int GetPartyCurrentIndex() => new int();

    [Token(Token = "0x600447D")]
    [Address(RVA = "0x11AF4F0", Offset = "0x11AE2F0", VA = "0x111AF4F0")]
    public PartyData GetPartyCurrent() => (PartyData) null;

    [Token(Token = "0x600447E")]
    [Address(RVA = "0x119DD00", Offset = "0x119CB00", VA = "0x1119DD00")]
    public void AutoSetLeaderUnit()
    {
    }

    [Token(Token = "0x600447F")]
    [Address(RVA = "0x119DF70", Offset = "0x119CD70", VA = "0x1119DF70")]
    public static int CalcLevelFromExp(int current) => new int();

    [Token(Token = "0x6004480")]
    [Address(RVA = "0x119E040", Offset = "0x119CE40", VA = "0x1119E040")]
    public int CalcLevel() => new int();

    [Token(Token = "0x6004481")]
    [Address(RVA = "0x11AE7E0", Offset = "0x11AD5E0", VA = "0x111AE7E0")]
    public int GetLevelExp() => new int();

    [Token(Token = "0x6004482")]
    [Address(RVA = "0x11ADA30", Offset = "0x11AC830", VA = "0x111ADA30")]
    public int GetExp() => new int();

    [Token(Token = "0x6004483")]
    [Address(RVA = "0x11AEEB0", Offset = "0x11ADCB0", VA = "0x111AEEB0")]
    public int GetNextExp() => new int();

    [Token(Token = "0x6004484")]
    [Address(RVA = "0x11AB480", Offset = "0x11AA280", VA = "0x111AB480")]
    public void GainExp(int exp)
    {
    }

    [Token(Token = "0x6004485")]
    [Address(RVA = "0x11BBC80", Offset = "0x11BAA80", VA = "0x111BBC80")]
    private void PlayerLevelUp(int delta)
    {
    }

    [Token(Token = "0x6004486")]
    [Address(RVA = "0x119E150", Offset = "0x119CF50", VA = "0x1119E150")]
    public static int CalcVipRankFromPoint(int current) => new int();

    [Token(Token = "0x6004487")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void GainVipPoint(int point)
    {
    }

    [Token(Token = "0x6004488")]
    [Address(RVA = "0x119DBE0", Offset = "0x119C9E0", VA = "0x1119DBE0")]
    public void AddPaymentInfo(string productId, int num = 1)
    {
    }

    [Token(Token = "0x6004489")]
    [Address(RVA = "0x11C5FE0", Offset = "0x11C4DE0", VA = "0x111C5FE0")]
    public void UpdateUnlocks()
    {
    }

    [Token(Token = "0x600448A")]
    [Address(RVA = "0x11B2250", Offset = "0x11B1050", VA = "0x111B2250")]
    public bool IsClearUnclockConditions_Quest(string[] conds_quests) => new bool();

    [Token(Token = "0x600448B")]
    [Address(RVA = "0x11AB550", Offset = "0x11AA350", VA = "0x111AB550")]
    public void GainGold(int gold)
    {
    }

    [Token(Token = "0x600448C")]
    [Address(RVA = "0x11AA0C0", Offset = "0x11A8EC0", VA = "0x111AA0C0")]
    private ItemData FindByItemID(string itemID) => (ItemData) null;

    [Token(Token = "0x600448D")]
    [Address(RVA = "0x11A07E0", Offset = "0x119F5E0", VA = "0x111A07E0")]
    public bool CheckFreeGachaGold() => new bool();

    [Token(Token = "0x600448E")]
    [Address(RVA = "0x11A0620", Offset = "0x119F420", VA = "0x111A0620")]
    public bool CheckFreeGachaGoldMax() => new bool();

    [Token(Token = "0x600448F")]
    [Address(RVA = "0x11AF0B0", Offset = "0x11ADEB0", VA = "0x111AF0B0")]
    public long GetNextFreeGachaGoldCoolDownSec() => new long();

    [Token(Token = "0x6004490")]
    [Address(RVA = "0x11A04F0", Offset = "0x119F2F0", VA = "0x111A04F0")]
    public bool CheckFreeGachaCoin() => new bool();

    [Token(Token = "0x6004491")]
    [Address(RVA = "0x11AEF90", Offset = "0x11ADD90", VA = "0x111AEF90")]
    public long GetNextFreeGachaCoinCoolDownSec() => new long();

    [Token(Token = "0x6004492")]
    [Address(RVA = "0x11A0B00", Offset = "0x119F900", VA = "0x111A0B00")]
    public bool CheckPaidGacha() => new bool();

    [Token(Token = "0x6004493")]
    [Address(RVA = "0x11BE930", Offset = "0x11BD730", VA = "0x111BE930")]
    public void SetInventory(int index, ItemData item)
    {
    }

    [Token(Token = "0x6004494")]
    [Address(RVA = "0x11BD230", Offset = "0x11BC030", VA = "0x111BD230")]
    public void SaveInventory()
    {
    }

    [Token(Token = "0x6004495")]
    [Address(RVA = "0x11C3B50", Offset = "0x11C2950", VA = "0x111C3B50")]
    public void UpdateInventory()
    {
    }

    [Token(Token = "0x6004496")]
    [Address(RVA = "0x11C63D0", Offset = "0x11C51D0", VA = "0x111C63D0")]
    public bool UseExpPotion(UnitData unit, ItemData item) => new bool();

    [Token(Token = "0x6004497")]
    [Address(RVA = "0x11A09C0", Offset = "0x119F7C0", VA = "0x111A09C0")]
    public bool CheckFriend(string fuid) => new bool();

    [Token(Token = "0x6004498")]
    [Address(RVA = "0x11BC810", Offset = "0x11BB610", VA = "0x111BC810")]
    public void RemoveFriendFollowerAll()
    {
    }

    [Token(Token = "0x6004499")]
    [Address(RVA = "0x11BC8A0", Offset = "0x11BB6A0", VA = "0x111BC8A0")]
    public void RemoveFriendFollower(string fuid)
    {
    }

    [Token(Token = "0x600449A")]
    [Address(RVA = "0x11A03A0", Offset = "0x119F1A0", VA = "0x111A03A0")]
    public bool CheckEnableEquipUnit(ItemParam item) => new bool();

    [Token(Token = "0x600449B")]
    [Address(RVA = "0x119FEF0", Offset = "0x119ECF0", VA = "0x1119FEF0")]
    public bool CheckEnableCreateItem(
      ItemParam param,
      bool root = true,
      int needNum = 1,
      NeedEquipItemList item_list = null)
    {
      return new bool();
    }

    [Token(Token = "0x600449C")]
    [Address(RVA = "0x119FF30", Offset = "0x119ED30", VA = "0x1119FF30")]
    public bool CheckEnableCreateItem(
      ItemParam param,
      ref bool isBulk,
      ref bool isCommonShortage,
      ref bool isCraft,
      bool root = true,
      int needNum = 1,
      NeedEquipItemList item_list = null,
      bool isTemp = false,
      bool isUseCommon = true)
    {
      return new bool();
    }

    [Token(Token = "0x600449D")]
    [Address(RVA = "0x119FE30", Offset = "0x119EC30", VA = "0x1119FE30")]
    public bool CheckEnableCreateItem(
      ItemParam param,
      ref bool is_ikkatsu,
      ref int cost,
      ref Dictionary<string, int> consumes,
      NeedEquipItemList item_list = null)
    {
      return new bool();
    }

    [Token(Token = "0x600449E")]
    [Address(RVA = "0x119FE90", Offset = "0x119EC90", VA = "0x1119FE90")]
    public bool CheckEnableCreateItem(
      ItemParam param,
      int count,
      ref bool is_ikkatsu,
      ref int cost,
      ref Dictionary<string, int> consumes,
      NeedEquipItemList item_list = null)
    {
      return new bool();
    }

    [Token(Token = "0x600449F")]
    [Address(RVA = "0x11ACF50", Offset = "0x11ABD50", VA = "0x111ACF50")]
    public int GetCreateItemCost(ItemParam param) => new int();

    [Token(Token = "0x60044A0")]
    [Address(RVA = "0x11AD540", Offset = "0x11AC340", VA = "0x111AD540")]
    public bool GetEnableCreateEquipItem(
      UnitData self,
      EquipData equip,
      ref int cost,
      NeedEquipItemList item_list = null)
    {
      return new bool();
    }

    [Token(Token = "0x60044A1")]
    [Address(RVA = "0x11AD340", Offset = "0x11AC140", VA = "0x111AD340")]
    public void GetEnableCreateEquipItemAll(
      UnitData self,
      EquipData[] equips,
      ref bool[] equipFlags,
      ref Dictionary<string, int> consume,
      ref int cost,
      NeedEquipItemList item_list = null)
    {
    }

    [Token(Token = "0x60044A2")]
    [Address(RVA = "0x11AD310", Offset = "0x11AC110", VA = "0x111AD310")]
    public void GetEnableCreateEquipItemAll(
      UnitData self,
      EquipData[] equips,
      ref bool[] equipFlags,
      NeedEquipItemList item_list = null)
    {
    }

    [Token(Token = "0x60044A3")]
    [Address(RVA = "0x119FA50", Offset = "0x119E850", VA = "0x1119FA50")]
    public bool CheckEnableCreateEquipItemAll(
      UnitData self,
      EquipData[] equips,
      ref Dictionary<string, int> consume,
      ref int cost,
      NeedEquipItemList item_list = null)
    {
      return new bool();
    }

    [Token(Token = "0x60044A4")]
    [Address(RVA = "0x119FE00", Offset = "0x119EC00", VA = "0x1119FE00")]
    public bool CheckEnableCreateEquipItemAll(
      UnitData self,
      EquipData[] equips,
      NeedEquipItemList item_list = null)
    {
      return new bool();
    }

    [Token(Token = "0x60044A5")]
    [Address(RVA = "0x119F1C0", Offset = "0x119DFC0", VA = "0x1119F1C0")]
    public bool CheckEnable2(
      UnitData self,
      EquipData[] equips_base,
      ref Dictionary<string, int> consume,
      ref int cost,
      ref int target_rank,
      ref bool can_jobmaster,
      ref bool can_jobmax,
      ref NeedEquipItemList item_list,
      bool isUseCommon = true)
    {
      return new bool();
    }

    [Token(Token = "0x60044A6")]
    [Address(RVA = "0x119F5B0", Offset = "0x119E3B0", VA = "0x1119F5B0")]
    public bool CheckEnableCreateEquipItemAll2(
      UnitData self,
      EquipData[] equips,
      ref NeedEquipItemList item_list,
      bool isUseCommon = true)
    {
      return new bool();
    }

    [Token(Token = "0x60044A7")]
    [Address(RVA = "0x11C0070", Offset = "0x11BEE70", VA = "0x111C0070")]
    public bool SetUnitEquipment(UnitData unit, int slotIndex) => new bool();

    [Token(Token = "0x60044A8")]
    [Address(RVA = "0x11BC1C0", Offset = "0x11BAFC0", VA = "0x111BC1C0")]
    public bool RarityUpUnit(UnitData unit) => new bool();

    [Token(Token = "0x60044A9")]
    [Address(RVA = "0x11A1510", Offset = "0x11A0310", VA = "0x111A1510")]
    private void ConsumeAwakePieces(UnitData unit, int num)
    {
    }

    [Token(Token = "0x60044AA")]
    [Address(RVA = "0x119DE70", Offset = "0x119CC70", VA = "0x1119DE70")]
    public bool AwakingUnit(UnitData unit) => new bool();

    [Token(Token = "0x60044AB")]
    [Address(RVA = "0x11AE7B0", Offset = "0x11AD5B0", VA = "0x111AE7B0")]
    public List<ItemData> GetJobRankUpReturnItemData(UnitData self, int jobNo, bool ignoreEquiped = false)
    {
      return (List<ItemData>) null;
    }

    [Token(Token = "0x60044AC")]
    [Address(RVA = "0x11B4320", Offset = "0x11B3120", VA = "0x111B4320")]
    public bool JobRankUpUnit(UnitData unit, int jobIndex) => new bool();

    [Token(Token = "0x60044AD")]
    [Address(RVA = "0x11A0F20", Offset = "0x119FD20", VA = "0x111A0F20")]
    public bool ClassChangeUnit(UnitData unit, int index) => new bool();

    [Token(Token = "0x60044AE")]
    [Address(RVA = "0x11A0B20", Offset = "0x119F920", VA = "0x111A0B20")]
    public bool CheckRankUpAbility(AbilityData ability) => new bool();

    [Token(Token = "0x60044AF")]
    [Address(RVA = "0x11BBFC0", Offset = "0x11BADC0", VA = "0x111BBFC0")]
    public bool RankUpAbility(AbilityData ability, bool is_update_badges = true) => new bool();

    [Token(Token = "0x60044B0")]
    [Address(RVA = "0x11AB5E0", Offset = "0x11AA3E0", VA = "0x111AB5E0")]
    public void GainItem(string itemID, int num)
    {
    }

    [Token(Token = "0x60044B1")]
    [Address(RVA = "0x11AB750", Offset = "0x11AA550", VA = "0x111AB750")]
    public void GainUnit(string unitID)
    {
    }

    [Token(Token = "0x60044B2")]
    [Address(RVA = "0x11ABFD0", Offset = "0x11AADD0", VA = "0x111ABFD0")]
    public void GainUnit(UnitData unit)
    {
    }

    [Token(Token = "0x60044B3")]
    [Address(RVA = "0x11B07D0", Offset = "0x11AF5D0", VA = "0x111B07D0")]
    public List<UnitData> GetSortedUnits(string menuID, bool includeShujinko = true)
    {
      return (List<UnitData>) null;
    }

    [Token(Token = "0x60044B4")]
    [Address(RVA = "0x11B0B50", Offset = "0x11AF950", VA = "0x111B0B50")]
    public List<UnitData> GetSortedUnits(
      GameUtility.UnitSortModes sortMode,
      bool ascending = false,
      bool includeShujinko = true)
    {
      return (List<UnitData>) null;
    }

    [Token(Token = "0x60044B5")]
    [Address(RVA = "0x11B0DD0", Offset = "0x11AFBD0", VA = "0x111B0DD0")]
    public UnitData GetUnitData(long iid) => (UnitData) null;

    [Token(Token = "0x60044B6")]
    [Address(RVA = "0x11AE720", Offset = "0x11AD520", VA = "0x111AE720")]
    public int GetItemSlotAmount() => new int();

    [Token(Token = "0x60044B7")]
    [Address(RVA = "0x119EE10", Offset = "0x119DC10", VA = "0x1119EE10")]
    public bool CheckConceptCardCapacity(int adddValue) => new bool();

    [Token(Token = "0x60044B8")]
    [Address(RVA = "0x11A0AB0", Offset = "0x119F8B0", VA = "0x111A0AB0")]
    public bool CheckItemCapacity(ItemParam item, int num) => new bool();

    [Token(Token = "0x60044B9")]
    [Address(RVA = "0x119EEE0", Offset = "0x119DCE0", VA = "0x1119EEE0")]
    public CreateItemResult CheckCreateItem(ItemParam item) => new CreateItemResult();

    [Token(Token = "0x60044BA")]
    [Address(RVA = "0x11A1C50", Offset = "0x11A0A50", VA = "0x111A1C50")]
    public bool CreateItem(ItemParam item) => new bool();

    [Token(Token = "0x60044BB")]
    [Address(RVA = "0x11A18E0", Offset = "0x11A06E0", VA = "0x111A18E0")]
    public bool CreateItemAll(ItemParam item) => new bool();

    [Token(Token = "0x60044BC")]
    [Address(RVA = "0x119F4B0", Offset = "0x119E2B0", VA = "0x1119F4B0")]
    public bool CheckEnableConvertGold() => new bool();

    [Token(Token = "0x60044BD")]
    [Address(RVA = "0x11B03B0", Offset = "0x11AF1B0", VA = "0x111B03B0")]
    public ShopData GetShopData(EShopType type) => (ShopData) null;

    [Token(Token = "0x60044BE")]
    [Address(RVA = "0x11BFD60", Offset = "0x11BEB60", VA = "0x111BFD60")]
    public void SetShopData(EShopType type, ShopData shop)
    {
    }

    [Token(Token = "0x60044BF")]
    [Address(RVA = "0x11BFCD0", Offset = "0x11BEAD0", VA = "0x111BFCD0")]
    public void SetShopCrystalData(Json_ShopBuyCrystal[] data)
    {
    }

    [Token(Token = "0x60044C0")]
    [Address(RVA = "0x11B0290", Offset = "0x11AF090", VA = "0x111B0290")]
    public List<Json_ShopBuyCrystal> GetShopCrystalDatas() => (List<Json_ShopBuyCrystal>) null;

    [Token(Token = "0x60044C1")]
    [Address(RVA = "0x3493D0", Offset = "0x3481D0", VA = "0x103493D0")]
    public LimitedShopData GetLimitedShopData() => (LimitedShopData) null;

    [Token(Token = "0x60044C2")]
    [Address(RVA = "0x11BE9A0", Offset = "0x11BD7A0", VA = "0x111BE9A0")]
    public void SetLimitedShopData(LimitedShopData shop)
    {
    }

    [Token(Token = "0x60044C3")]
    [Address(RVA = "0x349270", Offset = "0x348070", VA = "0x10349270")]
    public EventShopData GetEventShopData() => (EventShopData) null;

    [Token(Token = "0x60044C4")]
    [Address(RVA = "0x11BE820", Offset = "0x11BD620", VA = "0x111BE820")]
    public void SetEventShopData(EventShopData shop)
    {
    }

    [Token(Token = "0x60044C5")]
    [Address(RVA = "0x11A0E20", Offset = "0x119FC20", VA = "0x111A0E20")]
    public bool CheckUnlockShopType(EShopType type) => new bool();

    [Token(Token = "0x60044C6")]
    [Address(RVA = "0x11B0430", Offset = "0x11AF230", VA = "0x111B0430")]
    public string GetShopName(EShopType type) => (string) null;

    [Token(Token = "0x60044C7")]
    [Address(RVA = "0x11B0720", Offset = "0x11AF520", VA = "0x111B0720")]
    public int GetShopUpdateCost(EShopType type, bool getOldCost = false) => new int();

    [Token(Token = "0x60044C8")]
    [Address(RVA = "0x11B05C0", Offset = "0x11AF3C0", VA = "0x111B05C0")]
    public int GetShopTypeCostAmount(ESaleType type) => new int();

    [Token(Token = "0x60044C9")]
    [Address(RVA = "0x11A0C00", Offset = "0x119FA00", VA = "0x111A0C00")]
    public bool CheckShopUpdateCost(EShopType type) => new bool();

    [Token(Token = "0x60044CA")]
    [Address(RVA = "0x11A2D40", Offset = "0x11A1B40", VA = "0x111A2D40")]
    public void DEBUG_BUY_ITEM_UPDATED(EShopType shoptype)
    {
    }

    [Token(Token = "0x60044CB")]
    [Address(RVA = "0x11A34A0", Offset = "0x11A22A0", VA = "0x111A34A0")]
    public void DEBUG_BUY_ITEM(EShopType shoptype, int index)
    {
    }

    [Token(Token = "0x170006E4")]
    public DateTime VipExpiredAt
    {
      [Token(Token = "0x60044CC"), Address(RVA = "0x11C90E0", Offset = "0x11C7EE0", VA = "0x111C90E0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x60044CD")]
    [Address(RVA = "0x11A0450", Offset = "0x119F250", VA = "0x111A0450")]
    public bool CheckEnableVipCard() => new bool();

    [Token(Token = "0x60044CE")]
    [Address(RVA = "0x11C0490", Offset = "0x11BF290", VA = "0x111C0490")]
    public void SubAbilityRankUpCount(int value)
    {
    }

    [Token(Token = "0x60044CF")]
    [Address(RVA = "0x11BD0C0", Offset = "0x11BBEC0", VA = "0x111BD0C0")]
    public void RestoreAbilityRankUpCount()
    {
    }

    [Token(Token = "0x60044D0")]
    [Address(RVA = "0x11C04F0", Offset = "0x11BF2F0", VA = "0x111C04F0")]
    public void SubStamina(int value)
    {
    }

    [Token(Token = "0x60044D1")]
    [Address(RVA = "0x11AF2E0", Offset = "0x11AE0E0", VA = "0x111AF2E0")]
    public long GetNextStaminaRecoverySec() => new long();

    [Token(Token = "0x60044D2")]
    [Address(RVA = "0x11C51D0", Offset = "0x11C3FD0", VA = "0x111C51D0")]
    public void UpdateStamina()
    {
    }

    [Token(Token = "0x60044D3")]
    [Address(RVA = "0x11B0CD0", Offset = "0x11AFAD0", VA = "0x111B0CD0")]
    public int GetStaminaRecoveryCost(bool getOldCost = false) => new int();

    [Token(Token = "0x60044D4")]
    [Address(RVA = "0x11BD090", Offset = "0x11BBE90", VA = "0x111BD090")]
    public void ResetStaminaRecoverCount()
    {
    }

    [Token(Token = "0x60044D5")]
    [Address(RVA = "0x11BCC80", Offset = "0x11BBA80", VA = "0x111BCC80")]
    public void ResetBuyGoldNum()
    {
    }

    [Token(Token = "0x60044D6")]
    [Address(RVA = "0x11C04C0", Offset = "0x11BF2C0", VA = "0x111C04C0")]
    public void SubCaveStamina(int value)
    {
    }

    [Token(Token = "0x60044D7")]
    [Address(RVA = "0x11AEE50", Offset = "0x11ADC50", VA = "0x111AEE50")]
    public long GetNextCaveStaminaRecoverySec() => new long();

    [Token(Token = "0x60044D8")]
    [Address(RVA = "0x11C1C50", Offset = "0x11C0A50", VA = "0x111C1C50")]
    public void UpdateCaveStamina()
    {
    }

    [Token(Token = "0x60044D9")]
    [Address(RVA = "0x11AC380", Offset = "0x11AB180", VA = "0x111AC380")]
    public int GetCaveStaminaRecoveryCost() => new int();

    [Token(Token = "0x60044DA")]
    [Address(RVA = "0x11AEE20", Offset = "0x11ADC20", VA = "0x111AEE20")]
    public long GetNextAbilityRankUpCountRecoverySec() => new long();

    [Token(Token = "0x60044DB")]
    [Address(RVA = "0x11C0BB0", Offset = "0x11BF9B0", VA = "0x111C0BB0")]
    public void UpdateAbilityRankUpCount()
    {
    }

    [Token(Token = "0x170006E5")]
    public int ArenaResetCount
    {
      [Token(Token = "0x60044DC"), Address(RVA = "0xA45570", Offset = "0xA44370", VA = "0x10A45570")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60044DD")]
    [Address(RVA = "0x119E1F0", Offset = "0x119CFF0", VA = "0x1119E1F0")]
    public bool ChallengeArena() => new bool();

    [Token(Token = "0x60044DE")]
    [Address(RVA = "0x119ED70", Offset = "0x119DB70", VA = "0x1119ED70")]
    public bool CheckChangeArena() => new bool();

    [Token(Token = "0x60044DF")]
    [Address(RVA = "0x11AEE80", Offset = "0x11ADC80", VA = "0x111AEE80")]
    public long GetNextChallengeArenaCoolDownSec() => new long();

    [Token(Token = "0x60044E0")]
    [Address(RVA = "0x11C1C80", Offset = "0x11C0A80", VA = "0x111C1C80")]
    public void UpdateChallengeArenaTimer()
    {
    }

    [Token(Token = "0x60044E1")]
    [Address(RVA = "0x11AC440", Offset = "0x11AB240", VA = "0x111AC440")]
    public int GetChallengeArenaCost() => new int();

    [Token(Token = "0x60044E2")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void InitPlayerPrefs()
    {
    }

    [Token(Token = "0x60044E3")]
    [Address(RVA = "0x11A3C60", Offset = "0x11A2A60", VA = "0x111A3C60")]
    public void DEBUG_GAIN_ALL_ITEMS()
    {
    }

    [Token(Token = "0x60044E4")]
    [Address(RVA = "0x11A3E30", Offset = "0x11A2C30", VA = "0x111A3E30")]
    public void DEBUG_TRASH_ALL_ITEMS()
    {
    }

    [Token(Token = "0x60044E5")]
    [Address(RVA = "0x11A2B60", Offset = "0x11A1960", VA = "0x111A2B60")]
    public void DEBUG_ADD_ARTIFACTS(ArtifactData artifact)
    {
    }

    [Token(Token = "0x60044E6")]
    [Address(RVA = "0x11A3AF0", Offset = "0x11A28F0", VA = "0x111A3AF0")]
    public void DEBUG_GAIN_ALL_ARTIFACT()
    {
    }

    [Token(Token = "0x60044E7")]
    [Address(RVA = "0x11A3DB0", Offset = "0x11A2BB0", VA = "0x111A3DB0")]
    public void DEBUG_TRASH_ALL_ARTIFACT()
    {
    }

    [Token(Token = "0x60044E8")]
    [Address(RVA = "0x11B4400", Offset = "0x11B3200", VA = "0x111B4400")]
    public void LoadPlayerPrefs()
    {
    }

    [Token(Token = "0x60044E9")]
    [Address(RVA = "0x11BD370", Offset = "0x11BC170", VA = "0x111BD370")]
    public IEnumerator SavePlayerPrefsAsync() => (IEnumerator) null;

    [Token(Token = "0x60044EA")]
    [Address(RVA = "0x11B1560", Offset = "0x11B0360", VA = "0x111B1560")]
    private void InternalSavePlayerPrefsParty()
    {
    }

    [Token(Token = "0x60044EB")]
    [Address(RVA = "0x11BD3D0", Offset = "0x11BC1D0", VA = "0x111BD3D0")]
    public void SavePlayerPrefsParty()
    {
    }

    [Token(Token = "0x60044EC")]
    [Address(RVA = "0x11BD3F0", Offset = "0x11BC1F0", VA = "0x111BD3F0")]
    public void SavePlayerPrefs()
    {
    }

    [Token(Token = "0x60044ED")]
    [Address(RVA = "0x11AC050", Offset = "0x11AAE50", VA = "0x111AC050")]
    public long GenerateUnitUniqueID() => new long();

    [Token(Token = "0x60044EE")]
    [Address(RVA = "0x11B90E0", Offset = "0x11B7EE0", VA = "0x111B90E0")]
    public void OnQuestStart(string questID)
    {
    }

    [Token(Token = "0x60044EF")]
    [Address(RVA = "0x11B94F0", Offset = "0x11B82F0", VA = "0x111B94F0")]
    public void OnQuestWin(
      string questID,
      BattleCore.Record battleRecord = null,
      UnitData[] currentUnits = null,
      int addCnt = 1,
      QuestParam[] cleared_quests = null)
    {
    }

    [Token(Token = "0x60044F0")]
    [Address(RVA = "0x11B40F0", Offset = "0x11B2EF0", VA = "0x111B40F0")]
    private bool IsSelectUnitInParty(UnitData[] units, SupportData support, UnitParam param)
    {
      return new bool();
    }

    [Token(Token = "0x60044F1")]
    [Address(RVA = "0x119DA60", Offset = "0x119C860", VA = "0x1119DA60")]
    private void AddCountWinQuestUnit(
      TrophyObjective trophy,
      List<UnitData> units,
      SupportData support,
      int addCnt)
    {
    }

    [Token(Token = "0x60044F2")]
    [Address(RVA = "0x119D840", Offset = "0x119C640", VA = "0x1119D840")]
    private void AddCountWinQuestUnitByQuest(
      TrophyObjective trophy,
      List<UnitData> units,
      SupportData support,
      QuestParam quest,
      int addCnt)
    {
    }

    [Token(Token = "0x60044F3")]
    [Address(RVA = "0x119D3E0", Offset = "0x119C1E0", VA = "0x1119D3E0")]
    private void AddCountWinQuestUnitByArea(
      TrophyObjective trophy,
      List<UnitData> units,
      SupportData support,
      QuestParam quest,
      int addCnt)
    {
    }

    [Token(Token = "0x60044F4")]
    [Address(RVA = "0x119D610", Offset = "0x119C410", VA = "0x1119D610")]
    private void AddCountWinQuestUnitByMode(
      TrophyObjective trophy,
      List<UnitData> units,
      SupportData support,
      QuestParam quest,
      int addCnt)
    {
    }

    [Token(Token = "0x60044F5")]
    [Address(RVA = "0x11B8700", Offset = "0x11B7500", VA = "0x111B8700")]
    public void OnQuestLose(string questID)
    {
    }

    [Token(Token = "0x60044F6")]
    [Address(RVA = "0x11B7B20", Offset = "0x11B6920", VA = "0x111B7B20")]
    public void OnGoldChange(int delta)
    {
    }

    [Token(Token = "0x60044F7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void OnCoinChange(int delta)
    {
    }

    [Token(Token = "0x60044F8")]
    [Address(RVA = "0x11B7BF0", Offset = "0x11B69F0", VA = "0x111B7BF0")]
    public void OnItemQuantityChange(string itemID, int delta)
    {
    }

    [Token(Token = "0x60044F9")]
    [Address(RVA = "0x11B8620", Offset = "0x11B7420", VA = "0x111B8620")]
    public void OnPlayerLevelChange(int delta)
    {
    }

    [Token(Token = "0x60044FA")]
    [Address(RVA = "0x11B75C0", Offset = "0x11B63C0", VA = "0x111B75C0")]
    public void OnEnemyKill(string enemyID, int count)
    {
    }

    [Token(Token = "0x60044FB")]
    [Address(RVA = "0x11B7230", Offset = "0x11B6030", VA = "0x111B7230")]
    public void OnDamageToEnemy(Unit unit, Unit target, int damage)
    {
    }

    [Token(Token = "0x60044FC")]
    [Address(RVA = "0x11B6820", Offset = "0x11B5620", VA = "0x111B6820")]
    public void OnAbilityPowerUp(string unitID, string abilityID, int level, bool verify = false)
    {
    }

    [Token(Token = "0x60044FD")]
    [Address(RVA = "0x11BB180", Offset = "0x11B9F80", VA = "0x111BB180")]
    public void OnSoubiPowerUp(int value = 1)
    {
    }

    [Token(Token = "0x60044FE")]
    [Address(RVA = "0x11B7000", Offset = "0x11B5E00", VA = "0x111B7000")]
    public void OnBuyGold()
    {
    }

    [Token(Token = "0x60044FF")]
    [Address(RVA = "0x11B7940", Offset = "0x11B6740", VA = "0x111B7940")]
    public void OnFgGIDLogin()
    {
    }

    [Token(Token = "0x6004500")]
    [Address(RVA = "0x11B79D0", Offset = "0x11B67D0", VA = "0x111B79D0")]
    public void OnGacha(GachaTypes type, int count)
    {
    }

    [Token(Token = "0x6004501")]
    [Address(RVA = "0x11BB7A0", Offset = "0x11BA5A0", VA = "0x111BB7A0")]
    public void OnUnitLevelChange(string unitID, int delta, int level, bool verify = false)
    {
    }

    [Token(Token = "0x6004502")]
    [Address(RVA = "0x11BB540", Offset = "0x11BA340", VA = "0x111BB540")]
    public void OnUnitLevelAndJobLevelChange(string unitID, int level, params JobData[] jobs)
    {
    }

    [Token(Token = "0x6004503")]
    [Address(RVA = "0x11BBF50", Offset = "0x11BAD50", VA = "0x111BBF50")]
    private void PrintUnitAndJobLevelUsage(TrophyObjective trohy)
    {
    }

    [Token(Token = "0x6004504")]
    [Address(RVA = "0x11B7670", Offset = "0x11B6470", VA = "0x111B7670")]
    public void OnEvolutionChange(string unitID, int rarity)
    {
    }

    [Token(Token = "0x6004505")]
    [Address(RVA = "0x11B7D80", Offset = "0x11B6B80", VA = "0x111B7D80")]
    public void OnJobLevelChange(
      string unitID,
      string jobID,
      int rank,
      bool verify = false,
      int rankDelta = 1)
    {
    }

    [Token(Token = "0x6004506")]
    [Address(RVA = "0x11B8560", Offset = "0x11B7360", VA = "0x111B8560")]
    public void OnMultiTowerHelp()
    {
    }

    [Token(Token = "0x6004507")]
    [Address(RVA = "0x11B8300", Offset = "0x11B7100", VA = "0x111B8300")]
    public void OnLogin()
    {
    }

    [Token(Token = "0x6004508")]
    [Address(RVA = "0x11C0690", Offset = "0x11BF490", VA = "0x111C0690")]
    public void TrophyUpdateProgress()
    {
    }

    [Token(Token = "0x6004509")]
    [Address(RVA = "0x11BB210", Offset = "0x11BA010", VA = "0x111BB210")]
    public void OnSoubiSet(string unitID, int countUp = 1)
    {
    }

    [Token(Token = "0x600450A")]
    [Address(RVA = "0x11B8230", Offset = "0x11B7030", VA = "0x111B8230")]
    public void OnLimitBreak(string unitID, int delta = 1)
    {
    }

    [Token(Token = "0x600450B")]
    [Address(RVA = "0x11B7CB0", Offset = "0x11B6AB0", VA = "0x111B7CB0")]
    public void OnJobChange(string unitID)
    {
    }

    [Token(Token = "0x600450C")]
    [Address(RVA = "0x11B7160", Offset = "0x11B5F60", VA = "0x111B7160")]
    public void OnChangeAbilitySet(string unitID)
    {
    }

    [Token(Token = "0x600450D")]
    [Address(RVA = "0x11B6E20", Offset = "0x11B5C20", VA = "0x111B6E20")]
    public void OnBuyAtShop(string shopID, string itemID, int num)
    {
    }

    [Token(Token = "0x600450E")]
    [Address(RVA = "0x11B6D50", Offset = "0x11B5B50", VA = "0x111B6D50")]
    public void OnArtifactTransmute(string artifactID)
    {
    }

    [Token(Token = "0x600450F")]
    [Address(RVA = "0x11B6B10", Offset = "0x11B5910", VA = "0x111B6B10")]
    public void OnArtifactStrength(
      string artifactID,
      int useItemNum,
      int beforeLevel,
      int currentLevel)
    {
    }

    [Token(Token = "0x6004510")]
    [Address(RVA = "0x11B6A40", Offset = "0x11B5840", VA = "0x111B6A40")]
    public void OnArtifactEvolution(string artifactID)
    {
    }

    [Token(Token = "0x6004511")]
    [Address(RVA = "0x11BB9E0", Offset = "0x11BA7E0", VA = "0x111BB9E0")]
    public void OnUnlockTobiraTrophy(long unitUniqueID)
    {
    }

    [Token(Token = "0x6004512")]
    [Address(RVA = "0x11B85F0", Offset = "0x11B73F0", VA = "0x111B85F0")]
    public void OnOpenTobiraTrophy(long unitUniqueID)
    {
    }

    [Token(Token = "0x6004513")]
    [Address(RVA = "0x11C5200", Offset = "0x11C4000", VA = "0x111C5200")]
    public void UpdateTobiraTrophyStates()
    {
    }

    [Token(Token = "0x6004514")]
    [Address(RVA = "0x11C4C40", Offset = "0x11C3A40", VA = "0x111C4C40")]
    private void UpdateSinsTobiraTrophy(UnitData unitData)
    {
    }

    [Token(Token = "0x6004515")]
    [Address(RVA = "0x119ED00", Offset = "0x119DB00", VA = "0x1119ED00")]
    private void CheckAllSinsTobiraNonTargetTrophy()
    {
    }

    [Token(Token = "0x6004516")]
    [Address(RVA = "0x11BFE10", Offset = "0x11BEC10", VA = "0x111BFE10")]
    private void SetSinsTobiraTrophyByAllUnit(
      TobiraParam.Category category,
      TrophyConditionTypes trophyType)
    {
    }

    [Token(Token = "0x6004517")]
    [Address(RVA = "0x11B0E80", Offset = "0x11AFC80", VA = "0x111B0E80")]
    public List<TobiraParam.Category> GetUnlockTobiraCategorys(UnitData unitData)
    {
      return (List<TobiraParam.Category>) null;
    }

    [Token(Token = "0x6004518")]
    [Address(RVA = "0x11C5D30", Offset = "0x11C4B30", VA = "0x111C5D30")]
    private void UpdateUnlockTobiraUnitCountTrophy()
    {
    }

    [Token(Token = "0x6004519")]
    [Address(RVA = "0x11C5E80", Offset = "0x11C4C80", VA = "0x111C5E80")]
    private void UpdateUnlockTobiraUnitTrophy(UnitData unitData)
    {
    }

    [Token(Token = "0x600451A")]
    [Address(RVA = "0x11B8320", Offset = "0x11B7120", VA = "0x111B8320")]
    public void OnMixedConceptCard(
      string conceptCardID,
      int beforeLevel,
      int currentLevel,
      int beforeAwakeCount,
      int currentAwakeCount,
      int beforeTrust,
      int currentTrust)
    {
    }

    [Token(Token = "0x600451B")]
    [Address(RVA = "0x11C3420", Offset = "0x11C2220", VA = "0x111C3420")]
    public void UpdateConceptCardTrophyAll()
    {
    }

    [Token(Token = "0x600451C")]
    [Address(RVA = "0x11C2E80", Offset = "0x11C1C80", VA = "0x111C2E80")]
    public void UpdateConceptCardLevelupTrophy(
      string conceptCardID,
      int beforeLevel,
      int currentLevel)
    {
    }

    [Token(Token = "0x600451D")]
    [Address(RVA = "0x119E410", Offset = "0x119D210", VA = "0x1119E410")]
    private void CheckAllConceptCardLevelupTrophy()
    {
    }

    [Token(Token = "0x600451E")]
    [Address(RVA = "0x11C3000", Offset = "0x11C1E00", VA = "0x111C3000")]
    public void UpdateConceptCardLimitBreakTrophy(
      string conceptCardID,
      int beforeLimitBreak,
      int currentLimitBreak)
    {
    }

    [Token(Token = "0x600451F")]
    [Address(RVA = "0x119E640", Offset = "0x119D440", VA = "0x1119E640")]
    public void CheckAllConceptCardLimitBreakTrophy()
    {
    }

    [Token(Token = "0x6004520")]
    [Address(RVA = "0x11C3660", Offset = "0x11C2460", VA = "0x111C3660")]
    public void UpdateConceptCardTrustUpTrophy(
      string conceptCardID,
      int beforeTrust,
      int currentTrust)
    {
    }

    [Token(Token = "0x6004521")]
    [Address(RVA = "0x119EAF0", Offset = "0x119D8F0", VA = "0x1119EAF0")]
    public void CheckAllConceptCardTrustUpTrophy()
    {
    }

    [Token(Token = "0x6004522")]
    [Address(RVA = "0x11C34F0", Offset = "0x11C22F0", VA = "0x111C34F0")]
    public void UpdateConceptCardTrustMaxTrophy(string conceptCardID, int currentTrust)
    {
    }

    [Token(Token = "0x6004523")]
    [Address(RVA = "0x119E870", Offset = "0x119D670", VA = "0x1119E870")]
    private void CheckAllConceptCardTrustMaxTrophy()
    {
    }

    [Token(Token = "0x6004524")]
    [Address(RVA = "0x11C1CB0", Offset = "0x11C0AB0", VA = "0x111C1CB0")]
    public void UpdateClearOrdealTrophy(
      BattleCore.Record record,
      QuestTypes questType,
      string questIname)
    {
    }

    [Token(Token = "0x6004525")]
    [Address(RVA = "0x11C2190", Offset = "0x11C0F90", VA = "0x111C2190")]
    public void UpdateCompleteAllQuestCountTrophy(QuestParam questParam = null)
    {
    }

    [Token(Token = "0x6004526")]
    [Address(RVA = "0x11C0520", Offset = "0x11BF320", VA = "0x111C0520")]
    private void TrophyAllQuestTypeCompleteCount(QuestParam quest = null)
    {
    }

    [Token(Token = "0x6004527")]
    [Address(RVA = "0x119E320", Offset = "0x119D120", VA = "0x1119E320")]
    private void CheckAllCompleteMissionTrophy()
    {
    }

    [Token(Token = "0x6004528")]
    [Address(RVA = "0x11C2780", Offset = "0x11C1580", VA = "0x111C2780")]
    private void UpdateCompleteMissionCount(TrophyConditionTypes type, QuestParam quest = null)
    {
    }

    [Token(Token = "0x6004529")]
    [Address(RVA = "0x11C6300", Offset = "0x11C5100", VA = "0x111C6300")]
    public void UpdateViewNewsTrophy(string url)
    {
    }

    [Token(Token = "0x600452A")]
    [Address(RVA = "0x11BC320", Offset = "0x11BB120", VA = "0x111BC320")]
    public void RecordAllCompleteCheck(TrophyCategoryParam category)
    {
    }

    [Token(Token = "0x600452B")]
    [Address(RVA = "0x11C20F0", Offset = "0x11C0EF0", VA = "0x111C20F0")]
    public void UpdateCompleteAllQuestCountTrophy2(QuestParam questParam = null)
    {
    }

    [Token(Token = "0x600452C")]
    [Address(RVA = "0x11C21D0", Offset = "0x11C0FD0", VA = "0x111C21D0")]
    private void UpdateCompleteMissionCount2(
      TrophyConditionTypes type,
      QuestParam quest = null,
      CompleteQuestMap completeQuestMap = null)
    {
    }

    [Token(Token = "0x600452D")]
    [Address(RVA = "0x11B7090", Offset = "0x11B5E90", VA = "0x111B7090")]
    public void OnChallengeMissionComplete(string trophyID)
    {
    }

    [Token(Token = "0x600452E")]
    [Address(RVA = "0x11BB2E0", Offset = "0x11BA0E0", VA = "0x111BB2E0")]
    public void OnTowerScore(bool isNow = true)
    {
    }

    [Token(Token = "0x600452F")]
    [Address(RVA = "0x11BB050", Offset = "0x11B9E50", VA = "0x111BB050")]
    public void OnReadTips(string trophyIname)
    {
    }

    [Token(Token = "0x6004530")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void UpdateVipDailyMission(int vipLv)
    {
    }

    [Token(Token = "0x6004531")]
    [Address(RVA = "0x11C1A90", Offset = "0x11C0890", VA = "0x111C1A90")]
    public void UpdateCardDailyMission()
    {
    }

    [Token(Token = "0x6004532")]
    [Address(RVA = "0x11BCD00", Offset = "0x11BBB00", VA = "0x111BCD00")]
    private void ResetPrevCheckHour()
    {
    }

    [Token(Token = "0x6004533")]
    [Address(RVA = "0x11C4F20", Offset = "0x11C3D20", VA = "0x111C4F20")]
    public void UpdateStaminaDailyMission()
    {
    }

    [Token(Token = "0x6004534")]
    [Address(RVA = "0x11C14F0", Offset = "0x11C02F0", VA = "0x111C14F0")]
    public void UpdateArtifactTrophyStates()
    {
    }

    [Token(Token = "0x6004535")]
    [Address(RVA = "0x11C4160", Offset = "0x11C2F60", VA = "0x111C4160")]
    public void UpdatePlayerTrophyStates()
    {
    }

    [Token(Token = "0x6004536")]
    [Address(RVA = "0x11C0CD0", Offset = "0x11BFAD0", VA = "0x111C0CD0")]
    public void UpdateArenaRankTrophyStates(int currentRank = -1, int bestRank = -1)
    {
    }

    [Token(Token = "0x6004537")]
    [Address(RVA = "0x11C5430", Offset = "0x11C4230", VA = "0x111C5430")]
    public void UpdateTowerTrophyStates()
    {
    }

    [Token(Token = "0x6004538")]
    [Address(RVA = "0x11C6220", Offset = "0x11C5020", VA = "0x111C6220")]
    public void UpdateVersusTowerTrophyStates(string towerName, int currentFloor)
    {
    }

    [Token(Token = "0x6004539")]
    [Address(RVA = "0x11C3CF0", Offset = "0x11C2AF0", VA = "0x111C3CF0")]
    public void UpdateJoinGuild()
    {
    }

    [Token(Token = "0x600453A")]
    [Address(RVA = "0x11C3A30", Offset = "0x11C2830", VA = "0x111C3A30")]
    public void UpdateFriendCount()
    {
    }

    [Token(Token = "0x600453B")]
    [Address(RVA = "0x11C3920", Offset = "0x11C2720", VA = "0x111C3920")]
    public void UpdateFriendCount(int friend_count)
    {
    }

    [Token(Token = "0x600453C")]
    [Address(RVA = "0x11C4220", Offset = "0x11C3020", VA = "0x111C4220")]
    public void UpdateQuestMissionCount(
      QuestParam questParam = null,
      BattleCore.Record recode = null,
      QuestParam[] cleared_quests = null)
    {
    }

    [Token(Token = "0x600453D")]
    [Address(RVA = "0x11A11B0", Offset = "0x119FFB0", VA = "0x111A11B0")]
    public void ClearNewItemFlags()
    {
    }

    [Token(Token = "0x600453E")]
    [Address(RVA = "0x11A1080", Offset = "0x119FE80", VA = "0x111A1080")]
    public void ClearItemFlags(ItemData.ItemFlags flags)
    {
    }

    [Token(Token = "0x600453F")]
    [Address(RVA = "0x11B42D0", Offset = "0x11B30D0", VA = "0x111B42D0")]
    public bool ItemEntryExists(string iname) => new bool();

    [Token(Token = "0x6004540")]
    [Address(RVA = "0x11A1490", Offset = "0x11A0290", VA = "0x111A1490")]
    public void ClearUnits()
    {
    }

    [Token(Token = "0x6004541")]
    [Address(RVA = "0x11A1130", Offset = "0x119FF30", VA = "0x111A1130")]
    public void ClearItems()
    {
    }

    [Token(Token = "0x6004542")]
    [Address(RVA = "0x11A1000", Offset = "0x119FE00", VA = "0x111A1000")]
    public void ClearArtifacts()
    {
    }

    [Token(Token = "0x6004543")]
    [Address(RVA = "0x11B66D0", Offset = "0x11B54D0", VA = "0x111B66D0")]
    public void OfflineSellArtifacts(ArtifactData[] artifacts)
    {
    }

    [Token(Token = "0x6004544")]
    [Address(RVA = "0x11C0E20", Offset = "0x11BFC20", VA = "0x111C0E20")]
    public void UpdateArtifactOwner()
    {
    }

    [Token(Token = "0x6004545")]
    [Address(RVA = "0x11B1E80", Offset = "0x11B0C80", VA = "0x111B1E80")]
    public bool IsBeginner() => new bool();

    [Token(Token = "0x6004546")]
    [Address(RVA = "0x11AC260", Offset = "0x11AB060", VA = "0x111AC260")]
    public DateTime GetBeginnerEndTime() => new DateTime();

    [Token(Token = "0x6004547")]
    [Address(RVA = "0x11BDD70", Offset = "0x11BCB70", VA = "0x111BDD70")]
    public void SetBeginnerNotified()
    {
    }

    [Token(Token = "0x6004548")]
    [Address(RVA = "0x11B6300", Offset = "0x11B5100", VA = "0x111B6300")]
    public bool NeedsShowBeginnerNotify() => new bool();

    [Token(Token = "0x6004549")]
    [Address(RVA = "0x11A1B40", Offset = "0x11A0940", VA = "0x111A1B40")]
    public Dictionary<ItemParam, int> CreateItemSnapshot() => (Dictionary<ItemParam, int>) null;

    [Token(Token = "0x600454A")]
    [Address(RVA = "0x11AB6B0", Offset = "0x11AA4B0", VA = "0x111AB6B0")]
    public void GainPiecePoint(int point)
    {
    }

    [Token(Token = "0x600454B")]
    [Address(RVA = "0x11A40D0", Offset = "0x11A2ED0", VA = "0x111A40D0")]
    public string DequeueNextLoginBonusTableID() => (string) null;

    [Token(Token = "0x170006E6")]
    public bool HasQueuedLoginBonus
    {
      [Token(Token = "0x600454C"), Address(RVA = "0x11C8790", Offset = "0x11C7590", VA = "0x111C8790")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600454D")]
    [Address(RVA = "0x11C5590", Offset = "0x11C4390", VA = "0x111C5590")]
    public void UpdateUnitTrophyStates(bool verbose)
    {
    }

    [Token(Token = "0x600454E")]
    [Address(RVA = "0x11C5AF0", Offset = "0x11C48F0", VA = "0x111C5AF0")]
    private void UpdateUnitTrophy(UnitData unit)
    {
    }

    [Token(Token = "0x600454F")]
    [Address(RVA = "0x11BB420", Offset = "0x11BA220", VA = "0x111BB420")]
    public void OnUnitGet()
    {
    }

    [Token(Token = "0x6004550")]
    [Address(RVA = "0x11B77D0", Offset = "0x11B65D0", VA = "0x111B77D0")]
    public void OnEvolutionCheck(string unitID, int rarity, int initialRarity)
    {
    }

    [Token(Token = "0x6004551")]
    [Address(RVA = "0x11B8150", Offset = "0x11B6F50", VA = "0x111B8150")]
    public void OnLimitBreakCheck(string unitID, int awake)
    {
    }

    [Token(Token = "0x6004552")]
    [Address(RVA = "0x11C0300", Offset = "0x11BF100", VA = "0x111C0300")]
    public void SetupEventCoin()
    {
    }

    [Token(Token = "0x6004553")]
    [Address(RVA = "0x11C3800", Offset = "0x11C2600", VA = "0x111C3800")]
    public void UpdateEventCoin()
    {
    }

    [Token(Token = "0x6004554")]
    [Address(RVA = "0x11A9D90", Offset = "0x11A8B90", VA = "0x111A9D90")]
    public int EventCoinNum(string cost_iname) => new int();

    [Token(Token = "0x6004555")]
    [Address(RVA = "0x11BE720", Offset = "0x11BD520", VA = "0x111BE720")]
    public void SetEventCoinNum(string cost_iname, int num)
    {
    }

    [Token(Token = "0x6004556")]
    [Address(RVA = "0x11C0200", Offset = "0x11BF000", VA = "0x111C0200")]
    public void SetVersusPlacement(string key, int idx)
    {
    }

    [Token(Token = "0x6004557")]
    [Address(RVA = "0x11B1000", Offset = "0x11AFE00", VA = "0x111B1000")]
    public int GetVersusPlacement(string key, int default_index = 0) => new int();

    [Token(Token = "0x6004558")]
    [Address(RVA = "0x11C0040", Offset = "0x11BEE40", VA = "0x111C0040")]
    public void SetTowerMatchInfo(int floor, int key, int wincnt, bool gift)
    {
    }

    [Token(Token = "0x6004559")]
    [Address(RVA = "0x11BFBC0", Offset = "0x11BE9C0", VA = "0x111BFBC0")]
    public void SetRankMatchInfo(
      int _rank,
      int _score,
      RankMatchClass _class,
      int _battle_point,
      int _streak_win,
      int _wincnt,
      int _losecnt)
    {
    }

    [Token(Token = "0x600455A")]
    [Address(RVA = "0x11B33E0", Offset = "0x11B21E0", VA = "0x111B33E0")]
    public bool IsHaveAward(string award) => new bool();

    [Token(Token = "0x600455B")]
    [Address(RVA = "0x11C0BE0", Offset = "0x11BF9E0", VA = "0x111C0BE0")]
    public void UpdateAchievementTrophyStates()
    {
    }

    [Token(Token = "0x600455C")]
    [Address(RVA = "0x11C02D0", Offset = "0x11BF0D0", VA = "0x111C02D0")]
    public void SetWishList(string iname, int priority)
    {
    }

    [Token(Token = "0x600455D")]
    [Address(RVA = "0x11BFA60", Offset = "0x11BE860", VA = "0x111BFA60")]
    public void SetQuestListDirty()
    {
    }

    [Token(Token = "0x170006E7")]
    public List<ConceptCardData> ConceptCards
    {
      [Token(Token = "0x600455E"), Address(RVA = "0x349580", Offset = "0x348380", VA = "0x10349580")] get
      {
        return (List<ConceptCardData>) null;
      }
    }

    [Token(Token = "0x170006E8")]
    public List<ConceptCardMaterialData> ConceptCardExpMaterials
    {
      [Token(Token = "0x600455F"), Address(RVA = "0x78D9E0", Offset = "0x78C7E0", VA = "0x1078D9E0")] get
      {
        return (List<ConceptCardMaterialData>) null;
      }
    }

    [Token(Token = "0x170006E9")]
    public List<ConceptCardMaterialData> ConceptCardTrustMaterials
    {
      [Token(Token = "0x6004560"), Address(RVA = "0xFEBE00", Offset = "0xFEAC00", VA = "0x10FEBE00")] get
      {
        return (List<ConceptCardMaterialData>) null;
      }
    }

    [Token(Token = "0x170006EA")]
    public List<SkinConceptCardData> SkinConceptCards
    {
      [Token(Token = "0x6004561"), Address(RVA = "0x11C8D30", Offset = "0x11C7B30", VA = "0x111C8D30")] get
      {
        return (List<SkinConceptCardData>) null;
      }
    }

    [Token(Token = "0x6004562")]
    [Address(RVA = "0x11AA190", Offset = "0x11A8F90", VA = "0x111AA190")]
    public ConceptCardData FindConceptCardByUniqueID(long iid) => (ConceptCardData) null;

    [Token(Token = "0x6004563")]
    [Address(RVA = "0x11BC650", Offset = "0x11BB450", VA = "0x111BC650")]
    public void RemoveConceptCardData(long[] iids)
    {
    }

    [Token(Token = "0x6004564")]
    [Address(RVA = "0x11C32D0", Offset = "0x11C20D0", VA = "0x111C32D0")]
    public void UpdateConceptCardNum()
    {
    }

    [Token(Token = "0x6004565")]
    [Address(RVA = "0x11C31A0", Offset = "0x11C1FA0", VA = "0x111C31A0")]
    public void UpdateConceptCardNum(string[] inames)
    {
    }

    [Token(Token = "0x6004566")]
    [Address(RVA = "0x11ACEF0", Offset = "0x11ABCF0", VA = "0x111ACEF0")]
    public int GetConceptCardNum(string iname) => new int();

    [Token(Token = "0x6004567")]
    [Address(RVA = "0x11ACBD0", Offset = "0x11AB9D0", VA = "0x111ACBD0")]
    public int GetConceptCardMaterialNum(string iname) => new int();

    [Token(Token = "0x6004568")]
    [Address(RVA = "0x11ACD40", Offset = "0x11ABB40", VA = "0x111ACD40")]
    public OLong GetConceptCardMaterialUniqueID(string iname) => new OLong();

    [Token(Token = "0x6004569")]
    [Address(RVA = "0x11AD9E0", Offset = "0x11AC7E0", VA = "0x111AD9E0")]
    public int GetEnhanceConceptCardMaterial() => new int();

    [Token(Token = "0x600456A")]
    [Address(RVA = "0x11BBA10", Offset = "0x11BA810", VA = "0x111BBA10")]
    public void OverWriteConceptCardMaterials(JSON_ConceptCardMaterial[] concept_card_materials)
    {
    }

    [Token(Token = "0x600456B")]
    [Address(RVA = "0x11BE300", Offset = "0x11BD100", VA = "0x111BE300")]
    public void SetConceptCardNum(string iname, int value)
    {
    }

    [Token(Token = "0x600456C")]
    [Address(RVA = "0x11B7450", Offset = "0x11B6250", VA = "0x111B7450")]
    public void OnDirtyConceptCardData()
    {
    }

    [Token(Token = "0x600456D")]
    [Address(RVA = "0x11B7550", Offset = "0x11B6350", VA = "0x111B7550")]
    public void OnDirtyRuneData()
    {
    }

    [Token(Token = "0x600456E")]
    [Address(RVA = "0x11B74E0", Offset = "0x11B62E0", VA = "0x111B74E0")]
    public void OnDirtyCrystalData()
    {
    }

    [Token(Token = "0x600456F")]
    [Address(RVA = "0x11B3690", Offset = "0x11B2490", VA = "0x111B3690")]
    public bool IsHaveHealAPItems() => new bool();

    [Token(Token = "0x6004570")]
    [Address(RVA = "0x11B3430", Offset = "0x11B2230", VA = "0x111B3430")]
    public bool IsHaveConceptCardExpMaterial() => new bool();

    [Token(Token = "0x6004571")]
    [Address(RVA = "0x11B3560", Offset = "0x11B2360", VA = "0x111B3560")]
    public bool IsHaveConceptCardTrustMaterial() => new bool();

    [Token(Token = "0x6004572")]
    [Address(RVA = "0x11C2D30", Offset = "0x11C1B30", VA = "0x111C2D30")]
    public void UpdateConceptCardEquipedSlots(Json_Unit[] units)
    {
    }

    [Token(Token = "0x6004573")]
    [Address(RVA = "0x11C2BC0", Offset = "0x11C19C0", VA = "0x111C2BC0")]
    public void UpdateConceptCardEquipedSlotsAllUnit()
    {
    }

    [Token(Token = "0x6004574")]
    [Address(RVA = "0x11BFF90", Offset = "0x11BED90", VA = "0x111BFF90")]
    public void SetTowerFloorResetCoin(ReqTowerFloorReset.Json_Response result)
    {
    }

    [Token(Token = "0x6004575")]
    [Address(RVA = "0x11BE4F0", Offset = "0x11BD2F0", VA = "0x111BE4F0")]
    public void SetDrawPremiumLoginBonus(string _productid)
    {
    }

    [Token(Token = "0x6004576")]
    [Address(RVA = "0x11BE4D0", Offset = "0x11BD2D0", VA = "0x111BE4D0")]
    public void SetDrawPremiumLoginBonus(Json_LoginBonusTable _table)
    {
    }

    [Token(Token = "0x6004577")]
    [Address(RVA = "0x11BF700", Offset = "0x11BE500", VA = "0x111BF700")]
    public void SetPremiumLoginBonus(Json_LoginBonusTable[] loginbonus)
    {
    }

    [Token(Token = "0x6004578")]
    [Address(RVA = "0x11AFC80", Offset = "0x11AEA80", VA = "0x111AFC80")]
    public Json_LoginBonusTable GetPremiumLoginBonus(Json_LoginBonusTable loginbonus)
    {
      return (Json_LoginBonusTable) null;
    }

    [Token(Token = "0x6004579")]
    [Address(RVA = "0x11BDD10", Offset = "0x11BCB10", VA = "0x111BDD10")]
    public void SetAutoRepeatQuestBox(int box_add_count)
    {
    }

    [Token(Token = "0x600457A")]
    [Address(RVA = "0x11B1DF0", Offset = "0x11B0BF0", VA = "0x111B1DF0")]
    public bool IsAutoRepeatQuestBoxSizeLimit() => new bool();

    [Token(Token = "0x600457B")]
    [Address(RVA = "0x11BDC00", Offset = "0x11BCA00", VA = "0x111BDC00")]
    public void SetAutoRepeatQuestApItemPriority(string[] ap_items)
    {
    }

    [Token(Token = "0x600457C")]
    [Address(RVA = "0x11BDCF0", Offset = "0x11BCAF0", VA = "0x111BDCF0")]
    public void SetAutoRepeatQuestBoxExpansion(int box_add_count)
    {
    }

    [Token(Token = "0x600457D")]
    [Address(RVA = "0x11BDD40", Offset = "0x11BCB40", VA = "0x111BDD40")]
    public void SetAutoRepeatQuestToggle(bool is_full_box, bool is_drip, bool is_push)
    {
    }

    [Token(Token = "0x600457E")]
    [Address(RVA = "0x11B4240", Offset = "0x11B3040", VA = "0x111B4240")]
    public bool IsUseAutoRepeatQuest(QuestParam currentQuest) => new bool();

    [Token(Token = "0x170006EB")]
    public Dictionary<long, RuneData> Runes
    {
      [Token(Token = "0x600457F"), Address(RVA = "0x349440", Offset = "0x348240", VA = "0x10349440")] get
      {
        return (Dictionary<long, RuneData>) null;
      }
    }

    [Token(Token = "0x6004580")]
    [Address(RVA = "0x11AAB90", Offset = "0x11A9990", VA = "0x111AAB90")]
    public RuneData FindRuneByUniqueID(long iid) => (RuneData) null;

    [Token(Token = "0x6004581")]
    [Address(RVA = "0xA23110", Offset = "0xA21F10", VA = "0x10A23110")]
    public List<RuneEnforceGaugeData> GetRuneEnforceGauge() => (List<RuneEnforceGaugeData>) null;

    [Token(Token = "0x6004582")]
    [Address(RVA = "0x11B0280", Offset = "0x11AF080", VA = "0x111B0280")]
    public short GetRuneStrage() => new short();

    [Token(Token = "0x6004583")]
    [Address(RVA = "0x11AABF0", Offset = "0x11A99F0", VA = "0x111AABF0")]
    public bool FindRuneOwner(RuneData rune, out UnitData unit) => new bool();

    [Token(Token = "0x6004584")]
    [Address(RVA = "0x11BCB30", Offset = "0x11BB930", VA = "0x111BCB30")]
    public bool RemoveRunes(long[] unique_id) => new bool();

    [Token(Token = "0x6004585")]
    [Address(RVA = "0x11AFE60", Offset = "0x11AEC60", VA = "0x111AFE60")]
    public UnitData GetRuneOwner(RuneData data, eOverWritePartyType type) => (UnitData) null;

    [Token(Token = "0x6004586")]
    [Address(RVA = "0x11B2EB0", Offset = "0x11B1CB0", VA = "0x111B2EB0")]
    public bool IsExistReceivableCoinBuyUseBonus(
      eCoinBuyUseBonusTrigger trigger,
      eCoinBuyUseBonusType type)
    {
      return new bool();
    }

    [Token(Token = "0x6004587")]
    [Address(RVA = "0x11AC970", Offset = "0x11AB770", VA = "0x111AC970")]
    public int GetCoinBuyUseBonusProgress(string bonus_iname) => new int();

    [Token(Token = "0x6004588")]
    [Address(RVA = "0x11B1910", Offset = "0x11B0710", VA = "0x111B1910")]
    public bool IsAchievedCoinBuyUseBonus(string bonus_iname, int coin_num) => new bool();

    [Token(Token = "0x6004589")]
    [Address(RVA = "0x11B3E10", Offset = "0x11B2C10", VA = "0x111B3E10")]
    public bool IsReceivableCoinBuyUseBonus(string bonus_iname, int coin_num) => new bool();

    [Token(Token = "0x600458A")]
    [Address(RVA = "0x11B3F30", Offset = "0x11B2D30", VA = "0x111B3F30")]
    public bool IsReceivedCoinBuyUseBonus(string bonus_iname, int coin_num) => new bool();

    [Token(Token = "0x600458B")]
    [Address(RVA = "0x11ACA40", Offset = "0x11AB840", VA = "0x111ACA40")]
    public PlayerCoinBuyUseBonusRewardState GetCoinBuyUseBonusRewardState(
      string bonus_iname,
      int coin_num)
    {
      return (PlayerCoinBuyUseBonusRewardState) null;
    }

    [Token(Token = "0x170006EC")]
    public PlayerData.TrophyStarMission TrophyStarMissionInfo
    {
      [Token(Token = "0x600458C"), Address(RVA = "0x11C8F00", Offset = "0x11C7D00", VA = "0x111C8F00")] get
      {
        return (PlayerData.TrophyStarMission) null;
      }
      [Token(Token = "0x600458D"), Address(RVA = "0x11C9500", Offset = "0x11C8300", VA = "0x111C9500")] set
      {
      }
    }

    [Token(Token = "0x600458E")]
    [Address(RVA = "0x11B2030", Offset = "0x11B0E30", VA = "0x111B2030")]
    public bool IsCanGetRewardTrophyStarMission() => new bool();

    [Token(Token = "0x600458F")]
    [Address(RVA = "0x11B6200", Offset = "0x11B5000", VA = "0x111B6200")]
    public void LoginReset()
    {
    }

    [Token(Token = "0x6004590")]
    [Address(RVA = "0x11AC120", Offset = "0x11AAF20", VA = "0x111AC120")]
    public int GetAllUnitsTotalStrength() => new int();

    [Token(Token = "0x6004591")]
    [Address(RVA = "0x11C5320", Offset = "0x11C4120", VA = "0x111C5320")]
    public void UpdateTotalCombatPower()
    {
    }

    [Token(Token = "0x6004592")]
    [Address(RVA = "0x11A1460", Offset = "0x11A0260", VA = "0x111A1460")]
    public void ClearTotalCombatPowerRequestFlag()
    {
    }

    [Token(Token = "0x6004593")]
    [Address(RVA = "0x11C1DF0", Offset = "0x11C0BF0", VA = "0x111C1DF0")]
    public void UpdateCombatPowerTrophy()
    {
    }

    [Token(Token = "0x170006ED")]
    public int CrystalCap
    {
      [Token(Token = "0x6004594"), Address(RVA = "0x11C84B0", Offset = "0x11C72B0", VA = "0x111C84B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6004595")]
    [Address(RVA = "0x119F0A0", Offset = "0x119DEA0", VA = "0x1119F0A0")]
    public bool CheckCrystalCapacity(int addValue) => new bool();

    [Token(Token = "0x6004596")]
    [Address(RVA = "0x11ACFA0", Offset = "0x11ABDA0", VA = "0x111ACFA0")]
    public int GetCrystalHaveCount(string iname) => new int();

    [Token(Token = "0x6004597")]
    [Address(RVA = "0x11AE300", Offset = "0x11AD100", VA = "0x111AE300")]
    public List<string> GetHaveCrystalInames() => (List<string>) null;

    [Token(Token = "0x6004598")]
    [Address(RVA = "0x11A3F90", Offset = "0x11A2D90", VA = "0x111A3F90")]
    public void DeleteCrystals(long[] _ids)
    {
    }

    [Token(Token = "0x6004599")]
    [Address(RVA = "0x11A3E90", Offset = "0x11A2C90", VA = "0x111A3E90")]
    public void DeleteCrystal(long _id)
    {
    }

    [Token(Token = "0x600459A")]
    [Address(RVA = "0x11AD080", Offset = "0x11ABE80", VA = "0x111AD080")]
    public UnitData GetCrystalOwner(CrystalData data, eOverWritePartyType type) => (UnitData) null;

    [Token(Token = "0x600459B")]
    [Address(RVA = "0x11B26C0", Offset = "0x11B14C0", VA = "0x111B26C0")]
    public PlayerData.IsEnoughNeedItemResult IsEnoughRunePrideNeedItem(
      List<RunePrideItemData> _data_list)
    {
      return new PlayerData.IsEnoughNeedItemResult();
    }

    [Token(Token = "0x600459C")]
    [Address(RVA = "0x11AFEE0", Offset = "0x11AECE0", VA = "0x111AFEE0")]
    public void GetRunePrideNeedReplaceInfo(
      List<RunePrideItemData> _data_list,
      out int _repleace_num,
      out string _target_iname,
      out List<string> _sub_inames)
    {
    }

    [Token(Token = "0x600459D")]
    [Address(RVA = "0x11AF5B0", Offset = "0x11AE3B0", VA = "0x111AF5B0")]
    public JSON_PlayerBuff GetPlayerBuffSerialze() => (JSON_PlayerBuff) null;

    [Token(Token = "0x600459E")]
    [Address(RVA = "0x11C4020", Offset = "0x11C2E20", VA = "0x111C4020")]
    public void UpdatePlayerBuffs()
    {
    }

    [Token(Token = "0x600459F")]
    [Address(RVA = "0x11C3ED0", Offset = "0x11C2CD0", VA = "0x111C3ED0")]
    public void UpdatePlayerBuffs(
      List<UnitData> _units,
      List<AdventureDataBase> _AdvDataBaseList,
      List<BondData> _BondDatas)
    {
    }

    [Token(Token = "0x60045A0")]
    [Address(RVA = "0x11BF010", Offset = "0x11BDE10", VA = "0x111BF010")]
    public void SetPlayerBuff(
      UnitData _unit,
      JSON_PlayerBuff _json,
      ref List<AdventureDataBase> _AdvDataBaseList,
      ref List<BondData> _BondDatas)
    {
    }

    [Token(Token = "0x60045A1")]
    [Address(RVA = "0x11BF3A0", Offset = "0x11BE1A0", VA = "0x111BF3A0")]
    public void SetPlayerBuff(
      UnitData[] _units,
      JSON_PlayerBuff _json,
      ref List<AdventureDataBase> _AdvDataBaseList,
      ref List<BondData> _BondDatas)
    {
    }

    [Token(Token = "0x60045A2")]
    [Address(RVA = "0x11BF0B0", Offset = "0x11BDEB0", VA = "0x111BF0B0")]
    public void SetPlayerBuff(
      List<UnitData> _units,
      JSON_PlayerBuff _json,
      ref List<AdventureDataBase> _AdvDataBaseList,
      ref List<BondData> _BondDatas,
      bool isDummyData = false)
    {
    }

    [Token(Token = "0x170006EE")]
    [IgnoreMember]
    public bool IsEndTutorialGacha
    {
      [Token(Token = "0x60045A3"), Address(RVA = "0x11C8860", Offset = "0x11C7660", VA = "0x111C8860")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006EF")]
    [IgnoreMember]
    public bool IsEndNameSet
    {
      [Token(Token = "0x60045A4"), Address(RVA = "0x11C8850", Offset = "0x11C7650", VA = "0x111C8850")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60045A5")]
    [Address(RVA = "0x11C5570", Offset = "0x11C4370", VA = "0x111C5570")]
    public void UpdateTutorialGacha(bool value)
    {
    }

    [Token(Token = "0x60045A6")]
    [Address(RVA = "0x11C3EB0", Offset = "0x11C2CB0", VA = "0x111C3EB0")]
    public void UpdateNameSet(bool value)
    {
    }

    [Token(Token = "0x60045A7")]
    [Address(RVA = "0x11B4210", Offset = "0x11B3010", VA = "0x111B4210")]
    public bool IsTutorialSkipping() => new bool();

    [Token(Token = "0x60045A8")]
    [Address(RVA = "0x11A59A0", Offset = "0x11A47A0", VA = "0x111A59A0")]
    public void Deserialize(ReqPlayerInfo.Response json)
    {
    }

    [Token(Token = "0x170006F0")]
    public Json_LoginBonusTable DrawPremiumBonus
    {
      [Token(Token = "0x60045A9"), Address(RVA = "0x11C8580", Offset = "0x11C7380", VA = "0x111C8580")] get
      {
        return (Json_LoginBonusTable) null;
      }
    }

    [Token(Token = "0x60045AA")]
    [Address(RVA = "0x11BDE30", Offset = "0x11BCC30", VA = "0x111BDE30")]
    public void SetCoinPurchaseResult(PaymentManager.CoinRecord record)
    {
    }

    [Token(Token = "0x60045AB")]
    [Address(RVA = "0x11BEAB0", Offset = "0x11BD8B0", VA = "0x111BEAB0")]
    public void SetOrderResult(FulfillmentResult.OrderInfo order, bool isDupe)
    {
    }

    [Token(Token = "0x60045AC")]
    [Address(RVA = "0x11AF990", Offset = "0x11AE790", VA = "0x111AF990")]
    public int GetPremiumDateSpan() => new int();

    [Token(Token = "0x60045AD")]
    [Address(RVA = "0x11AA9B0", Offset = "0x11A97B0", VA = "0x111AA9B0")]
    public Json_PremiumLoginBonus[] FindPremiumLoginBonuses(string type)
    {
      return (Json_PremiumLoginBonus[]) null;
    }

    [Token(Token = "0x60045AE")]
    [Address(RVA = "0x11B31B0", Offset = "0x11B1FB0", VA = "0x111B31B0")]
    public bool IsHaveAllPremiumLoginBonusInfo() => new bool();

    [Token(Token = "0x60045AF")]
    [Address(RVA = "0x11B3990", Offset = "0x11B2790", VA = "0x111B3990")]
    public bool IsPremiumLoginBonus(string _productid) => new bool();

    [Token(Token = "0x60045B0")]
    [Address(RVA = "0x11BF870", Offset = "0x11BE670", VA = "0x111BF870")]
    public void SetPremiumLoginBonus(string _productid, Json_LoginBonusTable json)
    {
    }

    [Token(Token = "0x60045B1")]
    [Address(RVA = "0x11BCCB0", Offset = "0x11BBAB0", VA = "0x111BCCB0")]
    public void ResetPremiumLoginBonus()
    {
    }

    [Token(Token = "0x60045B2")]
    [Address(RVA = "0x11BF610", Offset = "0x11BE410", VA = "0x111BF610")]
    public void SetPremiumLoginBonusTime(int _type, OLong _time)
    {
    }

    [Token(Token = "0x60045B3")]
    [Address(RVA = "0x11BF460", Offset = "0x11BE260", VA = "0x111BF460")]
    public void SetPremiumLoginBonusTime(string _productid, OLong _time)
    {
    }

    [Token(Token = "0x60045B4")]
    [Address(RVA = "0x11AFCF0", Offset = "0x11AEAF0", VA = "0x111AFCF0")]
    public Json_LoginBonusTable GetPremiumTable(string _productid) => (Json_LoginBonusTable) null;

    [Token(Token = "0x60045B5")]
    [Address(RVA = "0x11AFBE0", Offset = "0x11AE9E0", VA = "0x111AFBE0")]
    public long GetPremiumExpiredAt(string _productid) => new long();

    [Token(Token = "0x60045B6")]
    [Address(RVA = "0x11AFB80", Offset = "0x11AE980", VA = "0x111AFB80")]
    public DateTime GetPremiumExpiredAtTime(string _productid) => new DateTime();

    [Token(Token = "0x60045B7")]
    [Address(RVA = "0x11B2650", Offset = "0x11B1450", VA = "0x111B2650")]
    public bool IsEnablePremiumMember(string _productid) => new bool();

    [Token(Token = "0x60045B8")]
    [Address(RVA = "0x11ACB20", Offset = "0x11AB920", VA = "0x111ACB20")]
    private string GetCommonProductID_FromAu(string _productid) => (string) null;

    [Token(Token = "0x170006F1")]
    public List<ExpansionPurchaseData> Expansions
    {
      [Token(Token = "0x60045B9"), Address(RVA = "0x11C85C0", Offset = "0x11C73C0", VA = "0x111C85C0")] get
      {
        return (List<ExpansionPurchaseData>) null;
      }
    }

    [Token(Token = "0x60045BA")]
    [Address(RVA = "0x11A8DB0", Offset = "0x11A7BB0", VA = "0x111A8DB0")]
    public void Deserialize(Json_ExpansionPurchase[] expansions)
    {
    }

    [Token(Token = "0x60045BB")]
    [Address(RVA = "0x11ADAC0", Offset = "0x11AC8C0", VA = "0x111ADAC0")]
    public ExpansionPurchaseData[] GetExpansionDatas(ExpansionPurchaseParam.eType type)
    {
      return (ExpansionPurchaseData[]) null;
    }

    [Token(Token = "0x60045BC")]
    [Address(RVA = "0x11AD7B0", Offset = "0x11AC5B0", VA = "0x111AD7B0")]
    public ExpansionPurchaseData[] GetEnableExpansionDatas(
      ExpansionPurchaseParam.eType type,
      bool is_enable_check = true,
      int _value = 0)
    {
      return (ExpansionPurchaseData[]) null;
    }

    [Token(Token = "0x60045BD")]
    [Address(RVA = "0x11AD210", Offset = "0x11AC010", VA = "0x111AD210")]
    public ExpansionPurchaseData[] GetEffectiveData(ExpansionPurchaseParam.eType _type)
    {
      return (ExpansionPurchaseData[]) null;
    }

    [Token(Token = "0x60045BE")]
    [Address(RVA = "0x11AC520", Offset = "0x11AB320", VA = "0x111AC520")]
    public int GetChallengeLimitCount(
      ExpansionPurchaseParam.eType _type,
      string _iname,
      int _challenge_limit_count)
    {
      return new int();
    }

    [Token(Token = "0x60045BF")]
    [Address(RVA = "0x11ADCE0", Offset = "0x11ACAE0", VA = "0x111ADCE0")]
    public long GetExpansionGroupExpiredAt(BuyCoinProductParam _param) => new long();

    [Token(Token = "0x60045C0")]
    [Address(RVA = "0x11B22C0", Offset = "0x11B10C0", VA = "0x111B22C0")]
    public bool IsEnableExpansionPurchaseForValue(int _value, ExpansionPurchaseParam.eType _type)
    {
      return new bool();
    }

    [Token(Token = "0x60045C1")]
    [Address(RVA = "0x11B2620", Offset = "0x11B1420", VA = "0x111B2620")]
    public bool IsEnableExpansion(ExpansionPurchaseParam.eType _type) => new bool();

    [Token(Token = "0x60045C2")]
    [Address(RVA = "0x11B2540", Offset = "0x11B1340", VA = "0x111B2540")]
    public bool IsEnableExpansion(string _iname) => new bool();

    [Token(Token = "0x60045C3")]
    [Address(RVA = "0x11ADAE0", Offset = "0x11AC8E0", VA = "0x111ADAE0")]
    public DateTime GetExpansionEndTime(ExpansionPurchaseParam.eType _type, int _value = 0)
    {
      return new DateTime();
    }

    [Token(Token = "0x60045C4")]
    [Address(RVA = "0x11ADBA0", Offset = "0x11AC9A0", VA = "0x111ADBA0")]
    public DateTime GetExpansionEndTime(string _iname) => new DateTime();

    [Token(Token = "0x60045C5")]
    [Address(RVA = "0x11AE0F0", Offset = "0x11ACEF0", VA = "0x111AE0F0")]
    public List<ExpansionPurchaseType> GetExpansionTypeList(ExpansionPurchaseParam.eType _type)
    {
      return (List<ExpansionPurchaseType>) null;
    }

    [Token(Token = "0x60045C6")]
    [Address(RVA = "0x11B1A20", Offset = "0x11B0820", VA = "0x111B1A20")]
    public bool IsAnyRepurchase() => new bool();

    [Token(Token = "0x170006F2")]
    public PlayerData_GvG GvGData
    {
      [Token(Token = "0x60045C7"), Address(RVA = "0x11C8700", Offset = "0x11C7500", VA = "0x111C8700")] get
      {
        return (PlayerData_GvG) null;
      }
    }

    [Token(Token = "0x60045C8")]
    [Address(RVA = "0x11A13A0", Offset = "0x11A01A0", VA = "0x111A13A0")]
    public void ClearPlayerGvGData()
    {
    }

    [Token(Token = "0x170006F3")]
    public PlayerData.PlayerData_LeagueMatch LeagueMatch
    {
      [Token(Token = "0x60045C9"), Address(RVA = "0x11C8A40", Offset = "0x11C7840", VA = "0x111C8A40")] get
      {
        return (PlayerData.PlayerData_LeagueMatch) null;
      }
    }

    [Token(Token = "0x60045CA")]
    [Address(RVA = "0x11A13D0", Offset = "0x11A01D0", VA = "0x111A13D0")]
    public void ClearPlayerLeagueMatchData()
    {
    }

    [Token(Token = "0x170006F4")]
    public PlayerData.PlayerData_Rune Rune
    {
      [Token(Token = "0x60045CB"), Address(RVA = "0x11C8CC0", Offset = "0x11C7AC0", VA = "0x111C8CC0")] get
      {
        return (PlayerData.PlayerData_Rune) null;
      }
    }

    [Token(Token = "0x60045CC")]
    [Address(RVA = "0x11A1400", Offset = "0x11A0200", VA = "0x111A1400")]
    public void ClearPlayerRuneData()
    {
    }

    [Token(Token = "0x170006F5")]
    public PlayerData.PlayerData_UnitUseItem PlayerUnitUseItem
    {
      [Token(Token = "0x60045CD"), Address(RVA = "0x11C8BD0", Offset = "0x11C79D0", VA = "0x111C8BD0")] get
      {
        return (PlayerData.PlayerData_UnitUseItem) null;
      }
    }

    [Token(Token = "0x60045CE")]
    [Address(RVA = "0x11A1430", Offset = "0x11A0230", VA = "0x111A1430")]
    public void ClearPlayerUnitUseItemData()
    {
    }

    [Token(Token = "0x60045CF")]
    [Address(RVA = "0x11C6440", Offset = "0x11C5240", VA = "0x111C6440")]
    static PlayerData()
    {
    }

    [Token(Token = "0x200105B")]
    [Flags]
    public enum EDeserializeFlags
    {
      [Token(Token = "0x4003B51")] None = 0,
      [Token(Token = "0x4003B52")] Gold = 1,
      [Token(Token = "0x4003B53")] Coin = 2,
      [Token(Token = "0x4003B54")] Stamina = 4,
      [Token(Token = "0x4003B55")] Cave = 8,
      [Token(Token = "0x4003B56")] AbilityUp = 16, // 0x00000010
      [Token(Token = "0x4003B57")] Arena = 32, // 0x00000020
      [Token(Token = "0x4003B58")] Tour = 64, // 0x00000040
    }

    [Token(Token = "0x200105C")]
    public class Json_InitData
    {
      [Token(Token = "0x4003B59")]
      [FieldOffset(Offset = "0x8")]
      public PlayerData.Json_InitUnits[] units;
      [Token(Token = "0x4003B5A")]
      [FieldOffset(Offset = "0xC")]
      public PlayerData.Json_InitItems[] items;
      [Token(Token = "0x4003B5B")]
      [FieldOffset(Offset = "0x10")]
      public PlayerData.Json_InitParty[] party;
      [Token(Token = "0x4003B5C")]
      [FieldOffset(Offset = "0x14")]
      public PlayerData.Json_InitUnits[] friends;

      [Token(Token = "0x60045D1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_InitData()
      {
      }
    }

    [Token(Token = "0x200105D")]
    public class Json_FriendData
    {
      [Token(Token = "0x4003B5D")]
      [FieldOffset(Offset = "0x8")]
      public Json_Unit[] friends;

      [Token(Token = "0x60045D2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_FriendData()
      {
      }
    }

    [Token(Token = "0x200105E")]
    public class Json_InitUnits
    {
      [Token(Token = "0x4003B5E")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4003B5F")]
      [FieldOffset(Offset = "0xC")]
      public int exp;
      [Token(Token = "0x4003B60")]
      [FieldOffset(Offset = "0x10")]
      public string[] skills;

      [Token(Token = "0x60045D3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_InitUnits()
      {
      }
    }

    [Token(Token = "0x200105F")]
    public class Json_InitItems
    {
      [Token(Token = "0x4003B61")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4003B62")]
      [FieldOffset(Offset = "0xC")]
      public int num;

      [Token(Token = "0x60045D4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_InitItems()
      {
      }
    }

    [Token(Token = "0x2001060")]
    public class Json_InitParty
    {
      [Token(Token = "0x4003B63")]
      [FieldOffset(Offset = "0x8")]
      public PlayerData.Json_InitPartyUnit[] units;

      [Token(Token = "0x60045D5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_InitParty()
      {
      }
    }

    [Token(Token = "0x2001061")]
    public class Json_InitPartyUnit
    {
      [Token(Token = "0x4003B64")]
      [FieldOffset(Offset = "0x8")]
      public int iid;
      [Token(Token = "0x4003B65")]
      [FieldOffset(Offset = "0xC")]
      public int leader;

      [Token(Token = "0x60045D6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_InitPartyUnit()
      {
      }
    }

    [Token(Token = "0x2001062")]
    public class TrophyStarMission
    {
      [Token(Token = "0x4003B66")]
      [FieldOffset(Offset = "0x8")]
      public PlayerData.TrophyStarMission.StarMission Daily;
      [Token(Token = "0x4003B67")]
      [FieldOffset(Offset = "0xC")]
      public PlayerData.TrophyStarMission.StarMission Weekly;

      [Token(Token = "0x60045D7")]
      [Address(RVA = "0x11EA670", Offset = "0x11E9470", VA = "0x111EA670")]
      public void Update(ReqTrophyStarMission.StarMission star_mission)
      {
      }

      [Token(Token = "0x60045D8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TrophyStarMission()
      {
      }

      [Token(Token = "0x2001063")]
      public class StarMission
      {
        [Token(Token = "0x4003B68")]
        [FieldOffset(Offset = "0x8")]
        public TrophyStarMissionParam TsmParam;
        [Token(Token = "0x4003B69")]
        [FieldOffset(Offset = "0xC")]
        public int YyMmDd;
        [Token(Token = "0x4003B6A")]
        [FieldOffset(Offset = "0x10")]
        public int StarNum;
        [Token(Token = "0x4003B6B")]
        [FieldOffset(Offset = "0x14")]
        public int[] Rewards;

        [Token(Token = "0x60045D9")]
        [Address(RVA = "0x11E9BA0", Offset = "0x11E89A0", VA = "0x111E9BA0")]
        public void SetRewards(int[] rewards)
        {
        }

        [Token(Token = "0x60045DA")]
        [Address(RVA = "0x11E9C10", Offset = "0x11E8A10", VA = "0x111E9C10")]
        public void Update(ReqTrophyStarMission.StarMission.Info info)
        {
        }

        [Token(Token = "0x60045DB")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public StarMission()
        {
        }
      }
    }

    [Token(Token = "0x2001064")]
    public struct IsEnoughNeedItemResult
    {
      [Token(Token = "0x4003B6C")]
      [FieldOffset(Offset = "0x0")]
      public bool IsEnoughItem;
      [Token(Token = "0x4003B6D")]
      [FieldOffset(Offset = "0x1")]
      public bool IsEnoughGold;
      [Token(Token = "0x4003B6E")]
      [FieldOffset(Offset = "0x2")]
      public bool IsEnoughCoin;

      [Token(Token = "0x60045DC")]
      [Address(RVA = "0x11DDA50", Offset = "0x11DC850", VA = "0x111DDA50")]
      public IsEnoughNeedItemResult(bool _isEnoughItem, bool _isEnoughGold, bool _isEnoughCoin)
      {
      }
    }

    [Token(Token = "0x2001065")]
    private class PremiumLoginStatus
    {
      [Token(Token = "0x4003B6F")]
      [FieldOffset(Offset = "0x8")]
      public Json_LoginBonusTable table;
      [Token(Token = "0x4003B70")]
      [FieldOffset(Offset = "0x10")]
      public OLong time;

      [Token(Token = "0x60045DD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PremiumLoginStatus()
      {
      }
    }

    [Token(Token = "0x2001066")]
    public class PlayerData_LeagueMatch
    {
      [Token(Token = "0x4003B71")]
      [FieldOffset(Offset = "0x8")]
      private ReqLeagueMatchTop.Response mResponse;
      [Token(Token = "0x4003B72")]
      [FieldOffset(Offset = "0xC")]
      private JSON_LeagueMatchDefenseParty mDefenseInfo;
      [Token(Token = "0x4003B73")]
      [FieldOffset(Offset = "0x10")]
      private JSON_LeagueMatchDefenseParty mDefenseNextInfo;
      [Token(Token = "0x4003B74")]
      [FieldOffset(Offset = "0x14")]
      private JSON_LeagueMatchDefenseParty mEditDefenseInfo;
      [Token(Token = "0x4003B75")]
      [FieldOffset(Offset = "0x18")]
      private JSON_LeagueMatchShamInfo mShamInfo;
      [Token(Token = "0x4003B76")]
      [FieldOffset(Offset = "0x1C")]
      private JSON_LeagueMatchMission[] mLeagueMatchMission;
      [Token(Token = "0x4003B77")]
      [FieldOffset(Offset = "0x20")]
      private JSON_LeagueMatchEnemies[] mLeagueMatchEnemies;
      [Token(Token = "0x4003B78")]
      [FieldOffset(Offset = "0x24")]
      private JSON_LeagueMatchParties[] mOffenseParties;
      [Token(Token = "0x4003B79")]
      [FieldOffset(Offset = "0x28")]
      private string mOffensePresetName;
      [Token(Token = "0x4003B7A")]
      [FieldOffset(Offset = "0x2C")]
      private JSON_LeagueMatchPresetPartyUnits[] mPresetPartyUnits;
      [Token(Token = "0x4003B7B")]
      [FieldOffset(Offset = "0x30")]
      private LeagueMatchTopModel mTopModel;
      [Token(Token = "0x4003B7C")]
      [FieldOffset(Offset = "0x34")]
      private bool mIsUnitEditAttackable;

      [Token(Token = "0x170006F6")]
      public ReqLeagueMatchTop.Response Response
      {
        [Token(Token = "0x60045DE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (ReqLeagueMatchTop.Response) null;
        }
      }

      [Token(Token = "0x170006F7")]
      public LeagueMatchTopModel TopModel
      {
        [Token(Token = "0x60045DF"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
        {
          return (LeagueMatchTopModel) null;
        }
      }

      [Token(Token = "0x170006F8")]
      public JSON_LeagueMatchDefenseParty DefenseInfo
      {
        [Token(Token = "0x60045E0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (JSON_LeagueMatchDefenseParty) null;
        }
      }

      [Token(Token = "0x170006F9")]
      public JSON_LeagueMatchDefenseParty DefenseNextInfo
      {
        [Token(Token = "0x60045E1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (JSON_LeagueMatchDefenseParty) null;
        }
      }

      [Token(Token = "0x170006FA")]
      public JSON_LeagueMatchDefenseParty EditDefenseInfo
      {
        [Token(Token = "0x60045E2"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (JSON_LeagueMatchDefenseParty) null;
        }
      }

      [Token(Token = "0x170006FB")]
      public JSON_LeagueMatchShamInfo ShamDefenseInfo
      {
        [Token(Token = "0x60045E3"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (JSON_LeagueMatchShamInfo) null;
        }
      }

      [Token(Token = "0x170006FC")]
      public JSON_LeagueMatchMission[] MissionInfo
      {
        [Token(Token = "0x60045E4"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (JSON_LeagueMatchMission[]) null;
        }
      }

      [Token(Token = "0x170006FD")]
      public JSON_LeagueMatchEnemies[] Enemies
      {
        [Token(Token = "0x60045E5"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return (JSON_LeagueMatchEnemies[]) null;
        }
      }

      [Token(Token = "0x170006FE")]
      public JSON_LeagueMatchParties[] OffenseParties
      {
        [Token(Token = "0x60045E6"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
        {
          return (JSON_LeagueMatchParties[]) null;
        }
      }

      [Token(Token = "0x170006FF")]
      public string OffensePresetName
      {
        [Token(Token = "0x60045E7"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000700")]
      public JSON_LeagueMatchPresetPartyUnits[] PresetPartyUnits
      {
        [Token(Token = "0x60045E8"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
        {
          return (JSON_LeagueMatchPresetPartyUnits[]) null;
        }
      }

      [Token(Token = "0x17000701")]
      public bool IsUnitEditAttackable
      {
        [Token(Token = "0x60045E9"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17000702")]
      public bool IsCanReceiveMission
      {
        [Token(Token = "0x60045EA"), Address(RVA = "0x11E2050", Offset = "0x11E0E50", VA = "0x111E2050")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x60045EB")]
      [Address(RVA = "0x11E1C40", Offset = "0x11E0A40", VA = "0x111E1C40")]
      public void SetData(ReqLeagueMatchTop.Response _response)
      {
      }

      [Token(Token = "0x60045EC")]
      [Address(RVA = "0x11E19F0", Offset = "0x11E07F0", VA = "0x111E19F0")]
      public void SetData(JSON_LeagueMatchDefenseInfo _defense_info)
      {
      }

      [Token(Token = "0x60045ED")]
      [Address(RVA = "0x11E19B0", Offset = "0x11E07B0", VA = "0x111E19B0")]
      public void SetData(JSON_LeagueMatchShamInfo _sham_defense_info)
      {
      }

      [Token(Token = "0x60045EE")]
      [Address(RVA = "0x11E1C00", Offset = "0x11E0A00", VA = "0x111E1C00")]
      public void SetData(JSON_LeagueMatchMission[] _missions)
      {
      }

      [Token(Token = "0x60045EF")]
      [Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")]
      public void SetData(JSON_LeagueMatchEnemies[] _enemies)
      {
      }

      [Token(Token = "0x60045F0")]
      [Address(RVA = "0x11E1970", Offset = "0x11E0770", VA = "0x111E1970")]
      public void SetData(JSON_LeagueMatchParties[] _parties)
      {
      }

      [Token(Token = "0x60045F1")]
      [Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")]
      public void SetData(LeagueMatchTopModel _topModel)
      {
      }

      [Token(Token = "0x60045F2")]
      [Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")]
      public void SetPresetName(string name)
      {
      }

      [Token(Token = "0x60045F3")]
      [Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")]
      public void SetData(JSON_LeagueMatchPresetPartyUnits[] _preset)
      {
      }

      [Token(Token = "0x60045F4")]
      [Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")]
      public void SetAttackable(bool _Value)
      {
      }

      [Token(Token = "0x60045F5")]
      [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
      public void SetEditDefenseInfo(JSON_LeagueMatchDefenseParty _Value)
      {
      }

      [Token(Token = "0x60045F6")]
      [Address(RVA = "0x11E17B0", Offset = "0x11E05B0", VA = "0x111E17B0")]
      public string LeagueMatchRankIconKey(int idx) => (string) null;

      [Token(Token = "0x60045F7")]
      [Address(RVA = "0x11E1890", Offset = "0x11E0690", VA = "0x111E1890")]
      public string LeagueMatchRankNameKey(int idx) => (string) null;

      [Token(Token = "0x60045F8")]
      [Address(RVA = "0x11E1770", Offset = "0x11E0570", VA = "0x111E1770")]
      public int GetLeagueMatchResultIndex(LeagueMatchWinLoseTypes type) => new int();

      [Token(Token = "0x60045F9")]
      [Address(RVA = "0x11E0B50", Offset = "0x11DF950", VA = "0x111E0B50")]
      public bool CheckEnableMap(string select_map) => new bool();

      [Token(Token = "0x60045FA")]
      [Address(RVA = "0x11E08D0", Offset = "0x11DF6D0", VA = "0x111E08D0")]
      public JSON_LeagueMatchBuffs[] CheckEnableBuff(int season_id, JSON_LeagueMatchBuffs[] buffs)
      {
        return (JSON_LeagueMatchBuffs[]) null;
      }

      [Token(Token = "0x60045FB")]
      [Address(RVA = "0x11E0D00", Offset = "0x11DFB00", VA = "0x111E0D00")]
      public int CheckEnablePlacementIndex(
        long unit_iid,
        JSON_LeagueMatchSet[] placement_set,
        int party_max = 3)
      {
        return new int();
      }

      [Token(Token = "0x60045FC")]
      [Address(RVA = "0x11E0FD0", Offset = "0x11DFDD0", VA = "0x111E0FD0")]
      public void CheckShamInfoCover(
        JSON_LeagueMatchShamInfo shamInfo,
        bool isUseCheck,
        ref string shamMap,
        ref ShamCopyData shamCopyData)
      {
      }

      [Token(Token = "0x60045FD")]
      [Address(RVA = "0x11E1420", Offset = "0x11E0220", VA = "0x111E1420")]
      public void CheckUnit(
        bool isUseCheck,
        PlayerPartyTypes type,
        ref List<UnitData> unitList,
        ref ShamCopyData shamCopyData)
      {
      }

      [Token(Token = "0x60045FE")]
      [Address(RVA = "0x11E1740", Offset = "0x11E0540", VA = "0x111E1740")]
      public JSON_LeagueMatchDefenseParty GetAnotherInfo() => (JSON_LeagueMatchDefenseParty) null;

      [Token(Token = "0x60045FF")]
      [Address(RVA = "0x11E0F00", Offset = "0x11DFD00", VA = "0x111E0F00")]
      public bool CheckNextDefenseUnit(long uniqueID) => new bool();

      [Token(Token = "0x6004600")]
      [Address(RVA = "0x11E0800", Offset = "0x11DF600", VA = "0x111E0800")]
      public bool CheckDefenseUnit(long uniqueID) => new bool();

      [Token(Token = "0x6004601")]
      [Address(RVA = "0x11E05A0", Offset = "0x11DF3A0", VA = "0x111E05A0")]
      public bool CheckDefenseEquiped(ArtifactData artifact) => new bool();

      [Token(Token = "0x6004602")]
      [Address(RVA = "0x11E0600", Offset = "0x11DF400", VA = "0x111E0600")]
      public bool CheckDefenseEquiped(ConceptCardData card) => new bool();

      [Token(Token = "0x6004603")]
      [Address(RVA = "0x11E0660", Offset = "0x11DF460", VA = "0x111E0660")]
      public bool CheckDefenseEquiped(RuneData rune) => new bool();

      [Token(Token = "0x6004604")]
      [Address(RVA = "0x11E06C0", Offset = "0x11DF4C0", VA = "0x111E06C0")]
      public bool CheckDefenseEquiped(CrystalData crystal) => new bool();

      [Token(Token = "0x6004605")]
      [Address(RVA = "0x11E0720", Offset = "0x11DF520", VA = "0x111E0720")]
      public bool CheckDefenseMap(string map) => new bool();

      [Token(Token = "0x6004606")]
      [Address(RVA = "0x11E0790", Offset = "0x11DF590", VA = "0x111E0790")]
      public bool CheckDefenseNextMap(string map) => new bool();

      [Token(Token = "0x6004607")]
      [Address(RVA = "0x11E2000", Offset = "0x11E0E00", VA = "0x111E2000")]
      public PlayerData_LeagueMatch()
      {
      }
    }

    [Token(Token = "0x2001075")]
    public class PlayerData_Rune
    {
      [Token(Token = "0x4003B8E")]
      [FieldOffset(Offset = "0x8")]
      private Dictionary<string, JSON_Rune_Auto_Option> mRuneAutoDictionary;
      [Token(Token = "0x4003B8F")]
      [FieldOffset(Offset = "0xC")]
      private JSON_Rune_Auto_Disassemble mRuneAutoDisassemble;

      [Token(Token = "0x17000703")]
      public Dictionary<string, JSON_Rune_Auto_Option> RuneAutoDictionary
      {
        [Token(Token = "0x6004629"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (Dictionary<string, JSON_Rune_Auto_Option>) null;
        }
      }

      [Token(Token = "0x17000704")]
      public JSON_Rune_Auto_Disassemble RuneAutoDisassemble
      {
        [Token(Token = "0x600462A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (JSON_Rune_Auto_Disassemble) null;
        }
      }

      [Token(Token = "0x600462B")]
      [Address(RVA = "0x11E24C0", Offset = "0x11E12C0", VA = "0x111E24C0")]
      public void Deserialize(JSON_Rune_Auto_Disassemble _rune_auto_disassemble)
      {
      }

      [Token(Token = "0x600462C")]
      [Address(RVA = "0x11E27A0", Offset = "0x11E15A0", VA = "0x111E27A0")]
      public void SetRuneAutoSet(string rare, JSON_Rune_Auto_Option param)
      {
      }

      [Token(Token = "0x600462D")]
      [Address(RVA = "0x11E2780", Offset = "0x11E1580", VA = "0x111E2780")]
      public void SetAutoDisassemble(bool isOn)
      {
      }

      [Token(Token = "0x600462E")]
      [Address(RVA = "0x11E2760", Offset = "0x11E1560", VA = "0x111E2760")]
      public bool GetRuneAutoCheck() => new bool();

      [Token(Token = "0x600462F")]
      [Address(RVA = "0x11E2610", Offset = "0x11E1410", VA = "0x111E2610")]
      public bool GetDetailSetCheck(string rare) => new bool();

      [Token(Token = "0x6004630")]
      [Address(RVA = "0x11E2840", Offset = "0x11E1640", VA = "0x111E2840")]
      public PlayerData_Rune()
      {
      }
    }

    [Token(Token = "0x2001077")]
    public class PlayerData_UnitUseItem
    {
      [Token(Token = "0x4003B93")]
      [FieldOffset(Offset = "0x8")]
      private List<long> mCrystalIids;
      [Token(Token = "0x4003B94")]
      [FieldOffset(Offset = "0xC")]
      private List<long> mUnitIids;

      [Token(Token = "0x6004635")]
      [Address(RVA = "0x11E28B0", Offset = "0x11E16B0", VA = "0x111E28B0")]
      public void Deserialize(ReqUnitUsedItem.Response json)
      {
      }

      [Token(Token = "0x6004636")]
      [Address(RVA = "0x11E2B10", Offset = "0x11E1910", VA = "0x111E2B10")]
      public bool IsUsedCrystal(long iid) => new bool();

      [Token(Token = "0x6004637")]
      [Address(RVA = "0x11E2BD0", Offset = "0x11E19D0", VA = "0x111E2BD0")]
      public bool IsUsedCrystal(CrystalData data) => new bool();

      [Token(Token = "0x6004638")]
      [Address(RVA = "0x11E29E0", Offset = "0x11E17E0", VA = "0x111E29E0")]
      public void Deserialize(ReqUnitUsedUnit.Response json)
      {
      }

      [Token(Token = "0x6004639")]
      [Address(RVA = "0x11E2CA0", Offset = "0x11E1AA0", VA = "0x111E2CA0")]
      public bool IsUsedUnit(long iid) => new bool();

      [Token(Token = "0x600463A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PlayerData_UnitUseItem()
      {
      }
    }
  }
}
