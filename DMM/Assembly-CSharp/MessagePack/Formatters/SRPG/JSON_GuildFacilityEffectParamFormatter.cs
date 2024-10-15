// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildFacilityEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000632")]
  public sealed class JSON_GuildFacilityEffectParamFormatter : 
    IMessagePackFormatter<JSON_GuildFacilityEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BE4")]
    [Address(RVA = "0xBD4860", Offset = "0xBD3660", VA = "0x10BD4860")]
    public JSON_GuildFacilityEffectParamFormatter()
    {
    }

    [Token(Token = "0x6001BE5")]
    [Address(RVA = "0xBD4650", Offset = "0xBD3450", VA = "0x10BD4650", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildFacilityEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BE6")]
    [Address(RVA = "0xBD4260", Offset = "0xBD3060", VA = "0x10BD4260", Slot = "5")]
    public JSON_GuildFacilityEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildFacilityEffectParam) null;
    }
  }
}
