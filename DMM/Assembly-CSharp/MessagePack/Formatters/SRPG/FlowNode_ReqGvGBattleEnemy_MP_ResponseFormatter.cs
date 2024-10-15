// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGBattleEnemy_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B10")]
  public sealed class FlowNode_ReqGvGBattleEnemy_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGBattleEnemy.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AB0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AB1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A7E")]
    [Address(RVA = "0xF35160", Offset = "0xF33F60", VA = "0x10F35160")]
    public FlowNode_ReqGvGBattleEnemy_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A7F")]
    [Address(RVA = "0xF34E70", Offset = "0xF33C70", VA = "0x10F34E70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGBattleEnemy.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A80")]
    [Address(RVA = "0xF34A40", Offset = "0xF33840", VA = "0x10F34A40", Slot = "5")]
    public FlowNode_ReqGvGBattleEnemy.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGBattleEnemy.MP_Response) null;
    }
  }
}
