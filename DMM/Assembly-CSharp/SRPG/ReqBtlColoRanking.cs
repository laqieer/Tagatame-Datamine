// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlColoRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003179")]
  public class ReqBtlColoRanking : WebAPI
  {
    [Token(Token = "0x600DE0F")]
    [Address(RVA = "0xA947C0", Offset = "0xA935C0", VA = "0x10A947C0")]
    public ReqBtlColoRanking(ReqBtlColoRanking.RankingTypes type, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200317A")]
    public enum RankingTypes
    {
      [Token(Token = "0x400ED40")] world,
      [Token(Token = "0x400ED41")] friend,
    }
  }
}
