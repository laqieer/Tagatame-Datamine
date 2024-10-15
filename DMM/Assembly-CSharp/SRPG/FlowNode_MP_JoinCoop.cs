// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_JoinCoop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017B8")]
  [FlowNode.NodeType("MultiPlay/Photon/MultiPlayJoinRoomCoop", 13618982)]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "Create or Join LINE", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Join Coop", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Create Coop", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_JoinCoop : FlowNode_MP_JoinRoom_base
  {
    [Token(Token = "0x4005575")]
    private const int PIN_IN_CREATE_COOP = 1;
    [Token(Token = "0x4005576")]
    private const int PIN_IN_JOIN_COOP = 2;
    [Token(Token = "0x4005577")]
    private const int PIN_IN_CREATE_OR_JOIN_LINE = 3;
    [Token(Token = "0x4005578")]
    [FieldOffset(Offset = "0x1C")]
    private bool isLine;

    [Token(Token = "0x600602A")]
    [Address(RVA = "0x134CFD0", Offset = "0x134BDD0", VA = "0x1134CFD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600602B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_JoinCoop()
    {
    }

    [Token(Token = "0x20017B9")]
    private class State_CreateCoop : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x600602C")]
      [Address(RVA = "0x1353D00", Offset = "0x1352B00", VA = "0x11353D00", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x600602D")]
      [Address(RVA = "0x1353F40", Offset = "0x1352D40", VA = "0x11353F40", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x600602E")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_CreateCoop()
      {
      }
    }

    [Token(Token = "0x20017BA")]
    private class State_JoinCoop : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x600602F")]
      [Address(RVA = "0x1355340", Offset = "0x1354140", VA = "0x11355340", Slot = "4")]
      public override void Begin(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006030")]
      [Address(RVA = "0x1355580", Offset = "0x1354380", VA = "0x11355580", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006031")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_JoinCoop()
      {
      }
    }
  }
}
