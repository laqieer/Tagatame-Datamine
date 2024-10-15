// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondMissionDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C7")]
  public sealed class BondMissionDataFormatter : 
    IMessagePackFormatter<BondMissionData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400181E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400181F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026A3")]
    [Address(RVA = "0xE66AF0", Offset = "0xE658F0", VA = "0x10E66AF0")]
    public BondMissionDataFormatter()
    {
    }

    [Token(Token = "0x60026A4")]
    [Address(RVA = "0xE669B0", Offset = "0xE657B0", VA = "0x10E669B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondMissionData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026A5")]
    [Address(RVA = "0xE666D0", Offset = "0xE654D0", VA = "0x10E666D0", Slot = "5")]
    public BondMissionData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondMissionData) null;
    }
  }
}
