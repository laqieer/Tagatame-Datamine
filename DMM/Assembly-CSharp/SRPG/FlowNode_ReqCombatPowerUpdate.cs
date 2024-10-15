// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCombatPowerUpdate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001320")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("CombatPower/Req/Update", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqCombatPowerUpdate : FlowNode_Network
  {
    [Token(Token = "0x40046FA")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40046FB")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60050A2")]
    [Address(RVA = "0x1259BF0", Offset = "0x12589F0", VA = "0x11259BF0")]
    private IEnumerator BeforeDestroyRequest() => (IEnumerator) null;

    [Token(Token = "0x60050A3")]
    [Address(RVA = "0x1259C40", Offset = "0x1258A40", VA = "0x11259C40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60050A4")]
    [Address(RVA = "0x125A480", Offset = "0x1259280", VA = "0x1125A480")]
    private void Success()
    {
    }

    [Token(Token = "0x60050A5")]
    [Address(RVA = "0x125A0C0", Offset = "0x1258EC0", VA = "0x1125A0C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050A6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCombatPowerUpdate()
    {
    }

    [Token(Token = "0x2001321")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40046FC")]
      [FieldOffset(Offset = "0x28")]
      public ReqCombatPowerUpdate.Response body;

      [Token(Token = "0x60050A7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
