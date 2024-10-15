// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelMapDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000842")]
  public sealed class JSON_DuelMapDataFormatter : 
    IMessagePackFormatter<JSON_DuelMapData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001514")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001515")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002214")]
    [Address(RVA = "0xD6BEB0", Offset = "0xD6ACB0", VA = "0x10D6BEB0")]
    public JSON_DuelMapDataFormatter()
    {
    }

    [Token(Token = "0x6002215")]
    [Address(RVA = "0xD6BD80", Offset = "0xD6AB80", VA = "0x10D6BD80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelMapData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002216")]
    [Address(RVA = "0xD6BA50", Offset = "0xD6A850", VA = "0x10D6BA50", Slot = "5")]
    public JSON_DuelMapData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelMapData) null;
    }
  }
}
