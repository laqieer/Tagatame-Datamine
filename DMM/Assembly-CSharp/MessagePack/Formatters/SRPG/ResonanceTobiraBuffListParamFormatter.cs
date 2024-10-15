// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceTobiraBuffListParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000982")]
  public sealed class ResonanceTobiraBuffListParamFormatter : 
    IMessagePackFormatter<ResonanceTobiraBuffListParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001794")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001795")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025D4")]
    [Address(RVA = "0xE35670", Offset = "0xE34470", VA = "0x10E35670")]
    public ResonanceTobiraBuffListParamFormatter()
    {
    }

    [Token(Token = "0x60025D5")]
    [Address(RVA = "0xE35440", Offset = "0xE34240", VA = "0x10E35440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceTobiraBuffListParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025D6")]
    [Address(RVA = "0xE35100", Offset = "0xE33F00", VA = "0x10E35100", Slot = "5")]
    public ResonanceTobiraBuffListParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceTobiraBuffListParam) null;
    }
  }
}
