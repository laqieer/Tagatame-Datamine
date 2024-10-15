// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_VipFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200071B")]
  public sealed class Json_VipFormatter : IMessagePackFormatter<Json_Vip>, IMessagePackFormatter
  {
    [Token(Token = "0x40012CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E9F")]
    [Address(RVA = "0xC65F30", Offset = "0xC64D30", VA = "0x10C65F30")]
    public Json_VipFormatter()
    {
    }

    [Token(Token = "0x6001EA0")]
    [Address(RVA = "0xC65E30", Offset = "0xC64C30", VA = "0x10C65E30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Vip value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EA1")]
    [Address(RVA = "0xC65B30", Offset = "0xC64930", VA = "0x10C65B30", Slot = "5")]
    public Json_Vip Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Vip) null;
    }
  }
}
