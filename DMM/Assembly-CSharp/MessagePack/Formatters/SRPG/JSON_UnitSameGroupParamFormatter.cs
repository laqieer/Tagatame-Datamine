// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitSameGroupParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200068B")]
  public sealed class JSON_UnitSameGroupParamFormatter : 
    IMessagePackFormatter<JSON_UnitSameGroupParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CEF")]
    [Address(RVA = "0xC0C0A0", Offset = "0xC0AEA0", VA = "0x10C0C0A0")]
    public JSON_UnitSameGroupParamFormatter()
    {
    }

    [Token(Token = "0x6001CF0")]
    [Address(RVA = "0xC0BF40", Offset = "0xC0AD40", VA = "0x10C0BF40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitSameGroupParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CF1")]
    [Address(RVA = "0xC0BBF0", Offset = "0xC0A9F0", VA = "0x10C0BBF0", Slot = "5")]
    public JSON_UnitSameGroupParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitSameGroupParam) null;
    }
  }
}
