// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AIParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007AE")]
  public sealed class AIParamFormatter : IMessagePackFormatter<AIParam>, IMessagePackFormatter
  {
    [Token(Token = "0x40013EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002058")]
    [Address(RVA = "0xCEAD90", Offset = "0xCE9B90", VA = "0x10CEAD90")]
    public AIParamFormatter()
    {
    }

    [Token(Token = "0x6002059")]
    [Address(RVA = "0xCEA320", Offset = "0xCE9120", VA = "0x10CEA320", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AIParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600205A")]
    [Address(RVA = "0xCE9930", Offset = "0xCE8730", VA = "0x10CE9930", Slot = "5")]
    public AIParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AIParam) null;
    }
  }
}
