// Decompiled with JetBrains decompiler
// Type: SRPG.Models.MasteryRewardModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003370")]
  public class MasteryRewardModel
  {
    [Token(Token = "0x400F311")]
    [FieldOffset(Offset = "0x8")]
    private string mNowEmblemPath;
    [Token(Token = "0x400F312")]
    [FieldOffset(Offset = "0xC")]
    private int mNowMasteryNum;
    [Token(Token = "0x400F313")]
    [FieldOffset(Offset = "0x10")]
    private string mNextMasteryNum;
    [Token(Token = "0x400F314")]
    [FieldOffset(Offset = "0x14")]
    private float mMasterySliderNum;
    [Token(Token = "0x400F315")]
    [FieldOffset(Offset = "0x18")]
    private float mMasterySliderMin;
    [Token(Token = "0x400F316")]
    [FieldOffset(Offset = "0x1C")]
    private float mMasterySliderMax;
    [Token(Token = "0x400F317")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsAchievementMasteryReward;
    [Token(Token = "0x400F318")]
    [FieldOffset(Offset = "0x21")]
    private bool mIsMax;
    [Token(Token = "0x400F319")]
    [FieldOffset(Offset = "0x24")]
    private List<MasteryRewardData> mMasteryRewardDataList;

    [Token(Token = "0x17001F36")]
    public string NowEmblemPath
    {
      [Token(Token = "0x600E450"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F37")]
    public int NowMasteryNum
    {
      [Token(Token = "0x600E451"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F38")]
    public string NextMasteryNum
    {
      [Token(Token = "0x600E452"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F39")]
    public float MasterySliderNum
    {
      [Token(Token = "0x600E453"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001F3A")]
    public float MasterySliderMin
    {
      [Token(Token = "0x600E454"), Address(RVA = "0x3A3980", Offset = "0x3A2780", VA = "0x103A3980")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001F3B")]
    public float MasterySliderMax
    {
      [Token(Token = "0x600E455"), Address(RVA = "0x3A3950", Offset = "0x3A2750", VA = "0x103A3950")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001F3C")]
    public List<MasteryRewardData> MasteryRewardDataList
    {
      [Token(Token = "0x600E456"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<MasteryRewardData>) null;
      }
    }

    [Token(Token = "0x17001F3D")]
    public bool IsAchievementMasteryReward
    {
      [Token(Token = "0x600E457"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F3E")]
    public bool IsMax
    {
      [Token(Token = "0x600E458"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E459")]
    [Address(RVA = "0xABB0B0", Offset = "0xAB9EB0", VA = "0x10ABB0B0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E45A")]
    [Address(RVA = "0xABB0C0", Offset = "0xAB9EC0", VA = "0x10ABB0C0")]
    public void UpDataParams()
    {
    }

    [Token(Token = "0x600E45B")]
    [Address(RVA = "0xABB2C0", Offset = "0xABA0C0", VA = "0x10ABB2C0")]
    public MasteryRewardModel()
    {
    }
  }
}
