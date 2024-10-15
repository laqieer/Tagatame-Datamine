// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_StatusAwakeDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A4E")]
  public sealed class Json_StatusAwakeDataFormatter : 
    IMessagePackFormatter<Json_StatusAwakeData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400192C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400192D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002838")]
    [Address(RVA = "0xEB3DB0", Offset = "0xEB2BB0", VA = "0x10EB3DB0")]
    public Json_StatusAwakeDataFormatter()
    {
    }

    [Token(Token = "0x6002839")]
    [Address(RVA = "0xEB3C80", Offset = "0xEB2A80", VA = "0x10EB3C80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_StatusAwakeData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600283A")]
    [Address(RVA = "0xEB3970", Offset = "0xEB2770", VA = "0x10EB3970", Slot = "5")]
    public Json_StatusAwakeData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_StatusAwakeData) null;
    }
  }
}
