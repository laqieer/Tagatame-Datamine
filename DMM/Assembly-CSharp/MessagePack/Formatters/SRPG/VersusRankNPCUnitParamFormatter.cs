// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.VersusRankNPCUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200096F")]
  public sealed class VersusRankNPCUnitParamFormatter : 
    IMessagePackFormatter<VersusRankNPCUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400176E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400176F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600259B")]
    [Address(RVA = "0xE36B40", Offset = "0xE35940", VA = "0x10E36B40")]
    public VersusRankNPCUnitParamFormatter()
    {
    }

    [Token(Token = "0x600259C")]
    [Address(RVA = "0xE36990", Offset = "0xE35790", VA = "0x10E36990", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      VersusRankNPCUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600259D")]
    [Address(RVA = "0xE36660", Offset = "0xE35460", VA = "0x10E36660", Slot = "5")]
    public VersusRankNPCUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (VersusRankNPCUnitParam) null;
    }
  }
}
