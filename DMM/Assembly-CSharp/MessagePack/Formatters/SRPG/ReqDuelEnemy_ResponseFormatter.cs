// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDuelEnemy_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000845")]
  public sealed class ReqDuelEnemy_ResponseFormatter : 
    IMessagePackFormatter<ReqDuelEnemy.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400151A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400151B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600221D")]
    [Address(RVA = "0xD798F0", Offset = "0xD786F0", VA = "0x10D798F0")]
    public ReqDuelEnemy_ResponseFormatter()
    {
    }

    [Token(Token = "0x600221E")]
    [Address(RVA = "0xD796C0", Offset = "0xD784C0", VA = "0x10D796C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDuelEnemy.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600221F")]
    [Address(RVA = "0xD79380", Offset = "0xD78180", VA = "0x10D79380", Slot = "5")]
    public ReqDuelEnemy.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDuelEnemy.Response) null;
    }
  }
}
