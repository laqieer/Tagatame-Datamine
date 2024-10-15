// Decompiled with JetBrains decompiler
// Type: SRPG.TowerRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D7A")]
  public class TowerRewardParam
  {
    [Token(Token = "0x4007472")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007473")]
    [FieldOffset(Offset = "0xC")]
    protected List<TowerRewardItem> mTowerRewardItems;

    [Token(Token = "0x600789E")]
    [Address(RVA = "0x3A5A50", Offset = "0x3A4850", VA = "0x103A5A50")]
    public void Deserialize(JSON_TowerRewardParam json)
    {
    }

    [Token(Token = "0x600789F")]
    [Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0", Slot = "4")]
    public virtual List<TowerRewardItem> GetTowerRewardItem() => (List<TowerRewardItem>) null;

    [Token(Token = "0x60078A0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TowerRewardParam()
    {
    }
  }
}
