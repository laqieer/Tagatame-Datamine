// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildAttendRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000690")]
  public sealed class JSON_GuildAttendRewardParamFormatter : 
    IMessagePackFormatter<JSON_GuildAttendRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CFE")]
    [Address(RVA = "0xBFC760", Offset = "0xBFB560", VA = "0x10BFC760")]
    public JSON_GuildAttendRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001CFF")]
    [Address(RVA = "0xBFC580", Offset = "0xBFB380", VA = "0x10BFC580", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildAttendRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D00")]
    [Address(RVA = "0xBFC240", Offset = "0xBFB040", VA = "0x10BFC240", Slot = "5")]
    public JSON_GuildAttendRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildAttendRewardParam) null;
    }
  }
}
