// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildFacilityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000633")]
  public sealed class JSON_GuildFacilityParamFormatter : 
    IMessagePackFormatter<JSON_GuildFacilityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BE7")]
    [Address(RVA = "0xBD5BB0", Offset = "0xBD49B0", VA = "0x10BD5BB0")]
    public JSON_GuildFacilityParamFormatter()
    {
    }

    [Token(Token = "0x6001BE8")]
    [Address(RVA = "0xBD5770", Offset = "0xBD4570", VA = "0x10BD5770", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildFacilityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BE9")]
    [Address(RVA = "0xBD51F0", Offset = "0xBD3FF0", VA = "0x10BD51F0", Slot = "5")]
    public JSON_GuildFacilityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildFacilityParam) null;
    }
  }
}
