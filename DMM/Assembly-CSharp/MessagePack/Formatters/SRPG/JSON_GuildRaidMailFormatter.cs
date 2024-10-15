// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidMailFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000904")]
  public sealed class JSON_GuildRaidMailFormatter : 
    IMessagePackFormatter<JSON_GuildRaidMail>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001698")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001699")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600245A")]
    [Address(RVA = "0xDE3C90", Offset = "0xDE2A90", VA = "0x10DE3C90")]
    public JSON_GuildRaidMailFormatter()
    {
    }

    [Token(Token = "0x600245B")]
    [Address(RVA = "0xDE3AB0", Offset = "0xDE28B0", VA = "0x10DE3AB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidMail value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600245C")]
    [Address(RVA = "0xDE3770", Offset = "0xDE2570", VA = "0x10DE3770", Slot = "5")]
    public JSON_GuildRaidMail Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidMail) null;
    }
  }
}
