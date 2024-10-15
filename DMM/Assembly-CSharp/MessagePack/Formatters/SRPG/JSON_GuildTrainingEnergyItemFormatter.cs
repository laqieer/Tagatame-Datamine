// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildTrainingEnergyItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000638")]
  public sealed class JSON_GuildTrainingEnergyItemFormatter : 
    IMessagePackFormatter<JSON_GuildTrainingEnergyItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001108")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001109")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BF6")]
    [Address(RVA = "0xBD7020", Offset = "0xBD5E20", VA = "0x10BD7020")]
    public JSON_GuildTrainingEnergyItemFormatter()
    {
    }

    [Token(Token = "0x6001BF7")]
    [Address(RVA = "0xBD6EF0", Offset = "0xBD5CF0", VA = "0x10BD6EF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildTrainingEnergyItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BF8")]
    [Address(RVA = "0xBD6BE0", Offset = "0xBD59E0", VA = "0x10BD6BE0", Slot = "5")]
    public JSON_GuildTrainingEnergyItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildTrainingEnergyItem) null;
    }
  }
}
