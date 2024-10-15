// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGBattleEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001703")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGBattleEnemy", 32741)]
  public class FlowNode_ReqGvGBattleEnemy : FlowNode_Network
  {
    [Token(Token = "0x400530B")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400530C")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005DD3")]
    [Address(RVA = "0x13229C0", Offset = "0x13217C0", VA = "0x113229C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DD4")]
    [Address(RVA = "0x1323380", Offset = "0x1322180", VA = "0x11323380")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DD5")]
    [Address(RVA = "0x1322C30", Offset = "0x1321A30", VA = "0x11322C30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DD6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGBattleEnemy()
    {
    }

    [Token(Token = "0x2001704")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400530D")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGBattleEnemy.Response body;

      [Token(Token = "0x6005DD7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
