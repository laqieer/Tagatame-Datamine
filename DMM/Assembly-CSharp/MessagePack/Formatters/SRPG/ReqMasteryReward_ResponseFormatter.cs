// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqMasteryReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D8")]
  public sealed class ReqMasteryReward_ResponseFormatter : 
    IMessagePackFormatter<ReqMasteryReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001440")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001441")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020D6")]
    [Address(RVA = "0xD1C900", Offset = "0xD1B700", VA = "0x10D1C900")]
    public ReqMasteryReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x60020D7")]
    [Address(RVA = "0xD1C460", Offset = "0xD1B260", VA = "0x10D1C460", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqMasteryReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020D8")]
    [Address(RVA = "0xD1BF60", Offset = "0xD1AD60", VA = "0x10D1BF60", Slot = "5")]
    public ReqMasteryReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqMasteryReward.Response) null;
    }
  }
}
