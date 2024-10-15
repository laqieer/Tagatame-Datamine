// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceFilterWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029C6")]
  [FlowNode.Pin(31, "全選択解除", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(141, "キャンセル完了", FlowNode.PinTypes.Output, 141)]
  [FlowNode.Pin(111, "Save完了", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(101, "初期化完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(51, "タブ切替", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(41, "キャンセル", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(21, "全選択", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(11, "Save", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class RuneReplaceFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CA9E")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400CA9F")]
    public const int PIN_INPUT_SAVE = 11;
    [Token(Token = "0x400CAA0")]
    public const int PIN_INPUT_ALL_SELECT = 21;
    [Token(Token = "0x400CAA1")]
    public const int PIN_INPUT_ALL_CLEAR_SELECT = 31;
    [Token(Token = "0x400CAA2")]
    public const int PIN_INPUT_CANCEL = 41;
    [Token(Token = "0x400CAA3")]
    public const int PIN_INPUT_TAB_CHANGE = 51;
    [Token(Token = "0x400CAA4")]
    public const int PIN_OUTPUT_INIT = 101;
    [Token(Token = "0x400CAA5")]
    public const int PIN_OUTPUT_SAVE_END = 111;
    [Token(Token = "0x400CAA6")]
    public const int PIN_OUTPUT_CANCEL_END = 141;
    [Token(Token = "0x400CAA7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400CAA8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mTabParent;
    [Token(Token = "0x400CAA9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneReplaceFilterTab mTabTemplate;
    [Token(Token = "0x400CAAA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneReplaceFilterCategory mRarityCategory;
    [Token(Token = "0x400CAAB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneReplaceFilterCategory mSetEffCategory;
    [Token(Token = "0x400CAAC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RuneReplaceFilterCategory mActivateSetEffCategory;
    [Token(Token = "0x400CAAD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RuneReplaceFilterCategory mEvoStatusCategory;
    [Token(Token = "0x400CAAE")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<string, RuneReplaceFilterTab> mTabDic;
    [Token(Token = "0x400CAAF")]
    [FieldOffset(Offset = "0x2C")]
    private Dictionary<string, RuneReplaceFilterCategory> mCategoryDic;
    [Token(Token = "0x400CAB0")]
    [FieldOffset(Offset = "0x30")]
    private RuneReplaceFilterWindowModel mModel;
    [Token(Token = "0x400CAB1")]
    [FieldOffset(Offset = "0x34")]
    private IEnumerator mToggleFadeAnimation;

    [Token(Token = "0x600BE19")]
    [Address(RVA = "0x859C70", Offset = "0x858A70", VA = "0x10859C70")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BE1A")]
    [Address(RVA = "0x859720", Offset = "0x858520", VA = "0x10859720")]
    public void InitializeTab()
    {
    }

    [Token(Token = "0x600BE1B")]
    [Address(RVA = "0x859670", Offset = "0x858470", VA = "0x10859670")]
    private void InitializeCategory()
    {
    }

    [Token(Token = "0x600BE1C")]
    [Address(RVA = "0x8592F0", Offset = "0x8580F0", VA = "0x108592F0")]
    private void Category(RuneReplaceFilterCategory category, eRuneFilterTypes type)
    {
    }

    [Token(Token = "0x600BE1D")]
    [Address(RVA = "0x859DE0", Offset = "0x858BE0", VA = "0x10859DE0")]
    public void RefreshTab()
    {
    }

    [Token(Token = "0x600BE1E")]
    [Address(RVA = "0x858F90", Offset = "0x857D90", VA = "0x10858F90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BE1F")]
    [Address(RVA = "0x85A2C0", Offset = "0x8590C0", VA = "0x1085A2C0")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BE20")]
    [Address(RVA = "0x8593D0", Offset = "0x8581D0", VA = "0x108593D0")]
    private void ChangeAll(bool isOn)
    {
    }

    [Token(Token = "0x600BE21")]
    [Address(RVA = "0x85A1B0", Offset = "0x858FB0", VA = "0x1085A1B0")]
    private void SaveFilter()
    {
    }

    [Token(Token = "0x600BE22")]
    [Address(RVA = "0x85A1D0", Offset = "0x858FD0", VA = "0x1085A1D0")]
    private void SetCurrentTabName(SerializeValueList args)
    {
    }

    [Token(Token = "0x600BE23")]
    [Address(RVA = "0x85A340", Offset = "0x859140", VA = "0x1085A340")]
    public void StartSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x600BE24")]
    [Address(RVA = "0x85A630", Offset = "0x859430", VA = "0x1085A630")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x600BE25")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneReplaceFilterWindow()
    {
    }
  }
}
