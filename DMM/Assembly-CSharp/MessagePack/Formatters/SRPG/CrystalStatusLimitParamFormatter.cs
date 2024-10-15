// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalStatusLimitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A52")]
  public sealed class CrystalStatusLimitParamFormatter : 
    IMessagePackFormatter<CrystalStatusLimitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001934")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001935")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002844")]
    [Address(RVA = "0xEBF1E0", Offset = "0xEBDFE0", VA = "0x10EBF1E0")]
    public CrystalStatusLimitParamFormatter()
    {
    }

    [Token(Token = "0x6002845")]
    [Address(RVA = "0xEBF030", Offset = "0xEBDE30", VA = "0x10EBF030", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalStatusLimitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002846")]
    [Address(RVA = "0xEBED50", Offset = "0xEBDB50", VA = "0x10EBED50", Slot = "5")]
    public CrystalStatusLimitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalStatusLimitParam) null;
    }
  }
}
