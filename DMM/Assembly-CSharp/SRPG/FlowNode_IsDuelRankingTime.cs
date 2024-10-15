// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsDuelRankingTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200134D")]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "true", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "false", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("Duel/FlowNode_IsDuelRankingTime", 16755200)]
  public class FlowNode_IsDuelRankingTime : FlowNode
  {
    [Token(Token = "0x4004771")]
    public const int PIN_INPUT = 0;
    [Token(Token = "0x4004772")]
    public const int PIN_TRUE = 10;
    [Token(Token = "0x4004773")]
    public const int PIN_FALSE = 11;

    [Token(Token = "0x6005122")]
    [Address(RVA = "0x124F710", Offset = "0x124E510", VA = "0x1124F710", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005123")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsDuelRankingTime()
    {
    }
  }
}
