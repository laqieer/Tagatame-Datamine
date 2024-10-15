// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdvanceRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A7B")]
  public sealed class JSON_AdvanceRewardParamFormatter : 
    IMessagePackFormatter<JSON_AdvanceRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001986")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001987")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028BF")]
    [Address(RVA = "0xED5330", Offset = "0xED4130", VA = "0x10ED5330")]
    public JSON_AdvanceRewardParamFormatter()
    {
    }

    [Token(Token = "0x60028C0")]
    [Address(RVA = "0xED5150", Offset = "0xED3F50", VA = "0x10ED5150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdvanceRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028C1")]
    [Address(RVA = "0xED4E10", Offset = "0xED3C10", VA = "0x10ED4E10", Slot = "5")]
    public JSON_AdvanceRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdvanceRewardParam) null;
    }
  }
}
