// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTrophyStarMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001882")]
  [FlowNode.NodeType("Trophy/StarMission/Req/Get", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTrophyStarMission : FlowNode_Network
  {
    [Token(Token = "0x40057EC")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40057ED")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60062C3")]
    [Address(RVA = "0x310850", Offset = "0x30F650", VA = "0x10310850", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062C4")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60062C5")]
    [Address(RVA = "0x310910", Offset = "0x30F710", VA = "0x10310910", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60062C6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTrophyStarMission()
    {
    }

    [Token(Token = "0x2001883")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40057EE")]
      [FieldOffset(Offset = "0x28")]
      public ReqTrophyStarMission.Response body;

      [Token(Token = "0x60062C7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
