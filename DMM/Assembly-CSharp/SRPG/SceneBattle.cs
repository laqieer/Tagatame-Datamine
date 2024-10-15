// Decompiled with JetBrains decompiler
// Type: SRPG.SceneBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C7D")]
  [AddComponentMenu("Scripts/SRPG/Scene/Battle")]
  public class SceneBattle : Scene
  {
    [Token(Token = "0x40021E5")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string QUEST_TEXTTABLE;
    [Token(Token = "0x40021E6")]
    private const float RenkeiSceneFadeTime = 0.5f;
    [Token(Token = "0x40021E7")]
    private const float RenkeiSceneBrightness = 0.25f;
    [Token(Token = "0x40021E8")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Color RenkeiChargeColor;
    [Token(Token = "0x40021E9")]
    private const float RenkeiChargeTime = 1f;
    [Token(Token = "0x40021EA")]
    private const float RenkeiAssistInterval = 0.5f;
    [Token(Token = "0x40021EB")]
    [FieldOffset(Offset = "0x10")]
    public InGameMenu mInGameMenu;
    [Token(Token = "0x40021EC")]
    [FieldOffset(Offset = "0x14")]
    public static readonly string DefaultExitPoint;
    [Token(Token = "0x40021ED")]
    [FieldOffset(Offset = "0x18")]
    public static SceneBattle Instance;
    [Token(Token = "0x40021EE")]
    [FieldOffset(Offset = "0x14")]
    private int mStartPlayerLevel;
    [Token(Token = "0x40021EF")]
    private const float MinLoadSkillTime = 0.75f;
    [Token(Token = "0x40021F0")]
    [FieldOffset(Offset = "0x18")]
    private BattleCore mBattle;
    [Token(Token = "0x40021F1")]
    [FieldOffset(Offset = "0x1C")]
    private StateMachine<SceneBattle> mState;
    [Token(Token = "0x40021F2")]
    [FieldOffset(Offset = "0x20")]
    private Unit mSelectedBattleCommandTarget;
    [Token(Token = "0x40021F3")]
    [FieldOffset(Offset = "0x24")]
    private int mSelectedBattleCommandGridX;
    [Token(Token = "0x40021F4")]
    [FieldOffset(Offset = "0x28")]
    private int mSelectedBattleCommandGridY;
    [Token(Token = "0x40021F5")]
    [FieldOffset(Offset = "0x2C")]
    private SkillData mSelectedBattleCommandSkill;
    [Token(Token = "0x40021F6")]
    [FieldOffset(Offset = "0x30")]
    private ItemData mSelectedBattleCommandItem;
    [Token(Token = "0x40021F7")]
    [FieldOffset(Offset = "0x34")]
    private GameObject mNavigation;
    [Token(Token = "0x40021F8")]
    [FieldOffset(Offset = "0x38")]
    private FlowNode_TutorialTrigger[] mTutorialTriggers;
    [Token(Token = "0x40021F9")]
    [FieldOffset(Offset = "0x3C")]
    private bool mStartCalled;
    [Token(Token = "0x40021FA")]
    [FieldOffset(Offset = "0x3D")]
    private bool mStartQuestCalled;
    [Token(Token = "0x40021FB")]
    [FieldOffset(Offset = "0x40")]
    private int mUnitStartCount;
    [Token(Token = "0x40021FC")]
    [FieldOffset(Offset = "0x44")]
    private int mUnitStartCountTotal;
    [Token(Token = "0x40021FD")]
    [FieldOffset(Offset = "0x48")]
    public bool IsNoCountUpUnitStartCount;
    [Token(Token = "0x40021FE")]
    [FieldOffset(Offset = "0x4C")]
    private FlowNode_BattleUI mBattleUI;
    [Token(Token = "0x40021FF")]
    [FieldOffset(Offset = "0x50")]
    private FlowNode_BattleUI_MultiPlay mBattleUI_MultiPlay;
    [Token(Token = "0x4002200")]
    [FieldOffset(Offset = "0x54")]
    private bool mUISignal;
    [Token(Token = "0x4002201")]
    [FieldOffset(Offset = "0x58")]
    private UnitCursor UnitCursor;
    [Token(Token = "0x4002202")]
    [FieldOffset(Offset = "0x5C")]
    private TacticsSceneSettings mTacticsSceneRoot;
    [Token(Token = "0x4002203")]
    [FieldOffset(Offset = "0x60")]
    private BattleSceneSettings mBattleSceneRoot;
    [Token(Token = "0x4002204")]
    [FieldOffset(Offset = "0x64")]
    private BattleSceneSettings mDefaultBattleScene;
    [Token(Token = "0x4002205")]
    [FieldOffset(Offset = "0x68")]
    private List<BattleSceneSettings> mBattleScenes;
    [Token(Token = "0x4002206")]
    [FieldOffset(Offset = "0x6C")]
    private DropGoldEffect mTreasureGoldTemplate;
    [Token(Token = "0x4002207")]
    [FieldOffset(Offset = "0x70")]
    private TreasureBox mTreasureBoxTemplate;
    [Token(Token = "0x4002208")]
    [FieldOffset(Offset = "0x74")]
    private DropItemEffect mTreasureDropTemplate;
    [Token(Token = "0x4002209")]
    [FieldOffset(Offset = "0x78")]
    private GameObject mMapAddGemEffectTemplate;
    [Token(Token = "0x400220A")]
    [FieldOffset(Offset = "0x7C")]
    private Vector3 mCameraCenter;
    [Token(Token = "0x400220B")]
    [FieldOffset(Offset = "0x88")]
    private List<TacticsUnitController> mTacticsUnits;
    [Token(Token = "0x400220C")]
    [FieldOffset(Offset = "0x8C")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x400220D")]
    [FieldOffset(Offset = "0x90")]
    private QuestStates mStartQuestState;
    [Token(Token = "0x400220E")]
    [FieldOffset(Offset = "0x91")]
    private bool mDownloadTutorialAssets;
    [Token(Token = "0x400220F")]
    [FieldOffset(Offset = "0x94")]
    private string mEventName;
    [Token(Token = "0x4002210")]
    [FieldOffset(Offset = "0x98")]
    private int mNumHotTargets;
    [Token(Token = "0x4002211")]
    [FieldOffset(Offset = "0x9C")]
    private List<TacticsUnitController> mHotTargets;
    [Token(Token = "0x4002212")]
    [FieldOffset(Offset = "0xA0")]
    private bool mIsRankingQuestNewScore;
    [Token(Token = "0x4002213")]
    [FieldOffset(Offset = "0xA1")]
    private bool mIsRankingQuestJoinReward;
    [Token(Token = "0x4002214")]
    [FieldOffset(Offset = "0xA4")]
    private int mRankingQuestNewRank;
    [Token(Token = "0x4002215")]
    [FieldOffset(Offset = "0xA8")]
    public string FirstClearItemId;
    [Token(Token = "0x4002216")]
    [FieldOffset(Offset = "0xAC")]
    public string EventPlayBgmID;
    [Token(Token = "0x4002217")]
    [FieldOffset(Offset = "0xB0")]
    private bool m_IsCardSendMail;
    [Token(Token = "0x4002218")]
    [FieldOffset(Offset = "0xB4")]
    private Json_PointQuestResult mPointQuestResult;
    [Token(Token = "0x4002219")]
    [FieldOffset(Offset = "0xB8")]
    private SceneBattle.eArenaSubmitMode mArenaSubmitMode;
    [Token(Token = "0x400221A")]
    [FieldOffset(Offset = "0xBC")]
    private int mCurrentUnitStartX;
    [Token(Token = "0x400221B")]
    [FieldOffset(Offset = "0xC0")]
    private int mCurrentUnitStartY;
    [Token(Token = "0x400221D")]
    [FieldOffset(Offset = "0xC8")]
    private bool mQuestStart;
    [Token(Token = "0x400221E")]
    [FieldOffset(Offset = "0xCC")]
    private SceneBattle.StateTransitionRequest mOnRequestStateChange;
    [Token(Token = "0x400221F")]
    [FieldOffset(Offset = "0xD0")]
    private Json_Unit mEditorSupportUnit;
    [Token(Token = "0x4002220")]
    [FieldOffset(Offset = "0xD4")]
    private bool mIsFirstPlay;
    [Token(Token = "0x4002221")]
    [FieldOffset(Offset = "0xD5")]
    private bool mIsFirstWin;
    [Token(Token = "0x4002222")]
    [FieldOffset(Offset = "0xD8")]
    private GridMap<float> mHeightMap;
    [Token(Token = "0x4002223")]
    [FieldOffset(Offset = "0xDC")]
    private float mWorldPosZ;
    [Token(Token = "0x4002224")]
    [FieldOffset(Offset = "0xE0")]
    private bool mMapReady;
    [Token(Token = "0x4002225")]
    [FieldOffset(Offset = "0xE1")]
    private bool mInterpAmbientLight;
    [Token(Token = "0x4002226")]
    public const int VALID_ENEMY_UNIT_MAX = 13;
    [Token(Token = "0x4002227")]
    [FieldOffset(Offset = "0xE2")]
    private bool mFirstTurn;
    [Token(Token = "0x4002228")]
    [FieldOffset(Offset = "0xE4")]
    private SceneBattle.CloseBattleUIWindow mCloseBattleUIWindow;
    [Token(Token = "0x4002229")]
    private const uint CHARGE_TARGET_ATTR_GRN = 1;
    [Token(Token = "0x400222A")]
    private const uint CHARGE_TARGET_ATTR_RED = 2;
    [Token(Token = "0x400222B")]
    [FieldOffset(Offset = "0xE8")]
    private bool mIsShowCastSkill;
    [Token(Token = "0x400222C")]
    [FieldOffset(Offset = "0xE9")]
    private bool mAutoActivateGimmick;
    [Token(Token = "0x400222D")]
    [FieldOffset(Offset = "0xEC")]
    [NonSerialized]
    public int GoldCount;
    [Token(Token = "0x400222E")]
    [FieldOffset(Offset = "0xF0")]
    [NonSerialized]
    public int TreasureCount;
    [Token(Token = "0x400222F")]
    [FieldOffset(Offset = "0xF4")]
    public int DispTreasureCount;
    [Token(Token = "0x4002230")]
    [FieldOffset(Offset = "0xF8")]
    [NonSerialized]
    public SceneBattle.ExitRequests ExitRequest;
    [Token(Token = "0x4002231")]
    [FieldOffset(Offset = "0xFC")]
    private FlowNode_Network mReqSubmit;
    [Token(Token = "0x4002232")]
    [FieldOffset(Offset = "0x100")]
    private bool mQuestResultSending;
    [Token(Token = "0x4002233")]
    [FieldOffset(Offset = "0x101")]
    private bool mQuestResultSent;
    [Token(Token = "0x4002234")]
    [FieldOffset(Offset = "0x104")]
    private int mFirstContact;
    [Token(Token = "0x4002235")]
    [FieldOffset(Offset = "0x108")]
    private bool mRevertQuestNewIfRetire;
    [Token(Token = "0x4002236")]
    [FieldOffset(Offset = "0x109")]
    private bool mIsForceEndQuest;
    [Token(Token = "0x4002237")]
    [FieldOffset(Offset = "0x10C")]
    private QuestResultData mSavedResult;
    [Token(Token = "0x4002238")]
    [FieldOffset(Offset = "0x110")]
    public SceneBattle.QuestEndEvent OnQuestEnd;
    [Token(Token = "0x4002239")]
    [FieldOffset(Offset = "0x114")]
    public string mDuelErrorMessage;
    [Token(Token = "0x400223A")]
    [FieldOffset(Offset = "0x118")]
    private GameObject GoResultBg;
    [Token(Token = "0x400223B")]
    [FieldOffset(Offset = "0x11C")]
    private bool mSceneExiting;
    [Token(Token = "0x400223C")]
    [FieldOffset(Offset = "0x120")]
    private int mPauseReqCount;
    [Token(Token = "0x400223D")]
    [FieldOffset(Offset = "0x124")]
    private Unit mLastPlayerSideUseSkillUnit;
    [Token(Token = "0x400223E")]
    [FieldOffset(Offset = "0x128")]
    private bool mWaitSkillSplashClose;
    [Token(Token = "0x400223F")]
    [FieldOffset(Offset = "0x12C")]
    private SkillSplash mSkillSplash;
    [Token(Token = "0x4002240")]
    [FieldOffset(Offset = "0x130")]
    private Unit mCollaboMainUnit;
    [Token(Token = "0x4002241")]
    [FieldOffset(Offset = "0x134")]
    private TacticsUnitController mCollaboTargetTuc;
    [Token(Token = "0x4002242")]
    [FieldOffset(Offset = "0x138")]
    private bool mIsInstigatorSubUnit;
    [Token(Token = "0x4002243")]
    [FieldOffset(Offset = "0x13C")]
    private SkillSplashCollabo mSkillSplashCollabo;
    [Token(Token = "0x4002244")]
    [FieldOffset(Offset = "0x140")]
    private SkillMotion mSkillMotion;
    [Token(Token = "0x4002245")]
    [FieldOffset(Offset = "0x144")]
    private bool isScreenMirroring;
    [Token(Token = "0x4002246")]
    [FieldOffset(Offset = "0x148")]
    private List<TacticsUnitController> mUnitsInBattle;
    [Token(Token = "0x4002247")]
    [FieldOffset(Offset = "0x14C")]
    private List<TacticsUnitController> mIgnoreShieldEffect;
    [Token(Token = "0x4002248")]
    [FieldOffset(Offset = "0x150")]
    private List<SceneBattle.EventRecvSkillUnit> mEventRecvSkillUnitLists;
    [Token(Token = "0x4002249")]
    [FieldOffset(Offset = "0x154")]
    private GameObject GoWeatherEffect;
    [Token(Token = "0x400224A")]
    [FieldOffset(Offset = "0x158")]
    private bool IsSetWeatherEffect;
    [Token(Token = "0x400224B")]
    [FieldOffset(Offset = "0x159")]
    private bool IsStoppedWeatherEffect;
    [Token(Token = "0x400224C")]
    private const float UPVIEW_CAMERADISTANCE_BASE = 5f;
    [Token(Token = "0x400224D")]
    [FieldOffset(Offset = "0x15C")]
    private SceneBattle.CameraMode m_CameraMode;
    [Token(Token = "0x400224E")]
    [FieldOffset(Offset = "0x160")]
    private float m_CameraYaw;
    [Token(Token = "0x400224F")]
    [FieldOffset(Offset = "0x164")]
    private bool m_NewCamera;
    [Token(Token = "0x4002250")]
    [FieldOffset(Offset = "0x165")]
    private bool m_FullRotationCamera;
    [Token(Token = "0x4002251")]
    [FieldOffset(Offset = "0x168")]
    private TargetCamera m_TargetCamera;
    [Token(Token = "0x4002252")]
    [FieldOffset(Offset = "0x16C")]
    private float m_CameraYawMin;
    [Token(Token = "0x4002253")]
    [FieldOffset(Offset = "0x170")]
    private float m_CameraYawMax;
    [Token(Token = "0x4002254")]
    [FieldOffset(Offset = "0x174")]
    private float m_DefaultCameraYawMin;
    [Token(Token = "0x4002255")]
    [FieldOffset(Offset = "0x178")]
    private float m_DefaultCameraYawMax;
    [Token(Token = "0x4002256")]
    [FieldOffset(Offset = "0x17C")]
    private bool m_UpdateCamera;
    [Token(Token = "0x4002257")]
    [FieldOffset(Offset = "0x17D")]
    private bool m_BattleCamera;
    [Token(Token = "0x4002258")]
    [FieldOffset(Offset = "0x17E")]
    private bool m_AllowCameraRotation;
    [Token(Token = "0x4002259")]
    [FieldOffset(Offset = "0x17F")]
    private bool m_AllowCameraTranslation;
    [Token(Token = "0x400225A")]
    [FieldOffset(Offset = "0x180")]
    private float m_CameraAngle;
    [Token(Token = "0x400225B")]
    [FieldOffset(Offset = "0x184")]
    private Vector3 m_CameraPosition;
    [Token(Token = "0x400225C")]
    [FieldOffset(Offset = "0x190")]
    private bool m_TargetCameraDistanceInterp;
    [Token(Token = "0x400225D")]
    [FieldOffset(Offset = "0x194")]
    private float m_TargetCameraDistance;
    [Token(Token = "0x400225E")]
    [FieldOffset(Offset = "0x198")]
    private bool m_TargetCameraPositionInterp;
    [Token(Token = "0x400225F")]
    [FieldOffset(Offset = "0x19C")]
    private Vector3 m_TargetCameraPosition;
    [Token(Token = "0x4002260")]
    [FieldOffset(Offset = "0x1A8")]
    private bool m_TargetCameraAngleInterp;
    [Token(Token = "0x4002261")]
    [FieldOffset(Offset = "0x1AC")]
    private float m_TargetCameraAngle;
    [Token(Token = "0x4002262")]
    [FieldOffset(Offset = "0x1B0")]
    private float m_TargetCameraAngleStart;
    [Token(Token = "0x4002263")]
    [FieldOffset(Offset = "0x1B4")]
    private float m_TargetCameraAngleTime;
    [Token(Token = "0x4002264")]
    [FieldOffset(Offset = "0x1B8")]
    private float m_TargetCameraAngleTimeMax;
    [Token(Token = "0x4002265")]
    [FieldOffset(Offset = "0x1BC")]
    private readonly float MULTI_PLAY_INPUT_TIME_LIMIT_SEC;
    [Token(Token = "0x4002266")]
    [FieldOffset(Offset = "0x1C0")]
    private readonly float MULTI_PLAY_INPUT_EXT_MOVE;
    [Token(Token = "0x4002267")]
    [FieldOffset(Offset = "0x1C4")]
    private readonly float MULTI_PLAY_INPUT_EXT_SELECT;
    [Token(Token = "0x4002268")]
    [FieldOffset(Offset = "0x1C8")]
    private readonly float MULTI_PLAY_INPUT_AUTO_SELECT;
    [Token(Token = "0x4002269")]
    [FieldOffset(Offset = "0x1CC")]
    private readonly float SEND_TURN_SEC;
    [Token(Token = "0x400226A")]
    [FieldOffset(Offset = "0x1D0")]
    private readonly int CPUBATTLE_PLAYER_NUM;
    [Token(Token = "0x400226B")]
    [FieldOffset(Offset = "0x1D4")]
    public readonly float SYNC_INTERVAL;
    [Token(Token = "0x400226C")]
    [FieldOffset(Offset = "0x1D8")]
    public readonly float RESUME_REQUEST_INTERVAL;
    [Token(Token = "0x400226D")]
    [FieldOffset(Offset = "0x1DC")]
    public readonly float RESUME_SUCCESS_INTERVAL;
    [Token(Token = "0x400226E")]
    [FieldOffset(Offset = "0x1E0")]
    public float mRestSyncInterval;
    [Token(Token = "0x400226F")]
    [FieldOffset(Offset = "0x1E4")]
    public float mRestResumeRequestInterval;
    [Token(Token = "0x4002270")]
    [FieldOffset(Offset = "0x1E8")]
    public float mRestResumeSuccessInterval;
    [Token(Token = "0x4002271")]
    [FieldOffset(Offset = "0x1EC")]
    private List<SceneBattle.MultiPlayInput> mSendList;
    [Token(Token = "0x4002272")]
    [FieldOffset(Offset = "0x1F0")]
    private float mSendTime;
    [Token(Token = "0x4002273")]
    [FieldOffset(Offset = "0x1F4")]
    private MultiSendLogBuffer mMultiSendLogBuffer;
    [Token(Token = "0x4002274")]
    [FieldOffset(Offset = "0x1F8")]
    private bool mBeginMultiPlay;
    [Token(Token = "0x4002275")]
    [FieldOffset(Offset = "0x1F9")]
    private bool mAudiencePause;
    [Token(Token = "0x4002276")]
    [FieldOffset(Offset = "0x1FA")]
    private bool mAudienceSkip;
    [Token(Token = "0x4002277")]
    [FieldOffset(Offset = "0x1FC")]
    private int mPrevGridX;
    [Token(Token = "0x4002278")]
    [FieldOffset(Offset = "0x200")]
    private int mPrevGridY;
    [Token(Token = "0x4002279")]
    [FieldOffset(Offset = "0x204")]
    private EUnitDirection mPrevDir;
    [Token(Token = "0x400227A")]
    [FieldOffset(Offset = "0x208")]
    private List<SceneBattle.MultiPlayRecvData> mRecvBattle;
    [Token(Token = "0x400227B")]
    [FieldOffset(Offset = "0x20C")]
    private List<SceneBattle.MultiPlayRecvData> mRecvCheck;
    [Token(Token = "0x400227C")]
    [FieldOffset(Offset = "0x210")]
    private List<SceneBattle.MultiPlayRecvData> mRecvGoodJob;
    [Token(Token = "0x400227D")]
    [FieldOffset(Offset = "0x214")]
    private List<SceneBattle.MultiPlayRecvData> mRecvContinue;
    [Token(Token = "0x400227E")]
    [FieldOffset(Offset = "0x218")]
    private List<SceneBattle.MultiPlayRecvData> mRecvIgnoreMyDisconnect;
    [Token(Token = "0x400227F")]
    [FieldOffset(Offset = "0x21C")]
    private List<SceneBattle.MultiPlayRecvData> mRecvResume;
    [Token(Token = "0x4002280")]
    [FieldOffset(Offset = "0x220")]
    private List<SceneBattle.MultiPlayRecvData> mRecvResumeRequest;
    [Token(Token = "0x4002281")]
    [FieldOffset(Offset = "0x224")]
    private List<SceneBattle.MultiPlayRecvData> mAudienceDisconnect;
    [Token(Token = "0x4002282")]
    [FieldOffset(Offset = "0x228")]
    private SceneBattle.MultiPlayRecvData mAudienceRetire;
    [Token(Token = "0x4002283")]
    [FieldOffset(Offset = "0x22C")]
    private Dictionary<int, SceneBattle.MultiPlayRecvData> mRecvCheckData;
    [Token(Token = "0x4002284")]
    [FieldOffset(Offset = "0x230")]
    private Dictionary<int, SceneBattle.MultiPlayRecvData> mRecvCheckMyData;
    [Token(Token = "0x4002285")]
    [FieldOffset(Offset = "0x234")]
    private List<SceneBattle.MultiPlayCheck> mMultiPlayCheckList;
    [Token(Token = "0x4002286")]
    [FieldOffset(Offset = "0x238")]
    private SceneBattle.EDisconnectType mDisconnectType;
    [Token(Token = "0x4002287")]
    [FieldOffset(Offset = "0x23C")]
    private List<SceneBattle.MultiPlayer> mMultiPlayer;
    [Token(Token = "0x4002288")]
    [FieldOffset(Offset = "0x240")]
    private List<SceneBattle.MultiPlayerUnit> mMultiPlayerUnit;
    [Token(Token = "0x400228D")]
    [FieldOffset(Offset = "0x250")]
    private bool mResumeMultiPlay;
    [Token(Token = "0x400228E")]
    [FieldOffset(Offset = "0x251")]
    private bool mResumeSend;
    [Token(Token = "0x400228F")]
    [FieldOffset(Offset = "0x252")]
    private bool mResumeOnlyPlayer;
    [Token(Token = "0x4002290")]
    [FieldOffset(Offset = "0x253")]
    private bool mResumeSuccess;
    [Token(Token = "0x4002291")]
    [FieldOffset(Offset = "0x254")]
    private List<int> mResumeAlreadyStartPlayer;
    [Token(Token = "0x4002292")]
    [FieldOffset(Offset = "0x258")]
    private bool mMapViewMode;
    [Token(Token = "0x4002293")]
    [FieldOffset(Offset = "0x259")]
    private bool mAlreadyEndBattle;
    [Token(Token = "0x4002294")]
    [FieldOffset(Offset = "0x25A")]
    private bool mCheater;
    [Token(Token = "0x4002295")]
    [FieldOffset(Offset = "0x25B")]
    private bool mAudienceForceEnd;
    [Token(Token = "0x4002297")]
    [FieldOffset(Offset = "0x260")]
    private int mCurrentSendInputUnitID;
    [Token(Token = "0x4002298")]
    [FieldOffset(Offset = "0x264")]
    private int mMultiPlaySendID;
    [Token(Token = "0x4002299")]
    [FieldOffset(Offset = "0x268")]
    private bool mExecDisconnected;
    [Token(Token = "0x400229A")]
    [FieldOffset(Offset = "0x269")]
    private bool mShowInputTimeLimit;
    [Token(Token = "0x400229C")]
    [FieldOffset(Offset = "0x270")]
    private int mThinkingPlayerIndex;
    [Token(Token = "0x40022A0")]
    [FieldOffset(Offset = "0x280")]
    private string mPhotonErrString;
    [Token(Token = "0x40022A1")]
    [FieldOffset(Offset = "0x284")]
    public List<SceneBattle.ReqCreateBreakObjUc> ReqCreateBreakObjUcLists;
    [Token(Token = "0x40022A2")]
    [FieldOffset(Offset = "0x288")]
    public List<SceneBattle.ReqCreateDtuUc> ReqCreateDtuUcLists;
    [Token(Token = "0x40022A3")]
    [FieldOffset(Offset = "0x28C")]
    private bool mSetupGoodJob;
    [Token(Token = "0x40022A4")]
    [FieldOffset(Offset = "0x290")]
    private float mGoodJobWait;
    [Token(Token = "0x40022A5")]
    private const int GRIDLAYER_MOVABLE = 0;
    [Token(Token = "0x40022A6")]
    private const int GRIDLAYER_SHATEI = 1;
    [Token(Token = "0x40022A7")]
    private const int GRIDLAYER_KOUKA = 2;
    [Token(Token = "0x40022A8")]
    private const int GRIDLAYER_CHARGE_GRN = 3;
    [Token(Token = "0x40022A9")]
    private const int GRIDLAYER_CHARGE_RED = 4;
    [Token(Token = "0x40022AA")]
    private const string GRIDLAYER_MATPATH_CHARGE_GRN = "BG/GridMaterialGrn";
    [Token(Token = "0x40022AB")]
    private const string GRIDLAYER_MATPATH_CHARGE_RED = "BG/GridMaterialRed";
    [Token(Token = "0x40022AC")]
    [FieldOffset(Offset = "0x294")]
    private DirectionArrow DirectionArrowTemplate;
    [Token(Token = "0x40022AD")]
    [FieldOffset(Offset = "0x298")]
    private GameObject TargetMarkerTemplate;
    [Token(Token = "0x40022AE")]
    [FieldOffset(Offset = "0x29C")]
    private SceneBattle.MoveInput mMoveInput;
    [Token(Token = "0x40022AF")]
    [FieldOffset(Offset = "0x2A0")]
    private EventScript mEventScript;
    [Token(Token = "0x40022B0")]
    [FieldOffset(Offset = "0x2A4")]
    private EventScript.Sequence mEventSequence;
    [Token(Token = "0x40022B1")]
    [FieldOffset(Offset = "0x2A8")]
    private UnitGauge GaugeOverlayTemplate;
    [Token(Token = "0x40022B2")]
    [FieldOffset(Offset = "0x2AC")]
    private UnitGauge EnemyGaugeOverlayTemplate;
    [Token(Token = "0x40022B3")]
    [FieldOffset(Offset = "0x2B0")]
    private UnitGauge EnemyBossGaugeOverlayTemplate;
    [Token(Token = "0x40022B4")]
    [FieldOffset(Offset = "0x2B4")]
    private GameObject mContinueWindowRes;
    [Token(Token = "0x40022B5")]
    [FieldOffset(Offset = "0x2B8")]
    [NonSerialized]
    private Unit mSelectedTarget;
    [Token(Token = "0x40022B6")]
    [FieldOffset(Offset = "0x2BC")]
    [NonSerialized]
    public bool UIParam_TargetValid;
    [Token(Token = "0x40022B7")]
    [FieldOffset(Offset = "0x2C0")]
    [NonSerialized]
    public AbilityData UIParam_CurrentAbility;
    [Token(Token = "0x40022B8")]
    [FieldOffset(Offset = "0x2C4")]
    private List<TacticsUnitController> mUnitList;
    [Token(Token = "0x40022B9")]
    [FieldOffset(Offset = "0x2C8")]
    private List<TacticsUnitController> mGimmickList;
    [Token(Token = "0x40022BA")]
    [FieldOffset(Offset = "0x2CC")]
    private WeatherInfo mWeatherInfo;
    [Token(Token = "0x40022BB")]
    [FieldOffset(Offset = "0x2D0")]
    private bool mIsWaitingForBattleSignal;
    [Token(Token = "0x40022BC")]
    [FieldOffset(Offset = "0x2D1")]
    private bool mIsUnitChgActive;
    [Token(Token = "0x40022BD")]
    [FieldOffset(Offset = "0x2D4")]
    private SceneBattle.TargetSelectorParam mTargetSelectorParam;
    [Token(Token = "0x40022BE")]
    [FieldOffset(Offset = "0x2F4")]
    private EUnitDirection mSkillDirectionByKouka;
    [Token(Token = "0x40022BF")]
    [FieldOffset(Offset = "0x2F8")]
    private bool mIsBackSelectSkill;
    [Token(Token = "0x40022C0")]
    [FieldOffset(Offset = "0x1C")]
    private static int MAX_MASK_BATTLE_UI;
    [Token(Token = "0x40022C1")]
    [FieldOffset(Offset = "0x2FC")]
    private uint mControlDisableMask;
    [Token(Token = "0x40022C2")]
    [FieldOffset(Offset = "0x300")]
    private TutorialButtonImage[] mTutorialButtonImages;
    [Token(Token = "0x40022C3")]
    [FieldOffset(Offset = "0x304")]
    private Quest_MoveUnit mUIMoveUnit;
    [Token(Token = "0x40022C4")]
    [FieldOffset(Offset = "0x308")]
    private GameObject mRenkeiAuraEffect;
    [Token(Token = "0x40022C5")]
    [FieldOffset(Offset = "0x30C")]
    private GameObject mRenkeiAssistEffect;
    [Token(Token = "0x40022C6")]
    [FieldOffset(Offset = "0x310")]
    private GameObject mRenkeiChargeEffect;
    [Token(Token = "0x40022C7")]
    [FieldOffset(Offset = "0x314")]
    private GameObject mRenkeiHitEffect;
    [Token(Token = "0x40022C8")]
    [FieldOffset(Offset = "0x318")]
    private GameObject mSummonUnitEffect;
    [Token(Token = "0x40022C9")]
    [FieldOffset(Offset = "0x31C")]
    private GameObject mUnitChangeEffect;
    [Token(Token = "0x40022CA")]
    [FieldOffset(Offset = "0x320")]
    private GameObject mWithdrawUnitEffect;
    [Token(Token = "0x40022CB")]
    [FieldOffset(Offset = "0x324")]
    private DamagePopup mDamageTemplate;
    [Token(Token = "0x40022CC")]
    [FieldOffset(Offset = "0x328")]
    private DamageDsgPopup mDamageDsgTemplate;
    [Token(Token = "0x40022CD")]
    [FieldOffset(Offset = "0x32C")]
    private DamagePopup mHpHealTemplate;
    [Token(Token = "0x40022CE")]
    [FieldOffset(Offset = "0x330")]
    private DamagePopup mMpHealTemplate;
    [Token(Token = "0x40022CF")]
    [FieldOffset(Offset = "0x334")]
    private GameObject mAutoHealEffectTemplate;
    [Token(Token = "0x40022D0")]
    [FieldOffset(Offset = "0x338")]
    private GameObject mDrainHpEffectTemplate;
    [Token(Token = "0x40022D1")]
    [FieldOffset(Offset = "0x33C")]
    private GameObject mDrainMpEffectTemplate;
    [Token(Token = "0x40022D2")]
    [FieldOffset(Offset = "0x340")]
    private GameObject mParamChangeEffectTemplate;
    [Token(Token = "0x40022D3")]
    [FieldOffset(Offset = "0x344")]
    private GameObject mConditionChangeEffectTemplate;
    [Token(Token = "0x40022D4")]
    [FieldOffset(Offset = "0x348")]
    private GameObject mChargeGrnTargetUnitEffect;
    [Token(Token = "0x40022D5")]
    [FieldOffset(Offset = "0x34C")]
    private GameObject mChargeRedTargetUnitEffect;
    [Token(Token = "0x40022D6")]
    [FieldOffset(Offset = "0x350")]
    private GameObject mKnockBackEffect;
    [Token(Token = "0x40022D7")]
    [FieldOffset(Offset = "0x354")]
    private GameObject mTrickMarker;
    [Token(Token = "0x40022D8")]
    [FieldOffset(Offset = "0x358")]
    private Dictionary<string, GameObject> mTrickMarkerDics;
    [Token(Token = "0x40022D9")]
    [FieldOffset(Offset = "0x35C")]
    private GameObject mJumpFallEffect;
    [Token(Token = "0x40022DA")]
    [FieldOffset(Offset = "0x360")]
    private GameObject mInspirationEffect;
    [Token(Token = "0x40022DB")]
    [FieldOffset(Offset = "0x364")]
    private GameObject mProtectTargetEffect;
    [Token(Token = "0x40022DC")]
    [FieldOffset(Offset = "0x368")]
    private GameObject mProtectSelfEffect;
    [Token(Token = "0x40022DD")]
    [FieldOffset(Offset = "0x36C")]
    private GameObject mCondBombEffect;
    [Token(Token = "0x40022DE")]
    [FieldOffset(Offset = "0x370")]
    private GameObject mCondSlipEffect;
    [Token(Token = "0x40022DF")]
    [FieldOffset(Offset = "0x374")]
    private GameObject mCondDownEffect;
    [Token(Token = "0x40022E0")]
    [FieldOffset(Offset = "0x378")]
    private GameObject mManipulateReflectionEffect;
    [Token(Token = "0x40022E1")]
    [FieldOffset(Offset = "0x37C")]
    private GameObject mManipulateAbsorptionEffect;
    [Token(Token = "0x40022E2")]
    [FieldOffset(Offset = "0x380")]
    private GameObject mManipulateBreakEffect;
    [Token(Token = "0x40022E3")]
    [FieldOffset(Offset = "0x384")]
    private GameObject mManipulateDamageEffect;
    [Token(Token = "0x40022E4")]
    [FieldOffset(Offset = "0x388")]
    private GameObject mManipulatePierceBreakAll;
    [Token(Token = "0x40022E5")]
    [FieldOffset(Offset = "0x38C")]
    private GameObject mManipulatePierceBreakRef;
    [Token(Token = "0x40022E6")]
    [FieldOffset(Offset = "0x390")]
    private GameObject mManipulatePierceBreakAbs;
    [Token(Token = "0x40022E7")]
    [FieldOffset(Offset = "0x394")]
    private GameObject mManipulatePierceBreakDir;
    [Token(Token = "0x40022E8")]
    [FieldOffset(Offset = "0x398")]
    private SkillNamePlate mSkillNamePlate;
    [Token(Token = "0x40022E9")]
    [FieldOffset(Offset = "0x39C")]
    private SkillNamePlate mInspirationTelopPlate;
    [Token(Token = "0x40022EA")]
    [FieldOffset(Offset = "0x3A0")]
    private SkillTargetWindow mSkillTargetWindow;
    [Token(Token = "0x40022EB")]
    [FieldOffset(Offset = "0x3A4")]
    private GameObject mJumpSpotEffectTemplate;
    [Token(Token = "0x40022EC")]
    [FieldOffset(Offset = "0x3A8")]
    private GameObject mGuardPopup;
    [Token(Token = "0x40022ED")]
    [FieldOffset(Offset = "0x3AC")]
    private GameObject mAbsorbPopup;
    [Token(Token = "0x40022EE")]
    [FieldOffset(Offset = "0x3B0")]
    private GameObject mCriticalPopup;
    [Token(Token = "0x40022EF")]
    [FieldOffset(Offset = "0x3B4")]
    private GameObject mBackstabPopup;
    [Token(Token = "0x40022F0")]
    [FieldOffset(Offset = "0x3B8")]
    private GameObject mMissPopup;
    [Token(Token = "0x40022F1")]
    [FieldOffset(Offset = "0x3BC")]
    private GameObject mPerfectAvoidPopup;
    [Token(Token = "0x40022F2")]
    [FieldOffset(Offset = "0x3C0")]
    private GameObject mWeakPopup;
    [Token(Token = "0x40022F3")]
    [FieldOffset(Offset = "0x3C4")]
    private GameObject mResistPopup;
    [Token(Token = "0x40022F4")]
    [FieldOffset(Offset = "0x3C8")]
    private GameObject mGutsPopup;
    [Token(Token = "0x40022F5")]
    [FieldOffset(Offset = "0x3CC")]
    private GameObject mUnitOwnerIndex;
    [Token(Token = "0x40022F6")]
    [FieldOffset(Offset = "0x3D0")]
    private GemParticle[] mGemDrainEffect_Front;
    [Token(Token = "0x40022F7")]
    [FieldOffset(Offset = "0x3D4")]
    private GemParticle[] mGemDrainEffect_Side;
    [Token(Token = "0x40022F8")]
    [FieldOffset(Offset = "0x3D8")]
    private GemParticle[] mGemDrainEffect_Back;
    [Token(Token = "0x40022F9")]
    [FieldOffset(Offset = "0x3DC")]
    private GameObject mGemDrainHitEffect;
    [Token(Token = "0x40022FA")]
    [FieldOffset(Offset = "0x3E0")]
    private List<KeyValuePair<Unit, GameObject>> mJumpSpotEffects;
    [Token(Token = "0x40022FB")]
    [FieldOffset(Offset = "0x3E4")]
    private GameObject mTargetMarkerTemplate;
    [Token(Token = "0x40022FC")]
    [FieldOffset(Offset = "0x3E8")]
    private GameObject mAssistMarkerTemplate;
    [Token(Token = "0x40022FD")]
    [FieldOffset(Offset = "0x3EC")]
    private GameObject mBlockedGridMarker;
    [Token(Token = "0x40022FE")]
    [FieldOffset(Offset = "0x3F0")]
    private bool mDisplayBlockedGridMarker;
    [Token(Token = "0x40022FF")]
    [FieldOffset(Offset = "0x3F4")]
    private Grid mGridDisplayBlockedGridMarker;
    [Token(Token = "0x4002300")]
    [FieldOffset(Offset = "0x3F8")]
    private GameObject[] mUnitMarkerTemplates;
    [Token(Token = "0x4002301")]
    [FieldOffset(Offset = "0x3FC")]
    private List<GameObject>[] mUnitMarkers;
    [Token(Token = "0x4002302")]
    [FieldOffset(Offset = "0x400")]
    private bool mLoadedAllUI;
    [Token(Token = "0x4002303")]
    [FieldOffset(Offset = "0x404")]
    private TouchController mTouchController;
    [Token(Token = "0x4002304")]
    [FieldOffset(Offset = "0x408")]
    private GameObject mVersusPlayerTarget;
    [Token(Token = "0x4002305")]
    [FieldOffset(Offset = "0x40C")]
    private GameObject mVersusEnemyTarget;
    [Token(Token = "0x4002306")]
    [FieldOffset(Offset = "0x410")]
    private GameObject mGoWeatherAttach;
    [Token(Token = "0x4002307")]
    [FieldOffset(Offset = "0x414")]
    private SceneBattle.GridClickEvent mOnGridClick;
    [Token(Token = "0x4002308")]
    [FieldOffset(Offset = "0x418")]
    private SceneBattle.UnitClickEvent mOnUnitClick;
    [Token(Token = "0x4002309")]
    [FieldOffset(Offset = "0x41C")]
    private SceneBattle.UnitFocusEvent mOnUnitFocus;
    [Token(Token = "0x400230A")]
    [FieldOffset(Offset = "0x420")]
    private TacticsUnitController mFocusedUnit;
    [Token(Token = "0x400230B")]
    [FieldOffset(Offset = "0x424")]
    private TacticsUnitController mMapModeFocusedUnit;
    [Token(Token = "0x400230C")]
    [FieldOffset(Offset = "0x428")]
    private SceneBattle.ScreenClickEvent mOnScreenClick;
    [Token(Token = "0x400230D")]
    [FieldOffset(Offset = "0x42C")]
    private float mLoadProgress_UI;
    [Token(Token = "0x400230E")]
    [FieldOffset(Offset = "0x430")]
    private float mLoadProgress_Scene;
    [Token(Token = "0x400230F")]
    [FieldOffset(Offset = "0x434")]
    private float mLoadProgress_Animation;
    [Token(Token = "0x4002310")]
    [FieldOffset(Offset = "0x438")]
    private SceneBattle.FocusTargetEvent mOnFocusTarget;
    [Token(Token = "0x4002311")]
    [FieldOffset(Offset = "0x43C")]
    private SceneBattle.SelectTargetEvent mOnSelectTarget;
    [Token(Token = "0x4002312")]
    [FieldOffset(Offset = "0x440")]
    private SceneBattle.CancelTargetSelectEvent mOnCancelTargetSelect;
    [Token(Token = "0x4002313")]
    [FieldOffset(Offset = "0x444")]
    private List<KeyValuePair<SceneBattle.PupupData, GameObject>> mPopups;
    [Token(Token = "0x4002314")]
    [FieldOffset(Offset = "0x448")]
    private Dictionary<RectTransform, Vector3> mPopupPositionCache;
    [Token(Token = "0x4002315")]
    [FieldOffset(Offset = "0x44C")]
    private List<RectTransform> mLayoutGauges;
    [Token(Token = "0x4002316")]
    [FieldOffset(Offset = "0x450")]
    private Dictionary<RectTransform, Vector2> mGaugePositionCache;
    [Token(Token = "0x4002317")]
    [FieldOffset(Offset = "0x454")]
    private float mGaugeCollisionRadius;
    [Token(Token = "0x4002318")]
    [FieldOffset(Offset = "0x458")]
    private float mGaugeYAspectRatio;
    [Token(Token = "0x4002319")]
    [FieldOffset(Offset = "0x45C")]
    private Dictionary<SkillParam, GameObject> mShieldEffects;
    [Token(Token = "0x400231A")]
    [FieldOffset(Offset = "0x460")]
    private bool mLoadingShieldEffects;

    [Token(Token = "0x170002F6")]
    public int UnitStartCount
    {
      [Token(Token = "0x600313A"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002F7")]
    public int UnitStartCountTotal
    {
      [Token(Token = "0x600313B"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002F8")]
    public FlowNode_BattleUI BattleUI
    {
      [Token(Token = "0x600313C"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (FlowNode_BattleUI) null;
      }
    }

    [Token(Token = "0x170002F9")]
    public GameObject CurrentScene
    {
      [Token(Token = "0x600313D"), Address(RVA = "0x101BD80", Offset = "0x101AB80", VA = "0x1101BD80")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170002FA")]
    public QuestParam CurrentQuest
    {
      [Token(Token = "0x600313E"), Address(RVA = "0x2B5F90", Offset = "0x2B4D90", VA = "0x102B5F90")] get
      {
        return (QuestParam) null;
      }
    }

    [Token(Token = "0x170002FB")]
    public bool IsRankingQuestNewScore
    {
      [Token(Token = "0x600313F"), Address(RVA = "0x36A8E0", Offset = "0x3696E0", VA = "0x1036A8E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170002FC")]
    public bool IsRankingQuestJoinReward
    {
      [Token(Token = "0x6003140"), Address(RVA = "0x36A950", Offset = "0x369750", VA = "0x1036A950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170002FD")]
    public int RankingQuestNewRank
    {
      [Token(Token = "0x6003141"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002FE")]
    public bool ValidateRankingQuestRank
    {
      [Token(Token = "0x6003142"), Address(RVA = "0x101C8E0", Offset = "0x101B6E0", VA = "0x1101C8E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170002FF")]
    public bool IsOrdealQuest
    {
      [Token(Token = "0x6003143"), Address(RVA = "0x101C280", Offset = "0x101B080", VA = "0x1101C280")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000300")]
    public bool IsGetFirstClearItem
    {
      [Token(Token = "0x6003144"), Address(RVA = "0x101C1D0", Offset = "0x101AFD0", VA = "0x1101C1D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000301")]
    public bool IsCardSendMail
    {
      [Token(Token = "0x6003145"), Address(RVA = "0x101C130", Offset = "0x101AF30", VA = "0x1101C130")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000302")]
    public Json_PointQuestResult PointQuestResult
    {
      [Token(Token = "0x6003146"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return (Json_PointQuestResult) null;
      }
    }

    [Token(Token = "0x17000303")]
    public bool IsEnableBattleSpeed
    {
      [Token(Token = "0x6003147"), Address(RVA = "0x101C140", Offset = "0x101AF40", VA = "0x1101C140")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000304")]
    public BattleCore Battle
    {
      [Token(Token = "0x6003148"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (BattleCore) null;
      }
    }

    [Token(Token = "0x17000305")]
    public List<PhotonPlayerData> AudiencePlayers
    {
      [Token(Token = "0x6003149"), Address(RVA = "0x5FBFF0", Offset = "0x5FADF0", VA = "0x105FBFF0")] get
      {
        return (List<PhotonPlayerData>) null;
      }
      [Token(Token = "0x600314A"), Address(RVA = "0x5FC070", Offset = "0x5FAE70", VA = "0x105FC070")] private set
      {
      }
    }

    [Token(Token = "0x17000306")]
    public bool QuestStart
    {
      [Token(Token = "0x600314B"), Address(RVA = "0x101C810", Offset = "0x101B610", VA = "0x1101C810")] get
      {
        return new bool();
      }
      [Token(Token = "0x600314C"), Address(RVA = "0x101CC20", Offset = "0x101BA20", VA = "0x1101CC20")] set
      {
      }
    }

    [Token(Token = "0x600314D")]
    [Address(RVA = "0x1017620", Offset = "0x1016420", VA = "0x11017620")]
    private void ToggleBattleScene(bool visible, string sceneName = null)
    {
    }

    [Token(Token = "0x600314E")]
    [Address(RVA = "0x1017AB0", Offset = "0x10168B0", VA = "0x11017AB0")]
    private void ToggleUserInterface(bool isEnabled)
    {
    }

    [Token(Token = "0x600314F")]
    [Address(RVA = "0xFF8C20", Offset = "0xFF7A20", VA = "0x10FF8C20")]
    public void EnableUserInterface()
    {
    }

    [Token(Token = "0x6003150")]
    [Address(RVA = "0xFF85D0", Offset = "0xFF73D0", VA = "0x10FF85D0")]
    public void DisableUserInterface()
    {
    }

    [Token(Token = "0x6003151")]
    [Address(RVA = "0x1011040", Offset = "0x100FE40", VA = "0x11011040")]
    private void Start()
    {
    }

    [Token(Token = "0x17000307")]
    public bool IsPlayingArenaQuest
    {
      [Token(Token = "0x6003152"), Address(RVA = "0x101C3B0", Offset = "0x101B1B0", VA = "0x1101C3B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000308")]
    public bool IsPlayingDuelQuest
    {
      [Token(Token = "0x6003153"), Address(RVA = "0x101C450", Offset = "0x101B250", VA = "0x1101C450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000309")]
    public bool IsPlayingArenaOrDuelQuest
    {
      [Token(Token = "0x6003154"), Address(RVA = "0x101C300", Offset = "0x101B100", VA = "0x1101C300")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700030A")]
    public bool IsPlayingGvGQuest
    {
      [Token(Token = "0x6003155"), Address(RVA = "0x101C4F0", Offset = "0x101B2F0", VA = "0x1101C4F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700030B")]
    public bool IsPlayingPreCalcResultQuest
    {
      [Token(Token = "0x6003156"), Address(RVA = "0x101C560", Offset = "0x101B360", VA = "0x1101C560")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003157")]
    [Address(RVA = "0xFFF9F0", Offset = "0xFFE7F0", VA = "0x10FFF9F0")]
    public bool IsArenaRankupInfo() => new bool();

    [Token(Token = "0x6003158")]
    [Address(RVA = "0xFECBC0", Offset = "0xFEB9C0", VA = "0x10FECBC0")]
    public int CalcArenaRankDelta() => new int();

    [Token(Token = "0x1700030C")]
    public bool IsPlayingMultiQuest
    {
      [Token(Token = "0x6003159"), Address(RVA = "0x101C530", Offset = "0x101B330", VA = "0x1101C530")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700030D")]
    public bool IsPlayingTower
    {
      [Token(Token = "0x600315A"), Address(RVA = "0x101C5A0", Offset = "0x101B3A0", VA = "0x1101C5A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700030E")]
    public bool IsPlayingLeagueMatch
    {
      [Token(Token = "0x600315B"), Address(RVA = "0x101C510", Offset = "0x101B310", VA = "0x1101C510")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600315C")]
    [Address(RVA = "0x1002E50", Offset = "0x1001C50", VA = "0x11002E50")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600315D")]
    [Address(RVA = "0x1002AD0", Offset = "0x10018D0", VA = "0x11002AD0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600315E")]
    [Address(RVA = "0x1002880", Offset = "0x1001680", VA = "0x11002880")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600315F")]
    [Address(RVA = "0x1003580", Offset = "0x1002380", VA = "0x11003580")]
    private void OnLoadTacticsScene(GameObject root)
    {
    }

    [Token(Token = "0x6003160")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void UpdateUnitHP(TacticsUnitController controller)
    {
    }

    [Token(Token = "0x6003161")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void UpdateUnitMP(TacticsUnitController controller)
    {
    }

    [Token(Token = "0x6003162")]
    [Address(RVA = "0xFF9AA0", Offset = "0xFF88A0", VA = "0x10FF9AA0")]
    private void FocusUnit(Unit unit)
    {
    }

    [Token(Token = "0x6003163")]
    [Address(RVA = "0xFFBE10", Offset = "0xFFAC10", VA = "0x10FFBE10")]
    public void GotoNextState()
    {
    }

    [Token(Token = "0x6003164")]
    [Address(RVA = "0xFFCAE0", Offset = "0xFFB8E0", VA = "0x10FFCAE0")]
    public void GotoPreviousState()
    {
    }

    [Token(Token = "0x6003165")]
    [Address(RVA = "0x10065C0", Offset = "0x10053C0", VA = "0x110065C0")]
    public static Vector3 RaycastGround(Vector3 start) => new Vector3();

    [Token(Token = "0x6003166")]
    [Address(RVA = "0xFF9240", Offset = "0xFF8040", VA = "0x10FF9240")]
    private TacticsUnitController FindClosestUnitController(Vector3 position, float maxDistance)
    {
      return (TacticsUnitController) null;
    }

    [Token(Token = "0x6003167")]
    [Address(RVA = "0xFFA960", Offset = "0xFF9760", VA = "0x10FFA960")]
    public int GetDisplayHeight(Unit unit) => new int();

    [Token(Token = "0x6003168")]
    [Address(RVA = "0xFECE90", Offset = "0xFEBC90", VA = "0x10FECE90")]
    public IntVector2 CalcCoord(Vector3 position) => new IntVector2();

    [Token(Token = "0x6003169")]
    [Address(RVA = "0xFED020", Offset = "0xFEBE20", VA = "0x10FED020")]
    public Vector3 CalcGridCenter(Grid grid) => new Vector3();

    [Token(Token = "0x600316A")]
    [Address(RVA = "0xFECFC0", Offset = "0xFEBDC0", VA = "0x10FECFC0")]
    public Vector3 CalcGridCenter(int x, int y) => new Vector3();

    [Token(Token = "0x600316B")]
    [Address(RVA = "0x1018180", Offset = "0x1016F80", VA = "0x11018180")]
    public EUnitDirection UnitDirectionFromPosition(
      Vector3 self,
      Vector3 target,
      SkillParam skill_param)
    {
      return new EUnitDirection();
    }

    [Token(Token = "0x600316C")]
    [Address(RVA = "0x1009CF0", Offset = "0x1008AF0", VA = "0x11009CF0")]
    public void RemoveLog()
    {
    }

    [Token(Token = "0x600316D")]
    [Address(RVA = "0x101B000", Offset = "0x1019E00", VA = "0x1101B000")]
    private void Update()
    {
    }

    [Token(Token = "0x600316E")]
    [Address(RVA = "0x1010EC0", Offset = "0x100FCC0", VA = "0x11010EC0")]
    private void StartDownloadNextQuestAsync()
    {
    }

    [Token(Token = "0x600316F")]
    [Address(RVA = "0xFF8870", Offset = "0xFF7670", VA = "0x10FF8870")]
    private IEnumerator DownloadNextQuestAsync() => (IEnumerator) null;

    [Token(Token = "0x6003170")]
    public void GotoState<StateType>() where StateType : State<SceneBattle>, new()
    {
    }

    [Token(Token = "0x6003171")]
    public bool IsInState<StateType>() where StateType : State<SceneBattle> => new bool();

    [Token(Token = "0x6003172")]
    [Address(RVA = "0xFF88D0", Offset = "0xFF76D0", VA = "0x10FF88D0")]
    private IEnumerator DownloadQuestAsync(QuestParam quest) => (IEnumerator) null;

    [Token(Token = "0x6003173")]
    [Address(RVA = "0x1010FB0", Offset = "0x100FDB0", VA = "0x11010FB0")]
    public void StartQuest(string questID, BattleCore.Json_Battle json)
    {
    }

    [Token(Token = "0x1700030F")]
    public bool IsFirstPlay
    {
      [Token(Token = "0x6003174"), Address(RVA = "0x101C1B0", Offset = "0x101AFB0", VA = "0x1101C1B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000310")]
    public bool IsFirstWin
    {
      [Token(Token = "0x6003175"), Address(RVA = "0x101C1C0", Offset = "0x101AFC0", VA = "0x1101C1C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000311")]
    public bool IsPlayLastDemo
    {
      [Token(Token = "0x6003176"), Address(RVA = "0x101C2A0", Offset = "0x101B0A0", VA = "0x1101C2A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003177")]
    [Address(RVA = "0x1010F30", Offset = "0x100FD30", VA = "0x11010F30")]
    private IEnumerator StartQuestAsync(string questID, BattleCore.Json_Battle jsonBtl)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003178")]
    [Address(RVA = "0x1001C60", Offset = "0x1000A60", VA = "0x11001C60")]
    private void OnApplicationPause(bool pause)
    {
    }

    [Token(Token = "0x6003179")]
    [Address(RVA = "0x1004D40", Offset = "0x1003B40", VA = "0x11004D40")]
    public void PlayBGM()
    {
    }

    [Token(Token = "0x600317A")]
    [Address(RVA = "0x10115D0", Offset = "0x10103D0", VA = "0x110115D0")]
    public void StopBGM()
    {
    }

    [Token(Token = "0x600317B")]
    [Address(RVA = "0x10184B0", Offset = "0x10172B0", VA = "0x110184B0")]
    private void UpdateBGM()
    {
    }

    [Token(Token = "0x600317C")]
    [Address(RVA = "0xFFCB10", Offset = "0xFFB910", VA = "0x10FFCB10")]
    private void GotoQuestStart()
    {
    }

    [Token(Token = "0x600317D")]
    [Address(RVA = "0xFED0F0", Offset = "0xFEBEF0", VA = "0x10FED0F0")]
    private void CalcGridHeights()
    {
    }

    [Token(Token = "0x600317E")]
    [Address(RVA = "0xFEC4D0", Offset = "0xFEB2D0", VA = "0x10FEC4D0")]
    private void BeginLoadMapAsync()
    {
    }

    [Token(Token = "0x600317F")]
    [Address(RVA = "0x1001220", Offset = "0x1000020", VA = "0x11001220")]
    private IEnumerator LoadMapAsync() => (IEnumerator) null;

    [Token(Token = "0x17000312")]
    private bool IsUnitLoading
    {
      [Token(Token = "0x6003180"), Address(RVA = "0x101C660", Offset = "0x101B460", VA = "0x1101C660")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003181")]
    [Address(RVA = "0x100A3A0", Offset = "0x10091A0", VA = "0x1100A3A0")]
    private void ResetUnitPosition(TacticsUnitController controller)
    {
    }

    [Token(Token = "0x6003182")]
    [Address(RVA = "0xFFB700", Offset = "0xFFA500", VA = "0x10FFB700")]
    private void GotoMapStart()
    {
    }

    [Token(Token = "0x6003183")]
    [Address(RVA = "0x1006340", Offset = "0x1005140", VA = "0x11006340")]
    private Unit RayPickUnit(Vector2 pos) => (Unit) null;

    [Token(Token = "0x6003184")]
    [Address(RVA = "0x100F4E0", Offset = "0x100E2E0", VA = "0x1100F4E0")]
    private void ShowUnitCursor(Unit unit)
    {
    }

    [Token(Token = "0x6003185")]
    [Address(RVA = "0x100F600", Offset = "0x100E400", VA = "0x1100F600")]
    private void ShowUnitCursor(Unit unit, Color color)
    {
    }

    [Token(Token = "0x6003186")]
    [Address(RVA = "0xFFD870", Offset = "0xFFC670", VA = "0x10FFD870")]
    private void HideUnitCursor(Unit unit)
    {
    }

    [Token(Token = "0x6003187")]
    [Address(RVA = "0xFFD6F0", Offset = "0xFFC4F0", VA = "0x10FFD6F0")]
    public void HideUnitCursor(TacticsUnitController controller)
    {
    }

    [Token(Token = "0x6003188")]
    [Address(RVA = "0xFEF530", Offset = "0xFEE330", VA = "0x10FEF530")]
    private void CloseBattleUI()
    {
    }

    [Token(Token = "0x6003189")]
    [Address(RVA = "0xFFDF60", Offset = "0xFFCD60", VA = "0x10FFDF60")]
    private void HighlightTargetGrid(Unit current, int range, int difffloor)
    {
    }

    [Token(Token = "0x600318A")]
    [Address(RVA = "0xFFEB30", Offset = "0xFFD930", VA = "0x10FFEB30")]
    private void InternalShowCastSkill()
    {
    }

    [Token(Token = "0x600318B")]
    [Address(RVA = "0xFFE870", Offset = "0xFFD670", VA = "0x10FFE870")]
    private void InternalHideCastSkill(bool is_only_target_unit = false)
    {
    }

    [Token(Token = "0x600318C")]
    [Address(RVA = "0x100E9C0", Offset = "0x100D7C0", VA = "0x1100E9C0")]
    private void ShowCastSkill()
    {
    }

    [Token(Token = "0x600318D")]
    [Address(RVA = "0xFFD5A0", Offset = "0xFFC3A0", VA = "0x10FFD5A0")]
    private void HideCastSkill(bool is_only_target_unit = false)
    {
    }

    [Token(Token = "0x600318E")]
    [Address(RVA = "0x1008D60", Offset = "0x1007B60", VA = "0x11008D60")]
    public void ReflectCastSkill(bool is_disp)
    {
    }

    [Token(Token = "0x600318F")]
    [Address(RVA = "0xFFAF80", Offset = "0xFF9D80", VA = "0x10FFAF80")]
    private void GotoInputMovement()
    {
    }

    [Token(Token = "0x6003190")]
    [Address(RVA = "0xFF9640", Offset = "0xFF8440", VA = "0x10FF9640")]
    private Unit FindTarget(
      Unit current,
      SkillData skill,
      GridMap<bool> map,
      EUnitSide targetSide,
      bool is_not_self = false)
    {
      return (Unit) null;
    }

    [Token(Token = "0x6003191")]
    [Address(RVA = "0xFFCB50", Offset = "0xFFB950", VA = "0x10FFCB50")]
    private void GotoSelectAttackTarget()
    {
    }

    [Token(Token = "0x6003192")]
    [Address(RVA = "0xFEC140", Offset = "0xFEAF40", VA = "0x10FEC140")]
    private bool ApplyUnitMovement(bool test = false) => new bool();

    [Token(Token = "0x6003193")]
    [Address(RVA = "0x1003880", Offset = "0x1002680", VA = "0x11003880")]
    private void OnSelectAttackTarget(int x, int y, SkillData skill, bool bUnitLockTarget)
    {
    }

    [Token(Token = "0x6003194")]
    [Address(RVA = "0xFF0E80", Offset = "0xFEFC80", VA = "0x10FF0E80")]
    private int CountAccessibleGrids(GridMap<int> grids) => new int();

    [Token(Token = "0x6003195")]
    [Address(RVA = "0x100A2C0", Offset = "0x10090C0", VA = "0x1100A2C0")]
    private void ResetUnitPosition()
    {
    }

    [Token(Token = "0x6003196")]
    [Address(RVA = "0xFF9490", Offset = "0xFF8290", VA = "0x10FF9490")]
    private Vector3[] FindPath(
      Unit unit,
      int startX,
      int startY,
      int goalX,
      int goalY,
      int disableHeight,
      GridMap<int> walkableField)
    {
      return (Vector3[]) null;
    }

    [Token(Token = "0x6003197")]
    [Address(RVA = "0xFFD620", Offset = "0xFFC420", VA = "0x10FFD620")]
    private void HideGrid()
    {
    }

    [Token(Token = "0x6003198")]
    [Address(RVA = "0xFEC0E0", Offset = "0xFEAEE0", VA = "0x10FEC0E0")]
    private Vector3 AdjustPositionToCurrentScene(Vector3 pos) => new Vector3();

    [Token(Token = "0x6003199")]
    [Address(RVA = "0x100F390", Offset = "0x100E190", VA = "0x1100F390")]
    private void ShowUnitCursorOnCurrent()
    {
    }

    [Token(Token = "0x600319A")]
    [Address(RVA = "0xFF1840", Offset = "0xFF0640", VA = "0x10FF1840")]
    private GridMap<int> CreateCurrentAccessMap() => (GridMap<int>) null;

    [Token(Token = "0x600319B")]
    [Address(RVA = "0x100FC40", Offset = "0x100EA40", VA = "0x1100FC40")]
    private void ShowWalkableGrids(GridMap<int> accessMap, int layerIndex)
    {
    }

    [Token(Token = "0x600319C")]
    [Address(RVA = "0x1003F40", Offset = "0x1002D40", VA = "0x11003F40")]
    private void OnUnitDeath(Unit unit)
    {
    }

    [Token(Token = "0x600319D")]
    [Address(RVA = "0xFEF9F0", Offset = "0xFEE7F0", VA = "0x10FEF9F0")]
    private bool ConditionalGotoGimmickState() => new bool();

    [Token(Token = "0x600319E")]
    [Address(RVA = "0xFF9A40", Offset = "0xFF8840", VA = "0x10FF9A40")]
    private void FinishGimmickState()
    {
    }

    [Token(Token = "0x600319F")]
    [Address(RVA = "0xFEBE30", Offset = "0xFEAC30", VA = "0x10FEBE30")]
    private void AddGoldCount(int num)
    {
    }

    [Token(Token = "0x60031A0")]
    [Address(RVA = "0xFEC0C0", Offset = "0xFEAEC0", VA = "0x10FEC0C0")]
    private void AddTreasureCount(int num)
    {
    }

    [Token(Token = "0x60031A1")]
    [Address(RVA = "0xFEBE10", Offset = "0xFEAC10", VA = "0x10FEBE10")]
    private void AddDispTreasureCount(int num)
    {
    }

    [Token(Token = "0x60031A2")]
    [Address(RVA = "0x100A420", Offset = "0x1009220", VA = "0x1100A420")]
    public void RestoreTreasureCount(int num)
    {
    }

    [Token(Token = "0x60031A3")]
    [Address(RVA = "0xFFA4E0", Offset = "0xFF92E0", VA = "0x10FFA4E0")]
    public TacticsUnitController[] GetActiveUnits() => (TacticsUnitController[]) null;

    [Token(Token = "0x60031A4")]
    [Address(RVA = "0xFF9990", Offset = "0xFF8790", VA = "0x10FF9990")]
    public TacticsUnitController FindUnitController(Unit unit) => (TacticsUnitController) null;

    [Token(Token = "0x60031A5")]
    [Address(RVA = "0xFFB090", Offset = "0xFF9E90", VA = "0x10FFB090")]
    private void GotoMapCommand()
    {
    }

    [Token(Token = "0x60031A6")]
    [Address(RVA = "0xFFB5C0", Offset = "0xFFA3C0", VA = "0x10FFB5C0")]
    private void GotoMapEnd()
    {
    }

    [Token(Token = "0x60031A7")]
    [Address(RVA = "0x1017E50", Offset = "0x1016C50", VA = "0x11017E50")]
    private void TriggerWinEvent()
    {
    }

    [Token(Token = "0x17000313")]
    public int FirstContact
    {
      [Token(Token = "0x60031A8"), Address(RVA = "0x33B040", Offset = "0x339E40", VA = "0x1033B040")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60031A9")]
    [Address(RVA = "0x1016E80", Offset = "0x1015C80", VA = "0x11016E80")]
    public void SubmitResult()
    {
    }

    [Token(Token = "0x60031AA")]
    [Address(RVA = "0x10027D0", Offset = "0x10015D0", VA = "0x110027D0")]
    public void OnColoRankModify()
    {
    }

    [Token(Token = "0x60031AB")]
    [Address(RVA = "0x10149D0", Offset = "0x10137D0", VA = "0x110149D0")]
    private void SubmitResultCallbackImpl(WWWResult www, bool isArenaType = false)
    {
    }

    [Token(Token = "0x60031AC")]
    [Address(RVA = "0x1014100", Offset = "0x1012F00", VA = "0x11014100")]
    private void SubmitGvGResultCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60031AD")]
    [Address(RVA = "0x1013B70", Offset = "0x1012970", VA = "0x11013B70")]
    private void SubmitDuelResultCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60031AE")]
    [Address(RVA = "0x1014520", Offset = "0x1013320", VA = "0x11014520")]
    private void SubmitLeagueMatchResultCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60031AF")]
    [Address(RVA = "0x1016E50", Offset = "0x1015C50", VA = "0x11016E50")]
    private void SubmitResultCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60031B0")]
    [Address(RVA = "0x1011690", Offset = "0x1010490", VA = "0x11011690")]
    private void SubmitArenaResultCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60031B1")]
    [Address(RVA = "0x10116C0", Offset = "0x10104C0", VA = "0x110116C0")]
    private void SubmitBattleResult(long btlid, QuestParam quest)
    {
    }

    [Token(Token = "0x60031B2")]
    [Address(RVA = "0x10170D0", Offset = "0x1015ED0", VA = "0x110170D0")]
    private void SubmitScenarioResult(long btlid)
    {
    }

    [Token(Token = "0x60031B3")]
    [Address(RVA = "0xFFA030", Offset = "0xFF8E30", VA = "0x10FFA030")]
    public void ForceEndQuest()
    {
    }

    [Token(Token = "0x60031B4")]
    [Address(RVA = "0x101ACB0", Offset = "0x1019AB0", VA = "0x1101ACB0")]
    private void UpdateTrophy()
    {
    }

    [Token(Token = "0x60031B5")]
    [Address(RVA = "0x1017F70", Offset = "0x1016D70", VA = "0x11017F70")]
    private void TrophyLvupCheck()
    {
    }

    [Token(Token = "0x60031B6")]
    [Address(RVA = "0xFF9C50", Offset = "0xFF8A50", VA = "0x10FF9C50")]
    public void ForceEndQuestInArenaSkip()
    {
    }

    [Token(Token = "0x60031B7")]
    [Address(RVA = "0xFF9CF0", Offset = "0xFF8AF0", VA = "0x10FF9CF0")]
    public void ForceEndQuestInArena()
    {
    }

    [Token(Token = "0x60031B8")]
    [Address(RVA = "0xFF9DB0", Offset = "0xFF8BB0", VA = "0x10FF9DB0")]
    public bool ForceEndQuestInGvG() => new bool();

    [Token(Token = "0x60031B9")]
    [Address(RVA = "0xFF9E70", Offset = "0xFF8C70", VA = "0x10FF9E70")]
    public bool ForceEndQuestInLeagueMatch() => new bool();

    [Token(Token = "0x60031BA")]
    [Address(RVA = "0x100AAA0", Offset = "0x10098A0", VA = "0x1100AAA0")]
    private void SendActionLog()
    {
    }

    [Token(Token = "0x17000314")]
    public QuestResultData ResultData
    {
      [Token(Token = "0x60031BB"), Address(RVA = "0x628750", Offset = "0x627550", VA = "0x10628750")] get
      {
        return (QuestResultData) null;
      }
    }

    [Token(Token = "0x60031BC")]
    [Address(RVA = "0x100A800", Offset = "0x1009600", VA = "0x1100A800")]
    private void SaveResult()
    {
    }

    [Token(Token = "0x60031BD")]
    [Address(RVA = "0x10019A0", Offset = "0x10007A0", VA = "0x110019A0")]
    private void OFFLINE_APPLY_QUEST_RESULT()
    {
    }

    [Token(Token = "0x60031BE")]
    [Address(RVA = "0xFF8D80", Offset = "0xFF7B80", VA = "0x10FF8D80")]
    private void ExitScene()
    {
    }

    [Token(Token = "0x60031BF")]
    [Address(RVA = "0x1004C90", Offset = "0x1003A90", VA = "0x11004C90")]
    public void Pause(bool flag)
    {
    }

    [Token(Token = "0x60031C0")]
    [Address(RVA = "0xFFFE40", Offset = "0xFFEC40", VA = "0x10FFFE40")]
    public bool IsPause() => new bool();

    [Token(Token = "0x60031C1")]
    [Address(RVA = "0xFEF350", Offset = "0xFEE150", VA = "0x10FEF350")]
    public void CleanUpMultiPlay()
    {
    }

    [Token(Token = "0x60031C2")]
    [Address(RVA = "0xFFA550", Offset = "0xFF9350", VA = "0x10FFA550")]
    private SceneBattle.PosRot GetCameraOffset_Unit() => new SceneBattle.PosRot();

    [Token(Token = "0x60031C3")]
    [Address(RVA = "0xFFBE40", Offset = "0xFFAC40", VA = "0x10FFBE40")]
    private void GotoPrepareSkill()
    {
    }

    [Token(Token = "0x60031C4")]
    [Address(RVA = "0xFED750", Offset = "0xFEC550", VA = "0x10FED750")]
    private void CancelMapViewMode()
    {
    }

    [Token(Token = "0x17000315")]
    private Unit mCollaboTargetUnit
    {
      [Token(Token = "0x60031C5"), Address(RVA = "0x101CA00", Offset = "0x101B800", VA = "0x1101CA00")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x17000316")]
    public Unit CollaboMainUnit
    {
      [Token(Token = "0x60031C6"), Address(RVA = "0x101BD20", Offset = "0x101AB20", VA = "0x1101BD20")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x17000317")]
    public Unit CollaboSubUnit
    {
      [Token(Token = "0x60031C7"), Address(RVA = "0x101BD50", Offset = "0x101AB50", VA = "0x1101BD50")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x60031C8")]
    [Address(RVA = "0x100E060", Offset = "0x100CE60", VA = "0x1100E060")]
    private void SetScreenMirroring(bool mirror)
    {
    }

    [Token(Token = "0x60031C9")]
    [Address(RVA = "0xFF8EC0", Offset = "0xFF7CC0", VA = "0x10FF8EC0")]
    private bool FindChangedShield(
      out TacticsUnitController tuc,
      out TacticsUnitController.ShieldState shield)
    {
      return new bool();
    }

    [Token(Token = "0x60031CA")]
    [Address(RVA = "0x100E3D0", Offset = "0x100D1D0", VA = "0x1100E3D0")]
    private IEnumerator SetWeatherEffect(WeatherData wd) => (IEnumerator) null;

    [Token(Token = "0x60031CB")]
    [Address(RVA = "0x1011620", Offset = "0x1010420", VA = "0x11011620")]
    private IEnumerator StopWeatherEffect(bool is_immidiate = false) => (IEnumerator) null;

    [Token(Token = "0x60031CC")]
    [Address(RVA = "0xFFA0F0", Offset = "0xFF8EF0", VA = "0x10FFA0F0")]
    public void ForceRestoreWeatherEffect(WeatherData wth_data)
    {
    }

    [Token(Token = "0x60031CD")]
    [Address(RVA = "0xFFA180", Offset = "0xFF8F80", VA = "0x10FFA180")]
    public void ForceStopWeatherEffect(bool is_immidiate)
    {
    }

    [Token(Token = "0x60031CE")]
    [Address(RVA = "0xFF1BB0", Offset = "0xFF09B0", VA = "0x10FF1BB0")]
    private JSON_GvGBattleEndParam CreateGvGbattleEndParam(BtlResultTypes result)
    {
      return (JSON_GvGBattleEndParam) null;
    }

    [Token(Token = "0x60031CF")]
    [Address(RVA = "0xFF21C0", Offset = "0xFF0FC0", VA = "0x10FF21C0")]
    private JSON_LeagueMatchBattleDetail CreateLeagueMatchEndParam()
    {
      return (JSON_LeagueMatchBattleDetail) null;
    }

    [Token(Token = "0x17000318")]
    public bool isUpView
    {
      [Token(Token = "0x60031D0"), Address(RVA = "0x101C9A0", Offset = "0x101B7A0", VA = "0x1101C9A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000319")]
    public bool isNewCamera
    {
      [Token(Token = "0x60031D1"), Address(RVA = "0x101C990", Offset = "0x101B790", VA = "0x1101C990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700031A")]
    public bool isFullRotationCamera
    {
      [Token(Token = "0x60031D2"), Address(RVA = "0x101C980", Offset = "0x101B780", VA = "0x1101C980")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700031B")]
    public bool mUpdateCameraPosition
    {
      [Token(Token = "0x60031D3"), Address(RVA = "0x101CCE0", Offset = "0x101BAE0", VA = "0x1101CCE0")] set
      {
      }
      [Token(Token = "0x60031D4"), Address(RVA = "0x101CA70", Offset = "0x101B870", VA = "0x1101CA70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700031C")]
    public bool isBattleCamera
    {
      [Token(Token = "0x60031D5"), Address(RVA = "0x101C910", Offset = "0x101B710", VA = "0x1101C910")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700031D")]
    public TargetCamera targetCamera
    {
      [Token(Token = "0x60031D6"), Address(RVA = "0xFC53A0", Offset = "0xFC41A0", VA = "0x10FC53A0")] get
      {
        return (TargetCamera) null;
      }
    }

    [Token(Token = "0x1700031E")]
    private bool IsCameraMoving
    {
      [Token(Token = "0x60031D7"), Address(RVA = "0x101C0D0", Offset = "0x101AED0", VA = "0x1101C0D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700031F")]
    public bool isCameraLeftMove
    {
      [Token(Token = "0x60031D8"), Address(RVA = "0x101C920", Offset = "0x101B720", VA = "0x1101C920")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000320")]
    public bool isCameraRightMove
    {
      [Token(Token = "0x60031D9"), Address(RVA = "0x101C950", Offset = "0x101B750", VA = "0x1101C950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000321")]
    private Vector3 mCameraTarget
    {
      [Token(Token = "0x60031DA"), Address(RVA = "0x101CCC0", Offset = "0x101BAC0", VA = "0x1101CCC0")] set
      {
      }
      [Token(Token = "0x60031DB"), Address(RVA = "0x101C9E0", Offset = "0x101B7E0", VA = "0x1101C9E0")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17000322")]
    private bool mAllowCameraRotation
    {
      [Token(Token = "0x60031DC"), Address(RVA = "0x101CC80", Offset = "0x101BA80", VA = "0x1101CC80")] set
      {
      }
      [Token(Token = "0x60031DD"), Address(RVA = "0x101C9C0", Offset = "0x101B7C0", VA = "0x1101C9C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000323")]
    private bool mAllowCameraTranslation
    {
      [Token(Token = "0x60031DE"), Address(RVA = "0x101CCA0", Offset = "0x101BAA0", VA = "0x1101CCA0")] set
      {
      }
      [Token(Token = "0x60031DF"), Address(RVA = "0x101C9D0", Offset = "0x101B7D0", VA = "0x1101C9D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000324")]
    private bool mDesiredCameraTargetSet
    {
      [Token(Token = "0x60031E0"), Address(RVA = "0x5EF210", Offset = "0x5EE010", VA = "0x105EF210")] set
      {
      }
      [Token(Token = "0x60031E1"), Address(RVA = "0x5EF100", Offset = "0x5EDF00", VA = "0x105EF100")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000325")]
    public float CameraYawRatio
    {
      [Token(Token = "0x60031E2"), Address(RVA = "0x101BCC0", Offset = "0x101AAC0", VA = "0x1101BCC0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60031E3")]
    [Address(RVA = "0x1009FA0", Offset = "0x1008DA0", VA = "0x11009FA0")]
    public void SetMoveCamera()
    {
    }

    [Token(Token = "0x60031E4")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void SetCameraOffset(Transform transform)
    {
    }

    [Token(Token = "0x60031E5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void InterpCameraOffset(Transform transform)
    {
    }

    [Token(Token = "0x60031E6")]
    [Address(RVA = "0xFFE170", Offset = "0xFFCF70", VA = "0x10FFE170")]
    private void InitCamera()
    {
    }

    [Token(Token = "0x60031E7")]
    [Address(RVA = "0xFF8150", Offset = "0xFF6F50", VA = "0x10FF8150")]
    private void DestroyCamera()
    {
    }

    [Token(Token = "0x60031E8")]
    [Address(RVA = "0x1009DD0", Offset = "0x1008BD0", VA = "0x11009DD0")]
    public void ResetCameraTarget()
    {
    }

    [Token(Token = "0x60031E9")]
    [Address(RVA = "0x1009FA0", Offset = "0x1008DA0", VA = "0x11009FA0")]
    public void ResetMoveCamera()
    {
    }

    [Token(Token = "0x60031EA")]
    [Address(RVA = "0x1018950", Offset = "0x1017750", VA = "0x11018950")]
    private void UpdateCameraControl(bool immediate = false)
    {
    }

    [Token(Token = "0x60031EB")]
    [Address(RVA = "0x1019410", Offset = "0x1018210", VA = "0x11019410")]
    private bool UpdateCameraRotationTouchMove(bool isEnable, bool immediate) => new bool();

    [Token(Token = "0x60031EC")]
    [Address(RVA = "0x1018FF0", Offset = "0x1017DF0", VA = "0x11018FF0")]
    private bool UpdateCameraPositionTouchMove(Vector3 xAxis, Vector3 yAxis) => new bool();

    [Token(Token = "0x60031ED")]
    [Address(RVA = "0x1019320", Offset = "0x1018120", VA = "0x11019320")]
    private bool UpdateCameraRotationInterp(bool immediate) => new bool();

    [Token(Token = "0x60031EE")]
    [Address(RVA = "0x1018E80", Offset = "0x1017C80", VA = "0x11018E80")]
    private bool UpdateCameraPositionInterp(bool immediate) => new bool();

    [Token(Token = "0x60031EF")]
    [Address(RVA = "0x100DA90", Offset = "0x100C890", VA = "0x1100DA90")]
    public void SetBattleCamera(bool value)
    {
    }

    [Token(Token = "0x60031F0")]
    [Address(RVA = "0x100DD40", Offset = "0x100CB40", VA = "0x1100DD40")]
    public void SetNewCamera(TacticsSceneCamera camera)
    {
    }

    [Token(Token = "0x60031F1")]
    [Address(RVA = "0x100DCE0", Offset = "0x100CAE0", VA = "0x1100DCE0")]
    public void SetFullRotationCamera(bool value)
    {
    }

    [Token(Token = "0x60031F2")]
    [Address(RVA = "0xFFA540", Offset = "0xFF9340", VA = "0x10FFA540")]
    public float GetCameraDistance() => new float();

    [Token(Token = "0x60031F3")]
    [Address(RVA = "0x100DAB0", Offset = "0x100C8B0", VA = "0x1100DAB0")]
    private void SetCameraTarget(Vector3 position)
    {
    }

    [Token(Token = "0x60031F4")]
    [Address(RVA = "0x100DAE0", Offset = "0x100C8E0", VA = "0x1100DAE0")]
    private void SetCameraTarget(Component component, bool is_cal_height = false)
    {
    }

    [Token(Token = "0x60031F5")]
    [Address(RVA = "0x100DC60", Offset = "0x100CA60", VA = "0x1100DC60")]
    private void SetCameraTarget(float x, float y)
    {
    }

    [Token(Token = "0x60031F6")]
    [Address(RVA = "0xFFF9C0", Offset = "0xFFE7C0", VA = "0x10FFF9C0")]
    public void InterpCameraTarget(Vector3 position)
    {
    }

    [Token(Token = "0x60031F7")]
    [Address(RVA = "0xFFF880", Offset = "0xFFE680", VA = "0x10FFF880")]
    private void InterpCameraTarget(Component component)
    {
    }

    [Token(Token = "0x60031F8")]
    [Address(RVA = "0xFFF800", Offset = "0xFFE600", VA = "0x10FFF800")]
    private void InterpCameraTargetToCurrent()
    {
    }

    [Token(Token = "0x60031F9")]
    [Address(RVA = "0xFFF7E0", Offset = "0xFFE5E0", VA = "0x10FFF7E0")]
    public void InterpCameraDistance(float distance)
    {
    }

    [Token(Token = "0x60031FA")]
    [Address(RVA = "0x100DCB0", Offset = "0x100CAB0", VA = "0x1100DCB0")]
    public void SetCameraYawRange(float min, float max)
    {
    }

    [Token(Token = "0x60031FB")]
    [Address(RVA = "0x100A590", Offset = "0x1009390", VA = "0x1100A590")]
    public void RotateCamera(float delta, float duration)
    {
    }

    [Token(Token = "0x60031FC")]
    [Address(RVA = "0xFFA530", Offset = "0xFF9330", VA = "0x10FFA530")]
    public float GetCameraAngle() => new float();

    [Token(Token = "0x60031FD")]
    [Address(RVA = "0xFFA5F0", Offset = "0xFF93F0", VA = "0x10FFA5F0")]
    public void GetCameraTargetView(out Vector3 center, out float distance, Vector3[] targets)
    {
    }

    [Token(Token = "0x60031FE")]
    [Address(RVA = "0x1002240", Offset = "0x1001040", VA = "0x11002240")]
    private void OnCameraPreCull(UnityEngine.Camera cam)
    {
    }

    [Token(Token = "0x60031FF")]
    [Address(RVA = "0x1001E50", Offset = "0x1000C50", VA = "0x11001E50")]
    private void OnCameraForcus()
    {
    }

    [Token(Token = "0x6003200")]
    [Address(RVA = "0x10185F0", Offset = "0x10173F0", VA = "0x110185F0")]
    private void UpdateCameraControlUpView(bool immediate = false)
    {
    }

    [Token(Token = "0x6003201")]
    [Address(RVA = "0x1001F80", Offset = "0x1000D80", VA = "0x11001F80")]
    public void OnCameraModeChange(SceneBattle.CameraMode nextMode)
    {
    }

    [Token(Token = "0x17000326")]
    public bool AudiencePause
    {
      [Token(Token = "0x6003202"), Address(RVA = "0x101BCA0", Offset = "0x101AAA0", VA = "0x1101BCA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003203"), Address(RVA = "0x101CAC0", Offset = "0x101B8C0", VA = "0x1101CAC0")] set
      {
      }
    }

    [Token(Token = "0x17000327")]
    public bool AudienceSkip
    {
      [Token(Token = "0x6003204"), Address(RVA = "0x101BCB0", Offset = "0x101AAB0", VA = "0x1101BCB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003205"), Address(RVA = "0x101CAE0", Offset = "0x101B8E0", VA = "0x1101CAE0")] set
      {
      }
    }

    [Token(Token = "0x6003206")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void MultiPlayLog(string str)
    {
    }

    [Token(Token = "0x17000328")]
    public int MultiPlayerCount
    {
      [Token(Token = "0x6003207"), Address(RVA = "0x101C740", Offset = "0x101B540", VA = "0x1101C740")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000329")]
    private float MultiPlayInputTimeLimit
    {
      [Token(Token = "0x6003208"), Address(RVA = "0x101C730", Offset = "0x101B530", VA = "0x1101C730")] get
      {
        return new float();
      }
      [Token(Token = "0x6003209"), Address(RVA = "0x101CC00", Offset = "0x101BA00", VA = "0x1101CC00")] set
      {
      }
    }

    [Token(Token = "0x1700032A")]
    private bool MultiPlayExtMoveInputTime
    {
      [Token(Token = "0x600320A"), Address(RVA = "0x101C710", Offset = "0x101B510", VA = "0x1101C710")] get
      {
        return new bool();
      }
      [Token(Token = "0x600320B"), Address(RVA = "0x101CBC0", Offset = "0x101B9C0", VA = "0x1101CBC0")] set
      {
      }
    }

    [Token(Token = "0x1700032B")]
    private bool MultiPlayExtSelectInputTime
    {
      [Token(Token = "0x600320C"), Address(RVA = "0x101C720", Offset = "0x101B520", VA = "0x1101C720")] get
      {
        return new bool();
      }
      [Token(Token = "0x600320D"), Address(RVA = "0x101CBE0", Offset = "0x101B9E0", VA = "0x1101CBE0")] set
      {
      }
    }

    [Token(Token = "0x1700032C")]
    public float MultiPlayAddInputTime
    {
      [Token(Token = "0x600320E"), Address(RVA = "0x101C700", Offset = "0x101B500", VA = "0x1101C700")] get
      {
        return new float();
      }
      [Token(Token = "0x600320F"), Address(RVA = "0x101CBA0", Offset = "0x101B9A0", VA = "0x1101CBA0")] set
      {
      }
    }

    [Token(Token = "0x1700032D")]
    public bool ResumeSuccess
    {
      [Token(Token = "0x6003210"), Address(RVA = "0x101C830", Offset = "0x101B630", VA = "0x1101C830")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003211"), Address(RVA = "0x101CC40", Offset = "0x101BA40", VA = "0x1101CC40")] set
      {
      }
    }

    [Token(Token = "0x1700032E")]
    public bool ResumeOnly
    {
      [Token(Token = "0x6003212"), Address(RVA = "0x101C820", Offset = "0x101B620", VA = "0x1101C820")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700032F")]
    public bool VersusMapView
    {
      [Token(Token = "0x6003213"), Address(RVA = "0x101C900", Offset = "0x101B700", VA = "0x1101C900")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003214"), Address(RVA = "0x101CC60", Offset = "0x101BA60", VA = "0x1101CC60")] set
      {
      }
    }

    [Token(Token = "0x17000330")]
    public bool AlreadyEndBattle
    {
      [Token(Token = "0x6003215"), Address(RVA = "0x101BC80", Offset = "0x101AA80", VA = "0x1101BC80")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003216"), Address(RVA = "0x101CA80", Offset = "0x101B880", VA = "0x1101CA80")] set
      {
      }
    }

    [Token(Token = "0x17000331")]
    public bool IsExistResume
    {
      [Token(Token = "0x6003217"), Address(RVA = "0x101C170", Offset = "0x101AF70", VA = "0x1101C170")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000332")]
    public bool AudienceForceEnd
    {
      [Token(Token = "0x6003218"), Address(RVA = "0x101BC90", Offset = "0x101AA90", VA = "0x1101BC90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003219"), Address(RVA = "0x101CAA0", Offset = "0x101B8A0", VA = "0x1101CAA0")] set
      {
      }
    }

    [Token(Token = "0x17000333")]
    public bool IsSend
    {
      [Token(Token = "0x600321A"), Address(RVA = "0x101C5C0", Offset = "0x101B3C0", VA = "0x1101C5C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000334")]
    public bool IsAutoForDisplay
    {
      [Token(Token = "0x600321B"), Address(RVA = "0x101C0C0", Offset = "0x101AEC0", VA = "0x1101C0C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600321C"), Address(RVA = "0x101CB80", Offset = "0x101B980", VA = "0x1101CB80")] private set
      {
      }
    }

    [Token(Token = "0x600321D")]
    [Address(RVA = "0xFF8E30", Offset = "0xFF7C30", VA = "0x10FF8E30")]
    public void ExtentionMultiInputTime(bool bMove)
    {
    }

    [Token(Token = "0x600321E")]
    [Address(RVA = "0xFF3DC0", Offset = "0xFF2BC0", VA = "0x10FF3DC0")]
    private void CreateMultiPlayer()
    {
    }

    [Token(Token = "0x600321F")]
    [Address(RVA = "0xFF0F30", Offset = "0xFEFD30", VA = "0x10FF0F30")]
    private void CreateAudiencePlayer()
    {
    }

    [Token(Token = "0x6003220")]
    [Address(RVA = "0xFF1460", Offset = "0xFF0260", VA = "0x10FF1460")]
    private void CreateCpuBattlePlayer()
    {
    }

    [Token(Token = "0x6003221")]
    [Address(RVA = "0xFED920", Offset = "0xFEC720", VA = "0x10FED920")]
    public void ChangeMultiPlayerUnit(Unit fr_unit, Unit to_unit)
    {
    }

    [Token(Token = "0x6003222")]
    [Address(RVA = "0x100A4B0", Offset = "0x10092B0", VA = "0x1100A4B0")]
    public void ResumeMultiPlayerUnit()
    {
    }

    [Token(Token = "0x6003223")]
    [Address(RVA = "0xFFFBE0", Offset = "0xFFE9E0", VA = "0x10FFFBE0")]
    public bool IsMultiPlayerAuto(Unit unit, bool showMode = false) => new bool();

    [Token(Token = "0x6003224")]
    [Address(RVA = "0xFFFD30", Offset = "0xFFEB30", VA = "0x10FFFD30")]
    public bool IsMultiTreasurePriority(Unit unit) => new bool();

    [Token(Token = "0x6003225")]
    [Address(RVA = "0xFFFAD0", Offset = "0xFFE8D0", VA = "0x10FFFAD0")]
    public bool IsMultiDisableSkill(Unit unit) => new bool();

    [Token(Token = "0x6003226")]
    [Address(RVA = "0xFEC540", Offset = "0xFEB340", VA = "0x10FEC540")]
    private void BeginMultiPlayer()
    {
    }

    [Token(Token = "0x6003227")]
    [Address(RVA = "0xFF8C40", Offset = "0xFF7A40", VA = "0x10FF8C40")]
    private void EndMultiPlayer()
    {
    }

    [Token(Token = "0x6003228")]
    [Address(RVA = "0xFEFBA0", Offset = "0xFEE9A0", VA = "0x10FEFBA0")]
    private SceneBattle.MultiPlayRecvData ConvertInputToReceiveData(
      SceneBattle.EMultiPlayRecvDataHeader header,
      int unitID,
      List<SceneBattle.MultiPlayInput> sendList)
    {
      return (SceneBattle.MultiPlayRecvData) null;
    }

    [Token(Token = "0x6003229")]
    [Address(RVA = "0xFF43A0", Offset = "0xFF31A0", VA = "0x10FF43A0")]
    private byte[] CreateSendBinary(SceneBattle.MultiPlayRecvData recv) => (byte[]) null;

    [Token(Token = "0x600322A")]
    [Address(RVA = "0xFF4330", Offset = "0xFF3130", VA = "0x10FF4330")]
    private byte[] CreateSendBinary(
      SceneBattle.EMultiPlayRecvDataHeader header,
      int unitID,
      List<SceneBattle.MultiPlayInput> sendList)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600322B")]
    [Address(RVA = "0xFF2650", Offset = "0xFF1450", VA = "0x10FF2650")]
    private string CreateMultiPlayInputList(
      SceneBattle.EMultiPlayRecvDataHeader header,
      int unitID,
      List<SceneBattle.MultiPlayInput> sendList)
    {
      return (string) null;
    }

    [Token(Token = "0x600322C")]
    [Address(RVA = "0xFFA2A0", Offset = "0xFF90A0", VA = "0x10FFA2A0")]
    private bool GainMultiPlayInputTimeLimit() => new bool();

    [Token(Token = "0x600322D")]
    [Address(RVA = "0x100A000", Offset = "0x1008E00", VA = "0x1100A000")]
    private TacticsUnitController ResetMultiPlayerTransform(Unit unit)
    {
      return (TacticsUnitController) null;
    }

    [Token(Token = "0x17000335")]
    public int DisplayMultiPlayInputTimeLimit
    {
      [Token(Token = "0x600322E"), Address(RVA = "0xFEBE00", Offset = "0xFEAC00", VA = "0x10FEBE00")] get
      {
        return new int();
      }
      [Token(Token = "0x600322F"), Address(RVA = "0x101CB60", Offset = "0x101B960", VA = "0x1101CB60")] set
      {
      }
    }

    [Token(Token = "0x17000336")]
    public PhotonPlayerParameter CurrentNotifyDisconnectedPlayer
    {
      [Token(Token = "0x6003230"), Address(RVA = "0xFEBDF0", Offset = "0xFEABF0", VA = "0x10FEBDF0")] get
      {
        return (PhotonPlayerParameter) null;
      }
      [Token(Token = "0x6003231"), Address(RVA = "0x101CB20", Offset = "0x101B920", VA = "0x1101CB20")] set
      {
      }
    }

    [Token(Token = "0x17000337")]
    public PhotonPlayerParameter CurrentResumePlayer
    {
      [Token(Token = "0x6003232"), Address(RVA = "0xA23110", Offset = "0xA21F10", VA = "0x10A23110")] get
      {
        return (PhotonPlayerParameter) null;
      }
      [Token(Token = "0x6003233"), Address(RVA = "0x101CB40", Offset = "0x101B940", VA = "0x1101CB40")] set
      {
      }
    }

    [Token(Token = "0x17000338")]
    public SceneBattle.ENotifyDisconnectedPlayerType CurrentNotifyDisconnectedPlayerType
    {
      [Token(Token = "0x6003234"), Address(RVA = "0xA23070", Offset = "0xA21E70", VA = "0x10A23070")] get
      {
        return new SceneBattle.ENotifyDisconnectedPlayerType();
      }
      [Token(Token = "0x6003235"), Address(RVA = "0x101CB00", Offset = "0x101B900", VA = "0x1101CB00")] set
      {
      }
    }

    [Token(Token = "0x6003236")]
    [Address(RVA = "0xFFABD0", Offset = "0xFF99D0", VA = "0x10FFABD0")]
    private int GetMultiPlayInputTimeLimit() => new int();

    [Token(Token = "0x6003237")]
    [Address(RVA = "0xFFAC00", Offset = "0xFF9A00", VA = "0x10FFAC00")]
    public int GetNextMyTurn() => new int();

    [Token(Token = "0x17000339")]
    public string PhotonErrorString
    {
      [Token(Token = "0x6003238"), Address(RVA = "0x319810", Offset = "0x318610", VA = "0x10319810")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003239")]
    [Address(RVA = "0x1003EB0", Offset = "0x1002CB0", VA = "0x11003EB0")]
    private void OnSuccessCheat(WWWResult www)
    {
    }

    [Token(Token = "0x600323A")]
    [Address(RVA = "0x10088C0", Offset = "0x10076C0", VA = "0x110088C0")]
    private void RecvResumeSuccess(SceneBattle.MultiPlayer mp, SceneBattle.MultiPlayRecvData data)
    {
    }

    [Token(Token = "0x600323B")]
    [Address(RVA = "0x10077F0", Offset = "0x10065F0", VA = "0x110077F0")]
    private void RecvEvent()
    {
    }

    [Token(Token = "0x600323C")]
    [Address(RVA = "0xFF85F0", Offset = "0xFF73F0", VA = "0x10FF85F0")]
    private bool DisconnetEvent() => new bool();

    [Token(Token = "0x600323D")]
    [Address(RVA = "0x100F210", Offset = "0x100E010", VA = "0x1100F210")]
    private void ShowTimeLimit()
    {
    }

    [Token(Token = "0x600323E")]
    [Address(RVA = "0x100EF60", Offset = "0x100DD60", VA = "0x1100EF60")]
    private void ShowThinking()
    {
    }

    [Token(Token = "0x600323F")]
    [Address(RVA = "0x1003FD0", Offset = "0x1002DD0", VA = "0x11003FD0")]
    private void OtherPlayerDisconnect()
    {
    }

    [Token(Token = "0x6003240")]
    [Address(RVA = "0x1004A60", Offset = "0x1003860", VA = "0x11004A60")]
    private void OtherPlayerResume()
    {
    }

    [Token(Token = "0x6003241")]
    [Address(RVA = "0xFEE820", Offset = "0xFED620", VA = "0x10FEE820")]
    private void CheckStart()
    {
    }

    [Token(Token = "0x6003242")]
    [Address(RVA = "0x1019E90", Offset = "0x1018C90", VA = "0x11019E90")]
    private void UpdateMultiBattleInfo()
    {
    }

    [Token(Token = "0x6003243")]
    [Address(RVA = "0xFEDC10", Offset = "0xFECA10", VA = "0x10FEDC10")]
    private bool CheckInputTimeLimit() => new bool();

    [Token(Token = "0x6003244")]
    [Address(RVA = "0x100D4C0", Offset = "0x100C2C0", VA = "0x1100D4C0")]
    private void SendTimeLimit()
    {
    }

    [Token(Token = "0x6003245")]
    [Address(RVA = "0xFEEE70", Offset = "0xFEDC70", VA = "0x10FEEE70")]
    public bool CheckSync() => new bool();

    [Token(Token = "0x6003246")]
    [Address(RVA = "0x100A190", Offset = "0x1008F90", VA = "0x1100A190")]
    public void ResetSync()
    {
    }

    [Token(Token = "0x6003247")]
    [Address(RVA = "0xFEE4F0", Offset = "0xFED2F0", VA = "0x10FEE4F0")]
    public bool CheckResumeSync() => new bool();

    [Token(Token = "0x6003248")]
    [Address(RVA = "0x101A8F0", Offset = "0x10196F0", VA = "0x1101A8F0")]
    private void UpdateMultiPlayer()
    {
    }

    [Token(Token = "0x6003249")]
    [Address(RVA = "0x10072B0", Offset = "0x10060B0", VA = "0x110072B0")]
    private bool RecvEventAudience(bool isSkip = false) => new bool();

    [Token(Token = "0x600324A")]
    [Address(RVA = "0xFEE710", Offset = "0xFED510", VA = "0x10FEE710")]
    private bool CheckSkipLogEnd(bool isSkip, int cnt, bool check) => new bool();

    [Token(Token = "0x600324B")]
    [Address(RVA = "0x1018270", Offset = "0x1017070", VA = "0x11018270")]
    private void UpdateAudiencePlayer()
    {
    }

    [Token(Token = "0x600324C")]
    [Address(RVA = "0x100FDD0", Offset = "0x100EBD0", VA = "0x1100FDD0")]
    public void SkipLog()
    {
    }

    [Token(Token = "0x600324D")]
    [Address(RVA = "0x100B510", Offset = "0x100A310", VA = "0x1100B510")]
    private void SendForceAuto()
    {
    }

    [Token(Token = "0x600324E")]
    [Address(RVA = "0x100AAC0", Offset = "0x10098C0", VA = "0x1100AAC0")]
    private void SendAuto(bool isBegin = false)
    {
    }

    [Token(Token = "0x600324F")]
    [Address(RVA = "0x10173A0", Offset = "0x10161A0", VA = "0x110173A0")]
    public void ToggleAutoPlay(bool enable)
    {
    }

    [Token(Token = "0x6003250")]
    [Address(RVA = "0x100BF20", Offset = "0x100AD20", VA = "0x1100BF20")]
    private void SendInputFlush(bool force = false)
    {
    }

    [Token(Token = "0x6003251")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void SendInputMove(Unit unit, TacticsUnitController controller)
    {
    }

    [Token(Token = "0x6003252")]
    [Address(RVA = "0x100C270", Offset = "0x100B070", VA = "0x1100C270")]
    private void SendInputGridXY(Unit unit, int gridX, int gridY, EUnitDirection dir, bool send = true)
    {
    }

    [Token(Token = "0x6003253")]
    [Address(RVA = "0x100C600", Offset = "0x100B400", VA = "0x1100C600")]
    private void SendInputMoveStart(Unit unit)
    {
    }

    [Token(Token = "0x6003254")]
    [Address(RVA = "0x100C450", Offset = "0x100B250", VA = "0x1100C450")]
    private void SendInputMoveEnd(Unit unit, bool cancel)
    {
    }

    [Token(Token = "0x6003255")]
    [Address(RVA = "0x100B7F0", Offset = "0x100A5F0", VA = "0x1100B7F0")]
    private void SendInputEntryBattle(
      EBattleCommand type,
      Unit unit,
      Unit enemy,
      SkillData skill,
      ItemData item,
      int gx,
      int gy,
      bool bUnitLockTarget)
    {
    }

    [Token(Token = "0x6003256")]
    [Address(RVA = "0x100C0D0", Offset = "0x100AED0", VA = "0x1100C0D0")]
    private void SendInputGridEvent(Unit unit)
    {
    }

    [Token(Token = "0x6003257")]
    [Address(RVA = "0x100C750", Offset = "0x100B550", VA = "0x1100C750")]
    private void SendInputUnitEnd(Unit unit, EUnitDirection dir)
    {
    }

    [Token(Token = "0x6003258")]
    [Address(RVA = "0x100C900", Offset = "0x100B700", VA = "0x1100C900")]
    private void SendInputUnitTimeLimit(Unit unit)
    {
    }

    [Token(Token = "0x6003259")]
    [Address(RVA = "0x100CA50", Offset = "0x100B850", VA = "0x1100CA50")]
    private void SendInputUnitXYDir(Unit unit, int gridX, int gridY, EUnitDirection dir)
    {
    }

    [Token(Token = "0x600325A")]
    [Address(RVA = "0x100B6E0", Offset = "0x100A4E0", VA = "0x1100B6E0")]
    private bool SendIgnoreMyDisconnect() => new bool();

    [Token(Token = "0x600325B")]
    [Address(RVA = "0x100CD70", Offset = "0x100BB70", VA = "0x1100CD70")]
    public void SendOtherPlayerDisconnect(int uid)
    {
    }

    [Token(Token = "0x600325C")]
    [Address(RVA = "0x1009E90", Offset = "0x1008C90", VA = "0x11009E90")]
    public void ResetCheckData()
    {
    }

    [Token(Token = "0x600325D")]
    [Address(RVA = "0x100ADC0", Offset = "0x1009BC0", VA = "0x1100ADC0")]
    private bool SendCheckMultiPlay() => new bool();

    [Token(Token = "0x600325E")]
    [Address(RVA = "0xFEDCC0", Offset = "0xFECAC0", VA = "0x10FEDCC0")]
    private bool CheckMultiPlay() => new bool();

    [Token(Token = "0x600325F")]
    [Address(RVA = "0xFFAE00", Offset = "0xFF9C00", VA = "0x10FFAE00")]
    private SRPG_TouchInputModule GetTouchInputModule() => (SRPG_TouchInputModule) null;

    [Token(Token = "0x6003260")]
    [Address(RVA = "0x100E540", Offset = "0x100D340", VA = "0x1100E540")]
    public void SetupGoodJob()
    {
    }

    [Token(Token = "0x6003261")]
    [Address(RVA = "0xFEF420", Offset = "0xFEE220", VA = "0x10FEF420")]
    public void CleanupGoodJob()
    {
    }

    [Token(Token = "0x6003262")]
    [Address(RVA = "0xFEBE50", Offset = "0xFEAC50", VA = "0x10FEBE50")]
    private void AddGoodJob(int gx, int gy, int unitID = -1)
    {
    }

    [Token(Token = "0x6003263")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void OnDoubleTap(Vector2 pos)
    {
    }

    [Token(Token = "0x6003264")]
    [Address(RVA = "0x1003460", Offset = "0x1002260", VA = "0x11003460")]
    private void OnGoodJobClickGrid(Grid grid)
    {
    }

    [Token(Token = "0x6003265")]
    [Address(RVA = "0x1003490", Offset = "0x1002290", VA = "0x11003490")]
    private void OnGoodJobClickUnit(TacticsUnitController controller)
    {
    }

    [Token(Token = "0x6003266")]
    [Address(RVA = "0x10196E0", Offset = "0x10184E0", VA = "0x110196E0")]
    private void UpdateGoodJob()
    {
    }

    [Token(Token = "0x6003267")]
    [Address(RVA = "0x100B360", Offset = "0x100A160", VA = "0x1100B360")]
    public bool SendFinishLoad() => new bool();

    [Token(Token = "0x6003268")]
    [Address(RVA = "0x100D3C0", Offset = "0x100C1C0", VA = "0x1100D3C0")]
    public void SendResumeSuccess()
    {
    }

    [Token(Token = "0x6003269")]
    [Address(RVA = "0x100CE70", Offset = "0x100BC70", VA = "0x1100CE70")]
    public void SendRequestResume()
    {
    }

    [Token(Token = "0x600326A")]
    [Address(RVA = "0x100A940", Offset = "0x1009740", VA = "0x1100A940")]
    public int SearchUnitIndex(Unit target) => new int();

    [Token(Token = "0x600326B")]
    [Address(RVA = "0x100D1F0", Offset = "0x100BFF0", VA = "0x1100D1F0")]
    public void SendResumeInfo()
    {
    }

    [Token(Token = "0x600326C")]
    [Address(RVA = "0xFF4400", Offset = "0xFF3200", VA = "0x10FF4400")]
    private byte[] CreateSendResumeInfo() => (byte[]) null;

    [Token(Token = "0x600326D")]
    [Address(RVA = "0x1008B60", Offset = "0x1007960", VA = "0x11008B60")]
    private IEnumerator RecvResume(byte[] resumedata) => (IEnumerator) null;

    [Token(Token = "0x600326E")]
    [Address(RVA = "0x1006E00", Offset = "0x1005C00", VA = "0x11006E00")]
    private void RecvBuildBuffAndCond(
      ref List<MultiPlayResumeSkillData> buff,
      ref List<MultiPlayResumeSkillData> cond,
      MultiPlayResumeUnitData unit)
    {
    }

    [Token(Token = "0x600326F")]
    [Address(RVA = "0x1008BD0", Offset = "0x10079D0", VA = "0x11008BD0")]
    private void RecvUnitDead(TacticsUnitController controller, Unit target)
    {
    }

    [Token(Token = "0x6003270")]
    [Address(RVA = "0x1008860", Offset = "0x1007660", VA = "0x11008860")]
    private IEnumerator RecvReinforcementUnit() => (IEnumerator) null;

    [Token(Token = "0x6003271")]
    [Address(RVA = "0x100A440", Offset = "0x1009240", VA = "0x1100A440")]
    private IEnumerator RestoreWeather(WeatherData wth_data) => (IEnumerator) null;

    [Token(Token = "0x6003272")]
    [Address(RVA = "0x100ACE0", Offset = "0x1009AE0", VA = "0x1100ACE0")]
    public void SendCheat(SceneBattle.CHEAT_TYPE type, int uid)
    {
    }

    [Token(Token = "0x6003273")]
    [Address(RVA = "0xFEDAA0", Offset = "0xFEC8A0", VA = "0x10FEDAA0")]
    public BattleCore.QuestResult CheckAudienceResult() => new BattleCore.QuestResult();

    [Token(Token = "0x6003274")]
    [Address(RVA = "0x1019DA0", Offset = "0x1018BA0", VA = "0x11019DA0")]
    private void UpdateInterval()
    {
    }

    [Token(Token = "0x1700033A")]
    public SceneBattle.MoveInput VirtualStickMoveInput
    {
      [Token(Token = "0x6003275"), Address(RVA = "0x305B90", Offset = "0x304990", VA = "0x10305B90")] get
      {
        return (SceneBattle.MoveInput) null;
      }
    }

    [Token(Token = "0x1700033B")]
    public EventScript EventScript
    {
      [Token(Token = "0x6003276"), Address(RVA = "0x305B80", Offset = "0x304980", VA = "0x10305B80")] get
      {
        return (EventScript) null;
      }
    }

    [Token(Token = "0x1700033C")]
    public GameObject continueWindowRes
    {
      [Token(Token = "0x6003277"), Address(RVA = "0x349180", Offset = "0x347F80", VA = "0x10349180")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6003278")]
    [Address(RVA = "0xFFAA40", Offset = "0xFF9840", VA = "0x10FFAA40")]
    private UnitGauge GetGaugeTemplateFor(Unit unit) => (UnitGauge) null;

    [Token(Token = "0x6003279")]
    [Address(RVA = "0x1002F00", Offset = "0x1001D00", VA = "0x11002F00")]
    public void OnGimmickUpdate()
    {
    }

    [Token(Token = "0x600327A")]
    [Address(RVA = "0xFF8030", Offset = "0xFF6E30", VA = "0x10FF8030")]
    private void DeleteOnGimmickIcon()
    {
    }

    [Token(Token = "0x600327B")]
    [Address(RVA = "0x100E1B0", Offset = "0x100CFB0", VA = "0x1100E1B0")]
    private void SetUnitUiHeight(Unit FocusUnit)
    {
    }

    [Token(Token = "0x600327C")]
    [Address(RVA = "0x100E0F0", Offset = "0x100CEF0", VA = "0x1100E0F0")]
    private void SetUiHeight(int Height)
    {
    }

    [Token(Token = "0x600327D")]
    [Address(RVA = "0xFEC370", Offset = "0xFEB170", VA = "0x10FEC370")]
    private void ArenaActionCountEnable(bool enable)
    {
    }

    [Token(Token = "0x600327E")]
    [Address(RVA = "0xFEC410", Offset = "0xFEB210", VA = "0x10FEC410")]
    private void ArenaActionCountSet(uint count)
    {
    }

    [Token(Token = "0x600327F")]
    [Address(RVA = "0x1009A90", Offset = "0x1008890", VA = "0x11009A90")]
    private void RemainingActionCountEnable(bool pc_enable, bool ec_enable)
    {
    }

    [Token(Token = "0x6003280")]
    [Address(RVA = "0x1009B90", Offset = "0x1008990", VA = "0x11009B90")]
    private void RemainingActionCountSet(uint pc_count, uint ec_count)
    {
    }

    [Token(Token = "0x6003281")]
    [Address(RVA = "0x10090D0", Offset = "0x1007ED0", VA = "0x110090D0")]
    private void ReflectWeatherInfo(WeatherData wd = null)
    {
    }

    [Token(Token = "0x6003282")]
    [Address(RVA = "0xFFAE90", Offset = "0xFF9C90", VA = "0x10FFAE90")]
    private GameObject GetWeatherEffectAttach() => (GameObject) null;

    [Token(Token = "0x6003283")]
    [Address(RVA = "0x100E440", Offset = "0x100D240", VA = "0x1100E440")]
    public void SetWeatherIconActive(bool _active)
    {
    }

    [Token(Token = "0x6003284")]
    [Address(RVA = "0x100E260", Offset = "0x100D060", VA = "0x1100E260")]
    private void SetWeatherEffectActive(bool is_enable)
    {
    }

    [Token(Token = "0x6003285")]
    [Address(RVA = "0xFFAEA0", Offset = "0xFF9CA0", VA = "0x10FFAEA0")]
    public string GetWeatherInfoSetting() => (string) null;

    [Token(Token = "0x6003286")]
    [Address(RVA = "0x10061E0", Offset = "0x1004FE0", VA = "0x110061E0")]
    private void RankingQuestActionCountEnable(bool enable)
    {
    }

    [Token(Token = "0x6003287")]
    [Address(RVA = "0x1006280", Offset = "0x1005080", VA = "0x11006280")]
    private void RankingQuestActionCountSet(uint count)
    {
    }

    [Token(Token = "0x6003288")]
    [Address(RVA = "0x1011510", Offset = "0x1010310", VA = "0x11011510")]
    private void StepToNear(Unit unit)
    {
    }

    [Token(Token = "0x6003289")]
    [Address(RVA = "0x1017300", Offset = "0x1016100", VA = "0x11017300")]
    public void TargetPlateResetHpGauge(TargetPlate plate, Unit unit)
    {
    }

    [Token(Token = "0x600328A")]
    private void GotoState_WaitSignal<T>() where T : State<SceneBattle>, new()
    {
    }

    [Token(Token = "0x600328B")]
    [Address(RVA = "0x1008DA0", Offset = "0x1007BA0", VA = "0x11008DA0")]
    private void ReflectUnitChgButton(Unit unit, bool is_update = false)
    {
    }

    [Token(Token = "0x600328C")]
    [Address(RVA = "0x1009700", Offset = "0x1008500", VA = "0x11009700")]
    private void RefreshMapCommands()
    {
    }

    [Token(Token = "0x600328D")]
    [Address(RVA = "0x1009910", Offset = "0x1008710", VA = "0x11009910")]
    private void RefreshOnlyMapCommand()
    {
    }

    [Token(Token = "0x600328E")]
    [Address(RVA = "0x1009F20", Offset = "0x1008D20", VA = "0x11009F20")]
    private void ResetHpGauge(TacticsUnitController tuc)
    {
    }

    [Token(Token = "0x600328F")]
    [Address(RVA = "0x1006730", Offset = "0x1005530", VA = "0x11006730")]
    public void RecalcAttackTargets(int px, int py, ref GridMap<bool> shateiGrid)
    {
    }

    [Token(Token = "0x6003290")]
    [Address(RVA = "0xFFBD90", Offset = "0xFFAB90", VA = "0x10FFBD90")]
    private void GotoMapViewMode()
    {
    }

    [Token(Token = "0x6003291")]
    [Address(RVA = "0xFFAFD0", Offset = "0xFF9DD0", VA = "0x10FFAFD0")]
    private void GotoItemSelect()
    {
    }

    [Token(Token = "0x6003292")]
    [Address(RVA = "0x1003C50", Offset = "0x1002A50", VA = "0x11003C50")]
    private void OnSelectItemTarget(int x, int y, ItemData item)
    {
    }

    [Token(Token = "0x6003293")]
    [Address(RVA = "0xFFD170", Offset = "0xFFBF70", VA = "0x10FFD170")]
    private void GotoUnitChgSelect(bool is_back = false)
    {
    }

    [Token(Token = "0x6003294")]
    [Address(RVA = "0xFFCE70", Offset = "0xFFBC70", VA = "0x10FFCE70")]
    private void GotoSelectTarget(
      SkillData skill,
      SceneBattle.SelectTargetCallback cancel,
      SceneBattle.SelectTargetPositionWithSkill accept,
      Unit defaultTarget = null,
      bool allowTargetChange = true)
    {
    }

    [Token(Token = "0x6003295")]
    [Address(RVA = "0xFFCFA0", Offset = "0xFFBDA0", VA = "0x10FFCFA0")]
    private void GotoSelectTarget(
      ItemData item,
      SceneBattle.SelectTargetCallback cancel,
      SceneBattle.SelectTargetPositionWithItem accept,
      Unit defaultTarget = null,
      bool allowTargetChange = true)
    {
    }

    [Token(Token = "0x6003296")]
    [Address(RVA = "0xFFAD10", Offset = "0xFF9B10", VA = "0x10FFAD10")]
    private EUnitDirection GetSkillDirectionByTargetArea(
      Unit unit,
      int curX,
      int curY,
      GridMap<bool> targetArea)
    {
      return new EUnitDirection();
    }

    [Token(Token = "0x6003297")]
    [Address(RVA = "0x100A9F0", Offset = "0x10097F0", VA = "0x1100A9F0")]
    public void SelectUnitDir(EUnitDirection dir)
    {
    }

    [Token(Token = "0x6003298")]
    [Address(RVA = "0xFFD080", Offset = "0xFFBE80", VA = "0x10FFD080")]
    private void GotoSkillSelect()
    {
    }

    [Token(Token = "0x6003299")]
    [Address(RVA = "0x1003D40", Offset = "0x1002B40", VA = "0x11003D40")]
    private void OnSelectSkillTarget(int x, int y, SkillData skill, bool bUnitLockTarget)
    {
    }

    [Token(Token = "0x1700033D")]
    private TutorialButtonImage[] TutorialButtonImages
    {
      [Token(Token = "0x600329A"), Address(RVA = "0x101C840", Offset = "0x101B640", VA = "0x1101C840")] get
      {
        return (TutorialButtonImage[]) null;
      }
    }

    [Token(Token = "0x600329B")]
    [Address(RVA = "0xFF8940", Offset = "0xFF7740", VA = "0x10FF8940")]
    public bool EnableControlBattleUI(SceneBattle.eMaskBattleUI emask, bool is_enable)
    {
      return new bool();
    }

    [Token(Token = "0x600329C")]
    [Address(RVA = "0xFF8950", Offset = "0xFF7750", VA = "0x10FF8950")]
    public bool EnableControlBattleUI(uint mask, bool is_enable) => new bool();

    [Token(Token = "0x600329D")]
    [Address(RVA = "0xFFFAB0", Offset = "0xFFE8B0", VA = "0x10FFFAB0")]
    public bool IsControlBattleUI(SceneBattle.eMaskBattleUI emask) => new bool();

    [Token(Token = "0x1700033E")]
    public GameObject KnockBackEffect
    {
      [Token(Token = "0x600329E"), Address(RVA = "0x349490", Offset = "0x348290", VA = "0x10349490")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x1700033F")]
    public GameObject TrickMarker
    {
      [Token(Token = "0x600329F"), Address(RVA = "0x3494A0", Offset = "0x3482A0", VA = "0x103494A0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17000340")]
    public Dictionary<string, GameObject> TrickMarkerDics
    {
      [Token(Token = "0x60032A0"), Address(RVA = "0x349480", Offset = "0x348280", VA = "0x10349480")] get
      {
        return (Dictionary<string, GameObject>) null;
      }
    }

    [Token(Token = "0x17000341")]
    public GameObject JumpFallEffect
    {
      [Token(Token = "0x60032A1"), Address(RVA = "0x349450", Offset = "0x348250", VA = "0x10349450")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17000342")]
    private Canvas OverlayCanvas
    {
      [Token(Token = "0x60032A2"), Address(RVA = "0x101C780", Offset = "0x101B580", VA = "0x1101C780")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x60032A3")]
    [Address(RVA = "0x100E650", Offset = "0x100D450", VA = "0x1100E650")]
    private void ShowAllHPGauges()
    {
    }

    [Token(Token = "0x17000343")]
    private bool IsHPGaugeChanging
    {
      [Token(Token = "0x60032A4"), Address(RVA = "0x101C1F0", Offset = "0x101AFF0", VA = "0x1101C1F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60032A5")]
    [Address(RVA = "0xFFD480", Offset = "0xFFC280", VA = "0x10FFD480")]
    private void HideAllHPGauges()
    {
    }

    [Token(Token = "0x60032A6")]
    [Address(RVA = "0xFFD510", Offset = "0xFFC310", VA = "0x10FFD510")]
    private void HideAllUnitOwnerIndex()
    {
    }

    [Token(Token = "0x60032A7")]
    [Address(RVA = "0x100EC80", Offset = "0x100DA80", VA = "0x1100EC80")]
    private void ShowPlayerHPGauges()
    {
    }

    [Token(Token = "0x60032A8")]
    [Address(RVA = "0x100EA40", Offset = "0x100D840", VA = "0x1100EA40")]
    private void ShowEnemyHPGauges()
    {
    }

    [Token(Token = "0x60032A9")]
    [Address(RVA = "0x100E870", Offset = "0x100D670", VA = "0x1100E870")]
    private void ShowBreakObjHPGauges()
    {
    }

    [Token(Token = "0x60032AA")]
    [Address(RVA = "0x1009A00", Offset = "0x1008800", VA = "0x11009A00")]
    private void RefreshUnitStatus(Unit unit)
    {
    }

    [Token(Token = "0x60032AB")]
    [Address(RVA = "0xFED290", Offset = "0xFEC090", VA = "0x10FED290")]
    private float CalcHeight(float x, float y) => new float();

    [Token(Token = "0x60032AC")]
    [Address(RVA = "0xFECC70", Offset = "0xFEBA70", VA = "0x10FECC70")]
    private IntVector2 CalcClickedGrid(Vector2 screenPosition) => new IntVector2();

    [Token(Token = "0x60032AD")]
    [Address(RVA = "0x1002300", Offset = "0x1001100", VA = "0x11002300")]
    private void OnClickBackground(Vector2 screenPosition)
    {
    }

    [Token(Token = "0x60032AE")]
    private T InstantiateSafe<T>(UnityEngine.Object obj) where T : UnityEngine.Object => (T) null;

    [Token(Token = "0x60032AF")]
    [Address(RVA = "0x1019E40", Offset = "0x1018C40", VA = "0x11019E40")]
    private void UpdateLoadProgress()
    {
    }

    [Token(Token = "0x60032B0")]
    [Address(RVA = "0x10018E0", Offset = "0x10006E0", VA = "0x110018E0")]
    private IEnumerator LoadUIAsync() => (IEnumerator) null;

    [Token(Token = "0x60032B1")]
    [Address(RVA = "0x1001940", Offset = "0x1000740", VA = "0x11001940")]
    private IEnumerator LoadUIGvGAsync() => (IEnumerator) null;

    [Token(Token = "0x60032B2")]
    [Address(RVA = "0xFFE2F0", Offset = "0xFFD0F0", VA = "0x10FFE2F0")]
    private void InitTouchArea()
    {
    }

    [Token(Token = "0x60032B3")]
    [Address(RVA = "0xFF81E0", Offset = "0xFF6FE0", VA = "0x10FF81E0")]
    private void DestroyUI(bool is_part = false)
    {
    }

    [Token(Token = "0x60032B4")]
    [Address(RVA = "0xFFDA40", Offset = "0xFFC840", VA = "0x10FFDA40")]
    private void HideUnitMarkers(bool deactivate = false)
    {
    }

    [Token(Token = "0x60032B5")]
    [Address(RVA = "0xFFDE10", Offset = "0xFFCC10", VA = "0x10FFDE10")]
    private void HideUnitMarkers(SceneBattle.UnitMarkerTypes markerType)
    {
    }

    [Token(Token = "0x60032B6")]
    [Address(RVA = "0xFFDBB0", Offset = "0xFFC9B0", VA = "0x10FFDBB0")]
    private void HideUnitMarkers(Unit unit)
    {
    }

    [Token(Token = "0x60032B7")]
    [Address(RVA = "0x100FBD0", Offset = "0x100E9D0", VA = "0x1100FBD0")]
    private void ShowUnitMarker(List<Unit> units, SceneBattle.UnitMarkerTypes markerType)
    {
    }

    [Token(Token = "0x60032B8")]
    [Address(RVA = "0x100F690", Offset = "0x100E490", VA = "0x1100F690")]
    private void ShowUnitMarker(Unit unit, SceneBattle.UnitMarkerTypes markerType)
    {
    }

    [Token(Token = "0x60032B9")]
    [Address(RVA = "0xFF7EF0", Offset = "0xFF6CF0", VA = "0x10FF7EF0")]
    private void DeactivateUnusedUnitMarkers()
    {
    }

    [Token(Token = "0x60032BA")]
    [Address(RVA = "0x100EB40", Offset = "0x100D940", VA = "0x1100EB40")]
    private void ShowEnemyUnitMarkers()
    {
    }

    [Token(Token = "0x60032BB")]
    [Address(RVA = "0x10055A0", Offset = "0x10043A0", VA = "0x110055A0")]
    public GameObject PopupDamageNumber(TacticsUnitController tuc, int number, float offs_y = 0.0f)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60032BC")]
    [Address(RVA = "0x1005910", Offset = "0x1004710", VA = "0x11005910")]
    public GameObject PopupHpHealNumber(TacticsUnitController tuc, int number, float offs_y = 0.0f)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60032BD")]
    [Address(RVA = "0x1005A30", Offset = "0x1004830", VA = "0x11005A30")]
    public GameObject PopupMpHealNumber(TacticsUnitController tuc, int number) => (GameObject) null;

    [Token(Token = "0x60032BE")]
    [Address(RVA = "0x1005A70", Offset = "0x1004870", VA = "0x11005A70")]
    public GameObject PopupNumber(
      TacticsUnitController tuc,
      int number,
      Color color,
      DamagePopup popup,
      float offs_y = 0.0f)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60032BF")]
    [Address(RVA = "0x10053F0", Offset = "0x10041F0", VA = "0x110053F0")]
    public GameObject PopupDamageDsgNumber(
      TacticsUnitController tuc,
      int number,
      eDamageDispType ddt)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x17000344")]
    public bool HasMissPopup
    {
      [Token(Token = "0x60032C0"), Address(RVA = "0x101BF80", Offset = "0x101AD80", VA = "0x1101BF80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000345")]
    public bool HasPerfectAvoidPopup
    {
      [Token(Token = "0x60032C1"), Address(RVA = "0x101BFD0", Offset = "0x101ADD0", VA = "0x1101BFD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000346")]
    public bool HasGuardPopup
    {
      [Token(Token = "0x60032C2"), Address(RVA = "0x101BEE0", Offset = "0x101ACE0", VA = "0x1101BEE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000347")]
    public bool HasAbsorbPopup
    {
      [Token(Token = "0x60032C3"), Address(RVA = "0x101BDF0", Offset = "0x101ABF0", VA = "0x1101BDF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000348")]
    public bool HasCriticalPopup
    {
      [Token(Token = "0x60032C4"), Address(RVA = "0x101BE90", Offset = "0x101AC90", VA = "0x1101BE90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000349")]
    public bool HasBackstabPopup
    {
      [Token(Token = "0x60032C5"), Address(RVA = "0x101BE40", Offset = "0x101AC40", VA = "0x1101BE40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700034A")]
    public bool HasWeakPopup
    {
      [Token(Token = "0x60032C6"), Address(RVA = "0x101C070", Offset = "0x101AE70", VA = "0x1101C070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700034B")]
    public bool HasResistPopup
    {
      [Token(Token = "0x60032C7"), Address(RVA = "0x101C020", Offset = "0x101AE20", VA = "0x1101C020")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700034C")]
    public bool HasGutsPopup
    {
      [Token(Token = "0x60032C8"), Address(RVA = "0x101BF30", Offset = "0x101AD30", VA = "0x1101BF30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60032C9")]
    [Address(RVA = "0x1005950", Offset = "0x1004750", VA = "0x11005950")]
    public void PopupMiss(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032CA")]
    [Address(RVA = "0x1005F40", Offset = "0x1004D40", VA = "0x11005F40")]
    public void PopupPefectAvoid(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032CB")]
    [Address(RVA = "0x1005750", Offset = "0x1004550", VA = "0x11005750")]
    public void PopupGuard(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032CC")]
    [Address(RVA = "0x1004ED0", Offset = "0x1003CD0", VA = "0x11004ED0")]
    public void PopupAbsorb(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032CD")]
    [Address(RVA = "0x1005310", Offset = "0x1004110", VA = "0x11005310")]
    public void PopupCritical(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032CE")]
    [Address(RVA = "0x1004FB0", Offset = "0x1003DB0", VA = "0x11004FB0")]
    public void PopupBackstab(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032CF")]
    [Address(RVA = "0x1006100", Offset = "0x1004F00", VA = "0x11006100")]
    public void PopupWeak(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032D0")]
    [Address(RVA = "0x1006020", Offset = "0x1004E20", VA = "0x11006020")]
    public void PopupResist(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032D1")]
    [Address(RVA = "0x1005830", Offset = "0x1004630", VA = "0x11005830")]
    public void PopupGuts(Vector3 position, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032D2")]
    [Address(RVA = "0x10055E0", Offset = "0x10043E0", VA = "0x110055E0")]
    public void PopupGoodJob(Vector3 position, GameObject prefab, Sprite sprite = null)
    {
    }

    [Token(Token = "0x60032D3")]
    [Address(RVA = "0xFF4240", Offset = "0xFF3040", VA = "0x10FF4240")]
    private Transform CreateParamChangeEffect(ParamTypes type, bool isDebuff) => (Transform) null;

    [Token(Token = "0x60032D4")]
    [Address(RVA = "0xFF1900", Offset = "0xFF0700", VA = "0x10FF1900")]
    private Transform CreateEffectChangeCT(int val) => (Transform) null;

    [Token(Token = "0x60032D5")]
    [Address(RVA = "0x1005C00", Offset = "0x1004A00", VA = "0x11005C00")]
    public void PopupParamChange(
      Vector3 position,
      BuffBit buff,
      BuffBit debuff,
      int ct_change_val = 0)
    {
    }

    [Token(Token = "0x60032D6")]
    [Address(RVA = "0xFF1370", Offset = "0xFF0170", VA = "0x10FF1370")]
    private Transform CreateConditionChangeEffect(EUnitCondition condition) => (Transform) null;

    [Token(Token = "0x60032D7")]
    [Address(RVA = "0x1005090", Offset = "0x1003E90", VA = "0x11005090")]
    public void PopupConditionChange(Vector3 position, EUnitCondition fails)
    {
    }

    [Token(Token = "0x60032D8")]
    [Address(RVA = "0x100ED80", Offset = "0x100DB80", VA = "0x1100ED80")]
    public void ShowSkillNamePlate(Unit unit, SkillData skill, string skill_name = "", float speed = 1f)
    {
    }

    [Token(Token = "0x60032D9")]
    [Address(RVA = "0x100EEB0", Offset = "0x100DCB0", VA = "0x1100EEB0")]
    public void ShowSkillNamePlate(string skill_name, EUnitSide side = EUnitSide.Player, float speed = 1f)
    {
    }

    [Token(Token = "0x60032DA")]
    [Address(RVA = "0xFFFA80", Offset = "0xFFE880", VA = "0x10FFFA80")]
    public bool IsClosedSkillNamePlate() => new bool();

    [Token(Token = "0x60032DB")]
    [Address(RVA = "0x100EC00", Offset = "0x100DA00", VA = "0x1100EC00")]
    public void ShowInspirationTelopPlate(float disp_time, float speed = 1f)
    {
    }

    [Token(Token = "0x60032DC")]
    [Address(RVA = "0x1004E00", Offset = "0x1003C00", VA = "0x11004E00")]
    public static void Popup2D(GameObject go, Vector3 position, int priority = 0, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032DD")]
    [Address(RVA = "0xFFE930", Offset = "0xFFD730", VA = "0x10FFE930")]
    private void InternalPopup2D(GameObject go, Vector3 position, int priority, float yOffset = 0.0f)
    {
    }

    [Token(Token = "0x60032DE")]
    [Address(RVA = "0x1000560", Offset = "0xFFF360", VA = "0x11000560")]
    private void LayoutPopups(UnityEngine.Camera cam)
    {
    }

    [Token(Token = "0x60032DF")]
    [Address(RVA = "0xFFFE60", Offset = "0xFFEC60", VA = "0x10FFFE60")]
    private void LayoutGauges(UnityEngine.Camera cam)
    {
    }

    [Token(Token = "0x1700034D")]
    public bool UISignal
    {
      [Token(Token = "0x60032E0"), Address(RVA = "0x2AABC0", Offset = "0x2A99C0", VA = "0x102AABC0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60032E1"), Address(RVA = "0x61C720", Offset = "0x61B520", VA = "0x1061C720")] set
      {
      }
    }

    [Token(Token = "0x60032E2")]
    [Address(RVA = "0x100DE20", Offset = "0x100CC20", VA = "0x1100DE20")]
    private void SetPrioritizedUnit(TacticsUnitController controller)
    {
    }

    [Token(Token = "0x60032E3")]
    [Address(RVA = "0x100DF30", Offset = "0x100CD30", VA = "0x1100DF30")]
    private void SetPrioritizedUnits(List<TacticsUnitController> controllers)
    {
    }

    [Token(Token = "0x60032E4")]
    [Address(RVA = "0x10178E0", Offset = "0x10166E0", VA = "0x110178E0")]
    private void ToggleRenkeiAura(bool visible)
    {
    }

    [Token(Token = "0x60032E5")]
    [Address(RVA = "0x1002CB0", Offset = "0x1001AB0", VA = "0x11002CB0")]
    private void OnDrag()
    {
    }

    [Token(Token = "0x60032E6")]
    [Address(RVA = "0x1002B90", Offset = "0x1001990", VA = "0x11002B90")]
    private void OnDragEnd()
    {
    }

    [Token(Token = "0x60032E7")]
    [Address(RVA = "0x1017840", Offset = "0x1016640", VA = "0x11017840")]
    private void ToggleJumpSpots(bool visible)
    {
    }

    [Token(Token = "0x60032E8")]
    [Address(RVA = "0x1009220", Offset = "0x1008020", VA = "0x11009220")]
    private void RefreshJumpSpots()
    {
    }

    [Token(Token = "0x60032E9")]
    [Address(RVA = "0xFFAB10", Offset = "0xFF9910", VA = "0x10FFAB10")]
    public GameObject GetJumpSpotEffect(Unit unit) => (GameObject) null;

    [Token(Token = "0x60032EA")]
    [Address(RVA = "0x10012F0", Offset = "0x10000F0", VA = "0x110012F0")]
    private void LoadShieldEffects()
    {
    }

    [Token(Token = "0x60032EB")]
    [Address(RVA = "0x1001280", Offset = "0x1000080", VA = "0x11001280")]
    private IEnumerator LoadShieldEffectsAsync(List<SkillParam> skills) => (IEnumerator) null;

    [Token(Token = "0x60032EC")]
    [Address(RVA = "0x1010B90", Offset = "0x100F990", VA = "0x11010B90")]
    private GameObject SpawnShieldEffect(
      TacticsUnitController unit,
      SkillParam skill,
      int value,
      int valueMax,
      int turn,
      int turnMax)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60032ED")]
    [Address(RVA = "0x101B2F0", Offset = "0x101A0F0", VA = "0x1101B2F0")]
    public SceneBattle()
    {
    }

    [Token(Token = "0x60032EE")]
    [Address(RVA = "0x101B1D0", Offset = "0x1019FD0", VA = "0x1101B1D0")]
    static SceneBattle()
    {
    }

    [Token(Token = "0x2000C7E")]
    public class MoveInput
    {
      [Token(Token = "0x400231B")]
      [FieldOffset(Offset = "0x8")]
      public SceneBattle SceneOwner;
      [Token(Token = "0x400231C")]
      [FieldOffset(Offset = "0xC")]
      public SceneBattle.MoveInput.TargetSelectEvent OnAttackTargetSelect;

      [Token(Token = "0x60032F5")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public virtual void MoveUnit(Vector3 target_screen_pos)
      {
      }

      [Token(Token = "0x60032F6")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
      public virtual void Start()
      {
      }

      [Token(Token = "0x60032F7")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void End()
      {
      }

      [Token(Token = "0x1700034E")]
      public virtual bool IsBusy
      {
        [Token(Token = "0x60032F8"), Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "7")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x60032F9")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Reset()
      {
      }

      [Token(Token = "0x60032FA")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
      public virtual void Update()
      {
      }

      [Token(Token = "0x60032FB")]
      [Address(RVA = "0x10232A0", Offset = "0x10220A0", VA = "0x110232A0")]
      protected void SelectAttackTarget(Unit unit)
      {
      }

      [Token(Token = "0x60032FC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MoveInput()
      {
      }

      [Token(Token = "0x2000C7F")]
      public delegate void TargetSelectEvent(Unit unit);
    }

    [Token(Token = "0x2000C80")]
    public class SimpleEvent
    {
      [Token(Token = "0x400231D")]
      [FieldOffset(Offset = "0x0")]
      private static Dictionary<int, SceneBattle.SimpleEvent.Interface> m_Group;

      [Token(Token = "0x6003301")]
      [Address(RVA = "0x1024990", Offset = "0x1023790", VA = "0x11024990")]
      public static void Clear()
      {
      }

      [Token(Token = "0x6003302")]
      [Address(RVA = "0x10249F0", Offset = "0x10237F0", VA = "0x110249F0")]
      public static bool HasGroup(int group) => new bool();

      [Token(Token = "0x6003303")]
      [Address(RVA = "0x1024AD0", Offset = "0x10238D0", VA = "0x11024AD0")]
      public static void Send(int group, string key, object obj)
      {
      }

      [Token(Token = "0x6003304")]
      [Address(RVA = "0x10248B0", Offset = "0x10236B0", VA = "0x110248B0")]
      public static void Add(int group, SceneBattle.SimpleEvent.Interface inst)
      {
      }

      [Token(Token = "0x6003305")]
      [Address(RVA = "0x1024A60", Offset = "0x1023860", VA = "0x11024A60")]
      public static void Remove(int group)
      {
      }

      [Token(Token = "0x6003306")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SimpleEvent()
      {
      }

      [Token(Token = "0x6003307")]
      [Address(RVA = "0x1024BC0", Offset = "0x10239C0", VA = "0x11024BC0")]
      static SimpleEvent()
      {
      }

      [Token(Token = "0x2000C81")]
      public interface Interface
      {
        [Token(Token = "0x6003308")]
        void OnEvent(string key, object obj);
      }
    }

    [Token(Token = "0x2000C82")]
    private enum eArenaSubmitMode
    {
      [Token(Token = "0x400231F")] BUSY,
      [Token(Token = "0x4002320")] SUCCESS,
      [Token(Token = "0x4002321")] FAILED,
    }

    [Token(Token = "0x2000C83")]
    public enum StateTransitionTypes
    {
      [Token(Token = "0x4002323")] Forward,
      [Token(Token = "0x4002324")] Back,
    }

    [Token(Token = "0x2000C84")]
    public delegate void StateTransitionRequest(SceneBattle.StateTransitionTypes type);

    [Token(Token = "0x2000C85")]
    private class State_ReqBtlComReq : State<SceneBattle>
    {
      [Token(Token = "0x4002325")]
      [FieldOffset(Offset = "0xC")]
      private GUIEventListener mGUIEvent;
      [Token(Token = "0x4002326")]
      [FieldOffset(Offset = "0x10")]
      private bool mShowInventory;
      [Token(Token = "0x4002327")]
      [FieldOffset(Offset = "0x14")]
      private Vector2 mInventoryScrollPos;
      [Token(Token = "0x4002328")]
      [FieldOffset(Offset = "0x1C")]
      private int mSelectChangeInventoryIndex;
      [Token(Token = "0x4002329")]
      [FieldOffset(Offset = "0x20")]
      private bool mShowArtifact;
      [Token(Token = "0x400232A")]
      [FieldOffset(Offset = "0x24")]
      private int mArtifactTab;
      [Token(Token = "0x400232B")]
      [FieldOffset(Offset = "0x28")]
      private int mSelectChangeArtifactUnitIndex;
      [Token(Token = "0x400232C")]
      [FieldOffset(Offset = "0x2C")]
      private int mSelectChangeArtifactJobIndex;
      [Token(Token = "0x400232D")]
      [FieldOffset(Offset = "0x30")]
      private int mSelectChangeArtifactIndex;
      [Token(Token = "0x400232E")]
      [FieldOffset(Offset = "0x34")]
      private string mFindQuestName;
      [Token(Token = "0x400232F")]
      [FieldOffset(Offset = "0x38")]
      private List<string> mQuestHistoryIds;
      [Token(Token = "0x4002330")]
      [FieldOffset(Offset = "0x3C")]
      private bool mShowHistory;
      [Token(Token = "0x4002331")]
      private const int HistoryMax = 10;
      [Token(Token = "0x4002332")]
      [FieldOffset(Offset = "0x40")]
      private List<QuestParam> QuestParamList;
      [Token(Token = "0x4002333")]
      [FieldOffset(Offset = "0x44")]
      private int mQuestFilterFlg;
      [Token(Token = "0x4002334")]
      [FieldOffset(Offset = "0x0")]
      private static readonly SceneBattle.State_ReqBtlComReq.EQuestFilter[] mQuestFilters;
      [Token(Token = "0x4002335")]
      [FieldOffset(Offset = "0x4")]
      private static readonly string[] mQuestFilterNames;
      [Token(Token = "0x4002336")]
      [FieldOffset(Offset = "0x48")]
      private bool[] mHitQuests;
      [Token(Token = "0x4002337")]
      [FieldOffset(Offset = "0x4C")]
      private List<QuestParam> mQuestList;

      [Token(Token = "0x600330D")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600330E")]
      [Address(RVA = "0x102A490", Offset = "0x1029290", VA = "0x1102A490", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600330F")]
      [Address(RVA = "0x102A570", Offset = "0x1029370", VA = "0x1102A570", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003310")]
      [Address(RVA = "0x102A540", Offset = "0x1029340", VA = "0x1102A540")]
      private void SetQuestFilter(SceneBattle.State_ReqBtlComReq.EQuestFilter type, bool flag)
      {
      }

      [Token(Token = "0x6003311")]
      [Address(RVA = "0x102A520", Offset = "0x1029320", VA = "0x1102A520")]
      private bool GetQuestFilter(SceneBattle.State_ReqBtlComReq.EQuestFilter type) => new bool();

      [Token(Token = "0x6003312")]
      [Address(RVA = "0x102A360", Offset = "0x1029160", VA = "0x1102A360")]
      private void AddHistory(string newIdName)
      {
      }

      [Token(Token = "0x6003313")]
      [Address(RVA = "0x102A430", Offset = "0x1029230", VA = "0x1102A430")]
      private void CreateSaveHistory()
      {
      }

      [Token(Token = "0x6003314")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
      private void OnGUI(GameObject go)
      {
      }

      [Token(Token = "0x6003315")]
      [Address(RVA = "0x102AB70", Offset = "0x1029970", VA = "0x1102AB70")]
      public State_ReqBtlComReq()
      {
      }

      [Token(Token = "0x6003316")]
      [Address(RVA = "0x102A700", Offset = "0x1029500", VA = "0x1102A700")]
      static State_ReqBtlComReq()
      {
      }

      [Token(Token = "0x2000C86")]
      private enum EQuestFilter
      {
        [Token(Token = "0x4002339")] Story = 1,
        [Token(Token = "0x400233A")] Seiseki = 2,
        [Token(Token = "0x400233B")] Babel = 4,
        [Token(Token = "0x400233C")] Genesis = 8,
        [Token(Token = "0x400233D")] Event = 16, // 0x00000010
        [Token(Token = "0x400233E")] Chara = 32, // 0x00000020
        [Token(Token = "0x400233F")] Advance = 64, // 0x00000040
        [Token(Token = "0x4002340")] Multi = 128, // 0x00000080
        [Token(Token = "0x4002341")] Tower = 256, // 0x00000100
        [Token(Token = "0x4002342")] Raid = 512, // 0x00000200
        [Token(Token = "0x4002343")] Other = 1024, // 0x00000400
      }
    }

    [Token(Token = "0x2000C87")]
    private class State_Start : State<SceneBattle>
    {
      [Token(Token = "0x6003317")]
      [Address(RVA = "0x102AC30", Offset = "0x1029A30", VA = "0x1102AC30", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003318")]
      [Address(RVA = "0x102AE40", Offset = "0x1029C40", VA = "0x1102AE40")]
      private IEnumerator LoadAndExecuteEvent(string eventName) => (IEnumerator) null;

      [Token(Token = "0x6003319")]
      [Address(RVA = "0x102AD20", Offset = "0x1029B20", VA = "0x1102AD20")]
      private void GotoNextState()
      {
      }

      [Token(Token = "0x600331A")]
      [Address(RVA = "0x102AEB0", Offset = "0x1029CB0", VA = "0x1102AEB0")]
      public State_Start()
      {
      }
    }

    [Token(Token = "0x2000C89")]
    private class State_InitUI : State<SceneBattle>
    {
      [Token(Token = "0x400234A")]
      [FieldOffset(Offset = "0xC")]
      private float mWait;
      [Token(Token = "0x400234B")]
      [FieldOffset(Offset = "0x10")]
      private float mElapsed;
      [Token(Token = "0x400234C")]
      [FieldOffset(Offset = "0x14")]
      private bool mLoaded;

      [Token(Token = "0x6003321")]
      [Address(RVA = "0x1025F10", Offset = "0x1024D10", VA = "0x11025F10", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003322")]
      [Address(RVA = "0x1025FD0", Offset = "0x1024DD0", VA = "0x11025FD0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003323")]
      [Address(RVA = "0x10260A0", Offset = "0x1024EA0", VA = "0x110260A0")]
      public State_InitUI()
      {
      }
    }

    [Token(Token = "0x2000C8A")]
    private class State_WaitForLog : State<SceneBattle>
    {
      [Token(Token = "0x6003324")]
      [Address(RVA = "0x102AF00", Offset = "0x1029D00", VA = "0x1102AF00")]
      private bool CheckShieldEffect() => new bool();

      [Token(Token = "0x6003325")]
      [Address(RVA = "0x102B030", Offset = "0x1029E30", VA = "0x1102B030", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003326")]
      [Address(RVA = "0x102C400", Offset = "0x102B200", VA = "0x1102C400")]
      public State_WaitForLog()
      {
      }
    }

    [Token(Token = "0x2000C8C")]
    private class State_Error : State<SceneBattle>
    {
      [Token(Token = "0x600332A")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600332B")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600332C")]
      [Address(RVA = "0x1025740", Offset = "0x1024540", VA = "0x11025740", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600332D")]
      [Address(RVA = "0x1025880", Offset = "0x1024680", VA = "0x11025880")]
      public State_Error()
      {
      }
    }

    [Token(Token = "0x2000C8D")]
    private class State_Connect : State<SceneBattle>
    {
      [Token(Token = "0x600332E")]
      [Address(RVA = "0x1025740", Offset = "0x1024540", VA = "0x11025740", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600332F")]
      [Address(RVA = "0x1025760", Offset = "0x1024560", VA = "0x11025760", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003330")]
      [Address(RVA = "0x1025840", Offset = "0x1024640", VA = "0x11025840")]
      public State_Connect()
      {
      }
    }

    [Token(Token = "0x2000C8E")]
    private class State_QuestStartV2 : State<SceneBattle>
    {
      [Token(Token = "0x4002350")]
      [FieldOffset(Offset = "0xC")]
      private bool is_call_map_start;

      [Token(Token = "0x6003331")]
      [Address(RVA = "0x102A2F0", Offset = "0x10290F0", VA = "0x1102A2F0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003332")]
      [Address(RVA = "0x102A320", Offset = "0x1029120", VA = "0x1102A320")]
      public State_QuestStartV2()
      {
      }
    }

    [Token(Token = "0x2000C8F")]
    private class State_MapCommandAI : State<SceneBattle>
    {
      [Token(Token = "0x6003333")]
      [Address(RVA = "0x10260E0", Offset = "0x1024EE0", VA = "0x110260E0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003334")]
      [Address(RVA = "0x1026170", Offset = "0x1024F70", VA = "0x11026170", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003335")]
      [Address(RVA = "0x1026230", Offset = "0x1025030", VA = "0x11026230")]
      public State_MapCommandAI()
      {
      }
    }

    [Token(Token = "0x2000C90")]
    private class State_MapCommandMultiPlay : State<SceneBattle>
    {
      [Token(Token = "0x6003336")]
      [Address(RVA = "0x1026270", Offset = "0x1025070", VA = "0x11026270", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003337")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003338")]
      [Address(RVA = "0x1026300", Offset = "0x1025100", VA = "0x11026300")]
      private void SyncCameraPosition(SceneBattle self)
      {
      }

      [Token(Token = "0x6003339")]
      [Address(RVA = "0x10264E0", Offset = "0x10252E0", VA = "0x110264E0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600333A")]
      [Address(RVA = "0x1026550", Offset = "0x1025350", VA = "0x11026550")]
      public State_MapCommandMultiPlay()
      {
      }
    }

    [Token(Token = "0x2000C91")]
    public class CloseBattleUIWindow
    {
      [Token(Token = "0x4002351")]
      [FieldOffset(Offset = "0x8")]
      public List<Win_Btn_Decide_Title_Flx> mMsgBox;
      [Token(Token = "0x4002352")]
      [FieldOffset(Offset = "0xC")]
      public List<Win_Btn_DecideCancel_FL_C> mYesNoDlg;

      [Token(Token = "0x600333B")]
      [Address(RVA = "0x101EC60", Offset = "0x101DA60", VA = "0x1101EC60")]
      public void Add(GameObject go)
      {
      }

      [Token(Token = "0x600333C")]
      [Address(RVA = "0x101ED90", Offset = "0x101DB90", VA = "0x1101ED90")]
      public void CloseAll()
      {
      }

      [Token(Token = "0x600333D")]
      [Address(RVA = "0x101F030", Offset = "0x101DE30", VA = "0x1101F030")]
      public CloseBattleUIWindow()
      {
      }
    }

    [Token(Token = "0x2000C92")]
    private class ChargeTarget
    {
      [Token(Token = "0x4002353")]
      [FieldOffset(Offset = "0x8")]
      public Unit mUnit;
      [Token(Token = "0x4002354")]
      [FieldOffset(Offset = "0xC")]
      public uint mAttr;

      [Token(Token = "0x600333E")]
      [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
      public ChargeTarget(Unit unit, uint attr)
      {
      }

      [Token(Token = "0x600333F")]
      [Address(RVA = "0x101EC50", Offset = "0x101DA50", VA = "0x1101EC50")]
      public void AddAttr(uint attr)
      {
      }
    }

    [Token(Token = "0x2000C93")]
    private class State_MapWait : State<SceneBattle>
    {
      [Token(Token = "0x6003340")]
      [Address(RVA = "0x1029570", Offset = "0x1028370", VA = "0x11029570", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003341")]
      [Address(RVA = "0x10295A0", Offset = "0x10283A0", VA = "0x110295A0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003342")]
      [Address(RVA = "0x1025740", Offset = "0x1024540", VA = "0x11025740", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003343")]
      [Address(RVA = "0x10296E0", Offset = "0x10284E0", VA = "0x110296E0")]
      public State_MapWait()
      {
      }
    }

    [Token(Token = "0x2000C94")]
    private class State_MapMoveSelect_Stick : State<SceneBattle>
    {
      [Token(Token = "0x4002355")]
      [FieldOffset(Offset = "0xC")]
      private SceneBattle mScene;
      [Token(Token = "0x4002356")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController mController;
      [Token(Token = "0x4002357")]
      [FieldOffset(Offset = "0x14")]
      private Vector3 mTapStart;
      [Token(Token = "0x4002358")]
      [FieldOffset(Offset = "0x20")]
      private float mPressTime;
      [Token(Token = "0x4002359")]
      [FieldOffset(Offset = "0x24")]
      private bool mTapped;
      [Token(Token = "0x400235A")]
      [FieldOffset(Offset = "0x28")]
      private GridMap<int> mAccessMap;
      [Token(Token = "0x400235B")]
      [FieldOffset(Offset = "0x2C")]
      private GridMap<int> mWalkableField;
      [Token(Token = "0x400235C")]
      [FieldOffset(Offset = "0x30")]
      private Vector3 mStart;
      [Token(Token = "0x400235D")]
      [FieldOffset(Offset = "0x3C")]
      private bool mAllowTap;
      [Token(Token = "0x400235E")]
      [FieldOffset(Offset = "0x40")]
      private int mDestX;
      [Token(Token = "0x400235F")]
      [FieldOffset(Offset = "0x44")]
      private int mDestY;
      [Token(Token = "0x4002360")]
      [FieldOffset(Offset = "0x48")]
      private Grid mStartGrid;
      [Token(Token = "0x4002361")]
      [FieldOffset(Offset = "0x4C")]
      private Vector2 mBasePos;
      [Token(Token = "0x4002362")]
      [FieldOffset(Offset = "0x54")]
      private Vector2 mTargetPos;
      [Token(Token = "0x4002363")]
      [FieldOffset(Offset = "0x5C")]
      private bool mTargetSet;
      [Token(Token = "0x4002364")]
      [FieldOffset(Offset = "0x5D")]
      private bool mMoveStarted;
      [Token(Token = "0x4002365")]
      [FieldOffset(Offset = "0x5E")]
      private bool mClickedOK;
      [Token(Token = "0x4002366")]
      [FieldOffset(Offset = "0x60")]
      private float mGridSnapTime;
      [Token(Token = "0x4002367")]
      [FieldOffset(Offset = "0x64")]
      private bool mJumping;
      [Token(Token = "0x4002368")]
      [FieldOffset(Offset = "0x65")]
      private bool mMoving;
      [Token(Token = "0x4002369")]
      [FieldOffset(Offset = "0x66")]
      private bool mHasDesiredRotation;
      [Token(Token = "0x400236A")]
      [FieldOffset(Offset = "0x67")]
      private bool mGridSnapping;
      [Token(Token = "0x400236B")]
      [FieldOffset(Offset = "0x68")]
      private Quaternion mDesiredRotation;
      [Token(Token = "0x400236C")]
      private const float STOP_RADIUS = 0.1f;

      [Token(Token = "0x6003344")]
      [Address(RVA = "0x1028050", Offset = "0x1026E50", VA = "0x11028050")]
      private void Reset()
      {
      }

      [Token(Token = "0x6003345")]
      [Address(RVA = "0x1027550", Offset = "0x1026350", VA = "0x11027550", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003346")]
      [Address(RVA = "0x1027C70", Offset = "0x1026A70", VA = "0x11027C70")]
      private void OnStateChange(SceneBattle.StateTransitionTypes transition)
      {
      }

      [Token(Token = "0x6003347")]
      [Address(RVA = "0x1027A10", Offset = "0x1026810", VA = "0x11027A10", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003348")]
      [Address(RVA = "0x1027C40", Offset = "0x1026A40", VA = "0x11027C40")]
      private bool IsGridBlocked(Vector2 co) => new bool();

      [Token(Token = "0x6003349")]
      [Address(RVA = "0x1027B00", Offset = "0x1026900", VA = "0x11027B00")]
      private bool IsGridBlocked(float x, float y) => new bool();

      [Token(Token = "0x600334A")]
      [Address(RVA = "0x1027980", Offset = "0x1026780", VA = "0x11027980")]
      private bool CanMoveToAdj(Vector2 from, Vector2 to) => new bool();

      [Token(Token = "0x600334B")]
      [Address(RVA = "0x1027920", Offset = "0x1026720", VA = "0x11027920")]
      private bool CanMoveToAdjDirect(Vector2 from, Vector2 to) => new bool();

      [Token(Token = "0x600334C")]
      [Address(RVA = "0x1027AB0", Offset = "0x10268B0", VA = "0x11027AB0")]
      private bool GridEqualIn2D(Vector2 a, Vector2 b) => new bool();

      [Token(Token = "0x600334D")]
      [Address(RVA = "0x1026F90", Offset = "0x1025D90", VA = "0x11026F90")]
      private void AdjustTargetPos(
        ref Vector2 basePos,
        ref Vector2 targetPos,
        Vector2 inputDir,
        Vector2 unitPos)
      {
      }

      [Token(Token = "0x17000351")]
      private Vector2 Velocity
      {
        [Token(Token = "0x600334E"), Address(RVA = "0x1029480", Offset = "0x1028280", VA = "0x11029480")] get
        {
          return new Vector2();
        }
      }

      [Token(Token = "0x600334F")]
      [Address(RVA = "0x10280E0", Offset = "0x1026EE0", VA = "0x110280E0")]
      private void SyncCameraPosition()
      {
      }

      [Token(Token = "0x6003350")]
      [Address(RVA = "0x1028110", Offset = "0x1026F10", VA = "0x11028110", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003351")]
      [Address(RVA = "0x10293D0", Offset = "0x10281D0", VA = "0x110293D0")]
      public State_MapMoveSelect_Stick()
      {
      }
    }

    [Token(Token = "0x2000C95")]
    private class State_AnimateMove : State<SceneBattle>
    {
      [Token(Token = "0x400236D")]
      [FieldOffset(Offset = "0xC")]
      private Unit mMovingUnit;
      [Token(Token = "0x400236E")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController mController;
      [Token(Token = "0x400236F")]
      [FieldOffset(Offset = "0x14")]
      private bool mMoveUnit;
      [Token(Token = "0x4002370")]
      [FieldOffset(Offset = "0x18")]
      private Vector3 mStartPosition;
      [Token(Token = "0x4002371")]
      [FieldOffset(Offset = "0x24")]
      private Vector3 mEndPosition;
      [Token(Token = "0x4002372")]
      [FieldOffset(Offset = "0x30")]
      private float mWaitCount;

      [Token(Token = "0x6003352")]
      [Address(RVA = "0x1024CA0", Offset = "0x1023AA0", VA = "0x11024CA0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003353")]
      [Address(RVA = "0x1025500", Offset = "0x1024300", VA = "0x11025500", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003354")]
      [Address(RVA = "0x1025020", Offset = "0x1023E20", VA = "0x11025020")]
      private void Move()
      {
      }

      [Token(Token = "0x6003355")]
      [Address(RVA = "0x1025700", Offset = "0x1024500", VA = "0x11025700")]
      public State_AnimateMove()
      {
      }
    }

    [Token(Token = "0x2000C96")]
    private class State_EventMapDead : State<SceneBattle>
    {
      [Token(Token = "0x4002373")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mController;

      [Token(Token = "0x6003356")]
      [Address(RVA = "0x10258C0", Offset = "0x10246C0", VA = "0x110258C0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003357")]
      [Address(RVA = "0x1025E40", Offset = "0x1024C40", VA = "0x11025E40", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003358")]
      [Address(RVA = "0x1025ED0", Offset = "0x1024CD0", VA = "0x11025ED0")]
      public State_EventMapDead()
      {
      }
    }

    [Token(Token = "0x2000C97")]
    private class State_MapDead : State<SceneBattle>
    {
      [Token(Token = "0x4002374")]
      [FieldOffset(Offset = "0xC")]
      private List<SceneBattle.State_MapDead.DirectionBase> mList;

      [Token(Token = "0x17000352")]
      public List<SceneBattle.State_MapDead.DirectionBase> list
      {
        [Token(Token = "0x6003359"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (List<SceneBattle.State_MapDead.DirectionBase>) null;
        }
      }

      [Token(Token = "0x600335A")]
      [Address(RVA = "0x1026590", Offset = "0x1025390", VA = "0x11026590", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600335B")]
      [Address(RVA = "0x1026CB0", Offset = "0x1025AB0", VA = "0x11026CB0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600335C")]
      [Address(RVA = "0x1026BF0", Offset = "0x10259F0", VA = "0x11026BF0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600335D")]
      [Address(RVA = "0x1026F10", Offset = "0x1025D10", VA = "0x11026F10")]
      public State_MapDead()
      {
      }

      [Token(Token = "0x2000C98")]
      public class DirectionBase
      {
        [Token(Token = "0x4002375")]
        [FieldOffset(Offset = "0x8")]
        private SceneBattle mSceneBattle;
        [Token(Token = "0x4002376")]
        [FieldOffset(Offset = "0xC")]
        private SceneBattle.State_MapDead mState;
        [Token(Token = "0x4002377")]
        [FieldOffset(Offset = "0x10")]
        private int mPriority;
        [Token(Token = "0x4002378")]
        [FieldOffset(Offset = "0x14")]
        private bool mDeleteFlag;
        [Token(Token = "0x4002379")]
        [FieldOffset(Offset = "0x18")]
        private SceneBattle.State_MapDead.DirectionBase.Proc mProc;
        [Token(Token = "0x400237A")]
        [FieldOffset(Offset = "0x1C")]
        private int mProcCount;

        [Token(Token = "0x17000353")]
        public SceneBattle scene
        {
          [Token(Token = "0x600335E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (SceneBattle) null;
          }
        }

        [Token(Token = "0x17000354")]
        public SceneBattle.State_MapDead state
        {
          [Token(Token = "0x600335F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (SceneBattle.State_MapDead) null;
          }
        }

        [Token(Token = "0x6003360")]
        [Address(RVA = "0x101EA40", Offset = "0x101D840", VA = "0x1101EA40")]
        public DirectionBase(SceneBattle self, SceneBattle.State_MapDead state)
        {
        }

        [Token(Token = "0x6003361")]
        [Address(RVA = "0x1021630", Offset = "0x1020430", VA = "0x11021630")]
        public bool Update() => new bool();

        [Token(Token = "0x6003362")]
        [Address(RVA = "0x2CE1B0", Offset = "0x2CCFB0", VA = "0x102CE1B0")]
        public void Delete()
        {
        }

        [Token(Token = "0x6003363")]
        [Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")]
        public void SetPriority(int pri)
        {
        }

        [Token(Token = "0x6003364")]
        [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
        public int GetPriority() => new int();

        [Token(Token = "0x6003365")]
        [Address(RVA = "0x1021610", Offset = "0x1020410", VA = "0x11021610")]
        protected void SetProc(SceneBattle.State_MapDead.DirectionBase.Proc proc)
        {
        }

        [Token(Token = "0x6003366")]
        [Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")]
        protected SceneBattle.State_MapDead.DirectionBase.Proc GetProc()
        {
          return new SceneBattle.State_MapDead.DirectionBase.Proc();
        }

        [Token(Token = "0x6003367")]
        [Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")]
        protected int GetProcCount() => new int();

        [Token(Token = "0x6003368")]
        [Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")]
        protected void SetProcCount(int value)
        {
        }

        [Token(Token = "0x6003369")]
        [Address(RVA = "0x8E18F0", Offset = "0x8E06F0", VA = "0x108E18F0")]
        protected void IncProcCount()
        {
        }

        [Token(Token = "0x600336A")]
        [Address(RVA = "0x1021600", Offset = "0x1020400", VA = "0x11021600")]
        protected void DecProcCount()
        {
        }

        [Token(Token = "0x600336B")]
        [Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0", Slot = "4")]
        public virtual void Initialize(int priority)
        {
        }

        [Token(Token = "0x600336C")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
        public virtual void Release()
        {
        }

        [Token(Token = "0x600336D")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
        protected virtual void OnPrepare()
        {
        }

        [Token(Token = "0x600336E")]
        [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "7")]
        protected virtual bool OnLoading() => new bool();

        [Token(Token = "0x600336F")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
        protected virtual void OnBegin()
        {
        }

        [Token(Token = "0x6003370")]
        [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "9")]
        protected virtual bool OnMain() => new bool();

        [Token(Token = "0x6003371")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")]
        protected virtual void OnEnd()
        {
        }

        [Token(Token = "0x2000C99")]
        protected enum Proc
        {
          [Token(Token = "0x400237C")] PREPARE,
          [Token(Token = "0x400237D")] BEGIN,
          [Token(Token = "0x400237E")] MAIN,
          [Token(Token = "0x400237F")] END,
        }
      }

      [Token(Token = "0x2000C9A")]
      public class Camera : SceneBattle.State_MapDead.DirectionBase
      {
        [Token(Token = "0x4002380")]
        [FieldOffset(Offset = "0x20")]
        protected Vector3 m_Center;
        [Token(Token = "0x4002381")]
        [FieldOffset(Offset = "0x2C")]
        protected float m_Distance;

        [Token(Token = "0x6003372")]
        [Address(RVA = "0x101EA40", Offset = "0x101D840", VA = "0x1101EA40")]
        public Camera(SceneBattle self, SceneBattle.State_MapDead state)
        {
        }

        [Token(Token = "0x6003373")]
        [Address(RVA = "0x101EA90", Offset = "0x101D890", VA = "0x1101EA90")]
        public void Initialize(int priority, Vector3[] targets)
        {
        }

        [Token(Token = "0x6003374")]
        [Address(RVA = "0x101EAC0", Offset = "0x101D8C0", VA = "0x1101EAC0", Slot = "8")]
        protected override void OnBegin()
        {
        }

        [Token(Token = "0x6003375")]
        [Address(RVA = "0x101EB20", Offset = "0x101D920", VA = "0x1101EB20", Slot = "9")]
        protected override bool OnMain() => new bool();

        [Token(Token = "0x2000C9B")]
        public class Normal : SceneBattle.State_MapDead.Camera
        {
          [Token(Token = "0x6003376")]
          [Address(RVA = "0x101EA40", Offset = "0x101D840", VA = "0x1101EA40")]
          public Normal(SceneBattle self, SceneBattle.State_MapDead state)
          {
          }
        }
      }

      [Token(Token = "0x2000C9C")]
      public class Dead : SceneBattle.State_MapDead.DirectionBase
      {
        [Token(Token = "0x4002382")]
        [FieldOffset(Offset = "0x20")]
        protected TacticsUnitController mController;
        [Token(Token = "0x4002383")]
        [FieldOffset(Offset = "0x24")]
        protected Unit mUnit;
        [Token(Token = "0x4002384")]
        [FieldOffset(Offset = "0x28")]
        protected DeadTypes mDeadType;
        [Token(Token = "0x4002385")]
        [FieldOffset(Offset = "0x2C")]
        protected bool mIsRevival;

        [Token(Token = "0x17000355")]
        public TacticsUnitController controller
        {
          [Token(Token = "0x6003377"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
          {
            return (TacticsUnitController) null;
          }
        }

        [Token(Token = "0x17000356")]
        public Unit unit
        {
          [Token(Token = "0x6003378"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
          {
            return (Unit) null;
          }
        }

        [Token(Token = "0x17000357")]
        public DeadTypes deadType
        {
          [Token(Token = "0x6003379"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
          {
            return new DeadTypes();
          }
        }

        [Token(Token = "0x17000358")]
        public bool IsRevival
        {
          [Token(Token = "0x600337A"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600337B")]
        [Address(RVA = "0x101EA40", Offset = "0x101D840", VA = "0x1101EA40")]
        public Dead(SceneBattle self, SceneBattle.State_MapDead state)
        {
        }

        [Token(Token = "0x600337C")]
        [Address(RVA = "0x1020840", Offset = "0x101F640", VA = "0x11020840")]
        public void Initialize(
          int priority,
          TacticsUnitController controller,
          DeadTypes deadType,
          bool isRevival)
        {
        }

        [Token(Token = "0x600337D")]
        [Address(RVA = "0x1020B10", Offset = "0x101F910", VA = "0x11020B10", Slot = "7")]
        protected override bool OnLoading() => new bool();

        [Token(Token = "0x600337E")]
        [Address(RVA = "0x1020A50", Offset = "0x101F850", VA = "0x11020A50", Slot = "8")]
        protected override void OnBegin()
        {
        }

        [Token(Token = "0x600337F")]
        [Address(RVA = "0x1020B40", Offset = "0x101F940", VA = "0x11020B40", Slot = "9")]
        protected override bool OnMain() => new bool();

        [Token(Token = "0x2000C9D")]
        public class Normal : SceneBattle.State_MapDead.Dead
        {
          [Token(Token = "0x6003380")]
          [Address(RVA = "0x101EA40", Offset = "0x101D840", VA = "0x1101EA40")]
          public Normal(SceneBattle self, SceneBattle.State_MapDead state)
          {
          }
        }

        [Token(Token = "0x2000C9E")]
        public class CameraForcus : SceneBattle.State_MapDead.Dead
        {
          [Token(Token = "0x6003381")]
          [Address(RVA = "0x101EA40", Offset = "0x101D840", VA = "0x1101EA40")]
          public CameraForcus(SceneBattle self, SceneBattle.State_MapDead state)
          {
          }

          [Token(Token = "0x6003382")]
          [Address(RVA = "0x101E9E0", Offset = "0x101D7E0", VA = "0x1101E9E0", Slot = "6")]
          protected override void OnPrepare()
          {
          }

          [Token(Token = "0x6003383")]
          [Address(RVA = "0x101E880", Offset = "0x101D680", VA = "0x1101E880", Slot = "7")]
          protected override bool OnLoading() => new bool();
        }
      }

      [Token(Token = "0x2000C9F")]
      public class TreasureDrop : SceneBattle.State_MapDead.DirectionBase
      {
        [Token(Token = "0x4002386")]
        [FieldOffset(Offset = "0x20")]
        protected Unit m_Owner;
        [Token(Token = "0x4002387")]
        [FieldOffset(Offset = "0x24")]
        protected Unit.UnitDrop m_Drop;
        [Token(Token = "0x4002388")]
        [FieldOffset(Offset = "0x28")]
        protected TreasureBox m_TreasureBox;

        [Token(Token = "0x6003384")]
        [Address(RVA = "0x101EA40", Offset = "0x101D840", VA = "0x1101EA40")]
        public TreasureDrop(SceneBattle self, SceneBattle.State_MapDead state)
        {
        }

        [Token(Token = "0x6003385")]
        [Address(RVA = "0x102C440", Offset = "0x102B240", VA = "0x1102C440")]
        public void Initialize(int priority, Unit owner, Unit.UnitDrop drop, Vector3 pos)
        {
        }

        [Token(Token = "0x6003386")]
        [Address(RVA = "0x102C5A0", Offset = "0x102B3A0", VA = "0x1102C5A0", Slot = "8")]
        protected override void OnBegin()
        {
        }

        [Token(Token = "0x6003387")]
        [Address(RVA = "0x102C6F0", Offset = "0x102B4F0", VA = "0x1102C6F0", Slot = "9")]
        protected override bool OnMain() => new bool();

        [Token(Token = "0x2000CA0")]
        public class Normal : SceneBattle.State_MapDead.TreasureDrop
        {
          [Token(Token = "0x6003388")]
          [Address(RVA = "0x101EA40", Offset = "0x101D840", VA = "0x1101EA40")]
          public Normal(SceneBattle self, SceneBattle.State_MapDead state)
          {
          }
        }
      }
    }

    [Token(Token = "0x2000CA1")]
    public class TreasureEvent : SceneBattle.SimpleEvent.Interface
    {
      [Token(Token = "0x4002389")]
      [FieldOffset(Offset = "0x0")]
      public static int GROUP;

      [Token(Token = "0x6003389")]
      [Address(RVA = "0x102C7A0", Offset = "0x102B5A0", VA = "0x1102C7A0", Slot = "4")]
      public void OnEvent(string key, object obj)
      {
      }

      [Token(Token = "0x600338A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TreasureEvent()
      {
      }

      [Token(Token = "0x600338B")]
      [Address(RVA = "0x102CA30", Offset = "0x102B830", VA = "0x1102CA30")]
      static TreasureEvent()
      {
      }
    }

    [Token(Token = "0x2000CA2")]
    private class State_MapRevive : SceneBattle.State_SpawnUnit
    {
      [Token(Token = "0x600338C")]
      [Address(RVA = "0x1029560", Offset = "0x1028360", VA = "0x11029560")]
      public State_MapRevive()
      {
      }
    }

    [Token(Token = "0x2000CA3")]
    private class State_PickupGimmick : State<SceneBattle>
    {
      [Token(Token = "0x400238A")]
      [FieldOffset(Offset = "0xC")]
      private SceneBattle mScene;
      [Token(Token = "0x400238B")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController mUnitController;
      [Token(Token = "0x400238C")]
      [FieldOffset(Offset = "0x14")]
      private TacticsUnitController mGimmickController;
      [Token(Token = "0x400238D")]
      [FieldOffset(Offset = "0x18")]
      private Unit.UnitDrop mDrop;
      [Token(Token = "0x400238E")]
      [FieldOffset(Offset = "0x1C")]
      private MapPickup mPickup;
      [Token(Token = "0x400238F")]
      [FieldOffset(Offset = "0x20")]
      private bool mLoadFinished;
      [Token(Token = "0x4002390")]
      [FieldOffset(Offset = "0x21")]
      private bool mItemDrop;
      [Token(Token = "0x4002391")]
      [FieldOffset(Offset = "0x24")]
      private LogMapEvent mLog;
      [Token(Token = "0x4002392")]
      [FieldOffset(Offset = "0x28")]
      private DropItemEffect mDropItemEffect;

      [Token(Token = "0x600338D")]
      [Address(RVA = "0x1029720", Offset = "0x1028520", VA = "0x11029720", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600338E")]
      [Address(RVA = "0x102A0D0", Offset = "0x1028ED0", VA = "0x1102A0D0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600338F")]
      [Address(RVA = "0x1029C90", Offset = "0x1028A90", VA = "0x11029C90", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003390")]
      [Address(RVA = "0x1029DB0", Offset = "0x1028BB0", VA = "0x11029DB0")]
      private void OnPickupDone()
      {
      }

      [Token(Token = "0x6003391")]
      [Address(RVA = "0x1029D50", Offset = "0x1028B50", VA = "0x11029D50")]
      private IEnumerator GemPramChangePopup() => (IEnumerator) null;

      [Token(Token = "0x6003392")]
      [Address(RVA = "0x102A2B0", Offset = "0x10290B0", VA = "0x1102A2B0")]
      public State_PickupGimmick()
      {
      }
    }

    [Token(Token = "0x2000CA5")]
    private class State_BattleDead : State<SceneBattle>
    {
      [Token(Token = "0x6003399")]
      [Address(RVA = "0x1030100", Offset = "0x102EF00", VA = "0x11030100", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600339A")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600339B")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600339C")]
      [Address(RVA = "0x10303E0", Offset = "0x102F1E0", VA = "0x110303E0")]
      public State_BattleDead()
      {
      }
    }

    [Token(Token = "0x2000CA6")]
    private class State_CastSkillStart : State<SceneBattle>
    {
      [Token(Token = "0x4002397")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mCasterController;

      [Token(Token = "0x600339D")]
      [Address(RVA = "0x1031CD0", Offset = "0x1030AD0", VA = "0x11031CD0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600339E")]
      [Address(RVA = "0x1031DF0", Offset = "0x1030BF0", VA = "0x11031DF0")]
      public State_CastSkillStart()
      {
      }
    }

    [Token(Token = "0x2000CA7")]
    private class State_CastSkillStartJump : State<SceneBattle>
    {
      [Token(Token = "0x4002398")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mCasterController;

      [Token(Token = "0x600339F")]
      [Address(RVA = "0x1031BB0", Offset = "0x10309B0", VA = "0x11031BB0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033A0")]
      [Address(RVA = "0x1031C90", Offset = "0x1030A90", VA = "0x11031C90")]
      public State_CastSkillStartJump()
      {
      }
    }

    [Token(Token = "0x2000CA8")]
    private class State_CastSkillStartChange : State<SceneBattle>
    {
      [Token(Token = "0x4002399")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mCasterController;

      [Token(Token = "0x60033A1")]
      [Address(RVA = "0x1031AC0", Offset = "0x10308C0", VA = "0x11031AC0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033A2")]
      [Address(RVA = "0x1031B70", Offset = "0x1030970", VA = "0x11031B70")]
      public State_CastSkillStartChange()
      {
      }
    }

    [Token(Token = "0x2000CA9")]
    private class State_CastSkillEnd : State<SceneBattle>
    {
      [Token(Token = "0x60033A3")]
      [Address(RVA = "0x1031A00", Offset = "0x1030800", VA = "0x11031A00", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033A4")]
      [Address(RVA = "0x1031A40", Offset = "0x1030840", VA = "0x11031A40", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033A5")]
      [Address(RVA = "0x1031A80", Offset = "0x1030880", VA = "0x11031A80")]
      public State_CastSkillEnd()
      {
      }
    }

    [Token(Token = "0x2000CAA")]
    private class State_MapTrick : State<SceneBattle>
    {
      [Token(Token = "0x400239A")]
      [FieldOffset(Offset = "0xC")]
      private SceneBattle.State_MapTrick.eSeqState mSeqState;
      [Token(Token = "0x400239B")]
      [FieldOffset(Offset = "0x10")]
      private float mPassedTime;
      [Token(Token = "0x400239C")]
      [FieldOffset(Offset = "0x14")]
      private LogMapTrick mLog;
      [Token(Token = "0x400239D")]
      [FieldOffset(Offset = "0x18")]
      private LoadRequest mLoadReqEffect;
      [Token(Token = "0x400239E")]
      [FieldOffset(Offset = "0x1C")]
      private List<SceneBattle.State_MapTrick.TucMapTrick> mTucMapTrickLists;
      [Token(Token = "0x400239F")]
      [FieldOffset(Offset = "0x20")]
      private bool mIsAction;
      [Token(Token = "0x40023A0")]
      [FieldOffset(Offset = "0x21")]
      private bool mIsDamaged;
      [Token(Token = "0x40023A1")]
      [FieldOffset(Offset = "0x24")]
      private List<GameObject> mGoEffectLists;
      [Token(Token = "0x40023A2")]
      [FieldOffset(Offset = "0x28")]
      private List<GameObject> mGoPopupLists;

      [Token(Token = "0x60033A6")]
      [Address(RVA = "0x1034670", Offset = "0x1033470", VA = "0x11034670", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033A7")]
      [Address(RVA = "0x1034BB0", Offset = "0x10339B0", VA = "0x11034BB0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033A8")]
      [Address(RVA = "0x1035780", Offset = "0x1034580", VA = "0x11035780")]
      public State_MapTrick()
      {
      }

      [Token(Token = "0x2000CAB")]
      private enum eSeqState
      {
        [Token(Token = "0x40023A4")] INIT,
        [Token(Token = "0x40023A5")] EFF_LOAD,
        [Token(Token = "0x40023A6")] EFF_PLAY,
        [Token(Token = "0x40023A7")] ACT_INIT,
        [Token(Token = "0x40023A8")] ACT_PLAY,
        [Token(Token = "0x40023A9")] EXIT,
      }

      [Token(Token = "0x2000CAC")]
      private class TucMapTrick
      {
        [Token(Token = "0x40023AA")]
        [FieldOffset(Offset = "0x8")]
        public TacticsUnitController mController;
        [Token(Token = "0x40023AB")]
        [FieldOffset(Offset = "0xC")]
        public LogMapTrick.TargetInfo mTargetInfo;

        [Token(Token = "0x60033A9")]
        [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
        public TucMapTrick(TacticsUnitController tuc, LogMapTrick.TargetInfo ti)
        {
        }
      }
    }

    [Token(Token = "0x2000CAD")]
    private class State_UnitEnd : State<SceneBattle>
    {
      [Token(Token = "0x40023AC")]
      private const float WAIT_SHAKE_PROGRESS = 0.3f;
      [Token(Token = "0x40023AD")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsPopDamage;
      [Token(Token = "0x40023AE")]
      [FieldOffset(Offset = "0xD")]
      private bool mIsShakeStart;
      [Token(Token = "0x40023AF")]
      [FieldOffset(Offset = "0x10")]
      private Unit mCurrentUnit;
      [Token(Token = "0x40023B0")]
      [FieldOffset(Offset = "0x14")]
      private TacticsUnitController mController;
      [Token(Token = "0x40023B1")]
      [FieldOffset(Offset = "0x18")]
      private bool mIsDamaged;
      [Token(Token = "0x40023B2")]
      [FieldOffset(Offset = "0x19")]
      private bool mIsEnded;

      [Token(Token = "0x60033AA")]
      [Address(RVA = "0x1039210", Offset = "0x1038010", VA = "0x11039210", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033AB")]
      [Address(RVA = "0x1039640", Offset = "0x1038440", VA = "0x11039640", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033AC")]
      [Address(RVA = "0x10395E0", Offset = "0x10383E0", VA = "0x110395E0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60033AD")]
      [Address(RVA = "0x1039B70", Offset = "0x1038970", VA = "0x11039B70")]
      public State_UnitEnd()
      {
      }
    }

    [Token(Token = "0x2000CAE")]
    private class State_OrdealChangeNext : State<SceneBattle>
    {
      [Token(Token = "0x40023B3")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsFinished;

      [Token(Token = "0x60033AE")]
      [Address(RVA = "0x1035870", Offset = "0x1034670", VA = "0x11035870", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033AF")]
      [Address(RVA = "0x10358F0", Offset = "0x10346F0", VA = "0x110358F0")]
      private IEnumerator StepOrdealChangeNextTeam() => (IEnumerator) null;

      [Token(Token = "0x60033B0")]
      [Address(RVA = "0x1035960", Offset = "0x1034760", VA = "0x11035960", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033B1")]
      [Address(RVA = "0x10359C0", Offset = "0x10347C0", VA = "0x110359C0")]
      public State_OrdealChangeNext()
      {
      }
    }

    [Token(Token = "0x2000CB0")]
    private class State_LogDelay : State<SceneBattle>
    {
      [Token(Token = "0x40023B7")]
      [FieldOffset(Offset = "0xC")]
      private float mTimer;
      [Token(Token = "0x40023B8")]
      [FieldOffset(Offset = "0x10")]
      private float mNow;

      [Token(Token = "0x60033B8")]
      [Address(RVA = "0x10342F0", Offset = "0x10330F0", VA = "0x110342F0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033B9")]
      [Address(RVA = "0x1034380", Offset = "0x1033180", VA = "0x11034380", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033BA")]
      [Address(RVA = "0x1034400", Offset = "0x1033200", VA = "0x11034400")]
      public State_LogDelay()
      {
      }
    }

    [Token(Token = "0x2000CB1")]
    private class State_MapEndV2 : State<SceneBattle>
    {
      [Token(Token = "0x60033BB")]
      [Address(RVA = "0x1034440", Offset = "0x1033240", VA = "0x11034440", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033BC")]
      [Address(RVA = "0x1034630", Offset = "0x1033430", VA = "0x11034630")]
      public State_MapEndV2()
      {
      }
    }

    [Token(Token = "0x2000CB2")]
    public enum ExitRequests
    {
      [Token(Token = "0x40023BA")] None,
      [Token(Token = "0x40023BB")] End,
      [Token(Token = "0x40023BC")] Restart,
    }

    [Token(Token = "0x2000CB3")]
    private class State_ArenaSkipWait : State<SceneBattle>
    {
      [Token(Token = "0x60033BD")]
      [Address(RVA = "0x102F8B0", Offset = "0x102E6B0", VA = "0x1102F8B0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033BE")]
      [Address(RVA = "0x102F970", Offset = "0x102E770", VA = "0x1102F970")]
      public State_ArenaSkipWait()
      {
      }
    }

    [Token(Token = "0x2000CB4")]
    public delegate void QuestEndEvent();

    [Token(Token = "0x2000CB5")]
    private class State_ReplayErrorResult : State<SceneBattle>
    {
      [Token(Token = "0x60033C3")]
      [Address(RVA = "0x1037B90", Offset = "0x1036990", VA = "0x11037B90", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033C4")]
      [Address(RVA = "0x1037C70", Offset = "0x1036A70", VA = "0x11037C70")]
      public State_ReplayErrorResult()
      {
      }
    }

    [Token(Token = "0x2000CB7")]
    private class State_DuelErrorResult : State<SceneBattle>
    {
      [Token(Token = "0x60033C7")]
      [Address(RVA = "0x10334B0", Offset = "0x10322B0", VA = "0x110334B0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033C8")]
      [Address(RVA = "0x1033570", Offset = "0x1032370", VA = "0x11033570")]
      public State_DuelErrorResult()
      {
      }
    }

    [Token(Token = "0x2000CB9")]
    private class State_PreQuestResult : State<SceneBattle>
    {
      [Token(Token = "0x60033CB")]
      [Address(RVA = "0x1035A00", Offset = "0x1034800", VA = "0x11035A00", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033CC")]
      [Address(RVA = "0x1036BE0", Offset = "0x10359E0", VA = "0x11036BE0")]
      public State_PreQuestResult()
      {
      }
    }

    [Token(Token = "0x2000CBB")]
    private class State_Result : State<SceneBattle>
    {
      [Token(Token = "0x40023C0")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsResDestroy;
      [Token(Token = "0x40023C1")]
      [FieldOffset(Offset = "0x10")]
      private LoadRequest mResLoadReq;
      [Token(Token = "0x40023C2")]
      [FieldOffset(Offset = "0x14")]
      private float mResPassedTime;
      [Token(Token = "0x40023C3")]
      [FieldOffset(Offset = "0x18")]
      private bool mOnResult;

      [Token(Token = "0x60033D0")]
      [Address(RVA = "0x10384E0", Offset = "0x10372E0", VA = "0x110384E0")]
      public bool IsExitRequest(BattleCore.Record record, bool needFriendRequest, bool isVersus)
      {
        return new bool();
      }

      [Token(Token = "0x60033D1")]
      [Address(RVA = "0x1037FB0", Offset = "0x1036DB0", VA = "0x11037FB0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033D2")]
      [Address(RVA = "0x1038660", Offset = "0x1037460", VA = "0x11038660")]
      private void StartResult()
      {
      }

      [Token(Token = "0x60033D3")]
      [Address(RVA = "0x1038C60", Offset = "0x1037A60", VA = "0x11038C60", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033D4")]
      [Address(RVA = "0x10391D0", Offset = "0x1037FD0", VA = "0x110391D0")]
      public State_Result()
      {
      }
    }

    [Token(Token = "0x2000CBD")]
    private class State_RestartQuest : State<SceneBattle>
    {
      [Token(Token = "0x40023C5")]
      [FieldOffset(Offset = "0xC")]
      private bool mRequested;

      [Token(Token = "0x60033D7")]
      [Address(RVA = "0x1037CB0", Offset = "0x1036AB0", VA = "0x11037CB0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033D8")]
      [Address(RVA = "0x1037D00", Offset = "0x1036B00", VA = "0x11037D00", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033D9")]
      [Address(RVA = "0x1037D80", Offset = "0x1036B80", VA = "0x11037D80")]
      public State_RestartQuest()
      {
      }
    }

    [Token(Token = "0x2000CBE")]
    private class State_ContinueQuest : State<SceneBattle>
    {
      [Token(Token = "0x40023C6")]
      [FieldOffset(Offset = "0xC")]
      private bool mRequested;
      [Token(Token = "0x40023C7")]
      [FieldOffset(Offset = "0x10")]
      private SceneBattle mScene;

      [Token(Token = "0x60033DA")]
      [Address(RVA = "0x10327C0", Offset = "0x10315C0", VA = "0x110327C0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033DB")]
      [Address(RVA = "0x1032E80", Offset = "0x1031C80", VA = "0x11032E80", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033DC")]
      [Address(RVA = "0x1032870", Offset = "0x1031670", VA = "0x11032870")]
      private void OnSuccess(WWWResult www)
      {
      }

      [Token(Token = "0x60033DD")]
      [Address(RVA = "0x10329B0", Offset = "0x10317B0", VA = "0x110329B0")]
      private void ResBtlComCont(BattleCore.Json_Battle response)
      {
      }

      [Token(Token = "0x60033DE")]
      [Address(RVA = "0x10330D0", Offset = "0x1031ED0", VA = "0x110330D0")]
      public State_ContinueQuest()
      {
      }
    }

    [Token(Token = "0x2000CBF")]
    private class State_ExitQuest : State<SceneBattle>
    {
      [Token(Token = "0x60033DF")]
      [Address(RVA = "0x10335B0", Offset = "0x10323B0", VA = "0x110335B0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033E0")]
      [Address(RVA = "0x10336C0", Offset = "0x10324C0", VA = "0x110336C0")]
      private IEnumerator ExitAsync() => (IEnumerator) null;

      [Token(Token = "0x60033E1")]
      [Address(RVA = "0x10337C0", Offset = "0x10325C0", VA = "0x110337C0")]
      public State_ExitQuest()
      {
      }
    }

    [Token(Token = "0x2000CC1")]
    private class State_Restart_SelectSupport : State<SceneBattle>
    {
      [Token(Token = "0x60033E9")]
      [Address(RVA = "0x1037DC0", Offset = "0x1036BC0", VA = "0x11037DC0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033EA")]
      [Address(RVA = "0x1037E50", Offset = "0x1036C50", VA = "0x11037E50", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60033EB")]
      [Address(RVA = "0x1037E80", Offset = "0x1036C80", VA = "0x11037E80")]
      private void OnStateChange(SceneBattle.StateTransitionTypes req)
      {
      }

      [Token(Token = "0x60033EC")]
      [Address(RVA = "0x1037F70", Offset = "0x1036D70", VA = "0x11037F70")]
      public State_Restart_SelectSupport()
      {
      }
    }

    [Token(Token = "0x2000CC2")]
    private class State_ConfirmContinue : State<SceneBattle>
    {
      [Token(Token = "0x60033ED")]
      [Address(RVA = "0x10323E0", Offset = "0x10311E0", VA = "0x110323E0")]
      private void OnDecide(GameObject dialog)
      {
      }

      [Token(Token = "0x60033EE")]
      [Address(RVA = "0x1032390", Offset = "0x1031190", VA = "0x11032390")]
      private void OnBuyCoinEnd()
      {
      }

      [Token(Token = "0x60033EF")]
      [Address(RVA = "0x1032350", Offset = "0x1031150", VA = "0x11032350")]
      private void OnBuyCoinCancel()
      {
      }

      [Token(Token = "0x60033F0")]
      [Address(RVA = "0x10323A0", Offset = "0x10311A0", VA = "0x110323A0")]
      private void OnCancel(GameObject dialog)
      {
      }

      [Token(Token = "0x60033F1")]
      [Address(RVA = "0x1032240", Offset = "0x1031040", VA = "0x11032240", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033F2")]
      [Address(RVA = "0x1032260", Offset = "0x1031060", VA = "0x11032260")]
      private void Confirm()
      {
      }

      [Token(Token = "0x60033F3")]
      [Address(RVA = "0x1032780", Offset = "0x1031580", VA = "0x11032780")]
      public State_ConfirmContinue()
      {
      }
    }

    [Token(Token = "0x2000CC3")]
    private struct PosRot
    {
      [Token(Token = "0x40023CE")]
      [FieldOffset(Offset = "0x0")]
      public Vector3 Position;
      [Token(Token = "0x40023CF")]
      [FieldOffset(Offset = "0xC")]
      public Quaternion Rotation;

      [Token(Token = "0x60033F5")]
      [Address(RVA = "0x102F860", Offset = "0x102E660", VA = "0x1102F860")]
      public void Apply(Transform target)
      {
      }

      [Token(Token = "0x60033F6")]
      [Address(RVA = "0x102F7D0", Offset = "0x102E5D0", VA = "0x1102F7D0")]
      public void Apply(Transform target, Vector3 deltaPosition)
      {
      }

      [Token(Token = "0x60033F7")]
      [Address(RVA = "0x102F740", Offset = "0x102E540", VA = "0x1102F740")]
      public void AddPosition(Component component)
      {
      }
    }

    [Token(Token = "0x2000CC4")]
    private class State_CondDamage : State<SceneBattle>
    {
      [Token(Token = "0x40023D0")]
      private const float WAIT_SHAKE_PROGRESS = 0.3f;
      [Token(Token = "0x40023D1")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsFinished;
      [Token(Token = "0x40023D2")]
      [FieldOffset(Offset = "0x10")]
      private LogCondDamage mLog;

      [Token(Token = "0x60033F8")]
      [Address(RVA = "0x1031E30", Offset = "0x1030C30", VA = "0x11031E30", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60033F9")]
      [Address(RVA = "0x1032130", Offset = "0x1030F30", VA = "0x11032130")]
      private IEnumerator ExecutePerformance() => (IEnumerator) null;

      [Token(Token = "0x60033FA")]
      [Address(RVA = "0x10321A0", Offset = "0x1030FA0", VA = "0x110321A0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60033FB")]
      [Address(RVA = "0x1032200", Offset = "0x1031000", VA = "0x11032200")]
      public State_CondDamage()
      {
      }
    }

    [Token(Token = "0x2000CC6")]
    private class State_DamageManipulate : State<SceneBattle>
    {
      [Token(Token = "0x40023D9")]
      private const float WAIT_SHAKE_PROGRESS = 0.3f;
      [Token(Token = "0x40023DA")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsFinished;
      [Token(Token = "0x40023DB")]
      [FieldOffset(Offset = "0x10")]
      private LogDamageManipulate mLog;
      [Token(Token = "0x40023DC")]
      [FieldOffset(Offset = "0x14")]
      private GameObject mSkillEffect;
      [Token(Token = "0x40023DD")]
      [FieldOffset(Offset = "0x18")]
      private bool mIsLoadingEffect;

      [Token(Token = "0x6003402")]
      [Address(RVA = "0x1033110", Offset = "0x1031F10", VA = "0x11033110", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003403")]
      [Address(RVA = "0x1033260", Offset = "0x1032060", VA = "0x11033260")]
      private void CameraForcusTarget(Unit unit, Grid grid)
      {
      }

      [Token(Token = "0x6003404")]
      [Address(RVA = "0x1033330", Offset = "0x1032130", VA = "0x11033330")]
      private IEnumerator ExecutePerformance() => (IEnumerator) null;

      [Token(Token = "0x6003405")]
      [Address(RVA = "0x1033410", Offset = "0x1032210", VA = "0x11033410", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003406")]
      [Address(RVA = "0x10333A0", Offset = "0x10321A0", VA = "0x110333A0")]
      private IEnumerator LoadManipulateEffectsAsync(string effect) => (IEnumerator) null;

      [Token(Token = "0x6003407")]
      [Address(RVA = "0x1033470", Offset = "0x1032270", VA = "0x11033470")]
      public State_DamageManipulate()
      {
      }
    }

    [Token(Token = "0x2000CCA")]
    private class State_AutoHeal : State<SceneBattle>
    {
      [Token(Token = "0x40023ED")]
      [FieldOffset(Offset = "0xC")]
      private GameObject mHealEffect;
      [Token(Token = "0x40023EE")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController mController;
      [Token(Token = "0x40023EF")]
      [FieldOffset(Offset = "0x14")]
      private LogAutoHeal mLog;
      [Token(Token = "0x40023F0")]
      [FieldOffset(Offset = "0x18")]
      private SceneBattle.State_AutoHeal.State mState;
      [Token(Token = "0x40023F1")]
      [FieldOffset(Offset = "0x1C")]
      private int mHealdHp;
      [Token(Token = "0x40023F2")]
      [FieldOffset(Offset = "0x20")]
      private short mHealdMp;

      [Token(Token = "0x6003419")]
      [Address(RVA = "0x102F9B0", Offset = "0x102E7B0", VA = "0x1102F9B0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600341A")]
      [Address(RVA = "0x102FB90", Offset = "0x102E990", VA = "0x1102FB90", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600341B")]
      [Address(RVA = "0x102FEE0", Offset = "0x102ECE0", VA = "0x1102FEE0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600341C")]
      [Address(RVA = "0x1030050", Offset = "0x102EE50", VA = "0x11030050")]
      private IEnumerator Wait(float wait) => (IEnumerator) null;

      [Token(Token = "0x600341D")]
      [Address(RVA = "0x102FC70", Offset = "0x102EA70", VA = "0x1102FC70")]
      private void StartEffect()
      {
      }

      [Token(Token = "0x600341E")]
      [Address(RVA = "0x10300C0", Offset = "0x102EEC0", VA = "0x110300C0")]
      public State_AutoHeal()
      {
      }

      [Token(Token = "0x2000CCB")]
      private enum State
      {
        [Token(Token = "0x40023F4")] Start,
        [Token(Token = "0x40023F5")] Wait,
        [Token(Token = "0x40023F6")] End,
        [Token(Token = "0x40023F7")] EffectStart,
        [Token(Token = "0x40023F8")] Effect,
      }
    }

    [Token(Token = "0x2000CCD")]
    private class State_PrepareCast : State<SceneBattle>
    {
      [Token(Token = "0x6003425")]
      [Address(RVA = "0x1036C20", Offset = "0x1035A20", VA = "0x11036C20", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003426")]
      [Address(RVA = "0x1036DC0", Offset = "0x1035BC0", VA = "0x11036DC0")]
      private void EnterChant(LogCast Log)
      {
      }

      [Token(Token = "0x6003427")]
      [Address(RVA = "0x1036E90", Offset = "0x1035C90", VA = "0x11036E90")]
      public State_PrepareCast()
      {
      }
    }

    [Token(Token = "0x2000CCE")]
    private class State_JumpCastStart : State<SceneBattle>
    {
      [Token(Token = "0x40023FD")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mCasterController;
      [Token(Token = "0x40023FE")]
      [FieldOffset(Offset = "0x10")]
      private float WaitTime;
      [Token(Token = "0x40023FF")]
      [FieldOffset(Offset = "0x14")]
      private float CountTime;
      [Token(Token = "0x4002400")]
      [FieldOffset(Offset = "0x18")]
      private bool mDirection;

      [Token(Token = "0x6003428")]
      [Address(RVA = "0x1033800", Offset = "0x1032600", VA = "0x11033800", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003429")]
      [Address(RVA = "0x10339C0", Offset = "0x10327C0", VA = "0x110339C0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600342A")]
      [Address(RVA = "0x1033990", Offset = "0x1032790", VA = "0x11033990", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600342B")]
      [Address(RVA = "0x1033AC0", Offset = "0x10328C0", VA = "0x11033AC0")]
      public State_JumpCastStart()
      {
      }
    }

    [Token(Token = "0x2000CCF")]
    private class State_JumpFall : State<SceneBattle>
    {
      [Token(Token = "0x4002401")]
      private const float WAIT_TIME = 0.5f;
      [Token(Token = "0x4002402")]
      private const float DELAY_TIME = 0.1f;
      [Token(Token = "0x4002403")]
      [FieldOffset(Offset = "0xC")]
      private LogFall mLog;
      [Token(Token = "0x4002404")]
      [FieldOffset(Offset = "0x10")]
      private bool mDirection;
      [Token(Token = "0x4002405")]
      [FieldOffset(Offset = "0x14")]
      private SceneBattle.State_JumpFall.eDirectionMode mDirectionMode;
      [Token(Token = "0x4002406")]
      [FieldOffset(Offset = "0x18")]
      private List<SceneBattle.State_JumpFall.Caster> mCasterLists;

      [Token(Token = "0x600342C")]
      [Address(RVA = "0x1033B00", Offset = "0x1032900", VA = "0x11033B00", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600342D")]
      [Address(RVA = "0x1034010", Offset = "0x1032E10", VA = "0x11034010", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600342E")]
      [Address(RVA = "0x1033990", Offset = "0x1032790", VA = "0x11033990", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600342F")]
      [Address(RVA = "0x1034260", Offset = "0x1033060", VA = "0x11034260")]
      public State_JumpFall()
      {
      }

      [Token(Token = "0x2000CD0")]
      private enum eDirectionMode
      {
        [Token(Token = "0x4002408")] FALL,
        [Token(Token = "0x4002409")] CAMERA_WAIT,
        [Token(Token = "0x400240A")] EXIT,
      }

      [Token(Token = "0x2000CD1")]
      private class Caster
      {
        [Token(Token = "0x400240B")]
        [FieldOffset(Offset = "0x8")]
        public TacticsUnitController mController;
        [Token(Token = "0x400240C")]
        [FieldOffset(Offset = "0xC")]
        public float mPassedTime;

        [Token(Token = "0x6003430")]
        [Address(RVA = "0x102F710", Offset = "0x102E510", VA = "0x1102F710")]
        public Caster(TacticsUnitController controller)
        {
        }
      }
    }

    [Token(Token = "0x2000CD2")]
    private enum eCsImage
    {
      [Token(Token = "0x400240E")] U2_MAIN,
      [Token(Token = "0x400240F")] U2_SUB,
      [Token(Token = "0x4002410")] UE_MAIN,
      [Token(Token = "0x4002411")] UE_SUB,
      [Token(Token = "0x4002412")] MAX,
    }

    [Token(Token = "0x2000CD3")]
    private class State_PrepareSkill : State<SceneBattle>
    {
      [Token(Token = "0x4002413")]
      [FieldOffset(Offset = "0xC")]
      private bool mLoadSplash;
      [Token(Token = "0x4002414")]
      [FieldOffset(Offset = "0x10")]
      private float mWaitCount;
      [Token(Token = "0x4002415")]
      [FieldOffset(Offset = "0x14")]
      private bool mIsLoadTransformUnit;
      [Token(Token = "0x4002416")]
      [FieldOffset(Offset = "0x15")]
      private bool mIsLoadBreakObjUnit;

      [Token(Token = "0x6003431")]
      [Address(RVA = "0x1036ED0", Offset = "0x1035CD0", VA = "0x11036ED0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003432")]
      [Address(RVA = "0x1037590", Offset = "0x1036390", VA = "0x11037590")]
      private IEnumerator PrepareSkill(Unit unit, SkillData skill) => (IEnumerator) null;

      [Token(Token = "0x6003433")]
      [Address(RVA = "0x1037A00", Offset = "0x1036800", VA = "0x11037A00")]
      private IEnumerator cutinVoice(Unit unit, SkillData skill) => (IEnumerator) null;

      [Token(Token = "0x6003434")]
      [Address(RVA = "0x1037620", Offset = "0x1036420", VA = "0x11037620", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003435")]
      [Address(RVA = "0x1037B00", Offset = "0x1036900", VA = "0x11037B00")]
      public static IEnumerator loadTransformUnit(
        SceneBattle self,
        Unit unit,
        TacticsUnitController bef_tuc = null,
        Action callback = null)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6003436")]
      [Address(RVA = "0x1037A80", Offset = "0x1036880", VA = "0x11037A80")]
      public static IEnumerator loadBreakObjUnit(SceneBattle self, Unit unit, Action callback = null)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6003437")]
      [Address(RVA = "0x10379C0", Offset = "0x10367C0", VA = "0x110379C0")]
      public State_PrepareSkill()
      {
      }
    }

    [Token(Token = "0x2000CD8")]
    private class State_Battle_PrepareSkill : State<SceneBattle>
    {
      [Token(Token = "0x4002436")]
      [FieldOffset(Offset = "0xC")]
      private SkillParam mSkill;
      [Token(Token = "0x4002437")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController mInstigator;
      [Token(Token = "0x4002438")]
      [FieldOffset(Offset = "0x14")]
      private List<TacticsUnitController> mTargets;

      [Token(Token = "0x6003452")]
      [Address(RVA = "0x1030420", Offset = "0x102F220", VA = "0x11030420", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003453")]
      [Address(RVA = "0x1030A70", Offset = "0x102F870", VA = "0x11030A70", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003454")]
      [Address(RVA = "0x1031980", Offset = "0x1030780", VA = "0x11031980")]
      public State_Battle_PrepareSkill()
      {
      }
    }

    [Token(Token = "0x2000CD9")]
    private class State_Battle_PlaySkill : State<SceneBattle>
    {
      [Token(Token = "0x6003455")]
      [Address(RVA = "0x1042490", Offset = "0x1041290", VA = "0x11042490", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003456")]
      [Address(RVA = "0x1042560", Offset = "0x1041360", VA = "0x11042560")]
      public State_Battle_PlaySkill()
      {
      }
    }

    [Token(Token = "0x2000CDA")]
    private class State_Battle_EndSkill : State<SceneBattle>
    {
      [Token(Token = "0x4002439")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsBusy;
      [Token(Token = "0x400243A")]
      [FieldOffset(Offset = "0x10")]
      private SkillData mSkillData;
      [Token(Token = "0x400243B")]
      [FieldOffset(Offset = "0x14")]
      private LogSkill mLogSkill;

      [Token(Token = "0x6003457")]
      [Address(RVA = "0x1041A40", Offset = "0x1040840", VA = "0x11041A40", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003458")]
      [Address(RVA = "0x1041D10", Offset = "0x1040B10", VA = "0x11041D10")]
      private void UpdateHPGauges()
      {
      }

      [Token(Token = "0x6003459")]
      [Address(RVA = "0x1041B80", Offset = "0x1040980", VA = "0x11041B80")]
      private void SetLogTargetbyBattleMapResetGrid(TacticsUnitController tuc, LogSkill log)
      {
      }

      [Token(Token = "0x600345A")]
      [Address(RVA = "0x10419D0", Offset = "0x10407D0", VA = "0x110419D0")]
      private IEnumerator AsyncUpdate() => (IEnumerator) null;

      [Token(Token = "0x600345B")]
      [Address(RVA = "0x1041EC0", Offset = "0x1040CC0", VA = "0x11041EC0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600345C")]
      [Address(RVA = "0x1042450", Offset = "0x1041250", VA = "0x11042450")]
      public State_Battle_EndSkill()
      {
      }
    }

    [Token(Token = "0x2000CDC")]
    private class State_Map_PrepareSkill : State<SceneBattle>
    {
      [Token(Token = "0x400243F")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController controller;
      [Token(Token = "0x4002440")]
      [FieldOffset(Offset = "0x10")]
      private LogSkill log;

      [Token(Token = "0x6003463")]
      [Address(RVA = "0x10473F0", Offset = "0x10461F0", VA = "0x110473F0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003464")]
      [Address(RVA = "0x1047980", Offset = "0x1046780", VA = "0x11047980", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003465")]
      [Address(RVA = "0x1047EB0", Offset = "0x1046CB0", VA = "0x11047EB0")]
      public State_Map_PrepareSkill()
      {
      }
    }

    [Token(Token = "0x2000CDD")]
    private class State_Map_LoadSkill : State<SceneBattle>
    {
      [Token(Token = "0x4002441")]
      [FieldOffset(Offset = "0xC")]
      private float mWaitTime;

      [Token(Token = "0x6003466")]
      [Address(RVA = "0x1043150", Offset = "0x1041F50", VA = "0x11043150", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003467")]
      [Address(RVA = "0x1044100", Offset = "0x1042F00", VA = "0x11044100", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003468")]
      [Address(RVA = "0x1044450", Offset = "0x1043250", VA = "0x11044450")]
      public State_Map_LoadSkill()
      {
      }
    }

    [Token(Token = "0x2000CDE")]
    private class State_Map_PlayPreSkillAnim : State<SceneBattle>
    {
      [Token(Token = "0x4002442")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mInstigator;
      [Token(Token = "0x4002443")]
      [FieldOffset(Offset = "0x10")]
      private bool mFadeIn;
      [Token(Token = "0x4002444")]
      [FieldOffset(Offset = "0x14")]
      private TacticsUnitController mTransformTuc;
      [Token(Token = "0x4002445")]
      [FieldOffset(Offset = "0x18")]
      private Quaternion mInstigatorQuat;
      [Token(Token = "0x4002446")]
      [FieldOffset(Offset = "0x28")]
      private Quaternion mCollaboQuat;
      [Token(Token = "0x4002447")]
      [FieldOffset(Offset = "0x38")]
      private Quaternion mTransformQuat;

      [Token(Token = "0x6003469")]
      [Address(RVA = "0x1044850", Offset = "0x1043650", VA = "0x11044850", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600346A")]
      [Address(RVA = "0x10447E0", Offset = "0x10435E0", VA = "0x110447E0")]
      private IEnumerator AsyncWork(LogSkill log) => (IEnumerator) null;

      [Token(Token = "0x600346B")]
      [Address(RVA = "0x1045220", Offset = "0x1044020", VA = "0x11045220")]
      public State_Map_PlayPreSkillAnim()
      {
      }
    }

    [Token(Token = "0x2000CE0")]
    private class State_Map_LoadSkill_Renkei1 : State<SceneBattle>
    {
      [Token(Token = "0x400244C")]
      [FieldOffset(Offset = "0xC")]
      private int mRenkeiUnitIndex;
      [Token(Token = "0x400244D")]
      [FieldOffset(Offset = "0x10")]
      private float mInterval;

      [Token(Token = "0x6003472")]
      [Address(RVA = "0x1043820", Offset = "0x1042620", VA = "0x11043820", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003473")]
      [Address(RVA = "0x10438E0", Offset = "0x10426E0", VA = "0x110438E0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003474")]
      [Address(RVA = "0x1043BF0", Offset = "0x10429F0", VA = "0x11043BF0")]
      public State_Map_LoadSkill_Renkei1()
      {
      }
    }

    [Token(Token = "0x2000CE1")]
    private class State_Map_LoadSkill_Renkei2 : State<SceneBattle>
    {
      [Token(Token = "0x400244E")]
      [FieldOffset(Offset = "0xC")]
      private float mDelay;

      [Token(Token = "0x6003475")]
      [Address(RVA = "0x1043C30", Offset = "0x1042A30", VA = "0x11043C30", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003476")]
      [Address(RVA = "0x1043E60", Offset = "0x1042C60", VA = "0x11043E60", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003477")]
      [Address(RVA = "0x10440C0", Offset = "0x1042EC0", VA = "0x110440C0")]
      public State_Map_LoadSkill_Renkei2()
      {
      }
    }

    [Token(Token = "0x2000CE2")]
    private class State_Map_LoadSkill_Protect : State<SceneBattle>
    {
      [Token(Token = "0x400244F")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsFinished;
      [Token(Token = "0x4002450")]
      [FieldOffset(Offset = "0x10")]
      private int mUnitProtectIndex;
      [Token(Token = "0x4002451")]
      [FieldOffset(Offset = "0x14")]
      private int mUnitGuardIndex;
      [Token(Token = "0x4002452")]
      [FieldOffset(Offset = "0x18")]
      private LogSkill log;

      [Token(Token = "0x6003478")]
      [Address(RVA = "0x1043160", Offset = "0x1041F60", VA = "0x11043160", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003479")]
      [Address(RVA = "0x10434A0", Offset = "0x10422A0", VA = "0x110434A0")]
      private IEnumerator ProtectEffect(Unit unit, bool isProtectTarget) => (IEnumerator) null;

      [Token(Token = "0x600347A")]
      [Address(RVA = "0x1043520", Offset = "0x1042320", VA = "0x11043520", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600347B")]
      [Address(RVA = "0x10437E0", Offset = "0x10425E0", VA = "0x110437E0")]
      public State_Map_LoadSkill_Protect()
      {
      }
    }

    [Token(Token = "0x2000CE4")]
    private class State_Map_LoadSkill_Protect_Next : State<SceneBattle>
    {
      [Token(Token = "0x4002459")]
      [FieldOffset(Offset = "0xC")]
      private LogSkill log;
      [Token(Token = "0x400245A")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController controller;

      [Token(Token = "0x6003482")]
      [Address(RVA = "0x1043250", Offset = "0x1042050", VA = "0x11043250", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003483")]
      [Address(RVA = "0x1043380", Offset = "0x1042180", VA = "0x11043380", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003484")]
      [Address(RVA = "0x1043460", Offset = "0x1042260", VA = "0x11043460")]
      public State_Map_LoadSkill_Protect_Next()
      {
      }
    }

    [Token(Token = "0x2000CE5")]
    private class State_Map_PlayPreDodge : State<SceneBattle>
    {
      [Token(Token = "0x400245B")]
      [FieldOffset(Offset = "0xC")]
      private List<TacticsUnitController> mPollControllers;
      [Token(Token = "0x400245C")]
      [FieldOffset(Offset = "0x10")]
      private float mDelay;

      [Token(Token = "0x6003485")]
      [Address(RVA = "0x1044490", Offset = "0x1043290", VA = "0x11044490", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003486")]
      [Address(RVA = "0x1044690", Offset = "0x1043490", VA = "0x11044690", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003487")]
      [Address(RVA = "0x1044750", Offset = "0x1043550", VA = "0x11044750")]
      public State_Map_PlayPreDodge()
      {
      }
    }

    [Token(Token = "0x2000CE6")]
    private class State_Map_PlaySkill : State<SceneBattle>
    {
      [Token(Token = "0x400245D")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mInstigator;
      [Token(Token = "0x400245E")]
      [FieldOffset(Offset = "0x10")]
      private List<TacticsUnitController> mTargets;
      [Token(Token = "0x400245F")]
      [FieldOffset(Offset = "0x14")]
      private float mEndWait;
      [Token(Token = "0x4002460")]
      [FieldOffset(Offset = "0x18")]
      private LogSkill mActionInfo;
      [Token(Token = "0x4002461")]
      [FieldOffset(Offset = "0x1C")]
      private IntVector2 mCameraStart;

      [Token(Token = "0x6003488")]
      [Address(RVA = "0x1045260", Offset = "0x1044060", VA = "0x11045260", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003489")]
      [Address(RVA = "0x1046560", Offset = "0x1045360", VA = "0x11046560", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600348A")]
      [Address(RVA = "0x1047370", Offset = "0x1046170", VA = "0x11047370")]
      public State_Map_PlaySkill()
      {
      }
    }

    [Token(Token = "0x2000CE7")]
    private class FindShield
    {
      [Token(Token = "0x4002462")]
      [FieldOffset(Offset = "0x8")]
      public TacticsUnitController mTuc;
      [Token(Token = "0x4002463")]
      [FieldOffset(Offset = "0xC")]
      public TacticsUnitController.ShieldState mShield;

      [Token(Token = "0x600348B")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public FindShield(TacticsUnitController tuc, TacticsUnitController.ShieldState shield)
      {
      }
    }

    [Token(Token = "0x2000CE8")]
    private class State_SpawnShieldEffects : State<SceneBattle>
    {
      [Token(Token = "0x4002464")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mUnit;
      [Token(Token = "0x4002465")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController.ShieldState mShield;
      [Token(Token = "0x4002466")]
      [FieldOffset(Offset = "0x14")]
      private bool mIsFinished;

      [Token(Token = "0x600348C")]
      [Address(RVA = "0x1047EF0", Offset = "0x1046CF0", VA = "0x11047EF0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600348D")]
      [Address(RVA = "0x1048120", Offset = "0x1046F20", VA = "0x11048120")]
      private IEnumerator SpawnEffectsAsync() => (IEnumerator) null;

      [Token(Token = "0x600348E")]
      [Address(RVA = "0x1048190", Offset = "0x1046F90", VA = "0x11048190", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600348F")]
      [Address(RVA = "0x1048210", Offset = "0x1047010", VA = "0x11048210")]
      public State_SpawnShieldEffects()
      {
      }
    }

    [Token(Token = "0x2000CEA")]
    private class EventRecvSkillUnit
    {
      [Token(Token = "0x400246B")]
      [FieldOffset(Offset = "0x8")]
      public bool mValid;
      [Token(Token = "0x400246C")]
      [FieldOffset(Offset = "0xC")]
      public SceneBattle.EventRecvSkillUnit.eType mType;
      [Token(Token = "0x400246D")]
      [FieldOffset(Offset = "0x10")]
      public TacticsUnitController mController;
      [Token(Token = "0x400246E")]
      [FieldOffset(Offset = "0x14")]
      public EElement mElem;
      [Token(Token = "0x400246F")]
      [FieldOffset(Offset = "0x18")]
      public EUnitCondition mCond;

      [Token(Token = "0x6003496")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EventRecvSkillUnit()
      {
      }

      [Token(Token = "0x6003497")]
      [Address(RVA = "0x1040910", Offset = "0x103F710", VA = "0x11040910")]
      public EventRecvSkillUnit(TacticsUnitController tuc, EElement elem)
      {
      }

      [Token(Token = "0x6003498")]
      [Address(RVA = "0x1040950", Offset = "0x103F750", VA = "0x11040950")]
      public EventRecvSkillUnit(TacticsUnitController tuc, EUnitCondition cond)
      {
      }

      [Token(Token = "0x2000CEB")]
      public enum eType
      {
        [Token(Token = "0x4002471")] UNKNOWN,
        [Token(Token = "0x4002472")] ELEM,
        [Token(Token = "0x4002473")] COND,
      }
    }

    [Token(Token = "0x2000CEC")]
    private class State_TriggerHPEvents : State<SceneBattle>
    {
      [Token(Token = "0x6003499")]
      [Address(RVA = "0x10485B0", Offset = "0x10473B0", VA = "0x110485B0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600349A")]
      [Address(RVA = "0x1048B00", Offset = "0x1047900", VA = "0x11048B00")]
      public State_TriggerHPEvents()
      {
      }
    }

    [Token(Token = "0x2000CED")]
    private class State_WaitGC<NextState> : State<SceneBattle> where NextState : State<SceneBattle>, new()
    {
      [Token(Token = "0x4002474")]
      [FieldOffset(Offset = "0x0")]
      private AsyncOperation mAsyncOp;

      [Token(Token = "0x600349B")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600349C")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600349D")]
      public State_WaitGC()
      {
      }
    }

    [Token(Token = "0x2000CEE")]
    private class State_Weather : State<SceneBattle>
    {
      [Token(Token = "0x4002475")]
      [FieldOffset(Offset = "0xC")]
      private LogWeather mLog;
      [Token(Token = "0x4002476")]
      [FieldOffset(Offset = "0x10")]
      private bool mIsFinished;

      [Token(Token = "0x600349E")]
      [Address(RVA = "0x1048DD0", Offset = "0x1047BD0", VA = "0x11048DD0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600349F")]
      [Address(RVA = "0x1048D60", Offset = "0x1047B60", VA = "0x11048D60")]
      private IEnumerator AsyncWeather() => (IEnumerator) null;

      [Token(Token = "0x60034A0")]
      [Address(RVA = "0x1048F60", Offset = "0x1047D60", VA = "0x11048F60", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034A1")]
      [Address(RVA = "0x1048FD0", Offset = "0x1047DD0", VA = "0x11048FD0")]
      public State_Weather()
      {
      }
    }

    [Token(Token = "0x2000CF0")]
    private class State_SpawnUnit : State<SceneBattle>
    {
      [Token(Token = "0x400247A")]
      [FieldOffset(Offset = "0xC")]
      private LoadRequest mLoadRequest;
      [Token(Token = "0x400247B")]
      [FieldOffset(Offset = "0x10")]
      private SceneBattle mScene;
      [Token(Token = "0x400247C")]
      [FieldOffset(Offset = "0x14")]
      private bool mIsFinished;
      [Token(Token = "0x400247D")]
      [FieldOffset(Offset = "0x18")]
      private Unit mSpawnUnit;

      [Token(Token = "0x60034A8")]
      [Address(RVA = "0x10482D0", Offset = "0x10470D0", VA = "0x110482D0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034A9")]
      [Address(RVA = "0x1048250", Offset = "0x1047050", VA = "0x11048250")]
      private IEnumerator AsyncWork(Unit unit, Unit kill_unit) => (IEnumerator) null;

      [Token(Token = "0x60034AA")]
      [Address(RVA = "0x1048420", Offset = "0x1047220", VA = "0x11048420", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034AB")]
      [Address(RVA = "0x1048570", Offset = "0x1047370", VA = "0x11048570")]
      public State_SpawnUnit()
      {
      }
    }

    [Token(Token = "0x2000CF3")]
    private class State_UnitWithdraw : State<SceneBattle>
    {
      [Token(Token = "0x4002489")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsFinished;

      [Token(Token = "0x60034B4")]
      [Address(RVA = "0x1048BB0", Offset = "0x10479B0", VA = "0x11048BB0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034B5")]
      [Address(RVA = "0x1048B40", Offset = "0x1047940", VA = "0x11048B40")]
      private IEnumerator AsyncWork(Unit unit) => (IEnumerator) null;

      [Token(Token = "0x60034B6")]
      [Address(RVA = "0x1048CC0", Offset = "0x1047AC0", VA = "0x11048CC0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034B7")]
      [Address(RVA = "0x1048D20", Offset = "0x1047B20", VA = "0x11048D20")]
      public State_UnitWithdraw()
      {
      }
    }

    [Token(Token = "0x2000CF5")]
    private class State_CancelTransform : State<SceneBattle>
    {
      [Token(Token = "0x400248F")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsFinished;

      [Token(Token = "0x60034BE")]
      [Address(RVA = "0x1042630", Offset = "0x1041430", VA = "0x11042630", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034BF")]
      [Address(RVA = "0x10425A0", Offset = "0x10413A0", VA = "0x110425A0")]
      private IEnumerator AsyncWork(Unit from_unit, Unit next_unit, DynamicTransformUnitParam dtu)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x60034C0")]
      [Address(RVA = "0x1042790", Offset = "0x1041590", VA = "0x11042790", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034C1")]
      [Address(RVA = "0x10427F0", Offset = "0x10415F0", VA = "0x110427F0")]
      public State_CancelTransform()
      {
      }
    }

    [Token(Token = "0x2000CF8")]
    private class State_Inspiration : State<SceneBattle>
    {
      [Token(Token = "0x400249E")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsFinished;

      [Token(Token = "0x60034CA")]
      [Address(RVA = "0x1042F30", Offset = "0x1041D30", VA = "0x11042F30", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034CB")]
      [Address(RVA = "0x1043040", Offset = "0x1041E40", VA = "0x11043040")]
      private IEnumerator InspirationEffect(Unit unit) => (IEnumerator) null;

      [Token(Token = "0x60034CC")]
      [Address(RVA = "0x10430B0", Offset = "0x1041EB0", VA = "0x110430B0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034CD")]
      [Address(RVA = "0x1043110", Offset = "0x1041F10", VA = "0x11043110")]
      public State_Inspiration()
      {
      }
    }

    [Token(Token = "0x2000CFA")]
    private class State_ArenaCalc : State<SceneBattle>
    {
      [Token(Token = "0x40024A3")]
      [FieldOffset(Offset = "0xC")]
      private GameObject mGoWin;

      [Token(Token = "0x60034D4")]
      [Address(RVA = "0x10417F0", Offset = "0x10405F0", VA = "0x110417F0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034D5")]
      [Address(RVA = "0x1041830", Offset = "0x1040630", VA = "0x11041830", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034D6")]
      [Address(RVA = "0x1041990", Offset = "0x1040790", VA = "0x11041990")]
      public State_ArenaCalc()
      {
      }
    }

    [Token(Token = "0x2000CFB")]
    private class State_ArenaCalcSkipWait : State<SceneBattle>
    {
      [Token(Token = "0x60034D7")]
      [Address(RVA = "0x1041580", Offset = "0x1040380", VA = "0x11041580", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034D8")]
      [Address(RVA = "0x1041640", Offset = "0x1040440", VA = "0x11041640")]
      public State_ArenaCalcSkipWait()
      {
      }
    }

    [Token(Token = "0x2000CFC")]
    private class State_ArenaCalcSkip : State<SceneBattle>
    {
      [Token(Token = "0x60034D9")]
      [Address(RVA = "0x1041680", Offset = "0x1040480", VA = "0x11041680", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034DA")]
      [Address(RVA = "0x10416B0", Offset = "0x10404B0", VA = "0x110416B0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034DB")]
      [Address(RVA = "0x10417B0", Offset = "0x10405B0", VA = "0x110417B0")]
      public State_ArenaCalcSkip()
      {
      }
    }

    [Token(Token = "0x2000CFD")]
    private class State_GvGCalc : State<SceneBattle>
    {
      [Token(Token = "0x40024A4")]
      [FieldOffset(Offset = "0xC")]
      private GameObject mGoWin;

      [Token(Token = "0x60034DC")]
      [Address(RVA = "0x10417F0", Offset = "0x10405F0", VA = "0x110417F0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034DD")]
      [Address(RVA = "0x1042DC0", Offset = "0x1041BC0", VA = "0x11042DC0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034DE")]
      [Address(RVA = "0x1042EC0", Offset = "0x1041CC0", VA = "0x11042EC0")]
      private IEnumerator sendResultStart(SceneBattle self) => (IEnumerator) null;

      [Token(Token = "0x60034DF")]
      [Address(RVA = "0x1042E80", Offset = "0x1041C80", VA = "0x11042E80")]
      public State_GvGCalc()
      {
      }
    }

    [Token(Token = "0x2000CFF")]
    private class State_DirectionOffSkill : State<SceneBattle>
    {
      [Token(Token = "0x40024A8")]
      [FieldOffset(Offset = "0xC")]
      private IEnumerator mTask;
      [Token(Token = "0x40024A9")]
      [FieldOffset(Offset = "0x10")]
      private IEnumerator mTaskNext;
      [Token(Token = "0x40024AA")]
      [FieldOffset(Offset = "0x14")]
      private LogSkill mActionInfo;
      [Token(Token = "0x40024AB")]
      [FieldOffset(Offset = "0x18")]
      private TacticsUnitController mInstigator;
      [Token(Token = "0x40024AC")]
      [FieldOffset(Offset = "0x1C")]
      private List<TacticsUnitController> mTargets;

      [Token(Token = "0x60034E6")]
      [Address(RVA = "0x1042A10", Offset = "0x1041810", VA = "0x11042A10")]
      private void ResetTask()
      {
      }

      [Token(Token = "0x60034E7")]
      [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
      private void SetTask(IEnumerator enumrator)
      {
      }

      [Token(Token = "0x60034E8")]
      [Address(RVA = "0x10429D0", Offset = "0x10417D0", VA = "0x110429D0")]
      private bool NextTask() => new bool();

      [Token(Token = "0x60034E9")]
      [Address(RVA = "0x1042830", Offset = "0x1041630", VA = "0x11042830", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60034EA")]
      [Address(RVA = "0x1042C10", Offset = "0x1041A10", VA = "0x11042C10", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60034EB")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60034EC")]
      [Address(RVA = "0x1042BA0", Offset = "0x10419A0", VA = "0x11042BA0")]
      private IEnumerator Task_PrepareSkill(SceneBattle self) => (IEnumerator) null;

      [Token(Token = "0x60034ED")]
      [Address(RVA = "0x1042B30", Offset = "0x1041930", VA = "0x11042B30")]
      private IEnumerator Task_MapPrepareSkill(SceneBattle self) => (IEnumerator) null;

      [Token(Token = "0x60034EE")]
      [Address(RVA = "0x1042AC0", Offset = "0x10418C0", VA = "0x11042AC0")]
      private IEnumerator Task_MapPlaySkill(SceneBattle self) => (IEnumerator) null;

      [Token(Token = "0x60034EF")]
      [Address(RVA = "0x1042A50", Offset = "0x1041850", VA = "0x11042A50")]
      private IEnumerator Task_Execute(SceneBattle self) => (IEnumerator) null;

      [Token(Token = "0x60034F0")]
      [Address(RVA = "0x1042D40", Offset = "0x1041B40", VA = "0x11042D40")]
      public State_DirectionOffSkill()
      {
      }

      [Token(Token = "0x2000D00")]
      private enum EndGotoState
      {
        [Token(Token = "0x40024AE")] NONE,
        [Token(Token = "0x40024AF")] WAIT_FOR_LOG,
        [Token(Token = "0x40024B0")] WAITEVENT_SPAWN_SHIELD_EFFECT,
        [Token(Token = "0x40024B1")] SPAWN_SHIELD_EFFECT,
      }
    }

    [Token(Token = "0x2000D06")]
    public enum CameraMode
    {
      [Token(Token = "0x40024D0")] DEFAULT,
      [Token(Token = "0x40024D1")] UPVIEW,
    }

    [Token(Token = "0x2000D07")]
    public enum EMultiPlayCommand
    {
      [Token(Token = "0x40024D3")] NOP,
      [Token(Token = "0x40024D4")] MOVE_START,
      [Token(Token = "0x40024D5")] MOVE,
      [Token(Token = "0x40024D6")] GRID_XY,
      [Token(Token = "0x40024D7")] MOVE_END,
      [Token(Token = "0x40024D8")] MOVE_CANCEL,
      [Token(Token = "0x40024D9")] ENTRY_BATTLE,
      [Token(Token = "0x40024DA")] GRID_EVENT,
      [Token(Token = "0x40024DB")] UNIT_END,
      [Token(Token = "0x40024DC")] UNIT_TIME_LIMIT,
      [Token(Token = "0x40024DD")] UNIT_XYDIR,
      [Token(Token = "0x40024DE")] NUM,
    }

    [Token(Token = "0x2000D08")]
    public class MultiPlayInput
    {
      [Token(Token = "0x40024DF")]
      [FieldOffset(Offset = "0x8")]
      public int b;
      [Token(Token = "0x40024E0")]
      [FieldOffset(Offset = "0xC")]
      public int t;
      [Token(Token = "0x40024E1")]
      [FieldOffset(Offset = "0x10")]
      public int c;
      [Token(Token = "0x40024E2")]
      [FieldOffset(Offset = "0x14")]
      public int u;
      [Token(Token = "0x40024E3")]
      [FieldOffset(Offset = "0x18")]
      public string s;
      [Token(Token = "0x40024E4")]
      [FieldOffset(Offset = "0x1C")]
      public string i;
      [Token(Token = "0x40024E5")]
      [FieldOffset(Offset = "0x20")]
      public int gx;
      [Token(Token = "0x40024E6")]
      [FieldOffset(Offset = "0x24")]
      public int gy;
      [Token(Token = "0x40024E7")]
      [FieldOffset(Offset = "0x28")]
      public int ul;
      [Token(Token = "0x40024E8")]
      [FieldOffset(Offset = "0x2C")]
      public int d;
      [Token(Token = "0x40024E9")]
      [FieldOffset(Offset = "0x30")]
      public float x;
      [Token(Token = "0x40024EA")]
      [FieldOffset(Offset = "0x34")]
      public float z;
      [Token(Token = "0x40024EB")]
      [FieldOffset(Offset = "0x38")]
      public float r;

      [Token(Token = "0x600350C")]
      [Address(RVA = "0x1041230", Offset = "0x1040030", VA = "0x11041230")]
      public bool IsValid(SceneBattle self) => new bool();

      [Token(Token = "0x600350D")]
      [Address(RVA = "0x10414C0", Offset = "0x10402C0", VA = "0x110414C0")]
      public MultiPlayInput()
      {
      }
    }

    [Token(Token = "0x2000D09")]
    public enum EMultiPlayRecvDataHeader
    {
      [Token(Token = "0x40024ED")] NOP,
      [Token(Token = "0x40024EE")] INPUT,
      [Token(Token = "0x40024EF")] CHECK,
      [Token(Token = "0x40024F0")] GOODJOB,
      [Token(Token = "0x40024F1")] CONTINUE,
      [Token(Token = "0x40024F2")] IGNORE_MY_DISCONNECT,
      [Token(Token = "0x40024F3")] FINISH_LOAD,
      [Token(Token = "0x40024F4")] REQUEST_RESUME,
      [Token(Token = "0x40024F5")] RESUME_INFO,
      [Token(Token = "0x40024F6")] RESUME_SUCCESS,
      [Token(Token = "0x40024F7")] SYNC,
      [Token(Token = "0x40024F8")] SYNC_RESUME,
      [Token(Token = "0x40024F9")] VS_RETIRE,
      [Token(Token = "0x40024FA")] VS_RETIRE_COMFIRM,
      [Token(Token = "0x40024FB")] CHEAT_MOVE,
      [Token(Token = "0x40024FC")] CHEAT_MP,
      [Token(Token = "0x40024FD")] CHEAT_RANGE,
      [Token(Token = "0x40024FE")] OTHERPLAYER_DISCONNECT,
      [Token(Token = "0x40024FF")] START_AUTO,
      [Token(Token = "0x4002500")] NUM,
      [Token(Token = "0x4002501")] SYNC_SEND,
    }

    [Token(Token = "0x2000D0A")]
    public enum CHEAT_TYPE
    {
      [Token(Token = "0x4002503")] MOVE,
      [Token(Token = "0x4002504")] MP,
      [Token(Token = "0x4002505")] RANGE,
    }

    [Token(Token = "0x2000D0B")]
    public enum EMultiPlayRecvAutoType
    {
      [Token(Token = "0x4002507")] SetAuto = 1,
      [Token(Token = "0x4002508")] SetDisPlay = 2,
    }

    [Token(Token = "0x2000D0C")]
    public enum EMultiPlayRecvAutoData
    {
      [Token(Token = "0x400250A")] Manual = 1,
      [Token(Token = "0x400250B")] Auto = 2,
    }

    [Token(Token = "0x2000D0D")]
    [MessagePackObject(true)]
    public class MultiPlayRecvData
    {
      [Token(Token = "0x400250C")]
      [FieldOffset(Offset = "0x8")]
      public string qst;
      [Token(Token = "0x400250D")]
      [FieldOffset(Offset = "0xC")]
      public int sq;
      [Token(Token = "0x400250E")]
      [FieldOffset(Offset = "0x10")]
      public int h;
      [Token(Token = "0x400250F")]
      [FieldOffset(Offset = "0x14")]
      public int b;
      [Token(Token = "0x4002510")]
      [FieldOffset(Offset = "0x18")]
      public int pidx;
      [Token(Token = "0x4002511")]
      [FieldOffset(Offset = "0x1C")]
      public int pid;
      [Token(Token = "0x4002512")]
      [FieldOffset(Offset = "0x20")]
      public int uid;
      [Token(Token = "0x4002513")]
      [FieldOffset(Offset = "0x24")]
      public int[] c;
      [Token(Token = "0x4002514")]
      [FieldOffset(Offset = "0x28")]
      public int[] u;
      [Token(Token = "0x4002515")]
      [FieldOffset(Offset = "0x2C")]
      public string[] s;
      [Token(Token = "0x4002516")]
      [FieldOffset(Offset = "0x30")]
      public string[] i;
      [Token(Token = "0x4002517")]
      [FieldOffset(Offset = "0x34")]
      public int[] gx;
      [Token(Token = "0x4002518")]
      [FieldOffset(Offset = "0x38")]
      public int[] gy;
      [Token(Token = "0x4002519")]
      [FieldOffset(Offset = "0x3C")]
      public int[] ul;
      [Token(Token = "0x400251A")]
      [FieldOffset(Offset = "0x40")]
      public int[] d;
      [Token(Token = "0x400251B")]
      [FieldOffset(Offset = "0x44")]
      public float[] x;
      [Token(Token = "0x400251C")]
      [FieldOffset(Offset = "0x48")]
      public float[] z;
      [Token(Token = "0x400251D")]
      [FieldOffset(Offset = "0x4C")]
      public float[] r;

      [Token(Token = "0x600350E")]
      [Address(RVA = "0x1041530", Offset = "0x1040330", VA = "0x11041530")]
      public MultiPlayRecvData()
      {
      }
    }

    [Token(Token = "0x2000D0E")]
    public class MultiPlayRecvBinData
    {
      [Token(Token = "0x400251E")]
      [FieldOffset(Offset = "0x8")]
      public byte[] bin;
      [Token(Token = "0x400251F")]
      [FieldOffset(Offset = "0xC")]
      public byte[] json;
      [Token(Token = "0x4002520")]
      [FieldOffset(Offset = "0x10")]
      public byte[] started;

      [Token(Token = "0x600350F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MultiPlayRecvBinData()
      {
      }
    }

    [Token(Token = "0x2000D0F")]
    public class MultiPlayCheck
    {
      [Token(Token = "0x4002521")]
      [FieldOffset(Offset = "0x8")]
      public int work;
      [Token(Token = "0x4002522")]
      [FieldOffset(Offset = "0xC")]
      public int playerIndex;
      [Token(Token = "0x4002523")]
      [FieldOffset(Offset = "0x10")]
      public int playerID;
      [Token(Token = "0x4002524")]
      [FieldOffset(Offset = "0x14")]
      public int battleTurn;
      [Token(Token = "0x4002525")]
      [FieldOffset(Offset = "0x18")]
      public int[] hp;
      [Token(Token = "0x4002526")]
      [FieldOffset(Offset = "0x1C")]
      public int[] gx;
      [Token(Token = "0x4002527")]
      [FieldOffset(Offset = "0x20")]
      public int[] gy;
      [Token(Token = "0x4002528")]
      [FieldOffset(Offset = "0x24")]
      public int[] dir;
      [Token(Token = "0x4002529")]
      [FieldOffset(Offset = "0x28")]
      public string rnd;

      [Token(Token = "0x6003510")]
      [Address(RVA = "0x1040C90", Offset = "0x103FA90", VA = "0x11040C90")]
      private bool IsEqual(int[] s0, int[] s1) => new bool();

      [Token(Token = "0x6003511")]
      [Address(RVA = "0x1040A30", Offset = "0x103F830", VA = "0x11040A30")]
      public bool IsEqual(SceneBattle.MultiPlayCheck dst) => new bool();

      [Token(Token = "0x6003512")]
      [Address(RVA = "0x1040990", Offset = "0x103F790", VA = "0x11040990")]
      private string GetIntListString(int[] a) => (string) null;

      [Token(Token = "0x6003513")]
      [Address(RVA = "0x1040CE0", Offset = "0x103FAE0", VA = "0x11040CE0", Slot = "3")]
      public override string ToString() => (string) null;

      [Token(Token = "0x6003514")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MultiPlayCheck()
      {
      }
    }

    [Token(Token = "0x2000D10")]
    private enum EDisconnectType
    {
      [Token(Token = "0x400252B")] DISCONNECTED,
      [Token(Token = "0x400252C")] BAN,
      [Token(Token = "0x400252D")] SEQUENCE_ERROR,
    }

    [Token(Token = "0x2000D11")]
    public enum ENotifyDisconnectedPlayerType
    {
      [Token(Token = "0x400252F")] NORMAL,
      [Token(Token = "0x4002530")] OWNER,
      [Token(Token = "0x4002531")] OWNER_AND_I_AM_OWNER,
    }

    [Token(Token = "0x2000D12")]
    public class ReqCreateBreakObjUc
    {
      [Token(Token = "0x4002532")]
      [FieldOffset(Offset = "0x8")]
      public SkillData mSkill;
      [Token(Token = "0x4002533")]
      [FieldOffset(Offset = "0xC")]
      public Unit mTargetUnit;

      [Token(Token = "0x6003515")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public ReqCreateBreakObjUc(SkillData skill, Unit target_unit)
      {
      }
    }

    [Token(Token = "0x2000D13")]
    public class ReqCreateDtuUc
    {
      [Token(Token = "0x4002534")]
      [FieldOffset(Offset = "0x8")]
      public SkillData mSkill;
      [Token(Token = "0x4002535")]
      [FieldOffset(Offset = "0xC")]
      public Unit mTargetUnit;

      [Token(Token = "0x6003516")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public ReqCreateDtuUc(SkillData skill, Unit target_unit)
      {
      }
    }

    [Token(Token = "0x2000D14")]
    private class State_Disconnected : State<SceneBattle>
    {
      [Token(Token = "0x6003517")]
      [Address(RVA = "0x1055DD0", Offset = "0x1054BD0", VA = "0x11055DD0")]
      public State_Disconnected()
      {
      }
    }

    [Token(Token = "0x2000D15")]
    private class State_MultiPlayContinueBase : State<SceneBattle>
    {
      [Token(Token = "0x4002536")]
      [FieldOffset(Offset = "0xC")]
      private List<SceneBattle.State_MultiPlayContinueBase.MultiPlayContinueRequest> mReqPool;
      [Token(Token = "0x4002537")]
      [FieldOffset(Offset = "0x10")]
      private bool mInitFlag;
      [Token(Token = "0x4002538")]
      [FieldOffset(Offset = "0x14")]
      private int mRoomOwnerPlayerID;

      [Token(Token = "0x1700038B")]
      public int Seed
      {
        [Token(Token = "0x6003518"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
        [Token(Token = "0x6003519"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] set
        {
        }
      }

      [Token(Token = "0x1700038C")]
      public long BtlID
      {
        [Token(Token = "0x600351A"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
        {
          return new long();
        }
        [Token(Token = "0x600351B"), Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")] set
        {
        }
      }

      [Token(Token = "0x600351C")]
      [Address(RVA = "0x10582B0", Offset = "0x10570B0", VA = "0x110582B0")]
      private SceneBattle.State_MultiPlayContinueBase.MultiPlayContinueRequest SendMultiPlayContinueRequest(
        SceneBattle self,
        bool flag,
        List<int> units,
        int seed,
        long btlid)
      {
        return (SceneBattle.State_MultiPlayContinueBase.MultiPlayContinueRequest) null;
      }

      [Token(Token = "0x600351D")]
      [Address(RVA = "0x1058580", Offset = "0x1057380", VA = "0x11058580", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600351E")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      protected virtual void OpenUI(bool roomOwner)
      {
      }

      [Token(Token = "0x600351F")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
      protected virtual void CloseUI(bool roomOwner, bool decided)
      {
      }

      [Token(Token = "0x6003520")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")]
      protected virtual void ExecContinue(List<int> units)
      {
      }

      [Token(Token = "0x6003521")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "11")]
      protected virtual void Cancel()
      {
      }

      [Token(Token = "0x6003522")]
      [Address(RVA = "0x1059790", Offset = "0x1058590", VA = "0x11059790")]
      public State_MultiPlayContinueBase()
      {
      }

      [Token(Token = "0x2000D16")]
      protected class MultiPlayContinueRequest
      {
        [Token(Token = "0x400253B")]
        [FieldOffset(Offset = "0x8")]
        public int playerID;
        [Token(Token = "0x400253C")]
        [FieldOffset(Offset = "0xC")]
        public bool flag;
        [Token(Token = "0x400253D")]
        [FieldOffset(Offset = "0x10")]
        public long btlid;
        [Token(Token = "0x400253E")]
        [FieldOffset(Offset = "0x18")]
        public int seed;
        [Token(Token = "0x400253F")]
        [FieldOffset(Offset = "0x1C")]
        public List<int> units;

        [Token(Token = "0x6003523")]
        [Address(RVA = "0x1050950", Offset = "0x104F750", VA = "0x11050950")]
        public MultiPlayContinueRequest()
        {
        }
      }
    }

    [Token(Token = "0x2000D1B")]
    private class State_MultiPlayContinue : SceneBattle.State_MultiPlayContinueBase
    {
      [Token(Token = "0x4002545")]
      [FieldOffset(Offset = "0x28")]
      private bool mOpenMenu;
      [Token(Token = "0x4002546")]
      [FieldOffset(Offset = "0x29")]
      private bool mOpenMenuReq;

      [Token(Token = "0x600352E")]
      [Address(RVA = "0x1059E70", Offset = "0x1058C70", VA = "0x11059E70", Slot = "8")]
      protected override void OpenUI(bool roomOwner)
      {
      }

      [Token(Token = "0x600352F")]
      [Address(RVA = "0x10598A0", Offset = "0x10586A0", VA = "0x110598A0", Slot = "9")]
      protected override void CloseUI(bool roomOwner, bool decided)
      {
      }

      [Token(Token = "0x6003530")]
      [Address(RVA = "0x1059EC0", Offset = "0x1058CC0", VA = "0x11059EC0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003531")]
      [Address(RVA = "0x10598E0", Offset = "0x10586E0", VA = "0x110598E0", Slot = "10")]
      protected override void ExecContinue(List<int> units)
      {
      }

      [Token(Token = "0x6003532")]
      [Address(RVA = "0x1059810", Offset = "0x1058610", VA = "0x11059810", Slot = "11")]
      protected override void Cancel()
      {
      }

      [Token(Token = "0x6003533")]
      [Address(RVA = "0x1059790", Offset = "0x1058590", VA = "0x11059790")]
      public State_MultiPlayContinue()
      {
      }
    }

    [Token(Token = "0x2000D1C")]
    private class State_MultiPlaySync : State<SceneBattle>
    {
      [Token(Token = "0x4002547")]
      [FieldOffset(Offset = "0xC")]
      private bool mSend;
      [Token(Token = "0x4002548")]
      [FieldOffset(Offset = "0xD")]
      private bool mSendResume;
      [Token(Token = "0x4002549")]
      [FieldOffset(Offset = "0x10")]
      private DateTime LoopTime;

      [Token(Token = "0x6003534")]
      [Address(RVA = "0x1059FC0", Offset = "0x1058DC0", VA = "0x11059FC0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003535")]
      [Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x1105A220", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003536")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003537")]
      [Address(RVA = "0x105A060", Offset = "0x1058E60", VA = "0x1105A060")]
      public void SendSync()
      {
      }

      [Token(Token = "0x6003538")]
      [Address(RVA = "0x105A4A0", Offset = "0x10592A0", VA = "0x1105A4A0")]
      public State_MultiPlaySync()
      {
      }
    }

    [Token(Token = "0x2000D1D")]
    private class State_SyncResume : State<SceneBattle>
    {
      [Token(Token = "0x6003539")]
      [Address(RVA = "0x1063FF0", Offset = "0x1062DF0", VA = "0x11063FF0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600353A")]
      [Address(RVA = "0x1064020", Offset = "0x1062E20", VA = "0x11064020", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600353B")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600353C")]
      [Address(RVA = "0x1064070", Offset = "0x1062E70", VA = "0x11064070")]
      public State_SyncResume()
      {
      }
    }

    [Token(Token = "0x2000D1E")]
    private class State_MapCommandVersus : State<SceneBattle>
    {
      [Token(Token = "0x600353D")]
      [Address(RVA = "0x1057970", Offset = "0x1056770", VA = "0x11057970", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600353E")]
      [Address(RVA = "0x1058040", Offset = "0x1056E40", VA = "0x11058040", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600353F")]
      [Address(RVA = "0x1057CC0", Offset = "0x1056AC0", VA = "0x11057CC0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003540")]
      [Address(RVA = "0x1057E60", Offset = "0x1056C60", VA = "0x11057E60")]
      private void SyncCameraPosition(SceneBattle self)
      {
      }

      [Token(Token = "0x6003541")]
      [Address(RVA = "0x1057D60", Offset = "0x1056B60", VA = "0x11057D60")]
      private void OnCommandSelect(UnitCommands.CommandTypes command, object ability)
      {
      }

      [Token(Token = "0x6003542")]
      [Address(RVA = "0x10580B0", Offset = "0x1056EB0", VA = "0x110580B0")]
      public State_MapCommandVersus()
      {
      }
    }

    [Token(Token = "0x2000D1F")]
    private class State_ComfirmFinishbattle : State<SceneBattle>
    {
      [Token(Token = "0x400254A")]
      [FieldOffset(Offset = "0xC")]
      private bool mIsFadeIn;

      [Token(Token = "0x6003543")]
      [Address(RVA = "0x1055C70", Offset = "0x1054A70", VA = "0x11055C70", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003544")]
      [Address(RVA = "0x1055CD0", Offset = "0x1054AD0", VA = "0x11055CD0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003545")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003546")]
      [Address(RVA = "0x1055D90", Offset = "0x1054B90", VA = "0x11055D90")]
      public State_ComfirmFinishbattle()
      {
      }
    }

    [Token(Token = "0x2000D20")]
    private class State_ForceWinComfirm : State<SceneBattle>
    {
      [Token(Token = "0x6003547")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003548")]
      [Address(RVA = "0x1055E10", Offset = "0x1054C10", VA = "0x11055E10", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003549")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600354A")]
      [Address(RVA = "0x1055E90", Offset = "0x1054C90", VA = "0x11055E90")]
      public State_ForceWinComfirm()
      {
      }
    }

    [Token(Token = "0x2000D21")]
    private class State_AudienceRetire : State<SceneBattle>
    {
      [Token(Token = "0x400254B")]
      [FieldOffset(Offset = "0xC")]
      private bool mClose;

      [Token(Token = "0x600354B")]
      [Address(RVA = "0x1055AD0", Offset = "0x10548D0", VA = "0x11055AD0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600354C")]
      [Address(RVA = "0x1055BE0", Offset = "0x10549E0", VA = "0x11055BE0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600354D")]
      [Address(RVA = "0x2E2F20", Offset = "0x2E1D20", VA = "0x102E2F20")]
      public void ClickEvent(GameObject go)
      {
      }

      [Token(Token = "0x600354E")]
      [Address(RVA = "0x1055C30", Offset = "0x1054A30", VA = "0x11055C30")]
      public State_AudienceRetire()
      {
      }
    }

    [Token(Token = "0x2000D22")]
    private class State_AudienceEnd : State<SceneBattle>
    {
      [Token(Token = "0x600354F")]
      [Address(RVA = "0x1055870", Offset = "0x1054670", VA = "0x11055870", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003550")]
      [Address(RVA = "0x1055910", Offset = "0x1054710", VA = "0x11055910")]
      public State_AudienceEnd()
      {
      }
    }

    [Token(Token = "0x2000D23")]
    private class State_AudienceForceEnd : State<SceneBattle>
    {
      [Token(Token = "0x400254C")]
      [FieldOffset(Offset = "0xC")]
      private bool mClose;

      [Token(Token = "0x6003551")]
      [Address(RVA = "0x1055950", Offset = "0x1054750", VA = "0x11055950", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003552")]
      [Address(RVA = "0x1055A40", Offset = "0x1054840", VA = "0x11055A40", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003553")]
      [Address(RVA = "0x2E2F20", Offset = "0x2E1D20", VA = "0x102E2F20")]
      public void ClickEvent(GameObject go)
      {
      }

      [Token(Token = "0x6003554")]
      [Address(RVA = "0x1055A90", Offset = "0x1054890", VA = "0x11055A90")]
      public State_AudienceForceEnd()
      {
      }
    }

    [Token(Token = "0x2000D24")]
    private class MultiPlayer
    {
      [Token(Token = "0x4002557")]
      [FieldOffset(Offset = "0x24")]
      private List<int> AutoTurn;

      [Token(Token = "0x1700038D")]
      public int PlayerIndex
      {
        [Token(Token = "0x6003555"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6003556"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x1700038E")]
      public int PlayerID
      {
        [Token(Token = "0x6003557"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x6003558"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x1700038F")]
      public bool NotifyDisconnected
      {
        [Token(Token = "0x6003559"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
        {
          return new bool();
        }
        [Token(Token = "0x600355A"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
        {
        }
      }

      [Token(Token = "0x17000390")]
      public bool Disconnected
      {
        [Token(Token = "0x600355B"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
        {
          return new bool();
        }
        [Token(Token = "0x600355C"), Address(RVA = "0xAB3920", Offset = "0xAB2720", VA = "0x10AB3920")] set
        {
        }
      }

      [Token(Token = "0x17000391")]
      public int RecvInputNum
      {
        [Token(Token = "0x600355D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x600355E"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] set
        {
        }
      }

      [Token(Token = "0x17000392")]
      public bool FinishLoad
      {
        [Token(Token = "0x600355F"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003560"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] set
        {
        }
      }

      [Token(Token = "0x17000393")]
      public bool SyncWait
      {
        [Token(Token = "0x6003561"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003562"), Address(RVA = "0x4082C0", Offset = "0x4070C0", VA = "0x104082C0")] set
        {
        }
      }

      [Token(Token = "0x17000394")]
      public int SyncTrun
      {
        [Token(Token = "0x6003563"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6003564"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
        {
        }
      }

      [Token(Token = "0x17000395")]
      public bool SyncResumeWait
      {
        [Token(Token = "0x6003565"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003566"), Address(RVA = "0x305F50", Offset = "0x304D50", VA = "0x10305F50")] set
        {
        }
      }

      [Token(Token = "0x17000396")]
      public bool StartBegin
      {
        [Token(Token = "0x6003567"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003568"), Address(RVA = "0x305F40", Offset = "0x304D40", VA = "0x10305F40")] set
        {
        }
      }

      [Token(Token = "0x17000397")]
      public bool IsAutoPlayer
      {
        [Token(Token = "0x6003569"), Address(RVA = "0x1055600", Offset = "0x1054400", VA = "0x11055600")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17000398")]
      public bool IsAutoTreasure
      {
        [Token(Token = "0x600356A"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
        {
          return new bool();
        }
        [Token(Token = "0x600356B"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] private set
        {
        }
      }

      [Token(Token = "0x17000399")]
      public bool IsAutoNoSkill
      {
        [Token(Token = "0x600356C"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
        {
          return new bool();
        }
        [Token(Token = "0x600356D"), Address(RVA = "0xAAFB60", Offset = "0xAAE960", VA = "0x10AAFB60")] private set
        {
        }
      }

      [Token(Token = "0x1700039A")]
      public bool IsSupportAI
      {
        [Token(Token = "0x600356E"), Address(RVA = "0x51AB90", Offset = "0x519990", VA = "0x1051AB90")] get
        {
          return new bool();
        }
        [Token(Token = "0x600356F"), Address(RVA = "0x1055690", Offset = "0x1054490", VA = "0x11055690")] private set
        {
        }
      }

      [Token(Token = "0x1700039B")]
      public bool IsAutoForDisplay
      {
        [Token(Token = "0x6003570"), Address(RVA = "0x10555F0", Offset = "0x10543F0", VA = "0x110555F0")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003571"), Address(RVA = "0x10554E0", Offset = "0x10542E0", VA = "0x110554E0")] private set
        {
        }
      }

      [Token(Token = "0x6003572")]
      [Address(RVA = "0x10554F0", Offset = "0x10542F0", VA = "0x110554F0")]
      public MultiPlayer(
        SceneBattle self,
        int playerIndex,
        int playerID,
        bool isSupport = false,
        bool isAutoTreasure = false,
        bool isAutoNoSkill = false,
        bool isAuto = false)
      {
      }

      [Token(Token = "0x6003573")]
      [Address(RVA = "0x1055420", Offset = "0x1054220", VA = "0x11055420")]
      public void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003574")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
      public void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003575")]
      [Address(RVA = "0x1055430", Offset = "0x1054230", VA = "0x11055430")]
      public void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003576")]
      [Address(RVA = "0x1055440", Offset = "0x1054240", VA = "0x11055440")]
      public void SetAutoTurn(int turn)
      {
      }

      [Token(Token = "0x6003577")]
      [Address(RVA = "0x10554E0", Offset = "0x10542E0", VA = "0x110554E0")]
      public void ToggleAutoPlay(bool enable)
      {
      }
    }

    [Token(Token = "0x2000D25")]
    private class MultiPlayerUnit
    {
      [Token(Token = "0x400255E")]
      [FieldOffset(Offset = "0x10")]
      private Unit mUnit;
      [Token(Token = "0x400255F")]
      [FieldOffset(Offset = "0x14")]
      private EUnitDirection mDir;
      [Token(Token = "0x4002560")]
      [FieldOffset(Offset = "0x18")]
      private int mGridX;
      [Token(Token = "0x4002561")]
      [FieldOffset(Offset = "0x1C")]
      private int mGridY;
      [Token(Token = "0x4002562")]
      [FieldOffset(Offset = "0x20")]
      private int mTargetX;
      [Token(Token = "0x4002563")]
      [FieldOffset(Offset = "0x24")]
      private int mTargetY;
      [Token(Token = "0x4002564")]
      [FieldOffset(Offset = "0x28")]
      private SceneBattle.MultiPlayerUnit.EGridSnap mGridSnap;
      [Token(Token = "0x4002565")]
      [FieldOffset(Offset = "0x2C")]
      private bool mIsRunning;
      [Token(Token = "0x4002566")]
      [FieldOffset(Offset = "0x30")]
      private List<SceneBattle.MultiPlayInput> mRecv;
      [Token(Token = "0x4002567")]
      [FieldOffset(Offset = "0x34")]
      private int mRecvTurnNum;
      [Token(Token = "0x4002568")]
      [FieldOffset(Offset = "0x38")]
      private int mCurrentTurn;
      [Token(Token = "0x4002569")]
      [FieldOffset(Offset = "0x3C")]
      private float mTurnSec;
      [Token(Token = "0x400256A")]
      [FieldOffset(Offset = "0x40")]
      private int mTurnCmdNum;
      [Token(Token = "0x400256B")]
      [FieldOffset(Offset = "0x44")]
      private int mTurnCmdDoneNum;
      [Token(Token = "0x400256C")]
      [FieldOffset(Offset = "0x48")]
      private GridMap<int> mMoveGrid;
      [Token(Token = "0x400256D")]
      [FieldOffset(Offset = "0x4C")]
      private bool mBegin;

      [Token(Token = "0x1700039C")]
      public SceneBattle.MultiPlayer Owner
      {
        [Token(Token = "0x6003578"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (SceneBattle.MultiPlayer) null;
        }
        [Token(Token = "0x6003579"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x1700039D")]
      public int UnitID
      {
        [Token(Token = "0x600357A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x600357B"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x1700039E")]
      public Unit Unit
      {
        [Token(Token = "0x600357C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (Unit) null;
        }
      }

      [Token(Token = "0x600357D")]
      [Address(RVA = "0x10520E0", Offset = "0x1050EE0", VA = "0x110520E0")]
      public void SetUnit(int index, Unit unit)
      {
      }

      [Token(Token = "0x600357E")]
      [Address(RVA = "0x1051670", Offset = "0x1050470", VA = "0x11051670")]
      public bool IsMoveCompleted(
        SceneBattle self,
        int x,
        int y,
        TacticsUnitController controller)
      {
        return new bool();
      }

      [Token(Token = "0x1700039F")]
      public bool IsExistRecvData
      {
        [Token(Token = "0x600357F"), Address(RVA = "0x10553E0", Offset = "0x10541E0", VA = "0x110553E0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6003580")]
      [Address(RVA = "0x1055100", Offset = "0x1053F00", VA = "0x11055100")]
      public MultiPlayerUnit(
        SceneBattle self,
        int unitID,
        Unit unit,
        SceneBattle.MultiPlayer owner)
      {
      }

      [Token(Token = "0x6003581")]
      [Address(RVA = "0x1051810", Offset = "0x1050610", VA = "0x11051810")]
      public void RecvInput(SceneBattle self, SceneBattle.MultiPlayRecvData data)
      {
      }

      [Token(Token = "0x6003582")]
      [Address(RVA = "0x10509C0", Offset = "0x104F7C0", VA = "0x110509C0")]
      public void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003583")]
      [Address(RVA = "0x10511A0", Offset = "0x104FFA0", VA = "0x110511A0")]
      public void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003584")]
      [Address(RVA = "0x10515F0", Offset = "0x10503F0", VA = "0x110515F0")]
      private Vector3 GetPosition3D(SceneBattle self, float x, float z) => new Vector3();

      [Token(Token = "0x6003585")]
      [Address(RVA = "0x1051150", Offset = "0x104FF50", VA = "0x11051150")]
      private bool CheckMoveable(int x, int y) => new bool();

      [Token(Token = "0x6003586")]
      [Address(RVA = "0x1052980", Offset = "0x1051780", VA = "0x11052980")]
      public void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003587")]
      [Address(RVA = "0x1051700", Offset = "0x1050500", VA = "0x11051700")]
      private void Move(SceneBattle self, int tx, int ty)
      {
      }

      [Token(Token = "0x6003588")]
      [Address(RVA = "0x1052130", Offset = "0x1050F30", VA = "0x11052130")]
      public void UpdateSkip(SceneBattle self)
      {
      }

      [Token(Token = "0x2000D26")]
      private enum EGridSnap
      {
        [Token(Token = "0x400256F")] NOP,
        [Token(Token = "0x4002570")] ACTIVE,
        [Token(Token = "0x4002571")] DONE,
        [Token(Token = "0x4002572")] NUM,
      }
    }

    [Token(Token = "0x2000D28")]
    public enum TargetActionTypes
    {
      [Token(Token = "0x4002575")] None,
      [Token(Token = "0x4002576")] Attack,
      [Token(Token = "0x4002577")] Skill,
      [Token(Token = "0x4002578")] Heal,
    }

    [Token(Token = "0x2000D29")]
    private class State_WaitSignal<T> : State<SceneBattle> where T : State<SceneBattle>, new()
    {
      [Token(Token = "0x600358C")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600358D")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600358E")]
      public State_WaitSignal()
      {
      }
    }

    [Token(Token = "0x2000D2A")]
    private class State_LoadMapV2 : State<SceneBattle>
    {
      [Token(Token = "0x4002579")]
      [FieldOffset(Offset = "0xC")]
      private bool mReady;

      [Token(Token = "0x600358F")]
      [Address(RVA = "0x1055ED0", Offset = "0x1054CD0", VA = "0x11055ED0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003590")]
      [Address(RVA = "0x1056000", Offset = "0x1054E00", VA = "0x11056000", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003591")]
      [Address(RVA = "0x10563E0", Offset = "0x10551E0", VA = "0x110563E0")]
      public State_LoadMapV2()
      {
      }
    }

    [Token(Token = "0x2000D2B")]
    private class State_StartEvent : State<SceneBattle>
    {
      [Token(Token = "0x400257A")]
      [FieldOffset(Offset = "0xC")]
      private EventScript.Sequence mSequence;

      [Token(Token = "0x6003592")]
      [Address(RVA = "0x1063AD0", Offset = "0x10628D0", VA = "0x11063AD0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003593")]
      [Address(RVA = "0x1063F20", Offset = "0x1062D20", VA = "0x11063F20", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003594")]
      [Address(RVA = "0x1063BA0", Offset = "0x10629A0", VA = "0x11063BA0")]
      private void Finish()
      {
      }

      [Token(Token = "0x6003595")]
      [Address(RVA = "0x1063FB0", Offset = "0x1062DB0", VA = "0x11063FB0")]
      public State_StartEvent()
      {
      }
    }

    [Token(Token = "0x2000D2C")]
    private class State_MapStartV2 : State<SceneBattle>
    {
      [Token(Token = "0x6003596")]
      [Address(RVA = "0x10580F0", Offset = "0x1056EF0", VA = "0x110580F0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003597")]
      [Address(RVA = "0x1058270", Offset = "0x1057070", VA = "0x11058270")]
      public State_MapStartV2()
      {
      }
    }

    [Token(Token = "0x2000D2D")]
    private class State_PreUnitStart : State<SceneBattle>
    {
      [Token(Token = "0x400257B")]
      [FieldOffset(Offset = "0xC")]
      private IEnumerator m_Task;

      [Token(Token = "0x6003598")]
      [Address(RVA = "0x105A760", Offset = "0x1059560", VA = "0x1105A760")]
      private IEnumerator Task_Begin(SceneBattle self) => (IEnumerator) null;

      [Token(Token = "0x6003599")]
      [Address(RVA = "0x105A6E0", Offset = "0x10594E0", VA = "0x1105A6E0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600359A")]
      [Address(RVA = "0x105A7D0", Offset = "0x10595D0", VA = "0x1105A7D0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x600359B")]
      [Address(RVA = "0x105AA40", Offset = "0x1059840", VA = "0x1105AA40")]
      public State_PreUnitStart()
      {
      }
    }

    [Token(Token = "0x2000D2F")]
    private class State_UnitStartV2 : State<SceneBattle>
    {
      [Token(Token = "0x60035A2")]
      [Address(RVA = "0x1066560", Offset = "0x1065360", VA = "0x11066560", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035A3")]
      [Address(RVA = "0x10667B0", Offset = "0x10655B0", VA = "0x110667B0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60035A4")]
      [Address(RVA = "0x1066F10", Offset = "0x1065D10", VA = "0x11066F10")]
      public State_UnitStartV2()
      {
      }
    }

    [Token(Token = "0x2000D30")]
    private class State_WaitFade<T> : State<SceneBattle> where T : State<SceneBattle>, new()
    {
      [Token(Token = "0x60035A5")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035A6")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60035A7")]
      public State_WaitFade()
      {
      }
    }

    [Token(Token = "0x2000D31")]
    private class State_WaitEvent<T> : State<SceneBattle> where T : State<SceneBattle>, new()
    {
      [Token(Token = "0x60035A8")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035A9")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60035AA")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60035AB")]
      public State_WaitEvent()
      {
      }
    }

    [Token(Token = "0x2000D32")]
    private class State_MapCommandV2 : State<SceneBattle>
    {
      [Token(Token = "0x4002580")]
      [FieldOffset(Offset = "0xC")]
      private Unit mQueuedTarget;
      [Token(Token = "0x4002581")]
      [FieldOffset(Offset = "0x10")]
      private UnitCommands.CommandTypes mQueuedCommand;
      [Token(Token = "0x4002582")]
      [FieldOffset(Offset = "0x14")]
      private object mSelectedAbility;
      [Token(Token = "0x4002583")]
      [FieldOffset(Offset = "0x18")]
      private bool mShouldRefreshCommands;
      [Token(Token = "0x4002584")]
      [FieldOffset(Offset = "0x19")]
      private bool mMoved;
      [Token(Token = "0x4002585")]
      [FieldOffset(Offset = "0x1C")]
      private int mStartX;
      [Token(Token = "0x4002586")]
      [FieldOffset(Offset = "0x20")]
      private int mStartY;
      [Token(Token = "0x4002587")]
      [FieldOffset(Offset = "0x24")]
      private Unit mCurrentUnit;
      [Token(Token = "0x4002588")]
      [FieldOffset(Offset = "0x28")]
      private int mHotTargets;
      [Token(Token = "0x4002589")]
      [FieldOffset(Offset = "0x2C")]
      private TacticsUnitController mCurrentController;

      [Token(Token = "0x60035AC")]
      [Address(RVA = "0x1056420", Offset = "0x1055220", VA = "0x11056420", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035AD")]
      [Address(RVA = "0x1056870", Offset = "0x1055670", VA = "0x11056870")]
      private void CanNotMove()
      {
      }

      [Token(Token = "0x60035AE")]
      [Address(RVA = "0x10568D0", Offset = "0x10556D0", VA = "0x110568D0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60035AF")]
      [Address(RVA = "0x1057340", Offset = "0x1056140", VA = "0x11057340", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x170003A2")]
      private bool IsInputBusy
      {
        [Token(Token = "0x60035B0"), Address(RVA = "0x1057930", Offset = "0x1056730", VA = "0x11057930")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170003A3")]
      private bool IsGridValid
      {
        [Token(Token = "0x60035B1"), Address(RVA = "0x1057900", Offset = "0x1056700", VA = "0x11057900")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x60035B2")]
      [Address(RVA = "0x1056A50", Offset = "0x1055850", VA = "0x11056A50")]
      private void OnTargetSelect(Unit target)
      {
      }

      [Token(Token = "0x60035B3")]
      [Address(RVA = "0x1056BB0", Offset = "0x10559B0", VA = "0x11056BB0")]
      private void SelectAttackTarget(Unit target)
      {
      }

      [Token(Token = "0x60035B4")]
      [Address(RVA = "0x1056F30", Offset = "0x1055D30", VA = "0x11056F30")]
      private void SelectCommand(UnitCommands.CommandTypes command, object ability)
      {
      }

      [Token(Token = "0x60035B5")]
      [Address(RVA = "0x10569B0", Offset = "0x10557B0", VA = "0x110569B0")]
      private void OnCommandSelect(UnitCommands.CommandTypes command, object ability)
      {
      }

      [Token(Token = "0x60035B6")]
      [Address(RVA = "0x1056AF0", Offset = "0x10558F0", VA = "0x11056AF0")]
      private void OnUnitChgSelect()
      {
      }

      [Token(Token = "0x60035B7")]
      [Address(RVA = "0x10578C0", Offset = "0x10566C0", VA = "0x110578C0")]
      public State_MapCommandV2()
      {
      }
    }

    [Token(Token = "0x2000D33")]
    private class State_SelectItemV2 : State<SceneBattle>
    {
      [Token(Token = "0x60035B8")]
      [Address(RVA = "0x105AA80", Offset = "0x1059880", VA = "0x1105AA80", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035B9")]
      [Address(RVA = "0x105ABD0", Offset = "0x10599D0", VA = "0x1105ABD0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60035BA")]
      [Address(RVA = "0x105AC90", Offset = "0x1059A90", VA = "0x1105AC90")]
      private void OnSelectItem(ItemData itemData)
      {
      }

      [Token(Token = "0x60035BB")]
      [Address(RVA = "0x105AE10", Offset = "0x1059C10", VA = "0x1105AE10")]
      private void OnStateChange(SceneBattle.StateTransitionTypes req)
      {
      }

      [Token(Token = "0x60035BC")]
      [Address(RVA = "0x105AE60", Offset = "0x1059C60", VA = "0x1105AE60")]
      public State_SelectItemV2()
      {
      }
    }

    [Token(Token = "0x2000D34")]
    private class State_SelectUnitChgV2 : State<SceneBattle>
    {
      [Token(Token = "0x400258A")]
      [FieldOffset(Offset = "0xC")]
      private Unit mUnitChgTo;
      [Token(Token = "0x400258B")]
      [FieldOffset(Offset = "0x10")]
      private List<Unit> mTargets;

      [Token(Token = "0x60035BD")]
      [Address(RVA = "0x1062930", Offset = "0x1061730", VA = "0x11062930", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035BE")]
      [Address(RVA = "0x1062C70", Offset = "0x1061A70", VA = "0x11062C70", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60035BF")]
      [Address(RVA = "0x1062DF0", Offset = "0x1061BF0", VA = "0x11062DF0")]
      private void OnSelectUnit(Unit unit_chg_to)
      {
      }

      [Token(Token = "0x60035C0")]
      [Address(RVA = "0x10633D0", Offset = "0x10621D0", VA = "0x110633D0")]
      private void OnStateChange(SceneBattle.StateTransitionTypes req)
      {
      }

      [Token(Token = "0x60035C1")]
      [Address(RVA = "0x10638F0", Offset = "0x10626F0", VA = "0x110638F0")]
      private void ShiftTarget(int delta)
      {
      }

      [Token(Token = "0x60035C2")]
      [Address(RVA = "0x1062DA0", Offset = "0x1061BA0", VA = "0x11062DA0")]
      private void OnNextTargetClick(GameObject go)
      {
      }

      [Token(Token = "0x60035C3")]
      [Address(RVA = "0x1062DC0", Offset = "0x1061BC0", VA = "0x11062DC0")]
      private void OnPrevTargetClick(GameObject go)
      {
      }

      [Token(Token = "0x60035C4")]
      [Address(RVA = "0x1063430", Offset = "0x1062230", VA = "0x11063430")]
      private void OnYesNoSelect(bool yes)
      {
      }

      [Token(Token = "0x60035C5")]
      [Address(RVA = "0x1063A50", Offset = "0x1062850", VA = "0x11063A50")]
      public State_SelectUnitChgV2()
      {
      }
    }

    [Token(Token = "0x2000D35")]
    private delegate void SelectTargetCallback();

    [Token(Token = "0x2000D36")]
    private delegate void SelectTargetPositionWithSkill(
      int x,
      int y,
      SkillData skill,
      bool bUnitTarget);

    [Token(Token = "0x2000D37")]
    private delegate void SelectTargetPositionWithItem(int x, int y, ItemData item);

    [Token(Token = "0x2000D38")]
    private struct TargetSelectorParam
    {
      [Token(Token = "0x400258C")]
      [FieldOffset(Offset = "0x0")]
      public ItemData Item;
      [Token(Token = "0x400258D")]
      [FieldOffset(Offset = "0x4")]
      public SkillData Skill;
      [Token(Token = "0x400258E")]
      [FieldOffset(Offset = "0x8")]
      public SceneBattle.SelectTargetCallback OnCancel;
      [Token(Token = "0x400258F")]
      [FieldOffset(Offset = "0xC")]
      public object OnAccept;
      [Token(Token = "0x4002590")]
      [FieldOffset(Offset = "0x10")]
      public Unit DefaultTarget;
      [Token(Token = "0x4002591")]
      [FieldOffset(Offset = "0x14")]
      public bool AllowTargetChange;
      [Token(Token = "0x4002592")]
      [FieldOffset(Offset = "0x15")]
      public bool IsThrowTargetSelect;
      [Token(Token = "0x4002593")]
      [FieldOffset(Offset = "0x18")]
      public Unit DefaultThrowTarget;
      [Token(Token = "0x4002594")]
      [FieldOffset(Offset = "0x1C")]
      public Unit ThrowTarget;
    }

    [Token(Token = "0x2000D39")]
    private class State_PreThrowTargetSelect : State<SceneBattle>
    {
      [Token(Token = "0x60035D2")]
      [Address(RVA = "0x105A630", Offset = "0x1059430", VA = "0x1105A630", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035D3")]
      [Address(RVA = "0x105A6A0", Offset = "0x10594A0", VA = "0x1105A6A0")]
      public State_PreThrowTargetSelect()
      {
      }
    }

    [Token(Token = "0x2000D3A")]
    private class State_ThrowTargetSelect : State<SceneBattle>
    {
      [Token(Token = "0x4002595")]
      private const int THROW_TARGET_RANGE = 1;
      [Token(Token = "0x4002596")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController mSelectedTarget;
      [Token(Token = "0x4002597")]
      [FieldOffset(Offset = "0x10")]
      private GridMap<bool> mTargetGrids;
      [Token(Token = "0x4002598")]
      [FieldOffset(Offset = "0x14")]
      private IntVector2 mTargetPosition;
      [Token(Token = "0x4002599")]
      [FieldOffset(Offset = "0x1C")]
      private List<TacticsUnitController> mTargets;
      [Token(Token = "0x400259A")]
      [FieldOffset(Offset = "0x20")]
      private bool mDragScroll;
      [Token(Token = "0x400259B")]
      [FieldOffset(Offset = "0x24")]
      private float mYScrollPos;
      [Token(Token = "0x400259C")]
      [FieldOffset(Offset = "0x28")]
      private bool mIgnoreDragVelocity;
      [Token(Token = "0x400259D")]
      [FieldOffset(Offset = "0x2C")]
      private float mDragY;
      [Token(Token = "0x400259E")]
      [FieldOffset(Offset = "0x30")]
      private bool mIsValidFtgt;

      [Token(Token = "0x60035D4")]
      [Address(RVA = "0x10640B0", Offset = "0x1062EB0", VA = "0x110640B0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035D5")]
      [Address(RVA = "0x10663E0", Offset = "0x10651E0", VA = "0x110663E0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x60035D6")]
      [Address(RVA = "0x1064D50", Offset = "0x1063B50", VA = "0x11064D50", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60035D7")]
      [Address(RVA = "0x10661C0", Offset = "0x1064FC0", VA = "0x110661C0")]
      private void SetYesButtonEnable(bool enable)
      {
      }

      [Token(Token = "0x60035D8")]
      [Address(RVA = "0x1065FA0", Offset = "0x1064DA0", VA = "0x11065FA0")]
      private void OnYesNoSelect(bool yes)
      {
      }

      [Token(Token = "0x60035D9")]
      [Address(RVA = "0x1065100", Offset = "0x1063F00", VA = "0x11065100")]
      private bool IsGridSelectable(int x, int y) => new bool();

      [Token(Token = "0x60035DA")]
      [Address(RVA = "0x1065260", Offset = "0x1064060", VA = "0x11065260")]
      private bool IsGridSelectable(Unit unit) => new bool();

      [Token(Token = "0x60035DB")]
      [Address(RVA = "0x1065370", Offset = "0x1064170", VA = "0x11065370")]
      private bool IsThrowValidForcedTargeting(Unit target_unit = null) => new bool();

      [Token(Token = "0x60035DC")]
      [Address(RVA = "0x1065530", Offset = "0x1064330", VA = "0x11065530")]
      private void OnFocus(TacticsUnitController controller, Grid focus_grid = null)
      {
      }

      [Token(Token = "0x60035DD")]
      [Address(RVA = "0x10653C0", Offset = "0x10641C0", VA = "0x110653C0")]
      private void OnClickUnit(TacticsUnitController controller)
      {
      }

      [Token(Token = "0x60035DE")]
      [Address(RVA = "0x1066270", Offset = "0x1065070", VA = "0x11066270")]
      private void ShiftTarget(int delta)
      {
      }

      [Token(Token = "0x60035DF")]
      [Address(RVA = "0x1065F60", Offset = "0x1064D60", VA = "0x11065F60")]
      private void OnNextTargetClick(GameObject go)
      {
      }

      [Token(Token = "0x60035E0")]
      [Address(RVA = "0x1065F80", Offset = "0x1064D80", VA = "0x11065F80")]
      private void OnPrevTargetClick(GameObject go)
      {
      }

      [Token(Token = "0x60035E1")]
      [Address(RVA = "0x10654C0", Offset = "0x10642C0", VA = "0x110654C0")]
      private void OnDrag()
      {
      }

      [Token(Token = "0x60035E2")]
      [Address(RVA = "0x10654A0", Offset = "0x10642A0", VA = "0x110654A0")]
      private void OnDragEnd()
      {
      }

      [Token(Token = "0x60035E3")]
      [Address(RVA = "0x10664E0", Offset = "0x10652E0", VA = "0x110664E0")]
      public State_ThrowTargetSelect()
      {
      }
    }

    [Token(Token = "0x2000D3C")]
    private class State_PreSelectTargetV2 : State<SceneBattle>
    {
      [Token(Token = "0x60035E6")]
      [Address(RVA = "0x105A580", Offset = "0x1059380", VA = "0x1105A580", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035E7")]
      [Address(RVA = "0x105A5F0", Offset = "0x10593F0", VA = "0x1105A5F0")]
      public State_PreSelectTargetV2()
      {
      }
    }

    [Token(Token = "0x2000D3D")]
    private class State_PreMapviewV2 : State<SceneBattle>
    {
      [Token(Token = "0x60035E8")]
      [Address(RVA = "0x105A4E0", Offset = "0x10592E0", VA = "0x1105A4E0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035E9")]
      [Address(RVA = "0x105A540", Offset = "0x1059340", VA = "0x1105A540")]
      public State_PreMapviewV2()
      {
      }
    }

    [Token(Token = "0x2000D3E")]
    private class State_SelectTargetV2 : State<SceneBattle>
    {
      [Token(Token = "0x40025A0")]
      [FieldOffset(Offset = "0xC")]
      private SceneBattle mScene;
      [Token(Token = "0x40025A1")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController mSelectedTarget;
      [Token(Token = "0x40025A2")]
      [FieldOffset(Offset = "0x14")]
      private GridMap<bool> mTargetGrids;
      [Token(Token = "0x40025A3")]
      [FieldOffset(Offset = "0x18")]
      private GridMap<bool> mTargetAreaGridMap;
      [Token(Token = "0x40025A4")]
      [FieldOffset(Offset = "0x1C")]
      private bool mSelectGrid;
      [Token(Token = "0x40025A5")]
      [FieldOffset(Offset = "0x20")]
      private IntVector2 mTargetPosition;
      [Token(Token = "0x40025A6")]
      [FieldOffset(Offset = "0x28")]
      private IntVector2 mSelectGridPosition;
      [Token(Token = "0x40025A7")]
      [FieldOffset(Offset = "0x30")]
      private bool mIsNotGridChange;
      [Token(Token = "0x40025A8")]
      [FieldOffset(Offset = "0x34")]
      private List<TacticsUnitController> mTargets;
      [Token(Token = "0x40025A9")]
      [FieldOffset(Offset = "0x38")]
      private bool mDragScroll;
      [Token(Token = "0x40025AA")]
      [FieldOffset(Offset = "0x39")]
      private bool mDragSelectGrid;
      [Token(Token = "0x40025AB")]
      [FieldOffset(Offset = "0x3C")]
      private float mYScrollPos;
      [Token(Token = "0x40025AC")]
      [FieldOffset(Offset = "0x40")]
      private bool mIgnoreDragVelocity;
      [Token(Token = "0x40025AD")]
      [FieldOffset(Offset = "0x44")]
      private float mDragY;
      [Token(Token = "0x40025AE")]
      [FieldOffset(Offset = "0x48")]
      private GUIEventListener mGUIEvent;

      [Token(Token = "0x60035EA")]
      [Address(RVA = "0x105AEA0", Offset = "0x1059CA0", VA = "0x1105AEA0", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x60035EB")]
      [Address(RVA = "0x105C350", Offset = "0x105B150", VA = "0x1105C350", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x60035EC")]
      [Address(RVA = "0x105D020", Offset = "0x105BE20", VA = "0x1105D020")]
      private bool NeedsTargetKakunin(Unit unit) => new bool();

      [Token(Token = "0x60035ED")]
      [Address(RVA = "0x10610E0", Offset = "0x105FEE0", VA = "0x110610E0")]
      private void OnNextTargetClick(GameObject go)
      {
      }

      [Token(Token = "0x60035EE")]
      [Address(RVA = "0x1061100", Offset = "0x105FF00", VA = "0x11061100")]
      private void OnPrevTargetClick(GameObject go)
      {
      }

      [Token(Token = "0x60035EF")]
      [Address(RVA = "0x105D3B0", Offset = "0x105C1B0", VA = "0x1105D3B0")]
      private void OnDragEnd()
      {
      }

      [Token(Token = "0x60035F0")]
      [Address(RVA = "0x105D3D0", Offset = "0x105C1D0", VA = "0x1105D3D0")]
      private void OnDrag()
      {
      }

      [Token(Token = "0x60035F1")]
      [Address(RVA = "0x1061A20", Offset = "0x1060820", VA = "0x11061A20")]
      private void SetYesButtonEnable(bool enable)
      {
      }

      [Token(Token = "0x60035F2")]
      [Address(RVA = "0x1061850", Offset = "0x1060650", VA = "0x11061850")]
      private void ResetHPGaugeYosouDamage()
      {
      }

      [Token(Token = "0x60035F3")]
      [Address(RVA = "0x1061280", Offset = "0x1060080", VA = "0x11061280")]
      private void OnYesNoSelect(bool yes)
      {
      }

      [Token(Token = "0x60035F4")]
      [Address(RVA = "0x1061D50", Offset = "0x1060B50", VA = "0x11061D50")]
      private void StartTargetKakunin()
      {
      }

      [Token(Token = "0x60035F5")]
      [Address(RVA = "0x105D230", Offset = "0x105C030", VA = "0x1105D230")]
      private void OnCancelTarget()
      {
      }

      [Token(Token = "0x60035F6")]
      [Address(RVA = "0x1061120", Offset = "0x105FF20", VA = "0x11061120")]
      private void OnSelectTargetMode(bool targetIsGrid)
      {
      }

      [Token(Token = "0x60035F7")]
      [Address(RVA = "0x1060F00", Offset = "0x105FD00", VA = "0x11060F00")]
      private void OnMapExitSelect()
      {
      }

      [Token(Token = "0x60035F8")]
      [Address(RVA = "0x105C890", Offset = "0x105B690", VA = "0x1105C890")]
      private void HilitArea(int x, int y)
      {
      }

      [Token(Token = "0x60035F9")]
      [Address(RVA = "0x105CB00", Offset = "0x105B900", VA = "0x1105CB00")]
      private void HilitNormalAttack(Unit Attacker, bool showOnly = false)
      {
      }

      [Token(Token = "0x60035FA")]
      [Address(RVA = "0x105CE60", Offset = "0x105BC60", VA = "0x1105CE60")]
      private bool IsValidForcedTargeting(Unit target_unit = null) => new bool();

      [Token(Token = "0x60035FB")]
      [Address(RVA = "0x105D260", Offset = "0x105C060", VA = "0x1105D260")]
      private void OnClickGrid(Grid grid)
      {
      }

      [Token(Token = "0x60035FC")]
      [Address(RVA = "0x105D2D0", Offset = "0x105C0D0", VA = "0x1105D2D0")]
      private void OnClickUnit(TacticsUnitController controller)
      {
      }

      [Token(Token = "0x60035FD")]
      [Address(RVA = "0x105D440", Offset = "0x105C240", VA = "0x1105D440")]
      private void OnFocusGrid(Grid grid, bool isBegin = false)
      {
      }

      [Token(Token = "0x60035FE")]
      [Address(RVA = "0x105CC20", Offset = "0x105BA20", VA = "0x1105CC20")]
      private bool IsGridSelectable(int x, int y) => new bool();

      [Token(Token = "0x60035FF")]
      [Address(RVA = "0x105CC70", Offset = "0x105BA70", VA = "0x1105CC70")]
      private bool IsGridSelectable(Unit unit) => new bool();

      [Token(Token = "0x6003600")]
      [Address(RVA = "0x105CFA0", Offset = "0x105BDA0", VA = "0x1105CFA0")]
      private bool IsValidSkillTarget(Unit target) => new bool();

      [Token(Token = "0x6003601")]
      [Address(RVA = "0x105F150", Offset = "0x105DF50", VA = "0x1105F150")]
      private void OnFocus(TacticsUnitController controller, Grid focus_grid = null)
      {
      }

      [Token(Token = "0x6003602")]
      [Address(RVA = "0x10626A0", Offset = "0x10614A0", VA = "0x110626A0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003603")]
      [Address(RVA = "0x1061AD0", Offset = "0x10608D0", VA = "0x11061AD0")]
      private void ShiftTarget(int delta)
      {
      }

      [Token(Token = "0x6003604")]
      [Address(RVA = "0x1061970", Offset = "0x1060770", VA = "0x11061970")]
      private void SetTargetSubArrow(int targetNum)
      {
      }

      [Token(Token = "0x6003605")]
      [Address(RVA = "0x1061E90", Offset = "0x1060C90", VA = "0x11061E90")]
      private bool UpdateTargetPlate(
        SkillData skill,
        List<BattleCore.UnitResult> targets,
        Unit unit,
        Unit guard,
        IntVector2 co)
      {
        return new bool();
      }

      [Token(Token = "0x6003606")]
      [Address(RVA = "0x10628A0", Offset = "0x10616A0", VA = "0x110628A0")]
      public State_SelectTargetV2()
      {
      }
    }

    [Token(Token = "0x2000D41")]
    private class State_InputDirection : State<SceneBattle>
    {
      [Token(Token = "0x40025B3")]
      [FieldOffset(Offset = "0xC")]
      private DirectionArrow[] mArrows;
      [Token(Token = "0x40025B4")]
      [FieldOffset(Offset = "0x10")]
      private int mSelectedDirection;
      [Token(Token = "0x40025B5")]
      [FieldOffset(Offset = "0x14")]
      private Unit mCurrentUnit;
      [Token(Token = "0x40025B6")]
      [FieldOffset(Offset = "0x18")]
      private TacticsUnitController mController;
      [Token(Token = "0x40025B7")]
      [FieldOffset(Offset = "0x1C")]
      private bool mIsStepEnd;
      [Token(Token = "0x40025B8")]
      [FieldOffset(Offset = "0x1D")]
      private bool mCancelButtonActive;
      [Token(Token = "0x40025B9")]
      [FieldOffset(Offset = "0x1E")]
      private bool mIsAuto;

      [Token(Token = "0x600360D")]
      [Address(RVA = "0x1067420", Offset = "0x1066220", VA = "0x11067420", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600360E")]
      [Address(RVA = "0x1067B20", Offset = "0x1066920", VA = "0x11067B20")]
      private void OnStepEnd()
      {
      }

      [Token(Token = "0x600360F")]
      [Address(RVA = "0x1068030", Offset = "0x1066E30", VA = "0x11068030")]
      private void OnYesNoSelect(bool yes)
      {
      }

      [Token(Token = "0x6003610")]
      [Address(RVA = "0x1068340", Offset = "0x1067140", VA = "0x11068340")]
      private void UpdateArrows()
      {
      }

      [Token(Token = "0x6003611")]
      [Address(RVA = "0x10683C0", Offset = "0x10671C0", VA = "0x110683C0", Slot = "5")]
      public override void Update(SceneBattle self)
      {
      }

      [Token(Token = "0x6003612")]
      [Address(RVA = "0x10676B0", Offset = "0x10664B0", VA = "0x110676B0", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003613")]
      [Address(RVA = "0x1067900", Offset = "0x1066700", VA = "0x11067900")]
      private void OnScreenClick(Vector2 position)
      {
      }

      [Token(Token = "0x6003614")]
      [Address(RVA = "0x10681A0", Offset = "0x1066FA0", VA = "0x110681A0")]
      public void SelectDirection(EUnitDirection dir)
      {
      }

      [Token(Token = "0x6003615")]
      [Address(RVA = "0x1067AD0", Offset = "0x10668D0", VA = "0x11067AD0")]
      private void OnStateChange(SceneBattle.StateTransitionTypes req)
      {
      }

      [Token(Token = "0x6003616")]
      [Address(RVA = "0x1068610", Offset = "0x1067410", VA = "0x11068610")]
      public State_InputDirection()
      {
      }
    }

    [Token(Token = "0x2000D42")]
    private class State_SelectSkillV2 : State<SceneBattle>
    {
      [Token(Token = "0x40025BA")]
      [FieldOffset(Offset = "0xC")]
      private UnitAbilitySkillList mSkillList;

      [Token(Token = "0x6003617")]
      [Address(RVA = "0x1068840", Offset = "0x1067640", VA = "0x11068840", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x6003618")]
      [Address(RVA = "0x1068A20", Offset = "0x1067820", VA = "0x11068A20", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x6003619")]
      [Address(RVA = "0x1068AB0", Offset = "0x10678B0", VA = "0x11068AB0")]
      private void OnSelectSkill(SkillData skill)
      {
      }

      [Token(Token = "0x600361A")]
      [Address(RVA = "0x1068B90", Offset = "0x1067990", VA = "0x11068B90")]
      private void OnStateChange(SceneBattle.StateTransitionTypes req)
      {
      }

      [Token(Token = "0x600361B")]
      [Address(RVA = "0x1068BF0", Offset = "0x10679F0", VA = "0x11068BF0")]
      public State_SelectSkillV2()
      {
      }
    }

    [Token(Token = "0x2000D43")]
    private class State_SelectGridEventV2 : State<SceneBattle>
    {
      [Token(Token = "0x600361C")]
      [Address(RVA = "0x1068680", Offset = "0x1067480", VA = "0x11068680", Slot = "4")]
      public override void Begin(SceneBattle self)
      {
      }

      [Token(Token = "0x600361D")]
      [Address(RVA = "0x1037E50", Offset = "0x1036C50", VA = "0x11037E50", Slot = "6")]
      public override void End(SceneBattle self)
      {
      }

      [Token(Token = "0x600361E")]
      [Address(RVA = "0x1068710", Offset = "0x1067510", VA = "0x11068710")]
      private void OnStateChange(SceneBattle.StateTransitionTypes req)
      {
      }

      [Token(Token = "0x600361F")]
      [Address(RVA = "0x1068800", Offset = "0x1067600", VA = "0x11068800")]
      public State_SelectGridEventV2()
      {
      }
    }

    [Token(Token = "0x2000D44")]
    public enum eMaskBattleUI
    {
      [Token(Token = "0x40025BC")] MENU = 1,
      [Token(Token = "0x40025BD")] MAP = 2,
      [Token(Token = "0x40025BE")] CAMERA = 4,
      [Token(Token = "0x40025BF")] CMD_ATTACK = 8,
      [Token(Token = "0x40025C0")] CMD_ABILITYS = 16, // 0x00000010
      [Token(Token = "0x40025C1")] CMD_ITEM = 32, // 0x00000020
      [Token(Token = "0x40025C2")] CMD_END = 64, // 0x00000040
      [Token(Token = "0x40025C3")] VS_GRID_TAP = 128, // 0x00000080
      [Token(Token = "0x40025C4")] VS_SWIPE = 256, // 0x00000100
      [Token(Token = "0x40025C5")] BACK_KEY = 512, // 0x00000200
    }

    [Token(Token = "0x2000D45")]
    private enum UnitMarkerTypes
    {
      [Token(Token = "0x40025C7")] Target,
      [Token(Token = "0x40025C8")] Enemy,
      [Token(Token = "0x40025C9")] Assist,
    }

    [Token(Token = "0x2000D46")]
    private delegate void GridClickEvent(Grid grid);

    [Token(Token = "0x2000D47")]
    private delegate void UnitClickEvent(TacticsUnitController controller);

    [Token(Token = "0x2000D48")]
    private delegate void UnitFocusEvent(TacticsUnitController controller, Grid focus_grid = null);

    [Token(Token = "0x2000D49")]
    private delegate void ScreenClickEvent(Vector2 position);

    [Token(Token = "0x2000D4A")]
    private delegate void FocusTargetEvent(Unit unit);

    [Token(Token = "0x2000D4B")]
    private delegate void SelectTargetEvent(Unit unit);

    [Token(Token = "0x2000D4C")]
    private delegate void CancelTargetSelectEvent();

    [Token(Token = "0x2000D4D")]
    private class PupupData
    {
      [Token(Token = "0x40025CA")]
      [FieldOffset(Offset = "0x8")]
      public int priority;
      [Token(Token = "0x40025CB")]
      [FieldOffset(Offset = "0xC")]
      public Vector3 position;
      [Token(Token = "0x40025CC")]
      [FieldOffset(Offset = "0x18")]
      public float yOffset;

      [Token(Token = "0x600363C")]
      [Address(RVA = "0x1067380", Offset = "0x1066180", VA = "0x11067380")]
      public PupupData(Vector3 position, int priority, float yOffset)
      {
      }
    }

    [Token(Token = "0x2000D4E")]
    public class VirtualStickInput : SceneBattle.MoveInput
    {
      [Token(Token = "0x40025CD")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController mController;
      [Token(Token = "0x40025CE")]
      [FieldOffset(Offset = "0x14")]
      private GridMap<int> mWalkableGrids;
      [Token(Token = "0x40025CF")]
      [FieldOffset(Offset = "0x18")]
      private Vector3 mStart;
      [Token(Token = "0x40025D0")]
      [FieldOffset(Offset = "0x24")]
      private int mDestX;
      [Token(Token = "0x40025D1")]
      [FieldOffset(Offset = "0x28")]
      private int mDestY;
      [Token(Token = "0x40025D2")]
      [FieldOffset(Offset = "0x2C")]
      private Vector2 mBasePos;
      [Token(Token = "0x40025D3")]
      [FieldOffset(Offset = "0x34")]
      private Vector2 mTargetPos;
      [Token(Token = "0x40025D4")]
      [FieldOffset(Offset = "0x3C")]
      private bool mTargetSet;
      [Token(Token = "0x40025D5")]
      [FieldOffset(Offset = "0x3D")]
      private bool mMoveStarted;
      [Token(Token = "0x40025D6")]
      [FieldOffset(Offset = "0x3E")]
      private bool mClickedOK;
      [Token(Token = "0x40025D7")]
      [FieldOffset(Offset = "0x40")]
      private float mGridSnapTime;
      [Token(Token = "0x40025D8")]
      [FieldOffset(Offset = "0x44")]
      private bool mJumping;
      [Token(Token = "0x40025D9")]
      [FieldOffset(Offset = "0x45")]
      private bool mHasInput;
      [Token(Token = "0x40025DA")]
      [FieldOffset(Offset = "0x48")]
      private int mCurrentX;
      [Token(Token = "0x40025DB")]
      [FieldOffset(Offset = "0x4C")]
      private int mCurrentY;
      [Token(Token = "0x40025DC")]
      [FieldOffset(Offset = "0x50")]
      private GridMap<bool> mShateiGrid;
      [Token(Token = "0x40025DD")]
      [FieldOffset(Offset = "0x54")]
      private float mStopTime;
      [Token(Token = "0x40025DE")]
      [FieldOffset(Offset = "0x58")]
      private bool mRouteSet;
      [Token(Token = "0x40025DF")]
      [FieldOffset(Offset = "0x59")]
      private bool mFullAccel;
      [Token(Token = "0x40025E0")]
      [FieldOffset(Offset = "0x5A")]
      private bool mHasDesiredRotation;
      [Token(Token = "0x40025E1")]
      [FieldOffset(Offset = "0x5B")]
      private bool mGridSnapping;
      [Token(Token = "0x40025E2")]
      [FieldOffset(Offset = "0x5C")]
      private Quaternion mDesiredRotation;
      [Token(Token = "0x40025E3")]
      private const float STOP_RADIUS = 0.1f;
      [Token(Token = "0x40025E4")]
      [FieldOffset(Offset = "0x6C")]
      private bool mUpdateShateiGrid;
      [Token(Token = "0x40025E5")]
      [FieldOffset(Offset = "0x6D")]
      private bool mShateiVisible;

      [Token(Token = "0x170003A4")]
      public override bool IsBusy
      {
        [Token(Token = "0x600363D"), Address(RVA = "0x1075800", Offset = "0x1074600", VA = "0x11075800", Slot = "7")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600363E")]
      [Address(RVA = "0x1073C80", Offset = "0x1072A80", VA = "0x11073C80", Slot = "8")]
      public override void Reset()
      {
      }

      [Token(Token = "0x600363F")]
      [Address(RVA = "0x1073D20", Offset = "0x1072B20", VA = "0x11073D20", Slot = "5")]
      public override void Start()
      {
      }

      [Token(Token = "0x6003640")]
      [Address(RVA = "0x1073000", Offset = "0x1071E00", VA = "0x11073000", Slot = "6")]
      public override void End()
      {
      }

      [Token(Token = "0x6003641")]
      [Address(RVA = "0x1073540", Offset = "0x1072340", VA = "0x11073540", Slot = "4")]
      public override void MoveUnit(Vector3 target_screen_pos)
      {
      }

      [Token(Token = "0x6003642")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
      private void OnDrag()
      {
      }

      [Token(Token = "0x6003643")]
      [Address(RVA = "0x1073B80", Offset = "0x1072980", VA = "0x11073B80")]
      private void OnDragEnd()
      {
      }

      [Token(Token = "0x6003644")]
      [Address(RVA = "0x1073580", Offset = "0x1072380", VA = "0x11073580")]
      private void OnClick(Vector2 screenPos)
      {
      }

      [Token(Token = "0x6003645")]
      [Address(RVA = "0x1074190", Offset = "0x1072F90", VA = "0x11074190")]
      private void UpdateBlockMarker()
      {
      }

      [Token(Token = "0x6003646")]
      [Address(RVA = "0x1073510", Offset = "0x1072310", VA = "0x11073510")]
      private bool IsGridBlocked(Vector2 co) => new bool();

      [Token(Token = "0x6003647")]
      [Address(RVA = "0x10733D0", Offset = "0x10721D0", VA = "0x110733D0")]
      private bool IsGridBlocked(float x, float y) => new bool();

      [Token(Token = "0x6003648")]
      [Address(RVA = "0x1072F70", Offset = "0x1071D70", VA = "0x11072F70")]
      private bool CanMoveToAdj(Vector2 from, Vector2 to) => new bool();

      [Token(Token = "0x6003649")]
      [Address(RVA = "0x1072F10", Offset = "0x1071D10", VA = "0x11072F10")]
      private bool CanMoveToAdjDirect(Vector2 from, Vector2 to) => new bool();

      [Token(Token = "0x600364A")]
      [Address(RVA = "0x1027AB0", Offset = "0x10268B0", VA = "0x11027AB0")]
      private bool GridEqualIn2D(Vector2 a, Vector2 b) => new bool();

      [Token(Token = "0x600364B")]
      [Address(RVA = "0x1072950", Offset = "0x1071750", VA = "0x11072950")]
      private void AdjustTargetPos(
        ref Vector2 basePos,
        ref Vector2 targetPos,
        Vector2 inputDir,
        Vector2 unitPos)
      {
      }

      [Token(Token = "0x170003A5")]
      private Vector2 Velocity
      {
        [Token(Token = "0x600364C"), Address(RVA = "0x1075830", Offset = "0x1074630", VA = "0x11075830")] get
        {
          return new Vector2();
        }
      }

      [Token(Token = "0x600364D")]
      [Address(RVA = "0x1074160", Offset = "0x1072F60", VA = "0x11074160")]
      private void SyncCameraPosition()
      {
      }

      [Token(Token = "0x600364E")]
      [Address(RVA = "0x1074270", Offset = "0x1073070", VA = "0x11074270", Slot = "9")]
      public override void Update()
      {
      }

      [Token(Token = "0x600364F")]
      [Address(RVA = "0x1073380", Offset = "0x1072180", VA = "0x11073380")]
      private void HideShatei()
      {
      }

      [Token(Token = "0x6003650")]
      [Address(RVA = "0x1073C00", Offset = "0x1072A00", VA = "0x11073C00")]
      private void ResetHPGauge(TacticsUnitController tuc)
      {
      }

      [Token(Token = "0x6003651")]
      [Address(RVA = "0x1075770", Offset = "0x1074570", VA = "0x11075770")]
      public VirtualStickInput()
      {
      }
    }
  }
}
