// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_VersusAudienceWaitStarted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001773")]
  [FlowNode.Pin(10, "Finish", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "ForceFinish", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Multi/Versus/AudienceWaitStarted", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(20, "Failed", FlowNode.PinTypes.Output, 20)]
  public class FlowNode_VersusAudienceWaitStarted : FlowNode
  {
    [Token(Token = "0x4005431")]
    private const int PIN_IN_START = 0;
    [Token(Token = "0x4005432")]
    private const int PIN_IN_FORCE_FINISH = 1;
    [Token(Token = "0x4005433")]
    private const int PIN_OUT_FINISH = 10;
    [Token(Token = "0x4005434")]
    private const int PIN_OUT_FAILED = 20;
    [Token(Token = "0x4005435")]
    private const float TIME_MAX_SEC = 5f;
    [Token(Token = "0x4005436")]
    [FieldOffset(Offset = "0x18")]
    private float mTimer;

    [Token(Token = "0x6005F1B")]
    [Address(RVA = "0x1344EB0", Offset = "0x1343CB0", VA = "0x11344EB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F1C")]
    [Address(RVA = "0x1344F10", Offset = "0x1343D10", VA = "0x11344F10")]
    private void Update()
    {
    }

    [Token(Token = "0x6005F1D")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Finished()
    {
    }

    [Token(Token = "0x6005F1E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_VersusAudienceWaitStarted()
    {
    }
  }
}
