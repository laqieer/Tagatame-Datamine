// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelPlayerDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000844")]
  public sealed class JSON_DuelPlayerDataFormatter : 
    IMessagePackFormatter<JSON_DuelPlayerData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001518")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001519")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600221A")]
    [Address(RVA = "0xD6CAD0", Offset = "0xD6B8D0", VA = "0x10D6CAD0")]
    public JSON_DuelPlayerDataFormatter()
    {
    }

    [Token(Token = "0x600221B")]
    [Address(RVA = "0xD6C5D0", Offset = "0xD6B3D0", VA = "0x10D6C5D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelPlayerData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600221C")]
    [Address(RVA = "0xD6C030", Offset = "0xD6AE30", VA = "0x10D6C030", Slot = "5")]
    public JSON_DuelPlayerData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelPlayerData) null;
    }
  }
}
