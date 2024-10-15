// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideParameterWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A34")]
  [FlowNode.Pin(1, "ウィンドウを閉じる", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(10, "遷移OK", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "遷移前のチェック", FlowNode.PinTypes.Input, 2)]
  public class RunePrideParameterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CCF4")]
    private const int OUTPUT_CLOSE_WINDOW = 1;
    [Token(Token = "0x400CCF5")]
    private const int INPUT_CLOSE_CONFIRM = 2;
    [Token(Token = "0x400CCF6")]
    private const int OUTPUT_CLOSE_SUCCESS = 10;
    [Token(Token = "0x400CCF7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RunePrideParameterListView ViewObj;
    [Token(Token = "0x400CCF8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400CCF9")]
    [FieldOffset(Offset = "0x14")]
    private UnitData SelectUnit;

    [Token(Token = "0x600C059")]
    [Address(RVA = "0x88B710", Offset = "0x88A510", VA = "0x1088B710", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C05A")]
    [Address(RVA = "0x88B850", Offset = "0x88A650", VA = "0x1088B850")]
    public void SetUp(UnitData _unit_data)
    {
    }

    [Token(Token = "0x600C05B")]
    [Address(RVA = "0x4FC150", Offset = "0x4FAF50", VA = "0x104FC150")]
    public void CloseSelf()
    {
    }

    [Token(Token = "0x600C05C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePrideParameterWindow()
    {
    }
  }
}
