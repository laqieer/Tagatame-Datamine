// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_JoinRankMatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017BB")]
  [FlowNode.Pin(2, "Join Rank Match", FlowNode.PinTypes.Input, 2)]
  [FlowNode.NodeType("MultiPlay/Photon/MultiPlayJoinRoomRankMatch", 13618982)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Create Rank Match", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_JoinRankMatch : FlowNode_MP_JoinRoom_base
  {
    [Token(Token = "0x4005579")]
    private const int PIN_IN_CREATE_RANK_MATCH = 1;
    [Token(Token = "0x400557A")]
    private const int PIN_IN_JOIN_RANK_MATCH = 2;
    [Token(Token = "0x400557B")]
    private const byte RANKMATCH_PLAYER_MAX = 2;
    [Token(Token = "0x400557C")]
    private const int RANKMATCH_LEVEL_RANGE = -1;

    [Token(Token = "0x6006032")]
    [Address(RVA = "0x134D180", Offset = "0x134BF80", VA = "0x1134D180", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006033")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_JoinRankMatch()
    {
    }

    [Token(Token = "0x20017BC")]
    private class State_CreateRankMatch : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x6006034")]
      [Address(RVA = "0x1354190", Offset = "0x1352F90", VA = "0x11354190", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006035")]
      [Address(RVA = "0x13543C0", Offset = "0x13531C0", VA = "0x113543C0", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006036")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_CreateRankMatch()
      {
      }
    }

    [Token(Token = "0x20017BD")]
    private class State_JoinRankMatch : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x6006037")]
      [Address(RVA = "0x1355CE0", Offset = "0x1354AE0", VA = "0x11355CE0", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006038")]
      [Address(RVA = "0x1355E80", Offset = "0x1354C80", VA = "0x11355E80", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006039")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_JoinRankMatch()
      {
      }
    }
  }
}
