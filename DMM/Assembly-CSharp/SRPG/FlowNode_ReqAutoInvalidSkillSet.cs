// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoInvalidSkillSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001742")]
  [FlowNode.NodeType("Ability/Req/AutoInvalidSkillSet", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqAutoInvalidSkillSet : FlowNode_Network
  {
    [Token(Token = "0x40053A7")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053A8")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005E93")]
    [Address(RVA = "0x133A580", Offset = "0x1339380", VA = "0x1133A580", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E94")]
    [Address(RVA = "0x133ABD0", Offset = "0x13399D0", VA = "0x1133ABD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E95")]
    [Address(RVA = "0x133A780", Offset = "0x1339580", VA = "0x1133A780", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E96")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoInvalidSkillSet()
    {
    }

    [Token(Token = "0x2001743")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40053A9")]
      [FieldOffset(Offset = "0x28")]
      public ReqInvalidSkillSet.Response body;

      [Token(Token = "0x6005E97")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
