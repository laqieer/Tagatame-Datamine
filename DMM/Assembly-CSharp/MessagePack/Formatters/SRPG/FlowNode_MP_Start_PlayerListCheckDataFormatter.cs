// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_MP_Start_PlayerListCheckDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F4")]
  public sealed class FlowNode_MP_Start_PlayerListCheckDataFormatter : 
    IMessagePackFormatter<FlowNode_MP_Start.PlayerListCheckData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001478")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001479")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600212A")]
    [Address(RVA = "0xD29E20", Offset = "0xD28C20", VA = "0x10D29E20")]
    public FlowNode_MP_Start_PlayerListCheckDataFormatter()
    {
    }

    [Token(Token = "0x600212B")]
    [Address(RVA = "0xD29C40", Offset = "0xD28A40", VA = "0x10D29C40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_MP_Start.PlayerListCheckData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600212C")]
    [Address(RVA = "0xD298F0", Offset = "0xD286F0", VA = "0x10D298F0", Slot = "5")]
    public FlowNode_MP_Start.PlayerListCheckData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_MP_Start.PlayerListCheckData) null;
    }
  }
}
