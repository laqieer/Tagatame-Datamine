// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidBossInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000924")]
  public sealed class JSON_GuildRaidBossInfoFormatter : 
    IMessagePackFormatter<JSON_GuildRaidBossInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024BA")]
    [Address(RVA = "0xDFC930", Offset = "0xDFB730", VA = "0x10DFC930")]
    public JSON_GuildRaidBossInfoFormatter()
    {
    }

    [Token(Token = "0x60024BB")]
    [Address(RVA = "0xDFC830", Offset = "0xDFB630", VA = "0x10DFC830", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidBossInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024BC")]
    [Address(RVA = "0xDFC550", Offset = "0xDFB350", VA = "0x10DFC550", Slot = "5")]
    public JSON_GuildRaidBossInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidBossInfo) null;
    }
  }
}
