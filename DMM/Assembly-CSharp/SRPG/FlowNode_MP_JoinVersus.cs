// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_JoinVersus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017C6")]
  [FlowNode.NodeType("MultiPlay/Photon/MultiPlayJoinRoomVersus", 13618982)]
  [FlowNode.Pin(1, "Create Versus", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Join Versus", FlowNode.PinTypes.Input, 101)]
  [AddComponentMenu("")]
  public class FlowNode_MP_JoinVersus : FlowNode_MP_JoinRoom_base
  {
    [Token(Token = "0x4005588")]
    private const int PIN_IN_CREATE_VERSUS = 1;
    [Token(Token = "0x4005589")]
    private const int PIN_IN_JOIN_VERSUS = 101;
    [Token(Token = "0x400558A")]
    private const byte VERSUS_PLAYER_MAX = 3;

    [Token(Token = "0x6006055")]
    [Address(RVA = "0x134D400", Offset = "0x134C200", VA = "0x1134D400", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006056")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_JoinVersus()
    {
    }

    [Token(Token = "0x20017C7")]
    private class State_CreateVersus : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x6006057")]
      [Address(RVA = "0x1354A60", Offset = "0x1353860", VA = "0x11354A60", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006058")]
      [Address(RVA = "0x1354CA0", Offset = "0x1353AA0", VA = "0x11354CA0", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006059")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_CreateVersus()
      {
      }
    }

    [Token(Token = "0x20017C8")]
    private class State_JoinVersus : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x600605A")]
      [Address(RVA = "0x1356590", Offset = "0x1355390", VA = "0x11356590", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x600605B")]
      [Address(RVA = "0x13566A0", Offset = "0x13554A0", VA = "0x113566A0", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x600605C")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_JoinVersus()
      {
      }
    }
  }
}
