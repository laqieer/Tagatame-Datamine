// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceLapBossReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F50")]
  [AddComponentMenu("UI/Advance/AdvanceLapBossReward")]
  public class AdvanceLapBossReward : MonoBehaviour
  {
    [Token(Token = "0x40083ED")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mItemName;
    [Token(Token = "0x40083EE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mItemNum;
    [Token(Token = "0x40083EF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mTrIconParent;
    [Token(Token = "0x40083F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AdvanceRewardIcon mRewardIcon;
    [Token(Token = "0x40083F1")]
    [FieldOffset(Offset = "0x1C")]
    private int mIndex;
    [Token(Token = "0x40083F2")]
    [FieldOffset(Offset = "0x20")]
    private AdvanceRewardDataParam mReward;

    [Token(Token = "0x17001264")]
    public int Index
    {
      [Token(Token = "0x6008066"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001265")]
    public AdvanceRewardDataParam Reward
    {
      [Token(Token = "0x6008067"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (AdvanceRewardDataParam) null;
      }
    }

    [Token(Token = "0x6008068")]
    [Address(RVA = "0x40BA70", Offset = "0x40A870", VA = "0x1040BA70")]
    public void SetItem(int index, AdvanceRewardDataParam reward)
    {
    }

    [Token(Token = "0x6008069")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceLapBossReward()
    {
    }
  }
}
