// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GuildTrainingDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009DC")]
  public sealed class Json_GuildTrainingDataFormatter : 
    IMessagePackFormatter<Json_GuildTrainingData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001848")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001849")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026E2")]
    [Address(RVA = "0xE88660", Offset = "0xE87460", VA = "0x10E88660")]
    public Json_GuildTrainingDataFormatter()
    {
    }

    [Token(Token = "0x60026E3")]
    [Address(RVA = "0xE884C0", Offset = "0xE872C0", VA = "0x10E884C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GuildTrainingData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026E4")]
    [Address(RVA = "0xE88110", Offset = "0xE86F10", VA = "0x10E88110", Slot = "5")]
    public Json_GuildTrainingData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GuildTrainingData) null;
    }
  }
}
