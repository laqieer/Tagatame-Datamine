// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGBattleCapture_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008DF")]
  public sealed class ReqGvGBattleCapture_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGBattleCapture.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400164E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400164F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023EB")]
    [Address(RVA = "0xDD93E0", Offset = "0xDD81E0", VA = "0x10DD93E0")]
    public ReqGvGBattleCapture_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023EC")]
    [Address(RVA = "0xDD9110", Offset = "0xDD7F10", VA = "0x10DD9110", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGBattleCapture.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023ED")]
    [Address(RVA = "0xDD8D70", Offset = "0xDD7B70", VA = "0x10DD8D70", Slot = "5")]
    public ReqGvGBattleCapture.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGBattleCapture.Response) null;
    }
  }
}
