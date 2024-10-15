// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.PickBanPhotonData_VersusDraftBanMessageDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009AE")]
  public sealed class PickBanPhotonData_VersusDraftBanMessageDataFormatter : 
    IMessagePackFormatter<PickBanPhotonData.VersusDraftBanMessageData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002658")]
    [Address(RVA = "0xE3DBB0", Offset = "0xE3C9B0", VA = "0x10E3DBB0")]
    public PickBanPhotonData_VersusDraftBanMessageDataFormatter()
    {
    }

    [Token(Token = "0x6002659")]
    [Address(RVA = "0xE3D440", Offset = "0xE3C240", VA = "0x10E3D440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PickBanPhotonData.VersusDraftBanMessageData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600265A")]
    [Address(RVA = "0xE3CBA0", Offset = "0xE3B9A0", VA = "0x10E3CBA0", Slot = "5")]
    public PickBanPhotonData.VersusDraftBanMessageData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (PickBanPhotonData.VersusDraftBanMessageData) null;
    }
  }
}
