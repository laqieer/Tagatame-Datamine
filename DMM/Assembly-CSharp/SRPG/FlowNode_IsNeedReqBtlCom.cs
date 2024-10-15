// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsNeedReqBtlCom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001810")]
  [FlowNode.NodeType("Quest/IsNeedReqBtlCom", 32741)]
  [FlowNode.Pin(10, "チェック開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "必要", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "不要", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  public class FlowNode_IsNeedReqBtlCom : FlowNode
  {
    [Token(Token = "0x4005692")]
    private const int PIN_INPUT_CHECK = 10;
    [Token(Token = "0x4005693")]
    private const int PIN_OUTPUT_NEED = 100;
    [Token(Token = "0x4005694")]
    private const int PIN_OUTPUT_NOT_NEED = 110;

    [Token(Token = "0x600613A")]
    [Address(RVA = "0x13595A0", Offset = "0x13583A0", VA = "0x113595A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600613B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsNeedReqBtlCom()
    {
    }
  }
}
