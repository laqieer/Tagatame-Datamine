// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCombatPowerPlayerRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008BF")]
  public sealed class ReqCombatPowerPlayerRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqCombatPowerPlayerRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400160E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400160F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600238B")]
    [Address(RVA = "0xDC3BF0", Offset = "0xDC29F0", VA = "0x10DC3BF0")]
    public ReqCombatPowerPlayerRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x600238C")]
    [Address(RVA = "0xDC3980", Offset = "0xDC2780", VA = "0x10DC3980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCombatPowerPlayerRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600238D")]
    [Address(RVA = "0xDC3600", Offset = "0xDC2400", VA = "0x10DC3600", Slot = "5")]
    public ReqCombatPowerPlayerRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCombatPowerPlayerRanking.Response) null;
    }
  }
}
