// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildBoardRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016AA")]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("Guild/GuildBoardRead", 32741)]
  public class FlowNode_ReqGuildBoardRead : FlowNode_Network
  {
    [Token(Token = "0x400524F")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x4005250")]
    private const int PIN_OUTPUT_SUCCESS = 100;

    [Token(Token = "0x6005CD8")]
    [Address(RVA = "0x130B9A0", Offset = "0x130A7A0", VA = "0x1130B9A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CD9")]
    [Address(RVA = "0x130BA70", Offset = "0x130A870", VA = "0x1130BA70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CDA")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildBoardRead()
    {
    }
  }
}
