// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DrawCardParam_DrawInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200065F")]
  public sealed class JSON_DrawCardParam_DrawInfoFormatter : 
    IMessagePackFormatter<JSON_DrawCardParam.DrawInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001156")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001157")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C6B")]
    [Address(RVA = "0xBE11B0", Offset = "0xBDFFB0", VA = "0x10BE11B0")]
    public JSON_DrawCardParam_DrawInfoFormatter()
    {
    }

    [Token(Token = "0x6001C6C")]
    [Address(RVA = "0xBE1050", Offset = "0xBDFE50", VA = "0x10BE1050", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DrawCardParam.DrawInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C6D")]
    [Address(RVA = "0xBE0D00", Offset = "0xBDFB00", VA = "0x10BE0D00", Slot = "5")]
    public JSON_DrawCardParam.DrawInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DrawCardParam.DrawInfo) null;
    }
  }
}
