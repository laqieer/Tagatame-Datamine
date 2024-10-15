// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GvGSchedule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016F7")]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "GvG Close", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "GvG Open", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("GvG/GvGOpen", 32741)]
  [FlowNode.Pin(1, "Start Check", FlowNode.PinTypes.Input, 1)]
  public class Flownode_GvGSchedule : FlowNode
  {
    [Token(Token = "0x40052EA")]
    private const int PIN_INPUT_CHECK = 1;
    [Token(Token = "0x40052EB")]
    private const int PIN_OUTPUT_OPEN = 101;
    [Token(Token = "0x40052EC")]
    private const int PIN_OUTPUT_CLOSE = 102;

    [Token(Token = "0x6005DAB")]
    [Address(RVA = "0x132E680", Offset = "0x132D480", VA = "0x1132E680", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DAC")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GvGSchedule()
    {
    }
  }
}
