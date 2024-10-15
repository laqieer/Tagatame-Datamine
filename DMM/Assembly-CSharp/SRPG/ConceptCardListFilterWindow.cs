// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardListFilterWindow
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
  [Token(Token = "0x2002AD7")]
  [FlowNode.Pin(1, "全選択", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/SortFilter/ConceptCardListFilterWindow")]
  [FlowNode.Pin(10, "Save完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "キャンセル完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(0, "Save", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "全選択解除", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "キャンセル", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "タブ切替", FlowNode.PinTypes.Input, 4)]
  public class ConceptCardListFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D0EE")]
    public const int PIN_INPUT_SAVE = 0;
    [Token(Token = "0x400D0EF")]
    public const int PIN_INPUT_ALL_SELECT = 1;
    [Token(Token = "0x400D0F0")]
    public const int PIN_INPUT_ALL_CLEAR_SELECT = 2;
    [Token(Token = "0x400D0F1")]
    public const int PIN_INPUT_CANCEL = 3;
    [Token(Token = "0x400D0F2")]
    public const int PIN_INPUT_TAB_CHANGE = 4;
    [Token(Token = "0x400D0F3")]
    public const int PIN_OUTPUT_SAVE_END = 10;
    [Token(Token = "0x400D0F4")]
    public const int PIN_OUTPUT_CANCEL_END = 11;
    [Token(Token = "0x400D0F5")]
    private const string SVB_KEY_CATEGORY_RARITY = "category_rarity";
    [Token(Token = "0x400D0F6")]
    private const string SVB_KEY_CATEGORY_BIRTH = "category_birth";
    [Token(Token = "0x400D0F7")]
    private const string SVB_KEY_CATEGORY_CARDGROUP = "category_cardgroup";
    [Token(Token = "0x400D0F8")]
    private const string SVB_KEY_CATEGORY_EXTRARARITY = "category_extra_rarity";
    [Token(Token = "0x400D0F9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mTabParent;
    [Token(Token = "0x400D0FA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mTabTemplate;
    [Token(Token = "0x400D0FB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x400D0FC")]
    [FieldOffset(Offset = "0x18")]
    private FilterConceptCardPrefs mCurrentFilterPrefs;
    [Token(Token = "0x400D0FD")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, ConceptCardFilterTab> mTabs;
    [Token(Token = "0x400D0FE")]
    [FieldOffset(Offset = "0x20")]
    private List<ConceptCardFilterCategory> mCategoryObjects;
    [Token(Token = "0x400D0FF")]
    [FieldOffset(Offset = "0x24")]
    private string mCurrentTabName;
    [Token(Token = "0x400D100")]
    [FieldOffset(Offset = "0x28")]
    private IEnumerator mToggleFadeAnimation;
    [Token(Token = "0x400D101")]
    [FieldOffset(Offset = "0x0")]
    private static ConceptCardListFilterWindow mInstance;

    [Token(Token = "0x17001A0E")]
    public static ConceptCardListFilterWindow Instance
    {
      [Token(Token = "0x600C3A4"), Address(RVA = "0x8BF1D0", Offset = "0x8BDFD0", VA = "0x108BF1D0")] get
      {
        return (ConceptCardListFilterWindow) null;
      }
    }

    [Token(Token = "0x17001A0F")]
    public FilterConceptCardPrefs CurrentFilterPrefs
    {
      [Token(Token = "0x600C3A5"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (FilterConceptCardPrefs) null;
      }
    }

    [Token(Token = "0x600C3A6")]
    [Address(RVA = "0x8BDA20", Offset = "0x8BC820", VA = "0x108BDA20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C3A7")]
    [Address(RVA = "0x8BDC40", Offset = "0x8BCA40", VA = "0x108BDC40")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C3A8")]
    [Address(RVA = "0x8BE2D0", Offset = "0x8BD0D0", VA = "0x108BE2D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C3A9")]
    [Address(RVA = "0x8BE2D0", Offset = "0x8BD0D0", VA = "0x108BE2D0")]
    private void Init()
    {
    }

    [Token(Token = "0x600C3AA")]
    [Address(RVA = "0x8BE0B0", Offset = "0x8BCEB0", VA = "0x108BE0B0")]
    private void Init_Tab()
    {
    }

    [Token(Token = "0x600C3AB")]
    [Address(RVA = "0x8BDC80", Offset = "0x8BCA80", VA = "0x108BDC80")]
    private void Init_Category()
    {
    }

    [Token(Token = "0x600C3AC")]
    [Address(RVA = "0x8BE860", Offset = "0x8BD660", VA = "0x108BE860")]
    private void SelectTab(string tab_name)
    {
    }

    [Token(Token = "0x600C3AD")]
    [Address(RVA = "0x8BED90", Offset = "0x8BDB90", VA = "0x108BED90")]
    public void UpdateTabState()
    {
    }

    [Token(Token = "0x600C3AE")]
    [Address(RVA = "0x8BE300", Offset = "0x8BD100", VA = "0x108BE300")]
    private bool IsExistActiveFilterInTab(string tab) => new bool();

    [Token(Token = "0x600C3AF")]
    [Address(RVA = "0x8BE9B0", Offset = "0x8BD7B0", VA = "0x108BE9B0")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x600C3B0")]
    [Address(RVA = "0x8BE930", Offset = "0x8BD730", VA = "0x108BE930")]
    private void StartSwitchVisibleAnimation(List<CanvasGroup> list_on, List<CanvasGroup> list_off)
    {
    }

    [Token(Token = "0x600C3B1")]
    [Address(RVA = "0x8BE970", Offset = "0x8BD770", VA = "0x108BE970")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x600C3B2")]
    [Address(RVA = "0x8BE570", Offset = "0x8BD370", VA = "0x108BE570")]
    private bool SavePrefs() => new bool();

    [Token(Token = "0x600C3B3")]
    [Address(RVA = "0x8BE470", Offset = "0x8BD270", VA = "0x108BE470")]
    private void OnSelectAll(bool is_on)
    {
    }

    [Token(Token = "0x600C3B4")]
    [Address(RVA = "0x8BF120", Offset = "0x8BDF20", VA = "0x108BF120")]
    public ConceptCardListFilterWindow()
    {
    }
  }
}
