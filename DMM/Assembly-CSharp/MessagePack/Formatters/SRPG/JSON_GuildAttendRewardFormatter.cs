// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildAttendRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200068F")]
  public sealed class JSON_GuildAttendRewardFormatter : 
    IMessagePackFormatter<JSON_GuildAttendReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CFB")]
    [Address(RVA = "0xBFC050", Offset = "0xBFAE50", VA = "0x10BFC050")]
    public JSON_GuildAttendRewardFormatter()
    {
    }

    [Token(Token = "0x6001CFC")]
    [Address(RVA = "0xBFBEF0", Offset = "0xBFACF0", VA = "0x10BFBEF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildAttendReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CFD")]
    [Address(RVA = "0xBFBBA0", Offset = "0xBFA9A0", VA = "0x10BFBBA0", Slot = "5")]
    public JSON_GuildAttendReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildAttendReward) null;
    }
  }
}
