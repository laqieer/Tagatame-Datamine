// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_JoinTower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017C1")]
  [FlowNode.Pin(2, "Join Tower", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(4, "Resume Tower", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "Join Tower Random", FlowNode.PinTypes.Input, 3)]
  [FlowNode.NodeType("MultiPlay/Photon/MultiPlayJoinRoomTower", 13618982)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Create Tower", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_JoinTower : FlowNode_MP_JoinRoom_base
  {
    [Token(Token = "0x4005584")]
    private const int PIN_IN_CREATE_TOWER = 1;
    [Token(Token = "0x4005585")]
    private const int PIN_IN_JOIN_TOWER = 2;
    [Token(Token = "0x4005586")]
    private const int PIN_IN_JOIN_RANDOM_TOWER = 3;
    [Token(Token = "0x4005587")]
    private const int PIN_IN_RESUME_TOWER = 4;

    [Token(Token = "0x6006047")]
    [Address(RVA = "0x134D2A0", Offset = "0x134C0A0", VA = "0x1134D2A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006048")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_JoinTower()
    {
    }

    [Token(Token = "0x20017C2")]
    private class State_CreateTower : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x6006049")]
      [Address(RVA = "0x13545D0", Offset = "0x13533D0", VA = "0x113545D0", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x600604A")]
      [Address(RVA = "0x1354850", Offset = "0x1353650", VA = "0x11354850", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x600604B")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_CreateTower()
      {
      }
    }

    [Token(Token = "0x20017C3")]
    private class State_JoinTower : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x600604C")]
      [Address(RVA = "0x1356110", Offset = "0x1354F10", VA = "0x11356110", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x600604D")]
      [Address(RVA = "0x1356300", Offset = "0x1355100", VA = "0x11356300", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x600604E")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_JoinTower()
      {
      }
    }

    [Token(Token = "0x20017C4")]
    private class State_JoinRandomTower : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x600604F")]
      [Address(RVA = "0x1355810", Offset = "0x1354610", VA = "0x11355810", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006050")]
      [Address(RVA = "0x1355A50", Offset = "0x1354850", VA = "0x11355A50", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006051")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_JoinRandomTower()
      {
      }
    }

    [Token(Token = "0x20017C5")]
    private class State_ResumeTower : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x6006052")]
      [Address(RVA = "0x1356C20", Offset = "0x1355A20", VA = "0x11356C20", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006053")]
      [Address(RVA = "0x1356F00", Offset = "0x1355D00", VA = "0x11356F00", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006054")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_ResumeTower()
      {
      }
    }
  }
}
