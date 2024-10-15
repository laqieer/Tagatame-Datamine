// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqDuelEnemy_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000846")]
  public sealed class FlowNode_ReqDuelEnemy_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqDuelEnemy.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400151C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400151D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002220")]
    [Address(RVA = "0xD6A710", Offset = "0xD69510", VA = "0x10D6A710")]
    public FlowNode_ReqDuelEnemy_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002221")]
    [Address(RVA = "0xD6A420", Offset = "0xD69220", VA = "0x10D6A420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqDuelEnemy.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002222")]
    [Address(RVA = "0xD69FF0", Offset = "0xD68DF0", VA = "0x10D69FF0", Slot = "5")]
    public FlowNode_ReqDuelEnemy.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqDuelEnemy.MP_Response) null;
    }
  }
}
