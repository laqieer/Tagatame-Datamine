// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_MailFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200089A")]
  public sealed class Json_MailFormatter : IMessagePackFormatter<Json_Mail>, IMessagePackFormatter
  {
    [Token(Token = "0x40015C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600231C")]
    [Address(RVA = "0xDA6770", Offset = "0xDA5570", VA = "0x10DA6770")]
    public Json_MailFormatter()
    {
    }

    [Token(Token = "0x600231D")]
    [Address(RVA = "0xDA64A0", Offset = "0xDA52A0", VA = "0x10DA64A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Mail value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600231E")]
    [Address(RVA = "0xDA6050", Offset = "0xDA4E50", VA = "0x10DA6050", Slot = "5")]
    public Json_Mail Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Mail) null;
    }
  }
}
