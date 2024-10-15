// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBtlComCombatPowerOpen_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008BE")]
  public sealed class ReqBtlComCombatPowerOpen_ResponseFormatter : 
    IMessagePackFormatter<ReqBtlComCombatPowerOpen.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400160C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400160D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002388")]
    [Address(RVA = "0xDC2A90", Offset = "0xDC1890", VA = "0x10DC2A90")]
    public ReqBtlComCombatPowerOpen_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002389")]
    [Address(RVA = "0xDC2920", Offset = "0xDC1720", VA = "0x10DC2920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBtlComCombatPowerOpen.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600238A")]
    [Address(RVA = "0xDC2650", Offset = "0xDC1450", VA = "0x10DC2650", Slot = "5")]
    public ReqBtlComCombatPowerOpen.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBtlComCombatPowerOpen.Response) null;
    }
  }
}
