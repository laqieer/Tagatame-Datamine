// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildFacilityDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F3")]
  public sealed class JSON_GuildFacilityDataFormatter : 
    IMessagePackFormatter<JSON_GuildFacilityData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001876")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001877")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002727")]
    [Address(RVA = "0xE848B0", Offset = "0xE836B0", VA = "0x10E848B0")]
    public JSON_GuildFacilityDataFormatter()
    {
    }

    [Token(Token = "0x6002728")]
    [Address(RVA = "0xE846D0", Offset = "0xE834D0", VA = "0x10E846D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildFacilityData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002729")]
    [Address(RVA = "0xE842E0", Offset = "0xE830E0", VA = "0x10E842E0", Slot = "5")]
    public JSON_GuildFacilityData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildFacilityData) null;
    }
  }
}
