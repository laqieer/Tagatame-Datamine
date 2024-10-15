// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidMailListItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000902")]
  public sealed class JSON_GuildRaidMailListItemFormatter : 
    IMessagePackFormatter<JSON_GuildRaidMailListItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001694")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001695")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002454")]
    [Address(RVA = "0xDE4450", Offset = "0xDE3250", VA = "0x10DE4450")]
    public JSON_GuildRaidMailListItemFormatter()
    {
    }

    [Token(Token = "0x6002455")]
    [Address(RVA = "0xDE4220", Offset = "0xDE3020", VA = "0x10DE4220", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidMailListItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002456")]
    [Address(RVA = "0xDE3E10", Offset = "0xDE2C10", VA = "0x10DE3E10", Slot = "5")]
    public JSON_GuildRaidMailListItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidMailListItem) null;
    }
  }
}
