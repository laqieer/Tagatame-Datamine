// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FixConceptCardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000701")]
  public sealed class JSON_FixConceptCardParamFormatter : 
    IMessagePackFormatter<JSON_FixConceptCardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400129A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400129B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E51")]
    [Address(RVA = "0xC26E00", Offset = "0xC25C00", VA = "0x10C26E00")]
    public JSON_FixConceptCardParamFormatter()
    {
    }

    [Token(Token = "0x6001E52")]
    [Address(RVA = "0xC26C60", Offset = "0xC25A60", VA = "0x10C26C60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FixConceptCardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E53")]
    [Address(RVA = "0xC268E0", Offset = "0xC256E0", VA = "0x10C268E0", Slot = "5")]
    public JSON_FixConceptCardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FixConceptCardParam) null;
    }
  }
}
