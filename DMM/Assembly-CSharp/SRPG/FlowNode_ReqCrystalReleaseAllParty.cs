// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalReleaseAllParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001336")]
  [FlowNode.NodeType("Crystal/Req/CrystalReleaseAllParty", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqCrystalReleaseAllParty : FlowNode_Network
  {
    [Token(Token = "0x400472F")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004730")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004731")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x60050E5")]
    [Address(RVA = "0x125CD10", Offset = "0x125BB10", VA = "0x1125CD10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60050E6")]
    [Address(RVA = "0x125D230", Offset = "0x125C030", VA = "0x1125D230")]
    private void Success()
    {
    }

    [Token(Token = "0x60050E7")]
    [Address(RVA = "0x125CF50", Offset = "0x125BD50", VA = "0x1125CF50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050E8")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalReleaseAllParty()
    {
    }

    [Token(Token = "0x2001337")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response_Base : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004732")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalReleaseAllParty.Response body;

      [Token(Token = "0x60050E9")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response_Base()
      {
      }
    }
  }
}
