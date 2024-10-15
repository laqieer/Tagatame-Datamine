// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureHistoryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008DE")]
  public sealed class JSON_AdventureHistoryFormatter : 
    IMessagePackFormatter<JSON_AdventureHistory>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400164C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400164D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023E8")]
    [Address(RVA = "0xDCD150", Offset = "0xDCBF50", VA = "0x10DCD150")]
    public JSON_AdventureHistoryFormatter()
    {
    }

    [Token(Token = "0x60023E9")]
    [Address(RVA = "0xDCCE90", Offset = "0xDCBC90", VA = "0x10DCCE90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureHistory value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023EA")]
    [Address(RVA = "0xDCCA80", Offset = "0xDCB880", VA = "0x10DCCA80", Slot = "5")]
    public JSON_AdventureHistory Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureHistory) null;
    }
  }
}
