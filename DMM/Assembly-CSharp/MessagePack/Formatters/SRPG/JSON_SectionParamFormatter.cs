// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SectionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000860")]
  public sealed class JSON_SectionParamFormatter : 
    IMessagePackFormatter<JSON_SectionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001550")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001551")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600226E")]
    [Address(RVA = "0xD8FBF0", Offset = "0xD8E9F0", VA = "0x10D8FBF0")]
    public JSON_SectionParamFormatter()
    {
    }

    [Token(Token = "0x600226F")]
    [Address(RVA = "0xD8F5E0", Offset = "0xD8E3E0", VA = "0x10D8F5E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SectionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002270")]
    [Address(RVA = "0xD8EE90", Offset = "0xD8DC90", VA = "0x10D8EE90", Slot = "5")]
    public JSON_SectionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SectionParam) null;
    }
  }
}
