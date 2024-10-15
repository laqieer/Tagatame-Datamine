// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ChatChannelMasterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000730")]
  public sealed class Json_ChatChannelMasterParamFormatter : 
    IMessagePackFormatter<Json_ChatChannelMasterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EDE")]
    [Address(RVA = "0xC86900", Offset = "0xC85700", VA = "0x10C86900")]
    public Json_ChatChannelMasterParamFormatter()
    {
    }

    [Token(Token = "0x6001EDF")]
    [Address(RVA = "0xC86760", Offset = "0xC85560", VA = "0x10C86760", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_ChatChannelMasterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EE0")]
    [Address(RVA = "0xC86450", Offset = "0xC85250", VA = "0x10C86450", Slot = "5")]
    public Json_ChatChannelMasterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_ChatChannelMasterParam) null;
    }
  }
}
