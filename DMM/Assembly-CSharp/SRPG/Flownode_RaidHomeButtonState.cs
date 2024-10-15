// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_RaidHomeButtonState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200181C")]
  [FlowNode.Pin(103, "Reward", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Challenge", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Raid/RaidHomeButtonState", 32741)]
  [FlowNode.Pin(102, "Close", FlowNode.PinTypes.Output, 102)]
  public class Flownode_RaidHomeButtonState : FlowNode
  {
    [Token(Token = "0x40056AE")]
    private const int PIN_IN_CHECK = 1;
    [Token(Token = "0x40056AF")]
    private const int PIN_OUT_CHALLENGE = 101;
    [Token(Token = "0x40056B0")]
    private const int PIN_OUT_CLOSE = 102;
    [Token(Token = "0x40056B1")]
    private const int PIN_OUT_REWARD = 103;

    [Token(Token = "0x6006155")]
    [Address(RVA = "0x136E0C0", Offset = "0x136CEC0", VA = "0x1136E0C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006156")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_RaidHomeButtonState()
    {
    }
  }
}
