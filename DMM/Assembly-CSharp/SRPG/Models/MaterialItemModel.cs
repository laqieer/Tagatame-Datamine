// Decompiled with JetBrains decompiler
// Type: SRPG.Models.MaterialItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200334C")]
  public class MaterialItemModel : BaseItemModel
  {
    [Token(Token = "0x400F215")]
    [FieldOffset(Offset = "0x20")]
    private int requiredAmout;

    [Token(Token = "0x17001E68")]
    public int RequiredAmout
    {
      [Token(Token = "0x600E2F8"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E2F9")]
    [Address(RVA = "0xAB34C0", Offset = "0xAB22C0", VA = "0x10AB34C0")]
    public void Initialize(ItemParam _itemParam, int _requiredAmout)
    {
    }

    [Token(Token = "0x600E2FA")]
    [Address(RVA = "0xAB1770", Offset = "0xAB0570", VA = "0x10AB1770")]
    public MaterialItemModel()
    {
    }
  }
}
