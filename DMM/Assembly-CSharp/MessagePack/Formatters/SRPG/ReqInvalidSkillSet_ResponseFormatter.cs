// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqInvalidSkillSet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000803")]
  public sealed class ReqInvalidSkillSet_ResponseFormatter : 
    IMessagePackFormatter<ReqInvalidSkillSet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001496")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001497")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002157")]
    [Address(RVA = "0xD4C100", Offset = "0xD4AF00", VA = "0x10D4C100")]
    public ReqInvalidSkillSet_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002158")]
    [Address(RVA = "0xD4BF60", Offset = "0xD4AD60", VA = "0x10D4BF60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqInvalidSkillSet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002159")]
    [Address(RVA = "0xD4BC30", Offset = "0xD4AA30", VA = "0x10D4BC30", Slot = "5")]
    public ReqInvalidSkillSet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqInvalidSkillSet.Response) null;
    }
  }
}
