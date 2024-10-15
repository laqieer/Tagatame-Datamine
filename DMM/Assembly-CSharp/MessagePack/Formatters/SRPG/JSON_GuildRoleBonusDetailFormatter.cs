// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRoleBonusDetailFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000691")]
  public sealed class JSON_GuildRoleBonusDetailFormatter : 
    IMessagePackFormatter<JSON_GuildRoleBonusDetail>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D01")]
    [Address(RVA = "0xBFCD20", Offset = "0xBFBB20", VA = "0x10BFCD20")]
    public JSON_GuildRoleBonusDetailFormatter()
    {
    }

    [Token(Token = "0x6001D02")]
    [Address(RVA = "0xBFCBF0", Offset = "0xBFB9F0", VA = "0x10BFCBF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRoleBonusDetail value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D03")]
    [Address(RVA = "0xBFC8E0", Offset = "0xBFB6E0", VA = "0x10BFC8E0", Slot = "5")]
    public JSON_GuildRoleBonusDetail Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRoleBonusDetail) null;
    }
  }
}
