// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BtlPointMissionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200070A")]
  public sealed class Json_BtlPointMissionFormatter : 
    IMessagePackFormatter<Json_BtlPointMission>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E6C")]
    [Address(RVA = "0xC5DCF0", Offset = "0xC5CAF0", VA = "0x10C5DCF0")]
    public Json_BtlPointMissionFormatter()
    {
    }

    [Token(Token = "0x6001E6D")]
    [Address(RVA = "0xC5DBC0", Offset = "0xC5C9C0", VA = "0x10C5DBC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BtlPointMission value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E6E")]
    [Address(RVA = "0xC5D8B0", Offset = "0xC5C6B0", VA = "0x10C5D8B0", Slot = "5")]
    public Json_BtlPointMission Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BtlPointMission) null;
    }
  }
}
