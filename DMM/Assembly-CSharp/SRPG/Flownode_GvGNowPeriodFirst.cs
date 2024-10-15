// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GvGNowPeriodFirst
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016F6")]
  [FlowNode.Pin(1, "IsFirstTime", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Yes", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("GvG/GvGNowPeriodFirst", 32741)]
  [FlowNode.Pin(102, "No", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class Flownode_GvGNowPeriodFirst : FlowNode
  {
    [Token(Token = "0x40052E7")]
    private const int PIN_INPUT_ISFIRST = 1;
    [Token(Token = "0x40052E8")]
    private const int PIN_OUTPUT_FIRST = 101;
    [Token(Token = "0x40052E9")]
    private const int PIN_OUTPUT_NOTFIRST = 102;

    [Token(Token = "0x6005DA9")]
    [Address(RVA = "0x132E580", Offset = "0x132D380", VA = "0x1132E580", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DAA")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GvGNowPeriodFirst()
    {
    }
  }
}
