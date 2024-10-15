// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_JoinRoom_base
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017BE")]
  [FlowNode.Pin(8000, "Success", FlowNode.PinTypes.Output, 8000)]
  [FlowNode.Pin(9002, "Failure", FlowNode.PinTypes.Output, 9002)]
  [FlowNode.Pin(9003, "Failure in Lobby", FlowNode.PinTypes.Output, 9003)]
  [FlowNode.Pin(9004, "Illegal Quest", FlowNode.PinTypes.Output, 9004)]
  [FlowNode.Pin(9005, "Failure Full Member", FlowNode.PinTypes.Output, 9005)]
  [FlowNode.Pin(9006, "Failure Battle Ver", FlowNode.PinTypes.Output, 9006)]
  public abstract class FlowNode_MP_JoinRoom_base : FlowNode
  {
    [Token(Token = "0x400557D")]
    private const int PIN_OUT_SUCCESS = 8000;
    [Token(Token = "0x400557E")]
    private const int PIN_OUT_FAILURE = 9002;
    [Token(Token = "0x400557F")]
    private const int PIN_OUT_FAILURE_IN_LOBBY = 9003;
    [Token(Token = "0x4005580")]
    private const int PIN_OUT_ILLEGAL_QUEST = 9004;
    [Token(Token = "0x4005581")]
    private const int PIN_OUT_FAILURE_FULL_MEMBER = 9005;
    [Token(Token = "0x4005582")]
    private const int PIN_OUT_FAILURE_BATTLE_VERSION = 9006;
    [Token(Token = "0x4005583")]
    [FieldOffset(Offset = "0x18")]
    protected StateMachine<FlowNode_MP_JoinRoom_base> stateMachine;

    [Token(Token = "0x600603A")]
    [Address(RVA = "0x134D260", Offset = "0x134C060", VA = "0x1134D260")]
    private void Update()
    {
    }

    [Token(Token = "0x600603B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    protected FlowNode_MP_JoinRoom_base()
    {
    }

    [Token(Token = "0x20017BF")]
    protected abstract class State_base : State<FlowNode_MP_JoinRoom_base>
    {
      [Token(Token = "0x600603C")]
      protected void GotoState<T>() where T : FlowNode_MP_JoinRoom_base.State_base, new()
      {
      }

      [Token(Token = "0x600603D")]
      [Address(RVA = "0x1358A40", Offset = "0x1357840", VA = "0x11358A40")]
      protected void Success()
      {
      }

      [Token(Token = "0x600603E")]
      [Address(RVA = "0x13588F0", Offset = "0x13576F0", VA = "0x113588F0")]
      protected void Failure()
      {
      }

      [Token(Token = "0x600603F")]
      [Address(RVA = "0x1358810", Offset = "0x1357610", VA = "0x11358810")]
      protected void FailureJoin(string stateName)
      {
      }

      [Token(Token = "0x6006040")]
      [Address(RVA = "0x13589A0", Offset = "0x13577A0", VA = "0x113589A0")]
      protected void IllegalQuest(string stateName)
      {
      }

      [Token(Token = "0x6006041")]
      [Address(RVA = "0x1358770", Offset = "0x1357570", VA = "0x11358770")]
      protected void FailureFullMember(string stateName)
      {
      }

      [Token(Token = "0x6006042")]
      [Address(RVA = "0x13586B0", Offset = "0x13574B0", VA = "0x113586B0")]
      private void FailureBattleVersion(string stateName)
      {
      }

      [Token(Token = "0x6006043")]
      [Address(RVA = "0x13584C0", Offset = "0x13572C0", VA = "0x113584C0")]
      private bool BattleversionFind() => new bool();

      [Token(Token = "0x6006044")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      protected State_base()
      {
      }
    }

    [Token(Token = "0x20017C0")]
    protected class State_DecideSeat : FlowNode_MP_JoinRoom_base.State_base
    {
      [Token(Token = "0x6006045")]
      [Address(RVA = "0x1354EB0", Offset = "0x1353CB0", VA = "0x11354EB0", Slot = "5")]
      public override void Update(FlowNode_MP_JoinRoom_base self)
      {
      }

      [Token(Token = "0x6006046")]
      [Address(RVA = "0x1354150", Offset = "0x1352F50", VA = "0x11354150")]
      public State_DecideSeat()
      {
      }
    }
  }
}
