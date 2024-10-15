// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTowerRecover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015BD")]
  [FlowNode.NodeType("Tower/Req/ReqTowerRecover", 32741)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_ReqTowerRecover : FlowNode_Network
  {
    [Token(Token = "0x4004F1D")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mFlowRoot;
    [Token(Token = "0x4004F1E")]
    [FieldOffset(Offset = "0x24")]
    private int usedCoin;

    [Token(Token = "0x6005974")]
    [Address(RVA = "0x12E0E90", Offset = "0x12DFC90", VA = "0x112E0E90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005975")]
    [Address(RVA = "0x12E1320", Offset = "0x12E0120", VA = "0x112E1320")]
    private void Success()
    {
    }

    [Token(Token = "0x6005976")]
    [Address(RVA = "0x12E1000", Offset = "0x12DFE00", VA = "0x112E1000", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005977")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTowerRecover()
    {
    }

    [Token(Token = "0x20015BE")]
    private class JSON_ReqTowerRecoverResponse
    {
      [Token(Token = "0x4004F1F")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x4004F20")]
      [FieldOffset(Offset = "0xC")]
      public int rtime;
      [Token(Token = "0x4004F21")]
      [FieldOffset(Offset = "0x10")]
      public int rcv_num;
      [Token(Token = "0x4004F22")]
      [FieldOffset(Offset = "0x14")]
      public JSON_ReqTowerResuponse.Json_TowerPlayerUnit[] pdeck;

      [Token(Token = "0x6005979")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ReqTowerRecoverResponse()
      {
      }
    }
  }
}
