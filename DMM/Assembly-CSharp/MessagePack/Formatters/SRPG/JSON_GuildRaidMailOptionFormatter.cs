// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidMailOptionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000903")]
  public sealed class JSON_GuildRaidMailOptionFormatter : 
    IMessagePackFormatter<JSON_GuildRaidMailOption>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001696")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001697")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002457")]
    [Address(RVA = "0xDE4AE0", Offset = "0xDE38E0", VA = "0x10DE4AE0")]
    public JSON_GuildRaidMailOptionFormatter()
    {
    }

    [Token(Token = "0x6002458")]
    [Address(RVA = "0xDE4A20", Offset = "0xDE3820", VA = "0x10DE4A20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidMailOption value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002459")]
    [Address(RVA = "0xDE4780", Offset = "0xDE3580", VA = "0x10DE4780", Slot = "5")]
    public JSON_GuildRaidMailOption Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidMailOption) null;
    }
  }
}
