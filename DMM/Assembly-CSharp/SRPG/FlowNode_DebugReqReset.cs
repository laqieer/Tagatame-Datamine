// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DebugReqReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013B9")]
  [FlowNode.NodeType("Debug/サーバのデータを削除", 32741)]
  [FlowNode.Pin(2, "Success_Online", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Success_Offline", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Error", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Reset", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_DebugReqReset : FlowNode
  {
    [Token(Token = "0x40048F2")]
    [FieldOffset(Offset = "0x18")]
    private StateMachine<FlowNode_DebugReqReset> mStateMachine;

    [Token(Token = "0x6005281")]
    [Address(RVA = "0x1273D90", Offset = "0x1272B90", VA = "0x11273D90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005282")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Success()
    {
    }

    [Token(Token = "0x6005283")]
    [Address(RVA = "0x1273D70", Offset = "0x1272B70", VA = "0x11273D70")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005284")]
    [Address(RVA = "0x1274110", Offset = "0x1272F10", VA = "0x11274110")]
    private void Update()
    {
    }

    [Token(Token = "0x6005285")]
    [Address(RVA = "0x1273F00", Offset = "0x1272D00", VA = "0x11273F00")]
    public void ResDebugDataReset(WWWResult www)
    {
    }

    [Token(Token = "0x6005286")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_DebugReqReset()
    {
    }

    [Token(Token = "0x20013BA")]
    private class State_WaitForConnect : State<FlowNode_DebugReqReset>
    {
      [Token(Token = "0x6005287")]
      [Address(RVA = "0x1277060", Offset = "0x1275E60", VA = "0x11277060", Slot = "5")]
      public override void Update(FlowNode_DebugReqReset self)
      {
      }

      [Token(Token = "0x6005288")]
      [Address(RVA = "0x12770A0", Offset = "0x1275EA0", VA = "0x112770A0")]
      public State_WaitForConnect()
      {
      }
    }
  }
}
