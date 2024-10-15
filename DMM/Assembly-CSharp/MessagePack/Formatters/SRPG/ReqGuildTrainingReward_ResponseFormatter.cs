// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildTrainingReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E1")]
  public sealed class ReqGuildTrainingReward_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildTrainingReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001852")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001853")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026F1")]
    [Address(RVA = "0xE8EB30", Offset = "0xE8D930", VA = "0x10E8EB30")]
    public ReqGuildTrainingReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026F2")]
    [Address(RVA = "0xE8E830", Offset = "0xE8D630", VA = "0x10E8E830", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildTrainingReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026F3")]
    [Address(RVA = "0xE8E380", Offset = "0xE8D180", VA = "0x10E8E380", Slot = "5")]
    public ReqGuildTrainingReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildTrainingReward.Response) null;
    }
  }
}
