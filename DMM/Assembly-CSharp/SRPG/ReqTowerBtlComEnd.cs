// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTowerBtlComEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031A5")]
  public class ReqTowerBtlComEnd : WebAPI
  {
    [Token(Token = "0x600DE39")]
    [Address(RVA = "0xA9D6D0", Offset = "0xA9C4D0", VA = "0x10A9D6D0")]
    public ReqTowerBtlComEnd(
      long btlid,
      Unit[] Player,
      Unit[] Enemy,
      int actCount,
      int round,
      byte floor,
      BtlResultTypes result,
      RandDeckResult[] deck,
      Network.ResponseCallback response,
      string trophyprog = null,
      string bingoprog = null,
      int[] missions = null,
      int[] missions_log = null,
      int[] missions_value = null,
      BattleCore.Record record = null)
    {
    }

    [Token(Token = "0x600DE3A")]
    [Address(RVA = "0xA9D5C0", Offset = "0xA9C3C0", VA = "0x10A9D5C0")]
    public void SetValue(ref StringBuilder sb, string name, long value)
    {
    }

    [Token(Token = "0x600DE3B")]
    [Address(RVA = "0xA9D550", Offset = "0xA9C350", VA = "0x10A9D550")]
    public void SetValue(ref StringBuilder sb, string name, string value)
    {
    }

    [Token(Token = "0x600DE3C")]
    [Address(RVA = "0xA9D630", Offset = "0xA9C430", VA = "0x10A9D630")]
    public void SetValue(ref StringBuilder sb, string name, long value, string end)
    {
    }

    [Token(Token = "0x600DE3D")]
    [Address(RVA = "0xA9D680", Offset = "0xA9C480", VA = "0x10A9D680")]
    public void SetValue(ref StringBuilder sb, string name, string value, string end)
    {
    }
  }
}
