// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckSocialAuth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001868")]
  [FlowNode.NodeType("Social/CheckSocialAuth", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "True", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "False", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_CheckSocialAuth : FlowNode
  {
    [Token(Token = "0x4005785")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005786")]
    private const int PIN_OUT_TRUE = 100;
    [Token(Token = "0x4005787")]
    private const int PIN_OUT_FALSE = 101;

    [Token(Token = "0x600626E")]
    [Address(RVA = "0x306210", Offset = "0x305010", VA = "0x10306210", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600626F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckSocialAuth()
    {
    }
  }
}
