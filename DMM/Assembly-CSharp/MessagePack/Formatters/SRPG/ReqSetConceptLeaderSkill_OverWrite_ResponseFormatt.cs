// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSetConceptLeaderSkill_OverWrite_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F8")]
  public sealed class ReqSetConceptLeaderSkill_OverWrite_ResponseFormatter : 
    IMessagePackFormatter<ReqSetConceptLeaderSkill_OverWrite.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001880")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001881")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002736")]
    [Address(RVA = "0xE91B50", Offset = "0xE90950", VA = "0x10E91B50")]
    public ReqSetConceptLeaderSkill_OverWrite_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002737")]
    [Address(RVA = "0xE919F0", Offset = "0xE907F0", VA = "0x10E919F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSetConceptLeaderSkill_OverWrite.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002738")]
    [Address(RVA = "0xE916B0", Offset = "0xE904B0", VA = "0x10E916B0", Slot = "5")]
    public ReqSetConceptLeaderSkill_OverWrite.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSetConceptLeaderSkill_OverWrite.Response) null;
    }
  }
}
