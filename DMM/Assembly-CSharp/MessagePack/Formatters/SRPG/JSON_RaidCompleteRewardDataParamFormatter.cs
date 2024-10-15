// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidCompleteRewardDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200062C")]
  public sealed class JSON_RaidCompleteRewardDataParamFormatter : 
    IMessagePackFormatter<JSON_RaidCompleteRewardDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BD2")]
    [Address(RVA = "0xBC1E00", Offset = "0xBC0C00", VA = "0x10BC1E00")]
    public JSON_RaidCompleteRewardDataParamFormatter()
    {
    }

    [Token(Token = "0x6001BD3")]
    [Address(RVA = "0xBC1CD0", Offset = "0xBC0AD0", VA = "0x10BC1CD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidCompleteRewardDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BD4")]
    [Address(RVA = "0xBC19C0", Offset = "0xBC07C0", VA = "0x10BC19C0", Slot = "5")]
    public JSON_RaidCompleteRewardDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidCompleteRewardDataParam) null;
    }
  }
}
