// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildAttendRewardDetailFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200068D")]
  public sealed class JSON_GuildAttendRewardDetailFormatter : 
    IMessagePackFormatter<JSON_GuildAttendRewardDetail>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CF5")]
    [Address(RVA = "0xBFBA20", Offset = "0xBFA820", VA = "0x10BFBA20")]
    public JSON_GuildAttendRewardDetailFormatter()
    {
    }

    [Token(Token = "0x6001CF6")]
    [Address(RVA = "0xBFB8F0", Offset = "0xBFA6F0", VA = "0x10BFB8F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildAttendRewardDetail value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CF7")]
    [Address(RVA = "0xBFB5E0", Offset = "0xBFA3E0", VA = "0x10BFB5E0", Slot = "5")]
    public JSON_GuildAttendRewardDetail Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildAttendRewardDetail) null;
    }
  }
}
