// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceRewardIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F64")]
  [AddComponentMenu("UI/Advance/AdvanceRewardIcon")]
  public class AdvanceRewardIcon : MonoBehaviour
  {
    [Token(Token = "0x4008461")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRewardUnit;
    [Token(Token = "0x4008462")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRewardItem;
    [Token(Token = "0x4008463")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRewardCard;
    [Token(Token = "0x4008464")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRewardArtifact;
    [Token(Token = "0x4008465")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mRewardAward;
    [Token(Token = "0x4008466")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRewardGold;
    [Token(Token = "0x4008467")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mRewardCoin;

    [Token(Token = "0x60080D6")]
    [Address(RVA = "0x417560", Offset = "0x416360", VA = "0x10417560")]
    public void Initialize(GiftData reward)
    {
    }

    [Token(Token = "0x60080D7")]
    [Address(RVA = "0x417060", Offset = "0x415E60", VA = "0x10417060")]
    public void Initialize(AdvanceRewardDataParam reward)
    {
    }

    [Token(Token = "0x60080D8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceRewardIcon()
    {
    }
  }
}
