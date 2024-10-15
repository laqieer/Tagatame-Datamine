// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRoleBonusRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000694")]
  public sealed class JSON_GuildRoleBonusRewardParamFormatter : 
    IMessagePackFormatter<JSON_GuildRoleBonusRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D0A")]
    [Address(RVA = "0xBFDD40", Offset = "0xBFCB40", VA = "0x10BFDD40")]
    public JSON_GuildRoleBonusRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001D0B")]
    [Address(RVA = "0xBFDB60", Offset = "0xBFC960", VA = "0x10BFDB60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRoleBonusRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D0C")]
    [Address(RVA = "0xBFD820", Offset = "0xBFC620", VA = "0x10BFD820", Slot = "5")]
    public JSON_GuildRoleBonusRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRoleBonusRewardParam) null;
    }
  }
}
