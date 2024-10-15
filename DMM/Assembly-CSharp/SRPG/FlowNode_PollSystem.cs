// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PollSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001460")]
  [AddComponentMenu("")]
  [FlowNode.Pin(8000, "CriticalSection", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1500, "BlockInterruptUrlSchemeLaunch", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1400, "BlockInterruptPhotonDisconnected", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1300, "BlockInterruptAll", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1280, "BeforeLogin", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1250, "NetworkConnecting", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1100, "DisableInputModule", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(11, "すべてパスするまで待つ", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "どれかに引っかかるまで待つ", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "すべてパスした", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(0, "どれかに引っかかった", FlowNode.PinTypes.Output, 0)]
  [FlowNode.NodeType("Common/PollSystem")]
  [FlowNode.Pin(1200, "FadeVisible", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_PollSystem : FlowNodePersistent
  {
    [Token(Token = "0x4004B59")]
    [FieldOffset(Offset = "0x18")]
    private bool[] mCheckFlag;
    [Token(Token = "0x4004B5A")]
    [FieldOffset(Offset = "0x1C")]
    private bool[] mCheckType;
    [Token(Token = "0x4004B5B")]
    [FieldOffset(Offset = "0x20")]
    private bool mStart;

    [Token(Token = "0x6005538")]
    [Address(RVA = "0x12990E0", Offset = "0x1297EE0", VA = "0x112990E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005539")]
    [Address(RVA = "0x328A10", Offset = "0x327810", VA = "0x10328A10")]
    private void Reset()
    {
    }

    [Token(Token = "0x600553A")]
    [Address(RVA = "0x12990A0", Offset = "0x1297EA0", VA = "0x112990A0")]
    private void AnyOn()
    {
    }

    [Token(Token = "0x600553B")]
    [Address(RVA = "0x1299060", Offset = "0x1297E60", VA = "0x11299060")]
    private void AllPass()
    {
    }

    [Token(Token = "0x600553C")]
    [Address(RVA = "0x1299240", Offset = "0x1298040", VA = "0x11299240")]
    private void Update()
    {
    }

    [Token(Token = "0x600553D")]
    [Address(RVA = "0x12994E0", Offset = "0x12982E0", VA = "0x112994E0")]
    public FlowNode_PollSystem()
    {
    }

    [Token(Token = "0x2001461")]
    private enum EType
    {
      [Token(Token = "0x4004B5D")] DISABLE_INPUT_MODULE,
      [Token(Token = "0x4004B5E")] FADE_VISIBLE,
      [Token(Token = "0x4004B5F")] NETWORK_CONNECTING,
      [Token(Token = "0x4004B60")] BEFORE_LOGIN,
      [Token(Token = "0x4004B61")] INTERRUPT_STOPPER_ALL,
      [Token(Token = "0x4004B62")] INTERRUPT_STOPPER_PHOTON_DISCONNECTED,
      [Token(Token = "0x4004B63")] INTERRUPT_STOPPER_URL_SCHEME_LAUNCH,
      [Token(Token = "0x4004B64")] CRITIAL_SECTION,
      [Token(Token = "0x4004B65")] NUM,
    }

    [Token(Token = "0x2001462")]
    private enum EState
    {
      [Token(Token = "0x4004B67")] NOP,
      [Token(Token = "0x4004B68")] CHECK,
      [Token(Token = "0x4004B69")] PASS,
      [Token(Token = "0x4004B6A")] NUM,
    }
  }
}
