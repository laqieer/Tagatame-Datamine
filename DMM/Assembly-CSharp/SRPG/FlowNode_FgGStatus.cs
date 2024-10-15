// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_FgGStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013EB")]
  [FlowNode.Pin(1, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "未連携", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(4, "連携済み", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("FgGID/FgGStatus", 32741)]
  [FlowNode.Pin(2, "非表示", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_FgGStatus : FlowNode
  {
    [Token(Token = "0x40049D2")]
    private const int PIN_ID_INPUT = 1;
    [Token(Token = "0x40049D3")]
    private const int PIN_ID_DISABLE = 2;
    [Token(Token = "0x40049D4")]
    private const int PIN_ID_NOT_SYNCHRONIZED = 3;
    [Token(Token = "0x40049D5")]
    private const int PIN_ID_SYNCHRONIZED = 4;

    [Token(Token = "0x6005368")]
    [Address(RVA = "0x1280330", Offset = "0x127F130", VA = "0x11280330", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005369")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_FgGStatus()
    {
    }
  }
}
