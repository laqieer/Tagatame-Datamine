// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitJobListPullDownModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033CF")]
  public class UnitJobListPullDownModel : UnitJobListModel
  {
    [Token(Token = "0x400F56A")]
    [FieldOffset(Offset = "0x1C")]
    private UnitData mData;
    [Token(Token = "0x400F56B")]
    [FieldOffset(Offset = "0x20")]
    private string mOriginalJobID;

    [Token(Token = "0x17002105")]
    public UnitData Data
    {
      [Token(Token = "0x600E7E7"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17002106")]
    public string OriginalJobID
    {
      [Token(Token = "0x600E7E8"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E7E9")]
    [Address(RVA = "0xAD06F0", Offset = "0xACF4F0", VA = "0x10AD06F0")]
    public UnitJobListPullDownModel(bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600E7EA")]
    [Address(RVA = "0xAD0750", Offset = "0xACF550", VA = "0x10AD0750", Slot = "4")]
    public override void Initialize(UnitData unitData)
    {
    }

    [Token(Token = "0x600E7EB")]
    [Address(RVA = "0xAD07C0", Offset = "0xACF5C0", VA = "0x10AD07C0")]
    public bool IsSelectCurrentJob() => new bool();
  }
}
