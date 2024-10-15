// Decompiled with JetBrains decompiler
// Type: SRPG.RuneFilterWindow
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
  [Token(Token = "0x2002AE4")]
  [FlowNode.Pin(2, "全選択解除", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/SortFilter/RuneFilterWindow")]
  [FlowNode.Pin(11, "キャンセル完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "Save完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(4, "タブ切替", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "キャンセル", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(0, "Save", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "全選択", FlowNode.PinTypes.Input, 1)]
  public class RuneFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D135")]
    public const int PIN_INPUT_SAVE = 0;
    [Token(Token = "0x400D136")]
    public const int PIN_INPUT_ALL_SELECT = 1;
    [Token(Token = "0x400D137")]
    public const int PIN_INPUT_ALL_CLEAR_SELECT = 2;
    [Token(Token = "0x400D138")]
    public const int PIN_INPUT_CANCEL = 3;
    [Token(Token = "0x400D139")]
    public const int PIN_INPUT_TAB_CHANGE = 4;
    [Token(Token = "0x400D13A")]
    public const int PIN_OUTPUT_SAVE_END = 10;
    [Token(Token = "0x400D13B")]
    public const int PIN_OUTPUT_CANCEL_END = 11;
    [Token(Token = "0x400D13C")]
    private const string SVB_KEY_CATEGORY_RARITY = "category_rarity";
    [Token(Token = "0x400D13D")]
    private const string SVB_KEY_CATEGORY_SETEFF = "category_seteff";
    [Token(Token = "0x400D13E")]
    private const string SVB_KEY_CATEGORY_EVOSTATUS = "category_evostatus";
    [Token(Token = "0x400D13F")]
    private const string SVB_KEY_CATEGORY_DEDICATED = "category_dedicated";
    [Token(Token = "0x400D140")]
    private const string SVB_KEY_CATEGORY_OVERWRITEPARTY = "category_overwriteparty";
    [Token(Token = "0x400D141")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mTabParent;
    [Token(Token = "0x400D142")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mTabTemplate;
    [Token(Token = "0x400D143")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x400D144")]
    [FieldOffset(Offset = "0x18")]
    private FilterRunePrefs mCurrentFilterPrefs;
    [Token(Token = "0x400D145")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, RuneFilterTab> mTabs;
    [Token(Token = "0x400D146")]
    [FieldOffset(Offset = "0x20")]
    private List<RuneFilterCategory> mCategoryObjects;
    [Token(Token = "0x400D147")]
    [FieldOffset(Offset = "0x24")]
    private string mCurrentTabName;
    [Token(Token = "0x400D148")]
    [FieldOffset(Offset = "0x28")]
    private IEnumerator mToggleFadeAnimation;
    [Token(Token = "0x400D149")]
    [FieldOffset(Offset = "0x0")]
    private static RuneFilterWindow mInstance;

    [Token(Token = "0x17001A19")]
    public static RuneFilterWindow Instance
    {
      [Token(Token = "0x600C3F1"), Address(RVA = "0x8C4410", Offset = "0x8C3210", VA = "0x108C4410")] get
      {
        return (RuneFilterWindow) null;
      }
    }

    [Token(Token = "0x17001A1A")]
    public FilterRunePrefs CurrentFilterPrefs
    {
      [Token(Token = "0x600C3F2"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (FilterRunePrefs) null;
      }
    }

    [Token(Token = "0x600C3F3")]
    [Address(RVA = "0x8C2DF0", Offset = "0x8C1BF0", VA = "0x108C2DF0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C3F4")]
    [Address(RVA = "0x8C3020", Offset = "0x8C1E20", VA = "0x108C3020")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C3F5")]
    [Address(RVA = "0x8C36F0", Offset = "0x8C24F0", VA = "0x108C36F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C3F6")]
    [Address(RVA = "0x8C36F0", Offset = "0x8C24F0", VA = "0x108C36F0")]
    private void Init()
    {
    }

    [Token(Token = "0x600C3F7")]
    [Address(RVA = "0x8C3460", Offset = "0x8C2260", VA = "0x108C3460")]
    private void Init_Tab()
    {
    }

    [Token(Token = "0x600C3F8")]
    [Address(RVA = "0x8C3060", Offset = "0x8C1E60", VA = "0x108C3060")]
    private void Init_Category()
    {
    }

    [Token(Token = "0x600C3F9")]
    [Address(RVA = "0x8C3B60", Offset = "0x8C2960", VA = "0x108C3B60")]
    private void SelectTab(string tab_name)
    {
    }

    [Token(Token = "0x600C3FA")]
    [Address(RVA = "0x8C3FD0", Offset = "0x8C2DD0", VA = "0x108C3FD0")]
    public void UpdateTabState()
    {
    }

    [Token(Token = "0x600C3FB")]
    [Address(RVA = "0x8C3720", Offset = "0x8C2520", VA = "0x108C3720")]
    private bool IsExistActiveFilterInTab(string tab) => new bool();

    [Token(Token = "0x600C3FC")]
    [Address(RVA = "0x8C3BE0", Offset = "0x8C29E0", VA = "0x108C3BE0")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x600C3FD")]
    [Address(RVA = "0x8BE930", Offset = "0x8BD730", VA = "0x108BE930")]
    private void StartSwitchVisibleAnimation(List<CanvasGroup> list_on, List<CanvasGroup> list_off)
    {
    }

    [Token(Token = "0x600C3FE")]
    [Address(RVA = "0x8BE970", Offset = "0x8BD770", VA = "0x108BE970")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x600C3FF")]
    [Address(RVA = "0x8C3990", Offset = "0x8C2790", VA = "0x108C3990")]
    private bool SavePrefs() => new bool();

    [Token(Token = "0x600C400")]
    [Address(RVA = "0x8C3890", Offset = "0x8C2690", VA = "0x108C3890")]
    private void OnSelectAll(bool is_on)
    {
    }

    [Token(Token = "0x600C401")]
    [Address(RVA = "0x8C4360", Offset = "0x8C3160", VA = "0x108C4360")]
    public RuneFilterWindow()
    {
    }
  }
}
