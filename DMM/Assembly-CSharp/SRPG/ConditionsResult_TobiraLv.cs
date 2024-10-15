// Decompiled with JetBrains decompiler
// Type: SRPG.ConditionsResult_TobiraLv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EA6")]
  public class ConditionsResult_TobiraLv : ConditionsResult_Unit
  {
    [Token(Token = "0x4002CF5")]
    [FieldOffset(Offset = "0x1C")]
    public int mCondsTobiraLv;
    [Token(Token = "0x4002CF6")]
    [FieldOffset(Offset = "0x20")]
    public TobiraParam.Category mCondsTobiraCategory;
    [Token(Token = "0x4002CF7")]
    [FieldOffset(Offset = "0x24")]
    public TobiraData mTobiraData;
    [Token(Token = "0x4002CF8")]
    [FieldOffset(Offset = "0x28")]
    private bool mTargetIsMaxLevel;

    [Token(Token = "0x170004D0")]
    public override string text
    {
      [Token(Token = "0x6003CF5"), Address(RVA = "0x10F4460", Offset = "0x10F3260", VA = "0x110F4460", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004D1")]
    public override string errorText
    {
      [Token(Token = "0x6003CF6"), Address(RVA = "0x10F4320", Offset = "0x10F3120", VA = "0x110F4320", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003CF7")]
    [Address(RVA = "0x10F4220", Offset = "0x10F3020", VA = "0x110F4220")]
    public ConditionsResult_TobiraLv(
      UnitData unitData,
      UnitParam unitParam,
      TobiraParam.Category condsTobiraCategory,
      int condsTobiraLv)
    {
    }
  }
}
