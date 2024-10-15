// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ShopListItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034EB")]
  public class ShopListItemExhibit : BaseExhibit, IRenderModel<ShopListItemModel>, IRenderModel
  {
    [Token(Token = "0x400FB2B")]
    [FieldOffset(Offset = "0x34")]
    private bool mIsNeedCheckTimer;
    [Token(Token = "0x400FB2C")]
    [FieldOffset(Offset = "0x38")]
    private ShopListItemExhibit.EKey mKey;
    [Token(Token = "0x400FB2D")]
    [FieldOffset(Offset = "0x3C")]
    private float mRefreshInterval;
    [Token(Token = "0x400FB2E")]
    [FieldOffset(Offset = "0x40")]
    private ShopListItemModel mModel;
    [Token(Token = "0x400FB2F")]
    [FieldOffset(Offset = "0x44")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ShopListItemExhibit.EKey), typeof (ShopListItemExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA52")]
    [Address(RVA = "0xAF7480", Offset = "0xAF6280", VA = "0x10AF7480", Slot = "8")]
    public void Render(ShopListItemModel model)
    {
    }

    [Token(Token = "0x600EA53")]
    [Address(RVA = "0xAF7A70", Offset = "0xAF6870", VA = "0x10AF7A70")]
    private void SetTextTimer()
    {
    }

    [Token(Token = "0x600EA54")]
    [Address(RVA = "0xAF79E0", Offset = "0xAF67E0", VA = "0x10AF79E0")]
    private void SetPaidCoinIcon()
    {
    }

    [Token(Token = "0x600EA55")]
    [Address(RVA = "0xAF7850", Offset = "0xAF6650", VA = "0x10AF7850")]
    private void SetCoinNum()
    {
    }

    [Token(Token = "0x600EA56")]
    [Address(RVA = "0xAF7900", Offset = "0xAF6700", VA = "0x10AF7900")]
    private void SetLock()
    {
    }

    [Token(Token = "0x600EA57")]
    [Address(RVA = "0xAF7E10", Offset = "0xAF6C10", VA = "0x10AF7E10")]
    private void Update()
    {
    }

    [Token(Token = "0x600EA58")]
    [Address(RVA = "0xAF7E70", Offset = "0xAF6C70", VA = "0x10AF7E70")]
    public ShopListItemExhibit()
    {
    }

    [Token(Token = "0x20034EC")]
    private enum EKey
    {
      [Token(Token = "0x400FB31")] None,
      [Token(Token = "0x400FB32")] ActivateCoinBg,
      [Token(Token = "0x400FB33")] SetBannerSprite,
      [Token(Token = "0x400FB34")] ActivateBody,
      [Token(Token = "0x400FB35")] SetTextTimer,
      [Token(Token = "0x400FB36")] ActivatePaidCoinObject,
      [Token(Token = "0x400FB37")] SetPaidCoinIcon,
      [Token(Token = "0x400FB38")] SetTextCoinNum,
      [Token(Token = "0x400FB39")] ActivateLockObjectAndText,
    }
  }
}
