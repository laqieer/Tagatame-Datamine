// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSortWindow
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
  [Token(Token = "0x2002AE9")]
  [AddComponentMenu("UI/SortFilter/RuneSortWindow")]
  [FlowNode.Pin(11, "キャンセル完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "Save完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(3, "キャンセル", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(0, "Save", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "降順", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "昇順", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(4, "タブ切替", FlowNode.PinTypes.Input, 4)]
  public class RuneSortWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D153")]
    public const int PIN_INPUT_SAVE = 0;
    [Token(Token = "0x400D154")]
    public const int PIN_INPUT_TO_DESCENDING = 1;
    [Token(Token = "0x400D155")]
    public const int PIN_INPUT_TO_ASCENDING = 2;
    [Token(Token = "0x400D156")]
    public const int PIN_INPUT_CANCEL = 3;
    [Token(Token = "0x400D157")]
    public const int PIN_INPUT_TAB_CHANGE = 4;
    [Token(Token = "0x400D158")]
    public const int PIN_OUTPUT_SAVE_END = 10;
    [Token(Token = "0x400D159")]
    public const int PIN_OUTPUT_CANCEL_END = 11;
    [Token(Token = "0x400D15A")]
    private const string SVB_KEY_CATEGORY_PARAMS = "category_params";
    [Token(Token = "0x400D15B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mTabParent;
    [Token(Token = "0x400D15C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mTabTemplate;
    [Token(Token = "0x400D15D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x400D15E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle mToggleAscending;
    [Token(Token = "0x400D15F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle mToggleDescending;
    [Token(Token = "0x400D160")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle mToggleBaseParamSort;
    [Token(Token = "0x400D161")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle mToggleEvoParamSort;
    [Token(Token = "0x400D162")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle mToggleSetParamSort;
    [Token(Token = "0x400D163")]
    [FieldOffset(Offset = "0x2C")]
    private SortUtility.SortRunePrefs mCurrentSortPrefs;
    [Token(Token = "0x400D164")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<string, RuneFilterTab> mTabs;
    [Token(Token = "0x400D165")]
    [FieldOffset(Offset = "0x34")]
    private List<RuneSortCategory> mCategoryObjects;
    [Token(Token = "0x400D166")]
    [FieldOffset(Offset = "0x38")]
    private string mCurrentTabName;
    [Token(Token = "0x400D167")]
    [FieldOffset(Offset = "0x3C")]
    private bool mIsAscending;
    [Token(Token = "0x400D168")]
    [FieldOffset(Offset = "0x3D")]
    private bool mIsBaseParamSort;
    [Token(Token = "0x400D169")]
    [FieldOffset(Offset = "0x3E")]
    private bool mIsEvoParamSort;
    [Token(Token = "0x400D16A")]
    [FieldOffset(Offset = "0x3F")]
    private bool mIsSetParamSort;
    [Token(Token = "0x400D16B")]
    [FieldOffset(Offset = "0x40")]
    private IEnumerator mToggleFadeAnimation;
    [Token(Token = "0x400D16C")]
    [FieldOffset(Offset = "0x0")]
    private static RuneSortWindow mInstance;

    [Token(Token = "0x17001A1E")]
    public static RuneSortWindow Instance
    {
      [Token(Token = "0x600C413"), Address(RVA = "0x8C6330", Offset = "0x8C5130", VA = "0x108C6330")] get
      {
        return (RuneSortWindow) null;
      }
    }

    [Token(Token = "0x17001A1F")]
    public SortUtility.SortRunePrefs CurrentSortPrefs
    {
      [Token(Token = "0x600C414"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (SortUtility.SortRunePrefs) null;
      }
    }

    [Token(Token = "0x600C415")]
    [Address(RVA = "0x8C4CC0", Offset = "0x8C3AC0", VA = "0x108C4CC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C416")]
    [Address(RVA = "0x8C4EE0", Offset = "0x8C3CE0", VA = "0x108C4EE0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C417")]
    [Address(RVA = "0x8C5570", Offset = "0x8C4370", VA = "0x108C5570")]
    private void Start()
    {
    }

    [Token(Token = "0x600C418")]
    [Address(RVA = "0x8C5570", Offset = "0x8C4370", VA = "0x108C5570")]
    private void Init()
    {
    }

    [Token(Token = "0x600C419")]
    [Address(RVA = "0x8C5350", Offset = "0x8C4150", VA = "0x108C5350")]
    private void Init_Tab()
    {
    }

    [Token(Token = "0x600C41A")]
    [Address(RVA = "0x8C4F20", Offset = "0x8C3D20", VA = "0x108C4F20")]
    private void Init_Category()
    {
    }

    [Token(Token = "0x600C41B")]
    [Address(RVA = "0x8C5130", Offset = "0x8C3F30", VA = "0x108C5130")]
    private void Init_Order()
    {
    }

    [Token(Token = "0x600C41C")]
    [Address(RVA = "0x8C5A70", Offset = "0x8C4870", VA = "0x108C5A70")]
    private void SelectTab(string tab_name)
    {
    }

    [Token(Token = "0x600C41D")]
    [Address(RVA = "0x8C5F50", Offset = "0x8C4D50", VA = "0x108C5F50")]
    public void UpdateTabState()
    {
    }

    [Token(Token = "0x600C41E")]
    [Address(RVA = "0x8C55B0", Offset = "0x8C43B0", VA = "0x108C55B0")]
    private bool IsExistActiveSortInTab(string tab) => new bool();

    [Token(Token = "0x600C41F")]
    [Address(RVA = "0x8C5B70", Offset = "0x8C4970", VA = "0x108C5B70")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x600C420")]
    [Address(RVA = "0x8C5AF0", Offset = "0x8C48F0", VA = "0x108C5AF0")]
    private void StartSwitchVisibleAnimation(List<CanvasGroup> list_on, List<CanvasGroup> list_off)
    {
    }

    [Token(Token = "0x600C421")]
    [Address(RVA = "0x8C5B30", Offset = "0x8C4930", VA = "0x108C5B30")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x600C422")]
    [Address(RVA = "0x8C56C0", Offset = "0x8C44C0", VA = "0x108C56C0")]
    private bool SavePrefs() => new bool();

    [Token(Token = "0x600C423")]
    [Address(RVA = "0x8C6270", Offset = "0x8C5070", VA = "0x108C6270")]
    public RuneSortWindow()
    {
    }
  }
}
