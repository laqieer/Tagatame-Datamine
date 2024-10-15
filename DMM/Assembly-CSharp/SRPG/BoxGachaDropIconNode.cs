// Decompiled with JetBrains decompiler
// Type: SRPG.BoxGachaDropIconNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020EE")]
  [AddComponentMenu("UI/BoxGacha/BoxGachaDropIconNode")]
  public class BoxGachaDropIconNode : ContentNode
  {
    [Token(Token = "0x4008E65")]
    [FieldOffset(Offset = "0x34")]
    private Animator mAnimator;

    [Token(Token = "0x17001366")]
    public GenesisRewardIcon RewardIcon
    {
      [Token(Token = "0x6008984"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (GenesisRewardIcon) null;
      }
      [Token(Token = "0x6008985"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
    }

    [Token(Token = "0x17001367")]
    public Animator animator
    {
      [Token(Token = "0x6008986"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x6008987")]
    [Address(RVA = "0x4A5050", Offset = "0x4A3E50", VA = "0x104A5050")]
    public void Setup(GenesisRewardDataParam reward)
    {
    }

    [Token(Token = "0x6008988")]
    [Address(RVA = "0x4A4EB0", Offset = "0x4A3CB0", VA = "0x104A4EB0")]
    private void SetupRewardIcon(GenesisRewardDataParam reward)
    {
    }

    [Token(Token = "0x6008989")]
    [Address(RVA = "0x4A4E20", Offset = "0x4A3C20", VA = "0x104A4E20")]
    public void PlayAnim(string anim_trigger)
    {
    }

    [Token(Token = "0x600898A")]
    [Address(RVA = "0x4A4D90", Offset = "0x4A3B90", VA = "0x104A4D90")]
    public bool IsFinishedAnim() => new bool();

    [Token(Token = "0x600898B")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public BoxGachaDropIconNode()
    {
    }
  }
}
