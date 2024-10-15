// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondMissionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B3F")]
  public sealed class BondMissionParamFormatter : 
    IMessagePackFormatter<BondMissionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B0E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B0F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002B0B")]
    [Address(RVA = "0xF5AAE0", Offset = "0xF598E0", VA = "0x10F5AAE0")]
    public BondMissionParamFormatter()
    {
    }

    [Token(Token = "0x6002B0C")]
    [Address(RVA = "0xF5A810", Offset = "0xF59610", VA = "0x10F5A810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondMissionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002B0D")]
    [Address(RVA = "0xF5A4D0", Offset = "0xF592D0", VA = "0x10F5A4D0", Slot = "5")]
    public BondMissionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondMissionParam) null;
    }
  }
}
