// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisLapBossReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024E9")]
  [AddComponentMenu("UI/Genesis/GenesisLapBossReward")]
  public class GenesisLapBossReward : MonoBehaviour
  {
    [Token(Token = "0x400A896")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mItemName;
    [Token(Token = "0x400A897")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mItemNum;
    [Token(Token = "0x400A898")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mTrIconParent;
    [Token(Token = "0x400A899")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GenesisRewardIcon mRewardIcon;
    [Token(Token = "0x400A89A")]
    [FieldOffset(Offset = "0x1C")]
    private int mIndex;
    [Token(Token = "0x400A89B")]
    [FieldOffset(Offset = "0x20")]
    private GenesisRewardDataParam mReward;

    [Token(Token = "0x170016AC")]
    public int Index
    {
      [Token(Token = "0x600A20E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016AD")]
    public GenesisRewardDataParam Reward
    {
      [Token(Token = "0x600A20F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (GenesisRewardDataParam) null;
      }
    }

    [Token(Token = "0x600A210")]
    [Address(RVA = "0x63C120", Offset = "0x63AF20", VA = "0x1063C120")]
    public void SetItem(int index, GenesisRewardDataParam reward)
    {
    }

    [Token(Token = "0x600A211")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisLapBossReward()
    {
    }
  }
}
