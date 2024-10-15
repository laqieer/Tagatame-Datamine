// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoInvalidSkillGet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001740")]
  [FlowNode.NodeType("Ability/Req/AutoInvalidSkillGet", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "ForceRequest", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_ReqAutoInvalidSkillGet : FlowNode_Network
  {
    [Token(Token = "0x40053A0")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053A1")]
    private const int PIN_IN_REQUEST_FORCE = 2;
    [Token(Token = "0x40053A2")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40053A3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool isResume;
    [Token(Token = "0x40053A4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private EInvalidSkillApplyType apply_type;
    [Token(Token = "0x40053A5")]
    [FieldOffset(Offset = "0x28")]
    private EInvalidSkillApplyType mSelectType;

    [Token(Token = "0x6005E8E")]
    [Address(RVA = "0x1339FE0", Offset = "0x1338DE0", VA = "0x11339FE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E8F")]
    [Address(RVA = "0x133A510", Offset = "0x1339310", VA = "0x1133A510")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E90")]
    [Address(RVA = "0x133A180", Offset = "0x1338F80", VA = "0x1133A180", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E91")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoInvalidSkillGet()
    {
    }

    [Token(Token = "0x2001741")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40053A6")]
      [FieldOffset(Offset = "0x28")]
      public ReqInvalidSkillGet.Response body;

      [Token(Token = "0x6005E92")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
