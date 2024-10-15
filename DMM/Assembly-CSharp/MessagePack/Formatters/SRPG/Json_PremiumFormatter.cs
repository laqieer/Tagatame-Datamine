// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_PremiumFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200071C")]
  public sealed class Json_PremiumFormatter : 
    IMessagePackFormatter<Json_Premium>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EA2")]
    [Address(RVA = "0xC64E60", Offset = "0xC63C60", VA = "0x10C64E60")]
    public Json_PremiumFormatter()
    {
    }

    [Token(Token = "0x6001EA3")]
    [Address(RVA = "0xC64D30", Offset = "0xC63B30", VA = "0x10C64D30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Premium value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EA4")]
    [Address(RVA = "0xC649F0", Offset = "0xC637F0", VA = "0x10C649F0", Slot = "5")]
    public Json_Premium Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Premium) null;
    }
  }
}
