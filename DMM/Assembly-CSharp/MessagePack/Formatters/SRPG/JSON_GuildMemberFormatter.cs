// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildMemberFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B3B")]
  public sealed class JSON_GuildMemberFormatter : 
    IMessagePackFormatter<JSON_GuildMember>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B06")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B07")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AFF")]
    [Address(RVA = "0xF660E0", Offset = "0xF64EE0", VA = "0x10F660E0")]
    public JSON_GuildMemberFormatter()
    {
    }

    [Token(Token = "0x6002B00")]
    [Address(RVA = "0xF65BE0", Offset = "0xF649E0", VA = "0x10F65BE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildMember value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002B01")]
    [Address(RVA = "0xF65570", Offset = "0xF64370", VA = "0x10F65570", Slot = "5")]
    public JSON_GuildMember Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildMember) null;
    }
  }
}
