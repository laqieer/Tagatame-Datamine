// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A63")]
  public sealed class JSON_GuildRaidDataFormatter : 
    IMessagePackFormatter<JSON_GuildRaidData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001956")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001957")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002877")]
    [Address(RVA = "0xEC6DE0", Offset = "0xEC5BE0", VA = "0x10EC6DE0")]
    public JSON_GuildRaidDataFormatter()
    {
    }

    [Token(Token = "0x6002878")]
    [Address(RVA = "0xEC6980", Offset = "0xEC5780", VA = "0x10EC6980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002879")]
    [Address(RVA = "0xEC6500", Offset = "0xEC5300", VA = "0x10EC6500", Slot = "5")]
    public JSON_GuildRaidData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidData) null;
    }
  }
}
