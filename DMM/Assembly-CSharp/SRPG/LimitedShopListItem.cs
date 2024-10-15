// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026D7")]
  [AddComponentMenu("UI/LimitedShopListItem")]
  public class LimitedShopListItem : MonoBehaviour
  {
    [Token(Token = "0x400B68D")]
    [FieldOffset(Offset = "0xC")]
    public JSON_ShopListArray.Shops shops;
    [Token(Token = "0x400B68E")]
    [FieldOffset(Offset = "0x10")]
    public LText l_text;
    [Token(Token = "0x400B68F")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Body;
    [Token(Token = "0x400B690")]
    [FieldOffset(Offset = "0x18")]
    public Text Timer;
    [Token(Token = "0x400B691")]
    [FieldOffset(Offset = "0x20")]
    private long mEndTime;
    [Token(Token = "0x400B692")]
    [FieldOffset(Offset = "0x28")]
    private float mRefreshInterval;
    [Token(Token = "0x400B693")]
    [FieldOffset(Offset = "0x2C")]
    public Image banner;
    [Token(Token = "0x400B694")]
    [FieldOffset(Offset = "0x30")]
    public string banner_sprite;
    [Token(Token = "0x400B695")]
    [FieldOffset(Offset = "0x34")]
    public string shop_cost_iname;
    [Token(Token = "0x400B696")]
    [FieldOffset(Offset = "0x38")]
    public bool btn_update;
    [Token(Token = "0x400B697")]
    [FieldOffset(Offset = "0x3C")]
    public string LimitedShopSpritePath;

    [Token(Token = "0x600ADE5")]
    [Address(RVA = "0x71E170", Offset = "0x71CF70", VA = "0x1071E170")]
    private void Start()
    {
    }

    [Token(Token = "0x600ADE6")]
    [Address(RVA = "0x71E200", Offset = "0x71D000", VA = "0x1071E200")]
    private void Update()
    {
    }

    [Token(Token = "0x600ADE7")]
    [Address(RVA = "0x71DE60", Offset = "0x71CC60", VA = "0x1071DE60")]
    public void SetShopList(JSON_ShopListArray.Shops shops)
    {
    }

    [Token(Token = "0x600ADE8")]
    [Address(RVA = "0x71D9C0", Offset = "0x71C7C0", VA = "0x1071D9C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600ADE9")]
    [Address(RVA = "0x71E1C0", Offset = "0x71CFC0", VA = "0x1071E1C0")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600ADEA")]
    [Address(RVA = "0x71E250", Offset = "0x71D050", VA = "0x1071E250")]
    public LimitedShopListItem()
    {
    }
  }
}
