// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VipParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F2")]
  public sealed class JSON_VipParamFormatter : 
    IMessagePackFormatter<JSON_VipParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400107C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400107D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B24")]
    [Address(RVA = "0xBA07A0", Offset = "0xB9F5A0", VA = "0x10BA07A0")]
    public JSON_VipParamFormatter()
    {
    }

    [Token(Token = "0x6001B25")]
    [Address(RVA = "0xBA0590", Offset = "0xB9F390", VA = "0x10BA0590", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VipParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B26")]
    [Address(RVA = "0xBA0190", Offset = "0xB9EF90", VA = "0x10BA0190", Slot = "5")]
    public JSON_VipParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VipParam) null;
    }
  }
}
