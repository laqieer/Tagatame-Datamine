// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_EvaluationParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E5")]
  public sealed class JSON_EvaluationParamFormatter : 
    IMessagePackFormatter<JSON_EvaluationParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001062")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001063")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AFD")]
    [Address(RVA = "0xB91B30", Offset = "0xB90930", VA = "0x10B91B30")]
    public JSON_EvaluationParamFormatter()
    {
    }

    [Token(Token = "0x6001AFE")]
    [Address(RVA = "0xB917E0", Offset = "0xB905E0", VA = "0x10B917E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_EvaluationParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AFF")]
    [Address(RVA = "0xB912A0", Offset = "0xB900A0", VA = "0x10B912A0", Slot = "5")]
    public JSON_EvaluationParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_EvaluationParam) null;
    }
  }
}
