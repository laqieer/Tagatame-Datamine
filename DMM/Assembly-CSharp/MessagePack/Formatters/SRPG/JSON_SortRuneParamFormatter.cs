// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SortRuneParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000675")]
  public sealed class JSON_SortRuneParamFormatter : 
    IMessagePackFormatter<JSON_SortRuneParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001182")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001183")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CAD")]
    [Address(RVA = "0xBEEC50", Offset = "0xBEDA50", VA = "0x10BEEC50")]
    public JSON_SortRuneParamFormatter()
    {
    }

    [Token(Token = "0x6001CAE")]
    [Address(RVA = "0xBEE9B0", Offset = "0xBED7B0", VA = "0x10BEE9B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SortRuneParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CAF")]
    [Address(RVA = "0xBEE5D0", Offset = "0xBED3D0", VA = "0x10BEE5D0", Slot = "5")]
    public JSON_SortRuneParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SortRuneParam) null;
    }
  }
}
