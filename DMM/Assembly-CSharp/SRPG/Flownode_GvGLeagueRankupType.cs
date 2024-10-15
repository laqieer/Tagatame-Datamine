// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GvGLeagueRankupType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016F5")]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/GvGLeagueRankupType", 32741)]
  [FlowNode.Pin(103, "No Change", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Change", FlowNode.PinTypes.Output, 101)]
  public class Flownode_GvGLeagueRankupType : FlowNode
  {
    [Token(Token = "0x40052E4")]
    private const int PIN_INPUT_START = 1;
    [Token(Token = "0x40052E5")]
    private const int PIN_OUTPUT_CHANGE = 101;
    [Token(Token = "0x40052E6")]
    private const int PIN_OUTPUT_NOCHANGE = 103;

    [Token(Token = "0x6005DA6")]
    [Address(RVA = "0x132E390", Offset = "0x132D190", VA = "0x1132E390", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DA7")]
    [Address(RVA = "0x132E2E0", Offset = "0x132D0E0", VA = "0x1132E2E0")]
    private bool IsFirstTimeEffect() => new bool();

    [Token(Token = "0x6005DA8")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GvGLeagueRankupType()
    {
    }
  }
}
