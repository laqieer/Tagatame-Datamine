// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRuleFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A75")]
  public sealed class JSON_VersusRuleFormatter : 
    IMessagePackFormatter<JSON_VersusRule>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400197A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400197B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028AD")]
    [Address(RVA = "0xECF420", Offset = "0xECE220", VA = "0x10ECF420")]
    public JSON_VersusRuleFormatter()
    {
    }

    [Token(Token = "0x60028AE")]
    [Address(RVA = "0xECF1F0", Offset = "0xECDFF0", VA = "0x10ECF1F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRule value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028AF")]
    [Address(RVA = "0xECEDE0", Offset = "0xECDBE0", VA = "0x10ECEDE0", Slot = "5")]
    public JSON_VersusRule Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRule) null;
    }
  }
}
