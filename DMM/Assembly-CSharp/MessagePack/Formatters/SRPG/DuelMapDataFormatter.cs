// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DuelMapDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A03")]
  public sealed class DuelMapDataFormatter : 
    IMessagePackFormatter<DuelMapData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001896")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001897")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002757")]
    [Address(RVA = "0xE943A0", Offset = "0xE931A0", VA = "0x10E943A0")]
    public DuelMapDataFormatter()
    {
    }

    [Token(Token = "0x6002758")]
    [Address(RVA = "0xE94230", Offset = "0xE93030", VA = "0x10E94230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DuelMapData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002759")]
    [Address(RVA = "0xE93F20", Offset = "0xE92D20", VA = "0x10E93F20", Slot = "5")]
    public DuelMapData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DuelMapData) null;
    }
  }
}
