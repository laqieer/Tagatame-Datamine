// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitAutoHpJudgeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B8")]
  public sealed class Unit_UnitAutoHpJudgeFormatter : 
    IMessagePackFormatter<Unit.UnitAutoHpJudge>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001400")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001401")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002076")]
    [Address(RVA = "0xD0DED0", Offset = "0xD0CCD0", VA = "0x10D0DED0")]
    public Unit_UnitAutoHpJudgeFormatter()
    {
    }

    [Token(Token = "0x6002077")]
    [Address(RVA = "0xD0DCF0", Offset = "0xD0CAF0", VA = "0x10D0DCF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitAutoHpJudge value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002078")]
    [Address(RVA = "0xD0D9B0", Offset = "0xD0C7B0", VA = "0x10D0D9B0", Slot = "5")]
    public Unit.UnitAutoHpJudge Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitAutoHpJudge) null;
    }
  }
}
