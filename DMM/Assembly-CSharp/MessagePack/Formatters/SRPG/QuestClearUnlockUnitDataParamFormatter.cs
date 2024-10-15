// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.QuestClearUnlockUnitDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000763")]
  public sealed class QuestClearUnlockUnitDataParamFormatter : 
    IMessagePackFormatter<QuestClearUnlockUnitDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400135E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400135F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F77")]
    [Address(RVA = "0xCB2840", Offset = "0xCB1640", VA = "0x10CB2840")]
    public QuestClearUnlockUnitDataParamFormatter()
    {
    }

    [Token(Token = "0x6001F78")]
    [Address(RVA = "0xCB23A0", Offset = "0xCB11A0", VA = "0x10CB23A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      QuestClearUnlockUnitDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F79")]
    [Address(RVA = "0xCB1D80", Offset = "0xCB0B80", VA = "0x10CB1D80", Slot = "5")]
    public QuestClearUnlockUnitDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (QuestClearUnlockUnitDataParam) null;
    }
  }
}
