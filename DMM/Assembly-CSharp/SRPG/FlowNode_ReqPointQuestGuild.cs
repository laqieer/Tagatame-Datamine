// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPointQuestGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001803")]
  [FlowNode.NodeType("PointQuest/Req/PointQuestGuild", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqPointQuestGuild : FlowNode_Network
  {
    [Token(Token = "0x4005679")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400567A")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x600611A")]
    [Address(RVA = "0x135DFC0", Offset = "0x135CDC0", VA = "0x1135DFC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600611B")]
    [Address(RVA = "0x135E560", Offset = "0x135D360", VA = "0x1135E560")]
    private void Success()
    {
    }

    [Token(Token = "0x600611C")]
    [Address(RVA = "0x135E1B0", Offset = "0x135CFB0", VA = "0x1135E1B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600611D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPointQuestGuild()
    {
    }

    [Token(Token = "0x2001804")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400567B")]
      [FieldOffset(Offset = "0x28")]
      public ReqPointQuestGuild.Response body;

      [Token(Token = "0x600611E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
