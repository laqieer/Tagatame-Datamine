// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitParam_StatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000767")]
  public sealed class UnitParam_StatusFormatter : 
    IMessagePackFormatter<UnitParam.Status>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001366")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001367")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F83")]
    [Address(RVA = "0xCBE030", Offset = "0xCBCE30", VA = "0x10CBE030")]
    public UnitParam_StatusFormatter()
    {
    }

    [Token(Token = "0x6001F84")]
    [Address(RVA = "0xCBDED0", Offset = "0xCBCCD0", VA = "0x10CBDED0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitParam.Status value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F85")]
    [Address(RVA = "0xCBDB90", Offset = "0xCBC990", VA = "0x10CBDB90", Slot = "5")]
    public UnitParam.Status Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (UnitParam.Status) null;
    }
  }
}
