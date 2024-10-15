// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidPrevFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A60")]
  public sealed class JSON_GuildRaidPrevFormatter : 
    IMessagePackFormatter<JSON_GuildRaidPrev>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001950")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001951")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600286E")]
    [Address(RVA = "0xEC8D80", Offset = "0xEC7B80", VA = "0x10EC8D80")]
    public JSON_GuildRaidPrevFormatter()
    {
    }

    [Token(Token = "0x600286F")]
    [Address(RVA = "0xEC8C80", Offset = "0xEC7A80", VA = "0x10EC8C80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidPrev value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002870")]
    [Address(RVA = "0xEC89A0", Offset = "0xEC77A0", VA = "0x10EC89A0", Slot = "5")]
    public JSON_GuildRaidPrev Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidPrev) null;
    }
  }
}
