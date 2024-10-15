// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGNodeDefenseEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001715")]
  [FlowNode.NodeType("GvG/Req/GvGNodeDefenseEntry", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGvGNodeDefenseEntry : FlowNode_Network
  {
    [Token(Token = "0x4005333")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005334")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005335")]
    [FieldOffset(Offset = "0x20")]
    public bool isForce;

    [Token(Token = "0x6005E0E")]
    [Address(RVA = "0x1326820", Offset = "0x1325620", VA = "0x11326820", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E0F")]
    [Address(RVA = "0x1327300", Offset = "0x1326100", VA = "0x11327300")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E10")]
    [Address(RVA = "0x1326B20", Offset = "0x1325920", VA = "0x11326B20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E11")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGNodeDefenseEntry()
    {
    }

    [Token(Token = "0x2001716")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005336")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGNodeDefenseEntry.Response body;

      [Token(Token = "0x6005E12")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
