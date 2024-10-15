// Decompiled with JetBrains decompiler
// Type: SRPG.UnitKakeraWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C60")]
  [AddComponentMenu("UI/UnitKakeraWindow")]
  [FlowNode.Pin(110, "クエスト書庫選択", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "共鳴状況で限界突破出来ないようにする判定", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "クエスト選択", FlowNode.PinTypes.Output, 100)]
  public class UnitKakeraWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DBA3")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400DBA4")]
    private const int PIN_OUT_QUEST_SELECT = 100;
    [Token(Token = "0x400DBA5")]
    private const int PIN_OUT_ARCHIVE_SELECT = 110;
    [Token(Token = "0x400DBA6")]
    private const int PIN_OUT_CHECK_RESONANCE = 120;
    [Token(Token = "0x400DBA7")]
    [FieldOffset(Offset = "0xC")]
    public UnitKakeraWindow.AwakeEvent OnAwakeAccept;
    [Token(Token = "0x400DBA8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject QuestList;
    [Token(Token = "0x400DBA9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RectTransform QuestListParent;
    [Token(Token = "0x400DBAA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject QuestListItemTemplate;
    [Token(Token = "0x400DBAB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private List<GameObject> PieceUnits;
    [Token(Token = "0x400DBAC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GameObject> PieceMasks;
    [Token(Token = "0x400DBAD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private List<Text> PieceConsumeTexts;
    [Token(Token = "0x400DBAE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<Text> PieceAmountTexts;
    [Token(Token = "0x400DBAF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private List<Slider> PieceSliders;
    [Token(Token = "0x400DBB0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<Button> PiecePlusButtons;
    [Token(Token = "0x400DBB1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private List<Button> PieceMinusButtons;
    [Token(Token = "0x400DBB2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<Button> PiecePlus5Buttons;
    [Token(Token = "0x400DBB3")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private List<Toggle> PieceMaxToggles;
    [Token(Token = "0x400DBB4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text Kakera_Consume_Message;
    [Token(Token = "0x400DBB5")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text Kakera_Caution_Message;
    [Token(Token = "0x400DBB6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject NotFoundGainQuestObject;
    [Token(Token = "0x400DBB7")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject CautionObject;
    [Token(Token = "0x400DBB8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x400DBB9")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Button MaxButton;
    [Token(Token = "0x400DBBA")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button CancelButton;
    [Token(Token = "0x400DBBB")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject JobUnlock;
    [Token(Token = "0x400DBBC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject UnlockArtifactSlot;
    [Token(Token = "0x400DBBD")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text AwakeResultLv;
    [Token(Token = "0x400DBBE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text AwakeResultComb;
    [Token(Token = "0x400DBBF")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private Text AwakeResultArtifactSlots;
    [Token(Token = "0x400DBC0")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private RectTransform JobUnlockParent;
    [Token(Token = "0x400DBC1")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private GameObject NotPieceDataMask;
    [Token(Token = "0x400DBC2")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text NextNeedPieceCount;
    [Token(Token = "0x400DBC3")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private UnitKakeraConfirm ConfirmWindowPrefab;
    [Token(Token = "0x400DBC4")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    [Space(10f)]
    private ExhibitList[] UnitResonanceAwakeExhibitList;
    [Token(Token = "0x400DBC5")]
    [FieldOffset(Offset = "0x84")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400DBC6")]
    [FieldOffset(Offset = "0x88")]
    private JobParam mUnlockJobParam;
    [Token(Token = "0x400DBC7")]
    [FieldOffset(Offset = "0x8C")]
    private List<GameObject> mGainedQuests;
    [Token(Token = "0x400DBC8")]
    [FieldOffset(Offset = "0x90")]
    private ItemParam LastUpadatedItemParam;
    [Token(Token = "0x400DBC9")]
    [FieldOffset(Offset = "0x94")]
    private UnitData mTempUnit;
    [Token(Token = "0x400DBCA")]
    [FieldOffset(Offset = "0x98")]
    private List<GameObject> mUnlockJobList;
    [Token(Token = "0x400DBCB")]
    [FieldOffset(Offset = "0x9C")]
    private List<JobSetParam> mCacheCCJobs;
    [Token(Token = "0x400DBCC")]
    [FieldOffset(Offset = "0xA0")]
    private SerializeValueList serializeValueList;
    [Token(Token = "0x400DBCD")]
    [FieldOffset(Offset = "0xA4")]
    private List<int> mBeforeUseCounts;

    [Token(Token = "0x600CD93")]
    [Address(RVA = "0x9884B0", Offset = "0x9872B0", VA = "0x109884B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CD94")]
    [Address(RVA = "0x9830A0", Offset = "0x981EA0", VA = "0x109830A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CD95")]
    [Address(RVA = "0x986470", Offset = "0x985270", VA = "0x10986470")]
    public void Refresh(UnitData unit, JobParam jobUnlock)
    {
    }

    [Token(Token = "0x600CD96")]
    [Address(RVA = "0x983730", Offset = "0x982530", VA = "0x10983730")]
    private bool CheckUnlockJob(int jobno, int awake_lv) => new bool();

    [Token(Token = "0x600CD97")]
    [Address(RVA = "0x9834C0", Offset = "0x9822C0", VA = "0x109834C0")]
    public int CalcCanAwakeMaxLv(
      int awakelv,
      int awakelvcap,
      int piece_amount,
      int element_piece_amount,
      int common_piece_amount)
    {
      return new int();
    }

    [Token(Token = "0x600CD98")]
    [Address(RVA = "0x983C50", Offset = "0x982A50", VA = "0x10983C50")]
    private int GetPieceCountForAwake(
      int awakelv,
      int awakelvcap,
      int piece_amount,
      int element_piece_amount,
      int common_piece_amount)
    {
      return new int();
    }

    [Token(Token = "0x600CD99")]
    [Address(RVA = "0x983D10", Offset = "0x982B10", VA = "0x10983D10")]
    private int GetPieceCountForNextAwakeLv(int awakelv, int awakelvcap, int pieceCount)
    {
      return new int();
    }

    [Token(Token = "0x600CD9A")]
    [Address(RVA = "0x983A70", Offset = "0x982870", VA = "0x10983A70")]
    private ItemData GetItemDataByPieceKind(UnitData unit, UnitKakeraWindow.PieceKind kind)
    {
      return (ItemData) null;
    }

    [Token(Token = "0x600CD9B")]
    [Address(RVA = "0x983DB0", Offset = "0x982BB0", VA = "0x10983DB0")]
    private void OnAwakeLvSelect(float value)
    {
    }

    [Token(Token = "0x600CD9C")]
    [Address(RVA = "0x983660", Offset = "0x982460", VA = "0x10983660")]
    private int CalcNeedPieceAll(int value) => new int();

    [Token(Token = "0x600CD9D")]
    [Address(RVA = "0x984B20", Offset = "0x983920", VA = "0x10984B20")]
    public void PointRefresh()
    {
    }

    [Token(Token = "0x600CD9E")]
    [Address(RVA = "0x985ED0", Offset = "0x984CD0", VA = "0x10985ED0")]
    private void RefreshGainedQuests(UnitData unit)
    {
    }

    [Token(Token = "0x600CD9F")]
    [Address(RVA = "0x988400", Offset = "0x987200", VA = "0x10988400")]
    private void SetScrollTop()
    {
    }

    [Token(Token = "0x600CDA0")]
    [Address(RVA = "0x9837A0", Offset = "0x9825A0", VA = "0x109837A0")]
    public void ClearPanel()
    {
    }

    [Token(Token = "0x600CDA1")]
    [Address(RVA = "0x9830D0", Offset = "0x981ED0", VA = "0x109830D0")]
    private void AddPanel(QuestParam questparam, QuestParam[] availableQuests)
    {
    }

    [Token(Token = "0x600CDA2")]
    [Address(RVA = "0x9845B0", Offset = "0x9833B0", VA = "0x109845B0")]
    private void OnQuestSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CDA3")]
    [Address(RVA = "0x983E50", Offset = "0x982C50", VA = "0x10983E50")]
    private void OnDecideClick()
    {
    }

    [Token(Token = "0x600CDA4")]
    [Address(RVA = "0x9838B0", Offset = "0x9826B0", VA = "0x109838B0")]
    private int[] GetClampUseItemCount() => (int[]) null;

    [Token(Token = "0x600CDA5")]
    [Address(RVA = "0x984350", Offset = "0x983150", VA = "0x10984350")]
    private void OnKakusei()
    {
    }

    [Token(Token = "0x600CDA6")]
    [Address(RVA = "0x984440", Offset = "0x983240", VA = "0x10984440")]
    private void OnMaxClick()
    {
    }

    [Token(Token = "0x600CDA7")]
    [Address(RVA = "0x983DD0", Offset = "0x982BD0", VA = "0x10983DD0")]
    private void OnCancelClick()
    {
    }

    [Token(Token = "0x600CDA8")]
    [Address(RVA = "0x985D40", Offset = "0x984B40", VA = "0x10985D40")]
    private void RefreshAwakeLv(UnitKakeraWindow.PieceKind kind, int value = 0)
    {
    }

    [Token(Token = "0x600CDA9")]
    [Address(RVA = "0x988220", Offset = "0x987020", VA = "0x10988220")]
    private void SaveSelectUseMax()
    {
    }

    [Token(Token = "0x600CDAA")]
    [Address(RVA = "0x985E10", Offset = "0x984C10", VA = "0x10985E10")]
    private void RefreshAwake()
    {
    }

    [Token(Token = "0x600CDAB")]
    [Address(RVA = "0x988B50", Offset = "0x987950", VA = "0x10988B50")]
    public UnitKakeraWindow()
    {
    }

    [Token(Token = "0x2002C61")]
    public delegate void AwakeEvent(
      int pieceCountUnit,
      int pieceCountElement,
      int pieceCountCommon);

    [Token(Token = "0x2002C62")]
    private enum PieceKind
    {
      [Token(Token = "0x400DBCF")] Unit,
      [Token(Token = "0x400DBD0")] Element,
      [Token(Token = "0x400DBD1")] Common,
      [Token(Token = "0x400DBD2")] Max,
    }
  }
}
