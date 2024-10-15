// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneBuffDataEvoStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000784")]
  public sealed class RuneBuffDataEvoStateFormatter : 
    IMessagePackFormatter<RuneBuffDataEvoState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FDA")]
    [Address(RVA = "0xCD1090", Offset = "0xCCFE90", VA = "0x10CD1090")]
    public RuneBuffDataEvoStateFormatter()
    {
    }

    [Token(Token = "0x6001FDB")]
    [Address(RVA = "0xCD0EA0", Offset = "0xCCFCA0", VA = "0x10CD0EA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneBuffDataEvoState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FDC")]
    [Address(RVA = "0xCD0B40", Offset = "0xCCF940", VA = "0x10CD0B40", Slot = "5")]
    public RuneBuffDataEvoState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneBuffDataEvoState) null;
    }
  }
}
