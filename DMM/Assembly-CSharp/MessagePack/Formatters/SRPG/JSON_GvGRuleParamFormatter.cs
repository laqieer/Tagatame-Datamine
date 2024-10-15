// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGRuleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A82")]
  public sealed class JSON_GvGRuleParamFormatter : 
    IMessagePackFormatter<JSON_GvGRuleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001994")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001995")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028D4")]
    [Address(RVA = "0xEE1D30", Offset = "0xEE0B30", VA = "0x10EE1D30")]
    public JSON_GvGRuleParamFormatter()
    {
    }

    [Token(Token = "0x60028D5")]
    [Address(RVA = "0xEE1AD0", Offset = "0xEE08D0", VA = "0x10EE1AD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGRuleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028D6")]
    [Address(RVA = "0xEE16A0", Offset = "0xEE04A0", VA = "0x10EE16A0", Slot = "5")]
    public JSON_GvGRuleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGRuleParam) null;
    }
  }
}
