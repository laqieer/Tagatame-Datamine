// Decompiled with JetBrains decompiler
// Type: SRPG.Models.MasteryRewardEntranceModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200336D")]
  public class MasteryRewardEntranceModel
  {
    [Token(Token = "0x400F307")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsEnableTime;
    [Token(Token = "0x400F308")]
    [FieldOffset(Offset = "0x9")]
    private bool mIsHomeUnitList;

    [Token(Token = "0x17001F2B")]
    public bool IsEnableTime
    {
      [Token(Token = "0x600E43C"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F2C")]
    public bool IsHomeUnitList
    {
      [Token(Token = "0x600E43D"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F2D")]
    public bool IsOpenMasteryReward
    {
      [Token(Token = "0x600E43E"), Address(RVA = "0xABAB50", Offset = "0xAB9950", VA = "0x10ABAB50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E43F")]
    [Address(RVA = "0xABA9E0", Offset = "0xAB97E0", VA = "0x10ABA9E0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E440")]
    [Address(RVA = "0xABA9E0", Offset = "0xAB97E0", VA = "0x10ABA9E0")]
    public void update()
    {
    }

    [Token(Token = "0x600E441")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MasteryRewardEntranceModel()
    {
    }
  }
}
