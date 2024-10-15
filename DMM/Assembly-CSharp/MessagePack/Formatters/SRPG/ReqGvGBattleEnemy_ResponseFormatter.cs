// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGBattleEnemy_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD9")]
  public sealed class ReqGvGBattleEnemy_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGBattleEnemy.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A42")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A43")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029D9")]
    [Address(RVA = "0xF28740", Offset = "0xF27540", VA = "0x10F28740")]
    public ReqGvGBattleEnemy_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029DA")]
    [Address(RVA = "0xF28480", Offset = "0xF27280", VA = "0x10F28480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGBattleEnemy.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029DB")]
    [Address(RVA = "0xF28060", Offset = "0xF26E60", VA = "0x10F28060", Slot = "5")]
    public ReqGvGBattleEnemy.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGBattleEnemy.Response) null;
    }
  }
}
