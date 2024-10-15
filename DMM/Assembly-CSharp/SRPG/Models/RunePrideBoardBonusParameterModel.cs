// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideBoardBonusParameterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033AE")]
  public class RunePrideBoardBonusParameterModel : BaseParameterModel
  {
    [Token(Token = "0x400F492")]
    [FieldOffset(Offset = "0x24")]
    private int bonusNum;
    [Token(Token = "0x400F493")]
    [FieldOffset(Offset = "0x28")]
    private bool isPotential;
    [Token(Token = "0x400F494")]
    [FieldOffset(Offset = "0x29")]
    private bool isViewBonusNum;
    [Token(Token = "0x400F495")]
    [FieldOffset(Offset = "0x2C")]
    private Sprite bonusSprite;

    [Token(Token = "0x1700205A")]
    public int BonusNum
    {
      [Token(Token = "0x600E6B1"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700205B")]
    public bool IsPotential
    {
      [Token(Token = "0x600E6B2"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700205C")]
    public bool IsViewBonusNum
    {
      [Token(Token = "0x600E6B3"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700205D")]
    public Sprite BonusSprite
    {
      [Token(Token = "0x600E6B4"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x600E6B5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void InitializeBonusData(RunePrideBonusData runePrideBonusData, bool isViewBonusNum)
    {
    }

    [Token(Token = "0x600E6B6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void InitializePotentialParam(RunePridePotentialParam bonusPotentialParam)
    {
    }

    [Token(Token = "0x600E6B7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Initialize(int bonusNum)
    {
    }

    [Token(Token = "0x600E6B8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void UpdateBoardBonusNum(int bonusNum)
    {
    }

    [Token(Token = "0x600E6B9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideBoardBonusParameterModel()
    {
    }
  }
}
