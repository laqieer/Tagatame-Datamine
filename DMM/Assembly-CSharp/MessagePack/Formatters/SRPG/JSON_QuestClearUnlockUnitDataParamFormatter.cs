// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestClearUnlockUnitDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F7")]
  public sealed class JSON_QuestClearUnlockUnitDataParamFormatter : 
    IMessagePackFormatter<JSON_QuestClearUnlockUnitDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001086")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001087")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B33")]
    [Address(RVA = "0xBA8E40", Offset = "0xBA7C40", VA = "0x10BA8E40")]
    public JSON_QuestClearUnlockUnitDataParamFormatter()
    {
    }

    [Token(Token = "0x6001B34")]
    [Address(RVA = "0xBA8A00", Offset = "0xBA7800", VA = "0x10BA8A00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestClearUnlockUnitDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B35")]
    [Address(RVA = "0xBA8400", Offset = "0xBA7200", VA = "0x10BA8400", Slot = "5")]
    public JSON_QuestClearUnlockUnitDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestClearUnlockUnitDataParam) null;
    }
  }
}
