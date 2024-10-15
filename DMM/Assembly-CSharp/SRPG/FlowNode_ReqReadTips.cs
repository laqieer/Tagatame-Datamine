// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqReadTips
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001586")]
  [FlowNode.NodeType("System/ReqReadTips", 32741)]
  [FlowNode.Pin(0, "TIPS既読", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "成功", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_ReqReadTips : FlowNode_Network
  {
    [Token(Token = "0x4004E62")]
    private const int PIN_ID_REQUEST = 0;
    [Token(Token = "0x4004E63")]
    private const int PIN_ID_SUCCESS = 10;

    [Token(Token = "0x60058C2")]
    [Address(RVA = "0x12DA500", Offset = "0x12D9300", VA = "0x112DA500", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058C3")]
    [Address(RVA = "0x12DA6B0", Offset = "0x12D94B0", VA = "0x112DA6B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058C4")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqReadTips()
    {
    }
  }
}
