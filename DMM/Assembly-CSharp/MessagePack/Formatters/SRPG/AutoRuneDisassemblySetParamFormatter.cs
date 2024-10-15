// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AutoRuneDisassemblySetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000802")]
  public sealed class AutoRuneDisassemblySetParamFormatter : 
    IMessagePackFormatter<AutoRuneDisassemblySetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001494")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001495")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002154")]
    [Address(RVA = "0xD3E7B0", Offset = "0xD3D5B0", VA = "0x10D3E7B0")]
    public AutoRuneDisassemblySetParamFormatter()
    {
    }

    [Token(Token = "0x6002155")]
    [Address(RVA = "0xD3E5D0", Offset = "0xD3D3D0", VA = "0x10D3E5D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AutoRuneDisassemblySetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002156")]
    [Address(RVA = "0xD3E2C0", Offset = "0xD3D0C0", VA = "0x10D3E2C0", Slot = "5")]
    public AutoRuneDisassemblySetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AutoRuneDisassemblySetParam) null;
    }
  }
}
