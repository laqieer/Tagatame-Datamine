// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FilterUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200066F")]
  public sealed class JSON_FilterUnitParamFormatter : 
    IMessagePackFormatter<JSON_FilterUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001176")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001177")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C9B")]
    [Address(RVA = "0xBE74F0", Offset = "0xBE62F0", VA = "0x10BE74F0")]
    public JSON_FilterUnitParamFormatter()
    {
    }

    [Token(Token = "0x6001C9C")]
    [Address(RVA = "0xBE7220", Offset = "0xBE6020", VA = "0x10BE7220", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FilterUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C9D")]
    [Address(RVA = "0xBE6E10", Offset = "0xBE5C10", VA = "0x10BE6E10", Slot = "5")]
    public JSON_FilterUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FilterUnitParam) null;
    }
  }
}
