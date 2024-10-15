// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GachaPickupsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000883")]
  public sealed class Json_GachaPickupsFormatter : 
    IMessagePackFormatter<Json_GachaPickups>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001596")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001597")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022D7")]
    [Address(RVA = "0xDA4130", Offset = "0xDA2F30", VA = "0x10DA4130")]
    public Json_GachaPickupsFormatter()
    {
    }

    [Token(Token = "0x60022D8")]
    [Address(RVA = "0xDA3F70", Offset = "0xDA2D70", VA = "0x10DA3F70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GachaPickups value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022D9")]
    [Address(RVA = "0xDA3BE0", Offset = "0xDA29E0", VA = "0x10DA3BE0", Slot = "5")]
    public Json_GachaPickups Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GachaPickups) null;
    }
  }
}
