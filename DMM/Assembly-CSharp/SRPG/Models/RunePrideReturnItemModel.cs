// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideReturnItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033BB")]
  public class RunePrideReturnItemModel : BaseItemModel
  {
    [Token(Token = "0x400F4F1")]
    [FieldOffset(Offset = "0x20")]
    private int mReturneCount;

    [Token(Token = "0x170020AB")]
    public int ReturnCount
    {
      [Token(Token = "0x600E73E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E73F")]
    [Address(RVA = "0xAC7A80", Offset = "0xAC6880", VA = "0x10AC7A80")]
    public void Initialize(string _item_iname, int _return_count)
    {
    }

    [Token(Token = "0x600E740")]
    [Address(RVA = "0xAC7A70", Offset = "0xAC6870", VA = "0x10AC7A70")]
    public void AddNum(int _add_num)
    {
    }

    [Token(Token = "0x600E741")]
    [Address(RVA = "0xAB1770", Offset = "0xAB0570", VA = "0x10AB1770")]
    public RunePrideReturnItemModel()
    {
    }
  }
}
