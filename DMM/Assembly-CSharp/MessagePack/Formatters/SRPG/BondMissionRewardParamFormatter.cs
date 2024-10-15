// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondMissionRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B3E")]
  public sealed class BondMissionRewardParamFormatter : 
    IMessagePackFormatter<BondMissionRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B0C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B0D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002B08")]
    [Address(RVA = "0xF5B320", Offset = "0xF5A120", VA = "0x10F5B320")]
    public BondMissionRewardParamFormatter()
    {
    }

    [Token(Token = "0x6002B09")]
    [Address(RVA = "0xF5B0F0", Offset = "0xF59EF0", VA = "0x10F5B0F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondMissionRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002B0A")]
    [Address(RVA = "0xF5ADB0", Offset = "0xF59BB0", VA = "0x10F5ADB0", Slot = "5")]
    public BondMissionRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondMissionRewardParam) null;
    }
  }
}
