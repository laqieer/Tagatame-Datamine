// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSetBonusFilterWindow
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
  [Token(Token = "0x20022E2")]
  [FlowNode.Pin(201, "データエラー", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(10, "フィルター実行", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(3, "選択全解除", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "全選択", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "フィルター実行", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class CrystalSetBonusFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009B57")]
    private const string SVB_KEY_CATEGORY_STATUS = "SVB_KEY_CATEGORY_STATUS";
    [Token(Token = "0x4009B58")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009B59")]
    private const int PIN_INPUT_SELECT_ALL = 2;
    [Token(Token = "0x4009B5A")]
    private const int PIN_INPUT_SELECT_CLEAR = 3;
    [Token(Token = "0x4009B5B")]
    private const int PIN_INPUT_EXECUTE_FILTER = 10;
    [Token(Token = "0x4009B5C")]
    private const int PIN_OUTPUT_FILTER_SET = 101;
    [Token(Token = "0x4009B5D")]
    private const int PIN_OUTPUT_ERROR = 201;
    [Token(Token = "0x4009B5E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mTabParent;
    [Token(Token = "0x4009B5F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalSetBonusFilterTab mTabTemplate;
    [Token(Token = "0x4009B60")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mParent;
    [Token(Token = "0x4009B61")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x4009B62")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle mAllSetBonusCheck;
    [Token(Token = "0x4009B63")]
    [FieldOffset(Offset = "0x0")]
    private static CrystalSetBonusFilterWindow mInstance;
    [Token(Token = "0x4009B64")]
    [FieldOffset(Offset = "0x20")]
    private IEnumerator mToggleFadeAnimation;
    [Token(Token = "0x4009B65")]
    [FieldOffset(Offset = "0x24")]
    private Dictionary<string, CrystalSetBonusFilterTab> mTabs;
    [Token(Token = "0x4009B66")]
    [FieldOffset(Offset = "0x28")]
    private List<CrystalSetBonusFilterCategry> mCategoryObjects;
    [Token(Token = "0x4009B67")]
    [FieldOffset(Offset = "0x2C")]
    private string mCurrentTabName;

    [Token(Token = "0x170014EE")]
    public static CrystalSetBonusFilterWindow Instance
    {
      [Token(Token = "0x60095CE"), Address(RVA = "0x58A9A0", Offset = "0x5897A0", VA = "0x1058A9A0")] get
      {
        return (CrystalSetBonusFilterWindow) null;
      }
    }

    [Token(Token = "0x60095CF")]
    [Address(RVA = "0x588B60", Offset = "0x587960", VA = "0x10588B60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60095D0")]
    [Address(RVA = "0x588BD0", Offset = "0x5879D0", VA = "0x10588BD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60095D1")]
    [Address(RVA = "0x589DB0", Offset = "0x588BB0", VA = "0x10589DB0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60095D2")]
    [Address(RVA = "0x58A6F0", Offset = "0x5894F0", VA = "0x1058A6F0")]
    public void UpdateTabState()
    {
    }

    [Token(Token = "0x60095D3")]
    [Address(RVA = "0x589DF0", Offset = "0x588BF0", VA = "0x10589DF0")]
    public void OnSelectTab(CrystalSetBonusFilterParam filter_param)
    {
    }

    [Token(Token = "0x60095D4")]
    [Address(RVA = "0x5899A0", Offset = "0x5887A0", VA = "0x105899A0")]
    private void Init()
    {
    }

    [Token(Token = "0x60095D5")]
    [Address(RVA = "0x589620", Offset = "0x588420", VA = "0x10589620")]
    private void Init_Tab()
    {
    }

    [Token(Token = "0x60095D6")]
    [Address(RVA = "0x589080", Offset = "0x587E80", VA = "0x10589080")]
    private void Init_Category()
    {
    }

    [Token(Token = "0x60095D7")]
    [Address(RVA = "0x589F20", Offset = "0x588D20", VA = "0x10589F20")]
    private void SelectTab(string tab_name)
    {
    }

    [Token(Token = "0x60095D8")]
    [Address(RVA = "0x589BA0", Offset = "0x5889A0", VA = "0x10589BA0")]
    private bool IsExistActiveFilterInTab(string tab) => new bool();

    [Token(Token = "0x60095D9")]
    [Address(RVA = "0x58A310", Offset = "0x589110", VA = "0x1058A310")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x60095DA")]
    [Address(RVA = "0x58A290", Offset = "0x589090", VA = "0x1058A290")]
    private void StartSwitchVisibleAnimation(List<CanvasGroup> list_on, List<CanvasGroup> list_off)
    {
    }

    [Token(Token = "0x60095DB")]
    [Address(RVA = "0x58A2D0", Offset = "0x5890D0", VA = "0x1058A2D0")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x60095DC")]
    [Address(RVA = "0x58A020", Offset = "0x588E20", VA = "0x1058A020")]
    private void SetAllToggle(bool is_on)
    {
    }

    [Token(Token = "0x60095DD")]
    [Address(RVA = "0x588C10", Offset = "0x587A10", VA = "0x10588C10")]
    private void ExecuteSetBonusFilter()
    {
    }

    [Token(Token = "0x60095DE")]
    [Address(RVA = "0x58A8F0", Offset = "0x5896F0", VA = "0x1058A8F0")]
    public CrystalSetBonusFilterWindow()
    {
    }
  }
}
