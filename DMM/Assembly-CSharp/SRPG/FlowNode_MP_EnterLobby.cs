// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_EnterLobby
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017B3")]
  [FlowNode.Pin(20, "Failure", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(0, "EnterLobby", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/Photon/MultiPlayEnterLobby", 13618982)]
  public class FlowNode_MP_EnterLobby : FlowNode
  {
    [Token(Token = "0x4005569")]
    private const int PIN_IN_ENTER_LOBBY = 0;
    [Token(Token = "0x400556A")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x400556B")]
    private const int PIN_OUT_FAILURE = 20;
    [Token(Token = "0x400556C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool IsAutoJoin;
    [Token(Token = "0x400556D")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private bool IsWaitRefreshRoom;
    [Token(Token = "0x400556E")]
    [FieldOffset(Offset = "0x1C")]
    private StateMachine<FlowNode_MP_EnterLobby> stateMachine;

    [Token(Token = "0x6006019")]
    [Address(RVA = "0x134B630", Offset = "0x134A430", VA = "0x1134B630", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x600601A")]
    [Address(RVA = "0x134B6E0", Offset = "0x134A4E0", VA = "0x1134B6E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600601B")]
    [Address(RVA = "0x134B840", Offset = "0x134A640", VA = "0x1134B840")]
    private void Update()
    {
    }

    [Token(Token = "0x600601C")]
    [Address(RVA = "0x134B800", Offset = "0x134A600", VA = "0x1134B800")]
    private void Success()
    {
    }

    [Token(Token = "0x600601D")]
    [Address(RVA = "0x134B5D0", Offset = "0x134A3D0", VA = "0x1134B5D0")]
    private void Failure()
    {
    }

    [Token(Token = "0x600601E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_EnterLobby()
    {
    }

    [Token(Token = "0x20017B4")]
    private class State_ConnectLobby : State<FlowNode_MP_EnterLobby>
    {
      [Token(Token = "0x600601F")]
      [Address(RVA = "0x1353A90", Offset = "0x1352890", VA = "0x11353A90", Slot = "4")]
      public override void Begin(FlowNode_MP_EnterLobby self)
      {
      }

      [Token(Token = "0x6006020")]
      [Address(RVA = "0x1353C10", Offset = "0x1352A10", VA = "0x11353C10", Slot = "5")]
      public override void Update(FlowNode_MP_EnterLobby self)
      {
      }

      [Token(Token = "0x6006021")]
      [Address(RVA = "0x1353B50", Offset = "0x1352950", VA = "0x11353B50")]
      private bool StartConnect() => new bool();

      [Token(Token = "0x6006022")]
      [Address(RVA = "0x1353CC0", Offset = "0x1352AC0", VA = "0x11353CC0")]
      public State_ConnectLobby()
      {
      }
    }

    [Token(Token = "0x20017B5")]
    private class State_WaitRoomRefresh : State<FlowNode_MP_EnterLobby>
    {
      [Token(Token = "0x6006023")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(FlowNode_MP_EnterLobby self)
      {
      }

      [Token(Token = "0x6006024")]
      [Address(RVA = "0x13583F0", Offset = "0x13571F0", VA = "0x113583F0", Slot = "5")]
      public override void Update(FlowNode_MP_EnterLobby self)
      {
      }

      [Token(Token = "0x6006025")]
      [Address(RVA = "0x1358480", Offset = "0x1357280", VA = "0x11358480")]
      public State_WaitRoomRefresh()
      {
      }
    }
  }
}
