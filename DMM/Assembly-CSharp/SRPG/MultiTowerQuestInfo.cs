// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027AA")]
  [AddComponentMenu("UI/MultiTowerQuestInfo")]
  public class MultiTowerQuestInfo : MonoBehaviour
  {
    [Token(Token = "0x400BB82")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject EnemyTemplate;
    [Token(Token = "0x400BB83")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject EnemyRoot;
    [Token(Token = "0x400BB84")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text QuestTitle;
    [Token(Token = "0x400BB85")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text RecommendLv;
    [Token(Token = "0x400BB86")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject DetailObject;
    [Token(Token = "0x400BB87")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject RewardTemplate;
    [Token(Token = "0x400BB88")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject RewardRoot;
    [Token(Token = "0x400BB89")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MultiTowerQuestInfo.eRewardShowType RewardShowType;
    [Token(Token = "0x400BB8A")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject Detail;
    [Token(Token = "0x400BB8B")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> mEnemyObject;
    [Token(Token = "0x400BB8C")]
    [FieldOffset(Offset = "0x34")]
    private List<GameObject> mRewardObject;

    [Token(Token = "0x600B220")]
    [Address(RVA = "0x7642B0", Offset = "0x7630B0", VA = "0x107642B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B221")]
    [Address(RVA = "0x7644A0", Offset = "0x7632A0", VA = "0x107644A0")]
    private void SetEnemy(MultiTowerFloorParam param)
    {
    }

    [Token(Token = "0x600B222")]
    [Address(RVA = "0x764870", Offset = "0x763670", VA = "0x10764870")]
    private void SetReward(MultiTowerFloorParam param)
    {
    }

    [Token(Token = "0x600B223")]
    [Address(RVA = "0x764190", Offset = "0x762F90", VA = "0x10764190")]
    private GameObject CreateRewardObject() => (GameObject) null;

    [Token(Token = "0x600B224")]
    [Address(RVA = "0x7640F0", Offset = "0x762EF0", VA = "0x107640F0")]
    private void BindData(GameObject obj, MultiTowerRewardItem reward)
    {
    }

    [Token(Token = "0x600B225")]
    [Address(RVA = "0x764BC0", Offset = "0x7639C0", VA = "0x10764BC0")]
    public MultiTowerQuestInfo()
    {
    }

    [Token(Token = "0x20027AB")]
    public enum eRewardShowType
    {
      [Token(Token = "0x400BB8E")] TopOnly,
      [Token(Token = "0x400BB8F")] All,
    }
  }
}
