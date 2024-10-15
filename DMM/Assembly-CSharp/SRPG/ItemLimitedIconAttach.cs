// Decompiled with JetBrains decompiler
// Type: SRPG.ItemLimitedIconAttach
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200265A")]
  [AddComponentMenu("UI/ItemLimitedIconAttach")]
  public class ItemLimitedIconAttach : MonoBehaviour
  {
    [Token(Token = "0x400B360")]
    [FieldOffset(Offset = "0xC")]
    private GameObject mLimitedIcon;

    [Token(Token = "0x600AB45")]
    [Address(RVA = "0x6E7200", Offset = "0x6E6000", VA = "0x106E7200")]
    public void Refresh(ItemParam _item_param = null)
    {
    }

    [Token(Token = "0x600AB46")]
    [Address(RVA = "0x6E7110", Offset = "0x6E5F10", VA = "0x106E7110")]
    private ItemParam GetItemParam() => (ItemParam) null;

    [Token(Token = "0x600AB47")]
    [Address(RVA = "0x6E6FE0", Offset = "0x6E5DE0", VA = "0x106E6FE0")]
    private void Display()
    {
    }

    [Token(Token = "0x600AB48")]
    [Address(RVA = "0x6E7190", Offset = "0x6E5F90", VA = "0x106E7190")]
    public void Hide()
    {
    }

    [Token(Token = "0x600AB49")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ItemLimitedIconAttach()
    {
    }
  }
}
