// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPieceShopBuyList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CDE")]
  [AddComponentMenu("UI/UnitPieceShopBuyList")]
  public class UnitPieceShopBuyList : MonoBehaviour
  {
    [Token(Token = "0x400DF05")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text amount_text;
    [Token(Token = "0x400DF06")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text cost_text;
    [Token(Token = "0x400DF07")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400DF08")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject soldout;
    [Token(Token = "0x400DF09")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject TimeLimitBase;
    [Token(Token = "0x400DF0A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject TimeLimitPopup;
    [Token(Token = "0x400DF0B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text TimeLimitText;
    [Token(Token = "0x400DF0C")]
    [FieldOffset(Offset = "0x28")]
    private float mRefreshInterval;
    [Token(Token = "0x400DF0D")]
    [FieldOffset(Offset = "0x2C")]
    private UnitPieceShopItem mShopItem;
    [Token(Token = "0x400DF0E")]
    [FieldOffset(Offset = "0x30")]
    private string mDay;
    [Token(Token = "0x400DF0F")]
    [FieldOffset(Offset = "0x34")]
    private string mHour;
    [Token(Token = "0x400DF10")]
    [FieldOffset(Offset = "0x38")]
    private string mMinute;

    [Token(Token = "0x17001B77")]
    private string Day
    {
      [Token(Token = "0x600D0CF"), Address(RVA = "0x9BD9B0", Offset = "0x9BC7B0", VA = "0x109BD9B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001B78")]
    private string Hour
    {
      [Token(Token = "0x600D0D0"), Address(RVA = "0x9BDA30", Offset = "0x9BC830", VA = "0x109BDA30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001B79")]
    private string Minute
    {
      [Token(Token = "0x600D0D1"), Address(RVA = "0x9BDAB0", Offset = "0x9BC8B0", VA = "0x109BDAB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600D0D2")]
    [Address(RVA = "0x9BD750", Offset = "0x9BC550", VA = "0x109BD750")]
    public void SetUp(UnitPieceShopItem shopItem)
    {
    }

    [Token(Token = "0x600D0D3")]
    [Address(RVA = "0x9BD960", Offset = "0x9BC760", VA = "0x109BD960")]
    private void Update()
    {
    }

    [Token(Token = "0x600D0D4")]
    [Address(RVA = "0x9BD200", Offset = "0x9BC000", VA = "0x109BD200")]
    private void RefreshExpire()
    {
    }

    [Token(Token = "0x600D0D5")]
    [Address(RVA = "0x4E6350", Offset = "0x4E5150", VA = "0x104E6350")]
    public UnitPieceShopBuyList()
    {
    }
  }
}
