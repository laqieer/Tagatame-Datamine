// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitMapPlacementModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033D9")]
  public class UnitMapPlacementModel
  {
    [Token(Token = "0x400F585")]
    [FieldOffset(Offset = "0x8")]
    private QuestParam mCurrentQuest;

    [Token(Token = "0x17002136")]
    public string QuestName
    {
      [Token(Token = "0x600E83A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E83B"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17002137")]
    public string QuestExpr
    {
      [Token(Token = "0x600E83C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E83D"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x600E83E")]
    [Address(RVA = "0xAD0B40", Offset = "0xACF940", VA = "0x10AD0B40")]
    public void Initialize(QuestParam _quest)
    {
    }

    [Token(Token = "0x600E83F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitMapPlacementModel()
    {
    }
  }
}
