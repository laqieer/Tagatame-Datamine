// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRoleBonusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000692")]
  public sealed class JSON_GuildRoleBonusFormatter : 
    IMessagePackFormatter<JSON_GuildRoleBonus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D04")]
    [Address(RVA = "0xBFD550", Offset = "0xBFC350", VA = "0x10BFD550")]
    public JSON_GuildRoleBonusFormatter()
    {
    }

    [Token(Token = "0x6001D05")]
    [Address(RVA = "0xBFD2A0", Offset = "0xBFC0A0", VA = "0x10BFD2A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRoleBonus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D06")]
    [Address(RVA = "0xBFCEA0", Offset = "0xBFBCA0", VA = "0x10BFCEA0", Slot = "5")]
    public JSON_GuildRoleBonus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRoleBonus) null;
    }
  }
}
