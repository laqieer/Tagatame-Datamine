// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_JobSetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E4")]
  public sealed class JSON_JobSetParamFormatter : 
    IMessagePackFormatter<JSON_JobSetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001060")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001061")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AFA")]
    [Address(RVA = "0xB97D20", Offset = "0xB96B20", VA = "0x10B97D20")]
    public JSON_JobSetParamFormatter()
    {
    }

    [Token(Token = "0x6001AFB")]
    [Address(RVA = "0xB978C0", Offset = "0xB966C0", VA = "0x10B978C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_JobSetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AFC")]
    [Address(RVA = "0xB972A0", Offset = "0xB960A0", VA = "0x10B972A0", Slot = "5")]
    public JSON_JobSetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_JobSetParam) null;
    }
  }
}
