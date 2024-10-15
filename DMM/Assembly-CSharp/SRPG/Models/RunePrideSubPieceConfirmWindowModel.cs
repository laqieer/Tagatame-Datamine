// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideSubPieceConfirmWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033BC")]
  public class RunePrideSubPieceConfirmWindowModel
  {
    [Token(Token = "0x400F4F2")]
    [FieldOffset(Offset = "0x8")]
    private int mReplaceNum;
    [Token(Token = "0x400F4F3")]
    [FieldOffset(Offset = "0xC")]
    private string mSubPieceItemName;
    [Token(Token = "0x400F4F4")]
    [FieldOffset(Offset = "0x10")]
    private string mSubPieceItemAmount;

    [Token(Token = "0x170020AC")]
    public int ReplaceNum
    {
      [Token(Token = "0x600E742"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020AD")]
    public string SubPieceItemName
    {
      [Token(Token = "0x600E743"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020AE")]
    public string SubPieceItemAmount
    {
      [Token(Token = "0x600E744"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E745")]
    [Address(RVA = "0xAC7B40", Offset = "0xAC6940", VA = "0x10AC7B40")]
    public void Initialize(int _replace_num, string _item_name, int _amount_num)
    {
    }

    [Token(Token = "0x600E746")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideSubPieceConfirmWindowModel()
    {
    }
  }
}
