// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GuildTrainingAddFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B18")]
  public sealed class Json_GuildTrainingAddFormatter : 
    IMessagePackFormatter<Json_GuildTrainingAdd>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AC0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AC1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A96")]
    [Address(RVA = "0xF3D480", Offset = "0xF3C280", VA = "0x10F3D480")]
    public Json_GuildTrainingAddFormatter()
    {
    }

    [Token(Token = "0x6002A97")]
    [Address(RVA = "0xF3D320", Offset = "0xF3C120", VA = "0x10F3D320", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GuildTrainingAdd value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A98")]
    [Address(RVA = "0xF3CFD0", Offset = "0xF3BDD0", VA = "0x10F3CFD0", Slot = "5")]
    public Json_GuildTrainingAdd Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GuildTrainingAdd) null;
    }
  }
}
