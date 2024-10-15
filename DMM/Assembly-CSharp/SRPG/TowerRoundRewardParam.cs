// Decompiled with JetBrains decompiler
// Type: SRPG.TowerRoundRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D7B")]
  public class TowerRoundRewardParam : TowerRewardParam
  {
    [Token(Token = "0x4007474")]
    [FieldOffset(Offset = "0x10")]
    public List<byte> mRoundList;

    [Token(Token = "0x60078A1")]
    [Address(RVA = "0x3A5C20", Offset = "0x3A4A20", VA = "0x103A5C20")]
    public void Deserialize(JSON_TowerRoundRewardParam json)
    {
    }

    [Token(Token = "0x60078A2")]
    [Address(RVA = "0x3A5ED0", Offset = "0x3A4CD0", VA = "0x103A5ED0", Slot = "4")]
    public override List<TowerRewardItem> GetTowerRewardItem() => (List<TowerRewardItem>) null;

    [Token(Token = "0x60078A3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TowerRoundRewardParam()
    {
    }
  }
}
