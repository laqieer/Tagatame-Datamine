// Decompiled with JetBrains decompiler
// Type: SRPG.AlchemyShopItemCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200251C")]
  [AddComponentMenu("UI/Guild/AlchemyShopItemCategory")]
  public class AlchemyShopItemCategory : MonoBehaviour
  {
    [Token(Token = "0x400A9A3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextTitle;
    [Token(Token = "0x400A9A4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoActive;
    [Token(Token = "0x400A9A5")]
    [FieldOffset(Offset = "0x14")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoLocked;
    [Token(Token = "0x400A9A6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button BtnLock;
    [Token(Token = "0x400A9A7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Space(5f)]
    private SRPG_Button BtnSelect;
    [Token(Token = "0x400A9A8")]
    [FieldOffset(Offset = "0x20")]
    private int mIndex;
    [Token(Token = "0x400A9A9")]
    [FieldOffset(Offset = "0x24")]
    private JSON_ShopListArray.Shops mShop;

    [Token(Token = "0x170016C1")]
    public int Index
    {
      [Token(Token = "0x600A319"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016C2")]
    public JSON_ShopListArray.Shops Shop
    {
      [Token(Token = "0x600A31A"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (JSON_ShopListArray.Shops) null;
      }
    }

    [Token(Token = "0x600A31B")]
    [Address(RVA = "0x6425E0", Offset = "0x6413E0", VA = "0x106425E0")]
    public void SetItem(
      int index,
      JSON_ShopListArray.Shops shop,
      UnityAction action = null,
      UnityAction lock_action = null)
    {
    }

    [Token(Token = "0x600A31C")]
    [Address(RVA = "0x642570", Offset = "0x641370", VA = "0x10642570")]
    public void SetCurrent(bool is_active)
    {
    }

    [Token(Token = "0x600A31D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AlchemyShopItemCategory()
    {
    }
  }
}
