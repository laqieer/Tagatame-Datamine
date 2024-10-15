// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_JukeBoxParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000689")]
  public sealed class JSON_JukeBoxParamFormatter : 
    IMessagePackFormatter<JSON_JukeBoxParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CE9")]
    [Address(RVA = "0xBFF680", Offset = "0xBFE480", VA = "0x10BFF680")]
    public JSON_JukeBoxParamFormatter()
    {
    }

    [Token(Token = "0x6001CEA")]
    [Address(RVA = "0xBFF2D0", Offset = "0xBFE0D0", VA = "0x10BFF2D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_JukeBoxParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CEB")]
    [Address(RVA = "0xBFED60", Offset = "0xBFDB60", VA = "0x10BFED60", Slot = "5")]
    public JSON_JukeBoxParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_JukeBoxParam) null;
    }
  }
}
