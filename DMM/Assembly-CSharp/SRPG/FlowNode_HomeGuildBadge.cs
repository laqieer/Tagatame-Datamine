// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_HomeGuildBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016A5")]
  [FlowNode.Pin(102, "設定完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.NodeType("Guild/HomeBadge", 32741)]
  [FlowNode.Pin(1, "バッチON", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "バッチOFF", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_HomeGuildBadge : FlowNode
  {
    [Token(Token = "0x400523E")]
    private const int PIN_IN_TRUE = 1;
    [Token(Token = "0x400523F")]
    private const int PIN_IN_FALSE = 2;
    [Token(Token = "0x4005240")]
    private const int PIN_OUT_SUCCESS = 102;

    [Token(Token = "0x6005CC8")]
    [Address(RVA = "0x1308290", Offset = "0x1307090", VA = "0x11308290", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CC9")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_HomeGuildBadge()
    {
    }
  }
}
