// Decompiled with JetBrains decompiler
// Type: SRPG.UnitEquipmentWindow
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
  [Token(Token = "0x2002C13")]
  [FlowNode.Pin(103, "アイテムが一括作成された", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(1, "ウインドウを表示", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "ウインドウの表示要素を再読み込み", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(104, "汎用装備が選択された", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(110, "クエスト書庫が選択された", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("UI/UnitEquipmentWindow")]
  [FlowNode.Pin(3, "アイテムの汎用装備が選択された", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(101, "入手クエストが選択された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "アイテムが作成された", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(100, "装備アイテムが装着された", FlowNode.PinTypes.Output, 100)]
  public class UnitEquipmentWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D9CF")]
    [FieldOffset(Offset = "0xC")]
    public UnitEquipmentWindow.EquipEvent OnEquip;
    [Token(Token = "0x400D9D0")]
    [FieldOffset(Offset = "0x10")]
    public UnitEquipmentWindow.EquipEvent OnCommonEquip;
    [Token(Token = "0x400D9D1")]
    [FieldOffset(Offset = "0x14")]
    public UnitEquipmentWindow.EquipReloadEvent OnReload;
    [Token(Token = "0x400D9D2")]
    [FieldOffset(Offset = "0x18")]
    public GameObject SubWindow;
    [Token(Token = "0x400D9D3")]
    [FieldOffset(Offset = "0x1C")]
    public SRPG_Button EquipButton;
    [Token(Token = "0x400D9D4")]
    [FieldOffset(Offset = "0x20")]
    public SRPG_Button CommonEquipButton;
    [Token(Token = "0x400D9D5")]
    [FieldOffset(Offset = "0x24")]
    public SRPG_Button ConfirmQuestButton;
    [Token(Token = "0x400D9D6")]
    [FieldOffset(Offset = "0x28")]
    public SRPG_Button ConfirmRecipeButton;
    [Token(Token = "0x400D9D7")]
    [FieldOffset(Offset = "0x2C")]
    public SRPG_Button CreateButton;
    [Token(Token = "0x400D9D8")]
    [FieldOffset(Offset = "0x30")]
    public SRPG_Button CreateButtonAll;
    [Token(Token = "0x400D9D9")]
    [FieldOffset(Offset = "0x34")]
    public RectTransform RecipeParent;
    [Token(Token = "0x400D9DA")]
    [FieldOffset(Offset = "0x38")]
    public RectTransform QuestsParent;
    [Token(Token = "0x400D9DB")]
    [FieldOffset(Offset = "0x3C")]
    public RectTransform SelectedItem;
    [Token(Token = "0x400D9DC")]
    [FieldOffset(Offset = "0x40")]
    public RectTransform ItemTreeParent;
    [Token(Token = "0x400D9DD")]
    [FieldOffset(Offset = "0x44")]
    public RectTransform ItemTreeArrow;
    [Token(Token = "0x400D9DE")]
    [FieldOffset(Offset = "0x48")]
    public ListItemEvents ItemTreeTemplate;
    [Token(Token = "0x400D9DF")]
    [FieldOffset(Offset = "0x4C")]
    public RectTransform RecipeListParent;
    [Token(Token = "0x400D9E0")]
    [FieldOffset(Offset = "0x50")]
    public RectTransform RecipeListLine;
    [Token(Token = "0x400D9E1")]
    [FieldOffset(Offset = "0x54")]
    public ListItemEvents RecipeListItemTemplate;
    [Token(Token = "0x400D9E2")]
    [FieldOffset(Offset = "0x58")]
    public ScrollRect QuestListScrollRect;
    [Token(Token = "0x400D9E3")]
    [FieldOffset(Offset = "0x5C")]
    public RectTransform QuestListParent;
    [Token(Token = "0x400D9E4")]
    [FieldOffset(Offset = "0x60")]
    public GameObject QuestListItemTemplate;
    [Token(Token = "0x400D9E5")]
    [FieldOffset(Offset = "0x64")]
    public RectTransform EquipItemParamParent;
    [Token(Token = "0x400D9E6")]
    [FieldOffset(Offset = "0x68")]
    public GameObject EquipItemParamTemplate;
    [Token(Token = "0x400D9E7")]
    [FieldOffset(Offset = "0x6C")]
    private EquipData mEquipmentData;
    [Token(Token = "0x400D9E8")]
    [FieldOffset(Offset = "0x70")]
    private List<GameObject> mEquipmentParameters;
    [Token(Token = "0x400D9E9")]
    [FieldOffset(Offset = "0x74")]
    private List<ItemParam> mItemParamTree;
    [Token(Token = "0x400D9EA")]
    [FieldOffset(Offset = "0x78")]
    private List<GameObject> ItemTree;
    [Token(Token = "0x400D9EB")]
    [FieldOffset(Offset = "0x7C")]
    private List<EquipRecipeItem> RecipeItems;
    [Token(Token = "0x400D9EC")]
    [FieldOffset(Offset = "0x80")]
    private List<GameObject> GainedQuests;
    [Token(Token = "0x400D9ED")]
    [FieldOffset(Offset = "0x84")]
    private List<GameObject> GainedDetailQuests;
    [Token(Token = "0x400D9EE")]
    [FieldOffset(Offset = "0x88")]
    private List<GameObject> GainedDetailQuestsMask;
    [Token(Token = "0x400D9EF")]
    [FieldOffset(Offset = "0x8C")]
    private bool mCreateItemSuccessed;
    [Token(Token = "0x400D9F0")]
    [FieldOffset(Offset = "0x90")]
    private ItemParam LastUpadatedItemParam;
    [Token(Token = "0x400D9F1")]
    [FieldOffset(Offset = "0x94")]
    public GameObject[] NoCommonUI;
    [Token(Token = "0x400D9F2")]
    [FieldOffset(Offset = "0x98")]
    public GameObject[] CommonUI;
    [Token(Token = "0x400D9F3")]
    [FieldOffset(Offset = "0x9C")]
    public GameObject QuestCommonEquipButton;
    [Token(Token = "0x400D9F4")]
    [FieldOffset(Offset = "0xA0")]
    public GameObject RecipeCommonEquipButton;
    [Token(Token = "0x400D9F5")]
    [FieldOffset(Offset = "0xA4")]
    public Text EquipAmount;
    [Token(Token = "0x400D9F6")]
    [FieldOffset(Offset = "0xA8")]
    public Color EquipAmountColor;
    [Token(Token = "0x400D9F7")]
    [FieldOffset(Offset = "0xB8")]
    public Color EquipAmountColorZero;
    [Token(Token = "0x400D9F8")]
    [FieldOffset(Offset = "0xC8")]
    private UnitData SelectedUnitData;
    [Token(Token = "0x400D9F9")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string QuestDetail;
    [Token(Token = "0x400D9FA")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string QuestDetailMulti;
    [Token(Token = "0x400D9FB")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    [Header("スクロール位置を再計算する")]
    [Space(5f)]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x400D9FC")]
    [FieldOffset(Offset = "0xD8")]
    protected QuestParam mCurrentQuest;
    [Token(Token = "0x400D9FD")]
    [FieldOffset(Offset = "0xDC")]
    private LoadRequest mReqQuestDetail;
    [Token(Token = "0x400D9FE")]
    [FieldOffset(Offset = "0xE0")]
    private LoadRequest mReqQuestDefaultDetail;
    [Token(Token = "0x400D9FF")]
    [FieldOffset(Offset = "0xE4")]
    private LoadRequest mReqQuestMultiDetail;
    [Token(Token = "0x400DA00")]
    [FieldOffset(Offset = "0xE8")]
    private NeedEquipItemList mNeedEquipItemList;
    [Token(Token = "0x400DA01")]
    [FieldOffset(Offset = "0xEC")]
    private List<UnitEquipmentWindow.ResetDefaultColor> EquipButtonColor;
    [Token(Token = "0x400DA02")]
    [FieldOffset(Offset = "0xF0")]
    private List<UnitEquipmentWindow.ResetDefaultColor> CommonButtonEquipColor;

    [Token(Token = "0x17001B07")]
    private bool IsTreeTop
    {
      [Token(Token = "0x600CBDE"), Address(RVA = "0x96F9F0", Offset = "0x96E7F0", VA = "0x1096F9F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CBDF")]
    [Address(RVA = "0x96AAC0", Offset = "0x9698C0", VA = "0x1096AAC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CBE0")]
    [Address(RVA = "0x96B1F0", Offset = "0x969FF0", VA = "0x1096B1F0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600CBE1")]
    [Address(RVA = "0x96F150", Offset = "0x96DF50", VA = "0x1096F150")]
    private void Start()
    {
    }

    [Token(Token = "0x600CBE2")]
    [Address(RVA = "0x96EC90", Offset = "0x96DA90", VA = "0x1096EC90")]
    public void SetResetColor(
      List<UnitEquipmentWindow.ResetDefaultColor> EquipButtonColorList,
      Graphic graphic)
    {
    }

    [Token(Token = "0x600CBE3")]
    [Address(RVA = "0x96B3F0", Offset = "0x96A1F0", VA = "0x1096B3F0")]
    private int GetSelectedJobIndex(UnitData unit) => new int();

    [Token(Token = "0x600CBE4")]
    [Address(RVA = "0x96BAD0", Offset = "0x96A8D0", VA = "0x1096BAD0")]
    private void OnConfirmQuestClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBE5")]
    [Address(RVA = "0x96BAD0", Offset = "0x96A8D0", VA = "0x1096BAD0")]
    private void OnConfirmRecipeClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBE6")]
    [Address(RVA = "0x96BC60", Offset = "0x96AA60", VA = "0x1096BC60")]
    private void OnEquipClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBE7")]
    [Address(RVA = "0x96BBC0", Offset = "0x96A9C0", VA = "0x1096BBC0")]
    private void OnCreateClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBE8")]
    [Address(RVA = "0x96BBC0", Offset = "0x96A9C0", VA = "0x1096BBC0")]
    private void OnCreateClick()
    {
    }

    [Token(Token = "0x600CBE9")]
    [Address(RVA = "0x96BB20", Offset = "0x96A920", VA = "0x1096BB20")]
    private void OnCreateAllClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBEA")]
    [Address(RVA = "0x96B7F0", Offset = "0x96A5F0", VA = "0x1096B7F0")]
    private void OnCommonEquipClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBEB")]
    [Address(RVA = "0x96B3D0", Offset = "0x96A1D0", VA = "0x1096B3D0")]
    private void CommonEquip(GameObject go = null)
    {
    }

    [Token(Token = "0x600CBEC")]
    [Address(RVA = "0x7B3BD0", Offset = "0x7B29D0", VA = "0x107B3BD0")]
    public void CommonEquiped()
    {
    }

    [Token(Token = "0x600CBED")]
    [Address(RVA = "0x96ED70", Offset = "0x96DB70", VA = "0x1096ED70")]
    public void SetRestorationRecipeItem(List<ItemParam> item)
    {
    }

    [Token(Token = "0x600CBEE")]
    [Address(RVA = "0x96BE90", Offset = "0x96AC90", VA = "0x1096BE90")]
    private void OnItemTreeSelect(GameObject go)
    {
    }

    [Token(Token = "0x600CBEF")]
    [Address(RVA = "0x96C6B0", Offset = "0x96B4B0", VA = "0x1096C6B0")]
    private void OnRecipeItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600CBF0")]
    [Address(RVA = "0x96C770", Offset = "0x96B570", VA = "0x1096C770")]
    private void OpenQuestDetail(QuestParam param)
    {
    }

    [Token(Token = "0x600CBF1")]
    [Address(RVA = "0x96C070", Offset = "0x96AE70", VA = "0x1096C070")]
    private void OnQuestDetailSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBF2")]
    [Address(RVA = "0x96BF80", Offset = "0x96AD80", VA = "0x1096BF80")]
    private void OnQuestDetailSelectMask(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBF3")]
    [Address(RVA = "0x96C160", Offset = "0x96AF60", VA = "0x1096C160")]
    private void OnQuestSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CBF4")]
    [Address(RVA = "0x96C900", Offset = "0x96B700", VA = "0x1096C900")]
    private void RefreshEquipButton(UnitData unit)
    {
    }

    [Token(Token = "0x600CBF5")]
    [Address(RVA = "0x96EC20", Offset = "0x96DA20", VA = "0x1096EC20")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600CBF6")]
    [Address(RVA = "0x96E4C0", Offset = "0x96D2C0", VA = "0x1096E4C0")]
    public void Refresh(UnitData unit, int slot)
    {
    }

    [Token(Token = "0x600CBF7")]
    [Address(RVA = "0x96D1D0", Offset = "0x96BFD0", VA = "0x1096D1D0")]
    private void RefreshItemTree(bool created = false)
    {
    }

    [Token(Token = "0x600CBF8")]
    [Address(RVA = "0x96D860", Offset = "0x96C660", VA = "0x1096D860")]
    private void RefreshRecipeItems()
    {
    }

    [Token(Token = "0x600CBF9")]
    [Address(RVA = "0x96CB90", Offset = "0x96B990", VA = "0x1096CB90")]
    private void RefreshGainedQuests()
    {
    }

    [Token(Token = "0x600CBFA")]
    [Address(RVA = "0x96F0A0", Offset = "0x96DEA0", VA = "0x1096F0A0")]
    private void SetScrollTop()
    {
    }

    [Token(Token = "0x600CBFB")]
    [Address(RVA = "0x96EE60", Offset = "0x96DC60", VA = "0x1096EE60")]
    private void SetScrollPos(List<QuestParam> quest_list)
    {
    }

    [Token(Token = "0x600CBFC")]
    [Address(RVA = "0x96B4C0", Offset = "0x96A2C0", VA = "0x1096B4C0")]
    private IEnumerator InitScroll(Vector2 vector) => (IEnumerator) null;

    [Token(Token = "0x600CBFD")]
    [Address(RVA = "0x96B260", Offset = "0x96A060", VA = "0x1096B260")]
    public void ClearPanel(bool stop_coroutine = true)
    {
    }

    [Token(Token = "0x600CBFE")]
    [Address(RVA = "0x96AC60", Offset = "0x969A60", VA = "0x1096AC60")]
    private void AddPanel(QuestParam questparam, QuestParam[] availableQuests)
    {
    }

    [Token(Token = "0x600CBFF")]
    [Address(RVA = "0x96B540", Offset = "0x96A340", VA = "0x1096B540")]
    public bool IsCommonEquipUI(long unit_id, int slot) => new bool();

    [Token(Token = "0x600CC00")]
    [Address(RVA = "0x96A8A0", Offset = "0x9696A0", VA = "0x1096A8A0")]
    public void ActivateCommonUI(bool is_common)
    {
    }

    [Token(Token = "0x600CC01")]
    [Address(RVA = "0x96ABA0", Offset = "0x9699A0", VA = "0x1096ABA0")]
    public void ActiveCommonEquipButton(bool is_common)
    {
    }

    [Token(Token = "0x600CC02")]
    [Address(RVA = "0x96F7A0", Offset = "0x96E5A0", VA = "0x1096F7A0")]
    public UnitEquipmentWindow()
    {
    }

    [Token(Token = "0x2002C14")]
    public delegate void EquipEvent();

    [Token(Token = "0x2002C15")]
    public delegate void EquipReloadEvent();

    [Token(Token = "0x2002C16")]
    public class ResetDefaultColor
    {
      [Token(Token = "0x400DA03")]
      [FieldOffset(Offset = "0x8")]
      private Graphic graphic;
      [Token(Token = "0x400DA04")]
      [FieldOffset(Offset = "0xC")]
      private Color color;

      [Token(Token = "0x600CC0C")]
      [Address(RVA = "0x968D10", Offset = "0x967B10", VA = "0x10968D10")]
      public ResetDefaultColor(Graphic graphic)
      {
      }

      [Token(Token = "0x600CC0D")]
      [Address(RVA = "0x968CD0", Offset = "0x967AD0", VA = "0x10968CD0")]
      public void Reset()
      {
      }
    }
  }
}
