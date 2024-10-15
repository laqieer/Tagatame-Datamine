// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePridePotentialParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B31")]
  public sealed class RunePridePotentialParamFormatter : 
    IMessagePackFormatter<RunePridePotentialParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AF2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AF3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AE1")]
    [Address(RVA = "0xF6F980", Offset = "0xF6E780", VA = "0x10F6F980")]
    public RunePridePotentialParamFormatter()
    {
    }

    [Token(Token = "0x6002AE2")]
    [Address(RVA = "0xF6F820", Offset = "0xF6E620", VA = "0x10F6F820", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePridePotentialParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AE3")]
    [Address(RVA = "0xF6F510", Offset = "0xF6E310", VA = "0x10F6F510", Slot = "5")]
    public RunePridePotentialParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePridePotentialParam) null;
    }
  }
}
