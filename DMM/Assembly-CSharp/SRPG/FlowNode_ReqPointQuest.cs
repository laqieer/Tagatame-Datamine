// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPointQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001801")]
  [FlowNode.Pin(102, "Nothing", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("PointQuest/Req/PointQuest", 32741)]
  public class FlowNode_ReqPointQuest : FlowNode_Network
  {
    [Token(Token = "0x4005675")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005676")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005677")]
    private const int PIN_OUT_NOTHING = 102;

    [Token(Token = "0x6006115")]
    [Address(RVA = "0x135F630", Offset = "0x135E430", VA = "0x1135F630", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006116")]
    [Address(RVA = "0x135FBB0", Offset = "0x135E9B0", VA = "0x1135FBB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006117")]
    [Address(RVA = "0x135F7E0", Offset = "0x135E5E0", VA = "0x1135F7E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006118")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPointQuest()
    {
    }

    [Token(Token = "0x2001802")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005678")]
      [FieldOffset(Offset = "0x28")]
      public ReqPointQuest.Response body;

      [Token(Token = "0x6006119")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
