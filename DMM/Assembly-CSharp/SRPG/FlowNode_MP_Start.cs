// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_Start
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200179D")]
  [FlowNode.Pin(102, "Failure", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(3, "ResumeStart", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Closed Room", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Start Host", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/Start", 32741)]
  public class FlowNode_MP_Start : FlowNode
  {
    [Token(Token = "0x400551F")]
    private const int PIN_IN_START_HOST = 1;
    [Token(Token = "0x4005520")]
    private const int PIN_IN_CLOSED_ROOM = 2;
    [Token(Token = "0x4005521")]
    private const int PIN_IN_RESUME_START = 3;
    [Token(Token = "0x4005522")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005523")]
    private const int PIN_OUT_FAILURE = 102;
    [Token(Token = "0x4005524")]
    [FieldOffset(Offset = "0x18")]
    private StateMachine<FlowNode_MP_Start> stateMachine;

    [Token(Token = "0x6005FD4")]
    [Address(RVA = "0x1352E70", Offset = "0x1351C70", VA = "0x11352E70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FD5")]
    [Address(RVA = "0x1353010", Offset = "0x1351E10", VA = "0x11353010")]
    private void Update()
    {
    }

    [Token(Token = "0x6005FD6")]
    [Address(RVA = "0x1352FD0", Offset = "0x1351DD0", VA = "0x11352FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005FD7")]
    [Address(RVA = "0x1352DD0", Offset = "0x1351BD0", VA = "0x11352DD0")]
    private void Failure(bool needCloseRoom = false)
    {
    }

    [Token(Token = "0x6005FD8")]
    [Address(RVA = "0x1352D60", Offset = "0x1351B60", VA = "0x11352D60")]
    private bool Check(int startedPlayerCount) => new bool();

    [Token(Token = "0x6005FD9")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_Start()
    {
    }

    [Token(Token = "0x200179E")]
    private class State_StartHost : State<FlowNode_MP_Start>
    {
      [Token(Token = "0x4005525")]
      [FieldOffset(Offset = "0xC")]
      private int playerCount;

      [Token(Token = "0x6005FDA")]
      [Address(RVA = "0x13537A0", Offset = "0x13525A0", VA = "0x113537A0", Slot = "4")]
      public override void Begin(FlowNode_MP_Start self)
      {
      }

      [Token(Token = "0x6005FDB")]
      [Address(RVA = "0x1358150", Offset = "0x1356F50", VA = "0x11358150", Slot = "5")]
      public override void Update(FlowNode_MP_Start self)
      {
      }

      [Token(Token = "0x6005FDC")]
      [Address(RVA = "0x13583B0", Offset = "0x13571B0", VA = "0x113583B0")]
      public State_StartHost()
      {
      }
    }

    [Token(Token = "0x200179F")]
    private class State_ClosedRoom : State<FlowNode_MP_Start>
    {
      [Token(Token = "0x4005526")]
      [FieldOffset(Offset = "0xC")]
      private int playerCount;

      [Token(Token = "0x6005FDD")]
      [Address(RVA = "0x13537A0", Offset = "0x13525A0", VA = "0x113537A0", Slot = "4")]
      public override void Begin(FlowNode_MP_Start self)
      {
      }

      [Token(Token = "0x6005FDE")]
      [Address(RVA = "0x13537D0", Offset = "0x13525D0", VA = "0x113537D0", Slot = "5")]
      public override void Update(FlowNode_MP_Start self)
      {
      }

      [Token(Token = "0x6005FDF")]
      [Address(RVA = "0x1353A50", Offset = "0x1352850", VA = "0x11353A50")]
      public State_ClosedRoom()
      {
      }
    }

    [Token(Token = "0x20017A0")]
    private class State_ResumeStart : State<FlowNode_MP_Start>
    {
      [Token(Token = "0x6005FE0")]
      [Address(RVA = "0x1356980", Offset = "0x1355780", VA = "0x11356980", Slot = "5")]
      public override void Update(FlowNode_MP_Start self)
      {
      }

      [Token(Token = "0x6005FE1")]
      [Address(RVA = "0x1356BE0", Offset = "0x13559E0", VA = "0x11356BE0")]
      public State_ResumeStart()
      {
      }
    }

    [Token(Token = "0x20017A1")]
    [MessagePackObject(true)]
    public class PlayerListCheckData
    {
      [Token(Token = "0x4005527")]
      [FieldOffset(Offset = "0x8")]
      public int senderPlayerID;
      [Token(Token = "0x4005528")]
      [FieldOffset(Offset = "0xC")]
      public int version;
      [Token(Token = "0x4005529")]
      [FieldOffset(Offset = "0x10")]
      public PhotonPlayerData[] playerList;

      [Token(Token = "0x6005FE2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PlayerListCheckData()
      {
      }
    }

    [Token(Token = "0x20017A2")]
    private class State_StartGame : State<FlowNode_MP_Start>
    {
      [Token(Token = "0x400552A")]
      [FieldOffset(Offset = "0xC")]
      private FlowNode_MP_Start.PlayerListCheckData sendData;
      [Token(Token = "0x400552B")]
      [FieldOffset(Offset = "0x10")]
      private List<FlowNode_MP_Start.PlayerListCheckData> receiveList;

      [Token(Token = "0x6005FE3")]
      [Address(RVA = "0x13575B0", Offset = "0x13563B0", VA = "0x113575B0", Slot = "4")]
      public override void Begin(FlowNode_MP_Start self)
      {
      }

      [Token(Token = "0x6005FE4")]
      [Address(RVA = "0x1357AB0", Offset = "0x13568B0", VA = "0x11357AB0", Slot = "5")]
      public override void Update(FlowNode_MP_Start self)
      {
      }

      [Token(Token = "0x6005FE5")]
      [Address(RVA = "0x13574A0", Offset = "0x13562A0", VA = "0x113574A0")]
      private bool AnalyzeEventData() => new bool();

      [Token(Token = "0x6005FE6")]
      [Address(RVA = "0x13580D0", Offset = "0x1356ED0", VA = "0x113580D0")]
      public State_StartGame()
      {
      }
    }

    [Token(Token = "0x20017A5")]
    private class State_StartGameConfirm : State<FlowNode_MP_Start>
    {
      [Token(Token = "0x6005FEC")]
      [Address(RVA = "0x1357190", Offset = "0x1355F90", VA = "0x11357190", Slot = "5")]
      public override void Update(FlowNode_MP_Start self)
      {
      }

      [Token(Token = "0x6005FED")]
      [Address(RVA = "0x1357460", Offset = "0x1356260", VA = "0x11357460")]
      public State_StartGameConfirm()
      {
      }
    }
  }
}
