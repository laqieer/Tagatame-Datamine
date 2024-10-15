// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FilterUnitConditionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200066E")]
  public sealed class JSON_FilterUnitConditionParamFormatter : 
    IMessagePackFormatter<JSON_FilterUnitConditionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001174")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001175")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C98")]
    [Address(RVA = "0xBE6990", Offset = "0xBE5790", VA = "0x10BE6990")]
    public JSON_FilterUnitConditionParamFormatter()
    {
    }

    [Token(Token = "0x6001C99")]
    [Address(RVA = "0xBE6640", Offset = "0xBE5440", VA = "0x10BE6640", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FilterUnitConditionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C9A")]
    [Address(RVA = "0xBE6120", Offset = "0xBE4F20", VA = "0x10BE6120", Slot = "5")]
    public JSON_FilterUnitConditionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FilterUnitConditionParam) null;
    }
  }
}
