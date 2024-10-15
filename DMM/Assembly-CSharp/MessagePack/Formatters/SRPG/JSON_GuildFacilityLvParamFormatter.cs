// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildFacilityLvParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000634")]
  public sealed class JSON_GuildFacilityLvParamFormatter : 
    IMessagePackFormatter<JSON_GuildFacilityLvParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001100")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001101")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BEA")]
    [Address(RVA = "0xBD5000", Offset = "0xBD3E00", VA = "0x10BD5000")]
    public JSON_GuildFacilityLvParamFormatter()
    {
    }

    [Token(Token = "0x6001BEB")]
    [Address(RVA = "0xBD4ED0", Offset = "0xBD3CD0", VA = "0x10BD4ED0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildFacilityLvParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BEC")]
    [Address(RVA = "0xBD4B90", Offset = "0xBD3990", VA = "0x10BD4B90", Slot = "5")]
    public JSON_GuildFacilityLvParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildFacilityLvParam) null;
    }
  }
}
