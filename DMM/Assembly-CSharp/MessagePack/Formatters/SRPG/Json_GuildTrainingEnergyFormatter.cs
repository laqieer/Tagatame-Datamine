// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GuildTrainingEnergyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009DD")]
  public sealed class Json_GuildTrainingEnergyFormatter : 
    IMessagePackFormatter<Json_GuildTrainingEnergy>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400184A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400184B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026E5")]
    [Address(RVA = "0xE88D30", Offset = "0xE87B30", VA = "0x10E88D30")]
    public Json_GuildTrainingEnergyFormatter()
    {
    }

    [Token(Token = "0x60026E6")]
    [Address(RVA = "0xE88C00", Offset = "0xE87A00", VA = "0x10E88C00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GuildTrainingEnergy value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026E7")]
    [Address(RVA = "0xE888C0", Offset = "0xE876C0", VA = "0x10E888C0", Slot = "5")]
    public Json_GuildTrainingEnergy Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GuildTrainingEnergy) null;
    }
  }
}
