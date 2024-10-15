// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FilterRuneConditionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200066C")]
  public sealed class JSON_FilterRuneConditionParamFormatter : 
    IMessagePackFormatter<JSON_FilterRuneConditionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001170")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001171")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C92")]
    [Address(RVA = "0xBE5360", Offset = "0xBE4160", VA = "0x10BE5360")]
    public JSON_FilterRuneConditionParamFormatter()
    {
    }

    [Token(Token = "0x6001C93")]
    [Address(RVA = "0xBE5090", Offset = "0xBE3E90", VA = "0x10BE5090", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FilterRuneConditionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C94")]
    [Address(RVA = "0xBE4BE0", Offset = "0xBE39E0", VA = "0x10BE4BE0", Slot = "5")]
    public JSON_FilterRuneConditionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FilterRuneConditionParam) null;
    }
  }
}
