// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidAreaParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000620")]
  public sealed class JSON_RaidAreaParamFormatter : 
    IMessagePackFormatter<JSON_RaidAreaParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BAE")]
    [Address(RVA = "0xBBEB70", Offset = "0xBBD970", VA = "0x10BBEB70")]
    public JSON_RaidAreaParamFormatter()
    {
    }

    [Token(Token = "0x6001BAF")]
    [Address(RVA = "0xBBE9A0", Offset = "0xBBD7A0", VA = "0x10BBE9A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidAreaParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BB0")]
    [Address(RVA = "0xBBE5E0", Offset = "0xBBD3E0", VA = "0x10BBE5E0", Slot = "5")]
    public JSON_RaidAreaParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidAreaParam) null;
    }
  }
}
