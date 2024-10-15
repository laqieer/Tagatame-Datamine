// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReplaceFilterWindow
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
  [Token(Token = "0x200228B")]
  [AddComponentMenu("UI/SortFilter/CrystalReplaceFilterWindow")]
  [FlowNode.Pin(10, "Save完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(3, "キャンセル", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "全選択解除", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(11, "キャンセル完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(0, "Save", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "全選択", FlowNode.PinTypes.Input, 1)]
  public class CrystalReplaceFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009960")]
    private const int PIN_INPUT_SAVE = 0;
    [Token(Token = "0x4009961")]
    private const int PIN_INPUT_ALL_SELECT = 1;
    [Token(Token = "0x4009962")]
    private const int PIN_INPUT_ALL_CLEAR_SELECT = 2;
    [Token(Token = "0x4009963")]
    private const int PIN_INPUT_CANCEL = 3;
    [Token(Token = "0x4009964")]
    private const int PIN_OUTPUT_SAVE_END = 10;
    [Token(Token = "0x4009965")]
    private const int PIN_OUTPUT_CANCEL_END = 11;
    [Token(Token = "0x4009966")]
    private const string SVB_KEY_CATEGORY_FAVORITE = "SVB_KEY_CATEGORY_FAVORITE";
    [Token(Token = "0x4009967")]
    private const string SVB_KEY_CATEGORY_RANK = "SVB_KEY_CATEGORY_RANK";
    [Token(Token = "0x4009968")]
    private const string SVB_KEY_CATEGORY_STATUS = "SVB_KEY_CATEGORY_STATUS";
    [Token(Token = "0x4009969")]
    private const string SVB_KEY_CATEGORY_OVERWRITEPARTY = "SVB_KEY_CATEGORY_OVERWRITEPARTY";
    [Token(Token = "0x400996A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mTabParent;
    [Token(Token = "0x400996B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mContentParent;
    [Token(Token = "0x400996C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CrystalFilterTab mTabTemplate;
    [Token(Token = "0x400996D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x400996E")]
    [FieldOffset(Offset = "0x1C")]
    private FilterCrystalReplacePrefs mCurrentFilterPrefs;
    [Token(Token = "0x400996F")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, CrystalFilterTab> mTabs;
    [Token(Token = "0x4009970")]
    [FieldOffset(Offset = "0x24")]
    private List<CrystalReplaceFilterCategory> mCategoryObjects;
    [Token(Token = "0x4009971")]
    [FieldOffset(Offset = "0x28")]
    private string mCurrentTabName;
    [Token(Token = "0x4009972")]
    [FieldOffset(Offset = "0x2C")]
    private IEnumerator mToggleFadeAnimation;

    [Token(Token = "0x170014C8")]
    public FilterCrystalReplacePrefs CurrentFilterPrefs
    {
      [Token(Token = "0x60093CF"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (FilterCrystalReplacePrefs) null;
      }
    }

    [Token(Token = "0x60093D0")]
    [Address(RVA = "0x56CBB0", Offset = "0x56B9B0", VA = "0x1056CBB0")]
    private void Start()
    {
    }

    [Token(Token = "0x60093D1")]
    [Address(RVA = "0x56C1D0", Offset = "0x56AFD0", VA = "0x1056C1D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60093D2")]
    [Address(RVA = "0x56CEC0", Offset = "0x56BCC0", VA = "0x1056CEC0")]
    public void OnSelectTab(CrystalReplaceFilterParam filter_param)
    {
    }

    [Token(Token = "0x60093D3")]
    [Address(RVA = "0x56CBB0", Offset = "0x56B9B0", VA = "0x1056CBB0")]
    private void Init()
    {
    }

    [Token(Token = "0x60093D4")]
    [Address(RVA = "0x56C830", Offset = "0x56B630", VA = "0x1056C830")]
    private void Init_Tab()
    {
    }

    [Token(Token = "0x60093D5")]
    [Address(RVA = "0x56C260", Offset = "0x56B060", VA = "0x1056C260")]
    private void Init_Category()
    {
    }

    [Token(Token = "0x60093D6")]
    [Address(RVA = "0x56D240", Offset = "0x56C040", VA = "0x1056D240")]
    private void SelectTab(string tab_name)
    {
    }

    [Token(Token = "0x60093D7")]
    [Address(RVA = "0x56D740", Offset = "0x56C540", VA = "0x1056D740")]
    public void UpdateTabState()
    {
    }

    [Token(Token = "0x60093D8")]
    [Address(RVA = "0x56CBE0", Offset = "0x56B9E0", VA = "0x1056CBE0")]
    private bool IsExistActiveFilterInTab(string tab) => new bool();

    [Token(Token = "0x60093D9")]
    [Address(RVA = "0x56D360", Offset = "0x56C160", VA = "0x1056D360")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x60093DA")]
    [Address(RVA = "0x56D2E0", Offset = "0x56C0E0", VA = "0x1056D2E0")]
    private void StartSwitchVisibleAnimation(List<CanvasGroup> list_on, List<CanvasGroup> list_off)
    {
    }

    [Token(Token = "0x60093DB")]
    [Address(RVA = "0x56D320", Offset = "0x56C120", VA = "0x1056D320")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x60093DC")]
    [Address(RVA = "0x56CFF0", Offset = "0x56BDF0", VA = "0x1056CFF0")]
    private bool SavePrefs() => new bool();

    [Token(Token = "0x60093DD")]
    [Address(RVA = "0x56CD00", Offset = "0x56BB00", VA = "0x1056CD00")]
    private void OnSelectAll(bool is_on)
    {
    }

    [Token(Token = "0x60093DE")]
    [Address(RVA = "0x56DA00", Offset = "0x56C800", VA = "0x1056DA00")]
    public CrystalReplaceFilterWindow()
    {
    }
  }
}
