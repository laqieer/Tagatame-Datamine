// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029C3")]
  public class RuneReplaceContentParam
  {
    [Token(Token = "0x400CA91")]
    private const int RuneEmpty = -1;
    [Token(Token = "0x400CA92")]
    [FieldOffset(Offset = "0x8")]
    private UnitData mData;
    [Token(Token = "0x400CA93")]
    [FieldOffset(Offset = "0xC")]
    private List<long> mRuneIdList;
    [Token(Token = "0x400CA94")]
    [FieldOffset(Offset = "0x10")]
    private List<bool> mRuneEquipReplaceList;

    [Token(Token = "0x170019A4")]
    public UnitData Data
    {
      [Token(Token = "0x600BDF9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x170019A5")]
    public List<long> RuneIdList
    {
      [Token(Token = "0x600BDFA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<long>) null;
      }
    }

    [Token(Token = "0x170019A6")]
    public List<bool> RuneEquipReplaceList
    {
      [Token(Token = "0x600BDFB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<bool>) null;
      }
    }

    [Token(Token = "0x600BDFC")]
    [Address(RVA = "0x858100", Offset = "0x856F00", VA = "0x10858100")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BDFD")]
    [Address(RVA = "0x858120", Offset = "0x856F20", VA = "0x10858120")]
    public void Initialize(UnitData unit)
    {
    }

    [Token(Token = "0x600BDFE")]
    [Address(RVA = "0x8582B0", Offset = "0x8570B0", VA = "0x108582B0")]
    public void Setup(UnitData unit)
    {
    }

    [Token(Token = "0x600BDFF")]
    [Address(RVA = "0x857E00", Offset = "0x856C00", VA = "0x10857E00")]
    public void Backup()
    {
    }

    [Token(Token = "0x600BE00")]
    [Address(RVA = "0x857F90", Offset = "0x856D90", VA = "0x10857F90")]
    private void Comparison()
    {
    }

    [Token(Token = "0x600BE01")]
    [Address(RVA = "0x857F10", Offset = "0x856D10", VA = "0x10857F10")]
    public void ClearAnimationFlagList()
    {
    }

    [Token(Token = "0x600BE02")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneReplaceContentParam()
    {
    }
  }
}
