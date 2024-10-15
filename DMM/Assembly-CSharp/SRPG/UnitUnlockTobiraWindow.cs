// Decompiled with JetBrains decompiler
// Type: SRPG.UnitUnlockTobiraWindow
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
  [Token(Token = "0x2002D24")]
  [FlowNode.Pin(101, "入手クエストが選択された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(51, "クエストをクリック", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(52, "クエスト詳細ボタンをクリック", FlowNode.PinTypes.Input, 52)]
  [FlowNode.Pin(100, "真理開眼開放ボタン押下", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(0, "表示を更新", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/UnitUnlockTobiraWindow")]
  [FlowNode.Pin(102, "閉じる：完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "共鳴状況で限界突破出来ないようにする判定", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(50, "素材をクリック", FlowNode.PinTypes.Input, 50)]
  public class UnitUnlockTobiraWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E0F9")]
    public const int ON_CLICK_ELEMENT_BUTTON = 50;
    [Token(Token = "0x400E0FA")]
    public const int ON_CLICK_QUEST_BUTTON = 51;
    [Token(Token = "0x400E0FB")]
    public const int ON_CLICK_QUESTDETAIL_BUTTON = 52;
    [Token(Token = "0x400E0FC")]
    public const int ON_CLICK_UNLOCK_TOBIRA_BUTTON = 100;
    [Token(Token = "0x400E0FD")]
    public const int OUT_SELECT_QUEST = 101;
    [Token(Token = "0x400E0FE")]
    public const int OUT_CLOSE_WINDOW = 102;
    [Token(Token = "0x400E0FF")]
    public const int OUT_CHECK_RESONANCE = 103;
    [Token(Token = "0x400E100")]
    [FieldOffset(Offset = "0xC")]
    [HelpBox("アイテムの親となるゲームオブジェクト")]
    public RectTransform ListParent;
    [Token(Token = "0x400E101")]
    [FieldOffset(Offset = "0x10")]
    [HelpBox("アイテムスロットの雛形")]
    public GameObject ItemSlotTemplate;
    [Token(Token = "0x400E102")]
    [FieldOffset(Offset = "0x14")]
    [HelpBox("不要なスロットの雛形")]
    public GameObject UnusedSlotTemplate;
    [Token(Token = "0x400E103")]
    [FieldOffset(Offset = "0x18")]
    [HelpBox("不要なスロットを表示する")]
    public bool ShowUnusedSlots;
    [Token(Token = "0x400E104")]
    [FieldOffset(Offset = "0x1C")]
    [HelpBox("最大スロット数")]
    public int MaxSlots;
    [Token(Token = "0x400E105")]
    [FieldOffset(Offset = "0x20")]
    [HelpBox("足りてないものを表示するラベル")]
    public Text HelpText;
    [Token(Token = "0x400E106")]
    [FieldOffset(Offset = "0x24")]
    public Button UnlockTobiraButton;
    [Token(Token = "0x400E107")]
    [FieldOffset(Offset = "0x28")]
    public ScrollRect ScrollParent;
    [Token(Token = "0x400E108")]
    [FieldOffset(Offset = "0x2C")]
    public Transform QuestListParent;
    [Token(Token = "0x400E109")]
    [FieldOffset(Offset = "0x30")]
    public GameObject QuestListItemTemplate;
    [Token(Token = "0x400E10A")]
    [FieldOffset(Offset = "0x34")]
    public Button MainPanelCloseBtn;
    [Token(Token = "0x400E10B")]
    [FieldOffset(Offset = "0x38")]
    public GameObject ItemSlotRoot;
    [Token(Token = "0x400E10C")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject ItemSlotBox;
    [Token(Token = "0x400E10D")]
    [FieldOffset(Offset = "0x40")]
    public GameObject MainPanel;
    [Token(Token = "0x400E10E")]
    [FieldOffset(Offset = "0x44")]
    public GameObject SubPanel;
    [Token(Token = "0x400E10F")]
    [FieldOffset(Offset = "0x48")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400E110")]
    [FieldOffset(Offset = "0x4C")]
    private List<GameObject> mItems;
    [Token(Token = "0x400E111")]
    [FieldOffset(Offset = "0x50")]
    private List<GameObject> mBoxs;
    [Token(Token = "0x400E112")]
    [FieldOffset(Offset = "0x54")]
    private List<GameObject> mGainedQuests;
    [Token(Token = "0x400E113")]
    [FieldOffset(Offset = "0x58")]
    private string mLastSelectItemIname;
    [Token(Token = "0x400E114")]
    [FieldOffset(Offset = "0x5C")]
    private float mDecelerationRate;
    [Token(Token = "0x400E115")]
    [FieldOffset(Offset = "0x60")]
    public UnitUnlockTobiraWindow.CallbackEvent OnCallback;
    [Token(Token = "0x400E116")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string QuestDetail;
    [Token(Token = "0x400E117")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string QuestDetailMulti;
    [Token(Token = "0x400E118")]
    [FieldOffset(Offset = "0x6C")]
    protected QuestParam mCurrentQuest;
    [Token(Token = "0x400E119")]
    [FieldOffset(Offset = "0x70")]
    private LoadRequest mReqQuestDetail;
    [Token(Token = "0x400E11A")]
    [FieldOffset(Offset = "0x74")]
    private LoadRequest mReqQuestDefaultDetail;
    [Token(Token = "0x400E11B")]
    [FieldOffset(Offset = "0x78")]
    private LoadRequest mReqQuestMultiDetail;
    [Token(Token = "0x400E11C")]
    [FieldOffset(Offset = "0x7C")]
    private SerializeValueList serializeValueList;

    [Token(Token = "0x600D25B")]
    [Address(RVA = "0x9D62D0", Offset = "0x9D50D0", VA = "0x109D62D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D25C")]
    [Address(RVA = "0x9D88F0", Offset = "0x9D76F0", VA = "0x109D88F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600D25D")]
    [Address(RVA = "0x9D6880", Offset = "0x9D5680", VA = "0x109D6880")]
    private void OnQuestSelect(QuestParam quest)
    {
    }

    [Token(Token = "0x600D25E")]
    [Address(RVA = "0x9D6D70", Offset = "0x9D5B70", VA = "0x109D6D70")]
    private void RefreshSubPanel(int index)
    {
    }

    [Token(Token = "0x600D25F")]
    [Address(RVA = "0x9D64C0", Offset = "0x9D52C0", VA = "0x109D64C0")]
    private void AddList(QuestParam qparam, bool isActive = false)
    {
    }

    [Token(Token = "0x600D260")]
    [Address(RVA = "0x9D87C0", Offset = "0x9D75C0", VA = "0x109D87C0")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x600D261")]
    [Address(RVA = "0x9D6D00", Offset = "0x9D5B00", VA = "0x109D6D00")]
    private IEnumerator RefreshScrollRect() => (IEnumerator) null;

    [Token(Token = "0x600D262")]
    [Address(RVA = "0x9D74B0", Offset = "0x9D62B0", VA = "0x109D74B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600D263")]
    [Address(RVA = "0x9D8B10", Offset = "0x9D7910", VA = "0x109D8B10")]
    private bool _CheckNullReference() => new bool();

    [Token(Token = "0x600D264")]
    [Address(RVA = "0x9D67F0", Offset = "0x9D55F0", VA = "0x109D67F0")]
    private TobiraRecipeParam GetCurrentRecipe() => (TobiraRecipeParam) null;

    [Token(Token = "0x600D265")]
    [Address(RVA = "0x9D6B80", Offset = "0x9D5980", VA = "0x109D6B80")]
    private void OpenQuestDetail(QuestParam param)
    {
    }

    [Token(Token = "0x600D266")]
    [Address(RVA = "0x9D8CB0", Offset = "0x9D7AB0", VA = "0x109D8CB0")]
    public UnitUnlockTobiraWindow()
    {
    }

    [Token(Token = "0x2002D25")]
    public delegate void CallbackEvent();
  }
}
