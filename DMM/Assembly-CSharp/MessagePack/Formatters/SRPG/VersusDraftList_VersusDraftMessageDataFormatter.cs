// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.VersusDraftList_VersusDraftMessageDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000800")]
  public sealed class VersusDraftList_VersusDraftMessageDataFormatter : 
    IMessagePackFormatter<VersusDraftList.VersusDraftMessageData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001490")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001491")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600214E")]
    [Address(RVA = "0xD54490", Offset = "0xD53290", VA = "0x10D54490")]
    public VersusDraftList_VersusDraftMessageDataFormatter()
    {
    }

    [Token(Token = "0x600214F")]
    [Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x10D53CD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      VersusDraftList.VersusDraftMessageData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002150")]
    [Address(RVA = "0xD533D0", Offset = "0xD521D0", VA = "0x10D533D0", Slot = "5")]
    public VersusDraftList.VersusDraftMessageData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (VersusDraftList.VersusDraftMessageData) null;
    }
  }
}
