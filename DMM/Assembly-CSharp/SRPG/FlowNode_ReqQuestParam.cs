// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200156E")]
  [FlowNode.NodeType("System/Master/ReqQuestParam", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_ReqQuestParam : FlowNode_Network
  {
    [Token(Token = "0x6005887")]
    [Address(RVA = "0x12D7C70", Offset = "0x12D6A70", VA = "0x112D7C70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005888")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005889")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x600588A")]
    [Address(RVA = "0x12D7E30", Offset = "0x12D6C30", VA = "0x112D7E30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600588B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQuestParam()
    {
    }

    [Token(Token = "0x200156F")]
    [MessagePackObject(true)]
    public class MP_QuestParam : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004E06")]
      [FieldOffset(Offset = "0x28")]
      public Json_QuestList body;

      [Token(Token = "0x600588C")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_QuestParam()
      {
      }
    }
  }
}
