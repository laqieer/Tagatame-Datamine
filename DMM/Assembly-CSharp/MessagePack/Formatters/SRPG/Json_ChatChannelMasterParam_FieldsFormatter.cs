// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ChatChannelMasterParam_FieldsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200072F")]
  public sealed class Json_ChatChannelMasterParam_FieldsFormatter : 
    IMessagePackFormatter<Json_ChatChannelMasterParam.Fields>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EDB")]
    [Address(RVA = "0xC87000", Offset = "0xC85E00", VA = "0x10C87000")]
    public Json_ChatChannelMasterParam_FieldsFormatter()
    {
    }

    [Token(Token = "0x6001EDC")]
    [Address(RVA = "0xC86DD0", Offset = "0xC85BD0", VA = "0x10C86DD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_ChatChannelMasterParam.Fields value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EDD")]
    [Address(RVA = "0xC86A80", Offset = "0xC85880", VA = "0x10C86A80", Slot = "5")]
    public Json_ChatChannelMasterParam.Fields Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_ChatChannelMasterParam.Fields) null;
    }
  }
}
