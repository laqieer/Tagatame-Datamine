// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C7")]
  public sealed class JSON_ResonanceCondParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001226")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001227")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DA3")]
    [Address(RVA = "0xC17FD0", Offset = "0xC16DD0", VA = "0x10C17FD0")]
    public JSON_ResonanceCondParamFormatter()
    {
    }

    [Token(Token = "0x6001DA4")]
    [Address(RVA = "0xC17D90", Offset = "0xC16B90", VA = "0x10C17D90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DA5")]
    [Address(RVA = "0xC17A10", Offset = "0xC16810", VA = "0x10C17A10", Slot = "5")]
    public JSON_ResonanceCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceCondParam) null;
    }
  }
}
