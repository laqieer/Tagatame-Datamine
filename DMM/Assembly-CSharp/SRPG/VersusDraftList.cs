// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002729")]
  [FlowNode.Pin(3, "Random Decide Unit", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(2, "Decide Unit", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(101, "Initialize Complete", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(130, "Unit Select SE", FlowNode.PinTypes.Output, 30)]
  [FlowNode.Pin(110, "Turn Player", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(111, "Turn Enemy", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(4, "Start Drafting", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(120, "Finish Draft", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftList")]
  [FlowNode.Pin(102, "Unit Selecting", FlowNode.PinTypes.Output, 3)]
  public class VersusDraftList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B88A")]
    [FieldOffset(Offset = "0x0")]
    public static bool VersusDraftTurnOwn;
    [Token(Token = "0x400B88B")]
    [FieldOffset(Offset = "0x4")]
    public static List<VersusDraftUnitParam> VersusDraftUnitList;
    [Token(Token = "0x400B88C")]
    [FieldOffset(Offset = "0x8")]
    public static List<UnitData> VersusDraftPartyUnits;
    [Token(Token = "0x400B88D")]
    [FieldOffset(Offset = "0xC")]
    public static List<int> VersusDraftPartyPlaces;
    [Token(Token = "0x400B88E")]
    [FieldOffset(Offset = "0x10")]
    public static List<UnitData> VersusDraftUnitDataListPlayer;
    [Token(Token = "0x400B88F")]
    [FieldOffset(Offset = "0x14")]
    public static List<UnitData> VersusDraftUnitDataListEnemy;
    [Token(Token = "0x400B890")]
    [FieldOffset(Offset = "0x18")]
    public static List<UnitData> VersusDraftBanUnitDataListPlayer;
    [Token(Token = "0x400B891")]
    [FieldOffset(Offset = "0x1C")]
    public static List<UnitData> VersusDraftBanUnitDataListEnemy;
    [Token(Token = "0x400B892")]
    [FieldOffset(Offset = "0x20")]
    public static int DraftID;
    [Token(Token = "0x400B893")]
    private const int DRAFT_UNIT_LIST_COL_MAX = 6;
    [Token(Token = "0x400B894")]
    [FieldOffset(Offset = "0xC")]
    private readonly int[] DRAFT_UNIT_LIST_COLS;
    [Token(Token = "0x400B895")]
    [FieldOffset(Offset = "0x10")]
    private readonly int[] SECRET_INDEX_LIST;
    [Token(Token = "0x400B896")]
    private const int SELECTING_UNIT_COUNT = 6;
    [Token(Token = "0x400B897")]
    private const float SINGLE_ENEMY_TIME = 5f;
    [Token(Token = "0x400B898")]
    [FieldOffset(Offset = "0x14")]
    private readonly int[] SELECTABLE_UNIT_COUNT_OF_TURN;
    [Token(Token = "0x400B899")]
    private const int INPUT_PIN_INITIALIZE = 1;
    [Token(Token = "0x400B89A")]
    private const int INPUT_PIN_DECIDE_UNIT = 2;
    [Token(Token = "0x400B89B")]
    private const int INPUT_PIN_DECIDE_UNIT_RANDOM = 3;
    [Token(Token = "0x400B89C")]
    private const int INPUT_PIN_START_DRAFTING = 4;
    [Token(Token = "0x400B89D")]
    private const int OUTPUT_PIN_INITIALIZE = 101;
    [Token(Token = "0x400B89E")]
    private const int OUTPUT_PIN_UNIT_SELECTING = 102;
    [Token(Token = "0x400B89F")]
    private const int OUTPUT_PIN_TURN_PLAYER = 110;
    [Token(Token = "0x400B8A0")]
    private const int OUTPUT_PIN_TURN_ENEMY = 111;
    [Token(Token = "0x400B8A1")]
    private const int OUTPUT_PIN_FINISH_DRAFT = 120;
    [Token(Token = "0x400B8A2")]
    private const int OUTPUT_PIN_UNIT_SELECT_SE = 130;
    [Token(Token = "0x400B8A3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform[] mDraftUnitTransforms;
    [Token(Token = "0x400B8A4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private VersusDraftUnit mDraftUnitItem;
    [Token(Token = "0x400B8A5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mSelectedUnitTransform;
    [Token(Token = "0x400B8A6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private VersusDraftSelectedUnit mSelectedUnitItem;
    [Token(Token = "0x400B8A7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mPlayerName;
    [Token(Token = "0x400B8A8")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mEnemyName;
    [Token(Token = "0x400B8A9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mPlayerText;
    [Token(Token = "0x400B8AA")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mEnemyText;
    [Token(Token = "0x400B8AB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mTimerGO;
    [Token(Token = "0x400B8AC")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mTimerText;
    [Token(Token = "0x400B8AD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mTurnChangePlayer;
    [Token(Token = "0x400B8AE")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mTurnChangeEnemy;
    [Token(Token = "0x400B8AF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mTurnChangeMessage;
    [Token(Token = "0x400B8B0")]
    [FieldOffset(Offset = "0x4C")]
    private bool mSingleMode;
    [Token(Token = "0x400B8B1")]
    [FieldOffset(Offset = "0x4D")]
    private bool mRandomSelecting;
    [Token(Token = "0x400B8B2")]
    [FieldOffset(Offset = "0x50")]
    private float mDraftSec;
    [Token(Token = "0x400B8B3")]
    [FieldOffset(Offset = "0x54")]
    private int mTurn;
    [Token(Token = "0x400B8B4")]
    [FieldOffset(Offset = "0x58")]
    private List<PhotonPlayerData> mAudiencePlayers;
    [Token(Token = "0x400B8B5")]
    [FieldOffset(Offset = "0x5C")]
    private PhotonPlayerParameter mEnemyPlayer;
    [Token(Token = "0x400B8B6")]
    [FieldOffset(Offset = "0x60")]
    private float mEnemyTimer;
    [Token(Token = "0x400B8B7")]
    [FieldOffset(Offset = "0x64")]
    private float mPlayerTimer;
    [Token(Token = "0x400B8B8")]
    [FieldOffset(Offset = "0x68")]
    private List<VersusDraftUnit> mVersusDraftUnitList;
    [Token(Token = "0x400B8B9")]
    [FieldOffset(Offset = "0x6C")]
    private List<VersusDraftSelectedUnit> mVersusDraftSelectedUnit;
    [Token(Token = "0x400B8BA")]
    [FieldOffset(Offset = "0x70")]
    private int mSelectingUnitIndex;
    [Token(Token = "0x400B8BB")]
    [FieldOffset(Offset = "0x74")]
    private int mEnemyUnitIndex;

    [Token(Token = "0x1700183F")]
    public int SelectableUnitCount
    {
      [Token(Token = "0x600AF92"), Address(RVA = "0x7401C0", Offset = "0x73EFC0", VA = "0x107401C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600AF93")]
    [Address(RVA = "0x73F1D0", Offset = "0x73DFD0", VA = "0x1073F1D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AF94")]
    [Address(RVA = "0x73CF80", Offset = "0x73BD80", VA = "0x1073CF80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF95")]
    [Address(RVA = "0x73EAE0", Offset = "0x73D8E0", VA = "0x1073EAE0")]
    private IEnumerator RandomSelecting() => (IEnumerator) null;

    [Token(Token = "0x600AF96")]
    [Address(RVA = "0x73FDF0", Offset = "0x73EBF0", VA = "0x1073FDF0")]
    private void Update()
    {
    }

    [Token(Token = "0x600AF97")]
    [Address(RVA = "0x73FC80", Offset = "0x73EA80", VA = "0x1073FC80")]
    private void UpdateTimer()
    {
    }

    [Token(Token = "0x600AF98")]
    [Address(RVA = "0x73F650", Offset = "0x73E450", VA = "0x1073F650")]
    private void UpdatePhotonMessage()
    {
    }

    [Token(Token = "0x600AF99")]
    [Address(RVA = "0x73F9E0", Offset = "0x73E7E0", VA = "0x1073F9E0")]
    private void UpdateSingleMode()
    {
    }

    [Token(Token = "0x600AF9A")]
    [Address(RVA = "0x73D090", Offset = "0x73BE90", VA = "0x1073D090")]
    private void AudienceUpdate()
    {
    }

    [Token(Token = "0x600AF9B")]
    [Address(RVA = "0x73E3C0", Offset = "0x73D1C0", VA = "0x1073E3C0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AF9C")]
    [Address(RVA = "0x73F110", Offset = "0x73DF10", VA = "0x1073F110")]
    public void StartDrafting()
    {
    }

    [Token(Token = "0x600AF9D")]
    [Address(RVA = "0x73D9B0", Offset = "0x73C7B0", VA = "0x1073D9B0")]
    private void DecideUnitRandom(bool notice = false, bool spaceOnly = false)
    {
    }

    [Token(Token = "0x600AF9E")]
    [Address(RVA = "0x73E260", Offset = "0x73D060", VA = "0x1073E260")]
    private VersusDraftUnit GetRandomUnit() => (VersusDraftUnit) null;

    [Token(Token = "0x600AF9F")]
    [Address(RVA = "0x73F0A0", Offset = "0x73DEA0", VA = "0x1073F0A0")]
    public void SetUnit(UnitData unit, int offset)
    {
    }

    [Token(Token = "0x600AFA0")]
    [Address(RVA = "0x73DC10", Offset = "0x73CA10", VA = "0x1073DC10")]
    private void DecideUnit()
    {
    }

    [Token(Token = "0x600AFA1")]
    [Address(RVA = "0x73E1C0", Offset = "0x73CFC0", VA = "0x1073E1C0")]
    private void FinishTurn()
    {
    }

    [Token(Token = "0x600AFA2")]
    [Address(RVA = "0x73EB50", Offset = "0x73D950", VA = "0x1073EB50")]
    public void SelectUnit()
    {
    }

    [Token(Token = "0x600AFA3")]
    [Address(RVA = "0x73EF90", Offset = "0x73DD90", VA = "0x1073EF90")]
    private void SendRoomMessage(
      VersusDraftList.VersusDraftMessageData mess,
      bool immediate = false,
      bool is_enemy = false)
    {
    }

    [Token(Token = "0x600AFA4")]
    [Address(RVA = "0x73D5A0", Offset = "0x73C3A0", VA = "0x1073D5A0")]
    private bool ChangeTurn(bool isPlayer = true) => new bool();

    [Token(Token = "0x600AFA5")]
    [Address(RVA = "0x73E150", Offset = "0x73CF50", VA = "0x1073E150")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600AFA6")]
    [Address(RVA = "0x7400A0", Offset = "0x73EEA0", VA = "0x107400A0")]
    public VersusDraftList()
    {
    }

    [Token(Token = "0x600AFA7")]
    [Address(RVA = "0x73FF70", Offset = "0x73ED70", VA = "0x1073FF70")]
    static VersusDraftList()
    {
    }

    [Token(Token = "0x200272A")]
    [MessagePackObject(true)]
    public class VersusDraftMessageData : SceneBattle.MultiPlayRecvData
    {
      [Token(Token = "0x400B8BC")]
      [FieldOffset(Offset = "0x50")]
      public int uidx0;
      [Token(Token = "0x400B8BD")]
      [FieldOffset(Offset = "0x54")]
      public int uidx1;
      [Token(Token = "0x400B8BE")]
      [FieldOffset(Offset = "0x58")]
      public int uidx2;
      [Token(Token = "0x400B8BF")]
      [FieldOffset(Offset = "0x5C")]
      public string draftName;

      [Token(Token = "0x600AFA8")]
      [Address(RVA = "0x740270", Offset = "0x73F070", VA = "0x10740270")]
      public VersusDraftMessageData()
      {
      }
    }

    [Token(Token = "0x200272B")]
    public enum VersusDraftMessageDataHeader
    {
      [Token(Token = "0x400B8C1")] NOP,
      [Token(Token = "0x400B8C2")] CURSOR,
      [Token(Token = "0x400B8C3")] DECIDE,
      [Token(Token = "0x400B8C4")] FINISH_TURN,
      [Token(Token = "0x400B8C5")] COMPLETE,
      [Token(Token = "0x400B8C6")] UNITSELECT,
      [Token(Token = "0x400B8C7")] NUM,
    }
  }
}
