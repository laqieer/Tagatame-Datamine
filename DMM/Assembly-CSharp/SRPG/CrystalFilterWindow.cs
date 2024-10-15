// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalFilterWindow
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
  [Token(Token = "0x2002ADE")]
  [FlowNode.Pin(3, "キャンセル", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(0, "Save", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "全選択解除", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "全選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Save完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "キャンセル完了", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("UI/SortFilter/CrystalFilterWindow")]
  public class CrystalFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D111")]
    private const int PIN_INPUT_SAVE = 0;
    [Token(Token = "0x400D112")]
    private const int PIN_INPUT_ALL_SELECT = 1;
    [Token(Token = "0x400D113")]
    private const int PIN_INPUT_ALL_CLEAR_SELECT = 2;
    [Token(Token = "0x400D114")]
    private const int PIN_INPUT_CANCEL = 3;
    [Token(Token = "0x400D115")]
    private const int PIN_OUTPUT_SAVE_END = 10;
    [Token(Token = "0x400D116")]
    private const int PIN_OUTPUT_CANCEL_END = 11;
    [Token(Token = "0x400D117")]
    private const string SVB_KEY_CATEGORY_FAVORITE = "SVB_KEY_CATEGORY_FAVORITE";
    [Token(Token = "0x400D118")]
    private const string SVB_KEY_CATEGORY_RANK = "SVB_KEY_CATEGORY_RANK";
    [Token(Token = "0x400D119")]
    private const string SVB_KEY_CATEGORY_STATUS = "SVB_KEY_CATEGORY_STATUS";
    [Token(Token = "0x400D11A")]
    private const string SVB_KEY_CATEGORY_OVERWRITEPARTY = "SVB_KEY_CATEGORY_OVERWRITEPARTY";
    [Token(Token = "0x400D11B")]
    [FieldOffset(Offset = "0xC")]
    private FilterCrystalPrefs mCurrentFilterPrefs;
    [Token(Token = "0x400D11C")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, CrystalFilterTab> mTabs;
    [Token(Token = "0x400D11D")]
    [FieldOffset(Offset = "0x14")]
    private List<CrystalFilterCategory> mCategoryObjects;
    [Token(Token = "0x400D11E")]
    [FieldOffset(Offset = "0x18")]
    private string mCurrentTabName;
    [Token(Token = "0x400D11F")]
    [FieldOffset(Offset = "0x1C")]
    private IEnumerator mToggleFadeAnimation;
    [Token(Token = "0x400D120")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mTabParent;
    [Token(Token = "0x400D121")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform mContentParent;
    [Token(Token = "0x400D122")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CrystalFilterTab mTabTemplate;
    [Token(Token = "0x400D123")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x400D124")]
    [FieldOffset(Offset = "0x0")]
    private static CrystalFilterWindow mInstance;

    [Token(Token = "0x17001A13")]
    public static CrystalFilterWindow Instance
    {
      [Token(Token = "0x600C3C9"), Address(RVA = "0x8C1700", Offset = "0x8C0500", VA = "0x108C1700")] get
      {
        return (CrystalFilterWindow) null;
      }
    }

    [Token(Token = "0x17001A14")]
    public FilterCrystalPrefs CurrentFilterPrefs
    {
      [Token(Token = "0x600C3CA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (FilterCrystalPrefs) null;
      }
    }

    [Token(Token = "0x600C3CB")]
    [Address(RVA = "0x8BFC90", Offset = "0x8BEA90", VA = "0x108BFC90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C3CC")]
    [Address(RVA = "0x8BFD20", Offset = "0x8BEB20", VA = "0x108BFD20")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C3CD")]
    [Address(RVA = "0x8C07F0", Offset = "0x8BF5F0", VA = "0x108C07F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C3CE")]
    [Address(RVA = "0x8C06A0", Offset = "0x8BF4A0", VA = "0x108C06A0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C3CF")]
    [Address(RVA = "0x8C0AA0", Offset = "0x8BF8A0", VA = "0x108C0AA0")]
    public void OnSelectTab(CrystalFilterParam filter_param)
    {
    }

    [Token(Token = "0x600C3D0")]
    [Address(RVA = "0x8C06A0", Offset = "0x8BF4A0", VA = "0x108C06A0")]
    private void Init()
    {
    }

    [Token(Token = "0x600C3D1")]
    [Address(RVA = "0x8C0320", Offset = "0x8BF120", VA = "0x108C0320")]
    private void Init_Tab()
    {
    }

    [Token(Token = "0x600C3D2")]
    [Address(RVA = "0x8BFD60", Offset = "0x8BEB60", VA = "0x108BFD60")]
    private void Init_Category()
    {
    }

    [Token(Token = "0x600C3D3")]
    [Address(RVA = "0x8C0DE0", Offset = "0x8BFBE0", VA = "0x108C0DE0")]
    private void SelectTab(string tab_name)
    {
    }

    [Token(Token = "0x600C3D4")]
    [Address(RVA = "0x8C1340", Offset = "0x8C0140", VA = "0x108C1340")]
    public void UpdateTabState()
    {
    }

    [Token(Token = "0x600C3D5")]
    [Address(RVA = "0x8C06D0", Offset = "0x8BF4D0", VA = "0x108C06D0")]
    private bool IsExistActiveFilterInTab(string tab) => new bool();

    [Token(Token = "0x600C3D6")]
    [Address(RVA = "0x8C0F60", Offset = "0x8BFD60", VA = "0x108C0F60")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x600C3D7")]
    [Address(RVA = "0x8C0EE0", Offset = "0x8BFCE0", VA = "0x108C0EE0")]
    private void StartSwitchVisibleAnimation(List<CanvasGroup> list_on, List<CanvasGroup> list_off)
    {
    }

    [Token(Token = "0x600C3D8")]
    [Address(RVA = "0x8C0F20", Offset = "0x8BFD20", VA = "0x108C0F20")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x600C3D9")]
    [Address(RVA = "0x8C0B90", Offset = "0x8BF990", VA = "0x108C0B90")]
    private bool SavePrefs() => new bool();

    [Token(Token = "0x600C3DA")]
    [Address(RVA = "0x8C0830", Offset = "0x8BF630", VA = "0x108C0830")]
    private void OnSelectAll(bool is_on)
    {
    }

    [Token(Token = "0x600C3DB")]
    [Address(RVA = "0x8C1650", Offset = "0x8C0450", VA = "0x108C1650")]
    public CrystalFilterWindow()
    {
    }
  }
}
