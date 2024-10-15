// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_AbilityUpFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000718")]
  public sealed class Json_AbilityUpFormatter : 
    IMessagePackFormatter<Json_AbilityUp>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E96")]
    [Address(RVA = "0xC5D0D0", Offset = "0xC5BED0", VA = "0x10C5D0D0")]
    public Json_AbilityUpFormatter()
    {
    }

    [Token(Token = "0x6001E97")]
    [Address(RVA = "0xC5CFD0", Offset = "0xC5BDD0", VA = "0x10C5CFD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_AbilityUp value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E98")]
    [Address(RVA = "0xC5CCD0", Offset = "0xC5BAD0", VA = "0x10C5CCD0", Slot = "5")]
    public Json_AbilityUp Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_AbilityUp) null;
    }
  }
}
