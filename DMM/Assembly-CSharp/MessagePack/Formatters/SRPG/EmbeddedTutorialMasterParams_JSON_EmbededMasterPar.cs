// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EmbeddedTutorialMasterParams_JSON_EmbededMasterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200085F")]
  public sealed class EmbeddedTutorialMasterParams_JSON_EmbededMasterParamFormatter : 
    IMessagePackFormatter<EmbeddedTutorialMasterParams.JSON_EmbededMasterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400154E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400154F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600226B")]
    [Address(RVA = "0xD832C0", Offset = "0xD820C0", VA = "0x10D832C0")]
    public EmbeddedTutorialMasterParams_JSON_EmbededMasterParamFormatter()
    {
    }

    [Token(Token = "0x600226C")]
    [Address(RVA = "0xD820B0", Offset = "0xD80EB0", VA = "0x10D820B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EmbeddedTutorialMasterParams.JSON_EmbededMasterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600226D")]
    [Address(RVA = "0xD815B0", Offset = "0xD803B0", VA = "0x10D815B0", Slot = "5")]
    public EmbeddedTutorialMasterParams.JSON_EmbededMasterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EmbeddedTutorialMasterParams.JSON_EmbededMasterParam) null;
    }
  }
}
