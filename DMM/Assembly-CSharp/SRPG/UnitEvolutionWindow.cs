// Decompiled with JetBrains decompiler
// Type: SRPG.UnitEvolutionWindow
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
  [Token(Token = "0x2002C1D")]
  [FlowNode.Pin(101, "入手クエストが選択された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "閉じる：完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(3, "詳細ボタンが押された", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "閉じる", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(0, "表示を更新", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/UnitEvolutionWindow")]
  [FlowNode.Pin(100, "ユニットが進化した", FlowNode.PinTypes.Output, 100)]
  public class UnitEvolutionWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DA12")]
    [FieldOffset(Offset = "0xC")]
    [HelpBox("アイテムの親となるゲームオブジェクト")]
    public RectTransform ListParent;
    [Token(Token = "0x400DA13")]
    [FieldOffset(Offset = "0x10")]
    [HelpBox("アイテムスロットの雛形")]
    public ListItemEvents ItemSlotTemplate;
    [Token(Token = "0x400DA14")]
    [FieldOffset(Offset = "0x14")]
    [HelpBox("不要なスロットの雛形")]
    public GameObject UnusedSlotTemplate;
    [Token(Token = "0x400DA15")]
    [FieldOffset(Offset = "0x18")]
    [HelpBox("不要なスロットを表示する")]
    public bool ShowUnusedSlots;
    [Token(Token = "0x400DA16")]
    [FieldOffset(Offset = "0x1C")]
    [HelpBox("最大スロット数")]
    public int MaxSlots;
    [Token(Token = "0x400DA17")]
    [FieldOffset(Offset = "0x20")]
    [HelpBox("足りてないものを表示するラベル")]
    public Text HelpText;
    [Token(Token = "0x400DA18")]
    [FieldOffset(Offset = "0x24")]
    public Button EvolveButton;
    [Token(Token = "0x400DA19")]
    [FieldOffset(Offset = "0x28")]
    public UnitData Unit;
    [Token(Token = "0x400DA1A")]
    [FieldOffset(Offset = "0x2C")]
    public ScrollRect ScrollParent;
    [Token(Token = "0x400DA1B")]
    [FieldOffset(Offset = "0x30")]
    public Transform QuestListParent;
    [Token(Token = "0x400DA1C")]
    [FieldOffset(Offset = "0x34")]
    public GameObject QuestListItemTemplate;
    [Token(Token = "0x400DA1D")]
    [FieldOffset(Offset = "0x38")]
    public SRPG_Button MainPanelCloseBtn;
    [Token(Token = "0x400DA1E")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject ItemSlotRoot;
    [Token(Token = "0x400DA1F")]
    [FieldOffset(Offset = "0x40")]
    public GameObject ItemSlotBox;
    [Token(Token = "0x400DA20")]
    [FieldOffset(Offset = "0x44")]
    public GameObject MainPanel;
    [Token(Token = "0x400DA21")]
    [FieldOffset(Offset = "0x48")]
    public GameObject SubPanel;
    [Token(Token = "0x400DA22")]
    [FieldOffset(Offset = "0x4C")]
    private List<GameObject> mItems;
    [Token(Token = "0x400DA23")]
    [FieldOffset(Offset = "0x50")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400DA24")]
    [FieldOffset(Offset = "0x54")]
    private List<GameObject> mBoxs;
    [Token(Token = "0x400DA25")]
    [FieldOffset(Offset = "0x58")]
    private List<GameObject> mGainedQuests;
    [Token(Token = "0x400DA26")]
    [FieldOffset(Offset = "0x5C")]
    private string mLastSelectItemIname;
    [Token(Token = "0x400DA27")]
    [FieldOffset(Offset = "0x60")]
    private float mDecelerationRate;
    [Token(Token = "0x400DA28")]
    [FieldOffset(Offset = "0x64")]
    public UnitEvolutionWindow.UnitEvolveEvent OnEvolve;
    [Token(Token = "0x400DA29")]
    [FieldOffset(Offset = "0x68")]
    public UnitEvolutionWindow.EvolveCloseEvent OnEvolveClose;
    [Token(Token = "0x400DA2A")]
    [FieldOffset(Offset = "0x6C")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string QuestDetail;
    [Token(Token = "0x400DA2B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string QuestDetailMulti;
    [Token(Token = "0x400DA2C")]
    [FieldOffset(Offset = "0x74")]
    protected QuestParam mCurrentQuest;
    [Token(Token = "0x400DA2D")]
    [FieldOffset(Offset = "0x78")]
    private LoadRequest mReqQuestDetail;
    [Token(Token = "0x400DA2E")]
    [FieldOffset(Offset = "0x7C")]
    private LoadRequest mReqQuestDefaultDetail;
    [Token(Token = "0x400DA2F")]
    [FieldOffset(Offset = "0x80")]
    private LoadRequest mReqQuestMultiDetail;

    [Token(Token = "0x600CC1F")]
    [Address(RVA = "0x96FA30", Offset = "0x96E830", VA = "0x1096FA30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CC20")]
    [Address(RVA = "0x971880", Offset = "0x970680", VA = "0x10971880")]
    private void Start()
    {
    }

    [Token(Token = "0x600CC21")]
    [Address(RVA = "0x970000", Offset = "0x96EE00", VA = "0x10970000")]
    private void OnEvolveClick()
    {
    }

    [Token(Token = "0x600CC22")]
    [Address(RVA = "0x96FF50", Offset = "0x96ED50", VA = "0x1096FF50")]
    private RecipeParam GetCurrentRecipe(UnitData unit) => (RecipeParam) null;

    [Token(Token = "0x600CC23")]
    [Address(RVA = "0x970090", Offset = "0x96EE90", VA = "0x10970090")]
    private void OnItemSelect2(GameObject go)
    {
    }

    [Token(Token = "0x600CC24")]
    [Address(RVA = "0x9710D0", Offset = "0x96FED0", VA = "0x109710D0")]
    private void RefreshSubPanel(int index = -1)
    {
    }

    [Token(Token = "0x600CC25")]
    [Address(RVA = "0x96FB30", Offset = "0x96E930", VA = "0x1096FB30")]
    private void AddList(QuestParam qparam, bool isActive = false)
    {
    }

    [Token(Token = "0x600CC26")]
    [Address(RVA = "0x96FEC0", Offset = "0x96ECC0", VA = "0x1096FEC0")]
    private void ClearPanel()
    {
    }

    [Token(Token = "0x600CC27")]
    [Address(RVA = "0x971750", Offset = "0x970550", VA = "0x10971750")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x600CC28")]
    [Address(RVA = "0x971060", Offset = "0x96FE60", VA = "0x10971060")]
    private IEnumerator RefreshScrollRect() => (IEnumerator) null;

    [Token(Token = "0x600CC29")]
    [Address(RVA = "0x970110", Offset = "0x96EF10", VA = "0x10970110")]
    private void OnQuestSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CC2A")]
    [Address(RVA = "0x970610", Offset = "0x96F410", VA = "0x10970610")]
    public void Refresh2()
    {
    }

    [Token(Token = "0x600CC2B")]
    [Address(RVA = "0x970480", Offset = "0x96F280", VA = "0x10970480")]
    private void OpenQuestDetail(QuestParam param)
    {
    }

    [Token(Token = "0x600CC2C")]
    [Address(RVA = "0x971B50", Offset = "0x970950", VA = "0x10971B50")]
    public UnitEvolutionWindow()
    {
    }

    [Token(Token = "0x2002C1E")]
    public delegate void UnitEvolveEvent();

    [Token(Token = "0x2002C1F")]
    public delegate void EvolveCloseEvent();
  }
}
