// Decompiled with JetBrains decompiler
// Type: SRPG.TowerQuestDropItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B4B")]
  [AddComponentMenu("UI/TowerQuestDropItemList")]
  public class TowerQuestDropItemList : QuestDropItemList
  {
    [Token(Token = "0x600C637")]
    [Address(RVA = "0x8EC600", Offset = "0x8EB400", VA = "0x108EC600", Slot = "4")]
    protected override void Refresh()
    {
    }

    [Token(Token = "0x600C638")]
    [Address(RVA = "0x8EC5E0", Offset = "0x8EB3E0", VA = "0x108EC5E0")]
    private bool IsDisableReward(TowerRewardItem reward) => new bool();

    [Token(Token = "0x600C639")]
    [Address(RVA = "0x8EC510", Offset = "0x8EB310", VA = "0x108EC510")]
    private GameObject CreateRewardObject() => (GameObject) null;

    [Token(Token = "0x600C63A")]
    [Address(RVA = "0x8EC260", Offset = "0x8EB060", VA = "0x108EC260")]
    private void BindData(GameObject obj, TowerRewardItem reward, int rewardIndex)
    {
    }

    [Token(Token = "0x600C63B")]
    [Address(RVA = "0x8EC840", Offset = "0x8EB640", VA = "0x108EC840")]
    public TowerQuestDropItemList()
    {
    }
  }
}
