// Decompiled with JetBrains decompiler
// Type: SRPG.PickBanPhotonData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BEE")]
  public class PickBanPhotonData
  {
    [Token(Token = "0x6007327")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PickBanPhotonData()
    {
    }

    [Token(Token = "0x2001BEF")]
    [MessagePackObject(true)]
    public class VersusDraftBanMessageData : SceneBattle.MultiPlayRecvData
    {
      [Token(Token = "0x4006BFD")]
      [FieldOffset(Offset = "0x50")]
      public int[] bid;
      [Token(Token = "0x4006BFE")]
      [FieldOffset(Offset = "0x54")]
      public string qstName;

      [Token(Token = "0x6007328")]
      [Address(RVA = "0x37DA60", Offset = "0x37C860", VA = "0x1037DA60")]
      public VersusDraftBanMessageData()
      {
      }
    }

    [Token(Token = "0x2001BF0")]
    public enum VersusDraftBanMessageDataHeader
    {
      [Token(Token = "0x4006C00")] UNIT_BAN,
    }
  }
}
