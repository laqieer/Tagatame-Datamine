// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqTrophyReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ACF")]
  public sealed class ReqTrophyReward_ResponseFormatter : 
    IMessagePackFormatter<ReqTrophyReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A2E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A2F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029BB")]
    [Address(RVA = "0xF16F60", Offset = "0xF15D60", VA = "0x10F16F60")]
    public ReqTrophyReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029BC")]
    [Address(RVA = "0xF16AB0", Offset = "0xF158B0", VA = "0x10F16AB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqTrophyReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029BD")]
    [Address(RVA = "0xF165D0", Offset = "0xF153D0", VA = "0x10F165D0", Slot = "5")]
    public ReqTrophyReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqTrophyReward.Response) null;
    }
  }
}
