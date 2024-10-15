// Decompiled with JetBrains decompiler
// Type: SRPG.BondItemSelectWindowConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020C1")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "強化開始ボタンをクリック", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(21, "キャンセルボタンをクリック", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(111, "強化開始ボタンの処理", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(121, "キャンセルボタンの処理", FlowNode.PinTypes.Output, 121)]
  public class BondItemSelectWindowConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008D55")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008D56")]
    private const int PIN_INPUT_OK = 11;
    [Token(Token = "0x4008D57")]
    private const int PIN_INPUT_CANCEL = 21;
    [Token(Token = "0x4008D58")]
    private const int PIN_OUTPUT_OK = 111;
    [Token(Token = "0x4008D59")]
    private const int PIN_OUTPUT_CANCEL = 121;
    [Token(Token = "0x4008D5A")]
    private const string SVB_ITEM_NUM = "item_text";
    [Token(Token = "0x4008D5B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform ItemTempParent;
    [Token(Token = "0x4008D5C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour ItemTemp;
    [Token(Token = "0x4008D5D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button StartButton;
    [Token(Token = "0x4008D5E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button CancelButton;

    [Token(Token = "0x600888A")]
    [Address(RVA = "0x495E70", Offset = "0x494C70", VA = "0x10495E70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600888B")]
    [Address(RVA = "0x495EC0", Offset = "0x494CC0", VA = "0x10495EC0")]
    private void Initialized()
    {
    }

    [Token(Token = "0x600888C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BondItemSelectWindowConfirm()
    {
    }
  }
}
