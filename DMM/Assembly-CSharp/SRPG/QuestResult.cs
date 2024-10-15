// Decompiled with JetBrains decompiler
// Type: SRPG.QuestResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028AD")]
  [FlowNode.Pin(100, "演出スキップ", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(10, "演出開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(200, "GvGリプレイ", FlowNode.PinTypes.Output, 200)]
  [AddComponentMenu("UI/QuestResult")]
  [FlowNode.Pin(40, "ランクアップ演出表示", FlowNode.PinTypes.Output, 40)]
  [FlowNode.Pin(31, "演出終了", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(41, "ランクアップ演出終了", FlowNode.PinTypes.Input, 41)]
  public class QuestResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C2BA")]
    [FieldOffset(Offset = "0xC")]
    [Description("確認用に使用するユニットのID。ユニットID@ジョブIDで指定する。")]
    public string[] DebugUnitIDs;
    [Token(Token = "0x400C2BB")]
    [FieldOffset(Offset = "0x10")]
    public bool[] DebugObjectiveFlags;
    [Token(Token = "0x400C2BC")]
    [FieldOffset(Offset = "0x14")]
    public string DebugMasterAbilityID;
    [Token(Token = "0x400C2BD")]
    [FieldOffset(Offset = "0x18")]
    [Description("ユニットアイコンを梱包する親ゲームオブジェクト")]
    public GameObject UnitList;
    [Token(Token = "0x400C2BE")]
    [FieldOffset(Offset = "0x1C")]
    [Description("ユニットアイコンのゲームオブジェクト")]
    public GameObject UnitListItem;
    [Token(Token = "0x400C2BF")]
    [FieldOffset(Offset = "0x20")]
    [Description("ユニット獲得経験値のゲームオブジェクト")]
    public GameObject UnitExpText;
    [Token(Token = "0x400C2C0")]
    [FieldOffset(Offset = "0x24")]
    [Description("ユニット獲得経験値の元ゲームオブジェクト")]
    public GameObject UnitExpObject;
    [Token(Token = "0x400C2C1")]
    [FieldOffset(Offset = "0x28")]
    [Description("ユニット獲得経験値ゲージの元ゲームオブジェクト")]
    public GameObject UnitExpGaugeObject;
    [Token(Token = "0x400C2C2")]
    [FieldOffset(Offset = "0x2C")]
    [Description("入手アイテムのリストになる親ゲームオブジェクト")]
    public GameObject TreasureList;
    [Token(Token = "0x400C2C3")]
    [FieldOffset(Offset = "0x30")]
    [Description("入手アイテムのリストになる親ゲームオブジェクト Contentnode版")]
    public ContentController CcTreasureList;
    [Token(Token = "0x400C2C4")]
    [FieldOffset(Offset = "0x34")]
    [Description("入手アイテムのゲームオブジェクト")]
    public GameObject TreasureListItem;
    [Token(Token = "0x400C2C5")]
    [FieldOffset(Offset = "0x38")]
    [Description("入手ユニットのゲームオブジェクト")]
    public GameObject TreasureListUnit;
    [Token(Token = "0x400C2C6")]
    [FieldOffset(Offset = "0x3C")]
    [Description("入手武具のゲームオブジェクト")]
    public GameObject TreasureListArtifact;
    [Token(Token = "0x400C2C7")]
    [FieldOffset(Offset = "0x40")]
    [Description("バトルコインのゲームオブジェクト")]
    public GameObject TreasureListBattleCoin;
    [Token(Token = "0x400C2C8")]
    [FieldOffset(Offset = "0x44")]
    [Description("入手真理念装のゲームオブジェクト")]
    public GameObject TreasureListConceptCard;
    [Token(Token = "0x400C2C9")]
    [FieldOffset(Offset = "0x48")]
    [Description("クリア条件の星を白星に切り替えるトリガーの名前")]
    public string Star_TurnOnTrigger;
    [Token(Token = "0x400C2CA")]
    [FieldOffset(Offset = "0x4C")]
    [Description("クリア条件の星が白星にならなかった場合のトリガーの名前")]
    public string Star_KeepOffTrigger;
    [Token(Token = "0x400C2CB")]
    [FieldOffset(Offset = "0x50")]
    [Description("クリア条件の星が白星に既になってる場合のトリガーの名前")]
    public string Star_ClearTrigger;
    [Token(Token = "0x400C2CC")]
    [FieldOffset(Offset = "0x54")]
    [Description("クリア条件の星にトリガーを送る間隔 (秒数)")]
    public float Star_TriggerInterval;
    [Token(Token = "0x400C2CD")]
    [FieldOffset(Offset = "0x58")]
    [Description("クリア条件の星で黒星を無視する")]
    public bool Star_SkipDarkStar;
    [Token(Token = "0x400C2CE")]
    [FieldOffset(Offset = "0x5C")]
    [Description("入手アイテムを可視状態に切り替えるトリガー")]
    public string Treasure_TurnOnTrigger;
    [Token(Token = "0x400C2CF")]
    [FieldOffset(Offset = "0x60")]
    [Description("入手アイテムを可視状態に切り替える間隔 (秒数)")]
    public float Treasure_TriggerInterval;
    [Token(Token = "0x400C2D0")]
    [FieldOffset(Offset = "0x64")]
    public GameObject Prefab_NewItemBadge;
    [Token(Token = "0x400C2D1")]
    [FieldOffset(Offset = "0x68")]
    public GameObject Prefab_MasterAbilityPopup;
    [Token(Token = "0x400C2D2")]
    [FieldOffset(Offset = "0x6C")]
    public GameObject Prefab_UnitDataUnlockPopup;
    [Token(Token = "0x400C2D3")]
    [FieldOffset(Offset = "0x70")]
    public Text TextConsumeAp;
    [Token(Token = "0x400C2D4")]
    [FieldOffset(Offset = "0x74")]
    public Color TextConsumeApColor;
    [Token(Token = "0x400C2D5")]
    [FieldOffset(Offset = "0x84")]
    [Description("ユニットのレベルアップ時に使用するトリガー。ユニットのゲームオブジェクトにアタッチされたAnimatorへ送られます。")]
    public string Unit_LevelUpTrigger;
    [Token(Token = "0x400C2D6")]
    [FieldOffset(Offset = "0x88")]
    [Description("一秒あたりの経験値の増加量")]
    public float ExpGainRate;
    [Token(Token = "0x400C2D7")]
    [FieldOffset(Offset = "0x8C")]
    [Description("経験値増加アニメーションの最長時間。経験値がExpGainRateの速度で増加する時、これで設定した時間を超える時に加算速度を上げる。")]
    public float ExpGainTimeMax;
    [Token(Token = "0x400C2D8")]
    [FieldOffset(Offset = "0x90")]
    protected List<GameObject> mUnitListItems;
    [Token(Token = "0x400C2D9")]
    [FieldOffset(Offset = "0x94")]
    private List<GameObject> mTreasureListItems;
    [Token(Token = "0x400C2DA")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private int mRaidOffsetLeft;
    [Token(Token = "0x400C2DB")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private float mRaidOffsetSpacing;
    [Token(Token = "0x400C2DC")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private float mRaidOffsetScale;
    [Token(Token = "0x400C2DD")]
    [FieldOffset(Offset = "0xA4")]
    private bool mUseLarge;
    [Token(Token = "0x400C2DE")]
    [FieldOffset(Offset = "0xA8")]
    public string PreStarAnimationTrigger;
    [Token(Token = "0x400C2DF")]
    [FieldOffset(Offset = "0xAC")]
    public string PostStarAnimationTrigger;
    [Token(Token = "0x400C2E0")]
    [FieldOffset(Offset = "0xB0")]
    public float PreStarAnimationDelay;
    [Token(Token = "0x400C2E1")]
    [FieldOffset(Offset = "0xB4")]
    public float PostStarAnimationDelay;
    [Token(Token = "0x400C2E2")]
    [FieldOffset(Offset = "0xB8")]
    public string PreExpAnimationTrigger;
    [Token(Token = "0x400C2E3")]
    [FieldOffset(Offset = "0xBC")]
    public string PostExpAnimationTrigger;
    [Token(Token = "0x400C2E4")]
    [FieldOffset(Offset = "0xC0")]
    public float PreExpAnimationDelay;
    [Token(Token = "0x400C2E5")]
    [FieldOffset(Offset = "0xC4")]
    public float PostExpAnimationDelay;
    [Token(Token = "0x400C2E6")]
    [FieldOffset(Offset = "0xC8")]
    public string PreItemAnimationTrigger;
    [Token(Token = "0x400C2E7")]
    [FieldOffset(Offset = "0xCC")]
    public string PostItemAnimationTrigger;
    [Token(Token = "0x400C2E8")]
    [FieldOffset(Offset = "0xD0")]
    public float PreItemAnimationDelay;
    [Token(Token = "0x400C2E9")]
    [FieldOffset(Offset = "0xD4")]
    public float PostItemAnimationDelay;
    [Token(Token = "0x400C2EA")]
    [FieldOffset(Offset = "0xD8")]
    protected QuestParam mCurrentQuest;
    [Token(Token = "0x400C2EB")]
    [FieldOffset(Offset = "0xDC")]
    private GameObject mMasterAbilityPopup;
    [Token(Token = "0x400C2EC")]
    [FieldOffset(Offset = "0xE0")]
    protected QuestResultData mResultData;
    [Token(Token = "0x400C2ED")]
    [FieldOffset(Offset = "0xE4")]
    protected string mQuestName;
    [Token(Token = "0x400C2EE")]
    [FieldOffset(Offset = "0xE8")]
    public GameObject RetryButton;
    [Token(Token = "0x400C2EF")]
    [FieldOffset(Offset = "0xEC")]
    public GameObject OwaruButton;
    [Token(Token = "0x400C2F0")]
    [FieldOffset(Offset = "0xF0")]
    public GameObject RaidOwaruButton;
    [Token(Token = "0x400C2F1")]
    [FieldOffset(Offset = "0xF4")]
    public Button StarKakuninButton;
    [Token(Token = "0x400C2F2")]
    [FieldOffset(Offset = "0xF8")]
    public SRPG_Button TeamUploadButton;
    [Token(Token = "0x400C2F3")]
    [FieldOffset(Offset = "0xFC")]
    protected List<UnitData> mUnits;
    [Token(Token = "0x400C2F4")]
    [FieldOffset(Offset = "0x100")]
    [Description("スキップボタン")]
    public Button ResultSkipButton;
    [Token(Token = "0x400C2F5")]
    [FieldOffset(Offset = "0x104")]
    [Description("経験値増加アニメーションスキップの倍速設定")]
    public float ResultSkipSpeedMul;
    [Token(Token = "0x400C2F6")]
    [FieldOffset(Offset = "0x108")]
    private bool mResultSkipElement;
    [Token(Token = "0x400C2F7")]
    [FieldOffset(Offset = "0x109")]
    private bool mExpAnimationEnd;
    [Token(Token = "0x400C2F8")]
    [FieldOffset(Offset = "0x10A")]
    protected bool mContinueStarAnimation;
    [Token(Token = "0x400C2F9")]
    [FieldOffset(Offset = "0x10B")]
    public bool UseUnitGetEffect;
    [Token(Token = "0x400C2FA")]
    [FieldOffset(Offset = "0x10C")]
    public bool NewEffectUse;
    [Token(Token = "0x400C2FB")]
    [FieldOffset(Offset = "0x110")]
    public int[] AcquiredUnitExp;
    [Token(Token = "0x400C2FC")]
    [FieldOffset(Offset = "0x114")]
    [Description("アリーナ：勝ち表示するゲームオブジェクト")]
    public GameObject GoArenaResultWin;
    [Token(Token = "0x400C2FD")]
    [FieldOffset(Offset = "0x118")]
    [Description("アリーナ：負けを表示するゲームオブジェクト")]
    public GameObject GoArenaResultLose;
    [Token(Token = "0x400C2FE")]
    [FieldOffset(Offset = "0x11C")]
    public BattleResultMissionDetail MissionDetailSmall;
    [Token(Token = "0x400C2FF")]
    [FieldOffset(Offset = "0x120")]
    public BattleResultMissionDetail MissionDetailLarge;
    [Token(Token = "0x400C300")]
    [FieldOffset(Offset = "0x124")]
    private List<GameObject> mObjectiveStars;
    [Token(Token = "0x400C301")]
    [FieldOffset(Offset = "0x128")]
    protected BattleResultMissionDetail mMissionDetail;
    [Token(Token = "0x400C302")]
    [FieldOffset(Offset = "0x12C")]
    protected List<int> mMultiTowerUnitsId;
    [Token(Token = "0x400C303")]
    [FieldOffset(Offset = "0x130")]
    public GameObject[] MultiTowerPlayerObj;
    [Token(Token = "0x400C304")]
    [FieldOffset(Offset = "0x134")]
    public RectTransform[] MultiTowerPlayerTransform;
    [Token(Token = "0x400C305")]
    [FieldOffset(Offset = "0x138")]
    public Texture2D GoldTex;
    [Token(Token = "0x400C306")]
    [FieldOffset(Offset = "0x13C")]
    public Sprite GoldFrame;
    [Token(Token = "0x400C307")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private SerializeValueBehaviour mSerializeValueBehaviour;
    [Token(Token = "0x400C308")]
    [FieldOffset(Offset = "0x144")]
    private List<QuestResultTreasureParam> mCcTreasureList;
    [Token(Token = "0x400C309")]
    [FieldOffset(Offset = "0x148")]
    public Animator MainAnimator;
    [Token(Token = "0x400C30A")]
    [FieldOffset(Offset = "0x14C")]
    [Description("クエストの自動周回開始ボタン")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestStartBtn;
    [Token(Token = "0x400C30B")]
    [FieldOffset(Offset = "0x150")]
    [Description("クエストの自動周回開始ボタンマスク")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestStartBtnMask;
    [Token(Token = "0x400C30C")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestBestTimeBtn;
    [Token(Token = "0x400C30D")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestBestTimeBtnMask;
    [Token(Token = "0x400C30E")]
    [FieldOffset(Offset = "0x15C")]
    [SerializeField]
    private Text AutoRepeatQuestBestTimeText;

    [Token(Token = "0x600B7D9")]
    [Address(RVA = "0x7EDCE0", Offset = "0x7ECAE0", VA = "0x107EDCE0")]
    protected void SetExpAnimationEnd()
    {
    }

    [Token(Token = "0x600B7DA")]
    [Address(RVA = "0x7ED710", Offset = "0x7EC510", VA = "0x107ED710")]
    public void OnStarKakuninButtonClick()
    {
    }

    [Token(Token = "0x600B7DB")]
    [Address(RVA = "0x7ED590", Offset = "0x7EC390", VA = "0x107ED590")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B7DC")]
    [Address(RVA = "0x7EDD50", Offset = "0x7ECB50", VA = "0x107EDD50")]
    private void Start()
    {
    }

    [Token(Token = "0x600B7DD")]
    [Address(RVA = "0x7EC2E0", Offset = "0x7EB0E0", VA = "0x107EC2E0", Slot = "5")]
    public virtual void CreateItemObject(List<QuestResult.DropItemData> items, Transform parent)
    {
    }

    [Token(Token = "0x600B7DE")]
    [Address(RVA = "0x7EB7C0", Offset = "0x7EA5C0", VA = "0x107EB7C0")]
    private void CreateArtifactObjects(Transform parent)
    {
    }

    [Token(Token = "0x600B7DF")]
    [Address(RVA = "0x7EBF30", Offset = "0x7EAD30", VA = "0x107EBF30")]
    private void CreateGoldObjects(Transform parent)
    {
    }

    [Token(Token = "0x600B7E0")]
    [Address(RVA = "0x7EC740", Offset = "0x7EB540", VA = "0x107EC740")]
    public void CreateTreasureObject(List<QuestResult.DropItemData> items)
    {
    }

    [Token(Token = "0x600B7E1")]
    [Address(RVA = "0x7EAE00", Offset = "0x7E9C00", VA = "0x107EAE00", Slot = "6")]
    public virtual void AddExpPlayer()
    {
    }

    [Token(Token = "0x600B7E2")]
    [Address(RVA = "0x7EA8B0", Offset = "0x7E96B0", VA = "0x107EA8B0")]
    public void AddExpPlayerMultiTower()
    {
    }

    [Token(Token = "0x600B7E3")]
    [Address(RVA = "0x7EA7F0", Offset = "0x7E95F0", VA = "0x107EA7F0", Slot = "7")]
    public virtual void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B7E4")]
    [Address(RVA = "0x7EFB50", Offset = "0x7EE950", VA = "0x107EFB50")]
    public void TriggerAnimation(string trigger)
    {
    }

    [Token(Token = "0x600B7E5")]
    [Address(RVA = "0x7ED720", Offset = "0x7EC520", VA = "0x107ED720", Slot = "8")]
    public virtual IEnumerator PlayAnimationAsync() => (IEnumerator) null;

    [Token(Token = "0x600B7E6")]
    [Address(RVA = "0x7EB250", Offset = "0x7EA050", VA = "0x107EB250", Slot = "9")]
    public virtual IEnumerator AddExp() => (IEnumerator) null;

    [Token(Token = "0x600B7E7")]
    [Address(RVA = "0x7ED790", Offset = "0x7EC590", VA = "0x107ED790")]
    protected IEnumerator RecvExpAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B7E8")]
    [Address(RVA = "0x7ED800", Offset = "0x7EC600", VA = "0x107ED800")]
    protected IEnumerator RecvTrustAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B7E9")]
    [Address(RVA = "0x7EDCF0", Offset = "0x7ECAF0", VA = "0x107EDCF0", Slot = "10")]
    public virtual IEnumerator StartTreasureAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B7EA")]
    [Address(RVA = "0x7EFAE0", Offset = "0x7EE8E0", VA = "0x107EFAE0", Slot = "11")]
    protected virtual IEnumerator TreasureAnimation(List<GameObject> ListItems)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600B7EB")]
    [Address(RVA = "0x7ED0D0", Offset = "0x7EBED0", VA = "0x107ED0D0")]
    protected IEnumerator ObjectiveAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B7EC")]
    [Address(RVA = "0x7EB2C0", Offset = "0x7EA0C0", VA = "0x107EB2C0")]
    private void ApplyQuestCampaignParams(string[] campaignIds)
    {
    }

    [Token(Token = "0x600B7ED")]
    [Address(RVA = "0x7EDB10", Offset = "0x7EC910", VA = "0x107EDB10")]
    private void RefreshQuestMissionReward()
    {
    }

    [Token(Token = "0x600B7EE")]
    [Address(RVA = "0x7ED480", Offset = "0x7EC280", VA = "0x107ED480")]
    public void OnClickMultiTowerRetry()
    {
    }

    [Token(Token = "0x600B7EF")]
    [Address(RVA = "0x7ED330", Offset = "0x7EC130", VA = "0x107ED330")]
    public void OnClickMultiTowerNextRetry()
    {
    }

    [Token(Token = "0x600B7F0")]
    [Address(RVA = "0x7ED670", Offset = "0x7EC470", VA = "0x107ED670")]
    public void OnPartyUploadFinished()
    {
    }

    [Token(Token = "0x600B7F1")]
    [Address(RVA = "0x7ED5F0", Offset = "0x7EC3F0", VA = "0x107ED5F0")]
    public void OnGvGReplay()
    {
    }

    [Token(Token = "0x600B7F2")]
    [Address(RVA = "0x7ED860", Offset = "0x7EC660", VA = "0x107ED860")]
    private bool RefreshAutoRepeatQuestBtn() => new bool();

    [Token(Token = "0x600B7F3")]
    [Address(RVA = "0x7ED130", Offset = "0x7EBF30", VA = "0x107ED130")]
    private void OnAutoRepeatQuestMask(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B7F4")]
    [Address(RVA = "0x7EFD40", Offset = "0x7EEB40", VA = "0x107EFD40")]
    public QuestResult()
    {
    }

    [Token(Token = "0x20028AE")]
    public class DropItemData : ItemData
    {
      [Token(Token = "0x400C30F")]
      [FieldOffset(Offset = "0x28")]
      public bool mIsSecret;
      [Token(Token = "0x400C310")]
      [FieldOffset(Offset = "0x2C")]
      private EBattleRewardType mBattleRewardType;
      [Token(Token = "0x400C311")]
      [FieldOffset(Offset = "0x30")]
      private ConceptCardData mConceptCardData;
      [Token(Token = "0x400C312")]
      [FieldOffset(Offset = "0x34")]
      private RuneData mRuneData;

      [Token(Token = "0x17001914")]
      public EBattleRewardType BattleRewardType
      {
        [Token(Token = "0x600B7F7"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
        {
          return new EBattleRewardType();
        }
      }

      [Token(Token = "0x17001915")]
      public bool IsItem
      {
        [Token(Token = "0x600B7F8"), Address(RVA = "0x7DFE60", Offset = "0x7DEC60", VA = "0x107DFE60")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001916")]
      public bool IsConceptCard
      {
        [Token(Token = "0x600B7F9"), Address(RVA = "0x7DFE50", Offset = "0x7DEC50", VA = "0x107DFE50")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001917")]
      public ItemParam itemParam
      {
        [Token(Token = "0x600B7FA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (ItemParam) null;
        }
      }

      [Token(Token = "0x17001918")]
      public ItemData itemData
      {
        [Token(Token = "0x600B7FB"), Address(RVA = "0x7DFE90", Offset = "0x7DEC90", VA = "0x107DFE90")] get
        {
          return (ItemData) null;
        }
      }

      [Token(Token = "0x17001919")]
      public ConceptCardParam conceptCardParam
      {
        [Token(Token = "0x600B7FC"), Address(RVA = "0x7DFE70", Offset = "0x7DEC70", VA = "0x107DFE70")] get
        {
          return (ConceptCardParam) null;
        }
      }

      [Token(Token = "0x1700191A")]
      public ConceptCardData conceptCardData
      {
        [Token(Token = "0x600B7FD"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
        {
          return (ConceptCardData) null;
        }
      }

      [Token(Token = "0x1700191B")]
      public RuneData runeData
      {
        [Token(Token = "0x600B7FE"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
        {
          return (RuneData) null;
        }
      }

      [Token(Token = "0x600B7FF")]
      [Address(RVA = "0x7DFDD0", Offset = "0x7DEBD0", VA = "0x107DFDD0")]
      public void SetupDropItemData(EBattleRewardType rewardType, long iid, string iname, int num)
      {
      }

      [Token(Token = "0x600B800")]
      [Address(RVA = "0x7DFD90", Offset = "0x7DEB90", VA = "0x107DFD90")]
      private void SetupConceptCard(string iname, int num)
      {
      }

      [Token(Token = "0x600B801")]
      [Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")]
      public void SetupDropRuneData(RuneData data)
      {
      }

      [Token(Token = "0x600B802")]
      [Address(RVA = "0x7DFE30", Offset = "0x7DEC30", VA = "0x107DFE30")]
      public DropItemData()
      {
      }
    }

    [Token(Token = "0x20028AF")]
    public class TrustAnimWork
    {
      [Token(Token = "0x400C313")]
      [FieldOffset(Offset = "0x8")]
      public UnitData beforeUnit;
      [Token(Token = "0x400C314")]
      [FieldOffset(Offset = "0xC")]
      public UnitData afterUnit;
      [Token(Token = "0x400C315")]
      [FieldOffset(Offset = "0x10")]
      public ConceptCardIconBattleResult cardIcon;

      [Token(Token = "0x600B803")]
      [Address(RVA = "0x42CC30", Offset = "0x42BA30", VA = "0x1042CC30")]
      public TrustAnimWork(UnitData before, UnitData after, ConceptCardIconBattleResult card)
      {
      }
    }

    [Token(Token = "0x20028B0")]
    private class CampaignPartyExp : MonoBehaviour
    {
      [Token(Token = "0x400C316")]
      [FieldOffset(Offset = "0xC")]
      public int Exp;

      [Token(Token = "0x600B804")]
      [Address(RVA = "0x7DFCE0", Offset = "0x7DEAE0", VA = "0x107DFCE0")]
      private void Start()
      {
      }

      [Token(Token = "0x600B805")]
      [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
      public CampaignPartyExp()
      {
      }
    }
  }
}
