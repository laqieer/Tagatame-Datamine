// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GachaOptionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B3")]
  public sealed class Json_GachaOptionFormatter : 
    IMessagePackFormatter<Json_GachaOption>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002667")]
    [Address(RVA = "0xE3B8A0", Offset = "0xE3A6A0", VA = "0x10E3B8A0")]
    public Json_GachaOptionFormatter()
    {
    }

    [Token(Token = "0x6002668")]
    [Address(RVA = "0xE3B770", Offset = "0xE3A570", VA = "0x10E3B770", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GachaOption value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002669")]
    [Address(RVA = "0xE3B450", Offset = "0xE3A250", VA = "0x10E3B450", Slot = "5")]
    public Json_GachaOption Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GachaOption) null;
    }
  }
}
