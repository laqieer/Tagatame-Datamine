// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneReplaceContentNodeModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003399")]
  public class RuneReplaceContentNodeModel
  {
    [Token(Token = "0x400F439")]
    [FieldOffset(Offset = "0x8")]
    private RuneReplaceContentParam mContentParam;
    [Token(Token = "0x400F43A")]
    [FieldOffset(Offset = "0xC")]
    private UnitModel mUnitModel;
    [Token(Token = "0x400F43B")]
    [FieldOffset(Offset = "0x10")]
    private int mRuneReplaceNum;
    [Token(Token = "0x400F43C")]
    [FieldOffset(Offset = "0x14")]
    private List<RuneSlotExModel> mRuneModelList;

    [Token(Token = "0x1700201F")]
    public UnitModel UnitModel
    {
      [Token(Token = "0x600E5FE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x17002020")]
    public int RuneReplaceNum
    {
      [Token(Token = "0x600E5FF"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E600")]
    [Address(RVA = "0xAC7EF0", Offset = "0xAC6CF0", VA = "0x10AC7EF0")]
    public string GetUnitName() => (string) null;

    [Token(Token = "0x600E601")]
    [Address(RVA = "0xAC7EA0", Offset = "0xAC6CA0", VA = "0x10AC7EA0")]
    public string GetUnitID() => (string) null;

    [Token(Token = "0x600E602")]
    [Address(RVA = "0xAA87D0", Offset = "0xAA75D0", VA = "0x10AA87D0")]
    public UnitData GetUnitData() => (UnitData) null;

    [Token(Token = "0x600E603")]
    [Address(RVA = "0xAC8210", Offset = "0xAC7010", VA = "0x10AC8210")]
    public bool IsEquipChange(int slotNum) => new bool();

    [Token(Token = "0x600E604")]
    [Address(RVA = "0xAC80A0", Offset = "0xAC6EA0", VA = "0x10AC80A0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E605")]
    [Address(RVA = "0xAC7F40", Offset = "0xAC6D40", VA = "0x10AC7F40")]
    public void Initialize(RuneReplaceContentParam contentParam)
    {
    }

    [Token(Token = "0x600E606")]
    [Address(RVA = "0xAC8270", Offset = "0xAC7070", VA = "0x10AC8270")]
    public void Setup(RuneReplaceContentParam param)
    {
    }

    [Token(Token = "0x600E607")]
    [Address(RVA = "0xAC7E40", Offset = "0xAC6C40", VA = "0x10AC7E40")]
    public RuneSlotExModel GetRuneSlotModel(int slotNum) => (RuneSlotExModel) null;

    [Token(Token = "0x600E608")]
    [Address(RVA = "0xAC7D60", Offset = "0xAC6B60", VA = "0x10AC7D60")]
    public void ClearAnimationFlag()
    {
    }

    [Token(Token = "0x600E609")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneReplaceContentNodeModel()
    {
    }
  }
}
